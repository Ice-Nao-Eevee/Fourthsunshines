namespace Fourthsunshines
{
    partial class kamar
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvKamar;
        private System.Windows.Forms.TextBox txtIdKamar;
        private System.Windows.Forms.TextBox txtNomorKamar;
        private System.Windows.Forms.TextBox txtTipeKamar;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvKamar = new System.Windows.Forms.DataGridView();
            this.txtIdKamar = new System.Windows.Forms.TextBox();
            this.txtNomorKamar = new System.Windows.Forms.TextBox();
            this.txtTipeKamar = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKamar
            // 
            this.dgvKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKamar.Location = new System.Drawing.Point(30, 220);
            this.dgvKamar.Name = "dgvKamar";
            this.dgvKamar.Size = new System.Drawing.Size(540, 200);
            this.dgvKamar.TabIndex = 0;
            this.dgvKamar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKamar_CellClick);
            // 
            // txtIdKamar
            // 
            this.txtIdKamar.Location = new System.Drawing.Point(30, 30);
            this.txtIdKamar.Name = "txtIdKamar";
            this.txtIdKamar.Size = new System.Drawing.Size(200, 23);
            this.txtIdKamar.TabIndex = 1;
            // 
            // txtNomorKamar
            // 
            this.txtNomorKamar.Location = new System.Drawing.Point(30, 60);
            this.txtNomorKamar.Name = "txtNomorKamar";
            this.txtNomorKamar.Size = new System.Drawing.Size(200, 23);
            this.txtNomorKamar.TabIndex = 2;
            // 
            // txtTipeKamar
            // 
            this.txtTipeKamar.Location = new System.Drawing.Point(30, 90);
            this.txtTipeKamar.Name = "txtTipeKamar";
            this.txtTipeKamar.Size = new System.Drawing.Size(200, 23);
            this.txtTipeKamar.TabIndex = 3;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(30, 120);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(200, 23);
            this.txtHarga.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(30, 150);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(200, 23);
            this.txtStatus.TabIndex = 5;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(280, 30);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 30);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(280, 70);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(280, 110);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 30);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // kamar
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtTipeKamar);
            this.Controls.Add(this.txtNomorKamar);
            this.Controls.Add(this.txtIdKamar);
            this.Controls.Add(this.dgvKamar);
            this.Name = "kamar";
            this.Text = "Data Kamar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
