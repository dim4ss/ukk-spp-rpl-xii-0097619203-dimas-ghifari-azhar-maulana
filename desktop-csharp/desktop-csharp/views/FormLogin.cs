using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace desktop_csharp.views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterPetugas pindah = new FormRegisterPetugas();
            pindah.FormClosed += Pindah_FormClosed1;
            pindah.Show();
            this.Hide();
        }

        private void Pindah_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //koneksi ke database

            //password kurang dari 6
            string user = textuser.Text;
            string password = textpw.Text;


            if (password.Length > 6)
            {
                textuser.Focus();
                //pindah ke dashboard
                FormDashboard pindahdash = new FormDashboard();
                pindahdash.FormClosed += Pindahdash_FormClosed;
                pindahdash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ulah");
            }
        }

        private void Pindahdash_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
