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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        public void Temizle()
        {
            tx_ad.Text = "";
            tx_soyad.Text = "";
            tx_tcNo.Text = "";
            tx_email.Text = "";
            tx_telefon.Text = "";
            tx_adres.Text = "";
           
             if (dgv_musteriler.SelectedRows.Count > 0)
                dgv_musteriler.SelectedRows[0].Selected = false;

        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Sayfayı kapatmak istediğinize emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {
                this.Close();
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
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
            if (tx_tcNo.Text.Trim().Length != 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_email.Text == "")
            {
                MessageBox.Show("E-mail boş bırakılmamalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_telefon.Text.Trim().Length != 11)
            {
                MessageBox.Show("Telefon numarası 11 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            if (tx_adres.Text == "")
            {
                MessageBox.Show("Adres boş bırakılmamalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow item in dgv_musteriler.Rows)
            {
                if (item.Cells[4].Value.ToString() == tx_telefon.Text)
                {
                    MessageBox.Show("Bu telefon numarasına ait personel daha önce eklenmiş.Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.Cells[3].Value.ToString() == tx_tcNo.Text)
                {
                    MessageBox.Show("Bu TC kimlik numarasına ait personel daha önce eklenmiş. Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.Cells[6].Value.ToString() == tx_email.Text)
                {
                    MessageBox.Show("Bu e-mail adresi başka bir personele ait. Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            object kayitSayisi = vt.Insert(@"insert into tbl_musteri(ad,soyad,tcNo,telefon,adres,eposta)
            values('"+tx_ad.Text+"','"+tx_soyad.Text+"','"+tx_tcNo.Text+"','"+tx_telefon.Text+"','"+tx_adres.Text+"','"+tx_email.Text+"')");
            Musteri_Load(null, null);
            MessageBox.Show("Müşteri, başarılı bir şekilde kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            dgv_musteriler.DataSource = vt.Select("select musteri_id,ad AS 'Adı',soyad AS 'Soyadı',tcNo AS 'TC Kimlik Numarası',telefon AS 'Telefon',adres AS 'Adres',eposta AS 'E-mail' from tbl_musteri");
            dgv_musteriler.Columns["musteri_id"].Visible = false;
            Temizle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_musteriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
            if (tx_tcNo.Text.Trim().Length != 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_email.Text == "")
            {
                MessageBox.Show("E-mail boş bırakılmamalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_telefon.Text.Trim().Length != 11)
            {
                MessageBox.Show("Telefon numarası 11 karakter olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tx_adres.Text == "")
            {
                MessageBox.Show("Adres boş bırakılmamalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow item in dgv_musteriler.Rows)
            {
                if (item.Cells[4].Value.ToString() == tx_telefon.Text)
                {
                    MessageBox.Show("Bu telefon numarasına ait personel daha önce eklenmiş.Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.Cells[3].Value.ToString() == tx_tcNo.Text)
                {
                    MessageBox.Show("Bu TC kimlik numarasına ait personel daha önce eklenmiş. Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.Cells[6].Value.ToString() == tx_email.Text)
                {
                    MessageBox.Show("Bu e-mail adresi başka bir personele ait. Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            int kayitSayisi = vt.UpdateDelete(@"update tbl_musteri
                                                set ad='"+tx_ad.Text+
                                                "',soyad='"+tx_soyad.Text+
                                                "', tcNo='"+tx_tcNo.Text+
                                                "', telefon='"+tx_telefon.Text+
                                                "',adres='"+tx_adres.Text+
                                                "',eposta='"+tx_email.Text+
                                                "'where musteri_id="+dgv_musteriler.SelectedRows[0].Cells["musteri_id"].Value);

            if (kayitSayisi > 0)
            {
                Musteri_Load(null,null);
                MessageBox.Show("Kayıt güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Temizle();
        }
        string musteriKontrol;
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_musteriler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_ad.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz müşteriye 2 kez tıklayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Müşteri kaydı silinecektir. Devam etmek istiyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }            

            DataTable kontrol = vt.Select("select COUNT(satis_id) cou from tbl_satis where musteri_id='" + musteriid + "'");
            musteriKontrol = kontrol.Rows[0]["cou"].ToString();

            if (musteriKontrol == "0")
            {
                int kayitSay = vt.UpdateDelete("delete from tbl_musteri where musteri_id=" + dgv_musteriler.SelectedRows[0].Cells["musteri_id"].Value);
                if (kayitSay > 0)
                {
                    Musteri_Load(null, null);
                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu Müşteri " + musteriKontrol + " satışta bulunmakta", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            Temizle();
        }

        private void tx_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != ' ' && e.KeyChar != '\b')
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

        private void tx_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }
        string musteriid;
        private void dgv_musteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_ad.Text = dgv_musteriler.SelectedRows[0].Cells[1].Value.ToString();
            tx_soyad.Text = dgv_musteriler.SelectedRows[0].Cells[2].Value.ToString();
            tx_tcNo.Text = dgv_musteriler.SelectedRows[0].Cells[3].Value.ToString();
            tx_telefon.Text = dgv_musteriler.SelectedRows[0].Cells[4].Value.ToString();
            tx_adres.Text = dgv_musteriler.SelectedRows[0].Cells[5].Value.ToString();
            tx_email.Text = dgv_musteriler.SelectedRows[0].Cells[6].Value.ToString();

            DataTable musterik = vt.Select("select musteri_id from tbl_musteri where tcNo='" + tx_tcNo.Text + "'");
            musteriid = musterik.Rows[0]["musteri_id"].ToString();
        }

        private void bilgileriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_musteriler_CellDoubleClick(null, null);
        }
    }
}
