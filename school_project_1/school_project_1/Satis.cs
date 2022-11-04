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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        public void Temizle()
        {
            dtp_tarih.Value = DateTime.Now;
            tx_tutar.Text = "";
            cbx_musteriAdi.SelectedIndex = -1;
            cbx_kullanici.SelectedIndex = -1;
            cbx_subeAdi.SelectedIndex = -1;
            cbx_odemeTur.SelectedIndex = -1;
            cbx_satisDurum.SelectedIndex = -1;

            if (dgv_satis.SelectedRows.Count > 0)
                dgv_satis.SelectedRows[0].Selected = false;
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        public void GridDoldur()
        {
            dgv_satis.DataSource = vt.Select(@" select satis_id,tarih,tutar,m.musteri_id,m.ad+' '+m.soyad AS 'Müşteri Adı Soyadı',k.kullanici_id,k.soyad+' '+k.soyad AS 'Kullanıcı Adı Soyadı',sb.sube_id,sb.subeAdi AS 'Şube Adı',ot.odemeTur_id,ot.odemeTur AS 'Ödeme Türü',sd.satisDurum_id,sd.satisDurumu AS 'Satış Durumu'
                                                    from tbl_satis s 
                                                    join tbl_musteri m on s.musteri_id=m.musteri_id
                                                    join tbl_kullanici k on s.kullanici_id=k.kullanici_id
                                                    join tbl_sube sb on s.sube_id=sb.sube_id
                                                    join tbl_odemeTur ot on s.odemeTur_id=ot.odemeTur_id
                                                    join tbl_satisDurumu sd on s.satisDurum_id=sd.satisDurum_id");

            dgv_satis.Columns["satis_id"].Visible = false;
            dgv_satis.Columns["musteri_id"].Visible = false;
            dgv_satis.Columns["kullanici_id"].Visible = false;
            dgv_satis.Columns["sube_id"].Visible = false;
            dgv_satis.Columns["odemeTur_id"].Visible = false;
            dgv_satis.Columns["satisDurum_id"].Visible = false;
        }
        private void Satis_Load(object sender, EventArgs e)
        {
            Temizle();
            GridDoldur();

            cbx_musteriAdi.DataSource = vt.Select("select musteri_id,ad+' ' +soyad adSoyad from tbl_musteri");
            cbx_musteriAdi.DisplayMember = "adSoyad";
            cbx_musteriAdi.ValueMember = "musteri_id";

            cbx_kullanici.DataSource = vt.Select("select kullanici_id,ad+ ' '+soyad adSoyad from tbl_kullanici");
            cbx_kullanici.DisplayMember = "adSoyad";
            cbx_kullanici.ValueMember = "kullanici_id";

            cbx_subeAdi.DataSource = vt.Select("select sube_id,subeAdi from tbl_sube");
            cbx_subeAdi.DisplayMember = "subeAdi";
            cbx_subeAdi.ValueMember = "sube_id";

            cbx_odemeTur.DataSource = vt.Select("select odemeTur_id,odemeTur from tbl_odemeTur");
            cbx_odemeTur.DisplayMember = "odemeTur";
            cbx_odemeTur.ValueMember = "odemeTur_id";

            cbx_urun.DataSource = vt.Select("select urun_id,urunKodu +' '+Cast(fiyat as nvarchar(20)) urun from tbl_urun");
            cbx_urun.DisplayMember = "urun";
            cbx_urun.ValueMember = "urun_id";

            cbx_satisDurum.DataSource = vt.Select("select satisDurum_id, satisDurumu from tbl_satisDurumu");
            cbx_satisDurum.DisplayMember = "satisDurumu";
            cbx_satisDurum.ValueMember = "satisDurum_id";

            cbx_urun.SelectedIndex = -1;
            TutarHesapla();
        }

        public void TutarHesapla()
        {
            int toplam = 0;
            for (int i = 0; i < dgv_satisDetay.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dgv_satisDetay.Rows[i].Cells[3].Value) * Convert.ToInt32(dgv_satisDetay.Rows[i].Cells[4].Value);
            }
            tx_tutar.Text = toplam.ToString();
        }

        private void dgv_satis_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_satis.SelectedRows.Count == 0)
                return;
            dgv_satisDetay.DataSource = vt.Select(@"select s.satisDetay_id,u.urun_id, u.urunKodu, s.adet,u.fiyat
	             from tbl_satisDetay s
	                 join tbl_urun u on s.urun_id=u.urun_id
                where s.satis_id=" + dgv_satis.SelectedRows[0].Cells["satis_id"].Value);
            dgv_satisDetay.Columns["satisDetay_id"].Visible = false;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (cbx_musteriAdi.SelectedIndex == -1 || cbx_kullanici.SelectedIndex == -1 || cbx_subeAdi.SelectedIndex == -1 || cbx_odemeTur.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            object kayitSayisi = vt.Insert(@"insert into tbl_satis(tarih,tutar,musteri_id,kullanici_id,sube_id,odemeTur_id,satisDurum_id)
				values('" + dtp_tarih.Value + "','" + tx_tutar.Text + "'," + cbx_musteriAdi.SelectedValue + "," + cbx_kullanici.SelectedValue + "," + cbx_subeAdi.SelectedValue + "," + cbx_odemeTur.SelectedValue + "," + cbx_satisDurum.SelectedValue + ")");
            GridDoldur();
            MessageBox.Show("Satış bilgileri eklendi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_urunEkle_Click(object sender, EventArgs e)
        {
            if (tx_adet.Text == "")
            {
                MessageBox.Show("Adet boş bırakılamaz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (cbx_urun.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ürün seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            vt.Insert("insert into tbl_satisDetay(satis_id,urun_id,adet) values(" + dgv_satis.SelectedRows[0].Cells["satis_id"].Value + "," + cbx_urun.SelectedValue + "," + tx_adet.Text + ")");
            dgv_satis_SelectionChanged(null, null);
            MessageBox.Show("Ürün eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            TutarHesapla();
        }

        private void btn_urunTemizle_Click(object sender, EventArgs e)
        {
            UrunTemizle();
           
        }
        public void UrunTemizle()
        {
            tx_adet.Text = "";
            cbx_urun.SelectedIndex = -1;

            if (dgv_satisDetay.SelectedRows.Count > 0)
                dgv_satisDetay.SelectedRows[0].Selected = false;
        }
         

        private void btn_urunGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_satisDetay.SelectedRows.Count == 0 || cbx_urun.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (tx_adet.Text == "")
            {
                MessageBox.Show("Adet boş bırakılamaz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (cbx_urun.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen ürün seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kayitSayisi = vt.UpdateDelete(@"update tbl_satisDetay
                                                set urun_id=" + cbx_urun.SelectedValue +
                                                ",adet=" + tx_adet.Text +
                                                "where satisDetay_id=" + dgv_satisDetay.SelectedRows[0].Cells["satisDetay_id"].Value);

            if (kayitSayisi > 0)
            {
                dgv_satis_SelectionChanged(null, null);
                MessageBox.Show(kayitSayisi + " kayıt güncellendi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TutarHesapla();
            }
        }

        private void dgv_satisDetay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_satisDetay.SelectedRows.Count == 0)
                return;

            tx_adet.Text = dgv_satisDetay.SelectedRows[0].Cells["adet"].Value.ToString();
            cbx_urun.SelectedValue = dgv_satisDetay.SelectedRows[0].Cells["urun_id"].Value;
        }

        private void btn_urunSil_Click(object sender, EventArgs e)
        {
            if (dgv_satisDetay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            int kayitSayisi = vt.UpdateDelete("delete from tbl_satisDetay where satisDetay_id=" + dgv_satisDetay.SelectedRows[0].Cells["satisDetay_id"].Value);
            if (kayitSayisi > 0)
            {
                dgv_satis_SelectionChanged(null, null);
                MessageBox.Show("Kayıt başarıyla silindi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TutarHesapla();
            }
            else
            {
                MessageBox.Show("Kayıt silinemedi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            UrunTemizle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_satis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (cbx_musteriAdi.SelectedIndex == -1 || cbx_kullanici.SelectedIndex == -1 || cbx_subeAdi.SelectedIndex == -1 || cbx_odemeTur.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            int kayitSayisi = vt.UpdateDelete(@"update tbl_satis
                                            set tarih='" + dtp_tarih.Value +
                                            "', tutar=" + tx_tutar.Text +
                                            ", musteri_id=" + cbx_musteriAdi.SelectedValue +
                                            ",kullanici_id=" + cbx_kullanici.SelectedValue +
                                            ",sube_id=" + cbx_subeAdi.SelectedValue +
                                            ",odemeTur_id=" + cbx_odemeTur.SelectedValue +
                                            ",satisDurum_id=" + cbx_satisDurum.SelectedValue +
                                            "where satis_id=" + dgv_satis.SelectedRows[0].Cells["satis_id"].Value);


            if (kayitSayisi > 0)
            {
                GridDoldur();
                MessageBox.Show(kayitSayisi + " kayıt güncellendi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void dgv_satis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_satis.SelectedRows.Count == 0)
                return;

            dtp_tarih.Text = dgv_satis.SelectedRows[0].Cells["tarih"].Value.ToString();
            tx_tutar.Text = dgv_satis.SelectedRows[0].Cells["tutar"].Value.ToString();
            cbx_musteriAdi.SelectedValue = dgv_satis.SelectedRows[0].Cells["musteri_id"].Value;
            cbx_kullanici.SelectedValue = dgv_satis.SelectedRows[0].Cells["kullanici_id"].Value;
            cbx_subeAdi.SelectedValue = dgv_satis.SelectedRows[0].Cells["sube_id"].Value;
            cbx_odemeTur.SelectedValue = dgv_satis.SelectedRows[0].Cells["odemeTur_id"].Value;
            cbx_satisDurum.SelectedValue = dgv_satis.SelectedRows[0].Cells["satisDurum_id"].Value;
        }

        private void btn_musteriEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem yaptıktan sonra lütfen formu yenileyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Musteri musfrm = new Musteri();
            musfrm.Show();
        }

        private void btn_kullaniciEkle_Click(object sender, EventArgs e)
        {

        }

        private void btn_subeEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem yaptıktan sonra lütfen formu yenileyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Sube sfrm = new Sube();
            sfrm.Show();
        }

        private void btn_odemeTuruEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem yaptıktan sonra lütfen formu yenileyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OdemeTur otfrm = new OdemeTur();
            otfrm.Show();
        }

        private void btn_siparisDurumuEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem yaptıktan sonra lütfen formu yenileyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SatisDurumu sdfrm = new SatisDurumu();
            sdfrm.Show();
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            Satis_Load(null, null);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_satis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (dgv_satisDetay.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silme işlemi başarılı.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu satışa ait ürünler bulunmaktadır. Önce ürünleri silmelisiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            try
            {

                int kayitSayisi = vt.UpdateDelete("delete from tbl_satis where satis_id=" + dgv_satis.SelectedRows[0].Cells["satis_id"].Value);
                if (kayitSayisi > 0)
                {
                    GridDoldur();
                    
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
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

        private void tx_adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tx_tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void bilgileriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_satis_CellDoubleClick(null, null);
        }

        private void bilgileriYükleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgv_satisDetay_CellDoubleClick(null, null);
        }
    }
}
