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
    public partial class Frm_ReceteOlustur : Form
    {
        public Frm_ReceteOlustur()
        {
            InitializeComponent();
        }

        
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=MBYS;User Id=postgres;Password=1234");
       
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            msk_IlacAdi.Focus();

            if (msk_IlacAdi.Text != "" && cmb_IlacTipi.Text != "" && cmb_IlacAdet.Text != "")
            {
                if (sayac == 4)
                {
                    button1.Hide();
                    lbl_warn.Visible = true;
                }

                int receteadeti;
                receteadeti = Convert.ToInt32(cmb_IlacAdet.Text);

                if (receteadeti <= 4)
                {
                    listView1.Items.Add(msk_IlacAdi.Text);
                    listView1.Items.Add(cmb_IlacTipi.Text);
                    listView1.Items.Add(cmb_IlacAdet.Text);


                    if (sayac == 0) // 1.ilaç türü
                    {
                        conn.Open();
                        NpgsqlCommand ilac_ekle = new NpgsqlCommand();
                        ilac_ekle.Connection = conn;
                        ilac_ekle.Parameters.AddWithValue("@receteno", Convert.ToInt32(msk_Receteno.Text));
                        ilac_ekle.Parameters.AddWithValue("@ad", msk_IlacAdi.Text);
                        ilac_ekle.Parameters.AddWithValue("@tip", cmb_IlacTipi.Text);
                        ilac_ekle.Parameters.AddWithValue("@adet", Convert.ToInt32(cmb_IlacAdet.Text));
                        ilac_ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(msk_ReceteMuayaneTarihi.Text));

                        ilac_ekle.CommandText = "insert into recetebilgi (recete_no,ilac_adi_1, ilac_tipi_1, ilac_adeti_1, tarih) values (@receteno, @ad, @tip,@adet, @tarih)";
                        ilac_ekle.CommandType = CommandType.Text;

                        NpgsqlDataReader dr = ilac_ekle.ExecuteReader();


                        conn.Close();
                        ilac_ekle.Dispose();




                        conn.Open();
                        NpgsqlCommand receteilac_ekle = new NpgsqlCommand();
                        receteilac_ekle.Connection = conn;
                        receteilac_ekle.Parameters.AddWithValue("@receteno", Convert.ToInt32(msk_Receteno.Text));
                        receteilac_ekle.Parameters.AddWithValue("@ad", msk_IlacAdi.Text);
                        receteilac_ekle.Parameters.AddWithValue("@tip", cmb_IlacTipi.Text);
                        receteilac_ekle.Parameters.AddWithValue("@adet", Convert.ToInt32(cmb_IlacAdet.Text));
                        receteilac_ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(msk_ReceteMuayaneTarihi.Text));

                        receteilac_ekle.CommandText = "insert into receteilacbilgi (recete_no,ilac_adi, ilac_tipi, ilac_adeti, tarih) values (@receteno, @ad, @tip,@adet, @tarih)";
                        receteilac_ekle.CommandType = CommandType.Text;

                        NpgsqlDataReader dr1 = receteilac_ekle.ExecuteReader();


                        conn.Close();
                        receteilac_ekle.Dispose();
                    }

                    if (sayac == 1) // 2. ilaç türü
                    {
                        conn.Open();
                        NpgsqlCommand ilac_ekle = new NpgsqlCommand();
                        ilac_ekle.Connection = conn;
                        ilac_ekle.Parameters.AddWithValue("@receteno", Convert.ToInt32(msk_Receteno.Text));
                        ilac_ekle.Parameters.AddWithValue("@ad", msk_IlacAdi.Text);
                        ilac_ekle.Parameters.AddWithValue("@tip", cmb_IlacTipi.Text);
                        ilac_ekle.Parameters.AddWithValue("@adet", Convert.ToInt32(cmb_IlacAdet.Text));


                        ilac_ekle.CommandText = ("update recetebilgi set ilac_adi_2=@ad , ilac_tipi_2=@tip , ilac_adeti_2=@adet where recete_no=@receteno ");

                        ilac_ekle.CommandType = CommandType.Text;

                        NpgsqlDataReader dr = ilac_ekle.ExecuteReader();


                        conn.Close();
                        ilac_ekle.Dispose();





                        conn.Open();
                        NpgsqlCommand receteilac_ekle = new NpgsqlCommand();
                        receteilac_ekle.Connection = conn;
                        receteilac_ekle.Parameters.AddWithValue("@receteno", Convert.ToInt32(msk_Receteno.Text));
                        receteilac_ekle.Parameters.AddWithValue("@ad", msk_IlacAdi.Text);
                        receteilac_ekle.Parameters.AddWithValue("@tip", cmb_IlacTipi.Text);
                        receteilac_ekle.Parameters.AddWithValue("@adet", Convert.ToInt32(cmb_IlacAdet.Text));
                        receteilac_ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(msk_ReceteMuayaneTarihi.Text));

                        receteilac_ekle.CommandText = "insert into receteilacbilgi (recete_no,ilac_adi, ilac_tipi, ilac_adeti, tarih) values (@receteno, @ad, @tip,@adet, @tarih)";
                        receteilac_ekle.CommandType = CommandType.Text;

                        NpgsqlDataReader dr1 = receteilac_ekle.ExecuteReader();


                        conn.Close();
                        receteilac_ekle.Dispose();
                    }

                    if (sayac == 2) // 3. ilaç türü
                    {
                        conn.Open();
                        NpgsqlCommand ilac_ekle = new NpgsqlCommand();
                        ilac_ekle.Connection = conn;
                        ilac_ekle.Parameters.AddWithValue("@receteno", Convert.ToInt32(msk_Receteno.Text));
                        ilac_ekle.Parameters.AddWithValue("@ad", msk_IlacAdi.Text);
                        ilac_ekle.Parameters.AddWithValue("@tip", cmb_IlacTipi.Text);
                        ilac_ekle.Parameters.AddWithValue("@adet", Convert.ToInt32(cmb_IlacAdet.Text));


                        ilac_ekle.CommandText = ("update recetebilgi set ilac_adi_3=@ad , ilac_tipi_3=@tip , ilac_adeti_3=@adet where recete_no=@receteno ");

                        ilac_ekle.CommandType = CommandType.Text;

                        NpgsqlDataReader dr = ilac_ekle.ExecuteReader();


                        conn.Close();
                        ilac_ekle.Dispose();







                        conn.Open();
                        NpgsqlCommand receteilac_ekle = new NpgsqlCommand();
                        receteilac_ekle.Connection = conn;
                        receteilac_ekle.Parameters.AddWithValue("@receteno", Convert.ToInt32(msk_Receteno.Text));
                        receteilac_ekle.Parameters.AddWithValue("@ad", msk_IlacAdi.Text);
                        receteilac_ekle.Parameters.AddWithValue("@tip", cmb_IlacTipi.Text);
                        receteilac_ekle.Parameters.AddWithValue("@adet", Convert.ToInt32(cmb_IlacAdet.Text));
                        receteilac_ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(msk_ReceteMuayaneTarihi.Text));

                        receteilac_ekle.CommandText = "insert into receteilacbilgi (recete_no,ilac_adi, ilac_tipi, ilac_adeti, tarih) values (@receteno, @ad, @tip,@adet, @tarih)";
                        receteilac_ekle.CommandType = CommandType.Text;

                        NpgsqlDataReader dr1 = receteilac_ekle.ExecuteReader();


                        conn.Close();
                        receteilac_ekle.Dispose();
                    }

                    if (sayac == 3) // 4. ilaç türü
                    {
                        conn.Open();
                        NpgsqlCommand ilac_ekle = new NpgsqlCommand();
                        ilac_ekle.Connection = conn;
                        ilac_ekle.Parameters.AddWithValue("@receteno", Convert.ToInt32(msk_Receteno.Text));
                        ilac_ekle.Parameters.AddWithValue("@ad", msk_IlacAdi.Text);
                        ilac_ekle.Parameters.AddWithValue("@tip", cmb_IlacTipi.Text);
                        ilac_ekle.Parameters.AddWithValue("@adet", Convert.ToInt32(cmb_IlacAdet.Text));


                        ilac_ekle.CommandText = ("update recetebilgi set ilac_adi_4=@ad , ilac_tipi_4=@tip , ilac_adeti_4=@adet where recete_no=@receteno ");

                        ilac_ekle.CommandType = CommandType.Text;

                        NpgsqlDataReader dr = ilac_ekle.ExecuteReader();


                        conn.Close();
                        ilac_ekle.Dispose();






                        conn.Open();
                        NpgsqlCommand receteilac_ekle = new NpgsqlCommand();
                        receteilac_ekle.Connection = conn;
                        receteilac_ekle.Parameters.AddWithValue("@receteno", Convert.ToInt32(msk_Receteno.Text));
                        receteilac_ekle.Parameters.AddWithValue("@ad", msk_IlacAdi.Text);
                        receteilac_ekle.Parameters.AddWithValue("@tip", cmb_IlacTipi.Text);
                        receteilac_ekle.Parameters.AddWithValue("@adet", Convert.ToInt32(cmb_IlacAdet.Text));
                        receteilac_ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(msk_ReceteMuayaneTarihi.Text));

                        receteilac_ekle.CommandText = "insert into receteilacbilgi (recete_no,ilac_adi, ilac_tipi, ilac_adeti, tarih) values (@receteno, @ad, @tip,@adet, @tarih)";
                        receteilac_ekle.CommandType = CommandType.Text;

                        NpgsqlDataReader dr1 = receteilac_ekle.ExecuteReader();


                        conn.Close();
                        receteilac_ekle.Dispose();
                    }


                    if (sayac == 4) // 5. ilaç türü
                    {
                        conn.Open();
                        NpgsqlCommand ilac_ekle = new NpgsqlCommand();
                        ilac_ekle.Connection = conn;
                        ilac_ekle.Parameters.AddWithValue("@receteno", Convert.ToInt32(msk_Receteno.Text));
                        ilac_ekle.Parameters.AddWithValue("@ad", msk_IlacAdi.Text);
                        ilac_ekle.Parameters.AddWithValue("@tip", cmb_IlacTipi.Text);
                        ilac_ekle.Parameters.AddWithValue("@adet", Convert.ToInt32(cmb_IlacAdet.Text));


                        ilac_ekle.CommandText = ("update recetebilgi set ilac_adi_5=@ad , ilac_tipi_5=@tip , ilac_adeti_5=@adet where recete_no=@receteno ");

                        ilac_ekle.CommandType = CommandType.Text;

                        NpgsqlDataReader dr = ilac_ekle.ExecuteReader();


                        conn.Close();
                        ilac_ekle.Dispose();






                        conn.Open();
                        NpgsqlCommand receteilac_ekle = new NpgsqlCommand();
                        receteilac_ekle.Connection = conn;
                        receteilac_ekle.Parameters.AddWithValue("@receteno", Convert.ToInt32(msk_Receteno.Text));
                        receteilac_ekle.Parameters.AddWithValue("@ad", msk_IlacAdi.Text);
                        receteilac_ekle.Parameters.AddWithValue("@tip", cmb_IlacTipi.Text);
                        receteilac_ekle.Parameters.AddWithValue("@adet", Convert.ToInt32(cmb_IlacAdet.Text));
                        receteilac_ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(msk_ReceteMuayaneTarihi.Text));

                        receteilac_ekle.CommandText = "insert into receteilacbilgi (recete_no,ilac_adi, ilac_tipi, ilac_adeti, tarih) values (@receteno, @ad, @tip,@adet, @tarih)";
                        receteilac_ekle.CommandType = CommandType.Text;

                        NpgsqlDataReader dr1 = receteilac_ekle.ExecuteReader();


                        conn.Close();
                        receteilac_ekle.Dispose();
                    }




                    listView1.Visible = true;

                    sayac++;
                }
                else MessageBox.Show("4 ten az ilaç girmeniz gerekli");





                conn.Open();
                NpgsqlCommand muayene_guncelle = new NpgsqlCommand();
                muayene_guncelle.Connection = conn;
                muayene_guncelle.Parameters.AddWithValue("@tcno", Convert.ToInt32(msk_ReceteTc.Text));
                muayene_guncelle.Parameters.AddWithValue("@receteno", Convert.ToInt32(msk_Receteno.Text));
                muayene_guncelle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(msk_ReceteMuayaneTarihi.Text));
                muayene_guncelle.CommandText = "update muayene set recete_no=@receteno where tcno=@tcno and tarih=@tarih";
                muayene_guncelle.CommandType = CommandType.Text;
                NpgsqlDataReader dr3 = muayene_guncelle.ExecuteReader();
                conn.Close();
                muayene_guncelle.Dispose();


                MessageBox.Show("recete kaydı başarılı");

            }
            else MessageBox.Show("Boş Bırakma Lütfen");
        }

        private void Frm_ReceteOlustur_Load(object sender, EventArgs e)
        {

            msk_ReceteMuayaneTarihi.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
            Random r = new Random();

            string temp = System.DateTime.Now.ToString("HH");

            msk_Receteno.Text += temp;
            msk_Receteno.Text += Convert.ToString(r.Next(100, 200));
         

            msk_IlacAdi.Focus();
        }
    }
}
