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
    public partial class Gorev : Form
    {
        public Gorev()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_gorev.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object kayitSay = vt.Insert("insert into tbl_gorev(gorev) values('" + tx_gorev.Text + "')");
            Gorev_Load(null, null);
            MessageBox.Show("Ekleme başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Gorev_Load(object sender, EventArgs e)
        {
            dgv_gorev.DataSource = vt.Select("select gorev_id, gorev AS 'Görev Adı' from tbl_gorev");
            dgv_gorev.Columns["gorev_id"].Visible = false;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_gorev.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_gorev.Text == "")
            {
                MessageBox.Show("Boş bırakmayınız!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_gorev set gorev = '" + tx_gorev.Text +
                "' where gorev_id ="
                + dgv_gorev.SelectedRows[0].Cells["gorev_id"].Value);
            if (kayitSay > 0)
            {
                Gorev_Load(null, null);
                MessageBox.Show("Bilgiler güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Temizle();
        }
        string gorevKontrol, gorevid;
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_gorev.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_gorev.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz göreve 2 kez tıklayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Kayıt silinecektir. Devam etmek istiyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes)
            {
                MessageBox.Show("Silme işlemi iptal edildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable kontrol = vt.Select("select COUNT(gorev_id) cou from tbl_personel where gorev_id='" + gorevid + "'");
            gorevKontrol = kontrol.Rows[0]["cou"].ToString();

            if (gorevKontrol == "0")
            {
                int kayitSay = vt.UpdateDelete("delete from tbl_gorev where gorev_id=" + dgv_gorev.SelectedRows[0].Cells["gorev_id"].Value);
                if (kayitSay > 0)
                {
                    Gorev_Load(null, null);
                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bu göreve kayıtlı " + gorevKontrol + " personel bulunmakta", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Temizle();

        }
        public void Temizle()
        {
            tx_gorev.Text = "";

            if (dgv_gorev.SelectedRows.Count > 0)
                dgv_gorev.SelectedRows[0].Selected = false;
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgv_gorev_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_gorev.SelectedRows.Count == 0)
                return;
            tx_gorev.Text = dgv_gorev.SelectedRows[0].Cells[1].Value.ToString();

            DataTable gorevk = vt.Select("select gorev_id from tbl_gorev where gorev='" + tx_gorev.Text + "'");
            gorevid = gorevk.Rows[0]["gorev_id"].ToString();
        }

        private void bilgileriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_gorev_CellDoubleClick(null, null);
        }

        private void tx_gorev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != ' ' && e.KeyChar != '\b')
                e.Handled = true;
        }
    }
}
