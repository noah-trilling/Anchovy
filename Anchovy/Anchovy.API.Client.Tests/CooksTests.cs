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
        public void TestInit()
        {
            _cooks = Service.Cooks;
        }
        [TestMethod]
        public async Task TestObjectLifecycle()
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
            var postResponse = await _cooks.PostCookWithOperationResponseAsync(homer, CancellationToken.None);
            var thing = postResponse.Body;
            var getCooksResponse = _cooks.GetCooksWithOperationResponseAsync(CancellationToken.None);
            var gotCooks = getCooksResponse.Result.Body;
            var postedCook = gotCooks.Where(_ => _.FirstName == "Homer").FirstOrDefault();
            Assert.IsNotNull(postedCook);
        }
    }
}
