namespace _99_OOP_Personel_Otomasyonu
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.txtPersonelId = new System.Windows.Forms.MaskedTextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.dtpISeGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.lblYas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtTelefonNo);
            this.panel1.Controls.Add(this.txtPersonelId);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnResimSec);
            this.panel1.Controls.Add(this.cmbUnvan);
            this.panel1.Controls.Add(this.dtpISeGirisTarihi);
            this.panel1.Controls.Add(this.dtpDogumTarihi);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 296);
            this.panel1.TabIndex = 0;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(120, 233);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(89, 13);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "@bilgeadam.com";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(295, 162);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(0, 13);
            this.lblYas.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(368, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(121, 194);
            this.txtTelefonNo.Mask = "(999) 000-0000";
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(168, 20);
            this.txtTelefonNo.TabIndex = 6;
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.Location = new System.Drawing.Point(123, 57);
            this.txtPersonelId.Mask = "00000";
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(38, 20);
            this.txtPersonelId.TabIndex = 5;
            this.txtPersonelId.ValidatingType = typeof(int);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(497, 228);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(168, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(497, 257);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(168, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(497, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(497, 170);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(168, 23);
            this.btnResimSec.TabIndex = 4;
            this.btnResimSec.Text = "RESİM SEÇ";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(497, 138);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(168, 21);
            this.cmbUnvan.TabIndex = 3;
            // 
            // dtpISeGirisTarihi
            // 
            this.dtpISeGirisTarihi.Location = new System.Drawing.Point(497, 106);
            this.dtpISeGirisTarihi.Name = "dtpISeGirisTarihi";
            this.dtpISeGirisTarihi.Size = new System.Drawing.Size(168, 20);
            this.dtpISeGirisTarihi.TabIndex = 2;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(121, 156);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(168, 20);
            this.dtpDogumTarihi.TabIndex = 2;
            this.dtpDogumTarihi.ValueChanged += new System.EventHandler(this.dtpDogumTarihi_ValueChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(123, 89);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(168, 20);
            this.txtAd.TabIndex = 1;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(121, 122);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(168, 20);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(444, 12);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(221, 83);
            this.txtAdres.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "E MAİL :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "TELEFON NO :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "UNVAN :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "İŞE GİRİŞ TARİHİ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DOĞUM TARİHİ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "AD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SOYAD :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ADRES :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PERSONEL ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONEL BİLGİLERİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 296);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 273);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(679, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P E R S O N E L   K A Y I T   O T O M A S Y O N U";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtTelefonNo;
        private System.Windows.Forms.MaskedTextBox txtPersonelId;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.DateTimePicker dtpISeGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblMail;
    }
}

