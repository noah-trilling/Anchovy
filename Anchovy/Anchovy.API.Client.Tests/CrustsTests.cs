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
            Assert.AreEqual("thick",crust.First().Name);    

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
            Assert.AreEqual("extra-spicy", postedCrust1.First().Name);
            Assert.AreEqual("extra-cheesy", postedCrust2.First().Name);

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

            var getResp = await _crusts.GetCrustsWithOperationResponseAsync(CancellationToken.None);
            var gotCrust = getResp.Body;

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
            Assert.AreEqual("regular", postedCrust1.First().Name);
            Assert.AreEqual("cheesy", postedCrust2.First().Name);
            Assert.AreEqual("garlic", postedCrust3.First().Name);
            Assert.AreEqual("spicy", postedCrust4.First().Name);
            Assert.AreEqual("extra-thin", postedCrust5.First().Name);
            Assert.AreEqual("extra-thick", postedCrust6.First().Name);
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

        [TestMethod]
        public async Task PutCrust1()
        {
            Crust crust1 = new Crust
            {
                Cost = 21,
                Name = "test"
            };
                                   
            var postResp = await _crusts.PostCrustWithOperationResponseAsync(crust1);
            var getResp1 = await _crusts.GetCrustsWithOperationResponseAsync();
            var postedCrust = getResp1.Body.Where(_ => _.Name == "test").First();


            Crust crust2 = new Crust
            {
                Cost = 5,
                Id = postedCrust.Id,
                Name = "new crust"
            };

            var putResp = await _crusts.PutCrustWithOperationResponseAsync((int)postedCrust.Id,crust2);
            var getResp2 = await _crusts.GetCrustWithOperationResponseAsync((int)postedCrust.Id);
            var putCrust = getResp2.Body;

            Assert.IsNotNull(postedCrust);
            Assert.IsNotNull(putCrust);
            Assert.AreEqual("test", postedCrust.Name);
            Assert.AreEqual("new crust", putCrust.Name);
        }

        [TestMethod]
        public async Task PutCrust2()
        {
            Crust crust1 = new Crust
            {
                Cost = 21,
                Name = "test1"
            };

           Crust crust2 = new Crust
            {
                Cost = 23,
                Name = "test2"
            };

            var postResp1 = await _crusts.PostCrustWithOperationResponseAsync(crust1);
            var getResp1 = await _crusts.GetCrustsWithOperationResponseAsync();
            var postedCrust1 = getResp1.Body.Where(_ => _.Name == "test1").First();
            var postResp2 = await _crusts.PostCrustWithOperationResponseAsync(crust2);
            var getResp2 = await _crusts.GetCrustsWithOperationResponseAsync();
            var postedCrust2 = getResp2.Body.Where(_ => _.Name == "test2").First();


            Crust crust3 = new Crust
            {
                Cost = 5,
                Id = postedCrust1.Id,
                Name = "new1"
            };

            Crust crust4 = new Crust
            {
                Cost = 3,
                Id = postedCrust2.Id,
                Name = "new2"
            };

            var putResp1 = await _crusts.PutCrustWithOperationResponseAsync((int)postedCrust1.Id, crust3);
            var getResp3 = await _crusts.GetCrustWithOperationResponseAsync((int)postedCrust1.Id);
            var putCrust1 = getResp3.Body;
            var putResp2 = await _crusts.PutCrustWithOperationResponseAsync((int)postedCrust2.Id, crust4);
            var getResp4 = await _crusts.GetCrustWithOperationResponseAsync((int)postedCrust2.Id);
            var putCrust2 = getResp4.Body;

            Assert.IsNotNull(postedCrust1);
            Assert.IsNotNull(postedCrust2);
            Assert.IsNotNull(putCrust1);
            Assert.IsNotNull(putCrust2);
            Assert.AreEqual("test1", postedCrust1.Name);
            Assert.AreEqual("test2", postedCrust2.Name);
            Assert.AreEqual("new1", putCrust1.Name);
            Assert.AreEqual("new2", putCrust2.Name);
        }
    }
}
