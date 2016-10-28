using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Anchovy.API.Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anchovy.API.Client.Tests
{
    [TestClass]
    public class CooksTests : AnchovyApiClientTests
    {
        private ICooks _cooks;

        [TestInitialize]
        public void CooksTestInit()
        {
            _cooks = Service.Cooks;
        }

        [TestMethod]
        public async Task GetCooks()
        {
            var getResp = await _cooks.GetCooksWithOperationResponseAsync();
            var cooks = getResp.Body;

            for(int i = 0; i < cooks.Count; ++i)
            {
                Console.WriteLine(cooks[i].FirstName + " " + cooks[i].MiddleName + " " + cooks[i].LastName);
            }
        }
        [TestMethod]
        public async Task PostCook1()
        {
            var burns = new Manager
            {
                Address = "123 Fake Street",
                City = "Springfield",
                Email = "burns@nuclearplant.gov",
                Salary = 10000000000.00,
                FirstName = "Montgomery",
                LastName = "Burns",
                MiddleName = "Bobo"
            };
            var homer = new Cook
            {
                Address = "123 Fake Street",
                City = "Springfield",
                Email = "burns@nuclearplant.gov",
                FirstName = "Homer",
                LastName = "Simpson",
                MiddleName = "Jay",
                HourlyWage = 60000,
                Manager = burns
            };
            var postResponse =  await _cooks.PostCookWithOperationResponseAsync(homer, CancellationToken.None);
            var thing = postResponse.Body;
            var getCooksResponse = _cooks.GetCooksWithOperationResponseAsync(CancellationToken.None);
            var gotCooks = getCooksResponse.Result.Body;
            var postedCook = gotCooks.Where(_ => _.FirstName == "Homer").FirstOrDefault();
            Assert.IsNotNull(postedCook);

        }

        [TestMethod]
        public async Task PostCook2()
        {
            var cook1 = new Cook
            {
                FirstName = "speedy",
                MiddleName = "slim",
                LastName = "spot",
                Address = "see view lane",
                City = "milwaukee",
                Email = "speedy@gmail.com",
                HourlyWage = 12,
                State = "WI",
                Username = "speedster",
                Password = "speedy1234",
                PieceworkRate = 3.5,
                ManagerId = 5
            };

            var cook2 = new Cook
            {
                FirstName = "jimmy",
                MiddleName = "jon",
                LastName = "plank",
                Address = "walk drive",
                City = "milwaukee",
                Email = "jjplank@gmail.com",
                HourlyWage = 15,
                State = "WI",
                Username = "plankjj",
                Password = "kd-3kd$#2",
                PieceworkRate = 4.25,
                ManagerId = 3
            };

            var postResp1 = await _cooks.PostCookWithOperationResponseAsync(cook1);
            var postResp2 = await _cooks.PostCookWithOperationResponseAsync(cook2);
            var gotCooksResp = await _cooks.GetCooksWithOperationResponseAsync();
            var cooksList = gotCooksResp.Body;
            var postedCook1 = cooksList.Where(_ => _.LastName == "spot");
            var postedCook2 = cooksList.Where(_ => _.FirstName == "jimmy");

            Assert.IsNotNull(postedCook1);
            Assert.IsNotNull(postedCook2);

            StringAssert.Equals("slim", postedCook1.First().MiddleName);
            StringAssert.Equals("jon", postedCook2.First().MiddleName);
        }

        [TestMethod]
        public async Task ClearCookTable()
        {
            var cooks = _cooks.GetCooksWithOperationResponseAsync().Result.Body;

            while (cooks.Count > 0)
            {
                var delResp = await _cooks.DeleteCookWithOperationResponseAsync((int)cooks.First().Id);
                var deletedCook = delResp.Body;
                Assert.IsNotNull(deletedCook);
                cooks = _cooks.GetCooksWithOperationResponseAsync().Result.Body;
            }
        }
    }
}
