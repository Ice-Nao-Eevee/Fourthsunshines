using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fourthsunshines
{
    public partial class kamar : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=fourthsunshines;Integrated Security=True");

        public kamar()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kamar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKamar.DataSource = dt;
            }
            finally { conn.Close(); }
        }

        void ClearForm()
        {
            txtIdKamar.Clear();
            txtNomorKamar.Clear();
            txtTipeKamar.Clear();
            txtHarga.Clear();
            txtStatus.Clear();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO kamar (id_kamar, nomor_kamar, tipe_kamar, harga, status) VALUES (@id,@no,@tipe,@harga,@status)",
                    conn);

                cmd.Parameters.AddWithValue("@id", txtIdKamar.Text);
                cmd.Parameters.AddWithValue("@no", txtNomorKamar.Text);
                cmd.Parameters.AddWithValue("@tipe", txtTipeKamar.Text);
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@status", txtStatus.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data kamar berhasil ditambahkan!");

                LoadData();
                ClearForm();
            }
            finally { conn.Close(); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE kamar SET nomor_kamar=@no, tipe_kamar=@tipe, harga=@harga, status=@status WHERE id_kamar=@id",
                    conn);

                cmd.Parameters.AddWithValue("@id", txtIdKamar.Text);
                cmd.Parameters.AddWithValue("@no", txtNomorKamar.Text);
                cmd.Parameters.AddWithValue("@tipe", txtTipeKamar.Text);
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@status", txtStatus.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data kamar berhasil diedit!");

                LoadData();
                ClearForm();
            }
            finally { conn.Close(); }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM kamar WHERE id_kamar=@id", conn);

                cmd.Parameters.AddWithValue("@id", txtIdKamar.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data kamar berhasil dihapus!");

                LoadData();
                ClearForm();
            }
            finally { conn.Close(); }
        }

        private void dgvKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdKamar.Text = dgvKamar.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNomorKamar.Text = dgvKamar.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTipeKamar.Text = dgvKamar.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtHarga.Text = dgvKamar.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStatus.Text = dgvKamar.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}
