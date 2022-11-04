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
    public partial class KullaniciDuzenle : Form
    {
        public KullaniciDuzenle()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        public static string guncellenenTC;

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AnaForm afrm = new AnaForm();
            this.Hide();
            afrm.Show();
        }

        private void btn_sifreGuncelle_Click(object sender, EventArgs e)
        {
            SifreGuncelle sfrm = new SifreGuncelle();
            this.Hide();
            sfrm.Show();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (tx_tcNo.Text.Trim().Length != 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_tcNo.Text.Length == 11)
            {
                DataTable dt = vt.Select("select * from tbl_kullanici where tcNo ='" + tx_tcNo.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bu TC kimlik numarasına ait başka bir hesap var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            if (tx_ad.Text.Trim().Length < 2)
            {
                MessageBox.Show("Ad en az 2 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_soyad.Text.Trim().Length < 2)
            {
                MessageBox.Show("Soyad en az 2 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_eposta.Text == "")
            {
                MessageBox.Show("E-posta boş bırakılamaz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (tx_eposta.Text.Length >= 3)
            {
                DataTable dt = vt.Select("select * from tbl_kullanici where eposta ='" + tx_eposta.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bu e-posta adresine ait bir hesap var.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

            }

            vt.UpdateDelete(@"update tbl_kullanici 
                                set tcNo='" + tx_tcNo.Text +
                                "' , ad='" + tx_ad.Text +
                                "', soyad='" + tx_soyad.Text +
                                "',eposta='" + tx_eposta.Text +
                                "'where tcNo='" + KullaniciGirisi.gonderilenVeri + "' or tcNo='" + KullaniciDuzenle.guncellenenTC + "'");

            guncellenenTC = tx_tcNo.Text;

            MessageBox.Show("Güncelleme İşlemi Başarılı.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
            this.Hide();
        }

        private void KullaniciDuzenle_Load(object sender, EventArgs e)
        {
            if (KullaniciGirisi.yetki == "1")
            {
                btn_admin.Visible = true;
            }
            else
            {
                btn_admin.Visible = false;
            }
        }

        private void tx_tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
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
    }
}
