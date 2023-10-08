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
    public partial class Frm_IlacKayit : Form
    {
        public Frm_IlacKayit()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=MBYS;User Id=postgres;Password=1234");

        private void btn_IlacEkle_Click(object sender, EventArgs e)
        {
            if (msk_ilac_tipi.Text != "" && msk_ilac_barkodNo.Text != "" && msk_IlacAdi.Text != "")
            {
                conn.Open();
                NpgsqlCommand ilac_ekle = new NpgsqlCommand();
                ilac_ekle.Connection = conn;
                ilac_ekle.Parameters.AddWithValue("@barkodno", Convert.ToInt32(msk_ilac_barkodNo.Text));
                ilac_ekle.Parameters.AddWithValue("@ad", msk_IlacAdi.Text);
                ilac_ekle.Parameters.AddWithValue("@tip", msk_ilac_tipi.Text);
                ilac_ekle.CommandText = "insert into ilacbilgi (barkod_no, adi, tipi) values (@barkodno, @ad, @tip)";
                ilac_ekle.CommandType = CommandType.Text;

                NpgsqlDataReader dr = ilac_ekle.ExecuteReader();


                conn.Close();
                ilac_ekle.Dispose();



                MessageBox.Show("İlaç kaydı başarılı");
            }
            else MessageBox.Show("Boş bırakmayın Lütfen");
        }
    }
}
