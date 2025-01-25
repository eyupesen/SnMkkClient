using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

                    foreach (var md in memberDetails)
                    {
                        if (md.Key == "kpy41_acc5_sermayede_dogrudan" && md.Value != null)
                        {
                            var shareholderList = JsonSerializer.Deserialize<List<ShareholderInfo>>(md.Value.ToString());
                            md.Value = shareholderList;
                        }
                    }
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
    }
}
