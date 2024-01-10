//using Microsoft.VisualStudio.TestTools.UnitTesting;
using xmlParserASP.Presistant;

namespace xmlParserASP.Services.Tests;

[TestClass()]
public class UpdateMainXmlTests
{
    GammaContext _gammaContext;

    public UpdateMainXmlTests(GammaContext gammaContext)
    {
        _gammaContext = gammaContext;
    }

    [TestMethod()]
    public void UpdateGammaXmlTest()
    {
        UpdateMainXml ux = new(_gammaContext);

        //var myObj = ux.UpdateGammaXml();

        //Assert.IsNotNull(myObj);
    }
}