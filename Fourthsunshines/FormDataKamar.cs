using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fourthsunshines
{
    public partial class FormDataKamar : Form
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=localhost;Initial Catalog=db_hotel;Integrated Security=True"
        );

        public FormDataKamar()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kamar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKamar.DataSource = dt;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Kamar (IdKamar, NomorKamar, TipeKamar, Harga, Status) " +
                    "VALUES (@id,@nomor,@tipe,@harga,@status)", conn);

                cmd.Parameters.AddWithValue("@id", txtIdKamar.Text);
                cmd.Parameters.AddWithValue("@nomor", txtNomor.Text);
                cmd.Parameters.AddWithValue("@tipe", txtTipe.Text);
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan!");
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Kamar SET NomorKamar=@nomor, TipeKamar=@tipe, Harga=@harga, Status=@status " +
                    "WHERE IdKamar=@id", conn);

                cmd.Parameters.AddWithValue("@id", txtIdKamar.Text);
                cmd.Parameters.AddWithValue("@nomor", txtNomor.Text);
                cmd.Parameters.AddWithValue("@tipe", txtTipe.Text);
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate!");
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Kamar WHERE IdKamar=@id", conn);

                cmd.Parameters.AddWithValue("@id", txtIdKamar.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil dihapus!");
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdKamar.Clear();
            txtNomor.Clear();
            txtTipe.Clear();
            txtHarga.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void dgvKamar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (row >= 0)
            {
                txtIdKamar.Text = dgvKamar.Rows[row].Cells["IdKamar"].Value.ToString();
                txtNomor.Text = dgvKamar.Rows[row].Cells["NomorKamar"].Value.ToString();
                txtTipe.Text = dgvKamar.Rows[row].Cells["TipeKamar"].Value.ToString();
                txtHarga.Text = dgvKamar.Rows[row].Cells["Harga"].Value.ToString();
                cmbStatus.Text = dgvKamar.Rows[row].Cells["Status"].Value.ToString();
            }
        }
    }
}
