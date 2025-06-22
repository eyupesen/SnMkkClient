namespace SnMkkClient
{
    partial class MemberDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDetailForm));
            label_memberTitle = new Label();
            dataGridView_memberDetails = new DataGridView();
            label_dgwTitle = new Label();
            label_disclosures = new Label();
            dataGridView_disclosures = new DataGridView();
            splitContainer_header = new SplitContainer();
            splitContainer_kunye = new SplitContainer();
            label2 = new Label();
            label1 = new Label();
            label_disclosureDetails = new Label();
            dataGridView_disclosureDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_memberDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_disclosures).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer_header).BeginInit();
            splitContainer_header.Panel1.SuspendLayout();
            splitContainer_header.Panel2.SuspendLayout();
            splitContainer_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_kunye).BeginInit();
            splitContainer_kunye.Panel1.SuspendLayout();
            splitContainer_kunye.Panel2.SuspendLayout();
            splitContainer_kunye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_disclosureDetail).BeginInit();
            SuspendLayout();
            // 
            // label_memberTitle
            // 
            label_memberTitle.Dock = DockStyle.Fill;
            label_memberTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label_memberTitle.ForeColor = Color.FromArgb(51, 61, 81);
            label_memberTitle.Image = Properties.Resources.office_building_48;
            label_memberTitle.ImageAlign = ContentAlignment.MiddleLeft;
            label_memberTitle.Location = new Point(10, 2);
            label_memberTitle.Name = "label_memberTitle";
            label_memberTitle.Size = new Size(1502, 60);
            label_memberTitle.TabIndex = 0;
            label_memberTitle.Text = "       FİRMA SANAYİ VE TİCARET ANONİM ŞİRKETİ";
            label_memberTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView_memberDetails
            // 
            dataGridView_memberDetails.AllowUserToAddRows = false;
            dataGridView_memberDetails.AllowUserToResizeRows = false;
            dataGridView_memberDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_memberDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_memberDetails.BackgroundColor = Color.WhiteSmoke;
            dataGridView_memberDetails.BorderStyle = BorderStyle.None;
            dataGridView_memberDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_memberDetails.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(7);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_memberDetails.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_memberDetails.GridColor = Color.White;
            dataGridView_memberDetails.Location = new Point(6, 26);
            dataGridView_memberDetails.Name = "dataGridView_memberDetails";
            dataGridView_memberDetails.ReadOnly = true;
            dataGridView_memberDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_memberDetails.RowHeadersVisible = false;
            dataGridView_memberDetails.Size = new Size(941, 782);
            dataGridView_memberDetails.TabIndex = 1;
            // 
            // label_dgwTitle
            // 
            label_dgwTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_dgwTitle.BackColor = Color.FromArgb(51, 61, 81);
            label_dgwTitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_dgwTitle.ForeColor = Color.White;
            label_dgwTitle.Image = Properties.Resources.label;
            label_dgwTitle.ImageAlign = ContentAlignment.MiddleLeft;
            label_dgwTitle.Location = new Point(7, 0);
            label_dgwTitle.Name = "label_dgwTitle";
            label_dgwTitle.Padding = new Padding(5, 0, 0, 0);
            label_dgwTitle.Size = new Size(940, 26);
            label_dgwTitle.TabIndex = 2;
            label_dgwTitle.Text = "      Künye";
            label_dgwTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_disclosures
            // 
            label_disclosures.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_disclosures.BackColor = Color.FromArgb(51, 61, 81);
            label_disclosures.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_disclosures.ForeColor = Color.White;
            label_disclosures.Image = Properties.Resources.notification;
            label_disclosures.ImageAlign = ContentAlignment.MiddleLeft;
            label_disclosures.Location = new Point(1, 0);
            label_disclosures.Name = "label_disclosures";
            label_disclosures.Padding = new Padding(5, 0, 0, 0);
            label_disclosures.Size = new Size(561, 26);
            label_disclosures.TabIndex = 4;
            label_disclosures.Text = "      Son Bildirimler";
            label_disclosures.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView_disclosures
            // 
            dataGridView_disclosures.AllowUserToAddRows = false;
            dataGridView_disclosures.AllowUserToResizeRows = false;
            dataGridView_disclosures.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_disclosures.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_disclosures.BackgroundColor = Color.WhiteSmoke;
            dataGridView_disclosures.BorderStyle = BorderStyle.None;
            dataGridView_disclosures.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Orange;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_disclosures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_disclosures.ColumnHeadersHeight = 36;
            dataGridView_disclosures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(7, 4, 7, 4);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_disclosures.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_disclosures.EnableHeadersVisualStyles = false;
            dataGridView_disclosures.GridColor = Color.White;
            dataGridView_disclosures.Location = new Point(0, 26);
            dataGridView_disclosures.Name = "dataGridView_disclosures";
            dataGridView_disclosures.ReadOnly = true;
            dataGridView_disclosures.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_disclosures.RowHeadersVisible = false;
            dataGridView_disclosures.Size = new Size(562, 317);
            dataGridView_disclosures.TabIndex = 3;
            dataGridView_disclosures.CellDoubleClick += dataGridView_disclosures_CellDoubleClick;
            // 
            // splitContainer_header
            // 
            splitContainer_header.Dock = DockStyle.Fill;
            splitContainer_header.FixedPanel = FixedPanel.Panel1;
            splitContainer_header.IsSplitterFixed = true;
            splitContainer_header.Location = new Point(0, 0);
            splitContainer_header.Name = "splitContainer_header";
            splitContainer_header.Orientation = Orientation.Horizontal;
            // 
            // splitContainer_header.Panel1
            // 
            splitContainer_header.Panel1.Controls.Add(label_memberTitle);
            splitContainer_header.Panel1.Padding = new Padding(10, 2, 10, 2);
            splitContainer_header.Panel1MinSize = 64;
            // 
            // splitContainer_header.Panel2
            // 
            splitContainer_header.Panel2.Controls.Add(splitContainer_kunye);
            splitContainer_header.Size = new Size(1522, 881);
            splitContainer_header.SplitterDistance = 64;
            splitContainer_header.SplitterWidth = 1;
            splitContainer_header.TabIndex = 5;
            // 
            // splitContainer_kunye
            // 
            splitContainer_kunye.Dock = DockStyle.Fill;
            splitContainer_kunye.Location = new Point(0, 0);
            splitContainer_kunye.Name = "splitContainer_kunye";
            // 
            // splitContainer_kunye.Panel1
            // 
            splitContainer_kunye.Panel1.Controls.Add(label_dgwTitle);
            splitContainer_kunye.Panel1.Controls.Add(dataGridView_memberDetails);
            splitContainer_kunye.Panel1MinSize = 950;
            // 
            // splitContainer_kunye.Panel2
            // 
            splitContainer_kunye.Panel2.Controls.Add(label2);
            splitContainer_kunye.Panel2.Controls.Add(label1);
            splitContainer_kunye.Panel2.Controls.Add(label_disclosureDetails);
            splitContainer_kunye.Panel2.Controls.Add(dataGridView_disclosureDetail);
            splitContainer_kunye.Panel2.Controls.Add(label_disclosures);
            splitContainer_kunye.Panel2.Controls.Add(dataGridView_disclosures);
            splitContainer_kunye.Panel2.Padding = new Padding(0, 0, 6, 0);
            splitContainer_kunye.Size = new Size(1522, 816);
            splitContainer_kunye.SplitterDistance = 950;
            splitContainer_kunye.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.FromArgb(51, 61, 81);
            label2.Font = new Font("Segoe UI", 8F);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(128, 355);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 0, 0, 0);
            label2.Size = new Size(303, 22);
            label2.TabIndex = 8;
            label2.Text = "Açmak istediğiniz ek dosyasına çift tıklayınız.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(51, 61, 81);
            label1.Font = new Font("Segoe UI", 8F);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(128, 3);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 0, 0, 0);
            label1.Size = new Size(303, 22);
            label1.TabIndex = 7;
            label1.Text = "Detayını görmek istediğiniz bildirime çift tıklayınız.";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label_disclosureDetails
            // 
            label_disclosureDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_disclosureDetails.BackColor = Color.FromArgb(51, 61, 81);
            label_disclosureDetails.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_disclosureDetails.ForeColor = Color.White;
            label_disclosureDetails.Image = Properties.Resources.stack_of_sheets;
            label_disclosureDetails.ImageAlign = ContentAlignment.MiddleLeft;
            label_disclosureDetails.Location = new Point(1, 352);
            label_disclosureDetails.Name = "label_disclosureDetails";
            label_disclosureDetails.Padding = new Padding(5, 0, 0, 0);
            label_disclosureDetails.Size = new Size(561, 26);
            label_disclosureDetails.TabIndex = 6;
            label_disclosureDetails.Text = "      Bildirim Detayı";
            label_disclosureDetails.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView_disclosureDetail
            // 
            dataGridView_disclosureDetail.AllowUserToAddRows = false;
            dataGridView_disclosureDetail.AllowUserToResizeRows = false;
            dataGridView_disclosureDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_disclosureDetail.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_disclosureDetail.BackgroundColor = Color.WhiteSmoke;
            dataGridView_disclosureDetail.BorderStyle = BorderStyle.None;
            dataGridView_disclosureDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Orange;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView_disclosureDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_disclosureDetail.ColumnHeadersHeight = 36;
            dataGridView_disclosureDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(7, 4, 7, 4);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 128, 255);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView_disclosureDetail.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView_disclosureDetail.EnableHeadersVisualStyles = false;
            dataGridView_disclosureDetail.GridColor = Color.White;
            dataGridView_disclosureDetail.Location = new Point(0, 378);
            dataGridView_disclosureDetail.Name = "dataGridView_disclosureDetail";
            dataGridView_disclosureDetail.ReadOnly = true;
            dataGridView_disclosureDetail.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_disclosureDetail.RowHeadersVisible = false;
            dataGridView_disclosureDetail.Size = new Size(562, 430);
            dataGridView_disclosureDetail.TabIndex = 5;
            dataGridView_disclosureDetail.CellDoubleClick += dataGridView_disclosureDetail_CellDoubleClick;
            // 
            // MemberDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1522, 881);
            Controls.Add(splitContainer_header);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MemberDetailForm";
            Text = "MemberDetailForm";
            Load += MemberDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_memberDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_disclosures).EndInit();
            splitContainer_header.Panel1.ResumeLayout(false);
            splitContainer_header.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_header).EndInit();
            splitContainer_header.ResumeLayout(false);
            splitContainer_kunye.Panel1.ResumeLayout(false);
            splitContainer_kunye.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_kunye).EndInit();
            splitContainer_kunye.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_disclosureDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_memberTitle;
        private DataGridView dataGridView_memberDetails;
        private Label label_dgwTitle;
        private Label label_disclosures;
        private DataGridView dataGridView_disclosures;
        private SplitContainer splitContainer_header;
        private SplitContainer splitContainer_kunye;
        private Label label_disclosureDetails;
        private DataGridView dataGridView_disclosureDetail;
        private Label label2;
        private Label label1;
    }
}