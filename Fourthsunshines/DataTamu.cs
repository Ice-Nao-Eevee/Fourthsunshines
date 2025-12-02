using System;
using System.Data;
using System.Windows.Forms;

namespace Fourthsunshines
{
    public partial class DataTamu : Form
    {
        DataTable tabelTamu = new DataTable();

        public DataTamu()
        {
            InitializeComponent();

            // Buat kolom DataGridView
            tabelTamu.Columns.Add("ID");
            tabelTamu.Columns.Add("Nama");
            tabelTamu.Columns.Add("Alamat");
            tabelTamu.Columns.Add("Telepon");

            dgvTamu.DataSource = tabelTamu;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tabelTamu.Rows.Add(
                txtID.Text,
                txtNama.Text,
                txtAlamat.Text,
                txtTelepon.Text
            );
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTamu.SelectedRows.Count > 0)
            {
                int index = dgvTamu.SelectedRows[0].Index;
                tabelTamu.Rows[index]["ID"] = txtID.Text;
                tabelTamu.Rows[index]["Nama"] = txtNama.Text;
                tabelTamu.Rows[index]["Alamat"] = txtAlamat.Text;
                tabelTamu.Rows[index]["Telepon"] = txtTelepon.Text;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvTamu.SelectedRows.Count > 0)
            {
                int index = dgvTamu.SelectedRows[0].Index;
                tabelTamu.Rows[index].Delete();
                ClearForm();
            }
        }

        private void dgvTamu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvTamu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNama.Text = dgvTamu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAlamat.Text = dgvTamu.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTelepon.Text = dgvTamu.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        void ClearForm()
        {
            txtID.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtTelepon.Clear();
        }
    }
}
