using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberPortali_H5190062
{
    public partial class FormAnasayfa : Form
    {

        int NavMenuGenislik;
        bool NavMenuAcik;
        public FormAnasayfa()
        {
            InitializeComponent();
            Loglama();
            if (Login.Adi != null)
            {
                txt_Adi.Text = Login.Adi;
                txt_Soyadi.Text = Login.Soyadi;
                txt_Yetki.Text = Login.Yetki;
                pictureBox_profilResmi.Image = Image.FromFile(@"C:\Users\kursa\Desktop\C# Uygulamaları Projesi\Images\" + Login.Id + "_ProfilResmi.png");
            }
            else
            {
                txt_Adi.Visible = false;
                txt_Soyadi.Text = "Ziyaretçi Hesabı";
                txt_Yetki.Visible = false;
            }

            NavMenuGenislik = panel_NavMenu.Width;
            NavMenuAcik = false;
            panel_NavMenu.Width = 72;
            timer_Zaman.Start();

            if (Login.Yetki == "Yazar")
            {
                btn_Yetkilendir.Visible = false;
            }

            if (Login.Yetki == "Yazar" || Login.Yetki == "Yönetici")
            {
            }
            else
            {
                btn_HaberEkle.Visible = false;
                btn_Yetkilendir.Visible = false;
            }

            if (txt_Soyadi.Text == "Ziyaretçi Hesabı")
            {
                btn_Profil.Visible = false;
                btn_Parola.Visible = false;
                btn_Yetkilendir.Visible = false;
            }

            Uc_SonDakika ucSonDakika = new Uc_SonDakika();
            AnaCerceveDegis(ucSonDakika);

        }

        private void Loglama()
        {
            var webClient = new WebClient();
            string dnsString = webClient.DownloadString("http://checkip.dyndns.org");
            dnsString = (new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(dnsString).Value;
            webClient.Dispose();
            File.AppendAllText(@"..\..\..\Loglar\" + DateTime.Now.ToString("dd.mm.yyyy") + ".txt",DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
            File.AppendAllText(@"..\..\..\Loglar\" + DateTime.Now.ToString("dd.mm.yyyy") + ".txt", " [INFO] Giriş Yaptı!");
            File.AppendAllText(@"..\..\..\Loglar\" + DateTime.Now.ToString("dd.mm.yyyy") + ".txt", " | Ip Adresi: ");
            File.AppendAllText(@"..\..\..\Loglar\" + DateTime.Now.ToString("dd.mm.yyyy") + ".txt", dnsString.ToString());
            File.AppendAllText(@"..\..\..\Loglar\" + DateTime.Now.ToString("dd.mm.yyyy") + ".txt", " Kullanıcı Id: ");
            File.AppendAllText(@"..\..\..\Loglar\" + DateTime.Now.ToString("dd.mm.yyyy") + ".txt", Login.Id.ToString());
            File.AppendAllText(@"..\..\..\Loglar\" + DateTime.Now.ToString("dd.mm.yyyy") + ".txt", " Adı: ");
            File.AppendAllText(@"..\..\..\Loglar\" + DateTime.Now.ToString("dd.mm.yyyy") + ".txt", Login.Adi);
            File.AppendAllText(@"..\..\..\Loglar\" + DateTime.Now.ToString("dd.mm.yyyy") + ".txt", " Soyadı: ");
            File.AppendAllText(@"..\..\..\Loglar\" + DateTime.Now.ToString("dd.mm.yyyy") + ".txt", Login.Soyadi);
            File.AppendAllText(@"..\..\..\Loglar\" + DateTime.Now.ToString("dd.mm.yyyy") + ".txt", Environment.NewLine);



        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_NavMenu_Click(object sender, EventArgs e)
        {
            timer_NavMenu.Start();
        }

        private void timer_NavMenu_Tick(object sender, EventArgs e)
        {
            if (NavMenuAcik)
            {
                panel_NavMenu.Width = panel_NavMenu.Width - 5;
                if(panel_NavMenu.Width <= 72)
                {
                    NavMenuAcik = false;
                    timer_NavMenu.Stop();
                    this.Refresh();
                }
            }
            else
            {
                panel_NavMenu.Width = panel_NavMenu.Width + 5;
                if (panel_NavMenu.Width >= 220)
                {
                    NavMenuAcik = true;
                    timer_NavMenu.Stop();
                    this.Refresh();
                }
            }
        }

        private void AnaCerceveDegis(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_AnaCerceve.Controls.Clear();
            panel_AnaCerceve.Controls.Add(uc);
        }

        private void btn_Profil_Click(object sender, EventArgs e)
        {
            Uc_Profil ucProfil = new Uc_Profil();
            AnaCerceveDegis(ucProfil);
        }

        private void btn_Parola_Click(object sender, EventArgs e)
        {
            Uc_ParolaDegistir ucParola = new Uc_ParolaDegistir();
            AnaCerceveDegis(ucParola);
        }

        private void timer_Zaman_Tick(object sender, EventArgs e)
        {
            label_Zaman.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        }

        private void btn_SonDakika_Click(object sender, EventArgs e)
        {
            Uc_SonDakika ucSonDakika = new Uc_SonDakika();
            AnaCerceveDegis(ucSonDakika);
        }

        private void btn_AnaHaber_Click(object sender, EventArgs e)
        {
            Uc_AnaHaberler ucanahaberler = new Uc_AnaHaberler();
            AnaCerceveDegis(ucanahaberler);
        }

        private void btn_TümHaberler_Click(object sender, EventArgs e)
        {
            Uc_TümHaberler uctumhaberler = new Uc_TümHaberler();
            AnaCerceveDegis(uctumhaberler);
        }

        private void btn_HaberEkle_Click(object sender, EventArgs e)
        {
            Uc_HaberEkle uchaberekle = new Uc_HaberEkle();
            AnaCerceveDegis(uchaberekle);
        }

        private void btn_Yetkilendir_Click(object sender, EventArgs e)
        {
            Uc_Yetkilendirme ucyetkilendirme = new Uc_Yetkilendirme();
            AnaCerceveDegis(ucyetkilendirme);
        }

        private void btn_SimgeDurumu_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
