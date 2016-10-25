using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anchovy.API.Client.Tests
{
    [TestClass]
    public class AnchovyApiClientTests
    {
        protected AnchovyAPIService Service;

        [TestInitialize]
        public void BaseTestInit()
        {
            Service = new AnchovyAPIService();
        }
        
    }
}
