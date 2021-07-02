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
    public partial class Uc_SonDakika : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\kursat;Initial Catalog=DbHaberPortali;Integrated Security=True;");
        DbHaberPortaliEntities db = new DbHaberPortaliEntities();
        String begendi = "";
        public Uc_SonDakika()
        {
            InitializeComponent();

            HaberResminiGetir(1);

        }

        private void HaberResminiGetir(int topSorgu)
        {
            var hbrlr = db.tbl_Haberler.SqlQuery("Select top " + topSorgu + " * from tbl_Haberler where HaberTuru = 'Son Dakika Haberi' order by Id desc").LastOrDefault();
            pictureBox_HaberResmi.Image = Image.FromFile(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + hbrlr.Id + "_HaberResmi.png");
        }
        private void SonDakikaHaberiniGetir(int topSorgu)
        {
            var hbrlr = db.tbl_Haberler.SqlQuery("Select top " + topSorgu + " * from tbl_Haberler where HaberTuru= 'Son Dakika Haberi' order by Id desc").LastOrDefault();

            richTextBox_HaberYazisi.Text = hbrlr.HaberYazisi;
            label_HaberBaslik.Text = hbrlr.HaberBaslik;
            label_HaberYayinTarihi.Text = hbrlr.YayinTarihi.ToString();
            label_AltBaslik.Text = hbrlr.HaberAltbaslik;
            pictureBox_HaberResmi.Image = Image.FromFile(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + hbrlr.Id + "_HaberResmi.png");
            txt_HaberId.Text = hbrlr.Id.ToString();

            begenileriGetir();
            okunmalarıGetir();

        }
        private void begenileriGetir()
        {
            baglanti.Open();
            SqlCommand begeni = new SqlCommand("Select Count(*) from tbl_Begeni where HaberId = @HaberId", baglanti);
            begeni.Parameters.AddWithValue("@HaberId", txt_HaberId.Text);
            Int32 count2 = Convert.ToInt32(begeni.ExecuteScalar());
            label_BegeniSayisi.Text = count2.ToString();
            baglanti.Close();
            begenildimi();
            if (Login.Yetki != "Ziyaretçi")
            {
                btn_Begen.Visible = true;
            }

        }

        private void okunmalarıGetir()
        {
            baglanti.Open();
            SqlCommand okunma = new SqlCommand("Select Count(*) from tbl_Okunma where HaberId = @HaberId", baglanti);
            okunma.Parameters.AddWithValue("@HaberId", txt_HaberId.Text);
            Int32 count = Convert.ToInt32(okunma.ExecuteScalar());
            label_OkunmaSayisi.Text = count.ToString();
            baglanti.Close();
        }

        private void OkunmaEkle()
        {
            string okunduBilgisi = "";
            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("Select Id from tbl_Okunma where KullaniciId = @KullaniciId and HaberId = @HaberId", baglanti);
            kontrol.Parameters.AddWithValue("@KullaniciId", Login.Id.ToString());
            kontrol.Parameters.AddWithValue("@HaberId", txt_HaberId.Text);
            SqlDataReader oku = kontrol.ExecuteReader();
            while (oku.Read())
            {
                okunduBilgisi = "okundu";
            }
            baglanti.Close();
            if (okunduBilgisi != "okundu" && Login.Yetki != "Ziyaretçi")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into tbl_Okunma(HaberId,KullaniciId) Values(@HaberId,@KullaniciId)", baglanti);
                komut.Parameters.AddWithValue("@HaberId", txt_HaberId.Text);
                komut.Parameters.AddWithValue("@KullaniciId", Login.Id);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }
        private void begenildimi()
        {
            begendi = "";
            baglanti.Open();
            SqlCommand begenKontrol = new SqlCommand("Select Id from tbl_Begeni where KullaniciId = @KullaniciId and HaberId = @HaberId", baglanti);
            begenKontrol.Parameters.AddWithValue("@KullaniciId", Login.Id);
            begenKontrol.Parameters.AddWithValue("@HaberId", txt_HaberId.Text);
            SqlDataReader oku = begenKontrol.ExecuteReader();
            while (oku.Read())
            {
                begendi = "begendi";
            }
            if (begendi == "begendi")
            {
                btn_Begen.Image = System.Drawing.Image.FromFile(@"../../../Icons/iconsCrimsonFill_facebook_like.ico");
            }
            else
            {
                btn_Begen.Image = System.Drawing.Image.FromFile(@"../../../Icons/iconsCrimson_facebook_like_32.png");
            }
            baglanti.Close();
        }

        private void btn_Begen_Click(object sender, EventArgs e)
        {
            if (begendi != "begendi")
            {
                baglanti.Open();
                SqlCommand haberBegen = new SqlCommand("Insert Into tbl_Begeni (KullaniciId,HaberId) values(@KullaniciId,@HaberId)", baglanti);
                haberBegen.Parameters.AddWithValue("@HaberId", txt_HaberId.Text);
                haberBegen.Parameters.AddWithValue("@KullaniciId", Login.Id);
                haberBegen.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand haberBegenme = new SqlCommand("Delete from tbl_Begeni Where HaberId = @HaberId and KullaniciId = @KullaniciId", baglanti);
                haberBegenme.Parameters.AddWithValue("@HaberId", txt_HaberId.Text);
                haberBegenme.Parameters.AddWithValue("@KullaniciId", Login.Id);
                haberBegenme.ExecuteNonQuery();
                baglanti.Close();
            }
            begenildimi();
            begenileriGetir();

        }
        private void btn_SonDakikaTop1_Click(object sender, EventArgs e)
        {

            label_HaberBaslik.Visible = true;
            label_HaberYayinTarihi.Visible = true;
            richTextBox_HaberYazisi.Visible = true;
            label_AltBaslik.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            SonDakikaHaberiniGetir(1);
            OkunmaEkle();

        }

        private void btn_SonDakikaTop2_Click(object sender, EventArgs e)
        {
            label_HaberBaslik.Visible = true;
            label_HaberYayinTarihi.Visible = true;
            richTextBox_HaberYazisi.Visible = true;
            label_AltBaslik.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            SonDakikaHaberiniGetir(2);
            OkunmaEkle();
        }

        private void btn_SonDakikaTop3_Click(object sender, EventArgs e)
        {
            label_HaberBaslik.Visible = true;
            label_HaberYayinTarihi.Visible = true;
            richTextBox_HaberYazisi.Visible = true;
            label_AltBaslik.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            SonDakikaHaberiniGetir(3);
            OkunmaEkle();
        }

        private void btn_SonDakikaTop4_Click(object sender, EventArgs e)
        {
            label_HaberBaslik.Visible = true;
            label_HaberYayinTarihi.Visible = true;
            richTextBox_HaberYazisi.Visible = true;
            label_AltBaslik.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            SonDakikaHaberiniGetir(4);
            OkunmaEkle();
        }

        private void btn_SonDakikaTop5_Click(object sender, EventArgs e)
        {
            label_HaberBaslik.Visible = true;
            label_HaberYayinTarihi.Visible = true;
            richTextBox_HaberYazisi.Visible = true;
            label_AltBaslik.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            SonDakikaHaberiniGetir(5);
            OkunmaEkle();
        }

        private void btn_SonDakikaTop1_MouseHover(object sender, EventArgs e)
        {
            HaberResminiGetir(1);
        }
        private void btn_SonDakikaTop2_MouseHover(object sender, EventArgs e)
        {
            HaberResminiGetir(2);
        }
        private void btn_SonDakikaTop3_MouseHover(object sender, EventArgs e)
        {
            HaberResminiGetir(3);
        }
        private void btn_SonDakikaTop4_MouseHover(object sender, EventArgs e)
        {
            HaberResminiGetir(4);
        }
        private void btn_SonDakikaTop5_MouseHover(object sender, EventArgs e)
        {
            HaberResminiGetir(5);
        }
    }
}
