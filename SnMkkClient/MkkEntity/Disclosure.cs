using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SnMkkClient.MkkEntity
{
    [Serializable]
    public class Disclosure
    {
        [JsonPropertyName("disclosureIndex")]
        public string DisclosureIndex { get; set; }

        [JsonPropertyName("disclosureType")]
        public string DisclosureType { get; set; }

        [JsonPropertyName("disclosureClass")]
        public string DisclosureClass { get; set; }

        [JsonPropertyName("subReportIds")]
        public List<string> SubReportIds { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("companyId")]
        public string CompanyId { get; set; }

        [JsonPropertyName("acceptedDataFileTypes")]
        public List<string> AcceptedDataFileTypes { get; set; }
    }
}
