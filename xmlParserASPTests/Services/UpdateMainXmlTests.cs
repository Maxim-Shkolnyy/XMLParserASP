using Microsoft.VisualStudio.TestTools.UnitTesting;
using xmlParserASP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xmlParserASP.Presistant;
using xmlParserASP.Entities.Gamma;

namespace xmlParserASP.Services.Tests
{
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
}