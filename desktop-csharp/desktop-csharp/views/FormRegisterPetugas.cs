using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace desktop_csharp.views
{
    public partial class FormRegisterPetugas : Form
    {
        public FormRegisterPetugas()
        {
            InitializeComponent();
        }

        private void lbllog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin pindahlog = new FormLogin();
            pindahlog.FormClosed += Pindah_FormClosed;
            pindahlog.Show();
            this.Hide();
        }
        private void Pindah_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void butsim_Click(object sender, EventArgs e)
        {
            //password tidakboleh kurang dari 6
            string user = textuser.Text;
            string nama = textnama.Text;
            string password = textpw.Text;
            string konfirmasi = textkonfirpw.Text;

            // Nilai pada Password harus sama dengan KonfirmasiPassword
            if (textpw.Text != textkonfirpw.Text)
            {
                MessageBox.Show("Konfirmasi kata sandi tidak cocok!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textkonfirpw.Focus();
                return;
            }
            //password tidak boleh kurang dari 6
            if (password.Length > 6)
            {
                textuser.Focus();
            }
            else
            {
                MessageBox.Show("ulah");
            }

            // 2. Validasi input: seluruh field wajib terisi
            if (string.IsNullOrWhiteSpace(textuser.Text) ||
                string.IsNullOrWhiteSpace(textnama.Text) ||
                string.IsNullOrWhiteSpace(textpw.Text) ||
                string.IsNullOrWhiteSpace(textkonfirpw.Text))
            {
                MessageBox.Show("Seluruh field wajib terisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }
    }
}

