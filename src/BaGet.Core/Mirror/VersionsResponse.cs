using Newtonsoft.Json;

namespace BaGet.Core.Mirror
{
    public class VersionsResponse
    {
        public VersionsResponse()
        {
            Versions = new string[0];
        }

        [JsonProperty("versions")]
        public string[] Versions { get; set; }
    }
}