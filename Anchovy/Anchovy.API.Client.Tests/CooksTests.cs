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
        private IManagers _managers;

        [TestInitialize]
        public void CooksTestInit()
        {
            _cooks = Service.Cooks;
            _managers = Service.Managers;
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

            var postResponse1 = await _managers.PostManagerWithOperationResponseAsync(burns, CancellationToken.None);
            var gotResponse1 = await _managers.GetManagersWithOperationResponseAsync();
            var gotManagers = gotResponse1.Body;
            var gotManager = gotManagers.Where(_ => _.FirstName == "Montgomery").FirstOrDefault();

            var homer = new Cook
            {
                Address = "123 Fake Street",
                City = "Springfield",
                Email = "burns@nuclearplant.gov",
                FirstName = "Homer",
                LastName = "Simpson",
                MiddleName = "Jay",
                HourlyWage = 60000,
                Manager = gotManager
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

            var gotResponse1 = await _managers.GetManagersWithOperationResponseAsync();
            var gotManagers = gotResponse1.Body;
            var gotManager = gotManagers.Where(_ => _.FirstName == "Montgomery").FirstOrDefault();

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
                ManagerId = gotManager.Id
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
                ManagerId = gotManager.Id
            };

            var postResp1 = await _cooks.PostCookWithOperationResponseAsync(cook1);
            var postResp2 = await _cooks.PostCookWithOperationResponseAsync(cook2);
            var gotCooksResp = await _cooks.GetCooksWithOperationResponseAsync();
            var cooksList = gotCooksResp.Body;
            var postedCook1 = cooksList.Where(_ => _.LastName == "spot");
            var postedCook2 = cooksList.Where(_ => _.FirstName == "jimmy");

            Assert.IsNotNull(postedCook1);
            Assert.IsNotNull(postedCook2);

            Assert.AreEqual("slim", postedCook1.First().MiddleName);
            Assert.AreEqual("jon", postedCook2.First().MiddleName);
        }

        [TestMethod]
        public async Task PostCook3()
        {

            var gotResponse1 = await _managers.GetManagersWithOperationResponseAsync();
            var gotManagers = gotResponse1.Body;
            var gotManager = gotManagers.Where(_ => _.FirstName == "Montgomery").FirstOrDefault();

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
                ManagerId = gotManager.Id
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
                ManagerId = gotManager.Id
            };

            var cook3 = new Cook
            {
                FirstName = "tim",
                MiddleName = "loom",
                LastName = "crom",
                City = "milwaukee",
                Email = "tim@gmail.com",
                HourlyWage = 12,
                State = "WI",
                Username = "timloom",
                Password = "cromtim",
                PieceworkRate = 2,
                ManagerId = gotManager.Id
            };

            var cook4 = new Cook
            {
                FirstName = "jo",
                MiddleName = "arth",
                LastName = "brooks",
                Email = "jjplank@gmail.com",
                HourlyWage = 13,
                State = "WI",
                Username = "arthb",
                Password = "password1",
                PieceworkRate = 2.5,
                ManagerId = gotManager.Id
            };

            var cook5 = new Cook
            {
                FirstName = "steve",
                MiddleName = "dell",
                LastName = "frits",
                City = "milwaukee",
                Email = "fritsd@gmail.com",
                HourlyWage = 14.7,
                State = "WI",
                Username = "fritsy",
                Password = "lsneond",
                PieceworkRate = 3.25,
                ManagerId = gotManager.Id
            };

            var cook6 = new Cook
            {
                FirstName = "kyle",
                MiddleName = "cart",
                LastName = "swiss",
                Email = "kswiss@gmail.com",
                HourlyWage = 15.75,
                State = "WI",
                Username = "kswiss",
                Password = "swissk32",
                PieceworkRate = 3.75,
                ManagerId = gotManager.Id
            };




            var postResp1 = await _cooks.PostCookWithOperationResponseAsync(cook1);
            var postResp2 = await _cooks.PostCookWithOperationResponseAsync(cook2);
            var postResp3 = await _cooks.PostCookWithOperationResponseAsync(cook3);
            var postResp4 = await _cooks.PostCookWithOperationResponseAsync(cook4);
            var postResp5 = await _cooks.PostCookWithOperationResponseAsync(cook5);
            var postResp6 = await _cooks.PostCookWithOperationResponseAsync(cook6);
            var gotCooksResp = await _cooks.GetCooksWithOperationResponseAsync();
            var cooksList = gotCooksResp.Body;
            var postedCook1 = cooksList.Where(_ => _.LastName == "spot");
            var postedCook2 = cooksList.Where(_ => _.LastName == "plank");
            var postedCook3 = cooksList.Where(_ => _.LastName == "crom");
            var postedCook4 = cooksList.Where(_ => _.LastName == "brooks");
            var postedCook5 = cooksList.Where(_ => _.LastName == "frits");
            var postedCook6 = cooksList.Where(_ => _.LastName == "swiss");

            Assert.IsNotNull(postedCook1);
            Assert.IsNotNull(postedCook2);
            Assert.IsNotNull(postedCook3);
            Assert.IsNotNull(postedCook4);
            Assert.IsNotNull(postedCook5);
            Assert.IsNotNull(postedCook6);

            Assert.AreEqual("speedster", postedCook1.First().Username);
            Assert.AreEqual("plankjj", postedCook2.First().Username);
            Assert.AreEqual("timloom", postedCook3.First().Username);
            Assert.AreEqual("arthb", postedCook4.First().Username);
            Assert.AreEqual("fritsy", postedCook5.First().Username);
            Assert.AreEqual("kswiss", postedCook6.First().Username);
        }

        [TestMethod]
        public async Task PutCook1()
        {

            var gotResponse1 = await _managers.GetManagersWithOperationResponseAsync();
            var gotManagers = gotResponse1.Body;
            var gotManager = gotManagers.Where(_ => _.FirstName == "Montgomery").FirstOrDefault();

            var cook1 = new Cook
            {
                FirstName = "silv",
                LastName = "mills",
                City = "milwaukee",
                HourlyWage = 10,
                State = "WI",
                Username = "mills",
                Password = "Password1234",
                PieceworkRate = 3.5,
                ManagerId = gotManager.Id
            };
            var postResp = await _cooks.PostCookWithOperationResponseAsync(cook1);
            var getResp1 = await _cooks.GetCooksWithOperationResponseAsync();
            var postedCook = getResp1.Body.Where(_ => _.Username == "mills").First();

            var cook2 = new Cook
            {
                FirstName = "josh",
                LastName = "james",
                Email = "jjames@gmail.com",
                HourlyWage = 12,
                State = "WI",
                Username = "jamesj",
                Id = postedCook.Id,
                Password = "K#)jlp,nd3",
                PieceworkRate = 3.5,
                ManagerId = gotManager.Id
            };

            var putResp = await _cooks.PutCookWithOperationResponseAsync((int)cook2.Id, cook2);
            var getResp2 = await _cooks.GetCookWithOperationResponseAsync((int)cook2.Id);
            var putCook = getResp2.Body;

            Assert.IsNotNull(postedCook);
            Assert.IsNotNull(putCook);
            Assert.AreEqual("silv", postedCook.FirstName);
            Assert.AreEqual("josh", putCook.FirstName);
        }

        [TestMethod]
        public async Task PutCook2()
        {

            var gotResponse1 = await _managers.GetManagersWithOperationResponseAsync();
            var gotManagers = gotResponse1.Body;
            var gotManager = gotManagers.Where(_ => _.FirstName == "Montgomery").FirstOrDefault();

            var cook1 = new Cook
            {
                FirstName = "trish",
                LastName = "lam",
                Email = "jjames@gmail.com",
                HourlyWage = 12,
                State = "WI",
                Username = "jamesj",
                Password = "K#)jlp,nd3",
                PieceworkRate = 3.5,
                ManagerId = gotManager.Id
            };

            var cook2 = new Cook
            {
                FirstName = "jim",
                LastName = "beam",
                Email = "jjames@gmail.com",
                HourlyWage = 12,
                State = "WI",
                Username = "jamesj",
                Password = "K#)jlp,nd3",
                PieceworkRate = 3.5,
                ManagerId = gotManager.Id
            };

            var postResp1 = await _cooks.PostCookWithOperationResponseAsync(cook1);
            var getResp1 = await _cooks.GetCooksWithOperationResponseAsync();
            var postedCook1 = getResp1.Body.Where(_ => _.LastName == "lam").First();
            var postResp2 = await _cooks.PostCookWithOperationResponseAsync(cook2);
            var getResp2 = await _cooks.GetCooksWithOperationResponseAsync();
            var postedCook2 = getResp2.Body.Where(_ => _.LastName == "beam").First();


            var cook3 = new Cook
            {
                FirstName = "josh",
                LastName = "james",
                Email = "jjames@gmail.com",
                HourlyWage = 12,
                State = "WI",
                Username = "jamesj",
                Id = postedCook1.Id,
                Password = "K#)jlp,nd3",
                PieceworkRate = 3.5,
                ManagerId = gotManager.Id
            };

            var cook4 = new Cook
            {
                FirstName = "mack",
                LastName = "thomas",
                Email = "jjames@gmail.com",
                HourlyWage = 12,
                State = "WI",
                Username = "jamesj",
                Id = postedCook2.Id,
                Password = "K#)jlp,nd3",
                PieceworkRate = 3.5,
                ManagerId = gotManager.Id
            };

            var putResp1 = await _cooks.PutCookWithOperationResponseAsync((int)cook3.Id, cook3);
            var getResp3 = await _cooks.GetCookWithOperationResponseAsync((int)cook3.Id);
            var putCook1 = getResp3.Body;
            var putResp2 = await _cooks.PutCookWithOperationResponseAsync((int)cook4.Id, cook4);
            var getResp4 = await _cooks.GetCookWithOperationResponseAsync((int)cook4.Id);
            var putCook2 = getResp4.Body;

            Assert.IsNotNull(postedCook1);
            Assert.IsNotNull(postedCook2);
            Assert.IsNotNull(putCook1);
            Assert.IsNotNull(putCook2);
            Assert.AreEqual("trish", postedCook1.FirstName);
            Assert.AreEqual("jim", postedCook2.FirstName);
            Assert.AreEqual("josh", putCook1.FirstName);
            Assert.AreEqual("mack", putCook2.FirstName);
        }

        [TestMethod]
        public async Task ClearCookTable()
        {
            var managers = _managers.GetManagersWithOperationResponseAsync().Result.Body;

            while (managers.Count > 0)
            {
                var delResp = await _managers.DeleteManagerWithOperationResponseAsync((int)managers.First().Id);
                var deletedManager = delResp.Body;
                Assert.IsNotNull(deletedManager);
                managers = _managers.GetManagersWithOperationResponseAsync().Result.Body;
            }

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
