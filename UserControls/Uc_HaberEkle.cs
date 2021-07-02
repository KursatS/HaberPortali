using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberPortali_H5190062
{
    public partial class Uc_HaberEkle : UserControl
    {
        DbHaberPortaliEntities db = new DbHaberPortaliEntities();
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\kursat;Initial Catalog=DbHaberPortali;Integrated Security=True;");
        public Uc_HaberEkle()
        {
            InitializeComponent();
            ComboBoxlariDoldur();
            YeniHaberIdGetir();
        }

        private string destFile = "";
        private string kategoriId = "";

        public void YeniHaberIdGetir()
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select top 1 Id from tbl_Haberler order by Id desc", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                int yenihaberid = int.Parse(oku3["Id"].ToString());
                txt_YeniHaberId.Text = (yenihaberid + 1).ToString();
            }
            baglanti.Close();
        }
        public void ComboBoxlariDoldur()
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from tbl_Kategori", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                comboBox_HaberKategori.Items.Add(oku1["Ad"]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select distinct HaberTuru from tbl_Haberler", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox_HaberTuru.Items.Add(oku2["HaberTuru"]);
            }
            baglanti.Close();

        }

        private void Converter(string KategoriAdi)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Id from tbl_Kategori where Ad = '"+ KategoriAdi + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kategoriId = oku["Id"].ToString();
            }
            baglanti.Close();
        }

        private void btn_HaberEkle_Click(object sender, EventArgs e)
        {
            Converter(comboBox_HaberKategori.Text);
            string sorgu = "INSERT INTO tbl_Haberler(Id,HaberBaslik,HaberAltBaslik,HaberYazisi,KullaniciId,KategoriId,HaberResim,HaberTuru,Durum) VALUES (@Id,@HaberBaslik,@HaberAltBaslik,@HaberYazisi,@KullaniciId,@KategoriId,@HaberResim,@HaberTuru,@Durum)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@HaberBaslik", txt_HaberBaslik.Text);
            komut.Parameters.AddWithValue("@HaberAltBaslik", txt_HaberAltBaslik.Text);
            komut.Parameters.AddWithValue("@HaberYazisi", richTextBox_HaberYazisi.Text);
            komut.Parameters.AddWithValue("@KullaniciId", Login.Id);
            komut.Parameters.AddWithValue("@HaberTuru", comboBox_HaberTuru.Text);
            komut.Parameters.AddWithValue("@Id", txt_YeniHaberId.Text);
            komut.Parameters.AddWithValue("@HaberResim", destFile);
            komut.Parameters.AddWithValue("@KategoriId", kategoriId);
            komut.Parameters.AddWithValue("@Durum", "A");

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Uc_HaberEkle uchaberekle = new Uc_HaberEkle();
            AnaCerceveDegis(uchaberekle);
        }
        private void AnaCerceveDegis(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_AnaCerceve.Controls.Clear();
            panel_AnaCerceve.Controls.Add(uc);
        }
        private void btn_HaberResmi_Click(object sender, EventArgs e)
        {
            
            if (openFDResim.ShowDialog() == DialogResult.OK)
            {
                pictureBox_HaberResmi.ImageLocation = openFDResim.FileName;
                System.IO.File.Copy(openFDResim.FileName, @"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + txt_YeniHaberId.Text + "_HaberResmi.png", true);
                destFile = System.IO.Path.Combine(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images", openFDResim.SafeFileName);
            }
            
        }
    }
}
