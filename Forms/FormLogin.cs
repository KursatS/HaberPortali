using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberPortali_H5190062
{
    public partial class FormLogin : Form
    {
        DbHaberPortaliEntities db = new DbHaberPortaliEntities();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_Kullanici kullanici = db.tbl_Kullanici.Where(k => (k.KullaniciAdi == txt_Kadi.Text && k.Parola == txt_Parola.Text) || k.Eposta == txt_Kadi.Text && k.Parola == txt_Parola.Text).FirstOrDefault();
                if(kullanici != null)
                {
                    Login.Adi = kullanici.Adi;
                    Login.Soyadi = kullanici.Soyadi;
                    Login.Id = kullanici.Id;
                    Login.KullaniciAdi = kullanici.KullaniciAdi;
                    Login.Eposta = kullanici.Eposta;
                    Login.Parola = kullanici.Parola;
                    Login.Cinsiyet = kullanici.Cinsiyet;
                    Login.Resim = kullanici.Resim;
                    Login.Yetki = kullanici.Yetki;
                    Login.DogumTarihi = (DateTime)kullanici.DogumTarihi;

                    FormAnasayfa frm = new FormAnasayfa();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    label_Message.Text = "Böyle bir kullanıcı bulunamadı.";
                }
            }
            catch(Exception h)
            {
                label_Message.Text = "Beklenmedik bir hata meydana geldi : " + h.Message;
            }
        }
        private void AnaCerceveDegis(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_Giris.Controls.Clear();
            panel_Giris.Controls.Add(uc);
        }
        private void btn_KayıtOl_Click(object sender, EventArgs e)
        {
            Uc_KayitOl uckayitol = new Uc_KayitOl();
            AnaCerceveDegis(uckayitol);
        }

        private void btn_ZiyaretciGiris_Click(object sender, EventArgs e)
        {
            Login.Yetki = "Ziyaretçi";
            FormAnasayfa frm = new FormAnasayfa();
            this.Hide();
            frm.ShowDialog();
        }

        private void btn_SimgeDurumu_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
