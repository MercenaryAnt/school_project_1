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
    public partial class OdemeTur : Form
    {
        public OdemeTur()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void OdemeTur_Load(object sender, EventArgs e)
        {
            dgv_odemeTur.DataSource = vt.Select("select odemeTur_id, odemeTur AS 'Ödeme Türü' from tbl_odemeTur");
            dgv_odemeTur.Columns["odemeTur_id"].Visible = false;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_odemeTur.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            object kayitSay = vt.Insert("insert into tbl_odemeTur(odemeTur) values('" + tx_odemeTur.Text + "')");
            OdemeTur_Load(null, null);
            MessageBox.Show("Ekleme işlemi başarılı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Temizle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_odemeTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_odemeTur.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_odemeTur set odemeTur = '" + tx_odemeTur.Text +
                "' where odemeTur_id ="
                + dgv_odemeTur.SelectedRows[0].Cells["odemeTur_id"].Value);
            if (kayitSay > 0)
            {
                OdemeTur_Load(null, null);
                MessageBox.Show("Bilgiler güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Temizle();
        }
        string odemeTurKontrol;
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_odemeTur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_odemeTur.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz ödemetürüne 2 kez tıklayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Kayıt silinecektir. Devam etmek istiyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable kontrol = vt.Select("select COUNT(satis_id) cou from tbl_satis where odemeTur_id='" + odemeTurid + "'");
            odemeTurKontrol = kontrol.Rows[0]["cou"].ToString();

            if (odemeTurKontrol == "0")
            {
                int kayitSay = vt.UpdateDelete("delete from tbl_odemeTur where odemeTur_id=" + dgv_odemeTur.SelectedRows[0].Cells["odemeTur_id"].Value);
                if (kayitSay > 0)
                {
                    OdemeTur_Load(null, null);
                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu ÖdemeTürüne kayıtlı " + odemeTurKontrol + " satış bulunmakta", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            Temizle();


        }
        public void Temizle()
        {
            tx_odemeTur.Text = "";

            if (dgv_odemeTur.SelectedRows.Count > 0)
                dgv_odemeTur.SelectedRows[0].Selected = false;
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
        string odemeTurid;
        private void dgv_odemeTur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_odemeTur.SelectedRows.Count == 0)
                return;
            tx_odemeTur.Text = dgv_odemeTur.SelectedRows[0].Cells[1].Value.ToString();

            DataTable odemeTurk = vt.Select("select odemeTur_id from tbl_odemeTur where odemeTur='" + tx_odemeTur.Text + "'");
            odemeTurid = odemeTurk.Rows[0]["odemeTur_id"].ToString();
        }

        private void tx_odemeTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != ' ' && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void bilgileriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_odemeTur_CellDoubleClick(null, null);
        }
    }
}
