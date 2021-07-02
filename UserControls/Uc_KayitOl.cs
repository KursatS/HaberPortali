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
    public partial class Uc_KayitOl : UserControl
    {
        DbHaberPortaliEntities db = new DbHaberPortaliEntities();
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\kursat;Initial Catalog=DbHaberPortali;Integrated Security=True;");
        public Uc_KayitOl()
        {
            
            InitializeComponent();
            YeniKayitIdGetir();
        }
        private string destFile = "";

        private void btn_KayıtOl_Click(object sender, EventArgs e)
        {
            string cinsiyet;
            if (rB_Erkek.Checked == true)
            {
                cinsiyet = "E";
            }
            else
            {
                cinsiyet = "K";
            }

            if (txt_Adiniz.Text.Length < 2)
            {
                label_Message.Text = "Adınız 2 karakterden az olamaz!";
            }
            else if (txt_Soyadiniz.Text.Length < 2)
            {
                label_Message.Text = "Soyadınız 2 karakterden az olamaz!";
            }
            else if (!txt_Epostaniz.Text.Contains('@') || txt_Epostaniz.Text.Length < 5)
            {
                label_Message.Text = "Lütfen doğru bir eposta adresi giriniz!";
            }
            else if (txt_KullaniciAdiniz.Text.Length < 5)
            {
                label_Message.Text = "Kullanıcı adınız 5 karakterden az olamaz!";
            }
            else if (txt_Parolaniz.Text.Length < 5)
            {
                label_Message.Text = "Parolanız 5 karakterden az olamaz!";
            }
            else if (txt_Parolaniz.Text != txt_ParolanizTekrar.Text)
            {
                label_Message.Text = "Girdiğiniz parolalar eşleşmedi!";
            }
            else if (rB_Erkek.Checked == rB_Kadın.Checked)
            {
                label_Message.Text = "Lütfen cinsiyetinizi seçiniz!";
            }
            else if (dtp_DogumTarihi.Value == null)
            {
                label_Message.Text = "Lütfen geçerli bir doğum tarihi giriniz!";
            }
            else
            {
                string sorgu = "INSERT INTO tbl_Kullanici(Id,Adi,Soyadi,KullaniciAdi,Eposta,Parola,DogumTarihi,Cinsiyet,Resim,Yetki) VALUES (@Id,@Adi,@Soyadi,@KullaniciAdi,@Eposta,@Parola,@DogumTarihi,@Cinsiyet,@Resim,@Yetki)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Id", txt_KayitId.Text);
                komut.Parameters.AddWithValue("@Adi", txt_Adiniz.Text);
                komut.Parameters.AddWithValue("@Soyadi", txt_Soyadiniz.Text);
                komut.Parameters.AddWithValue("@KullaniciAdi", txt_KullaniciAdiniz.Text);
                komut.Parameters.AddWithValue("@Eposta", txt_Epostaniz.Text);
                komut.Parameters.AddWithValue("@Parola", txt_Parolaniz.Text);
                komut.Parameters.AddWithValue("@DogumTarihi", dtp_DogumTarihi.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                komut.Parameters.AddWithValue("@Resim", destFile);
                komut.Parameters.AddWithValue("@Yetki", "Kullanıcı");

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                FormLogin frm = new FormLogin();
                this.Hide();
                frm.ShowDialog();
            }

        }
        public void YeniKayitIdGetir()
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select top 1 Id from tbl_Kullanici order by Id desc", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                int yenikullaniciid = int.Parse(oku3["Id"].ToString());
                txt_KayitId.Text = (yenikullaniciid + 1).ToString();
            }
            baglanti.Close();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void btn_KayitResim_Click(object sender, EventArgs e)
        {
            if (openFDResim.ShowDialog() == DialogResult.OK)
            {
                pictureBox_KayitResim.ImageLocation = openFDResim.FileName;
                System.IO.File.Copy(openFDResim.FileName, @"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + txt_KayitId.Text + "_ProfilResmi.png", true);
                destFile = System.IO.Path.Combine(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images", openFDResim.SafeFileName);
            }
        }

        private void dtp_DogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtp_DogumTarihi.Format = DateTimePickerFormat.Custom;
            dtp_DogumTarihi.CustomFormat = "MM/dd/yyyy";
            
            txt_DogumTarihi.Text = dtp_DogumTarihi.Text; 
        }

    }
}
