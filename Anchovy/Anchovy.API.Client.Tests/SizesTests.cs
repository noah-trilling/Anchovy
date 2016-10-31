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
    public class SizesTests : AnchovyApiClientTests
    {
        public ISizes _sizes;

        [TestInitialize]
        public void SizesTestInit()
        {
            _sizes = Service.Sizes;
        }

        [TestMethod]
        public async Task GetSizes()
        {
            var getResp = await _sizes.GetSizesWithOperationResponseAsync(CancellationToken.None);
            var sizes = getResp.Body;
            for (int i = 0; i < sizes.Count; ++i)
            {
                Console.WriteLine(sizes[i].Name);
            }
        }

        [TestMethod]
        public async Task PostOneSize()
        {
            var size1 = new Size
            {
                Cost = 6,
                Id = 2,
                Name = "small"
            };
            
            var postResponse = await _sizes.PostSizeWithOperationResponseAsync(size1, CancellationToken.None);
            var obj = postResponse.Body;
            var getResponse = _sizes.GetSizesWithOperationResponseAsync(CancellationToken.None);
            var gotSize = getResponse.Result.Body;
            var size = gotSize.Where(_ => _.Name == "small");

            Assert.IsNotNull(size);
            Assert.AreEqual(size1.Name, size.First().Name);
            Assert.AreEqual(6, size.First().Cost);
        }

        [TestMethod]
        public async Task PostNoId()
        {
            var size1 = new Size
            {
                Cost = 10,
                Name = "medium"
            };

            var postResponse = await _sizes.PostSizeWithOperationResponseAsync(size1, CancellationToken.None);
            var obj = postResponse.Body;
            var getResponse = _sizes.GetSizesWithOperationResponseAsync(CancellationToken.None);
            var gotSize = getResponse.Result.Body;
            var size = gotSize.Where(_ => _.Name == "medium");

            Assert.IsNotNull(size);
            Assert.AreEqual(size1.Name, size.First().Name);
            Assert.IsNotNull(size.First().Id);
            Assert.AreEqual(size1.Cost, size.First().Cost);
        }

        [TestMethod]
        public async Task PutSize()
        {
            var size1 = new Size
            {
                Name = "small",
                Cost = 99
            };
            var postResp = await _sizes.PostSizeWithOperationResponseAsync(size1);
            var getResp1 = await _sizes.GetSizesWithOperationResponseAsync();
            var postedSize = getResp1.Body.Where(_ => _.Name == "small").First();


            Size size2 = new Size
            {
                Cost = 20,
                Id = postedSize.Id,
                Name = "new size"
            };

            var putResp = await _sizes.PutSizeWithOperationResponseAsync((int)postedSize.Id, size2);
            var getResp2 = await _sizes.GetSizeWithOperationResponseAsync((int)postedSize.Id);
            var putSize = getResp2.Body;

            // Check for new values
            Assert.IsNotNull(postedSize);
            Assert.IsNotNull(putSize);
            Assert.AreEqual(size2.Name, putSize.Name);
            Assert.AreEqual(size2.Cost, putSize.Cost);
            Assert.AreEqual(postedSize.Id, putSize.Id);
        }

        [TestMethod]
        public async Task DeleteSize()
        {
            var size1 = new Size
            {
                Name = "medium",
                Cost = 99
            };
            var postResp = await _sizes.PostSizeWithOperationResponseAsync(size1);
            var getResp1 = await _sizes.GetSizesWithOperationResponseAsync();
            var postedSize = getResp1.Body.Where(_ => _.Name == "medium").First();

            var delResp = await _sizes.DeleteSizeWithOperationResponseAsync((int)postedSize.Id, CancellationToken.None);

            var getResp2 = await _sizes.GetSizesWithOperationResponseAsync();
            var delResp2 = getResp2.Body.Where(_ => _.Name == "medium");

            // Check that item was deleted
            Assert.AreEqual(getResp1.Body.Count - 1, getResp2.Body.Count);
        }

        [TestMethod]
        public async Task PostMultipleSizes()
        {
            var size1 = new Size
            {
                Cost = 6,
                Name = "m-small"
            };

            var size2 = new Size
            {
                Cost = 8,
                Name = "m-medium"
            };

            var size3 = new Size
            {
                Cost = 10,
                Name = "m-large"
            };

            var size4 = new Size
            {
                Cost = 12,
                Name = "m-extra-large"
            };

            var size5 = new Size
            {
                Cost = 15,
                Name = "m-xx-large"
            };

            var postResponse1 = await _sizes.PostSizeWithOperationResponseAsync(size1, CancellationToken.None);
            var postResponse2 = await _sizes.PostSizeWithOperationResponseAsync(size2, CancellationToken.None);
            var postResponse3 = await _sizes.PostSizeWithOperationResponseAsync(size3, CancellationToken.None);
            var postResponse4 = await _sizes.PostSizeWithOperationResponseAsync(size4, CancellationToken.None);
            var postResponse5 = await _sizes.PostSizeWithOperationResponseAsync(size5, CancellationToken.None);


            var getResp = await _sizes.GetSizesWithOperationResponseAsync(CancellationToken.None);
            var gotSizes = getResp.Body;

            var postedSize1 = gotSizes.Where(_ => _.Name == "m-small");
            var postedSize2 = gotSizes.Where(_ => _.Name == "m-medium");
            var postedSize3 = gotSizes.Where(_ => _.Name == "m-large");
            var postedSize4 = gotSizes.Where(_ => _.Name == "m-extra-large");
            var postedSize5 = gotSizes.Where(_ => _.Name == "m-xx-large");

            // Check for null responses
            Assert.IsNotNull(postedSize1);
            Assert.IsNotNull(postedSize2);
            Assert.IsNotNull(postedSize3);
            Assert.IsNotNull(postedSize4);
            Assert.IsNotNull(postedSize5);

            // Check all sizes have an id
            Assert.IsNotNull(postedSize1.First().Id);
            Assert.IsNotNull(postedSize2.First().Id);
            Assert.IsNotNull(postedSize3.First().Id);
            Assert.IsNotNull(postedSize4.First().Id);
            Assert.IsNotNull(postedSize5.First().Id);

            // Check for same names
            Assert.AreEqual(size1.Name, postedSize1.First().Name);
            Assert.AreEqual(size2.Name, postedSize2.First().Name);
            Assert.AreEqual(size3.Name, postedSize3.First().Name);
            Assert.AreEqual(size4.Name, postedSize4.First().Name);
            Assert.AreEqual(size5.Name, postedSize5.First().Name);

            // Check for same costs
            Assert.AreEqual(size1.Cost, postedSize1.First().Cost);
            Assert.AreEqual(size2.Cost, postedSize2.First().Cost);
            Assert.AreEqual(size3.Cost, postedSize3.First().Cost);
            Assert.AreEqual(size4.Cost, postedSize4.First().Cost);
            Assert.AreEqual(size5.Cost, postedSize5.First().Cost);
        }

        [TestMethod]
        public async Task ClearSizeTable()
        {
            var gotSize = _sizes.GetSizesWithOperationResponseAsync(CancellationToken.None).Result.Body;
            while (gotSize.Count > 0)
            {
                var delResp = await _sizes.DeleteSizeWithOperationResponseAsync((int)gotSize.First().Id);
                var deletedSize = delResp.Body;
                Assert.IsNotNull(deletedSize);
                gotSize = _sizes.GetSizesWithOperationResponseAsync(CancellationToken.None).Result.Body;
            }

            var getResp1 = await _sizes.GetSizesWithOperationResponseAsync();

            Assert.AreEqual(0, getResp1.Body.Count);
        }
    }
}
