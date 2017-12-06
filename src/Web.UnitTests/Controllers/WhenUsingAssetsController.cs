using GatewayAssets.DomainModel;
using GatewayAssets.DomainModel.Asset;
using GatewayAssets.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace GatewayAssets.Web.UnitTests.Controllers
{
    [TestFixture]
    public class WhenUsingAssetsController
    {
        [Test]
        public void CallingGetAssetsWithoutIdentifierReturnsAssetList()
        {
            var sut = new AssetsController();
            var result = sut.Get();

            Assert.NotNull(result);
            Assert.IsInstanceOf<IActionResult>(result);
            Assert.IsInstanceOf<OkObjectResult>(result);

            var okResult = result as OkObjectResult;
            StringAssert.Contains("_links", okResult.Value.ToString());
        }

        [Test]
        public void CallingGetAssetsWithIdentifierReturnsSingleAsset()
        {
            var sut = new AssetsController();
            var result = sut.Get("12345");

            Assert.NotNull(result);
            Assert.IsInstanceOf<IActionResult>(result);
            Assert.IsInstanceOf<OkObjectResult>(result);

            var okResult = result as OkObjectResult;
            StringAssert.Contains("\"identifier\":\"12345\"", okResult.Value.ToString());
        }

        [Test]
        public void CallingPostAssetsReturnsCreatedResponse()
        {
            var sut = new AssetsController();
            var assetToPost = new DocumentAsset
            {
                Identifier = "54321",
                DocumentType = "Doc Type"
            };
            var result = sut.Post(assetToPost.SerialiseToJson());

            Assert.NotNull(result);
            Assert.IsInstanceOf<IActionResult>(result);
            Assert.IsInstanceOf<ObjectResult>(result);

            var actionResult = result as ObjectResult;
            Assert.AreEqual(201, actionResult.StatusCode);
            StringAssert.Contains("\"identifier\":\"54321\"", actionResult.Value.ToString());
        }
    }
}