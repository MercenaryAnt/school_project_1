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

namespace Gorsel3_Proje_AylinOnder_18759035
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.DataSource = vt.Select(@"select kullanici_id, ad, soyad, tcNo, sifre, eposta, kt.kullaniciTur_id, kt.kullaniciTur from tbl_kullanici k
                                         join tbl_kullaniciTur kt on k.kullaniciTur_id=kt.kullaniciTur_id");

            dgv.Columns["kullanici_id"].Visible = false;
            dgv.Columns["kullaniciTur_id"].Visible = false;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                return;
            tx_ad.Text = dgv.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_soyad.Text = dgv.SelectedRows[0].Cells["soyad"].Value.ToString();
            tx_tc.Text = dgv.SelectedRows[0].Cells["tcNo"].Value.ToString();
            tx_sifre.Text = dgv.SelectedRows[0].Cells["sifre"].Value.ToString();
            tx_email.Text = dgv.SelectedRows[0].Cells["eposta"].Value.ToString();

        }
    }
}
