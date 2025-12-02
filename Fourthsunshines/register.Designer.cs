namespace Fourthsunshines
{
    partial class register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblregistrasi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtnomerhp = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.groupBox1.Controls.Add(this.btnsimpan);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtalamat);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtnomerhp);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblregistrasi);
            this.groupBox1.Location = new System.Drawing.Point(581, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 652);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblregistrasi
            // 
            this.lblregistrasi.AutoSize = true;
            this.lblregistrasi.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(63)))), ((int)(((byte)(100)))));
            this.lblregistrasi.Location = new System.Drawing.Point(28, 46);
            this.lblregistrasi.Name = "lblregistrasi";
            this.lblregistrasi.Size = new System.Drawing.Size(361, 41);
            this.lblregistrasi.TabIndex = 1;
            this.lblregistrasi.Text = "Registrasi Pengguna";
            this.lblregistrasi.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "isi form pendaftaran di bawah ini";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtusername.Location = new System.Drawing.Point(69, 168);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(463, 35);
            this.txtusername.TabIndex = 3;
            this.txtusername.Text = "Username";
            this.txtusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnomerhp
            // 
            this.txtnomerhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomerhp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnomerhp.Location = new System.Drawing.Point(69, 235);
            this.txtnomerhp.Multiline = true;
            this.txtnomerhp.Name = "txtnomerhp";
            this.txtnomerhp.Size = new System.Drawing.Size(463, 35);
            this.txtnomerhp.TabIndex = 4;
            this.txtnomerhp.Text = "Nomer Hp";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtemail.Location = new System.Drawing.Point(69, 299);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(463, 35);
            this.txtemail.TabIndex = 5;
            this.txtemail.Text = "Email";
            // 
            // txtalamat
            // 
            this.txtalamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalamat.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtalamat.Location = new System.Drawing.Point(69, 361);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(463, 99);
            this.txtalamat.TabIndex = 6;
            this.txtalamat.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "username wajib di isi";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(208)))));
            this.btnclear.Location = new System.Drawing.Point(149, 554);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(118, 43);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsimpan.Location = new System.Drawing.Point(334, 554);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(118, 43);
            this.btnsimpan.TabIndex = 10;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(55, 301);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(492, 60);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Fourthsunshines Hotel";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.groupBox1);
            this.Name = "register";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblregistrasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtnomerhp;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Label lblAppName;
    }
}