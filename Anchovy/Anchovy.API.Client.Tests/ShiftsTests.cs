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
    public class ShiftsTests : AnchovyApiClientTests
    {
        //private IShifts _shift;
        //private IManagers _manager;
        //private ICooks _cook;

        //[TestInitialize]
        //public void ShiftTestInit()
        //{
        //    _shift = Service.Shifts;
        //}

        //[TestMethod]
        //public async Task addShift()
        //{
        //    var burns = new Manager
        //    {
        //        Address = "123 Fake Street",
        //        City = "Springfield",
        //        Email = "burns@nuclearplant.gov",
        //        Salary = 10000000000.00,
        //        FirstName = "Montgomery",
        //        LastName = "Burns",
        //        MiddleName = "Bobo"
        //    };
        //   // var postResponse1 = await _manager.PostManagerWithOperationResponseAsync(burns, CancellationToken.None);

        //    var homer = new Cook
        //    {
        //        Address = "123 Fake Street",
        //        City = "Springfield",
        //        Email = "burns@nuclearplant.gov",
        //        FirstName = "Homer",
        //        LastName = "Simpson",
        //        MiddleName = "Jay",
        //        HourlyWage = 60000,
        //        Manager = burns
        //    };
        //   // var postResponse2 = await _cook.PostCookWithOperationResponseAsync(homer, CancellationToken.None);

        //    var shift1 = new Shift
        //    { 
        //            Id= 0,
        //            //CookId = homer.Id,
        //            Cook= homer,
        //            StartTime = DateTime.Now,
        //            EndTime = DateTime.Now
        //    };

        //    var postResponse = await _shift.PostShiftWithOperationResponseAsync(shift1, CancellationToken.None);
        //    var thing = postResponse.Body;
        //    var getShiftsResponse = _shift.GetShiftsWithOperationResponseAsync(CancellationToken.None);
        //    var gotShifts = getShiftsResponse.Result.Body;
        //    var postedShift = gotShifts.Where(_ => _.Id == shift1.Id).FirstOrDefault();
        //    Assert.IsNotNull(postedShift);
        //}

        //[TestMethod]
        //public async Task addManager2()
        //{
        //    var man1 = new Manager
        //    {
        //        Address = "555 lake rd",
        //        City = "lakeview",
        //        Email = "man1@email.com",
        //        Salary = 50000.00,
        //        FirstName = "Bobby",
        //        LastName = "Ray",
        //        MiddleName = "Etch"
        //    };

        //    var man2 = new Manager
        //    {
        //        Address = "444 lake rd",
        //        City = "lakeview",
        //        Email = "man2@email.com",
        //        Salary = 50000.00,
        //        FirstName = "Jonny",
        //        LastName = "Lynch",
        //        MiddleName = "Cray"
        //    };

        //    var postResp1 = await _managers.PostManagerWithOperationResponseAsync(man1);
        //    var postResp2 = await _managers.PostManagerWithOperationResponseAsync(man2);
        //    var gotManagersResp = await _managers.GetManagersWithOperationResponseAsync();
        //    var managerList = gotManagersResp.Body;
        //    var postedManager1 = managerList.Where(_ => _.LastName == "Ray");
        //    var postedManager2 = managerList.Where(_ => _.FirstName == "Jonny");

        //    Assert.IsNotNull(postedManager1);
        //    Assert.IsNotNull(postedManager2);

        //    Assert.AreEqual("Etch", postedManager1.First().MiddleName);
        //    Assert.AreEqual("Cray", postedManager2.First().MiddleName);
        //}

        //[TestMethod]
        //public async Task PutManager1()
        //{
        //    var jonny = new Manager
        //    {
        //        Address = "444 lake rd",
        //        City = "lakeview",
        //        Email = "jonnycl@email.com",
        //        Salary = 50000.00,
        //        FirstName = "Jonny",
        //        LastName = "Lynch",
        //        MiddleName = "Cray"
        //    };

        //    var postResp = await _managers.PostManagerWithOperationResponseAsync(jonny);
        //    var getResp1 = await _managers.GetManagersWithOperationResponseAsync();
        //    var postedManager = getResp1.Body.Where(_ => _.Email == "jonnycl@email.com").First();

        //    var jake = new Manager
        //    {
        //        Address = "555 lake rd",
        //        City = "lakeview",
        //        Email = "jakycl@email.com",
        //        Salary = 50000.00,
        //        FirstName = "Jake",
        //        LastName = "Lin",
        //        MiddleName = "Dart",
        //        Id = postedManager.Id
        //    };

        //    var putResp = await _managers.PutManagerWithOperationResponseAsync((int)jake.Id, jake);
        //    var getResp2 = await _managers.GetManagerWithOperationResponseAsync((int)jake.Id);
        //    var putManager = getResp2.Body;

        //    Assert.IsNotNull(postedManager);
        //    Assert.IsNotNull(putManager);
        //    Assert.AreEqual("Jonny", postedManager.FirstName);
        //    Assert.AreEqual("Jake", putManager.FirstName);
        //}

        //[TestMethod]
        //public async Task ClearManagerTable()
        //{
        //    var managers = _managers.GetManagersWithOperationResponseAsync().Result.Body;

        //    while (managers.Count > 0)
        //    {
        //        var delResp = await _managers.DeleteManagerWithOperationResponseAsync((int)managers.First().Id);
        //        var deletedManager = delResp.Body;
        //        Assert.IsNotNull(deletedManager);
        //        managers = _managers.GetManagersWithOperationResponseAsync().Result.Body;
        //    }
        //}
    }
}
