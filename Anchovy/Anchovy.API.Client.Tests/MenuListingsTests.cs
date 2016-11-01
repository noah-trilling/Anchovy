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
    public class MenuListingsTests : AnchovyApiClientTests
    {

        public IMenuListings _menuListings;
        public ISizes _sizes;

        [TestInitialize]
        public void MenuListingsTestInit()
        {
            _menuListings = Service.MenuListings;
            _sizes = Service.Sizes;
        }

        [TestMethod]
        public async Task MenuListingsGet()
        {
            var getResp = await _menuListings.GetMenuListingsWithOperationResponseAsync(CancellationToken.None);
            var menuListings = getResp.Body;
            for (int i = 0; i < menuListings.Count; ++i)
            {
                Console.WriteLine(menuListings[i].Name);
            }
        }

        [TestMethod]
        public async Task MenuListingPost()
        {
            var size1 = new Size
            {
                Cost = 6,
                Id = 2,
                Name = "small"
            };
            var postSize = await _sizes.PostSizeWithOperationResponseAsync(size1, CancellationToken.None);
            var getResponse = _sizes.GetSizesWithOperationResponseAsync(CancellationToken.None);
            var gotSize = getResponse.Result.Body;
            var size = gotSize.Where(_ => _.Name == "small").First();

            var menuListing1 = new MenuListing
            {
                Cost = 6,
                Name = "Wings",
                Size = size
            };

            var postResponse = await _menuListings.PostMenuListingWithOperationResponseAsync(menuListing1, CancellationToken.None);
            var getResponse2 = _menuListings.GetMenuListingsWithOperationResponseAsync(CancellationToken.None);
            var gotMenuListing = getResponse2.Result.Body;
            var menuListing = gotMenuListing.Where(_ => _.Name == "Wings");

            Assert.IsNotNull(menuListing);
            Assert.AreEqual(menuListing1.Name, menuListing.First().Name);
            Assert.AreEqual(menuListing1.Cost, menuListing.First().Cost);
        }

        [TestMethod]
        public async Task MenuListingPostNoId()
        {
            var size1 = new Size
            {
                Cost = 6,
                Id = 2,
                Name = "small"
            };
            var postSize = await _sizes.PostSizeWithOperationResponseAsync(size1, CancellationToken.None);

            var menuListing1 = new MenuListing
            {
                Cost = 6,
                SizeId = 2,
                Name = "Wings",
                Size = size1
            };

            var postResponse = await _menuListings.PostMenuListingWithOperationResponseAsync(menuListing1, CancellationToken.None);
            var getResponse = _menuListings.GetMenuListingsWithOperationResponseAsync(CancellationToken.None);
            var gotMenuListing = getResponse.Result.Body;
            var menuListing = gotMenuListing.Where(_ => _.Name == "Wings");

            Assert.IsNotNull(menuListing);
            Assert.IsNotNull(menuListing.First().Id);
            Assert.AreEqual(menuListing1.Name, menuListing.First().Name);
            Assert.AreEqual(menuListing1.Cost, menuListing.First().Cost);
        }

        [TestMethod]
        public async Task MenuListingGetById()
        {
            var size1 = new Size
            {
                Cost = 6,
                Id = 2,
                Name = "x-small"
            };

            var menuListing1 = new MenuListing
            {
                Cost = 6,
                SizeId = 2,
                Name = "Breadsticks",
                Size = size1
            };

            var postResponse = await _menuListings.PostMenuListingWithOperationResponseAsync(menuListing1, CancellationToken.None);
            var getResponse = _menuListings.GetMenuListingWithOperationResponseAsync((int)postResponse.Body.Id);
            var gotMenuListing = getResponse.Result.Body;

            Assert.IsNotNull(gotMenuListing);
            Assert.AreEqual(menuListing1.Cost, gotMenuListing.Cost);
            Assert.AreEqual(menuListing1.Name, gotMenuListing.Name);
        }

        [TestMethod]
        public async Task MenuListingPut()
        {
            var size1 = new Size
            {
                Cost = 6,
                Id = 2,
                Name = "x-small"
            };

            var menuListing1 = new MenuListing
            {
                Cost = 6,
                SizeId = 2,
                Name = "Breadsticks",
                Size = size1
            };

            var postResp = await _menuListings.PostMenuListingWithOperationResponseAsync(menuListing1);
            var getResp1 = await _menuListings.GetMenuListingsWithOperationResponseAsync();
            var postedMenuListing = getResp1.Body.Where(_ => _.Name == "Breadsticks").First();

            var size2 = new Size
            {
                Cost = 6,
                Id = 2,
                Name = "x-large"
            };

            MenuListing menuListing2 = new MenuListing
            {
                Cost = 20,
                SizeId = postedMenuListing.SizeId,
                Id = postedMenuListing.Id,
                Name = "new menuListing"
            };

            if (postedMenuListing.Id != null)
            {
                var putResp = await _menuListings.PutMenuListingWithOperationResponseAsync(postedMenuListing.Id.Value, menuListing2);
            }
            if (postedMenuListing.Id != null)
            {
                var getResp2 = await _menuListings.GetMenuListingWithOperationResponseAsync(postedMenuListing.Id.Value);
                var putMenuListing = getResp2.Body;

                // Check for new values
                Assert.IsNotNull(postedMenuListing);
                Assert.IsNotNull(putMenuListing);
                Assert.AreEqual(menuListing2.Name, putMenuListing.Name);
                Assert.AreEqual(menuListing2.Cost, putMenuListing.Cost);
                Assert.AreEqual(menuListing2.SizeId, putMenuListing.SizeId);
                Assert.AreEqual(postedMenuListing.Id, putMenuListing.Id);
            }
        }

        [TestMethod]
        public async Task MenuListingDelete()
        {
            var size1 = new Size
            {
                Cost = 6,
                Id = 2,
                Name = "x-small"
            };

            var menuListing1 = new MenuListing
            {
                Cost = 6,
                SizeId = 2,
                Name = "Breadsticks",
                Size = size1
            };

            var postResp = await _menuListings.PostMenuListingWithOperationResponseAsync(menuListing1);
            var getResp1 = await _menuListings.GetMenuListingsWithOperationResponseAsync();
            var postedMenuListing = getResp1.Body.Where(_ => _.Name == "Breadsticks").First();

            if (postedMenuListing.Id != null)
            {
                var delResp = await _menuListings.DeleteMenuListingWithOperationResponseAsync(postedMenuListing.Id.Value, CancellationToken.None);
            }

            var getResp2 = await _menuListings.GetMenuListingsWithOperationResponseAsync();
            var delResp2 = getResp2.Body.Where(_ => _.Name == "medium");

            // Check that item was deleted
            Assert.AreEqual(getResp1.Body.Count - 1, getResp2.Body.Count);
        }

        [TestMethod]
        public async Task MenuListingPostMultiple()
        {
            var size1 = new Size
            {
                Cost = 6,
                Id = 2,
                Name = "m-small"
            };

            var menuListing1 = new MenuListing
            {
                Cost = 6,
                SizeId = 2,
                Name = "m-Breadsticks",
                Size = size1
            };

            var size2 = new Size
            {
                Cost = 8,
                Id = 2,
                Name = "m-medium"
            };

            var menuListing2 = new MenuListing
            {
                Cost = 6,
                SizeId = 2,
                Name = "m-Candy",
                Size = size2
            };

            var size3 = new Size
            {
                Cost = 6,
                Id = 2,
                Name = "m-large"
            };

            var menuListing3 = new MenuListing
            {
                Cost = 6,
                SizeId = 2,
                Name = "m-Wings",
                Size = size3
            };

            var menuListing4 = new MenuListing
            {
                Cost = 12,
                Name = "m-extra-large",
                Size = size3
            };

            var menuListing5 = new MenuListing
            {
                Cost = 15,
                Name = "m-xx-large",
                Size = size3
            };

            var postResponse1 = await _menuListings.PostMenuListingWithOperationResponseAsync(menuListing1, CancellationToken.None);
            var postResponse2 = await _menuListings.PostMenuListingWithOperationResponseAsync(menuListing2, CancellationToken.None);
            var postResponse3 = await _menuListings.PostMenuListingWithOperationResponseAsync(menuListing3, CancellationToken.None);
            var postResponse4 = await _menuListings.PostMenuListingWithOperationResponseAsync(menuListing4, CancellationToken.None);
            var postResponse5 = await _menuListings.PostMenuListingWithOperationResponseAsync(menuListing5, CancellationToken.None);


            var getResp = await _menuListings.GetMenuListingsWithOperationResponseAsync(CancellationToken.None);
            var gotMenuListings = getResp.Body;

            var postedMenuListing1 = gotMenuListings.Where(_ => _.Name == "m-Breadsticks");
            var postedMenuListing2 = gotMenuListings.Where(_ => _.Name == "m-Candy");
            var postedMenuListing3 = gotMenuListings.Where(_ => _.Name == "m-Wings");
            var postedMenuListing4 = gotMenuListings.Where(_ => _.Name == "m-extra-large");
            var postedMenuListing5 = gotMenuListings.Where(_ => _.Name == "m-xx-large");

            // Check for null responses
            Assert.IsNotNull(postedMenuListing1);
            Assert.IsNotNull(postedMenuListing2);
            Assert.IsNotNull(postedMenuListing3);
            Assert.IsNotNull(postedMenuListing4);
            Assert.IsNotNull(postedMenuListing5);

            // Check all menuListings have an id
            Assert.IsNotNull(postedMenuListing1.First().Id);
            Assert.IsNotNull(postedMenuListing2.First().Id);
            Assert.IsNotNull(postedMenuListing3.First().Id);
            Assert.IsNotNull(postedMenuListing4.First().Id);
            Assert.IsNotNull(postedMenuListing5.First().Id);

            // Check for same names
            Assert.AreEqual(menuListing1.Name, postedMenuListing1.First().Name);
            Assert.AreEqual(menuListing2.Name, postedMenuListing2.First().Name);
            Assert.AreEqual(menuListing3.Name, postedMenuListing3.First().Name);
            Assert.AreEqual(menuListing4.Name, postedMenuListing4.First().Name);
            Assert.AreEqual(menuListing5.Name, postedMenuListing5.First().Name);

            // Check for same costs
            Assert.AreEqual(menuListing1.Cost, postedMenuListing1.First().Cost);
            Assert.AreEqual(menuListing2.Cost, postedMenuListing2.First().Cost);
            Assert.AreEqual(menuListing3.Cost, postedMenuListing3.First().Cost);
            Assert.AreEqual(menuListing4.Cost, postedMenuListing4.First().Cost);
            Assert.AreEqual(menuListing5.Cost, postedMenuListing5.First().Cost);
        }

        [TestMethod]
        public async Task MenuListingsClearTable()
        {
            var gotMenuListings = _menuListings.GetMenuListingsWithOperationResponseAsync(CancellationToken.None).Result.Body;
            // Iterate over each menuListing to get the id and delete that menuListing
            while (gotMenuListings.Count > 0)
            {
                var delResp = await _menuListings.DeleteMenuListingWithOperationResponseAsync((int)gotMenuListings.First().Id);
                var deletedMenuListing = delResp.Body;
                Assert.IsNotNull(deletedMenuListing);
                gotMenuListings = _menuListings.GetMenuListingsWithOperationResponseAsync(CancellationToken.None).Result.Body;
            }

            var getResp1 = await _menuListings.GetMenuListingsWithOperationResponseAsync();

            // Confirm there are no menuListings left
            Assert.AreEqual(0, getResp1.Body.Count);
        }
    }
}
