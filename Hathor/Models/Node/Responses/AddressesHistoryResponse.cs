using Newtonsoft.Json;
using System.Collections.Generic;

namespace Hathor.Models.Node.Responses
{
    public class AddressesHistoryResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("has_more")]
        public string? Message { get; set; }

        [JsonProperty("first_hash")]
        public int FirstHash { get; set; }

        [JsonProperty("first_address")]
        public int FirstAddress { get; set; }

        [JsonProperty("history")]
        public Dictionary<string, AddressesHistoryData> History { get; set; } = new Dictionary<string, AddressesHistoryData>();
    }

    public class AddressesHistoryData
    {

        [JsonProperty("hash")]
        public string Hash { get; set; } = default!;

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("is_voided")]
        public bool IsVoided { get; set; }

        [JsonProperty("parents")]
        public List<string>? Parents { get; set; }

        [JsonProperty("inputs")]
        public List<Input>? Inputs { get; set; }

        [JsonProperty("outputs")]
        public List<Output>? Outputs { get; set; }
        
    }
    
}