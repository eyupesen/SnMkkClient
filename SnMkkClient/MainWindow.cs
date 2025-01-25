using System.Net.Http.Headers;
using System.Text;
using SnMkkClient.MkkEntity;
using System.Text.Json;
using System.Data;
using SnMkkClient.MkkApi;

namespace SnMkkClient
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        HttpClient Client = new HttpClient();
        List<Member> memberList = new List<Member>();

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            KapApi.PrepareClient(Client, "b1c48596-e3d9-4495-9957-b8e39c9bf7ac", "ef6851bb-0aee-48a8-aee1-8ab224455cde");
            List<Member> members = await KapApi.GetMembers(Client);

            if (members != null)
            {
                memberList = members;
                SetTextBoxMembersAutoCompletion(members.FindAll(x => !string.IsNullOrWhiteSpace(x.Title)).Select(x => x.Title).ToList());
                Deneme(members);
            }

        }



        private void FillDGVMembers(List<Member> memberList)
        {
            listView_members.Items.Clear();
            if (listView_members != null)
            {
                foreach (var mem in memberList)
                {
                    var lvi = new ListViewItem(mem.Id);
                    lvi.SubItems.Add(mem.Title);
                    lvi.SubItems.Add(mem.StockCode);
                    lvi.SubItems.Add(mem.MemberType);
                    lvi.SubItems.Add(mem.KfifUrl);
                    listView_members.Items.Add(lvi);
                }
            }

            listView_members.GridLines = true;
        }

        void SetTextBoxMembersAutoCompletion(List<string> memberList)
        {
            textBox_membersSearch.AutoCompleteMode = AutoCompleteMode.Suggest; // Öneri ve ekleme modu
            textBox_membersSearch.AutoCompleteSource = AutoCompleteSource.CustomSource; // Özel kaynak

            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            source.AddRange(memberList.ToArray());

            textBox_membersSearch.AutoCompleteCustomSource = source;

        }

        private void button_memberSearch_Click(object sender, EventArgs e)
        {
            var filteredMemberList = memberList.FindAll(x => (!string.IsNullOrEmpty(x.Title) && x.Title.ToLower().Contains(textBox_membersSearch.Text.ToLower())) ||
                                                             (!string.IsNullOrEmpty(x.StockCode) && x.StockCode.ToLower().Contains(textBox_membersSearch.Text.ToLower())));

            FillDGVMembers(filteredMemberList);
        }

        private void listView_members_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listView_members_ItemActivate(object sender, EventArgs e)
        {
            if (listView_members.SelectedItems.Count > 0)
            {
                var selectedItem = listView_members.SelectedItems[0];
                KapApi.GetMemberDetail(Client, selectedItem.Text);
            }
        }

        private async void Deneme(List<Member> members)
        {
            List<MemberDetail> list = new List<MemberDetail>();
            foreach (Member member in members.Take(250))
            {
                var memberdet = await KapApi.GetMemberDetail(Client, member.Id);
                list.AddRange(memberdet);
                await Task.Delay(5000);
            }
            var stop = "stop";
        }
    }
}
