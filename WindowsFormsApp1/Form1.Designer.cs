namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEtutOlustur = new System.Windows.Forms.Button();
            this.maskedTextBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxOgretmen = new System.Windows.Forms.ComboBox();
            this.comboBoxDers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxETUTID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxogrenci = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEtutver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxogrenciekle = new System.Windows.Forms.MaskedTextBox();
            this.ÖğrenciEkleButtonu = new System.Windows.Forms.Button();
            this.ogreklemail = new System.Windows.Forms.TextBox();
            this.ogreklesınıf = new System.Windows.Forms.TextBox();
            this.ogreklesoyad = new System.Windows.Forms.TextBox();
            this.ogreklead = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fotoyuklebutton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonogretmenekle = new System.Windows.Forms.Button();
            this.ogretmeneklesınıf = new System.Windows.Forms.TextBox();
            this.ogretmeneklesoyad = new System.Windows.Forms.TextBox();
            this.ogretmeneklead = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEtutOlustur);
            this.groupBox1.Controls.Add(this.maskedTextBoxSaat);
            this.groupBox1.Controls.Add(this.maskedTextBoxTarih);
            this.groupBox1.Controls.Add(this.comboBoxOgretmen);
            this.groupBox1.Controls.Add(this.comboBoxDers);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnEtutOlustur
            // 
            this.btnEtutOlustur.Location = new System.Drawing.Point(114, 248);
            this.btnEtutOlustur.Name = "btnEtutOlustur";
            this.btnEtutOlustur.Size = new System.Drawing.Size(175, 35);
            this.btnEtutOlustur.TabIndex = 3;
            this.btnEtutOlustur.Text = "Etüt Oluştur ";
            this.btnEtutOlustur.UseVisualStyleBackColor = true;
            this.btnEtutOlustur.Click += new System.EventHandler(this.btnEtutOlustur_Click);
            // 
            // maskedTextBoxSaat
            // 
            this.maskedTextBoxSaat.Location = new System.Drawing.Point(115, 202);
            this.maskedTextBoxSaat.Mask = "90:00";
            this.maskedTextBoxSaat.Name = "maskedTextBoxSaat";
            this.maskedTextBoxSaat.Size = new System.Drawing.Size(175, 26);
            this.maskedTextBoxSaat.TabIndex = 2;
            this.maskedTextBoxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxTarih
            // 
            this.maskedTextBoxTarih.Location = new System.Drawing.Point(114, 151);
            this.maskedTextBoxTarih.Mask = "00/00/0000";
            this.maskedTextBoxTarih.Name = "maskedTextBoxTarih";
            this.maskedTextBoxTarih.Size = new System.Drawing.Size(175, 26);
            this.maskedTextBoxTarih.TabIndex = 2;
            this.maskedTextBoxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxOgretmen
            // 
            this.comboBoxOgretmen.FormattingEnabled = true;
            this.comboBoxOgretmen.Location = new System.Drawing.Point(115, 101);
            this.comboBoxOgretmen.Name = "comboBoxOgretmen";
            this.comboBoxOgretmen.Size = new System.Drawing.Size(176, 28);
            this.comboBoxOgretmen.TabIndex = 1;
            // 
            // comboBoxDers
            // 
            this.comboBoxDers.FormattingEnabled = true;
            this.comboBoxDers.Location = new System.Drawing.Point(114, 51);
            this.comboBoxDers.Name = "comboBoxDers";
            this.comboBoxDers.Size = new System.Drawing.Size(176, 28);
            this.comboBoxDers.TabIndex = 1;
            this.comboBoxDers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDers_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Saat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tarih :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğretmen :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxETUTID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxogrenci);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnEtutver);
            this.groupBox2.Location = new System.Drawing.Point(423, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 297);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxETUTID
            // 
            this.textBoxETUTID.Enabled = false;
            this.textBoxETUTID.Location = new System.Drawing.Point(108, 68);
            this.textBoxETUTID.Name = "textBoxETUTID";
            this.textBoxETUTID.Size = new System.Drawing.Size(130, 26);
            this.textBoxETUTID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Etüt ID  :";
            // 
            // textBoxogrenci
            // 
            this.textBoxogrenci.Location = new System.Drawing.Point(108, 114);
            this.textBoxogrenci.Name = "textBoxogrenci";
            this.textBoxogrenci.Size = new System.Drawing.Size(130, 26);
            this.textBoxogrenci.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Öğrenci :";
            // 
            // btnEtutver
            // 
            this.btnEtutver.BackColor = System.Drawing.Color.Tomato;
            this.btnEtutver.Location = new System.Drawing.Point(108, 157);
            this.btnEtutver.Name = "btnEtutver";
            this.btnEtutver.Size = new System.Drawing.Size(130, 34);
            this.btnEtutver.TabIndex = 0;
            this.btnEtutver.Text = "Etüt Ver";
            this.btnEtutver.UseVisualStyleBackColor = false;
            this.btnEtutver.Click += new System.EventHandler(this.btnEtutver_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(25, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(764, 185);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 160);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.maskedTextBoxogrenciekle);
            this.groupBox4.Controls.Add(this.ÖğrenciEkleButtonu);
            this.groupBox4.Controls.Add(this.ogreklemail);
            this.groupBox4.Controls.Add(this.ogreklesınıf);
            this.groupBox4.Controls.Add(this.ogreklesoyad);
            this.groupBox4.Controls.Add(this.ogreklead);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(730, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 297);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // maskedTextBoxogrenciekle
            // 
            this.maskedTextBoxogrenciekle.Location = new System.Drawing.Point(109, 160);
            this.maskedTextBoxogrenciekle.Mask = "(999) 000-0000";
            this.maskedTextBoxogrenciekle.Name = "maskedTextBoxogrenciekle";
            this.maskedTextBoxogrenciekle.Size = new System.Drawing.Size(122, 26);
            this.maskedTextBoxogrenciekle.TabIndex = 3;
            // 
            // ÖğrenciEkleButtonu
            // 
            this.ÖğrenciEkleButtonu.BackColor = System.Drawing.Color.Tomato;
            this.ÖğrenciEkleButtonu.Location = new System.Drawing.Point(47, 242);
            this.ÖğrenciEkleButtonu.Name = "ÖğrenciEkleButtonu";
            this.ÖğrenciEkleButtonu.Size = new System.Drawing.Size(184, 41);
            this.ÖğrenciEkleButtonu.TabIndex = 2;
            this.ÖğrenciEkleButtonu.Text = "ÖğrenciEkle";
            this.ÖğrenciEkleButtonu.UseVisualStyleBackColor = false;
            this.ÖğrenciEkleButtonu.Click += new System.EventHandler(this.ÖğrenciEkleButtonu_Click);
            // 
            // ogreklemail
            // 
            this.ogreklemail.Location = new System.Drawing.Point(109, 210);
            this.ogreklemail.Name = "ogreklemail";
            this.ogreklemail.Size = new System.Drawing.Size(122, 26);
            this.ogreklemail.TabIndex = 1;
            // 
            // ogreklesınıf
            // 
            this.ogreklesınıf.Location = new System.Drawing.Point(109, 120);
            this.ogreklesınıf.Name = "ogreklesınıf";
            this.ogreklesınıf.Size = new System.Drawing.Size(122, 26);
            this.ogreklesınıf.TabIndex = 1;
            // 
            // ogreklesoyad
            // 
            this.ogreklesoyad.Location = new System.Drawing.Point(109, 80);
            this.ogreklesoyad.Name = "ogreklesoyad";
            this.ogreklesoyad.Size = new System.Drawing.Size(122, 26);
            this.ogreklesoyad.TabIndex = 1;
            // 
            // ogreklead
            // 
            this.ogreklead.Location = new System.Drawing.Point(109, 38);
            this.ogreklead.Name = "ogreklead";
            this.ogreklead.Size = new System.Drawing.Size(122, 26);
            this.ogreklead.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mail :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Telefon :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sınıf :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Soyad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ad :";
            // 
            // fotoyuklebutton
            // 
            this.fotoyuklebutton.BackColor = System.Drawing.Color.Tomato;
            this.fotoyuklebutton.Location = new System.Drawing.Point(19, 194);
            this.fotoyuklebutton.Name = "fotoyuklebutton";
            this.fotoyuklebutton.Size = new System.Drawing.Size(150, 42);
            this.fotoyuklebutton.TabIndex = 2;
            this.fotoyuklebutton.Text = "Fotoğraf Yükle";
            this.fotoyuklebutton.UseVisualStyleBackColor = false;
            this.fotoyuklebutton.Click += new System.EventHandler(this.fotoyuklebutton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fotoyuklebutton);
            this.groupBox5.Controls.Add(this.pictureBox);
            this.groupBox5.Location = new System.Drawing.Point(1001, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(182, 296);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(19, 38);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(147, 136);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonogretmenekle);
            this.groupBox6.Controls.Add(this.ogretmeneklesınıf);
            this.groupBox6.Controls.Add(this.ogretmeneklesoyad);
            this.groupBox6.Controls.Add(this.ogretmeneklead);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(847, 340);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(320, 182);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // buttonogretmenekle
            // 
            this.buttonogretmenekle.BackColor = System.Drawing.Color.Tomato;
            this.buttonogretmenekle.Location = new System.Drawing.Point(82, 131);
            this.buttonogretmenekle.Name = "buttonogretmenekle";
            this.buttonogretmenekle.Size = new System.Drawing.Size(161, 45);
            this.buttonogretmenekle.TabIndex = 8;
            this.buttonogretmenekle.Text = "Öğretmen Ekle";
            this.buttonogretmenekle.UseVisualStyleBackColor = false;
            // 
            // ogretmeneklesınıf
            // 
            this.ogretmeneklesınıf.Location = new System.Drawing.Point(154, 99);
            this.ogretmeneklesınıf.Name = "ogretmeneklesınıf";
            this.ogretmeneklesınıf.Size = new System.Drawing.Size(89, 26);
            this.ogretmeneklesınıf.TabIndex = 5;
            // 
            // ogretmeneklesoyad
            // 
            this.ogretmeneklesoyad.Location = new System.Drawing.Point(154, 59);
            this.ogretmeneklesoyad.Name = "ogretmeneklesoyad";
            this.ogretmeneklesoyad.Size = new System.Drawing.Size(89, 26);
            this.ogretmeneklesoyad.TabIndex = 6;
            // 
            // ogretmeneklead
            // 
            this.ogretmeneklead.Location = new System.Drawing.Point(154, 17);
            this.ogretmeneklead.Name = "ogretmeneklead";
            this.ogretmeneklead.Size = new System.Drawing.Size(89, 26);
            this.ogretmeneklead.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(78, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sınıf :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(78, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Soyad :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(78, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Ad :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 539);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEtutOlustur;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSaat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTarih;
        private System.Windows.Forms.ComboBox comboBoxOgretmen;
        private System.Windows.Forms.ComboBox comboBoxDers;
        private System.Windows.Forms.Button btnEtutver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxogrenci;
        private System.Windows.Forms.TextBox textBoxETUTID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ogreklemail;
        private System.Windows.Forms.TextBox ogreklesınıf;
        private System.Windows.Forms.TextBox ogreklesoyad;
        private System.Windows.Forms.TextBox ogreklead;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button fotoyuklebutton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonogretmenekle;
        private System.Windows.Forms.TextBox ogretmeneklesınıf;
        private System.Windows.Forms.TextBox ogretmeneklesoyad;
        private System.Windows.Forms.TextBox ogretmeneklead;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ÖğrenciEkleButtonu;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxogrenciekle;
    }
}

