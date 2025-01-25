using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SnMkkClient.MkkEntity
{
    [Serializable]
    public class Member
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("stockCode")]
        public string StockCode { get; set; }

        [JsonPropertyName("memberType")]
        public string MemberType { get; set; }

        [JsonPropertyName("kfifUrl")]
        public string? KfifUrl { get; set; }
    }
}
