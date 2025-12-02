using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fourthsunshines
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tidak perlu apa-apa di sini untuk sekarang
        }

        // ========== PLACEHOLDER LOGIC ==========

        private void Txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            // Username placeholder
            if (tb == txtUsername && tb.Text == "Username")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }

            // Password placeholder
            if (tb == txtPassword && tb.Text == "Password")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
                tb.UseSystemPasswordChar = true;   // mulai disembunyikan
            }
        }

        private void Txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            // Username placeholder kembali
            if (tb == txtUsername && string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "Username";
                tb.ForeColor = Color.Gray;
            }

            // Password placeholder kembali
            if (tb == txtPassword && string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.UseSystemPasswordChar = false;  // tampilkan lagi
                tb.Text = "Password";
                tb.ForeColor = Color.Gray;
            }
        }

        // ========== LOGIN BUTTON ==========

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Username & Password benar
            string usernameBenar = "sapi";
            string passwordBenar = "raju";

            // Cek login
            if (txtUsername.Text == usernameBenar && txtPassword.Text == passwordBenar)
            {
                // Pindah ke Dashboard
                dashboard dash = new dashboard();
                dash.Show();

                // Tutup atau sembunyikan form login
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Username atau password salah!",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // ========== REGISTER LINK ==========
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register frm = new register();
            frm.Show();
            this.Hide(); // kalau mau login ditutup
        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }
    }
}
