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
    public partial class Uc_Yorum : UserControl
    {
        DbHaberPortaliEntities db = new DbHaberPortaliEntities();

        public Uc_Yorum()
        {
            InitializeComponent();
            //label_YorumSahibi.Text = Yorumlar.HaberId.ToString();
            //label_YorumSahibiSoyad.Text = Yorumlar.KullaniciId.ToString();
            //label_YorumSahibiYetki.Text = Yorumlar.KullaniciId.ToString();
            //label_YorumTarihi.Text = Yorumlar.YorumTarihi.ToString();
            //richTextBox_Yorum.Text = Yorumlar.Yorum;
        }

    }
}
