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
    public partial class Uc_Yetkilendirme : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\kursat;Initial Catalog=DbHaberPortali;Integrated Security=True;");
        public Uc_Yetkilendirme()
        {
            InitializeComponent();
            ComboBoxiDoldur();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_Kullanici where Eposta Like '%" + txt_AraEposta.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txt_Id.Text = oku["Id"].ToString();
                txt_Ad.Text = oku["Adi"].ToString();
                txt_Soyad.Text = oku["Soyadi"].ToString();
                txt_Eposta.Text = oku["Eposta"].ToString();
                txt_Kad.Text = oku["KullaniciAdi"].ToString();
                txt_Cinsiyet.Text = oku["Cinsiyet"].ToString();
                comboBox_Yetki.Text = oku["Yetki"].ToString();
            }
            baglanti.Close();
            if (txt_AraEposta.Text == "")
            {
                txt_Id.Text = "";
                txt_Ad.Text = "";
                txt_Soyad.Text = "";
                txt_Eposta.Text = "";
                txt_Kad.Text = "";
                txt_Cinsiyet.Text = "";
                comboBox_Yetki.Text = "";
            }
            if (txt_Id.Text == Login.Id.ToString())
            {
                txt_Id.Text = "";
                txt_Ad.Text = "";
                txt_Soyad.Text = "";
                txt_Eposta.Text = "";
                txt_Kad.Text = "";
                txt_Cinsiyet.Text = "";
                comboBox_Yetki.Text = "";
                label_Message.Text = "Kendi hesabınızın yetkisini değiştiremezsiniz.";
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_Kullanici SET Yetki='"+ comboBox_Yetki.Text +"' where Id =" + txt_Id.Text + "",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            label_Message.Text = "Yetkilendirme Başarılı!";
        }

        private void ComboBoxiDoldur()
        {
            comboBox_Yetki.Items.Add("Yönetici");
            comboBox_Yetki.Items.Add("Yazar");
            comboBox_Yetki.Items.Add("Kullanıcı");
        }
    }
}
