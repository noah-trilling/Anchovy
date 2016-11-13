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
        //    _manager = Service.Managers;
        //    _cook = Service.Cooks;

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

        //    var postResponse1 = _manager.PostManagerWithOperationResponseAsync(burns, CancellationToken.None);

        //    var gotResponseM = _manager.GetManagers();
        //    // var gotManagers = gotResponseM.;
        //    var gotManager = gotResponseM.Where(_ => _.FirstName == "Montgomery").FirstOrDefault();

        //    var homer = new Cook
        //    {
        //        Address = "123 Fake Street",
        //        City = "Springfield",
        //        Email = "burns@nuclearplant.gov",
        //        FirstName = "Homer",
        //        LastName = "Simpson",
        //        MiddleName = "Jay",
        //        HourlyWage = 60000,
        //        Manager = gotManager
        //    };
        //    var postResponseC = _cook.PostCookWithOperationResponseAsync(homer, CancellationToken.None);


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

        //    var postResponse1 = _manager.PostManagerWithOperationResponseAsync(burns, CancellationToken.None);

        //    var gotResponseM = _manager.GetManagers();
        //    // var gotManagers = gotResponseM.;
        //    var gotManager = gotResponseM.Where(_ => _.FirstName == "Montgomery").FirstOrDefault();

        //    var homer = new Cook
        //    {
        //        Address = "123 Fake Street",
        //        City = "Springfield",
        //        Email = "burns@nuclearplant.gov",
        //        FirstName = "Homer",
        //        LastName = "Simpson",
        //        MiddleName = "Jay",
        //        HourlyWage = 60000,
        //        Manager = gotManager
        //    };
        //    var postResponseC = _cook.PostCookWithOperationResponseAsync(homer, CancellationToken.None);

        //    //var gotResponseM = await _manager.GetManagersWithOperationResponseAsync();
        //    //var gotManagers = gotResponseM.Body;
        //    //var gotManager = gotManagers.Where(_ => _.FirstName == "Montgomery").FirstOrDefault();
        //    //var homer = new Cook
        //    //{
        //    //    Address = "123 Fake Street",
        //    //    City = "Springfield",
        //    //    Email = "burns@nuclearplant.gov",
        //    //    FirstName = "Homer",
        //    //    LastName = "Simpson",
        //    //    MiddleName = "Jay",
        //    //    HourlyWage = 60000,
        //    //    Manager = gotManager
        //    //};
        //    //var postResponseC = await _cook.PostCookWithOperationResponseAsync(homer, CancellationToken.None);

        //    var gotResponseC = await _cook.GetCooksWithOperationResponseAsync();
        //    var gotCooks = gotResponseC.Body;
        //    var gotCook = gotCooks.Where(_ => _.FirstName == "Homer").FirstOrDefault();

        //    var shift1 = new Shift
        //    {
        //        Id = 0,
        //        CookId = gotCook.Id,
        //        Cook = gotCook,
        //        StartTime = DateTime.Now,
        //        EndTime = DateTime.Now
        //    };

        //    var postResponseS = await _shift.PostShiftWithOperationResponseAsync(shift1, CancellationToken.None);
        //    // var thing = postResponseS.Body;
        //    var getShiftsResponse = _shift.GetShiftsWithOperationResponseAsync(CancellationToken.None);
        //    var gotShifts = getShiftsResponse.Result.Body;
        //    var gotShift = gotShifts.First();
        //    var postedShift = gotShifts.Where(_ => _.Id == gotShift.Id).FirstOrDefault();
        //    Assert.IsNotNull(postedShift);
        //}


        //[TestMethod]
        //public async Task PutShift1()
        //{

        //    var gotResponseC = await _cook.GetCooksWithOperationResponseAsync();
        //    var gotCooks = gotResponseC.Body;
        //    var gotCook = gotCooks.Where(_ => _.FirstName == "Homer").FirstOrDefault();

        //    var shift1 = new Shift
        //    {
        //        Id = 0,
        //        CookId = gotCook.Id,
        //        Cook = gotCook,
        //        StartTime = DateTime.Now,
        //        EndTime = DateTime.Now
        //    };

        //    var postResponseS = await _shift.PostShiftWithOperationResponseAsync(shift1, CancellationToken.None);
        //    var getShiftsResponse = await _shift.GetShiftsWithOperationResponseAsync(CancellationToken.None);
        //    var gotShifts = getShiftsResponse.Body;
        //    var gotShift = gotShifts.First();
        //    var postedShift = gotShifts.Where(_ => _.Id == gotShift.Id).FirstOrDefault();



        //    var shift2 = new Shift
        //    {

        //        CookId = gotCook.Id,
        //        Cook = gotCook,
        //        StartTime = DateTime.Now,
        //        EndTime = DateTime.Now,
        //        Id = postedShift.Id
        //    };

        //    var putResp = await _shift.PutShiftWithOperationResponseAsync((int)shift2.Id, shift2);
        //    var getResp2 = await _shift.GetShiftWithOperationResponseAsync((int)shift2.Id);
        //    var putShift = getResp2.Body;

        //    Assert.IsNotNull(postedShift);
        //    Assert.IsNotNull(putShift);
        //    Assert.AreEqual(gotCook.Id, postedShift.CookId);
        //    Assert.AreEqual(gotCook.Id, putShift.CookId);
        //}

        //[TestMethod]
        //public async Task ClearShiftTable()
        //{
        //    var managers = _manager.GetManagersWithOperationResponseAsync().Result.Body;
        //    while (managers.Count > 0)
        //    {
        //        var delResp = await _manager.DeleteManagerWithOperationResponseAsync((int)managers.First().Id);
        //        managers = _manager.GetManagersWithOperationResponseAsync().Result.Body;
        //    }

        //    var cooks = _cook.GetCooksWithOperationResponseAsync().Result.Body;
        //    while (cooks.Count > 0)
        //    {
        //        var delResp = await _cook.DeleteCookWithOperationResponseAsync((int)managers.First().Id);
        //        cooks = _cook.GetCooksWithOperationResponseAsync().Result.Body;
        //    }

        //    var shifts = _shift.GetShiftsWithOperationResponseAsync().Result.Body;
        //    while (shifts.Count > 0)
        //    {
        //        var delResp = await _shift.DeleteShiftWithOperationResponseAsync((int)managers.First().Id);
        //        var deletedShift = delResp.Body;
        //        Assert.IsNotNull(deletedShift);
        //        shifts = _shift.GetShiftsWithOperationResponseAsync().Result.Body;
        //    }

        //}
    }
}
