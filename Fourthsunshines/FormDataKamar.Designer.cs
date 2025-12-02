namespace Fourthsunshines
{
    partial class FormDataKamar
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
            this.dgvKamar = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNomor = new System.Windows.Forms.Label();
            this.lblTipe = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();

            this.txtIdKamar = new System.Windows.Forms.TextBox();
            this.txtNomor = new System.Windows.Forms.TextBox();
            this.txtTipe = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvKamar
            // 
            this.dgvKamar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKamar.Location = new System.Drawing.Point(330, 30);
            this.dgvKamar.Name = "dgvKamar";
            this.dgvKamar.RowHeadersWidth = 51;
            this.dgvKamar.Size = new System.Drawing.Size(500, 350);
            this.dgvKamar.TabIndex = 0;
            this.dgvKamar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKamar_CellClick);

            // LABEL & INPUT
            this.lblId.Text = "ID Kamar";
            this.lblId.Location = new System.Drawing.Point(20, 30);

            this.txtIdKamar.Location = new System.Drawing.Point(130, 30);
            this.txtIdKamar.Width = 160;

            this.lblNomor.Text = "Nomor Kamar";
            this.lblNomor.Location = new System.Drawing.Point(20, 80);

            this.txtNomor.Location = new System.Drawing.Point(130, 80);
            this.txtNomor.Width = 160;

            this.lblTipe.Text = "Tipe";
            this.lblTipe.Location = new System.Drawing.Point(20, 130);

            this.txtTipe.Location = new System.Drawing.Point(130, 130);
            this.txtTipe.Width = 160;

            this.lblHarga.Text = "Harga";
            this.lblHarga.Location = new System.Drawing.Point(20, 180);

            this.txtHarga.Location = new System.Drawing.Point(130, 180);
            this.txtHarga.Width = 160;

            this.lblStatus.Text = "Status";
            this.lblStatus.Location = new System.Drawing.Point(20, 230);

            this.cmbStatus.Location = new System.Drawing.Point(130, 230);
            this.cmbStatus.Width = 160;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] {
                "Kosong", "Terisi", "Dibersihkan"
            });

            // BUTTONS
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Location = new System.Drawing.Point(20, 290);
            this.btnTambah.Width = 100;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(130, 290);
            this.btnUpdate.Width = 100;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnHapus.Text = "Hapus";
            this.btnHapus.Location = new System.Drawing.Point(20, 340);
            this.btnHapus.Width = 100;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(130, 340);
            this.btnClear.Width = 100;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // FORM STYLE
            this.BackColor = System.Drawing.Color.FromArgb(255, 230, 240);
            this.ClientSize = new System.Drawing.Size(860, 420);

            this.Controls.Add(this.dgvKamar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIdKamar);
            this.Controls.Add(this.lblNomor);
            this.Controls.Add(this.txtNomor);
            this.Controls.Add(this.lblTipe);
            this.Controls.Add(this.txtTipe);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnClear);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormDataKamar";
            this.Text = "Manajemen Data Kamar";

            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKamar;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNomor;
        private System.Windows.Forms.Label lblTipe;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.TextBox txtIdKamar;
        private System.Windows.Forms.TextBox txtNomor;
        private System.Windows.Forms.TextBox txtTipe;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
    }
}
