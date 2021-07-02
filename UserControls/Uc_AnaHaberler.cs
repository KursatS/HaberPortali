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
    public partial class Uc_AnaHaberler : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\kursat;Initial Catalog=DbHaberPortali;Integrated Security=True;");
        DbHaberPortaliEntities db = new DbHaberPortaliEntities();
        String begendi = "";
        public Uc_AnaHaberler()
        {
            InitializeComponent();

            HaberResimleriniGetir();

            if (Login.Yetki == "Ziyaretçi")
            {
                btn_Begen.Visible = false;
            }
        }

        private void HaberResimleriniGetir()
        {
            var hbrlr = db.tbl_Haberler.SqlQuery("Select top 5 * from tbl_Haberler where HaberTuru = 'Ana Haber' order by Id desc").ToList();
            pictureBox_AnaHaber1.Image = Image.FromFile(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + hbrlr[0].Id + "_HaberResmi.png");
            pictureBox_AnaHaber2.Image = Image.FromFile(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + hbrlr[1].Id + "_HaberResmi.png");
            pictureBox_AnaHaber3.Image = Image.FromFile(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + hbrlr[2].Id + "_HaberResmi.png");
            pictureBox_AnaHaber4.Image = Image.FromFile(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + hbrlr[3].Id + "_HaberResmi.png");
            pictureBox_AnaHaber5.Image = Image.FromFile(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + hbrlr[4].Id + "_HaberResmi.png");
        }

        private void HaberiGetir(int topSorgu)
        {
            var hbrlr = db.tbl_Haberler.SqlQuery("Select top " + topSorgu + " * from tbl_Haberler where HaberTuru = 'Ana Haber' order by Id desc").LastOrDefault();

            richTextBox_HaberYazisi.Text = hbrlr.HaberYazisi;
            label_HaberBaslik.Text = hbrlr.HaberBaslik;
            label_HaberYayinTarihi.Text = hbrlr.YayinTarihi.ToString();
            label_HaberBaslik.Visible = true;
            label_HaberYayinTarihi.Visible = true;
            richTextBox_HaberYazisi.Visible = true;
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
            SqlCommand kontrol = new SqlCommand("Select Id from tbl_Okunma where KullaniciId = @KullaniciId and HaberId = @HaberId",baglanti);
            kontrol.Parameters.AddWithValue("@KullaniciId" , Login.Id.ToString());
            kontrol.Parameters.AddWithValue("@HaberId" , txt_HaberId.Text);
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

        private void pictureBox_AnaHaber1_Click(object sender, EventArgs e)
        {
            HaberiGetir(1);
            OkunmaEkle();
            timer_AnaHaberSize.Start();
        }


        private void pictureBox_AnaHaber2_Click(object sender, EventArgs e)
        {
            HaberiGetir(2);
            OkunmaEkle();
            timer_AnaHaberSize.Start();

        }

        private void pictureBox_AnaHaber3_Click(object sender, EventArgs e)
        {
            HaberiGetir(3);
            OkunmaEkle();
            timer_AnaHaberSize.Start();

        }

        private void pictureBox_AnaHaber5_Click(object sender, EventArgs e)
        {
            HaberiGetir(5);
            OkunmaEkle();
            timer_AnaHaberSize.Start();

        }

        private void pictureBox_AnaHaber4_Click(object sender, EventArgs e)
        {
            HaberiGetir(4);
            OkunmaEkle();
            timer_AnaHaberSize.Start();

        }

        private void timer_AnaHaberSize_Tick(object sender, EventArgs e)
        {
            if (panel_AnaHaberBilgileri.Height <= 200)
            {
                panel_AnaHaberBilgileri.Height += 10;
                panel_Haberler.Height -= 10;
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
    }
}
