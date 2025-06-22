namespace SnMkkClient
{
    partial class AppSettings
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
            groupBox_kapUserName = new GroupBox();
            textBox_kapUserName = new TextBox();
            label2 = new Label();
            groupBox_kapPassword = new GroupBox();
            textBox_kapPassword = new TextBox();
            label1 = new Label();
            button_save = new Button();
            button_cancel = new Button();
            groupBox_kapUserName.SuspendLayout();
            groupBox_kapPassword.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_kapUserName
            // 
            groupBox_kapUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_kapUserName.Controls.Add(textBox_kapUserName);
            groupBox_kapUserName.Controls.Add(label2);
            groupBox_kapUserName.Location = new Point(12, 12);
            groupBox_kapUserName.Name = "groupBox_kapUserName";
            groupBox_kapUserName.Size = new Size(397, 54);
            groupBox_kapUserName.TabIndex = 0;
            groupBox_kapUserName.TabStop = false;
            groupBox_kapUserName.Text = "KAP Kullanıcı Adı";
            // 
            // textBox_kapUserName
            // 
            textBox_kapUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_kapUserName.BorderStyle = BorderStyle.None;
            textBox_kapUserName.Font = new Font("Segoe UI", 10F);
            textBox_kapUserName.Location = new Point(15, 21);
            textBox_kapUserName.Multiline = true;
            textBox_kapUserName.Name = "textBox_kapUserName";
            textBox_kapUserName.PasswordChar = '●';
            textBox_kapUserName.PlaceholderText = "API için alınan \"username\" bilgisini giriniz.";
            textBox_kapUserName.Size = new Size(371, 23);
            textBox_kapUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.White;
            label2.Location = new Point(9, 17);
            label2.Name = "label2";
            label2.Size = new Size(380, 28);
            label2.TabIndex = 2;
            // 
            // groupBox_kapPassword
            // 
            groupBox_kapPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_kapPassword.Controls.Add(textBox_kapPassword);
            groupBox_kapPassword.Controls.Add(label1);
            groupBox_kapPassword.Location = new Point(12, 72);
            groupBox_kapPassword.Name = "groupBox_kapPassword";
            groupBox_kapPassword.Size = new Size(397, 54);
            groupBox_kapPassword.TabIndex = 100;
            groupBox_kapPassword.TabStop = false;
            groupBox_kapPassword.Text = "KAP Şifre";
            // 
            // textBox_kapPassword
            // 
            textBox_kapPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_kapPassword.BorderStyle = BorderStyle.None;
            textBox_kapPassword.Font = new Font("Segoe UI", 10F);
            textBox_kapPassword.Location = new Point(15, 21);
            textBox_kapPassword.Multiline = true;
            textBox_kapPassword.Name = "textBox_kapPassword";
            textBox_kapPassword.PasswordChar = '●';
            textBox_kapPassword.PlaceholderText = "API için alınan \"password\" bilgisini giriniz.";
            textBox_kapPassword.Size = new Size(371, 23);
            textBox_kapPassword.TabIndex = 101;
            textBox_kapPassword.Tag = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.White;
            label1.Location = new Point(9, 17);
            label1.Name = "label1";
            label1.Size = new Size(380, 28);
            label1.TabIndex = 2;
            // 
            // button_save
            // 
            button_save.BackColor = Color.FromArgb(51, 61, 81);
            button_save.FlatAppearance.BorderSize = 0;
            button_save.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            button_save.FlatStyle = FlatStyle.Flat;
            button_save.Font = new Font("Segoe UI", 10F);
            button_save.ForeColor = Color.White;
            button_save.Image = Properties.Resources.check_mark_16;
            button_save.ImageAlign = ContentAlignment.MiddleLeft;
            button_save.Location = new Point(318, 135);
            button_save.Name = "button_save";
            button_save.Padding = new Padding(12, 0, 0, 0);
            button_save.Size = new Size(91, 28);
            button_save.TabIndex = 201;
            button_save.Text = "     Save";
            button_save.TextAlign = ContentAlignment.MiddleLeft;
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.DarkGray;
            button_cancel.FlatAppearance.BorderSize = 0;
            button_cancel.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Segoe UI", 10F);
            button_cancel.ForeColor = Color.White;
            button_cancel.Image = Properties.Resources.cancel;
            button_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            button_cancel.Location = new Point(12, 135);
            button_cancel.Name = "button_cancel";
            button_cancel.Padding = new Padding(8, 0, 0, 0);
            button_cancel.Size = new Size(91, 28);
            button_cancel.TabIndex = 205;
            button_cancel.Text = "     Cancel";
            button_cancel.TextAlign = ContentAlignment.MiddleLeft;
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += this.button_cancel_Click;
            // 
            // AppSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 175);
            ControlBox = false;
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(groupBox_kapPassword);
            Controls.Add(groupBox_kapUserName);
            MaximumSize = new Size(437, 214);
            MinimumSize = new Size(437, 214);
            Name = "AppSettings";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            Load += AppSettings_Load;
            groupBox_kapUserName.ResumeLayout(false);
            groupBox_kapUserName.PerformLayout();
            groupBox_kapPassword.ResumeLayout(false);
            groupBox_kapPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_kapUserName;
        private TextBox textBox_kapUserName;
        private GroupBox groupBox_kapPassword;
        private TextBox textBox_kapPassword;
        private Label label2;
        private Label label1;
        private Button button_save;
        private Button button_cancel;
    }
}