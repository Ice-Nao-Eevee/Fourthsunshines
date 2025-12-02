using System;
using System.Windows.Forms;

namespace Fourthsunshines
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        // ========== BUTTON SIMPAN ==========
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            // VALIDASI
            if (txtusername.Text.Trim() == "" || txtusername.Text == "Username")
            {
                MessageBox.Show("Username harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtnomerhp.Text.Trim() == "" || txtnomerhp.Text == "Nomer Hp")
            {
                MessageBox.Show("Nomor HP harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtemail.Text.Trim() == "" || txtemail.Text == "Email")
            {
                MessageBox.Show("Email harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtalamat.Text.Trim() == "" || txtalamat.Text == "Alamat")
            {
                MessageBox.Show("Alamat harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SIMPAN BERHASIL
            MessageBox.Show("Registrasi berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // === PINDAH KE DASHBOARD ===
            dashboard dash = new dashboard();  // pastikan nama form = dashboard.cs
            dash.Show();

            this.Hide(); // sembunyiin form register (biar ga nambah jendela)
        }


        // ========== BUTTON CLEAR ==========
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "Username";
            txtnomerhp.Text = "Nomer Hp";
            txtemail.Text = "Email";
            txtalamat.Text = "Alamat";
        }

        // ========== EVENT TEXTBOX ==========
        private void txtalamat_TextChanged(object sender, EventArgs e) { }
        private void txtemail_TextChanged(object sender, EventArgs e) { }
        private void txtnomerhp_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}
