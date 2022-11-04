using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.IO;

namespace school_project_1
{
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
        }

        private void Baslangic_Load(object sender, EventArgs e)
        {
            string cpuSeriNo = LisanslamaIslemleri.CPUSeriNoCek();
            string hddSeriNo = LisanslamaIslemleri.HDDSeriNoCek()[0];
            string metinCpuHdd = (cpuSeriNo + hddSeriNo.Trim()).Replace('0', '9').Replace('B', 'X').Replace('F', 'Z');
            string sifreliMetin = LisanslamaIslemleri.MD5Sifrele(metinCpuHdd).ToUpper();
            string yazilimKodu = sifreliMetin.Substring(1, 3) + sifreliMetin.Substring(8, 6) + sifreliMetin.Substring(20, 3) + sifreliMetin.Substring(28, 3) + sifreliMetin.Substring(16, 1);

            yazilimKodu = yazilimKodu.Insert(12, "-");
            yazilimKodu = yazilimKodu.Insert(8, "-");
            yazilimKodu = yazilimKodu.Insert(4, "-");

            tx_yazilimKodu.Text = yazilimKodu;
            tx_lisansKodu.Text = "";
        }

        private void btn_lisansGirisi_Click(object sender, EventArgs e)
        {
            string yazilimKodu = tx_yazilimKodu.Text.Remove(4, 1).Remove(8, 1).Remove(12, 1);
            yazilimKodu = yazilimKodu + "BeyazEsya31";

            yazilimKodu = LisanslamaIslemleri.MD5Sifrele(yazilimKodu).ToUpper();

            string lisansKodu = yazilimKodu.Substring(1, 3) + yazilimKodu.Substring(8, 6) + yazilimKodu.Substring(20, 3) + yazilimKodu.Substring(28, 3) + yazilimKodu.Substring(16, 1);

            lisansKodu = lisansKodu.Insert(12, "-");
            lisansKodu = lisansKodu.Insert(8, "-");
            lisansKodu = lisansKodu.Insert(4, "-");

            //tx_lisansKodu.Text = lisansKodu;

            if (lisansKodu == tx_lisansKodu.Text)
            {
                StreamWriter sw = new StreamWriter("Lisans.l", false, Encoding.Default);
                sw.WriteLine(LisanslamaIslemleri.MD5Sifrele(yazilimKodu + lisansKodu));
                sw.Close();
                MessageBox.Show("Lisanslama İşlemi Başarılı. Uygulamayı Yeniden Başlatınız.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lisans kodu geçersiz");
            }
        }

       
    }
}
