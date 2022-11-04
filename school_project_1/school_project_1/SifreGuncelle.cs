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
    public partial class SifreGuncelle : Form
    {
        public SifreGuncelle()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void btn_sifreKaydet_Click(object sender, EventArgs e)
        {
            string sifreMd5 = DLLIslemleri.DigerIslemler.CreateMD5(tx_sifre.Text);
            vt.UpdateDelete(@"update tbl_kullanici 
                                set sifre='" + sifreMd5 +
                               "'where tcNo='" + KullaniciGirisi.gonderilenVeri + "' or tcNo='" + KullaniciDuzenle.guncellenenTC + "'");
            MessageBox.Show("Şifre Değiştirme İşlemi Başarılı.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            KullaniciDuzenle kfrm = new KullaniciDuzenle();
            this.Hide();
            kfrm.Show();
        }

        private void tx_sifre_TextChanged(object sender, EventArgs e)
        {
            if (tx_sifre.Text.Length < 4)
                lbl_sifreMesaj.Text = "Şifre en az 4 karakter olabilir !";
            else if (tx_sifre.Text != tx_sifretkr.Text)
                lbl_sifreMesaj.Text = "Şifreler uyuşmuyor !";
            else
                lbl_sifreMesaj.Text = "Onaylandı.";
        }

        private void SifreGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
