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
    public class ManagersTests : AnchovyApiClientTests
    {
        private IManagers _managers;

        [TestInitialize]
        public void ManagersTestInit()
        {
            _managers = Service.Managers;
        }

        [TestMethod]
        public async Task addManager()
        {
            var bobby = new Manager
            {
                Address = "555 lake rd",
                City = "lakeview",
                Email = "bobbyg@email.com",
                Salary = 50000.00,
                FirstName = "Bobby",
                LastName = "Ray",
                MiddleName = "Etch"
            };

            var postResponse = await _managers.PostManagerWithOperationResponseAsync(bobby, CancellationToken.None);
            var thing = postResponse.Body;
            var getManagersResponse = _managers.GetManagersWithOperationResponseAsync(CancellationToken.None);
            var gotMangers = getManagersResponse.Result.Body;
            var postedCook = gotMangers.Where(_ => _.FirstName == "Bobby").FirstOrDefault();
            Assert.IsNotNull(postedCook);
        }

        [TestMethod]
        public async Task addManager2()
        {
            var man1 = new Manager
            {
                Address = "555 lake rd",
                City = "lakeview",
                Email = "man1@email.com",
                Salary = 50000.00,
                FirstName = "Bobby",
                LastName = "Ray",
                MiddleName = "Etch"
            };

            var man2 = new Manager
            {
                Address = "444 lake rd",
                City = "lakeview",
                Email = "man2@email.com",
                Salary = 50000.00,
                FirstName = "Jonny",
                LastName = "Lynch",
                MiddleName = "Cray"
            };

            var postResp1 = await _managers.PostManagerWithOperationResponseAsync(man1);
            var postResp2 = await _managers.PostManagerWithOperationResponseAsync(man2);
            var gotManagersResp = await _managers.GetManagersWithOperationResponseAsync();
            var managerList = gotManagersResp.Body;
            var postedManager1 = managerList.Where(_ => _.LastName == "Ray");
            var postedManager2 = managerList.Where(_ => _.FirstName == "Jonny");
             
            Assert.IsNotNull(postedManager1);
            Assert.IsNotNull(postedManager2);

            Assert.AreEqual("Etch", postedManager1.First().MiddleName);
            Assert.AreEqual("Cray", postedManager2.First().MiddleName);
        }

        [TestMethod]
        public async Task PutManager1()
        {
            var jonny = new Manager
            {
                Address = "444 lake rd",
                City = "lakeview",
                Email = "jonnycl@email.com",
                Salary = 50000.00,
                FirstName = "Jonny",
                LastName = "Lynch",
                MiddleName = "Cray"
            };

            var postResp = await _managers.PostManagerWithOperationResponseAsync(jonny);
            var getResp1 = await _managers.GetManagersWithOperationResponseAsync();
            var postedManager = getResp1.Body.Where(_ => _.Email == "jonnycl@email.com").First();

            var jake = new Manager
            {
                Address = "555 lake rd",
                City = "lakeview",
                Email = "jakycl@email.com",
                Salary = 50000.00,
                FirstName = "Jake",
                LastName = "Lin",
                MiddleName = "Dart",
                Id = postedManager.Id
            };

            var putResp = await _managers.PutManagerWithOperationResponseAsync((int)jake.Id, jake);
            var getResp2 = await _managers.GetManagerWithOperationResponseAsync((int)jake.Id);
            var putManager = getResp2.Body;

            Assert.IsNotNull(postedManager);
            Assert.IsNotNull(putManager);
            Assert.AreEqual("Jonny", postedManager.FirstName);
            Assert.AreEqual("Jake", putManager.FirstName);
        }

        [TestMethod]
        public async Task ClearManagerTable()
        {
            var managers = _managers.GetManagersWithOperationResponseAsync().Result.Body;

            while (managers.Count > 0)
            {
                var delResp = await _managers.DeleteManagerWithOperationResponseAsync((int)managers.First().Id);
                var deletedManager = delResp.Body;
                Assert.IsNotNull(deletedManager);
                managers = _managers.GetManagersWithOperationResponseAsync().Result.Body;
            }
        }

    }
}
