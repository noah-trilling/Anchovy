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
    public class CustomersTests : AnchovyApiClientTests
    {

        public ICustomers _customers;

        [TestInitialize]
        public void CustomersTestInit()
        {
            _customers = Service.Customers;
        }

        [TestMethod]
        public async Task CustomersGet()
        {
            var getResp = await _customers.GetCustomersWithOperationResponseAsync(CancellationToken.None);
            var customers = getResp.Body;
            for (int i = 0; i < customers.Count; ++i)
            {
                Console.WriteLine(customers[i].FirstName);
            }
        }

        [TestMethod]
        public async Task CustomerPost()
        {
            var customer1 = new Customer
            {
                City = "Springfield",
                Email = "homer.jay@simpson.com",
                Address = "123 Fake St.",
                Id = 2,
                FirstName = "Homer",
                MiddleName = "Jay",
                LastName = "Simpson",
                Username = "HoJu",
                Password = "password",
                State = "???",
                Phone = "555-867-5309",
                SignUpDate = DateTime.Now
            };

            var postResponse = await _customers.PostCustomerWithOperationResponseAsync(customer1, CancellationToken.None);
            var obj = postResponse.Body;
            var getResponse = _customers.GetCustomersWithOperationResponseAsync(CancellationToken.None);
            var gotCustomer = getResponse.Result.Body;
            var customer = gotCustomer.Where(_ => _.FirstName == "Homer");

            Assert.IsNotNull(customer);
            Assert.AreEqual(customer1.FirstName, customer.First().FirstName);
            Assert.AreEqual(customer1.City, customer.First().City);
            Assert.AreEqual(customer1.Address, customer.First().Address);
            Assert.AreEqual(customer1.Email, customer.First().Email);
        }

        [TestMethod]
        public async Task CustomerPostNoId()
        {
            var customer1 = new Customer
            {
                City = "Springfield",
                Email = "marge.j@bouvier.com",
                Address = "123 Fake St.",
                FirstName = "Marge",
                MiddleName = "J",
                LastName = "Bouvier",
                Username = "Margie",
                Password = "password",
                State = "???",
                Phone = "555-867-5309",
                SignUpDate = DateTime.Now
            };

            var postResponse = await _customers.PostCustomerWithOperationResponseAsync(customer1, CancellationToken.None);
            var getResponse = _customers.GetCustomersWithOperationResponseAsync(CancellationToken.None);
            var gotCustomer = getResponse.Result.Body;
            var customer = gotCustomer.Where(_ => _.FirstName == "Marge");

            Assert.IsNotNull(customer);
            Assert.IsNotNull(customer.First().Id);
            Assert.AreEqual(customer1.FirstName, customer.First().FirstName);
            Assert.AreEqual(customer1.City, customer.First().City);
            Assert.AreEqual(customer1.Address, customer.First().Address);
            Assert.AreEqual(customer1.Email, customer.First().Email);
        }

        [TestMethod]
        public async Task CustomerGetById()
        {
            var customer1 = new Customer
            {
                City = "Springfield",
                Email = "bart.j@simpson.com",
                Address = "123 Fake St.",
                FirstName = "Bart",
                MiddleName = "J",
                LastName = "Simpson",
                Username = "Bartman",
                Password = "password",
                State = "???",
                Phone = "555-867-5309",
                SignUpDate = DateTime.Now
            };

            var postResponse = await _customers.PostCustomerWithOperationResponseAsync(customer1, CancellationToken.None);
            var getResponse = _customers.GetCustomerWithOperationResponseAsync((int)postResponse.Body.Id);
            var gotCustomer = getResponse.Result.Body;

            Assert.IsNotNull(gotCustomer);
            Assert.AreEqual(customer1.FirstName, gotCustomer.FirstName);
            Assert.AreEqual(customer1.City, gotCustomer.City);
            Assert.AreEqual(customer1.Address, gotCustomer.Address);
            Assert.AreEqual(customer1.Email, gotCustomer.Email);
        }

        [TestMethod]
        public async Task CustomerPut()
        {
            var customer1 = new Customer
            {
                FirstName = "Goofball",
                City = "Capital City",
                Email = "g.o.ofball@capitalcity.com",
                Address = "1 Capital City Dr.",
                MiddleName = "Ball",
                LastName = "Goof",
                Username = "Goofball",
                Password = "password",
                State = "???",
                Phone = "555-867-5309",
                SignUpDate = DateTime.Now
            };

            var postResp = await _customers.PostCustomerWithOperationResponseAsync(customer1);
            var getResp1 = await _customers.GetCustomersWithOperationResponseAsync();
            var postedCustomer = getResp1.Body.Where(_ => _.FirstName == "Goofball").First();


            Customer customer2 = new Customer
            {
                City = "Springfield",
                Id = postedCustomer.Id,
                Address = "1 Nuclear Dr.",
                Email = "iso.tope@isotopes.com",
                FirstName = "Isotope",
                MiddleName = "I",
                LastName = "Sotope",
                Username = "Isotopey",
                Password = "password",
                State = "???",
                Phone = "555-867-5309",
                SignUpDate = DateTime.Now
            };

            var putResp = await _customers.PutCustomerWithOperationResponseAsync((int)postedCustomer.Id, customer2);
            var getResp2 = await _customers.GetCustomerWithOperationResponseAsync((int)postedCustomer.Id);
            var putCustomer = getResp2.Body;

            // Check for new values
            Assert.IsNotNull(postedCustomer);
            Assert.IsNotNull(putCustomer);
            Assert.AreEqual(customer2.FirstName, putCustomer.FirstName);
            Assert.AreEqual(customer2.City, putCustomer.City);
            Assert.AreEqual(customer2.Email, putCustomer.Email);
            Assert.AreEqual(customer2.Address, putCustomer.Address);
            Assert.AreEqual(postedCustomer.Id, putCustomer.Id);
        }

        [TestMethod]
        public async Task CustomerDelete()
        {
            var customer1 = new Customer
            {
                FirstName = "Homer",
                City = "Springfield",
                Email = "homer.jay@simpson.com",
                Address = "123 Fake St.",
                MiddleName = "Jay",
                LastName = "Simpson",
                Username = "HoJu",
                Password = "password",
                State = "???",
                Phone = "555-867-5309",
                SignUpDate = DateTime.Now
            };
            var postResp = await _customers.PostCustomerWithOperationResponseAsync(customer1);
            var getResp1 = await _customers.GetCustomersWithOperationResponseAsync();
            var postedCustomer = getResp1.Body.Where(_ => _.FirstName == "Homer").First();

            var delResp = await _customers.DeleteCustomerWithOperationResponseAsync((int)postedCustomer.Id, CancellationToken.None);

            var getResp2 = await _customers.GetCustomersWithOperationResponseAsync();
            var delResp2 = getResp2.Body.Where(_ => _.FirstName == "Homer");

            // Check that item was deleted
            Assert.AreEqual(getResp1.Body.Count - 1, getResp2.Body.Count);
        }

        [TestMethod]
        public async Task CustomersPostMultiple()
        {
            var customer1 = new Customer
            {
                City = "Springfield",
                Email = "homer.jay@simpson.com",
                Address = "742 Evergreen Terrace",
                FirstName = "m-Homer",
                MiddleName = "Jay",
                LastName = "Simpson",
                Username = "HoJu",
                Password = "password",
                State = "???",
                Phone = "555-867-5309",
                SignUpDate = DateTime.Now
            };

            var customer2 = new Customer
            {
                City = "Springfield",
                Address = "742 Evergreen Terrace",
                Email = "marge@simpson.com",
                FirstName = "m-Marge",
                MiddleName = "J",
                LastName = "Bouvier",
                Username = "Margie",
                Password = "password",
                State = "???",
                Phone = "555-867-5309",
                SignUpDate = DateTime.Now
            };

            var customer3 = new Customer
            {
                City = "Springfield",
                Address = "742 Evergreen Terrace",
                Email = "bart@simpson.com",
                FirstName = "m-Bart",
                MiddleName = "J",
                LastName = "Simpson",
                Username = "Bartman",
                Password = "password",
                State = "???",
                Phone = "555-867-5309",
                SignUpDate = DateTime.Now
            };

            var customer4 = new Customer
            {
                City = "Springfield",
                Address = "742 Evergreen Terrace",
                Email = "lisa@simpson.com",
                FirstName = "m-Lisa",
                MiddleName = "Sax",
                LastName = "Simpson",
                Username = "Saxman",
                Password = "password",
                State = "???",
                Phone = "555-867-5309",
                SignUpDate = DateTime.Now
            };

            var customer5 = new Customer
            {
                City = "Springfield",
                Address = "742 Evergreen Terrace",
                Email = "maggie@simpson.com",
                FirstName = "m-Maggie",
                MiddleName = "M",
                LastName = "Simpson",
                Username = "MaggieMay",
                Password = "password",
                State = "???",
                Phone = "555-867-5309",
                SignUpDate = DateTime.Now
            };

            var postResponse1 = await _customers.PostCustomerWithOperationResponseAsync(customer1, CancellationToken.None);
            var postResponse2 = await _customers.PostCustomerWithOperationResponseAsync(customer2, CancellationToken.None);
            var postResponse3 = await _customers.PostCustomerWithOperationResponseAsync(customer3, CancellationToken.None);
            var postResponse4 = await _customers.PostCustomerWithOperationResponseAsync(customer4, CancellationToken.None);
            var postResponse5 = await _customers.PostCustomerWithOperationResponseAsync(customer5, CancellationToken.None);


            var getResp = await _customers.GetCustomersWithOperationResponseAsync(CancellationToken.None);
            var gotCustomers = getResp.Body;

            var postedCustomer1 = gotCustomers.Where(_ => _.FirstName == "m-Homer");
            var postedCustomer2 = gotCustomers.Where(_ => _.FirstName == "m-Marge");
            var postedCustomer3 = gotCustomers.Where(_ => _.FirstName == "m-Bart");
            var postedCustomer4 = gotCustomers.Where(_ => _.FirstName == "m-Lisa");
            var postedCustomer5 = gotCustomers.Where(_ => _.FirstName == "m-Maggie");

            // Check for null responses
            Assert.IsNotNull(postedCustomer1);
            Assert.IsNotNull(postedCustomer2);
            Assert.IsNotNull(postedCustomer3);
            Assert.IsNotNull(postedCustomer4);
            Assert.IsNotNull(postedCustomer5);

            // Check all customers have an id
            Assert.IsNotNull(postedCustomer1.First().Id);
            Assert.IsNotNull(postedCustomer2.First().Id);
            Assert.IsNotNull(postedCustomer3.First().Id);
            Assert.IsNotNull(postedCustomer4.First().Id);
            Assert.IsNotNull(postedCustomer5.First().Id);

            // Check for same names
            Assert.AreEqual(customer1.FirstName, postedCustomer1.First().FirstName);
            Assert.AreEqual(customer2.FirstName, postedCustomer2.First().FirstName);
            Assert.AreEqual(customer3.FirstName, postedCustomer3.First().FirstName);
            Assert.AreEqual(customer4.FirstName, postedCustomer4.First().FirstName);
            Assert.AreEqual(customer5.FirstName, postedCustomer5.First().FirstName);

            // Check for same costs
            Assert.AreEqual(customer1.City, postedCustomer1.First().City);
            Assert.AreEqual(customer2.City, postedCustomer2.First().City);
            Assert.AreEqual(customer3.City, postedCustomer3.First().City);
            Assert.AreEqual(customer4.City, postedCustomer4.First().City);
            Assert.AreEqual(customer5.City, postedCustomer5.First().City);
        }

        [TestMethod]
        public async Task CustomersClearTable()
        {
            var gotCustomers = _customers.GetCustomersWithOperationResponseAsync(CancellationToken.None).Result.Body;
            // Iterate over each customer to get the id and delete that customer
            while (gotCustomers.Count > 0)
            {
                var delResp = await _customers.DeleteCustomerWithOperationResponseAsync((int)gotCustomers.First().Id);
                var deletedCustomer = delResp.Body;
                Assert.IsNotNull(deletedCustomer);
                gotCustomers = _customers.GetCustomersWithOperationResponseAsync(CancellationToken.None).Result.Body;
            }

            var getResp1 = await _customers.GetCustomersWithOperationResponseAsync();

            // Confirm there are no customers left
            Assert.AreEqual(0, getResp1.Body.Count);
        }
    }
}
