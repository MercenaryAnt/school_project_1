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
    public partial class UrunSinifi : Form
    {
        public UrunSinifi()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void UrunSinifi_Load(object sender, EventArgs e)
        {
            dgv_sinif.DataSource = vt.Select("select urunSinif_id, urunSinifi from tbl_urunSinifi");
            dgv_sinif.Columns["urunSinif_id"].Visible = false;
        }


        string urunSinifid;
        private void dgv_sinif_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_sinif.SelectedRows.Count == 0)
                return;
            tx_urunSinifi.Text = dgv_sinif.SelectedRows[0].Cells["urunSinifi"].Value.ToString();

            DataTable urunSinifk = vt.Select("select urunSinif_id from tbl_urunSinifi where urunSinifi='" + tx_urunSinifi.Text + "'");
            urunSinifid = urunSinifk.Rows[0]["urunSinif_id"].ToString();
        }

        private void btn_ekle_Click_1(object sender, EventArgs e)
        {
            if (tx_urunSinifi.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            object kayitSayisi = vt.Insert("insert into tbl_urunSinifi(urunSinifi) values('" + tx_urunSinifi.Text + "')");
            UrunSinifi_Load(null, null);
            MessageBox.Show("Sınıf eklemesi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            if (dgv_sinif.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_urunSinifi.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSayisi = vt.UpdateDelete(@"update tbl_urunSinifi set urunSinifi = '" + tx_urunSinifi.Text +
                "' where urunSinif_id ="
                + dgv_sinif.SelectedRows[0].Cells["urunSinif_id"].Value);
            if (kayitSayisi > 0)
            {
                UrunSinifi_Load(null, null);
                MessageBox.Show("Bilgiler güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Temizle();
        }
        public void Temizle()
        {
            tx_urunSinifi.Text = "";

            if (dgv_sinif.SelectedRows.Count > 0)
                dgv_sinif.SelectedRows[0].Selected = false;
        }

        private void btn_temizle_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }
        string urunSinifKontrol;
        private void btn_sil_Click_1(object sender, EventArgs e)
        {
            if (dgv_sinif.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_urunSinifi.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz ÜrünSınıfına 2 kez tıklayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Kayıt silinecektir. Devam etmek istiyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable kontrol = vt.Select("select COUNT(urun_id) cou from tbl_urun where urunSinif_id='" + urunSinifid + "'");
            urunSinifKontrol = kontrol.Rows[0]["cou"].ToString();

            if (urunSinifKontrol == "0")
            {
                int kayitSayisi = vt.UpdateDelete("delete from tbl_urunSinifi where urunSinif_id=" + dgv_sinif.SelectedRows[0].Cells["urunSinif_id"].Value);
                if (kayitSayisi > 0)
                {
                    UrunSinifi_Load(null, null);
                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu ÜrünSınıfına kayıtlı " + urunSinifKontrol + " ürün bulunmakta", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            Temizle();
        }

        private void tx_urunSinifi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != ' '  && e.KeyChar !='+' && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void bilgileriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_sinif_CellDoubleClick(null, null);
        }
    }
}
