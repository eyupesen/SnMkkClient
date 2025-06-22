namespace SnMkkClient
{
    partial class KAPClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KAPClient));
            listView_members = new ListView();
            columnHeader_id = new ColumnHeader();
            columnHeader_title = new ColumnHeader();
            columnHeader_stockCode = new ColumnHeader();
            columnHeader_memberType = new ColumnHeader();
            columnHeader_url = new ColumnHeader();
            label_member = new Label();
            textBox_membersSearch = new TextBox();
            button_memberSearch = new Button();
            panel1 = new Panel();
            button_settings = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listView_members
            // 
            listView_members.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_members.BorderStyle = BorderStyle.None;
            listView_members.Columns.AddRange(new ColumnHeader[] { columnHeader_id, columnHeader_title, columnHeader_stockCode, columnHeader_memberType, columnHeader_url });
            listView_members.FullRowSelect = true;
            listView_members.Location = new Point(12, 63);
            listView_members.Name = "listView_members";
            listView_members.Size = new Size(1240, 606);
            listView_members.TabIndex = 1;
            listView_members.UseCompatibleStateImageBehavior = false;
            listView_members.View = View.Details;
            listView_members.ItemActivate += listView_members_ItemActivate;
            // 
            // columnHeader_id
            // 
            columnHeader_id.Text = "Id";
            // 
            // columnHeader_title
            // 
            columnHeader_title.Text = "Şirket";
            columnHeader_title.Width = 480;
            // 
            // columnHeader_stockCode
            // 
            columnHeader_stockCode.Text = "Hisse Kodu";
            columnHeader_stockCode.Width = 100;
            // 
            // columnHeader_memberType
            // 
            columnHeader_memberType.Text = "Üye Tipi";
            columnHeader_memberType.Width = 100;
            // 
            // columnHeader_url
            // 
            columnHeader_url.Text = "URL";
            columnHeader_url.Width = 360;
            // 
            // label_member
            // 
            label_member.Font = new Font("Segoe UI Semilight", 14F);
            label_member.ForeColor = Color.White;
            label_member.Image = Properties.Resources.office_building;
            label_member.ImageAlign = ContentAlignment.MiddleLeft;
            label_member.Location = new Point(12, 16);
            label_member.Name = "label_member";
            label_member.Size = new Size(155, 30);
            label_member.TabIndex = 2;
            label_member.Text = "Firma Arama";
            label_member.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox_membersSearch
            // 
            textBox_membersSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_membersSearch.BorderStyle = BorderStyle.FixedSingle;
            textBox_membersSearch.Font = new Font("Segoe UI", 14F);
            textBox_membersSearch.Location = new Point(173, 16);
            textBox_membersSearch.Name = "textBox_membersSearch";
            textBox_membersSearch.Size = new Size(534, 32);
            textBox_membersSearch.TabIndex = 3;
            // 
            // button_memberSearch
            // 
            button_memberSearch.BackColor = Color.WhiteSmoke;
            button_memberSearch.FlatAppearance.BorderSize = 0;
            button_memberSearch.FlatStyle = FlatStyle.Flat;
            button_memberSearch.Font = new Font("Segoe UI", 12F);
            button_memberSearch.Image = Properties.Resources.loupe_16;
            button_memberSearch.ImageAlign = ContentAlignment.MiddleLeft;
            button_memberSearch.Location = new Point(713, 17);
            button_memberSearch.Name = "button_memberSearch";
            button_memberSearch.Padding = new Padding(10, 0, 10, 0);
            button_memberSearch.Size = new Size(108, 30);
            button_memberSearch.TabIndex = 4;
            button_memberSearch.Text = "Filtrele";
            button_memberSearch.TextAlign = ContentAlignment.MiddleRight;
            button_memberSearch.UseVisualStyleBackColor = false;
            button_memberSearch.Click += button_memberSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 61, 81);
            panel1.Controls.Add(button_settings);
            panel1.Controls.Add(label_member);
            panel1.Controls.Add(button_memberSearch);
            panel1.Controls.Add(textBox_membersSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 57);
            panel1.TabIndex = 5;
            // 
            // button_settings
            // 
            button_settings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_settings.FlatAppearance.BorderSize = 0;
            button_settings.FlatStyle = FlatStyle.Flat;
            button_settings.Image = Properties.Resources.settings;
            button_settings.Location = new Point(1222, 16);
            button_settings.Name = "button_settings";
            button_settings.Size = new Size(30, 30);
            button_settings.TabIndex = 5;
            button_settings.UseVisualStyleBackColor = true;
            button_settings.Click += button_settings_Click;
            // 
            // KAPClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 61, 81);
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(listView_members);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "KAPClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SN MKK KAP Client";
            FormClosing += KAPClient_FormClosing;
            Load += KAPClient_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView listView_members;
        private ColumnHeader columnHeader_id;
        private ColumnHeader columnHeader_title;
        private ColumnHeader columnHeader_stockCode;
        private ColumnHeader columnHeader_memberType;
        private ColumnHeader columnHeader_url;
        private Label label_member;
        private TextBox textBox_membersSearch;
        private Button button_memberSearch;
        private Panel panel1;
        private Button button_settings;
    }
}
