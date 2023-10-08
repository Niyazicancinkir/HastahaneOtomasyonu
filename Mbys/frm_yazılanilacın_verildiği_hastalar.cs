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
    public partial class frm_yazılanilacın_verildiği_hastalar : Form
    {
        public frm_yazılanilacın_verildiği_hastalar()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=MBYS;User Id=postgres;Password=1234");
        public int verileri_goster(string txt, DataGridView dataGridView)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

                dataGridView.DataSource = dt;

            }
            komut.Dispose();
            conn.Close();
            return 0;
        }
        private void btnIlacAra_Click(object sender, EventArgs e)
        {
            if (txt_AranacakIlac.Text != "")
            {
                label1.Text = txt_AranacakIlac.Text;
                label1.Text += " Adlı İlacın Verildiği Hastaların Bilgisi";
                verileri_goster("\r\nselect tcno,ad,soyad,muayene.recete_no,muayene.tarih \r\nfrom muayene\r\ninner join recetebilgi on recetebilgi.recete_no=muayene.recete_no\r\nwhere recetebilgi.ilac_adi_1='" + txt_AranacakIlac.Text + "'  or recetebilgi.ilac_adi_2= '" + txt_AranacakIlac.Text + "' or recetebilgi.ilac_adi_3= '" + txt_AranacakIlac.Text + "' or recetebilgi.ilac_adi_3= '" + txt_AranacakIlac.Text + "'  or recetebilgi.ilac_adi_2= '" + txt_AranacakIlac.Text + "' or recetebilgi.ilac_adi_3= '" + txt_AranacakIlac.Text + "' order by muayene.tarih", dgv_ilaclistele);
            }else  MessageBox.Show("Boş Bırkma Lütfen");
        }
    }
}