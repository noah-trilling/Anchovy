using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Anchovy.API.Client.Models;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Anchovy.API.Client.Tests
{
    [TestClass]
    public class ToppingsTests : AnchovyApiClientTests
    {
        private IToppings _toppings;

        [TestInitialize]
        public void ToppingsTestInit()
        {
            _toppings = Service.Toppings;
        }

        [TestMethod]
        public async Task addTopping()
        {
            var chicken = new Topping
            {
                Name = "chicken",
                Cost = 2,
                Quantity = 100,
                LowLevel =  20
            };


            var postResponse = await _toppings.PostToppingWithOperationResponseAsync(chicken, CancellationToken.None);
            var thing = postResponse.Body;
            var getToppingsResponse = _toppings.GetToppingsWithOperationResponseAsync(CancellationToken.None);
            var gotToppings = getToppingsResponse.Result.Body;
            var postedTopping = gotToppings.Where(_ => _.Name == "chicken").FirstOrDefault();
            Assert.IsNotNull(postedTopping);
        }

        [TestMethod]
        public async Task addTopping2()
        {
            var chicken = new Topping
            {
                Name = "chicken",
                Cost = 2,
                Quantity = 100,
                LowLevel = 20
            };

            var beef = new Topping
            {
                Name = "beef",
                Cost = 3,
                Quantity = 200,
                LowLevel = 50
            };

            var postResp1 = await _toppings.PostToppingWithOperationResponseAsync(chicken);
            var postResp2 = await _toppings.PostToppingWithOperationResponseAsync(beef);
            var gotToppingsResp = await _toppings.GetToppingsWithOperationResponseAsync();
            var toppingList = gotToppingsResp.Body;
            var postedTopping1 = toppingList.Where(_ => _.Name == "chicken");
            var postedTopping2 = toppingList.Where(_ => _.Name == "beef");

            Assert.IsNotNull(postedTopping1);
            Assert.IsNotNull(postedTopping2);

            Assert.AreEqual("chicken", postedTopping1.First().Name);
            Assert.AreEqual("beef", postedTopping2.First().Name);
        }

        [TestMethod]
        public async Task PutTopping()
        {
            var chicken = new Topping
            {
                Name = "chicken",
                Cost = 2,
                Quantity = 100,
                LowLevel = 20
            };

            var postResp = await _toppings.PostToppingWithOperationResponseAsync(chicken);
            var getResp1 = await _toppings.GetToppingsWithOperationResponseAsync();
            var postedTopping = getResp1.Body.Where(_ => _.Name == "chicken").First();

            var beef = new Topping
            {
                Name = "beef",
                Cost = 3,
                Quantity = 200,
                LowLevel = 50,
                Id = postedTopping.Id
            };

            var putResp = await _toppings.PutToppingWithOperationResponseAsync((int)beef.Id, beef);
            var getResp2 = await _toppings.GetToppingWithOperationResponseAsync((int)beef.Id);
            var putTopping = getResp2.Body;

            Assert.IsNotNull(postedTopping);
            Assert.IsNotNull(putTopping);
            Assert.AreEqual("chicken", postedTopping.Name);
            Assert.AreEqual("beef", putTopping.Name);
        }

        [TestMethod]
        public async Task ClearToppingTable()
        {
            var toppings = _toppings.GetToppingsWithOperationResponseAsync().Result.Body;

            while (toppings.Count > 0)
            {
                var delResp = await _toppings.DeleteToppingWithOperationResponseAsync((int)toppings.First().Id);
                var deletedTopping = delResp.Body;
                Assert.IsNotNull(deletedTopping);
                toppings = _toppings.GetToppingsWithOperationResponseAsync().Result.Body;
            }
        }
    }
}
