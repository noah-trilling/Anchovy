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
            StringAssert.Equals("bbq", postedSauce.First().Name);
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
            StringAssert.Equals("regular", postedSauce1.First().Name);
            StringAssert.Equals("none", postedSauce2.First().Name);
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
            var postedSauce1 = gotSauces.Where(_ => _.Name == "honey-bbq");
            var postedSauce2 = gotSauces.Where(_ => _.Name == "terriyaki");
            var postedSauce3 = gotSauces.Where(_ => _.Name == "golden-bbq");
            var postedSauce4 = gotSauces.Where(_ => _.Name == "jerk");
            var postedSauce5 = gotSauces.Where(_ => _.Name == "special-pineapple");
            var postedSauce6 = gotSauces.Where(_ => _.Name == "flaming-bbq");

            Assert.IsNotNull(postedSauce1);
            Assert.IsNotNull(postedSauce2);
            Assert.IsNotNull(postedSauce3);
            Assert.IsNotNull(postedSauce4);
            Assert.IsNotNull(postedSauce5);
            Assert.IsNotNull(postedSauce6);

            StringAssert.Equals("honey-bbq", postedSauce1.First().Name);
            StringAssert.Equals("terriyaki", postedSauce1.First().Name);
            StringAssert.Equals("golden-bbq", postedSauce1.First().Name);
            StringAssert.Equals("jerk", postedSauce1.First().Name);
            StringAssert.Equals("special-pineapple", postedSauce1.First().Name);
            StringAssert.Equals("flaming-bbq", postedSauce1.First().Name);
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
    }
}
