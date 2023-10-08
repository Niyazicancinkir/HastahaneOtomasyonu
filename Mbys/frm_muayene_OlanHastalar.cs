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
    public partial class frm_muayene_OlanHastalar : Form
    {
        public frm_muayene_OlanHastalar()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=MBYS;User Id=postgres;Password=1234");

        public int verileri_goster(string txt)
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

                dgv_muayenelistele.DataSource = dt;

            }
            komut.Dispose();
            conn.Close();
            return 0;
        }

    

        private void frm_muayene_OlanHastalar_Load(object sender, EventArgs e)
        {
     verileri_goster("select * from muayene order by tarih ");
        }
    }
}
