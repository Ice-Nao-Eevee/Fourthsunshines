using System;
using System.Data;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class FormReservasi : Form
    {
        DataTable reservasiTable = new DataTable();

        public FormReservasi()
        {
            InitializeComponent();
            SetupTable();
        }

        void SetupTable()
        {
            reservasiTable.Columns.Add("ID Reservasi");
            reservasiTable.Columns.Add("Nama Tamu");
            reservasiTable.Columns.Add("ID Kamar");
            reservasiTable.Columns.Add("Check-in");
            reservasiTable.Columns.Add("Check-out");

            dgvReservasi.DataSource = reservasiTable;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            reservasiTable.Rows.Add(
                txtIdReservasi.Text,
                txtNamaTamu.Text,
                txtIdKamar.Text,
                dtpCheckIn.Value.ToShortDateString(),
                dtpCheckOut.Value.ToShortDateString()
            );

            MessageBox.Show("Reservasi berhasil ditambahkan!");
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvReservasi.CurrentRow == null) return;

            dgvReservasi.CurrentRow.Cells[0].Value = txtIdReservasi.Text;
            dgvReservasi.CurrentRow.Cells[1].Value = txtNamaTamu.Text;
            dgvReservasi.CurrentRow.Cells[2].Value = txtIdKamar.Text;
            dgvReservasi.CurrentRow.Cells[3].Value = dtpCheckIn.Value.ToShortDateString();
            dgvReservasi.CurrentRow.Cells[4].Value = dtpCheckOut.Value.ToShortDateString();

            MessageBox.Show("Reservasi berhasil diupdate!");
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvReservasi.CurrentRow == null) return;

            dgvReservasi.Rows.RemoveAt(dgvReservasi.CurrentRow.Index);
            MessageBox.Show("Reservasi berhasil dihapus!");
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvReservasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtIdReservasi.Text = dgvReservasi.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNamaTamu.Text = dgvReservasi.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIdKamar.Text = dgvReservasi.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpCheckIn.Value = DateTime.Parse(dgvReservasi.Rows[e.RowIndex].Cells[3].Value.ToString());
            dtpCheckOut.Value = DateTime.Parse(dgvReservasi.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        void ClearForm()
        {
            txtIdReservasi.Text = "";
            txtNamaTamu.Text = "";
            txtIdKamar.Text = "";
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
        }
    }
}
