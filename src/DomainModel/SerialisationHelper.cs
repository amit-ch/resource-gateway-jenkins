using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GatewayAssets.DomainModel
{
    public static class SerialisationHelper
    {
        public static string SerialiseToJson<T>(this T objectToSerialise)
        {
            return JsonConvert.SerializeObject(objectToSerialise, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        public static T DeserialseFromJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}