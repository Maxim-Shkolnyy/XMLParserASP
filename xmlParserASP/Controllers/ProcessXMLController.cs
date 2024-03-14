using Microsoft.AspNetCore.Mvc;
using xmlParserASP.Models;
using xmlParserASP.Presistant;
using xmlParserASP.Services;
using xmlParserASP.Services.UpdateServices.XmlToGammaUpload_OLD;

namespace xmlParserASP.Controllers;

public class ProcessXMLController : Controller
{
    private readonly GammaContext _gammaContext;
    private readonly ReadAttrFromXmlTo3ColumnsRU _readAttrFromXmlTo3ColumnsRU;
    private readonly ReadAttrFromXmlTo3ColumnsUA _readAttrFromXmlTo3ColumnsUA;
    private readonly WriteToXL _writeToXL;
    private readonly WriteRuToXL _writeToRuToXL;
    private readonly UniqNodesInXML _uniqNodesInXML;
    public ProcessXMLController(ReadAttrFromXmlTo3ColumnsRU readAttrFromXmlTo3ColumnsRU, ReadAttrFromXmlTo3ColumnsUA readAttrFromXmlTo3ColumnsUA, WriteRuToXL writeRuToXL, WriteToXL writeToXL, UniqNodesInXML uniqNodesInXML, GammaContext gammaContext)
    {
        _readAttrFromXmlTo3ColumnsRU=readAttrFromXmlTo3ColumnsRU;
        _readAttrFromXmlTo3ColumnsUA=readAttrFromXmlTo3ColumnsUA;
        _writeToRuToXL=writeRuToXL;
        _writeToXL=writeToXL;
        _uniqNodesInXML=uniqNodesInXML;
        _gammaContext=gammaContext;
    }
    public IActionResult Index()
    {
        var model = new DownloadPhotosViewModel
        {
            SupplierXmlSettings = _gammaContext.MmSupplierXmlSettings.ToList()
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult ProcessUnload(int selectedSupplierXmlSetting)
    {
        _uniqNodesInXML.Read(selectedSupplierXmlSetting);

        var suppSetting = _gammaContext.MmSupplierXmlSettings.FirstOrDefault(s => s.SupplierXmlSettingId==selectedSupplierXmlSetting);
        if (suppSetting != null)
        {
            if (PathModel.Language == Language.Ua)
            {
                _readAttrFromXmlTo3ColumnsUA.ReadAttrTo3(selectedSupplierXmlSetting);

                _writeToXL.WriteSheet(selectedSupplierXmlSetting);
            }
            else
            {
                var writeToXLru = new WriteRuToXL(_gammaContext);
                writeToXLru.WriteRuColumnsToXL(selectedSupplierXmlSetting);

                _readAttrFromXmlTo3ColumnsRU.ReadAttrto3ru(selectedSupplierXmlSetting);
            }
        }

        return View();
    }
}
