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
    public partial class UrunKaydet : Form
    {
        public UrunKaydet()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void btn_bilgi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tanımlamış olduğunuz ürünün stok adedidir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }   

        private void btn_urunSinifiEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem yaptıktan sonra lütfen formu yenileyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunSinifi snf = new UrunSinifi();
            snf.Show();
        }

        private void btn_birimEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem yaptıktan sonra lütfen formu yenileyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Birim brm = new Birim();
            brm.Show();
        }

        private void UrunKaydet_Load(object sender, EventArgs e)
        {
            UrunDoldur();

            cbx_urunTur.DisplayMember = "urunTur";
            cbx_urunTur.ValueMember = "urunTur_id";
            cbx_urunTur.DataSource = vt.Select("select urunTur_id, urunTur from tbl_urunTur");

            cbx_urunSinifi.DisplayMember = "urunSinifi";
            cbx_urunSinifi.ValueMember = "urunSinif_id";
            cbx_urunSinifi.DataSource = vt.Select("select urunSinif_id, urunSinifi from tbl_urunSinifi");

            cbx_birim.DisplayMember = "birim";
            cbx_birim.ValueMember = "birim_id";
            cbx_birim.DataSource = vt.Select("select birim_id, birim from tbl_birim");


        }
        public void UrunDoldur()
        {
            dgv_urunler.DataSource = vt.Select(@"select urun_id,urunKodu AS 'Ürün Kodu',barkod AS 'Barkod Numarası',miktar AS 'Miktar',fiyat AS 'Fiyat',ut.urunTur_id,ut.urunTur AS 'Ürün Türü',b.birim_id,b.birim AS 'Stok Birimi',us.urunSinif_id,us.urunSinifi AS 'Ürün Sınıfı'
                                                from tbl_urun u
                                                join tbl_urunTur ut on ut.urunTur_id=u.urunTur_id
                                                join tbl_birim b on b.birim_id=u.birim_id
                                                join tbl_urunSinifi us on us.urunSinif_id=u.urunSinif_id");

            dgv_urunler.Columns["urun_id"].Visible = false;
            dgv_urunler.Columns["urunTur_id"].Visible = false;
            dgv_urunler.Columns["birim_id"].Visible = false;
            dgv_urunler.Columns["urunSinif_id"].Visible = false;


        }
        private void tx_barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tx_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tx_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void btn_urunTurEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem yaptıktan sonra lütfen formu yenileyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunTur utfrm = new UrunTur();
            utfrm.Show();
        }

        private void tx_urunKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_urunKodu.Text == "")
            {
                MessageBox.Show("Ürün kodu boş bırakılamaz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (tx_barkod.Text.Trim().Length != 13)
            {
                MessageBox.Show("Barkod numarası 13 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_miktar.Text == "")
            {
                MessageBox.Show("Lütfen ürün adedini giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_fiyat.Text == "")
            {
                MessageBox.Show("Lütfen ürünün fiyatını giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_urunTur.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ürün türünü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_urunSinifi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ürün sınıfını seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_birim.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen stok birimini seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow item in dgv_urunler.Rows)
            {
                if (item.Cells[2].Value.ToString() == tx_barkod.Text)
                {
                    MessageBox.Show("Bu barkod numarasına ait ürün daha önce eklenmiş.Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.Cells[1].Value.ToString() == tx_urunKodu.Text)
                {
                    MessageBox.Show("Bu ürün koduna ait ürün daha önce eklenmiş. Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            object kayitSayisi = vt.Insert(@"insert into tbl_urun(urunKodu,barkod,miktar,fiyat,urunTur_id,birim_id,urunSinif_id)
                                            values('"+tx_urunKodu.Text+"','"+tx_barkod.Text+"','"+tx_miktar.Text+"','"+tx_fiyat.Text+"',"+cbx_urunTur.SelectedValue+","+cbx_birim.SelectedValue+","+cbx_urunSinifi.SelectedValue+")");

            UrunDoldur();
            MessageBox.Show("Ürün, başarılı bir şekilde kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();

        }

        public void Temizle()
        {
            tx_urunKodu.Text = "";
            tx_barkod.Text = "";
            tx_miktar.Text = "";
            tx_fiyat.Text = "";
            cbx_urunTur.SelectedIndex = -1;
            cbx_urunSinifi.SelectedIndex = -1;
            cbx_birim.SelectedIndex = -1;

            if (dgv_urunler.SelectedRows.Count > 0)
                dgv_urunler.SelectedRows[0].Selected = false;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (tx_urunKodu.Text == "")
            {
                MessageBox.Show("Ürün kodu boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_barkod.Text.Trim().Length != 13)
            {
                MessageBox.Show("Barkod numarası 13 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_miktar.Text == "")
            {
                MessageBox.Show("Lütfen ürün adedini giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_fiyat.Text == "")
            {
                MessageBox.Show("Lütfen ürünün fiyatını giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_urunTur.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ürün türünü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_urunSinifi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ürün sınıfını seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_birim.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen stok birimini seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow item in dgv_urunler.Rows)
            {
                if (item.Cells[2].Value.ToString() == tx_barkod.Text)
                {
                    MessageBox.Show("Bu barkod numarasına ait ürün daha önce eklenmiş.Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (item.Cells[1].Value.ToString() == tx_urunKodu.Text)
                {
                    MessageBox.Show("Bu ürün koduna ait ürün daha önce eklenmiş. Tekrar eklenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            int kayitSayisi = vt.UpdateDelete(@"update tbl_urun 
                                                set urunKodu='"+tx_urunKodu.Text+
                                                "', barkod='"+tx_barkod.Text+
                                                "', miktar='"+tx_miktar.Text+
                                                "', fiyat='"+tx_fiyat.Text+
                                                "',urunTur_id="+cbx_urunTur.SelectedValue+
                                                ",birim_id="+cbx_birim.SelectedValue+
                                                ",urunSinif_id="+cbx_urunSinifi.SelectedValue+
                                                "where urun_id=" + dgv_urunler.SelectedRows[0].Cells["urun_id"].Value);
            if (kayitSayisi > 0)
            {
                UrunDoldur();
                MessageBox.Show("Kayıt güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Temizle();
        }
        string urunKontrol;
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_urunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_urunKodu.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz ürüne 2 kez tıklayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Kayıt silinecektir. Devam etmek istiyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable kontrol = vt.Select("select COUNT(satisDetay_id) cou from tbl_satisDetay where urun_id='" + urunid + "'");
            urunKontrol = kontrol.Rows[0]["cou"].ToString();

            if (urunKontrol == "0")
            {
                int kayitSayisi = vt.UpdateDelete("delete from tbl_urun where urun_id=" + dgv_urunler.SelectedRows[0].Cells["urun_id"].Value);
                if (kayitSayisi > 0)
                {
                    UrunDoldur();
                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu Ürüne kayıtlı " + urunKontrol + " SatışDetay bulunmakta", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Temizle();
        }
        string urunid;
        private void dgv_urunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_urunler.SelectedRows.Count == 0)
                return;
            tx_urunKodu.Text = dgv_urunler.SelectedRows[0].Cells[1].Value.ToString();
            tx_barkod.Text = dgv_urunler.SelectedRows[0].Cells[2].Value.ToString();
            tx_miktar.Text = dgv_urunler.SelectedRows[0].Cells[3].Value.ToString();
            tx_fiyat.Text = dgv_urunler.SelectedRows[0].Cells[4].Value.ToString();
            cbx_urunTur.SelectedValue = dgv_urunler.SelectedRows[0].Cells["urunTur_id"].Value;
            cbx_birim.SelectedValue = dgv_urunler.SelectedRows[0].Cells["birim_id"].Value;
            cbx_urunSinifi.SelectedValue = dgv_urunler.SelectedRows[0].Cells["urunSinif_id"].Value;


            DataTable urunk = vt.Select("select urun_id from tbl_urun where urunKodu='" + tx_urunKodu.Text + "'");
            urunid = urunk.Rows[0]["urun_id"].ToString();
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

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            UrunKaydet_Load(null, null);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void bilgileriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_urunler_CellDoubleClick(null, null);
        }
    }
}
