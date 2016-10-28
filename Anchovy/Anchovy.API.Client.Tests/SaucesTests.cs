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
    public class SaucesTests : AnchovyApiClientTests
    {
        public ISauces _sauces;

        [TestInitialize]
        public void SauceTestInit()
        {
            _sauces = Service.Sauces;
        }

        [TestMethod]
        public async Task GetSauces()
        {
            var getResp = await _sauces.GetSaucesWithOperationResponseAsync();
            var sauces = getResp.Body;
           
            for(int i = 0; i < sauces.Count; ++i)
            {
                Console.WriteLine(sauces[i].Name);
            }

        }

        [TestMethod]
        public async Task PostSauce1()
        {
            var sauce = new Sauce
            {
                Name = "bbq",
                Cost = 5
            };
            var getResp = await _sauces.PostSauceWithOperationResponseAsync(sauce);
            var gotSauces = _sauces.GetSaucesWithOperationResponseAsync().Result.Body;
            var postedSauce = gotSauces.Where(_ => _.Name == "bbq");

            Assert.IsNotNull(postedSauce);
            Assert.AreEqual("bbq", postedSauce.First().Name);
        }

        [TestMethod]
        public async Task PostSauce2()
        {
            var sauce1 = new Sauce
            {
                Name = "regular",
                Cost = 5
            };
            var sauce2 = new Sauce
            {
                Name = "none",
                Cost = 0
            };


            var getResp1 = await _sauces.PostSauceWithOperationResponseAsync(sauce1);
            var getResp2 = await _sauces.PostSauceWithOperationResponseAsync(sauce2);
            var gotSauces = _sauces.GetSaucesWithOperationResponseAsync().Result.Body;
            var postedSauce1 = gotSauces.Where(_ => _.Name == "regular");
            var postedSauce2 = gotSauces.Where(_ => _.Name == "none");

            Assert.IsNotNull(postedSauce1);
            Assert.IsNotNull(postedSauce2);
            Assert.AreEqual("regular", postedSauce1.First().Name);
            Assert.AreEqual("none", postedSauce2.First().Name);
        }

        [TestMethod]
        public async Task PostSauce3()
        {
            var sauce1 = new Sauce
            {
                Name = "honey-bbq",
                Cost = 5
            };
            var sauce2 = new Sauce
            {
                Name = "terriyaki",
                Cost = 5
            };
            var sauce3 = new Sauce
            {
                Name = "golden-bbq",
                Cost = 5
            };
            var sauce4 = new Sauce
            {
                Name = "jerk",
                Cost = 5
            };
            var sauce5 = new Sauce
            {
                Name = "special-pineapple",
                Cost = 5
            };
            var sauce6 = new Sauce
            {
                Name = "flaming-bbq",
                Cost = 5
            };
            var getResp1 = await _sauces.PostSauceWithOperationResponseAsync(sauce1);
            var getResp2 = await _sauces.PostSauceWithOperationResponseAsync(sauce2);
            var getResp3 = await _sauces.PostSauceWithOperationResponseAsync(sauce3);
            var getResp4 = await _sauces.PostSauceWithOperationResponseAsync(sauce4);
            var getResp5 = await _sauces.PostSauceWithOperationResponseAsync(sauce5);
            var getResp6 = await _sauces.PostSauceWithOperationResponseAsync(sauce6);

            var gotSauces = _sauces.GetSaucesWithOperationResponseAsync().Result.Body;
            var postedSauce1 = gotSauces.Where(_ => _.Name == "honey-bbq").First();
            var postedSauce2 = gotSauces.Where(_ => _.Name == "terriyaki").First();
            var postedSauce3 = gotSauces.Where(_ => _.Name == "golden-bbq").First();
            var postedSauce4 = gotSauces.Where(_ => _.Name == "jerk").First();
            var postedSauce5 = gotSauces.Where(_ => _.Name == "special-pineapple").First();
            var postedSauce6 = gotSauces.Where(_ => _.Name == "flaming-bbq").First();

            Assert.IsNotNull(postedSauce1);
            Assert.IsNotNull(postedSauce2);
            Assert.IsNotNull(postedSauce3);
            Assert.IsNotNull(postedSauce4);
            Assert.IsNotNull(postedSauce5);
            Assert.IsNotNull(postedSauce6);

            Assert.AreEqual("honey-bbq", postedSauce1.Name);
            Assert.AreEqual("terriyaki", postedSauce2.Name);
            Assert.AreEqual("golden-bbq", postedSauce3.Name);
            Assert.AreEqual("jerk", postedSauce4.Name);
            Assert.AreEqual("special-pineapple", postedSauce5.Name);
            Assert.AreEqual("flaming-bbq", postedSauce6.Name);
        }

        [TestMethod]
        public async Task ClearSauceTable()
        {
            var sauces =  _sauces.GetSaucesWithOperationResponseAsync().Result.Body;

            while(sauces.Count > 0){
                var delResp = await _sauces.DeleteSauceWithOperationResponseAsync((int)sauces.First().Id);
                var deletedSauce = delResp.Body;
                Assert.IsNotNull(deletedSauce);
                sauces = _sauces.GetSaucesWithOperationResponseAsync().Result.Body;
            }

        }

        [TestMethod]
        public async Task PutSauce1()
        {
            var sauce1 = new Sauce
            {
                Name = "bbq",
                Cost = 5
            };
            var postResp = await _sauces.PostSauceWithOperationResponseAsync(sauce1);
            var getResp1 = await _sauces.GetSaucesWithOperationResponseAsync();
            var postedSauce = getResp1.Body.Where(_ => _.Name == "bbq").First();

            var sauce2 = new Sauce
            {
                Name = "tomato-sauce",
                Id = postedSauce.Id,
                Cost = 3
            };

            var putResp = await _sauces.PutSauceWithOperationResponseAsync((int)sauce2.Id,sauce2);
            var getResp2 = await _sauces.GetSauceWithOperationResponseAsync((int)sauce2.Id);
            var putSauce = getResp2.Body;

            Assert.IsNotNull(postedSauce);
            Assert.IsNotNull(putSauce);
            Assert.AreEqual("bbq", postedSauce.Name);
            Assert.AreEqual("tomato-sauce", putSauce.Name);
        }

        [TestMethod]
        public async Task PutSauce2()
        {
            Sauce sauce1 = new Sauce
            {
                Cost = 21,
                Name = "bad-sauce"
            };

            Sauce sauce2 = new Sauce
            {
                Cost = 23,
                Name = "null-sauce"
            };

            var postResp1 = await _sauces.PostSauceWithOperationResponseAsync(sauce1);
            var getResp1 = await _sauces.GetSaucesWithOperationResponseAsync();
            var postedSauce1 = getResp1.Body.Where(_ => _.Name == "bad-sauce").First();
            var postResp2 = await _sauces.PostSauceWithOperationResponseAsync(sauce2);
            var getResp2 = await _sauces.GetSaucesWithOperationResponseAsync();
            var postedSauce2 = getResp2.Body.Where(_ => _.Name == "null-sauce").First();


            Sauce sauce3 = new Sauce
            {
                Cost = 5,
                Id = postedSauce1.Id,
                Name = "good-sauce"
            };

            Sauce sauce4 = new Sauce
            {
                Cost = 3,
                Id = postedSauce2.Id,
                Name = "pineapple-sauce"
            };

            var putResp1 = await _sauces.PutSauceWithOperationResponseAsync((int)sauce3.Id, sauce3);
            var getResp3 = await _sauces.GetSauceWithOperationResponseAsync((int)sauce3.Id);
            var putSauce1 = getResp3.Body;
            var putResp2 = await _sauces.PutSauceWithOperationResponseAsync((int)sauce4.Id, sauce4);
            var getResp4 = await _sauces.GetSauceWithOperationResponseAsync((int)sauce4.Id);
            var putSauce2 = getResp4.Body;

            Assert.IsNotNull(postedSauce1);
            Assert.IsNotNull(postedSauce2);
            Assert.IsNotNull(putSauce1);
            Assert.IsNotNull(putSauce2);
            Assert.AreEqual("bad-sauce", postedSauce1.Name);
            Assert.AreEqual("null-sauce", postedSauce2.Name);
            Assert.AreEqual("good-sauce", putSauce1.Name);
            Assert.AreEqual("pineapple-sauce", putSauce2.Name);
        }
    }
}
