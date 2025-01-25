using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace SnMkkClient.MkkEntity
{
    [Serializable]
    public class MemberDetail
    {
        [JsonPropertyName("nameTr")]
        public string NameTr { get; set; }

        [JsonPropertyName("nameEn")]
        public string NameEn { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("publishDateTime")]
        public string PublishDateTime { get; set; }

        [JsonPropertyName("value")]
        public object Value { get; set; }
    }


    //kpy41_acc5_sermayede_dogrudan
    [Serializable]
    public class ShareholderInfo
    {
        [JsonPropertyName("shareInCapital")]
        public string ShareInCapital { get; set; }

        [JsonPropertyName("votingRightRatio")]
        public string VotingRightRatio { get; set; }

        [JsonPropertyName("shareholder")]
        public string Shareholder { get; set; }

        [JsonPropertyName("ratioInCapital")]
        public string RatioInCapital { get; set; }
    }


    //kpy41_acc1_ilet_adres_tel_fax
    [Serializable]
    public class ContactInfo
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("fax")]
        public string Fax { get; set; }
    }


    //kpy41_acc6_yonetimde_soz_sahibi
    [Serializable]
    public class Profession
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("styleName")]
        public string StyleName { get; set; }
    }

    [Serializable]
    public class Person
    {
        [JsonPropertyName("nameSurname")]
        public string NameSurname { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("profession")]
        public Profession Profession { get; set; }

        [JsonPropertyName("positionsHeldInTheCompanyInTheLastFiveYears")]
        public string PositionsHeldInTheCompanyInTheLastFiveYears { get; set; }

        [JsonPropertyName("currentPositionsHeldOutsideTheCompany")]
        public string CurrentPositionsHeldOutsideTheCompany { get; set; }

        [JsonPropertyName("hideDelete")]
        public bool HideDelete { get; set; }
    }



    //kpy41_acc1_yatirimci_iliskileri
    [Serializable]
    public class InvestorRelations
    {
        [JsonPropertyName("nameSurname")]
        public string NameSurname { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("assignmentDate")]
        public string AssignmentDate { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("typeOfLicenceDocument")]
        public string TypeOfLicenceDocument { get; set; }

        [JsonPropertyName("licenceDocumentNo")]
        public string LicenceDocumentNo { get; set; }
    }


    //kpy41_acc5_sermayeyi_temsil_eden
    [Serializable]
    public class ShareType
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    [Serializable]
    public class ShareInfo
    {
        [JsonPropertyName("shareGroup")]
        public string ShareGroup { get; set; }

        [JsonPropertyName("registeredOrBearerShare")]
        public ShareType RegisteredOrBearerShare { get; set; }

        [JsonPropertyName("nominalValuePerShare")]
        public string NominalValuePerShare { get; set; }

        [JsonPropertyName("monetaryUnitOfPerShare")]
        public ShareType MonetaryUnitOfPerShare { get; set; }

        [JsonPropertyName("nominalValueOfShares")]
        public string NominalValueOfShares { get; set; }

        [JsonPropertyName("monetaryUnitOfShares")]
        public ShareType MonetaryUnitOfShares { get; set; }

        [JsonPropertyName("ratioToTotalCapital")]
        public string RatioToTotalCapital { get; set; }

        [JsonPropertyName("typeOfPrivilege")]
        public string TypeOfPrivilege { get; set; }

        [JsonPropertyName("exchangeTradedOrNot")]
        public ShareType ExchangeTradedOrNot { get; set; }
    }

}
