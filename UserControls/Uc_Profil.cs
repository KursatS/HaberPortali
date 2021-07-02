using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HaberPortali_H5190062
{
    public partial class Uc_Profil : UserControl
    {
        DbHaberPortaliEntities db = new DbHaberPortaliEntities();
        public Uc_Profil()
        {
            InitializeComponent();

            txt_Adi.Text = Login.Adi;
            txt_Soyadi.Text = Login.Soyadi;
            txt_Eposta.Text = Login.Eposta;
            txt_Id.Text = Login.Id.ToString();
            txt_KullaniciAdi.Text = Login.KullaniciAdi;
            txt_Yetki.Text = Login.Yetki;
            txt_Cinsiyeti.Text = Login.Cinsiyet;
            txt_DogumTarihi.Text = Login.DogumTarihi.ToString("MM/dd/yyyy");
            pictureBox_ProfilResmi.Image = Image.FromFile(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + Login.Id + "_ProfilResmi.png");

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_Parola.Text == Login.Parola)
            {
                tbl_Kullanici klnc = db.tbl_Kullanici.Find(int.Parse(txt_Id.Text));
                klnc.KullaniciAdi = txt_KullaniciAdi.Text;
                klnc.Eposta = txt_Eposta.Text;
                klnc.Resim = txt_ResimYolu.Text;
                db.SaveChanges();
                label_Message.Text = "Profil Güncellendi.";
                txt_Parola.Text = "";
            }
            else
            {
                label_Message.Text = "Parolanızı hatalı girdiniz.";
                txt_Parola.Text = "";
            }
        }

        private void btn_ProfilResmi_Click(object sender, EventArgs e)
        {
            if (openFDResim.ShowDialog() == DialogResult.OK)
            {
                pictureBox_ProfilResmi.ImageLocation = openFDResim.FileName;
                System.IO.File.Copy(openFDResim.FileName, @"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + Login.Id + "_ProfilResmi.png", true);
                string destFile = System.IO.Path.Combine(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images", openFDResim.SafeFileName);
                txt_ResimYolu.Text = destFile;
            }

        }
    }
}
