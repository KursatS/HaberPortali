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
    public partial class Uc_TümHaberler : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\kursat;Initial Catalog=DbHaberPortali;Integrated Security=True;");
        public Uc_TümHaberler()
        {
            InitializeComponent();
            HaberleriListele("Select Id,HaberBaslik,HaberAltBaslik,HaberYazisi,YayinTarihi,KullaniciId,KategoriId,HaberTuru from tbl_Haberler");
            ComboBoxlariDoldur();
            dtp_Gun.CustomFormat = " ";
            dtp_Gun.Format = DateTimePickerFormat.Custom;

            if (Login.Yetki == "Yazar" || Login.Yetki == "Yönetici")
            {
                txt_HaberBaslik.ReadOnly = false;
                txt_HaberAltBaslik.ReadOnly = false;
                txt_HaberKategorisi.ReadOnly = false;
                txt_HaberTuru.ReadOnly = false;
                txt_HaberYayinTarihi.ReadOnly = false;
                txt_HaberYazari.ReadOnly = false;
                richTextBox_HaberYazisi.ReadOnly = false;
            }

        }
        private string destFile = "";

        private void begenileriGetir()
        {
            baglanti.Open();
            SqlCommand begeni = new SqlCommand("Select Count(*) from tbl_Begeni where HaberId = @HaberId", baglanti);
            begeni.Parameters.AddWithValue("@HaberId", txt_HaberId.Text);
            Int32 count2 = Convert.ToInt32(begeni.ExecuteScalar());
            txt_BegeniSayisi.Text = count2.ToString();
            baglanti.Close();
        }

        private void okunmalarıGetir()
        {
            baglanti.Open();
            SqlCommand okunma = new SqlCommand("Select Count(*) from tbl_Okunma where HaberId = @HaberId", baglanti);
            okunma.Parameters.AddWithValue("@HaberId", txt_HaberId.Text);
            Int32 count = Convert.ToInt32(okunma.ExecuteScalar());
            txt_OkunmaSayisi.Text = count.ToString();
            baglanti.Close();
        }
        public void ComboBoxlariDoldur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_Kullanici where Yetki= 'Yazar'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox_HaberYazari.Items.Add(oku["Adi"]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from tbl_Kategori",baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                comboBox_HaberKategorisi.Items.Add(oku1["Ad"]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select distinct HaberTuru from tbl_Haberler",baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox_HaberTuru.Items.Add(oku2["HaberTuru"]);
            }
            baglanti.Close();
            
        }
        public void HaberleriListele(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView_TumHaberler.DataSource = ds.Tables[0];
            dataGridView_TumHaberler.Columns["Id"].Visible = false;
            dataGridView_TumHaberler.Columns["HaberBaslik"].Width = 260;
        }

        private void Convertor(string KategoriId,string KullaniciId)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Ad from tbl_Kategori where Id = " + KategoriId + "",baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                txt_HaberKategorisi.Text = oku1["Ad"].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Adi,Soyadi from tbl_Kullanici where Id = " + KullaniciId + "", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                txt_HaberYazari.Text = oku2["Adi"].ToString();
                txt_HaberYazari.Text += " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();


        }

        private void dataGridView_TumHaberler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var HaberId = dataGridView_TumHaberler.CurrentRow.Cells["Id"].Value.ToString();
            var KategoriId = dataGridView_TumHaberler.CurrentRow.Cells["KategoriId"].Value.ToString();
            var KullaniciId = dataGridView_TumHaberler.CurrentRow.Cells["KullaniciId"].Value.ToString();
            Convertor(KategoriId,KullaniciId);
            txt_HaberBaslik.Text = dataGridView_TumHaberler.CurrentRow.Cells["HaberBaslik"].Value.ToString();
            txt_HaberAltBaslik.Text = dataGridView_TumHaberler.CurrentRow.Cells["HaberAltbaslik"].Value.ToString();
            txt_HaberTuru.Text = dataGridView_TumHaberler.CurrentRow.Cells["HaberTuru"].Value.ToString();
            txt_HaberYayinTarihi.Text = dataGridView_TumHaberler.CurrentRow.Cells["YayinTarihi"].Value.ToString();
            richTextBox_HaberYazisi.Text = dataGridView_TumHaberler.CurrentRow.Cells["HaberYazisi"].Value.ToString();
            pictureBox_HaberResmi.Image = Image.FromFile(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + HaberId + "_HaberResmi.png");
            txt_HaberId.Text = HaberId;

            if (Login.Yetki == "Ziyaretçi" || Login.Yetki == "Kullanıcı")
            {
                btn_Duzenle.Visible = false;
                btn_Sil.Visible = false;
            }
            else
            {
                btn_Duzenle.Visible = true;
                btn_Sil.Visible = true;
            }

            begenileriGetir();
            okunmalarıGetir();
        
        }
        private string Sqlkomut = "";
        private void btn_FiltreliAra_Click(object sender, EventArgs e)
        {
            Haberler();
        }

        private void Haberler()
        {
            if (checkBox_Pasifmi.Checked == true)
            {
                Sqlkomut = "Select Id,HaberBaslik,HaberAltBaslik,HaberYazisi,YayinTarihi,KullaniciId,KategoriId,HaberTuru from tbl_Haberler Where Durum = 'P' ";
            }
            else
            {
                Sqlkomut = "Select Id,HaberBaslik,HaberAltBaslik,HaberYazisi,YayinTarihi,KullaniciId,KategoriId,HaberTuru from tbl_Haberler Where Durum = 'A' ";
            }

            if (comboBox_HaberYazari.Text != "")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("Select Id from tbl_Kullanici where Adi = '" + comboBox_HaberYazari.Text + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Sqlkomut += "and KullaniciId = '" + oku["Id"].ToString() + "'";
                }

                baglanti.Close();
            }
            if (comboBox_HaberKategorisi.Text != "")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("Select Id from tbl_Kategori where Ad = '" + comboBox_HaberKategorisi.Text + "'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Sqlkomut += " and KategoriId = '" + oku["Id"].ToString() + "'";
                }

                baglanti.Close();
            }
            if (comboBox_HaberTuru.Text != "")
            {
                Sqlkomut += " and HaberTuru = '" + comboBox_HaberTuru.Text + "'";
            }
            if (dtp_Gun.Text != " ")
            {
                Sqlkomut += " and YayinTarihi between '" + dtp_Gun.Text + " 00:00' and '" + dtp_Gun.Text + " 23:59'";
            }
            HaberleriListele(Sqlkomut);
            comboBox_HaberKategorisi.Text = "";
            comboBox_HaberTuru.Text = "";
            comboBox_HaberYazari.Text = "";
            dtp_Gun.CustomFormat = " ";
            dtp_Gun.Format = DateTimePickerFormat.Custom;
        }

        private void dtp_Gun_ValueChanged(object sender, EventArgs e)
        {
            dtp_Gun.CustomFormat = "yyyy/MM/dd";
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update tbl_Haberler SET HaberYazisi= @HaberYazisi , Durum = 'A' where Id = " + txt_HaberId.Text + "", baglanti);
                komut.Parameters.AddWithValue("@HaberYazisi", richTextBox_HaberYazisi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
            Haberler();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_Haberler SET Durum='P' where Id =" + txt_HaberId.Text + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Haberler();

        }
    }
}
