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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();


        private void Admin_Load(object sender, EventArgs e)
        {
            KullaniciGridDoldur();

            cbx_yetki.DisplayMember = "kullaniciTur";
            cbx_yetki.ValueMember = "kullaniciTur_id";
            cbx_yetki.DataSource = vt.Select(@"select kullaniciTur_id, kullaniciTur from tbl_kullaniciTur");

        }

        private void KullaniciGridDoldur()
        {
            dgv_admin.DataSource = vt.Select(@"select kullanici_id, ad Ad, soyad Soyad, tcNo TcKimlik, sifre, eposta Eposta, t.kullaniciTur_id, t.kullaniciTur Yetki
                                                    from tbl_kullanici k 
                                                    join tbl_kullaniciTur t on k.kullaniciTur_id=t.kullaniciTur_id");

            dgv_admin.Columns["kullanici_id"].Visible = false;
            dgv_admin.Columns["kullaniciTur_id"].Visible = false;
            dgv_admin.Columns["sifre"].Visible = false;
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            KullaniciDuzenle kduzen = new KullaniciDuzenle();
            this.Hide();
            kduzen.Show();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_admin.SelectedRows.Count==0)
            {
                MessageBox.Show("Silinecek satırı seçiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            int kayitSay = vt.UpdateDelete("delete from tbl_kullanici where kullanici_id="+dgv_admin.SelectedRows[0].Cells["kullanici_id"].Value);
            if (kayitSay>0)
            {
                KullaniciGridDoldur();
                MessageBox.Show("Kayıt başarıyla silindi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kayit silinemedi.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void dgv_admin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_admin.SelectedRows.Count == 0)
            {
                return;
            }
            tx_ad.Text = dgv_admin.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_soyad.Text = dgv_admin.SelectedRows[0].Cells["soyad"].Value.ToString();
            tx_tcNo.Text = dgv_admin.SelectedRows[0].Cells[3].Value.ToString();
            tx_eposta.Text = dgv_admin.SelectedRows[0].Cells["eposta"].Value.ToString();
            cbx_yetki.SelectedValue = dgv_admin.SelectedRows[0].Cells["kullaniciTur_id"].Value;

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_ad.Text = "";
            tx_soyad.Text = "";
            tx_tcNo.Text = "";
            tx_sifre.Text = "";
            tx_eposta.Text = "";
            cbx_yetki.SelectedIndex = -1;

            if (dgv_admin.SelectedRows.Count>0)
            {
                dgv_admin.SelectedRows[0].Selected = false;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_admin.SelectedRows.Count==0)
            {
                MessageBox.Show("Güncellenecek satırı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sifreMd5 = DLLIslemleri.DigerIslemler.CreateMD5(tx_sifre.Text);
            int kayitSay = vt.UpdateDelete(@"update tbl_kullanici
                                                set ad='"+tx_ad.Text+
                                                "',soyad='"+tx_soyad.Text+
                                                "',tcNo='"+tx_tcNo.Text+
                                                "',sifre='" + sifreMd5 +
                                                "',eposta='" +tx_eposta.Text+
                                                "',kullaniciTur_id="+cbx_yetki.SelectedValue+
                                                "where kullanici_id="+dgv_admin.SelectedRows[0].Cells["kullanici_id"].Value);
            if (kayitSay>0)
            {
                KullaniciGridDoldur();
                MessageBox.Show(kayitSay+" Kayıt başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
