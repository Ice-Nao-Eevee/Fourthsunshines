namespace Fourthsunshines
{
    partial class DataTamu
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
            this.dgvTamu = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblTelepon = new System.Windows.Forms.Label();

            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();

            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTamu)).BeginInit();
            this.SuspendLayout();

            // ---------------------------
            // DataGridView
            // ---------------------------
            this.dgvTamu.BackgroundColor = System.Drawing.Color.White;
            this.dgvTamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamu.Location = new System.Drawing.Point(320, 30);
            this.dgvTamu.Name = "dgvTamu";
            this.dgvTamu.RowHeadersWidth = 51;
            this.dgvTamu.RowTemplate.Height = 24;
            this.dgvTamu.Size = new System.Drawing.Size(500, 350);
            this.dgvTamu.TabIndex = 0;
            this.dgvTamu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTamu_CellClick);

            // ---------------------------
            // Label + TextBox Input
            // ---------------------------
            this.lblID.Text = "ID Tamu";
            this.lblID.Location = new System.Drawing.Point(20, 30);

            this.txtID.Location = new System.Drawing.Point(120, 30);
            this.txtID.Width = 150;

            this.lblNama.Text = "Nama";
            this.lblNama.Location = new System.Drawing.Point(20, 80);

            this.txtNama.Location = new System.Drawing.Point(120, 80);
            this.txtNama.Width = 150;

            this.lblAlamat.Text = "Alamat";
            this.lblAlamat.Location = new System.Drawing.Point(20, 130);

            this.txtAlamat.Location = new System.Drawing.Point(120, 130);
            this.txtAlamat.Width = 150;

            this.lblTelepon.Text = "Telepon";
            this.lblTelepon.Location = new System.Drawing.Point(20, 180);

            this.txtTelepon.Location = new System.Drawing.Point(120, 180);
            this.txtTelepon.Width = 150;

            // ---------------------------
            // Button CRUD
            // ---------------------------
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Location = new System.Drawing.Point(20, 240);
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            this.btnEdit.Text = "Edit";
            this.btnEdit.Location = new System.Drawing.Point(120, 240);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnHapus.Text = "Hapus";
            this.btnHapus.Location = new System.Drawing.Point(20, 290);
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(120, 290);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // ---------------------------
            // Form Layout
            // ---------------------------
            this.BackColor = System.Drawing.Color.FromArgb(255, 230, 235);
            this.ClientSize = new System.Drawing.Size(850, 420);
            this.Controls.Add(this.dgvTamu);

            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);

            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtNama);

            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.txtAlamat);

            this.Controls.Add(this.lblTelepon);
            this.Controls.Add(this.txtTelepon);

            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnClear);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "DataTamu";
            this.Text = "Data Tamu";

            ((System.ComponentModel.ISupportInitialize)(this.dgvTamu)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTamu;

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblTelepon;

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtTelepon;

        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
    }
}
