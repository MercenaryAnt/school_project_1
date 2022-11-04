using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLIslemleri;

namespace school_project_1
{
    public partial class Kaydol : Form
    {
        public Kaydol()
        {
            InitializeComponent();
        }
        
        Veritabani vt=new Veritabani("db_beyazEsya", ".");
        private void btn_geri_Click(object sender, EventArgs e)
        {
            KullaniciGirisi grs = new KullaniciGirisi();
            this.Hide();
            grs.Show();
        }

        private void Kaydol_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            
            if (tx_tcNo.Text == "" || tx_sifre.Text == "" || tx_sifretkr.Text=="" || tx_ad.Text=="" || tx_soyad.Text=="" || tx_eposta.Text=="")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (tx_tcNo.Text.Trim().Length != 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 karakter uzunluğunda olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_tcNo.Text.Length == 11)
            {
                DataTable dt = vt.Select("select * from tbl_kullanici where tcNo ='" + tx_tcNo.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Aynı TC kimlik numarası  ile kayıt yapılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            if (tx_ad.Text.Trim().Length < 2)
            {
                MessageBox.Show("Ad en az 2 karakter olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_soyad.Text.Trim().Length < 2)
            {
                MessageBox.Show("Soyad en az 2 karakter olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_eposta.Text == "")
            {
                MessageBox.Show("E-posta boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_eposta.Text.Length >= 3)
            {
                DataTable dt = vt.Select("select * from tbl_kullanici where eposta ='" + tx_eposta.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Aynı eposta ile kayıt yapılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            string sifreMd5 = DLLIslemleri.DigerIslemler.CreateMD5(tx_sifre.Text);
            vt.Insert(@"insert into tbl_kullanici(ad,soyad,tcNo,sifre,eposta,kullaniciTur_id)
                        values('"+tx_ad.Text+"','"+tx_soyad.Text+"','"+tx_tcNo.Text+"','"+sifreMd5+"','"+tx_eposta.Text+"',2)");

            MessageBox.Show("Kayıt işlemi başarılı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void tx_sifre_TextChanged(object sender, EventArgs e)
        {
            if (tx_sifre.Text.Length < 4)
                lbl_sifreMesaj.Text = "Şifre en az 4 karakter olabilir!";
            else if (tx_sifre.Text != tx_sifretkr.Text)
                lbl_sifreMesaj.Text = "Şifreler uyuşmuyor!";
            else
                lbl_sifreMesaj.Text = "Onaylandı.";
        }

        private void tx_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tx_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tx_tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void Kaydol_Load(object sender, EventArgs e)
        {

        }
    }
}
