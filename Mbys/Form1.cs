using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Mbys
{
    public partial class frm_mainPage : Form
    {
        public frm_mainPage()
        {
            InitializeComponent();
        }

        private void btn_HastaKaydet_Click(object sender, EventArgs e)
        {

           Frm_HastaKayit frm_HastaKayit = new Frm_HastaKayit();
            frm_HastaKayit.ShowDialog();
        }

        private void btn_MuayeneKaydet_Click(object sender, EventArgs e)
        {
            Frm_MuayeneKayit frm_MuayeneKayit = new Frm_MuayeneKayit();
            frm_MuayeneKayit.ShowDialog();
        }

        private void btn_IlacKaydet_Click(object sender, EventArgs e)
        {
            Frm_IlacKayit frm_IlacKayit = new Frm_IlacKayit();
             frm_IlacKayit.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_ReceteOlustur frm_ReceteOlustur = new();
            frm_ReceteOlustur.ShowDialog();
        }

        private void btn_bilgi_goruntule_Click(object sender, EventArgs e)
        {
            Bilgi_Görüntüleme bilgi_Görüntüleme = new();
            bilgi_Görüntüleme.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_yazýlanilacýn_verildiði_hastalar frm_Yazýlanilacýn_Verildiði_Hastalar = new();
            frm_Yazýlanilacýn_Verildiði_Hastalar.ShowDialog();

        }

        private void btn_muayene_Click(object sender, EventArgs e)
        {
            frm_muayene_OlanHastalar frm_Muayene = new();
            frm_Muayene.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_HastaKayýtGöster frm_HastaKayýtGöster = new();
            frm_HastaKayýtGöster.ShowDialog();
        }

        private void btn_hastayaverilenilac_Click(object sender, EventArgs e)
        {
            frm_HastayaGöreÝlac frm_HastayaGöreÝlac = new();
            frm_HastayaGöreÝlac.ShowDialog();

        }

        private void checkisdoctor(object sender, EventArgs e)

        {

            pgDoctor.Visible = true;
            pgEczacý.Visible = false;
            pgSekreter.Visible = false; 
            pb_hastaoto.Visible=false;
            
            lblyazý.Visible = false;
            lblsecim.Visible = true;
            lblsecim.Text = "Doktor Seçtiniz";
            
           gb_eczacý.Visible = false;
            gb_sekreter.Visible = false;
            btn_bilgi_goruntule.Visible = true;
            btn_muayene.Visible = true;
            btn_MuayeneKaydet.Visible = true;
            btn_bilgi_goruntule.Visible = true;
            btn_hastayaverilenilac.Visible = true;
            gb_Doctor.Visible = true;
            btn_hastabilgigoster.Visible = true;
            btn_ilacverilenhasta.Visible = true;

 
        }

        private void checkissekreter(object sender, EventArgs e)
        {
            pgDoctor.Visible = false;
            pgEczacý.Visible = false;
            pgSekreter.Visible = true;
            pb_hastaoto.Visible = false;
            lblyazý.Visible = false;
            lblsecim.Visible = true;
            lblsecim.Text = "Sekreter Seçtiniz";
            gb_sekreter.Visible = true;
            gb_eczacý.Visible = false;
            btn_bilgi_goruntule.Visible = false;
            btn_muayene.Visible = false;
            btn_MuayeneKaydet.Visible = false;
            btn_bilgi_goruntule.Visible = false;
            btn_hastayaverilenilac.Visible = false;
            gb_Doctor.Visible = false;
            btn_hastabilgigoster.Visible = false;
            btn_ilacverilenhasta.Visible = false;
            btn_HastaKaydet.Visible = true;


        }

        private void checkiseczacý(object sender, EventArgs e)
        {
            pgDoctor.Visible = false;
            pgEczacý.Visible = true;
            pgSekreter.Visible = false;
            pb_hastaoto.Visible = false;
            lblyazý.Visible = false;
            lblsecim.Visible = true;
            lblsecim.Text = "Eczacý Seçtiniz";
            gb_eczacý.Visible = true;
            gb_sekreter.Visible = false;
            btn_bilgi_goruntule.Visible = false;
            btn_muayene.Visible = false;
            btn_MuayeneKaydet.Visible = false;
            btn_bilgi_goruntule.Visible = false;
            btn_hastayaverilenilac.Visible = false;
            gb_Doctor.Visible = false;
            btn_hastabilgigoster.Visible = false;
            btn_ilacverilenhasta.Visible = false;
            btn_HastaKaydet.Visible = false;
            btn_IlacKaydet.Visible = true;


        }

        private void checkisseciniz(object sender, EventArgs e)
        {
            pgDoctor.Visible = false;
            pgEczacý.Visible = false;
            pgSekreter.Visible = false;
            pb_hastaoto.Visible = true;
            lblsecim.Text = "Lütfen Seçim Yapýnýz.";
            lblyazý.Visible = true;
            gb_eczacý.Visible = false;
            gb_sekreter.Visible=false;
            btn_bilgi_goruntule.Visible = false;
            btn_muayene.Visible = false;
            btn_MuayeneKaydet.Visible = false;
            btn_bilgi_goruntule.Visible = false;
            btn_hastayaverilenilac.Visible = false;
            gb_Doctor.Visible = false;
            btn_hastabilgigoster.Visible = false;
            btn_ilacverilenhasta.Visible = false;
            btn_HastaKaydet.Visible = false;
            btn_IlacKaydet.Visible = false;

        }
    }
}