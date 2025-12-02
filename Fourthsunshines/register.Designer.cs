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
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnomerhp = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblregistrasi = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.groupBox1.Location = new System.Drawing.Point(516, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(550, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsimpan.Location = new System.Drawing.Point(297, 443);
            this.btnsimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(105, 34);
            this.btnsimpan.TabIndex = 10;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(182)))), ((int)(((byte)(208)))));
            this.btnclear.Location = new System.Drawing.Point(132, 443);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(105, 34);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "username wajib di isi";
            // 
            // txtalamat
            // 
            this.txtalamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalamat.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtalamat.Location = new System.Drawing.Point(61, 289);
            this.txtalamat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(412, 80);
            this.txtalamat.TabIndex = 6;
            this.txtalamat.Text = "Alamat";
            this.txtalamat.TextChanged += new System.EventHandler(this.txtalamat_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtemail.Location = new System.Drawing.Point(61, 239);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(412, 29);
            this.txtemail.TabIndex = 5;
            this.txtemail.Text = "Email";
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtnomerhp
            // 
            this.txtnomerhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomerhp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtnomerhp.Location = new System.Drawing.Point(61, 188);
            this.txtnomerhp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnomerhp.Multiline = true;
            this.txtnomerhp.Name = "txtnomerhp";
            this.txtnomerhp.Size = new System.Drawing.Size(412, 29);
            this.txtnomerhp.TabIndex = 4;
            this.txtnomerhp.Text = "Nomer Hp";
            this.txtnomerhp.TextChanged += new System.EventHandler(this.txtnomerhp_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtusername.Location = new System.Drawing.Point(61, 134);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(412, 29);
            this.txtusername.TabIndex = 3;
            this.txtusername.Text = "Username";
            this.txtusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "isi form pendaftaran di bawah ini";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblregistrasi
            // 
            this.lblregistrasi.AutoSize = true;
            this.lblregistrasi.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(63)))), ((int)(((byte)(100)))));
            this.lblregistrasi.Location = new System.Drawing.Point(25, 37);
            this.lblregistrasi.Name = "lblregistrasi";
            this.lblregistrasi.Size = new System.Drawing.Size(300, 35);
            this.lblregistrasi.TabIndex = 1;
            this.lblregistrasi.Text = "Registrasi Pengguna";
            this.lblregistrasi.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(49, 241);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(411, 50);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Fourthsunshines Hotel";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1067, 520);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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