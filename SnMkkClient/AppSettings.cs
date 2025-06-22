using SnMkkClient.AppEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnMkkClient
{
    public partial class AppSettings : Form
    {
        public AppSettings()
        {
            InitializeComponent();
        }

        private void AppSettings_Load(object sender, EventArgs e)
        {
            textBox_kapUserName.Text = App.Settings != null && !string.IsNullOrEmpty(App.Settings.UserName) ? App.Settings.UserName : string.Empty;
            textBox_kapPassword.Text = App.Settings != null && !string.IsNullOrEmpty(App.Settings.Password) ? App.Settings.Password : string.Empty;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_kapPassword.Text) || string.IsNullOrEmpty(textBox_kapPassword.Text))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre alanlarını doldurunuz.", "Zorunlu Alanlar");
                return;
            }
            App.Settings.UserName = textBox_kapUserName.Text;
            App.Settings.Password = textBox_kapPassword.Text;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (App.Settings == null || string.IsNullOrEmpty(App.Settings.UserName) || string.IsNullOrEmpty(App.Settings.Password))
            {
                MessageBox.Show("Kayıtlı Kullanıcı Adı ve Şifre bulunmuyor. Kullanıcı adı şifre girip kaydetmeden bu pencereden çıkış yapılamaz.", "Zorunlu Alanlar");
                return;
            }
            this.Close();
        }

    }
}
