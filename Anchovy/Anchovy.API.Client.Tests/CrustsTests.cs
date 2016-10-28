using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Anchovy.API.Client.Models;

namespace Anchovy.API.Client.Tests
{
  
    [TestClass]
    public class CrustsTests : AnchovyApiClientTests
    {
        public ICrusts _crusts;

        [TestInitialize]
        public void CrustsTestInit()
        {
            _crusts = Service.Crusts;
        }


        [TestMethod]
        public async Task GetCrust1()
        {         
            var getResp = await _crusts.GetCrustsWithOperationResponseAsync(CancellationToken.None);
            var gotCrust = getResp.Body;
            for (int i = 0; i < gotCrust.Count; ++i)
            {
                Console.WriteLine(gotCrust[i].Name);
            }
        }

        [TestMethod]
        public async Task PostCrust1()
        {
            var crust1 = new Crust
            {
                Cost = 20,
                Id = 2,
                Name = "thick"
            };
                                  
            var postResp = await _crusts.PostCrustWithOperationResponseAsync(crust1,CancellationToken.None);
            var obj = postResp.Body;
            var getResp =  _crusts.GetCrustsWithOperationResponseAsync(CancellationToken.None);
            var gotCrust = getResp.Result.Body;
            var crust = gotCrust.Where(_ => _.Name == "thick");
            Assert.IsNotNull(crust);
            StringAssert.Equals("thick",crust.First().Name);    

        }

        [TestMethod]
        public async Task PostCrust2()
        {
            var crust1 = new Crust
            {
                Cost = 14,
                Name = "extra-spicy"
            };

            var crust2 = new Crust
            {
                Cost = 18,
                Name = "extra-cheesy"
            };

            var postResp1 = await _crusts.PostCrustWithOperationResponseAsync(crust1, CancellationToken.None);
            var postResp2 = await _crusts.PostCrustWithOperationResponseAsync(crust2);
            var getResp = _crusts.GetCrustsWithOperationResponseAsync(CancellationToken.None);
            var gotCrust = getResp.Result.Body;
            var postedCrust1 = gotCrust.Where(_ => _.Name == "extra-spicy");
            var postedCrust2 = gotCrust.Where(_ => _.Name == "extra-cheesy");
            Assert.IsNotNull(crust1);
            Assert.IsNotNull(crust2);
            StringAssert.Equals("extra-spicy", postedCrust1.First().Name);
            StringAssert.Equals("extra-cheesy", postedCrust2.First().Name);

        }

        [TestMethod]
        public async Task PostCrust3()
        {
            var crust1 = new Crust
            {
                Cost = 10,
                Name = "regular"
            };

            var crust2 = new Crust
            {
                Cost = 15,
                Name = "cheesy"
            };

            var crust3 = new Crust
            {
                Cost = 12,
                Name = "garlic"
            };

            var crust4 = new Crust
            {
                Cost = 12,
                Name = "spicy"
            };
            var crust5 = new Crust
            {
                Cost = 12,
                Name = "extra-thin"
            };

            var crust6 = new Crust
            {
                Cost = 17,
                Name = "extra-thick"
            };

            var postResp1 = await _crusts.PostCrustWithOperationResponseAsync(crust1);
            var postResp2 = await _crusts.PostCrustWithOperationResponseAsync(crust2);
            var postResp3 = await _crusts.PostCrustWithOperationResponseAsync(crust3);
            var postResp4 = await _crusts.PostCrustWithOperationResponseAsync(crust4);
            var postResp5 = await _crusts.PostCrustWithOperationResponseAsync(crust5);
            var postResp6 = await _crusts.PostCrustWithOperationResponseAsync(crust6);

            var getResp = _crusts.GetCrustsWithOperationResponseAsync(CancellationToken.None);
            var gotCrust = getResp.Result.Body;

            var postedCrust1 = gotCrust.Where(_ => _.Name == "regular");
            var postedCrust2 = gotCrust.Where(_ => _.Name == "cheesy");
            var postedCrust3 = gotCrust.Where(_ => _.Name == "garlic");
            var postedCrust4 = gotCrust.Where(_ => _.Name == "spicy");
            var postedCrust5 = gotCrust.Where(_ => _.Name == "extra-thin");
            var postedCrust6 = gotCrust.Where(_ => _.Name == "extra-thick");

            Assert.IsNotNull(crust1);
            Assert.IsNotNull(crust2);
            Assert.IsNotNull(crust3);
            Assert.IsNotNull(crust4);
            Assert.IsNotNull(crust5);
            Assert.IsNotNull(crust6);
            StringAssert.Equals("regular", postedCrust1.First().Name);
            StringAssert.Equals("cheesy", postedCrust2.First().Name);
            StringAssert.Equals("garlic", postedCrust3.First().Name);
            StringAssert.Equals("spicy", postedCrust4.First().Name);
            StringAssert.Equals("extra-thin", postedCrust5.First().Name);
            StringAssert.Equals("extra-thick", postedCrust6.First().Name);
        }

        [TestMethod]
        public async Task ClearCrustTable()
        {
            var gotCrust = _crusts.GetCrustsWithOperationResponseAsync(CancellationToken.None).Result.Body;
            while(gotCrust.Count > 0)
            {
                var delResp = await _crusts.DeleteCrustWithOperationResponseAsync((int)gotCrust.First().Id);
                var deletedCrust = delResp.Body;
                Assert.IsNotNull(deletedCrust);
                gotCrust = _crusts.GetCrustsWithOperationResponseAsync(CancellationToken.None).Result.Body;
            }
        }

        [TestCleanup]
        public void tearDown()
        {

        }
    }
}
