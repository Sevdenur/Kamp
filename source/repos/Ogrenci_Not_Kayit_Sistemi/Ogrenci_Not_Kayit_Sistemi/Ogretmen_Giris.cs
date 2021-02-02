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

namespace Ogrenci_Not_Kayit_Sistemi
{
    public partial class Ogretmen_Giris : Form
    {
        public Ogretmen_Giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2DKOFA8;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void button_ogrtmn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "SELECT OGRETMEN_AD, OGRETMEN_SOYAD, OGRETMEN_NO FROM OGRETMEN";
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (maskedTextBox_ogrtmnNo.Text == dr["OGRETMEN_NO"].ToString() && 
                    textBox_ogrtmn_isim.Text == dr["OGRETMEN_AD"].ToString() && 
                    textBox_ogrtmn_soyisim.Text == dr["OGRETMEN_SOYAD"].ToString())
                {
                    Ogretmen_Detay_Form ogretmen_Detay_Form = new Ogretmen_Detay_Form();
                    ogretmen_Detay_Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz");
                }
            }              
        }
    }
}
