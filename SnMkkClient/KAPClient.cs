using System.Net.Http.Headers;
using System.Text;
using SnMkkClient.MkkEntity;
using System.Text.Json;
using System.Data;
using SnMkkClient.MkkApi;
using Microsoft.VisualBasic.ApplicationServices;
using SnMkkClient.Helpers;
using SnMkkClient.AppEntity;

namespace SnMkkClient
{
    public partial class KAPClient : Form
    {
        public KAPClient()
        {
            InitializeComponent();
        }

        HttpClient Client = new HttpClient();
        List<Member> memberList = new List<Member>();

        public static string AppDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KapClient";
        public static string AppDataSettingsFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KapClient\Settings.dat";


        #region Form Events

        private async void KAPClient_Load(object sender, EventArgs e)
        {
            GetSettings();
            KapApi.PrepareClient(Client, App.Settings.UserName, App.Settings.Password);
            List<Member> members = await KapApi.GetMembers(Client);

            if (members != null)
            {
                memberList = members;
                SetTextBoxMembersAutoCompletion(members.FindAll(x => !string.IsNullOrWhiteSpace(x.Title)).Select(x => x.Title).ToList());
                button_memberSearch.PerformClick();
            }


        }

        private void KAPClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializationHelper.Serialization(App.Settings, AppDataSettingsFilePath);
        }

        private void button_memberSearch_Click(object sender, EventArgs e)
        {
            var filteredMemberList = memberList.FindAll(x => (!string.IsNullOrEmpty(x.Title) && x.Title.ToLower().Contains(textBox_membersSearch.Text.ToLower())) ||
                                                             (!string.IsNullOrEmpty(x.StockCode) && x.StockCode.ToLower().Contains(textBox_membersSearch.Text.ToLower())));

            FillDGVMembers(filteredMemberList);
        }

        private async void listView_members_ItemActivate(object sender, EventArgs e)
        {
            if (listView_members.SelectedItems.Count > 0)
            {
                var selectedItem = listView_members.SelectedItems[0];
                var selectedMember = memberList.Find(x => x.Id == selectedItem.Text);
                var selectedMemberDetail = await KapApi.GetMemberDetail(Client, selectedItem.Text);

                var selectedMemberDisclosures = await KapApi.GetDisclosures(Client, selectedItem.Text);

                MemberDetailForm mdf = new MemberDetailForm(selectedMember, selectedMemberDetail, selectedMemberDisclosures);
                mdf.Show();

            }
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            AppSettings settings = new AppSettings();
            settings.ShowDialog();
        }

        #endregion


        #region Sub Methods

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

        private void SetTextBoxMembersAutoCompletion(List<string> memberList)
        {
            textBox_membersSearch.AutoCompleteMode = AutoCompleteMode.Suggest; // Öneri ve ekleme modu
            textBox_membersSearch.AutoCompleteSource = AutoCompleteSource.CustomSource; // Özel kaynak

            AutoCompleteStringCollection source = new AutoCompleteStringCollection();

            source.AddRange(memberList.ToArray());

            textBox_membersSearch.AutoCompleteCustomSource = source;

        }

        private void GetSettings()
        {
            bool needToOpenSettings = false;
            if (!Directory.Exists(AppDataFolderPath))
            {
                Directory.CreateDirectory(AppDataFolderPath);
                needToOpenSettings = true;
            }
            else if (!File.Exists(AppDataSettingsFilePath))
            {
                needToOpenSettings = true;
            }
            else if (File.Exists(AppDataSettingsFilePath))
            {
                App.Settings = (SnMkkClient.AppEntity.Settings)SerializationHelper.DeSerialization(App.Settings, AppDataSettingsFilePath);

                if (App.Settings == null || string.IsNullOrEmpty(App.Settings.UserName) || string.IsNullOrEmpty(App.Settings.Password))
                {
                    needToOpenSettings = true;
                }
            }
            if (needToOpenSettings)
            {
                MessageBox.Show("KAP için API kullanıcı adı ve şifresini girmelisiniz.", "Kullanıcı adı ve şifre giriniz.");
                AppSettings settings = new AppSettings();
                settings.ShowDialog();
            }
        }

        #endregion

    }
}
