namespace HotelApp
{
    partial class FormReservasi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtIdReservasi = new System.Windows.Forms.TextBox();
            this.txtNamaTamu = new System.Windows.Forms.TextBox();
            this.txtIdKamar = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dgvReservasi = new System.Windows.Forms.DataGridView();

            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasi)).BeginInit();
            this.SuspendLayout();

            // txtIdReservasi
            this.txtIdReservasi.Location = new System.Drawing.Point(30, 30);
            this.txtIdReservasi.Name = "txtIdReservasi";
            this.txtIdReservasi.Size = new System.Drawing.Size(250, 23);

            // txtNamaTamu
            this.txtNamaTamu.Location = new System.Drawing.Point(30, 65);
            this.txtNamaTamu.Name = "txtNamaTamu";
            this.txtNamaTamu.Size = new System.Drawing.Size(250, 23);

            // txtIdKamar
            this.txtIdKamar.Location = new System.Drawing.Point(30, 100);
            this.txtIdKamar.Name = "txtIdKamar";
            this.txtIdKamar.Size = new System.Drawing.Size(250, 23);

            // dtpCheckIn
            this.dtpCheckIn.Location = new System.Drawing.Point(30, 135);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(250, 23);

            // dtpCheckOut
            this.dtpCheckOut.Location = new System.Drawing.Point(30, 170);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(250, 23);

            // dgvReservasi
            this.dgvReservasi.Location = new System.Drawing.Point(320, 30);
            this.dgvReservasi.Name = "dgvReservasi";
            this.dgvReservasi.Size = new System.Drawing.Size(500, 300);
            this.dgvReservasi.ReadOnly = true;
            this.dgvReservasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservasi_CellClick);

            // Buttons

            this.btnTambah.Text = "Tambah";
            this.btnTambah.Location = new System.Drawing.Point(30, 210);
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(120, 210);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnHapus.Text = "Hapus";
            this.btnHapus.Location = new System.Drawing.Point(210, 210);
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(30, 245);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // FormReservasi
            this.ClientSize = new System.Drawing.Size(860, 380);
            this.Controls.Add(this.dgvReservasi);
            this.Controls.Add(this.txtIdReservasi);
            this.Controls.Add(this.txtNamaTamu);
            this.Controls.Add(this.txtIdKamar);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.dtpCheckOut);

            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnClear);

            this.Name = "FormReservasi";
            this.Text = "Reservasi";

            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtIdReservasi;
        private System.Windows.Forms.TextBox txtNamaTamu;
        private System.Windows.Forms.TextBox txtIdKamar;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DataGridView dgvReservasi;

        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
    }
}
