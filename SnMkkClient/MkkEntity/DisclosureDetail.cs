using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SnMkkClient.MkkEntity
{
    [Serializable]
    public class DisclosureDetail
    {
        [JsonPropertyName("disclosureIndex")]
        public string DisclosureIndex { get; set; }

        [JsonPropertyName("senderId")]
        public string SenderId { get; set; }

        [JsonPropertyName("senderTitle")]
        public string SenderTitle { get; set; }

        [JsonPropertyName("senderExchCodes")]
        public List<string> SenderExchCodes { get; set; }

        [JsonPropertyName("behalfSenderId")]
        public string BehalfSenderId { get; set; }

        [JsonPropertyName("behalfSenderTitle")]
        public string BehalfSenderTitle { get; set; }

        [JsonPropertyName("behalfSenderExchCodes")]
        public List<string> BehalfSenderExchCodes { get; set; }

        [JsonPropertyName("disclosureReason")]
        public string DisclosureReason { get; set; }

        [JsonPropertyName("disclosureType")]
        public string DisclosureType { get; set; }

        [JsonPropertyName("disclosureClass")]
        public string DisclosureClass { get; set; }

        [JsonPropertyName("subject")]
        public TrEn Subject { get; set; }

        [JsonPropertyName("period")]
        public TrEn Period { get; set; }

        [JsonPropertyName("relatedStocks")]
        public List<RelatedStock> RelatedStocks { get; set; } = new List<RelatedStock>();

        [JsonPropertyName("summary")]
        public TrEn Summary { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("attachmentUrls")]
        public List<ResponseAttachmenturls> AttachmentUrls { get; set; }

        [JsonPropertyName("presentation")]
        public List<Presentation> Presentation { get; set; }

        [JsonPropertyName("consolidation")]
        public string Consolidation { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

    }


    [Serializable]
    public class TrEn
    {
        [JsonPropertyName("tr")]
        public string Tr { get; set; }

        [JsonPropertyName("en")]
        public string En { get; set; }

    }


    [Serializable]
    public class RelatedStock
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

    }

    [Serializable]
    public class ResponseAttachmenturls
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("fileName")]
        public string FileName { get; set; }

    }

    [Serializable]
    public class ContextPeriod
    {
        [JsonPropertyName("instant")]
        public string Instant { get; set; }

    }

    [Serializable]
    public class Context
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("Period")]
        public ContextPeriod Period { get; set; }

    }

    [Serializable]
    public class ContextList
    {
        [JsonPropertyName("Context")]
        [JsonConverter(typeof(SingleOrArrayConverter<Context>))]
        public List<Context> Context { get; set; }

    }

    [Serializable]
    public class CodeValue
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

    }

    [Serializable]
    public class Langs
    {
        [JsonPropertyName("lang")]
        public List<CodeValue> Lang { get; set; }

    }

    [Serializable]
    public class Values
    {

        [JsonPropertyName("value")]
        [JsonConverter(typeof(SingleOrArrayConverter<ReportItemValue>))]

        public List<ReportItemValue> valueList { get; set; }

        [JsonPropertyName("Value")]
        [JsonConverter(typeof(SingleOrArrayConverter<ReportItemValue>))]
        public List<ReportItemValue> ValueList { get; set; }

    }

    [Serializable]
    public class ReportItemValue
    {
        [JsonPropertyName("contextId")]
        public string ContextId { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("rounding")]
        public string Rounding { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

    }

    [Serializable]
    public class Presentation
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("content")]
        public Content Content { get; set; }

    }

    [Serializable]
    public class Content
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("isMultiDimensional")]
        public string IsMultiDimensional { get; set; }

        [JsonPropertyName("ContextList")]
        public ContextList ContextList { get; set; }

        [JsonPropertyName("ReportItem")]
        [JsonConverter(typeof(SingleOrArrayConverter<Content_ReporItem>))]
        public List<Content_ReporItem> ReportItem { get; set; }

    }

    [Serializable]
    public class Content_ReporItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abstract")]
        public string Abstract { get; set; }

        [JsonPropertyName("langs")]
        public Langs Langs { get; set; }

        [JsonPropertyName("ReportItem")]
        [JsonConverter(typeof(SingleOrArrayConverter<Content_ReportItem_ReportItem>))]
        public List<Content_ReportItem_ReportItem> ReportItem { get; set; }

    }

    [Serializable]
    public class Content_ReportItem_ReportItem
    {
        [JsonPropertyName("isHypercubeItem")]
        public string IsHypercubeItem { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abstract")]
        public string Abstract { get; set; }

        [JsonPropertyName("langs")]
        public Langs Langs { get; set; }

        [JsonPropertyName("ReportItem")]
        [JsonConverter(typeof(SingleOrArrayConverter<Content_ReportItem_ReportItem_ReportItem>))]
        public List<Content_ReportItem_ReportItem_ReportItem> ReportItem { get; set; }

    }

    [Serializable]
    public class Content_ReportItem_ReportItem_ReportItem
    {
        [JsonPropertyName("isDimensionItem")]
        public string IsDimensionItem { get; set; }

        [JsonPropertyName("isTypedDomain")]
        public string IsTypedDomain { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abstract")]
        public string Abstract { get; set; }

        [JsonPropertyName("langs")]
        public Langs Langs { get; set; }

        [JsonPropertyName("Values")]
        public Values Values { get; set; }

        [JsonPropertyName("ReportItem")]
        [JsonConverter(typeof(SingleOrArrayConverter<Content_ReportItem_ReportItem_ReportItem_ReportItem>))]
        public List<Content_ReportItem_ReportItem_ReportItem_ReportItem> ReportItem { get; set; }

    }

    [Serializable]
    public class Content_ReportItem_ReportItem_ReportItem_ReportItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("preferredLabel")]
        public string PreferredLabel { get; set; }

        [JsonPropertyName("abstract")]
        public string Abstract { get; set; }

        [JsonPropertyName("langs")]
        public Langs Langs { get; set; }

        [JsonPropertyName("Values")]
        public Values Values { get; set; }

    }

    public static class DisclosureTypes
    {
        public static string FR = "Finansal Rapor Bildirimi";
        public static string ODA = "Özel Durum Açıklaması Bildirimi";
        public static string DG = "Diğer Bildirim";
        public static string DUY = "Düzenleyici Kurum Bildirimi";
        public static string FON = "Fon Bildirimi";
        public static string CA = "Hak Kullanım Bildirimi";

        public static string GetExplanation(string type)
        {
            switch (type)
            {
                case "FR": return FR;
                case "ODA": return ODA;
                case "DG": return DG;
                case "DUY": return DUY;
                case "FON": return FON;
                case "CA": return CA;
                default: return "";
            }
        }

    }

    public static class DisclosureReason
    {
        public static string NEW = "Yeni Bildirim";
        public static string UPD = "Güncelleme Bildirimi";
        public static string CORR = "Düzeltme Bildirimi";
        public static string CANC = "Süreç İptal Bildirimi";

        public static string GetExplanation(string type)
        {
            switch (type)
            {
                case "NEW": return NEW;
                case "UPD": return UPD;
                case "CORR": return CORR;
                case "CANC": return CANC;
                default: return "";
            }
        }
    }

    public static class Consolidation
    {
        public static string CS = "Konsolide";
        public static string NC = "Konsolide Olmayan";

        public static string GetExplanation(string type)
        {
            switch (type)
            {
                case "CS": return CS;
                case "NC": return NC;
                default: return "";
            }
        }
    }

    public static class DisclosureDict
    {
        public static readonly Dictionary<string, string> propertyDictionary = new Dictionary<string, string>
        {
            ["DisclosureIndex"] = "Bildirim No",
            ["SenderId"] = "Gönderen ID",
            ["SenderTitle"] = "Gönderen Ünvanı",
            ["SenderExchCodes"] = "Gönderen Borsa Kodları",
            ["BehalfSenderId"] = "Adına Gönderilen ID",
            ["BehalfSenderTitle"] = "Adına Gönderilen Ünvan",
            ["BehalfSenderExchCodes"] = "Adına Gönderilen Borsa Kodları",
            ["DisclosureReason"] = "Bildirim Nedeni",
            ["DisclosureType"] = "Bildirim Türü",
            ["DisclosureClass"] = "Bildirim Sınıfı",
            ["Subject"] = "Konu",
            ["Period"] = "Dönem",
            ["RelatedStocks"] = "İlgili Hisseler",
            ["Summary"] = "Özet",
            ["Time"] = "Zaman",
            ["Link"] = "Bağlantı",
            ["AttachmentUrls"] = "Ek Dosya Bağlantıları",
            ["Presentation"] = "Sunum",
            ["Consolidation"] = "Konsolidasyon",
            ["Year"] = "Yıl"
        };
    }

    public class SingleOrArrayConverter<T> : JsonConverter<List<T>>
    {
        public override List<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                return JsonSerializer.Deserialize<List<T>>(ref reader, options);
            }
            else
            {
                T singleValue = JsonSerializer.Deserialize<T>(ref reader, options);
                return new List<T> { singleValue };
            }
        }

        public override void Write(Utf8JsonWriter writer, List<T> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }

}
