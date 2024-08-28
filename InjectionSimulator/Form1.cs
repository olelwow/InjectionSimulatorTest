using InjectionInloggning;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InjectionSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginHandler handler = new(txt_username.Text, txt_password.Text);

            label_status.Text = handler.Login();
        }
    }
}
