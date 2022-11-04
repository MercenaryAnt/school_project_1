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
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }
        Veritabani vt=new Veritabani("db_beyazEsya", ".");
        public static string gonderilenVeri;
        public static string yetki;

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            if (Settings.Default.beniHatirla == true)
            {
                cbx_hatirla.Checked = true;
                tx_tcNo.Text = Settings.Default.tcNo;
                tx_sifre.Text = Settings.Default.sifre;
            }
            else
            {
                Settings.Default.Reset();
            }
        }

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            Kaydol kfrm = new Kaydol();
            kfrm.Show();
            this.Hide();
        }

        private void KullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (tx_tcNo.Text == "" || tx_sifre.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_tcNo.Text.Trim().Length != 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 karakter uzunluğunda olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sifreMd5 = DLLIslemleri.DigerIslemler.CreateMD5(tx_sifre.Text);
            DataTable dtSonuc = vt.Select(@"select kullanici_id,ad,soyad,kullaniciTur_id from tbl_kullanici 
                    where tcNo='" + tx_tcNo.Text + "' and sifre='" + sifreMd5 + "'");
            if (dtSonuc.Rows.Count == 0)
            {
                MessageBox.Show("Tc No veya Şifre Hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_hatirla.Checked == true)
            {
                Settings.Default.beniHatirla = true;
                Settings.Default.tcNo = tx_tcNo.Text;
                Settings.Default.sifre = tx_sifre.Text;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.Reset();
            }

            DataTable dtyetki = vt.Select(@"select kullaniciTur_id from tbl_kullanici where tcNo='" + tx_tcNo.Text + "'");
            yetki = dtyetki.Rows[0]["kullaniciTur_id"].ToString();

            this.Hide();
            
            gonderilenVeri = tx_tcNo.Text;
            AnaForm afrm = new AnaForm();
           
            afrm.kullanici_id = Convert.ToInt32(dtSonuc.Rows[0]["kullanici_id"]);
            afrm.Text = "Beyaz Eşya - [" + dtSonuc.Rows[0]["ad"].ToString() + " " + dtSonuc.Rows[0]["soyad"].ToString() + "]";
            afrm.Show();
            afrm.Show();
        }

        private void cbx_sifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_sifreGoster.Checked == true)
                tx_sifre.PasswordChar = '\0';
            else
                tx_sifre.PasswordChar = '*';
        }

        private void tx_tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }
    }
}
