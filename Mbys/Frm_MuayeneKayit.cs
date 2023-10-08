using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mbys
{
    public partial class Frm_MuayeneKayit : Form
    {
        public Frm_MuayeneKayit()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=MBYS;User Id=postgres;Password=1234");




        string Tckontrol;
        public void tckontrol(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                Tckontrol = dr[0].ToString();
            }

            komut.Dispose();
            conn.Close();
         
        }








            private void btn_MuayeneKayit_Click(object sender, EventArgs e)
        {
            
            if (msk_hasta_tc.Text != "" && msk_hasta_sikayet.Text != "" && msk_hasta_Tani.Text != "" && msk_hasta_tc.Text != "" && msk_hasta_tedavi.Text != "" && msk_muayane_adi.Text != "" && msk_muayene_soyad.Text != "")
            {

              tckontrol("select tcno from muayene  where tcno='"+Convert.ToInt32(msk_hasta_tc.Text)+"' and tarih='"+ Convert.ToDateTime(msk_hasta_muayaneTarihi.Text) + "'");
             
                if (Convert.ToInt32(Tckontrol) != Convert.ToInt32(msk_hasta_tc.Text))
                {

                    conn.Open();
                    NpgsqlCommand muayene_ekle = new NpgsqlCommand();
                    muayene_ekle.Connection = conn;
                    muayene_ekle.Parameters.AddWithValue("@ad", msk_muayane_adi.Text);
                    muayene_ekle.Parameters.AddWithValue("@soyad", msk_muayene_soyad.Text);
                    muayene_ekle.Parameters.AddWithValue("@tcno", Convert.ToInt32(msk_hasta_tc.Text));
                    muayene_ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(msk_hasta_muayaneTarihi.Text));
                    muayene_ekle.Parameters.AddWithValue("@sikayet", msk_hasta_sikayet.Text);
                    muayene_ekle.Parameters.AddWithValue("@tani", msk_hasta_Tani.Text);
                    muayene_ekle.Parameters.AddWithValue("@tedavi", msk_hasta_tedavi.Text);
                    muayene_ekle.Parameters.AddWithValue("@receteno", 0);

                    muayene_ekle.CommandType = CommandType.Text;
                    muayene_ekle.CommandText = "insert into muayene (ad,soyad,tcno, tarih, sikayet, tani, tedavi, recete_no) values (@ad,@soyad,@tcno, @tarih, @sikayet, @tani, @tedavi,@receteno)";

                    NpgsqlDataReader dr = muayene_ekle.ExecuteReader();

                    conn.Close();
                    muayene_ekle.Dispose();


                    MessageBox.Show("muayene bilgileri başarıyla kaydedildi");
                    btn_MuayeneKayit.Hide();
                    btn_ReceteOlustur.Visible = true;



                }

            }
            else MessageBox.Show("Boş Bırkma Lütfen ");



          
        }

        private void Frm_MuayeneKayit_Load(object sender, EventArgs e)
        {

            msk_hasta_muayaneTarihi.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void btn_ReceteOlustur_Click(object sender, EventArgs e)
        {
            btn_ReceteOlustur.Hide();



            msk_hasta_muayaneTarihi.Text = System.DateTime.Now.ToString("dd/MM/yyyy");

            Frm_ReceteOlustur frm_ReceteOlustur = new Frm_ReceteOlustur();
            frm_ReceteOlustur.msk_ReceteMuayaneTarihi.Text = msk_hasta_muayaneTarihi.Text;
            frm_ReceteOlustur.msk_ReceteAdi.Text = msk_muayane_adi.Text;
            frm_ReceteOlustur.msk_ReceteSoyad.Text = msk_muayene_soyad.Text;
            //  frm_Recete.msk_recete_receteno.Text = msk_hasta_receteno.Text;
            frm_ReceteOlustur.msk_ReceteTani.Text = msk_hasta_Tani.Text;
            frm_ReceteOlustur.msk_ReceteTc.Text = msk_hasta_tc.Text;
            frm_ReceteOlustur.msk_IlacAdi.Select();
            this.Hide();
            frm_ReceteOlustur.ShowDialog();
        }
    }
}
