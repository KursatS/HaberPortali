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
    public partial class Uc_ParolaDegistir : UserControl
    {
        DbHaberPortaliEntities db = new DbHaberPortaliEntities();
        public Uc_ParolaDegistir()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (txt_Parola.Text == Login.Parola && txt_yeniParola.Text == txt_yeniParolaTekrar.Text)
            {
                tbl_Kullanici klnc = db.tbl_Kullanici.Find(int.Parse(Login.Id.ToString()));
                klnc.Parola = txt_yeniParola.Text;
                db.SaveChanges();
                label_Message.Text = "Parolanız Güncellendi.";
                Login.Parola = txt_yeniParola.Text;
                txt_yeniParola.Text = "";
                txt_Parola.Text = "";
                txt_yeniParolaTekrar.Text = "";

            }
            else
            {
                label_Message.Text = "Girilen bilgiler hatalı.";
            }
        }
    }
}
