using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnMkkClient.MkkEntity;
using System.Reflection;
using System.Text.Json;
using System.Collections;
using System.Text.RegularExpressions;
using SnMkkClient.MkkApi;
using System.Diagnostics;
using SnMkkClient.AppEntity;

namespace SnMkkClient
{
    public partial class MemberDetailForm : Form
    {
        public MemberDetailForm()
        {
            InitializeComponent();
        }

        HttpClient Client = new HttpClient();

        Member MemberInformation;
        List<MemberDetail> MemberDetails;
        List<Disclosure> Disclosures;

        public MemberDetailForm(Member member, List<MemberDetail>? memberDetails, List<Disclosure>? disclosures)
        {
            MemberInformation = member ?? new Member();
            MemberDetails = memberDetails ?? new List<MemberDetail>();
            Disclosures = disclosures ?? new List<Disclosure>();

            InitializeComponent();
        }


        #region Form Events

        private void MemberDetailForm_Load(object sender, EventArgs e)
        {
            KapApi.PrepareClient(Client, App.Settings.UserName, App.Settings.Password);
            FillScreen();
        }

        private async void dataGridView_disclosures_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                try
                {
                    DisclosureDetail? disclosureDetail = await KapApi.GetDisclosureDetail(Client, dataGridView_disclosures.Rows[e.RowIndex].Cells[0].Value.ToString());
                    dataGridView_disclosures.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.LimeGreen;
                    dataGridView_disclosureDetail.DataSource = SetDisclosureDetailDataSource(disclosureDetail);
                    dataGridView_disclosureDetail.Columns["Key"].HeaderText = "Başlık";
                    dataGridView_disclosureDetail.Columns["Value"].HeaderText = "Değer";
                    foreach (DataGridViewColumn col in dataGridView_disclosureDetail.Columns)
                    {
                        if (col.Name == "Key")
                        {
                            col.Width = 120;
                        }
                        else
                        {
                            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                    foreach (DataGridViewRow row in dataGridView_disclosureDetail.Rows)
                    {
                        if (row.Cells["Key"].Value.ToString().StartsWith("Attachment"))
                        {
                            row.Cells["Key"].Style.BackColor = Color.FromArgb(255, 224, 224);
                        }
                    }

                }
                catch (Exception ex)
                {
                    dataGridView_disclosures.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.Crimson;
                    dataGridView_disclosures.Rows[e.RowIndex].Cells[0].ToolTipText = ex.Message;
                }
            }
        }

        private async void dataGridView_disclosureDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && dataGridView_disclosureDetail.Rows[e.RowIndex].Cells[0].Value.ToString().StartsWith("Attachment"))
            {
                string[] urlArray = dataGridView_disclosureDetail.Rows[e.RowIndex].Cells[1].Value.ToString().Split(" : https://vykapialpha.mkk.com.tr/api/vyk/downloadAttachment/");
                string[] extensionArray = urlArray[0].Split(".");
                string extension = extensionArray[extensionArray.Length - 1];

                byte[] fileBytes = await KapApi.GetAttachment(Client, urlArray[1]);

                using (MemoryStream memoryStream = new MemoryStream(fileBytes))
                {
                    if (fileBytes.Length > 0)
                    {
                        string tempFilePath = Path.GetTempFileName() + "." + extension;
                        File.WriteAllBytes(tempFilePath, memoryStream.ToArray());
                        Process.Start(new ProcessStartInfo(tempFilePath) { UseShellExecute = true });
                    }
                    else
                    {
                        MessageBox.Show("Dosyaya erişilemedi.");
                    }
                }
            }
        }

        #endregion


        #region Sub Methods

        private void FillScreen()
        {
            label_memberTitle.Text = "       " + MemberInformation.Title;
            this.Text = MemberInformation.Title;


            dataGridView_memberDetails.DataSource = SetMemberDetailDataSource(MemberDetails);


            dataGridView_disclosures.DataSource = SetDisclosureDataSource(Disclosures);
            dataGridView_disclosures.Columns["Index"].HeaderText = "Id";
            dataGridView_disclosures.Columns["Type"].HeaderText = "Bildirim Tipi";
            dataGridView_disclosures.Columns["SubReports"].HeaderText = "Alt Rapor";

            foreach (DataGridViewColumn col in dataGridView_memberDetails.Columns)
            {
                if (col.Name == "Title")
                {
                    col.Width = 360;
                }
                else
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            foreach (DataGridViewRow row in dataGridView_memberDetails.Rows)
            {
                row.Cells[0].Style.BackColor = Color.FromArgb(217, 225, 242);
            }

            foreach (DataGridViewColumn col in dataGridView_disclosures.Columns)
            {
                if (col.Name != "SubReports")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private DataTable SetMemberDetailDataSource(List<MemberDetail> memberDetails)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Title", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Value", typeof(string)));

            if (memberDetails == null) { return dataTable; }

            memberDetails.OrderBy(x => x.Key);

            foreach (MemberDetail member in memberDetails)
            {
                if (member == null || member.Value == null) continue;

                if (member.Value.GetType() != typeof(JsonElement) && member.Value.GetType() != typeof(string))
                {
                    var value = ProcessObjectAsList(member.Value);
                    dataTable.Rows.Add(member.NameTr.Trim(), value);
                }
                else if (member.Value.ToString().Length > 1 && member.Value.ToString().Substring(0, 1) != "[")
                {
                    dataTable.Rows.Add(member.NameTr.Trim(), member.Value.ToString());
                }
            }

            return dataTable;
        }

        private DataTable SetDisclosureDataSource(List<Disclosure> disclosures)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Index", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Type", typeof(string)));
            dataTable.Columns.Add(new DataColumn("SubReports", typeof(string)));

            if (disclosures == null) { return dataTable; }

            foreach (Disclosure member in disclosures)
            {
                if (member == null || member.DisclosureIndex == null) continue;

                if (member.DisclosureIndex.ToString().Length > 1)
                {
                    dataTable.Rows.Add(member.DisclosureIndex.Trim(),
                                       member.DisclosureType.ToString(),
                                       member.SubReportIds != null ? ClearSubReportIds(member.SubReportIds) : "");
                }
            }

            dataTable.DefaultView.Sort = "Index DESC";

            return dataTable;
        }

        private DataTable SetDisclosureDetailDataSource(DisclosureDetail? disclosureDetail)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Title", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Value", typeof(string)));

            if (disclosureDetail == null)
            {
                return dataTable;
            }
            else
            {
                dataTable = GetPropertiesAsDataTable(disclosureDetail);

                var extrasDict = GetExtrasForDisclosureDetails(disclosureDetail);

                AddExtrasToDataTable(extrasDict, dataTable);
            }


            return dataTable;
        }

        private string ProcessObjectAsList(object obj)
        {
            if (obj is IEnumerable list)
            {
                var sb = new StringBuilder();

                var stringList = new List<string>();
                foreach (var item in list)
                {
                    stringList.Add(GetPropertiesAsString(item));
                }

                sb.AppendJoin(Environment.NewLine, stringList);

                return sb.ToString();
            }
            else
            {
                return "Verilen obje bir liste değil.";
            }
        }

        private string GetPropertiesAsString(object obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));

            var properties = obj.GetType().GetProperties();
            var sb = new StringBuilder();

            foreach (var property in properties)
            {
                if (property.GetValue(obj) != null)
                {
                    string name = GetTurkishTitle(property.Name, MemberDict.propertyDictionary);
                    object value = property.GetValue(obj) ?? "null";

                    if (typeof(MkkEntity.KeyText) == value.GetType())
                    {
                        var keyText = (MkkEntity.KeyText)value;
                        value = keyText.Text;
                    }

                    sb.AppendLine($"{name}: {value}");
                }
            }

            return sb.ToString();
        }

        private string GetTurkishTitle(string key, Dictionary<string, string> dictionary)
        {
            if (key != null && dictionary.ContainsKey(key.Trim()))
            {
                return dictionary[key.Trim()];
            }
            else if (key == null)
            {
                return "";
            }

            return key;
        }

        private DataTable GetPropertiesAsDataTable(object obj)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Key", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Value", typeof(string)));

            if (obj == null) throw new ArgumentNullException(nameof(obj));

            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.GetValue(obj) != null)
                {
                    string name = GetTurkishTitle(property.Name, DisclosureDict.propertyDictionary);
                    object value;
                    if (typeof(string) == property.GetValue(obj).GetType())
                    {
                        value = property.GetValue(obj) ?? "null";
                        dataTable.Rows.Add(name, value);
                    }
                }
            }

            return dataTable;
        }

        private Dictionary<string, List<ReportItemValue>> GetExtrasForDisclosureDetails(DisclosureDetail? disclosureDetail)
        {
            Dictionary<string, List<ReportItemValue>> keyValuePairs = new Dictionary<string, List<ReportItemValue>>();
            if (disclosureDetail != null)
            {
                if (disclosureDetail.Presentation != null && disclosureDetail.Presentation.Count > 0)
                {
                    foreach (var prs in disclosureDetail.Presentation)
                    {
                        if (prs.Content != null && prs.Content.ReportItem != null)
                        {
                            foreach (var rptItemL1 in prs.Content.ReportItem)
                            {
                                if (rptItemL1 != null && rptItemL1.ReportItem != null)
                                {
                                    foreach (var rptItemL2 in rptItemL1.ReportItem)
                                    {
                                        if (rptItemL2 != null && rptItemL2.ReportItem != null)
                                        {
                                            foreach (var rptItemL3 in rptItemL2.ReportItem)
                                            {
                                                if (rptItemL3 != null)
                                                {
                                                    if (rptItemL3.Name != null && rptItemL3.Values != null && rptItemL3.Values.ValueList != null)
                                                    {
                                                        string keyL3 = rptItemL3.Name;
                                                        bool isKeyAddedL3 = keyValuePairs.ContainsKey(keyL3);
                                                        foreach (var val in rptItemL3.Values.ValueList)
                                                        {
                                                            if (val != null)
                                                            {
                                                                if (!string.IsNullOrEmpty(val.Value))
                                                                {
                                                                    val.Value = Regex.Replace(val.Value, "<.*?>", string.Empty, RegexOptions.Singleline);
                                                                    val.Value = val.Value.Replace("&amp;", "").Replace("&nbsp;", " ");
                                                                }
                                                                if (isKeyAddedL3)
                                                                {
                                                                    keyValuePairs[keyL3].Add(val);
                                                                }
                                                                else
                                                                {
                                                                    keyValuePairs.Add(keyL3, new List<ReportItemValue> { val });
                                                                    isKeyAddedL3 = true;
                                                                }
                                                            }
                                                        }
                                                    }


                                                    if (rptItemL3.ReportItem != null)
                                                    {
                                                        foreach (var rptItemL4 in rptItemL3.ReportItem)
                                                        {
                                                            if (rptItemL4.Name != null && rptItemL4.Values != null && rptItemL4.Values.ValueList != null)
                                                            {
                                                                string keyL4 = rptItemL4.Name;
                                                                bool isKeyAddedL4 = keyValuePairs.ContainsKey(keyL4);
                                                                foreach (var val in rptItemL4.Values.ValueList)
                                                                {
                                                                    if (val != null)
                                                                    {
                                                                        if (!string.IsNullOrEmpty(val.Value))
                                                                        {
                                                                            val.Value = Regex.Replace(val.Value, "<.*?>", string.Empty, RegexOptions.Singleline);
                                                                            val.Value = val.Value.Replace("&amp;", "").Replace("&nbsp;", " ");
                                                                        }
                                                                        if (isKeyAddedL4)
                                                                        {
                                                                            keyValuePairs[keyL4].Add(val);
                                                                        }
                                                                        else
                                                                        {
                                                                            keyValuePairs.Add(keyL4, new List<ReportItemValue> { val });
                                                                            isKeyAddedL4 = true;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                if (disclosureDetail.AttachmentUrls != null && disclosureDetail.AttachmentUrls.Count > 0)
                {
                    string keyAttachments = "Attachment ";
                    int attachmentCount = 1;
                    foreach (var file in disclosureDetail.AttachmentUrls)
                    {
                        var fileUrlInfo = new ReportItemValue()
                        {
                            ContextId = file.Url ?? string.Empty,
                            Value = (file.FileName ?? string.Empty) + " : " + (file.Url ?? string.Empty)
                        };
                        keyValuePairs.Add(keyAttachments + attachmentCount++.ToString().PadLeft(2, '0'), new List<ReportItemValue>() { fileUrlInfo });
                    }
                }
            }

            return keyValuePairs;
        }

        private void AddExtrasToDataTable(Dictionary<string, List<ReportItemValue>> extras, DataTable dataTable)
        {
            if (extras == null || extras.Count == 0) return;
            foreach (var key in extras.Keys)
            {
                dataTable.Rows.Add(key, string.Join(", ", extras[key].Where(x => !string.IsNullOrEmpty(x.Value)).Select(x => x.Value)));
            }
        }

        private string ClearSubReportIds(List<string> subReportIds)
        {
            var strb = new StringBuilder();
            if (subReportIds == null || subReportIds.Count == 0) return "";

            foreach (string subReportId in subReportIds)
            {
                if (subReportId == null) continue;
                strb.AppendJoin(' ', Regex.Replace(subReportId, @"\d", "").Split(new char[] { '-', '_' }, StringSplitOptions.RemoveEmptyEntries));
            }

            return strb.ToString().Replace("oda ", "");
        }

        #endregion


    }
}


