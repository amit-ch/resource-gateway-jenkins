using System.Collections.Generic;
using System.Net;
using GatewayAssets.DomainModel;
using GatewayAssets.DomainModel.Asset;
using GatewayAssets.DomainModel.ResponseWrappers;
using Microsoft.AspNetCore.Mvc;

namespace GatewayAssets.Web.Controllers
{
    [Route("api/v1/[controller]")]
    public class AssetsController : Controller
    {
        // GET api/assets
        [HttpGet]
        public IActionResult Get()
        {
            var asset1 = DummyAsset("video");
            var asset2 = DummyAsset("document");

            var response = new ServiceResponse
            {
                Meta = new Meta
                {
                    _links = new Links
                    {
                        Self = new Link {Href = "/api/assets"},
                        First = new Link {Href = "/api/assets"},
                        Last = new Link {Href = "/api/assets"},
                        Prev = new Link {Href = "/api/assets"},
                        Next = new Link {Href = "/api/assets"}
                    },
                    TotalCount = 2
                },
                AssetItems = new List<Asset> {asset1, asset2}
            };

            return Ok(response.SerialiseToJson());
        }

        // GET api/assets/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var asset = DummyAsset("video");
            asset.Identifier = id;
            return Ok(asset.SerialiseToJson());
        }

        // POST api/assets
        [HttpPost]
        public IActionResult Post([FromBody] dynamic jsonBody)
        {
            return StatusCode((int) HttpStatusCode.Created, jsonBody);

            //See https://stackoverflow.com/questions/25896281/restful-post-request-if-the-record-already-exists-on-post-data-do-we-return-20
            //return StatusCode((int) HttpStatusCode.Created, asset); for created assets
            //return StatusCode((int) HttpStatusCode.OK, asset); for updated assets
        }

        // PUT api/assets/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] dynamic jsonBody)
        {
            return StatusCode((int) HttpStatusCode.NotImplemented, "Not implemented.");
        }

        // DELETE api/assets/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return StatusCode((int) HttpStatusCode.NotImplemented, "Not implemented.");
        }

        private static Asset DummyAsset(string assetType)
        {
            Asset asset;

            switch (assetType)
            {
                case "video":
                    asset = new VideoAsset
                    {
                        ActivePictureFormat = "APF",
                        BarCode = "BC",
                        CloseCaptionAvailable = false,
                        Codec = "CODEC",
                        Container = "C",
                        FrameRate = "FR",
                        ImageAspectRatio = "16:9",
                        LineStandard = "LS",
                        MusicAndEffects = false,
                        RunTimeInSeconds = 0,
                        ScreenAspectRatio = "14:9",
                        Standard = "S",
                        TextedLanguage = "TL"
                    };
                    break;
                default:
                    asset = new DocumentAsset
                    {
                        DocumentType = "Doc Type"
                    };
                    break;
            }

            asset.Identifier = $"Dummy {assetType} Id";
            asset.Name = $"{assetType} name";
            asset.Source = new Source {Identifier = "Source System Id", System = "Source System Name"};
            asset.Content = new Content {Identifier = "Content Id", Code = "Content Code", Type = "Content Type"};
            asset.Title = $"{assetType} title";
            asset.Description = $"{assetType} description";
            asset.Status = "Dummy";
            asset.Sensitive = false;
            asset.Keywords = new List<Keyword>
            {
                new Keyword {Name = "Keyword 1 Name", Value = "Keyword 1 Value"},
                new Keyword {Name = "Keyword 2 Name", Value = "Keyword 2 Value"}
            };
            asset.Location = new Location
            {
                Path = "//dummy/asset.mpg",
                FileSize = "Dummy Asset File Size",
                Format = "Dummy Asset Format",
                Renditions = new List<Rendition> {new Rendition {Type = "Dummy Asset Rendition Type"}}
            };

            return asset;
        }
    }
}