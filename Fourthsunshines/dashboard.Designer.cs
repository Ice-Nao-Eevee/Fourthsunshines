namespace Fourthsunshines
{
    partial class dashboard
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnReservasi = new System.Windows.Forms.Button();
            this.btnKamar = new System.Windows.Forms.Button();
            this.btnDataTamu = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCard1 = new System.Windows.Forms.Panel();
            this.labelCard1 = new System.Windows.Forms.Label();
            this.panelCard2 = new System.Windows.Forms.Panel();
            this.labelCard2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.panelCard2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.panelSidebar.Controls.Add(this.btnReservasi);
            this.panelSidebar.Controls.Add(this.btnKamar);
            this.panelSidebar.Controls.Add(this.btnDataTamu);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(180, 600);
            this.panelSidebar.TabIndex = 3;
            // 
            // btnReservasi
            // 
            this.btnReservasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.btnReservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservasi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnReservasi.Location = new System.Drawing.Point(10, 250);
            this.btnReservasi.Name = "btnReservasi";
            this.btnReservasi.Size = new System.Drawing.Size(160, 40);
            this.btnReservasi.TabIndex = 0;
            this.btnReservasi.Text = "Reservasi";
            this.btnReservasi.UseVisualStyleBackColor = false;
            this.btnReservasi.Click += new System.EventHandler(this.btnReservasi_Click);
            // 
            // btnKamar
            // 
            this.btnKamar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.btnKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKamar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnKamar.Location = new System.Drawing.Point(10, 191);
            this.btnKamar.Name = "btnKamar";
            this.btnKamar.Size = new System.Drawing.Size(160, 40);
            this.btnKamar.TabIndex = 1;
            this.btnKamar.Text = "Data Kamar";
            this.btnKamar.UseVisualStyleBackColor = false;
            this.btnKamar.Click += new System.EventHandler(this.btnKamar_Click);
            // 
            // btnDataTamu
            // 
            this.btnDataTamu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.btnDataTamu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataTamu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnDataTamu.Location = new System.Drawing.Point(10, 130);
            this.btnDataTamu.Name = "btnDataTamu";
            this.btnDataTamu.Size = new System.Drawing.Size(160, 40);
            this.btnDataTamu.TabIndex = 2;
            this.btnDataTamu.Text = "Data Tamu";
            this.btnDataTamu.UseVisualStyleBackColor = false;
            this.btnDataTamu.Click += new System.EventHandler(this.btnDataTamu_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(198)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(180, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(820, 100);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            // 
            // panelCard1
            // 
            this.panelCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.panelCard1.Controls.Add(this.labelCard1);
            this.panelCard1.Location = new System.Drawing.Point(220, 140);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Size = new System.Drawing.Size(300, 150);
            this.panelCard1.TabIndex = 1;
            // 
            // labelCard1
            // 
            this.labelCard1.AutoSize = true;
            this.labelCard1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelCard1.Location = new System.Drawing.Point(20, 20);
            this.labelCard1.Name = "labelCard1";
            this.labelCard1.Size = new System.Drawing.Size(165, 32);
            this.labelCard1.TabIndex = 0;
            this.labelCard1.Text = "Jumlah Tamu";
            // 
            // panelCard2
            // 
            this.panelCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.panelCard2.Controls.Add(this.labelCard2);
            this.panelCard2.Location = new System.Drawing.Point(608, 140);
            this.panelCard2.Name = "panelCard2";
            this.panelCard2.Size = new System.Drawing.Size(300, 150);
            this.panelCard2.TabIndex = 0;
            // 
            // labelCard2
            // 
            this.labelCard2.AutoSize = true;
            this.labelCard2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelCard2.Location = new System.Drawing.Point(20, 20);
            this.labelCard2.Name = "labelCard2";
            this.labelCard2.Size = new System.Drawing.Size(184, 32);
            this.labelCard2.TabIndex = 0;
            this.labelCard2.Text = "Total Reservasi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(200)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(413, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 150);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Kamar";   // ✅ Sudah diganti

            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCard2);
            this.Controls.Add(this.panelCard1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.panelCard2.ResumeLayout(false);
            this.panelCard2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnDataTamu;
        private System.Windows.Forms.Button btnKamar;
        private System.Windows.Forms.Button btnReservasi;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Label labelCard1;

        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Label labelCard2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
