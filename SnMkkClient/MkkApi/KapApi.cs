using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SnMkkClient.MkkEntity;

namespace SnMkkClient.MkkApi
{
    public static class KapApi
    {
        private static readonly string rootUrl = "https://apigwdev.mkk.com.tr/api/";

        public static void PrepareClient(HttpClient client, string username, string password)
        {
            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
        }


        #region Main Services

        public static async Task<List<Member>> GetMembers(HttpClient client)
        {
            string url = rootUrl + "vyk/members";

            List<Member> members = new List<Member>();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();

                    members = JsonSerializer.Deserialize<List<Member>>(responseData);
                }
                else
                {
                    Console.WriteLine($"Hata! Durum kodu: {response.StatusCode}");
                    Console.WriteLine($"Hata mesajı: {await response.Content.ReadAsStringAsync()}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
            return members;
        }

        public static async Task<List<MemberDetail>> GetMemberDetail(HttpClient client, string memberId)
        {

            string url = rootUrl + "vyk/memberDetail/" + memberId;

            List<MemberDetail> memberDetails = new List<MemberDetail>();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();

                    memberDetails = JsonSerializer.Deserialize<List<MemberDetail>>(responseData);

                    ParseMemberDetails(memberDetails);

                }
                else
                {
                    Console.WriteLine($"Hata! Durum kodu: {response.StatusCode}");
                    Console.WriteLine($"Hata mesajı: {await response.Content.ReadAsStringAsync()}");
                }
            }
            catch (Exception)
            {
                throw;
            }

            return memberDetails;
        }

        public static async Task<List<Disclosure>> GetDisclosures(HttpClient client, string memberId)
        {
            //disclosureIndex=1186879 index numarası her firmaya göre değişmektedir. 
            //gönderilen numaradan itibaren son 44 bildirimi listelemektedir.
            string url = rootUrl + "vyk/disclosures?disclosureIndex=1186879&companyId=" + memberId;

            List<Disclosure> disclosures = new List<Disclosure>();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();

                    disclosures = JsonSerializer.Deserialize<List<Disclosure>>(responseData);

                    ReOrderDisclosures(disclosures);
                }
                else
                {
                    Console.WriteLine($"Hata! Durum kodu: {response.StatusCode}");
                    Console.WriteLine($"Hata mesajı: {await response.Content.ReadAsStringAsync()}");
                }
            }
            catch (Exception)
            {
                throw;
            }

            return disclosures;
        }

        public static async Task<DisclosureDetail> GetDisclosureDetail(HttpClient client, string index)
        {

            string url = rootUrl + "vyk/disclosureDetail/" + index + "?fileType=data";

            DisclosureDetail disclosureDetail = new DisclosureDetail();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();

                    disclosureDetail = JsonSerializer.Deserialize<DisclosureDetail>(responseData);
                }
                else
                {
                    Console.WriteLine($"Hata! Durum kodu: {response.StatusCode}");
                    Console.WriteLine($"Hata mesajı: {await response.Content.ReadAsStringAsync()}");
                }
            }
            catch (Exception)
            {
                throw;
            }

            return disclosureDetail;
        }

        public static async Task<byte[]> GetAttachment(HttpClient client, string attachmentKey)
        {
            //https://apigwdev.mkk.com.tr/api/vyk

            string url = rootUrl + "vyk/downloadAttachment/" + attachmentKey;

            byte[] fileBytes;

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    fileBytes = await response.Content.ReadAsByteArrayAsync();
                }
                else
                {
                    Console.WriteLine($"Hata! Durum kodu: {response.StatusCode}");
                    Console.WriteLine($"Hata mesajı: {await response.Content.ReadAsStringAsync()}");
                    fileBytes = new byte[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata! Durum kodu: {ex.Source}");
                Console.WriteLine($"Hata mesajı: {ex.Message}");
                fileBytes = new byte[0];
            }

            return fileBytes;

        }

        #endregion


        #region Helpers

        private static void ParseMemberDetails(List<MemberDetail> memberDetails)
        {
            if (memberDetails == null) return;

            foreach (var md in memberDetails)
            {
                if (md != null && md.Key != null && md.Value != null)
                {
                    switch (md.Key)
                    {
                        case "kpy41_acc1_ilet_adres_tel_fax": md.Value = JsonSerializer.Deserialize<List<CommunicationAdressPhoneandFax>>(md.Value.ToString()); break;
                        case "kpy41_acc1_ilet_email": md.Value = JsonSerializer.Deserialize<List<EmailAdress>>(md.Value.ToString()); break;
                        case "kpy41_acc1_merkez_disi_orgutleri": md.Value = JsonSerializer.Deserialize<List<OutlyingOrganizationsBranchesContactOffices>>(md.Value.ToString()); break;
                        case "kpy41_acc1_yatirimci_iliskileri": md.Value = JsonSerializer.Deserialize<List<InvestorRelationsDepartmentorContactPeople>>(md.Value.ToString()); break;
                        case "kpy41_acc2_yetki_belgeleri": md.Value = JsonSerializer.Deserialize<List<AuthorizationDocumentsOwned>>(md.Value.ToString()); break;
                        case "kpy41_acc3_ortaklik_hakki_vermeyen": md.Value = JsonSerializer.Deserialize<List<InformationAboutIssuedCapitalMarketInstrumentsOtherThanShares>>(md.Value.ToString()); break;
                        case "kpy41_acc3_son_durum_borsa_piyasalar": md.Value = JsonSerializer.Deserialize<List<CurrentListofOtherExchangesorOrganizedMarketswheretheCompanysCapitalMarketInstrumentsareListedorTraded>>(md.Value.ToString()); break;
                        case "kpy41_acc5_ortaklik_yapisi": md.Value = JsonSerializer.Deserialize<List<ShareholdingStructure>>(md.Value.ToString()); break;
                        case "kpy41_acc5_sermayede_dogrudan": md.Value = JsonSerializer.Deserialize<List<CurrentBreakdownofIndirectShareholders>>(md.Value.ToString()); break;
                        case "kpy41_acc5_sermayeyi_temsil_eden": md.Value = JsonSerializer.Deserialize<List<InformationAboutSharesRepresentingtheCapital>>(md.Value.ToString()); break;
                        case "kpy41_acc5_sermayeyi_temsil_eden_2": md.Value = JsonSerializer.Deserialize<List<InformationAboutSharesRepresentingtheCapital2>>(md.Value.ToString()); break;
                        case "kpy41_acc5_son_durum_sermayeye": md.Value = JsonSerializer.Deserialize<List<CurrentBreakdownofIndirectShareholders>>(md.Value.ToString()); break;
                        case "kpy41_acc6_birimler_hizmetler": md.Value = JsonSerializer.Deserialize<List<InHouseUnitsOutsourcedServices>>(md.Value.ToString()); break;
                        case "kpy41_acc6_portfoy_yoneticileri": md.Value = JsonSerializer.Deserialize<List<PortfolioManagers>>(md.Value.ToString()); break;
                        case "kpy41_acc6_sermaye_piyasa_faaliyetleri": md.Value = JsonSerializer.Deserialize<List<PersonsHavingSigningAuthorityRegardingCapitalMarketsActivities>>(md.Value.ToString()); break;
                        case "kpy41_acc6_sirketin_diger_personel": md.Value = JsonSerializer.Deserialize<List<OtherPersonnel>>(md.Value.ToString()); break;
                        case "kpy41_acc6_sorumlu_ortaklar": md.Value = JsonSerializer.Deserialize<List<Partners>>(md.Value.ToString()); break;
                        case "kpy41_acc6_yonetim_kurulu_uyeleri": md.Value = JsonSerializer.Deserialize<List<BoardMembers>>(md.Value.ToString()); break;
                        case "kpy41_acc6_yonetim_kurulu_uyeleri_2": md.Value = JsonSerializer.Deserialize<List<BoardMembers2>>(md.Value.ToString()); break;
                        case "kpy41_acc6_yonetimde_soz_sahibi": md.Value = JsonSerializer.Deserialize<List<TopManagement>>(md.Value.ToString()); break;
                        case "kpy41_acc7_bagli_ortakliklar": md.Value = JsonSerializer.Deserialize<List<SubsidiariesFinancialNonCurrentAssetsandFinancialInvestments>>(md.Value.ToString()); break;
                        case "kpy41_acc9_son_durum_denetledigi_kap": md.Value = JsonSerializer.Deserialize<List<KAPMembersCurrentlyAuditedbytheCompany>>(md.Value.ToString()); break;

                        default:
                            break;
                    }
                }

            }
        }

        private static void ReOrderDisclosures(List<Disclosure> disclosures)
        {
            if (disclosures == null) return;

            foreach (var disclosure in disclosures)
            {
                disclosure.DisclosureType = DisclosureTypes.GetExplanation(disclosure.DisclosureType);
            }

        }

        #endregion

    }
}
