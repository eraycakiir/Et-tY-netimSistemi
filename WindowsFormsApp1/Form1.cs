using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0UHEVM7\SQLEXPRESS;Initial Catalog=etut_db;Integrated Security=True");
            void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLDERS", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxDers.ValueMember = "DERSID";
            comboBoxDers.DisplayMember = "DERSAD";
            comboBoxDers.DataSource = dt;
        }
        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etut2", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
        }

        private void comboBoxDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select*From TBLOGRETMEN where BRANSID=" + comboBoxDers.SelectedValue, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxOgretmen.ValueMember = "OGRTID";
            comboBoxOgretmen.DisplayMember = "AD";
            comboBoxOgretmen.DataSource = dt2;        }

        private void btnEtutOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLETUT(DERSID,OGRETMENID,TARIH,SAAT)values(@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBoxDers.SelectedValue);
            komut.Parameters.AddWithValue("@P2", comboBoxOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@P3", maskedTextBoxTarih.Text);
            komut.Parameters.AddWithValue("@P4", maskedTextBoxSaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Oluşturuldu", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxETUTID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnEtutver_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLETUT set OGRENCIID=@p1,DURUM=@p2 where ID =@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", textBoxogrenci.Text);
            komut.Parameters.AddWithValue("@p2", "true");
            komut.Parameters.AddWithValue("@p3", textBoxETUTID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        private void fotoyuklebutton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox.ImageLocation = openFileDialog1.FileName;
        }

        private void ÖğrenciEkleButtonu_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", ogreklead.Text);
            komut.Parameters.AddWithValue("@p2", ogreklesoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox.ImageLocation);
            komut.Parameters.AddWithValue("@p4", ogreklesınıf.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBoxogrenciekle.Text);
            komut.Parameters.AddWithValue("@p6", ogreklemail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme EKlendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
