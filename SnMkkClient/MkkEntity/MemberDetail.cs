using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Reflection.Metadata;


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

    // kpy41_acc1_ilet_adres_tel_fax
    [Serializable]
    public class CommunicationAdressPhoneandFax
    {

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("fax")]
        public string Fax { get; set; }
    }

    // kpy41_acc1_ilet_email
    [Serializable]
    public class EmailAdress
    {

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }

    // kpy41_acc1_merkez_disi_orgutleri
    [Serializable]
    public class OutlyingOrganizationsBranchesContactOffices
    {

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("typeOfOutlyingOrganization")]
        public string TypeOfOutlyingOrganization { get; set; }

        [JsonPropertyName("adress")]
        public string Adress { get; set; }

        [JsonPropertyName("nameSurnameOfManagerOrIndividualResponsible")]
        public string NameSurnameOfManagerOrIndividualResponsible { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("fax")]
        public string Fax { get; set; }

        [JsonPropertyName("permissionDateToStartOperations")]
        public string PermissionDateToStartOperations { get; set; }
    }

    // kpy41_acc1_yatirimci_iliskileri
    [Serializable]
    public class InvestorRelationsDepartmentorContactPeople
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

    // kpy41_acc2_yetki_belgeleri
    [Serializable]
    public class AuthorizationDocumentsOwned
    {

        [JsonPropertyName("typeOfAuthorizationDocument")]
        public string TypeOfAuthorizationDocument { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }
    }

    // kpy41_acc3_ortaklik_hakki_vermeyen
    [Serializable]
    public class InformationAboutIssuedCapitalMarketInstrumentsOtherThanShares
    {

        [JsonPropertyName("typeOfCapitalMarketInstrument")]
        public string TypeOfCapitalMarketInstrument { get; set; }

        [JsonPropertyName("issueCeiling")]
        public string IssueCeiling { get; set; }

        [JsonPropertyName("monetaryUnit")]
        public KeyText MonetaryUnit { get; set; }

        [JsonPropertyName("domesticOrForeign")]
        public KeyText DomesticOrForeign { get; set; }

        [JsonPropertyName("beginningDatesOfIssueCeiling")]
        public string BeginningDatesOfIssueCeiling { get; set; }

        [JsonPropertyName("endingDatesOfIssueCeiling")]
        public string EndingDatesOfIssueCeiling { get; set; }

        [JsonPropertyName("typeOfSale")]
        public KeyText TypeOfSale { get; set; }

        [JsonPropertyName("fundUser")]
        public string FundUser { get; set; }
    }

    // kpy41_acc3_son_durum_borsa_piyasalar
    [Serializable]
    public class CurrentListofOtherExchangesorOrganizedMarketswheretheCompanysCapitalMarketInstrumentsareListedorTraded
    {

        [JsonPropertyName("typeOfTheListedOrTradingCapitalMarketInstrument")]
        public string TypeOfTheListedOrTradingCapitalMarketInstrument { get; set; }

        [JsonPropertyName("initialDateOfListingOrTrading")]
        public string InitialDateOfListingOrTrading { get; set; }

        [JsonPropertyName("countryOfTheMarketOrStockExchange")]
        public string CountryOfTheMarketOrStockExchange { get; set; }

        [JsonPropertyName("marketOrStockExchange")]
        public string MarketOrStockExchange { get; set; }

        [JsonPropertyName("relevantSubMarketOrExchange")]
        public string RelevantSubMarketOrExchange { get; set; }
    }

    // kpy41_acc5_ortaklik_yapisi
    [Serializable]
    public class ShareholdingStructure
    {

        [JsonPropertyName("disableShareHolder")]
        public string DisableShareHolder { get; set; }

        [JsonPropertyName("shareholder")]
        public string Shareholder { get; set; }

        [JsonPropertyName("shareInCapital")]
        public string ShareInCapital { get; set; }

        [JsonPropertyName("monetaryUnit")]
        public KeyText MonetaryUnit { get; set; }

        [JsonPropertyName("ratioInCapital")]
        public string RatioInCapital { get; set; }

        [JsonPropertyName("hideDelete")]
        public string HideDelete { get; set; }
    }

    // kpy41_acc5_sermayeyi_temsil_eden
    [Serializable]
    public class InformationAboutSharesRepresentingtheCapital
    {

        [JsonPropertyName("shareGroup")]
        public string ShareGroup { get; set; }

        [JsonPropertyName("registeredOrBearerShare")]
        public KeyText RegisteredOrBearerShare { get; set; }

        [JsonPropertyName("nominalValuePerShare")]
        public string NominalValuePerShare { get; set; }

        [JsonPropertyName("monetaryUnitOfPerShare")]
        public KeyText MonetaryUnitOfPerShare { get; set; }

        [JsonPropertyName("nominalValueOfShares")]
        public string NominalValueOfShares { get; set; }

        [JsonPropertyName("monetaryUnitOfShares")]
        public KeyText MonetaryUnitOfShares { get; set; }

        [JsonPropertyName("ratioToTotalCapital")]
        public string RatioToTotalCapital { get; set; }

        [JsonPropertyName("typeOfPrivilege")]
        public string TypeOfPrivilege { get; set; }

        [JsonPropertyName("exchangeTradedOrNot")]
        public KeyText ExchangeTradedOrNot { get; set; }
    }

    // kpy41_acc5_sermayeyi_temsil_eden_2
    [Serializable]
    public class InformationAboutSharesRepresentingtheCapital2
    {

        [JsonPropertyName("shareGroup")]
        public string ShareGroup { get; set; }

        [JsonPropertyName("registeredOrBearerShare")]
        public KeyText RegisteredOrBearerShare { get; set; }

        [JsonPropertyName("nominalValuePerShare")]
        public string NominalValuePerShare { get; set; }

        [JsonPropertyName("monetaryUnitOfPerShare")]
        public KeyText MonetaryUnitOfPerShare { get; set; }

        [JsonPropertyName("nominalValueOfShares")]
        public string NominalValueOfShares { get; set; }

        [JsonPropertyName("monetaryUnitOfShares")]
        public KeyText MonetaryUnitOfShares { get; set; }

        [JsonPropertyName("ratioToTotalCapital")]
        public string RatioToTotalCapital { get; set; }

        [JsonPropertyName("typeOfPrivilege")]
        public string TypeOfPrivilege { get; set; }

        [JsonPropertyName("exchangeTradedOrNot")]
        public KeyText ExchangeTradedOrNot { get; set; }
    }

    // kpy41_acc5_son_durum_sermayeye
    [Serializable]
    public class CurrentBreakdownofIndirectShareholders
    {

        [JsonPropertyName("shareholder")]
        public string Shareholder { get; set; }

        [JsonPropertyName("shareInCapital")]
        public string ShareInCapital { get; set; }

        [JsonPropertyName("monetaryUnit")]
        public KeyText MonetaryUnit { get; set; }

        [JsonPropertyName("ratioInCapital")]
        public string RatioInCapital { get; set; }

        [JsonPropertyName("votingRightRatio")]
        public string VotingRightRatio { get; set; }

    }

    // kpy41_acc6_birimler_hizmetler
    [Serializable]
    public class InHouseUnitsOutsourcedServices
    {

        [JsonPropertyName("birim")]
        public string Birim { get; set; }

        [JsonPropertyName("kurum")]
        public string Kurum { get; set; }

        [JsonPropertyName("fieldCode")]
        public string FieldCode { get; set; }
    }

    // kpy41_acc6_portfoy_yoneticileri
    [Serializable]
    public class PortfolioManagers
    {

        [JsonPropertyName("nameSurname")]
        public string NameSurname { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("profession")]
        public string Profession { get; set; }

        [JsonPropertyName("positionsHeldInTheCompanyInTheLastFiveYears")]
        public string PositionsHeldInTheCompanyInTheLastFiveYears { get; set; }

        [JsonPropertyName("typeOfLicenceDocument")]
        public string TypeOfLicenceDocument { get; set; }

        [JsonPropertyName("licenceNumber")]
        public string LicenceNumber { get; set; }
    }

    // kpy41_acc6_sermaye_piyasa_faaliyetleri
    [Serializable]
    public class PersonsHavingSigningAuthorityRegardingCapitalMarketsActivities
    {

        [JsonPropertyName("nameSurname")]
        public string NameSurname { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    // kpy41_acc6_sirketin_diger_personel
    [Serializable]
    public class OtherPersonnel
    {

        [JsonPropertyName("nameSurname")]
        public string NameSurname { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    // kpy41_acc6_sorumlu_ortaklar
    [Serializable]
    public class Partners
    {

        [JsonPropertyName("nameSurname")]
        public string NameSurname { get; set; }
    }

    // kpy41_acc6_yonetim_kurulu_uyeleri
    [Serializable]
    public class BoardMembers
    {

        [JsonPropertyName("nameSurname")]
        public string NameSurname { get; set; }

        [JsonPropertyName("personWhoBehavesOnBehalfOfLegalPersonBoardMember")]
        public string PersonWhoBehavesOnBehalfOfLegalPersonBoardMember { get; set; }

        [JsonPropertyName("gender")]
        public KeyText Gender { get; set; }

        [JsonPropertyName("title")]
        public KeyText Title { get; set; }

        [JsonPropertyName("profession")]
        public KeyText Profession { get; set; }

        [JsonPropertyName("firstChosenDate")]
        public string FirstChosenDate { get; set; }

        [JsonPropertyName("executiveOrNon")]
        public KeyText ExecutiveOrNon { get; set; }

        [JsonPropertyName("positionsHeldInTheCompanyInTheLastFiveYears")]
        public string PositionsHeldInTheCompanyInTheLastFiveYears { get; set; }

        [JsonPropertyName("currentPositionsHeldOutsideTheCompany")]
        public string CurrentPositionsHeldOutsideTheCompany { get; set; }

        [JsonPropertyName("fiveYearsExperience")]
        public KeyText FiveYearsExperience { get; set; }

        [JsonPropertyName("shareInCapital")]
        public string ShareInCapital { get; set; }

        [JsonPropertyName("theShareGroupThatTheBoardMemberRepresenting")]
        public string TheShareGroupThatTheBoardMemberRepresenting { get; set; }

        [JsonPropertyName("independentBoardMemberOrNot")]
        public KeyText IndependentBoardMemberOrNot { get; set; }

        [JsonPropertyName("linkToTheIndependencyDeclaration")]
        public string LinkToTheIndependencyDeclaration { get; set; }

        [JsonPropertyName("consideredByTheNominationCommittee")]
        public KeyText ConsideredByTheNominationCommittee { get; set; }

        [JsonPropertyName("satisfyTheIndependenceOrNot")]
        public KeyText SatisfyTheIndependenceOrNot { get; set; }

        [JsonPropertyName("committeesChargedAndTask")]
        public string CommitteesChargedAndTask { get; set; }

        [JsonPropertyName("hideDelete")]
        public object HideDelete { get; set; }
    }

    // kpy41_acc6_yonetim_kurulu_uyeleri_2
    [Serializable]
    public class BoardMembers2
    {

        [JsonPropertyName("nameSurname")]
        public string NameSurname { get; set; }

        [JsonPropertyName("personWhoBehavesOnBehalfOfLegalPersonBoardMember")]
        public string PersonWhoBehavesOnBehalfOfLegalPersonBoardMember { get; set; }

        [JsonPropertyName("gender")]
        public KeyText Gender { get; set; }

        [JsonPropertyName("title")]
        public KeyText Title { get; set; }

        [JsonPropertyName("profession")]
        public KeyText Profession { get; set; }

        [JsonPropertyName("positionsHeldInTheCompanyInTheLastFiveYears")]
        public string PositionsHeldInTheCompanyInTheLastFiveYears { get; set; }

        [JsonPropertyName("currentPositionsHeldOutsideTheCompany")]
        public string CurrentPositionsHeldOutsideTheCompany { get; set; }

        [JsonPropertyName("shareInCapital")]
        public string ShareInCapital { get; set; }

        [JsonPropertyName("hideDelete")]
        public object HideDelete { get; set; }
    }

    // kpy41_acc6_yonetimde_soz_sahibi
    [Serializable]
    public class TopManagement
    {

        [JsonPropertyName("nameSurname")]
        public string NameSurname { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("profession")]
        public KeyText Profession { get; set; }

        [JsonPropertyName("positionsHeldInTheCompanyInTheLastFiveYears")]
        public string PositionsHeldInTheCompanyInTheLastFiveYears { get; set; }

        [JsonPropertyName("currentPositionsHeldOutsideTheCompany")]
        public string CurrentPositionsHeldOutsideTheCompany { get; set; }

        [JsonPropertyName("hideDelete")]
        public object HideDelete { get; set; }
    }

    // kpy41_acc7_bagli_ortakliklar
    [Serializable]
    public class SubsidiariesFinancialNonCurrentAssetsandFinancialInvestments
    {

        [JsonPropertyName("companyTitle")]
        public string CompanyTitle { get; set; }

        [JsonPropertyName("scopeOfActivitiesOfCompany")]
        public string ScopeOfActivitiesOfCompany { get; set; }

        [JsonPropertyName("paidInOrIssuedCapital")]
        public string PaidInOrIssuedCapital { get; set; }

        [JsonPropertyName("capitalShareOfCompany")]
        public string CapitalShareOfCompany { get; set; }

        [JsonPropertyName("monetaryUnit")]
        public KeyText MonetaryUnit { get; set; }

        [JsonPropertyName("ratioOfCapitalShareOfCompany")]
        public string RatioOfCapitalShareOfCompany { get; set; }

        [JsonPropertyName("relationWithTheCompany")]
        public string RelationWithTheCompany { get; set; }
    }

    // kpy41_acc9_son_durum_denetledigi_kap
    [Serializable]
    public class KAPMembersCurrentlyAuditedbytheCompany
    {

        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }
    }

    [Serializable]
    public class KeyText
    {

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("styleName")]
        public string StyleName { get; set; }

    }

    public static class MemberDict
    {
        public static readonly Dictionary<string, string> propertyDictionary = new Dictionary<string, string>
        {
            ["Address"] = "Adres",
            ["Adress"] = "Adres",
            ["AssignmentDate"] = "Atama Tarihi",
            ["BeginningDatesOfIssueCeiling"] = "İhraç Tavanının Başlangıç Tarihleri",
            ["Birim"] = "Birim",
            ["apitalShareOfCompany"] = "Şirketin Ana Sermayesi",
            ["CommitteesChargedAndTask"] = "Görevli Komiteler ve Görevleri",
            ["CompanyName"] = "Şirket Adı",
            ["CompanyTitle"] = "Şirket Unvanı",
            ["ConsideredByTheNominationCommittee"] = "Değerlendirme Komitesi Tarafından Değerlendirilen",
            ["CountryOfTheMarketOrStockExchange"] = "Pazar veya Borsa Ülkesi",
            ["CurrentPositionsHeldOutsideTheCompany"] = "Şirket Dışındaki Mevcut Görevler",
            ["Date"] = "Tarih",
            ["DisableShareHolder"] = "Hissedar Payını Devre Dışı Bırak",
            ["DomesticOrForeign"] = "Dış veya İç",
            ["Email"] = "E-posta",
            ["EndingDatesOfIssueCeiling"] = "İhraç Tavanının Bitiş Tarihleri",
            ["ExchangeTradedOrNot"] = "Borsada İşlem Görüp Görmediği",
            ["ExecutiveOrNon"] = "Yönetici veya Değil",
            ["Fax"] = "Faks",
            ["FieldCode"] = "Alan Kodu",
            ["FirstChosenDate"] = "İlk Seçildiği Tarih",
            ["FiveYearsExperience"] = "Beş Yıllık Deneyim",
            ["FundUser"] = "Fon Kullanıcısı",
            ["Gender"] = "Cinsiyet",
            ["HideDelete"] = "Silmeyi Gizle",
            ["IndependentBoardMemberOrNot"] = "Bağımsız Yönetim Kurulu Üyesi mi Değil mi?",
            ["InitialDateOfListingOrTrading"] = "Listelenme veya İşlem Görmeye Başlama Tarihi",
            ["IssueCeiling"] = "İhraç Tavanı",
            ["Kurum"] = "Kurum",
            ["LicenceDocumentNo"] = "Lisans Belge Numarası",
            ["LicenceNumber"] = "Lisans Numarası",
            ["LinkToTheIndependencyDeclaration"] = "Bağımsızlık Beyanına Bağlantı",
            ["MarketOrStockExchange"] = "Pazar veya Borsa",
            ["MonetaryUnit"] = "Para Birimi",
            ["MonetaryUnitOfPerShare"] = "Hisse Başı Para Birimi",
            ["MonetaryUnitOfShares"] = "Hisselerin Para Birimi",
            ["Name"] = "Adı",
            ["NameSurname"] = "Ad Soyad",
            ["NameSurnameOfManagerOrIndividualResponsible"] = "Yetkili veya Yöneticinin Ad Soyadı",
            ["NominalValueOfShares"] = "Hisselerin Nominal Değeri",
            ["NominalValuePerShare"] = "Hisse Başı Nominal Değer",
            ["Number"] = "Numara",
            ["PaidInOrIssuedCapital"] = "Ödenmiş veya Çıkarılmış Sermaye",
            ["PermissionDateToStartOperations"] = "Faaliyetlere Başlama İzin Tarihi",
            ["PersonWhoBehavesOnBehalfOfLegalPersonBoardMember"] = "Tüzel Kişi Yönetim Kurulu Üyesi Adına Hareket Eden Kişi",
            ["Phone"] = "Telefon",
            ["Position"] = "Pozisyon",
            ["PositionsHeldInTheCompanyInTheLastFiveYears"] = "Son Beş Yılda Şirkette Tutulan Pozisyonlar",
            ["Profession"] = "Meslek",
            ["RatioInCapital"] = "Sermaye Oranı",
            ["RatioOfCapitalShareOfCompany"] = "Şirketin Sermaye Payı Oranı",
            ["RatioToTotalCapital"] = "Toplam Sermayeye Oranı",
            ["RegisteredOrBearerShare"] = "Nama veya Hamiline Hisse",
            ["RelationWithTheCompany"] = "Şirketle İlişkisi",
            ["RelevantSubMarketOrExchange"] = "İlgili Alt Pazar veya Borsa",
            ["SatisfyTheIndependenceOrNot"] = "Bağımsızlık Şartını Karşılayıp Karşılamadığı",
            ["ScopeOfActivitiesOfCompany"] = "Şirketin Faaliyet Alanı",
            ["ShareGroup"] = "Hisse Grubu",
            ["ShareInCapital"] = "Sermayedeki Pay",
            ["Shareholder"] = "Hissedar",
            ["TheShareGroupThatTheBoardMemberRepresenting"] = "Yönetim Kurulu Üyesinin Temsil Ettiği Hisse Grubu",
            ["Title"] = "Unvan",
            ["TypeOfAuthorizationDocument"] = "Yetki Belgesi Türü",
            ["TypeOfCapitalMarketInstrument"] = "Sermaye Piyasası Aracı Türü",
            ["TypeOfLicenceDocument"] = "Lisans Belgesi Türü",
            ["TypeOfOutlyingOrganization"] = "Şube Türü",
            ["TypeOfPrivilege"] = "Ayrıcalık Türü",
            ["TypeOfSale"] = "Satış Türü",
            ["TypeOfTheListedOrTradingCapitalMarketInstrument"] = "Listelenen veya İşlem Gören Sermaye Piyasası Aracı Türü",
            ["VotingRightRatio"] = "Oy Hakkı Oranı",
        };
    }



}