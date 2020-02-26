using Newtonsoft.Json;

namespace CodingContest.Models 
{
    [JsonObject]
    public class DataModel : IDataModel
    {
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}