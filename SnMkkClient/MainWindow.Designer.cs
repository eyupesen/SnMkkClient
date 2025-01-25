namespace SnMkkClient
{
    partial class MainWindow
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(51, 61, 81);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(988, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(56, 20);
            fileToolStripMenuItem.Text = "Ayarlar";
            // 
            // listView_members
            // 
            listView_members.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView_members.BorderStyle = BorderStyle.None;
            listView_members.Columns.AddRange(new ColumnHeader[] { columnHeader_id, columnHeader_title, columnHeader_stockCode, columnHeader_memberType, columnHeader_url });
            listView_members.FullRowSelect = true;
            listView_members.Location = new Point(12, 84);
            listView_members.Name = "listView_members";
            listView_members.Size = new Size(964, 494);
            listView_members.TabIndex = 1;
            listView_members.UseCompatibleStateImageBehavior = false;
            listView_members.View = View.Details;
            listView_members.ItemActivate += listView_members_ItemActivate;
            listView_members.DoubleClick += listView_members_DoubleClick;
            // 
            // columnHeader_id
            // 
            columnHeader_id.Text = "Id";
            // 
            // columnHeader_title
            // 
            columnHeader_title.Text = "Şirket";
            columnHeader_title.Width = 300;
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
            columnHeader_url.Width = 300;
            // 
            // label_member
            // 
            label_member.AutoSize = true;
            label_member.Font = new Font("Segoe UI Semilight", 14F);
            label_member.ForeColor = Color.White;
            label_member.Location = new Point(12, 16);
            label_member.Name = "label_member";
            label_member.Size = new Size(89, 25);
            label_member.TabIndex = 2;
            label_member.Text = "Şirket Adı";
            // 
            // textBox_membersSearch
            // 
            textBox_membersSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_membersSearch.BorderStyle = BorderStyle.FixedSingle;
            textBox_membersSearch.Font = new Font("Segoe UI", 14F);
            textBox_membersSearch.Location = new Point(107, 13);
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
            button_memberSearch.Location = new Point(647, 14);
            button_memberSearch.Name = "button_memberSearch";
            button_memberSearch.Size = new Size(100, 30);
            button_memberSearch.TabIndex = 4;
            button_memberSearch.Text = "Ara";
            button_memberSearch.UseVisualStyleBackColor = false;
            button_memberSearch.Click += button_memberSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 61, 81);
            panel1.Controls.Add(label_member);
            panel1.Controls.Add(button_memberSearch);
            panel1.Controls.Add(textBox_membersSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 57);
            panel1.TabIndex = 5;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 61, 81);
            ClientSize = new Size(988, 590);
            Controls.Add(panel1);
            Controls.Add(listView_members);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Form1";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
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
    }
}
