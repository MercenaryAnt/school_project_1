using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.IO;

namespace school_project_1
{
    class LisanslamaIslemleri
    {

        public static String CPUSeriNoCek()
        {
            String processorID = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
            ManagementObjectCollection mObject = searcher.Get();

            foreach (ManagementObject obj in mObject)
            {
                processorID = obj["ProcessorId"].ToString();
            }

            return processorID;
        }

        public static List<string> HDDSeriNoCek()
        {
            List<string> serials = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            ManagementObjectCollection disks = searcher.Get();
            foreach (ManagementObject disk in disks)
            {
                if (disk["SerialNumber"] == null)
                    serials.Add("");
                else
                    serials.Add(disk["SerialNumber"].ToString());
            }
            return serials;
        }

        public static string MD5Sifrele(string sifrelenecekMetin)
        {

            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }
        public static Boolean lisansKontrol()
        {
            string cpuSeriNo = CPUSeriNoCek();
            string hddSeriNo = HDDSeriNoCek()[0];
            string metinCpuHdd = (cpuSeriNo + hddSeriNo.Trim()).Replace('0', '9').Replace('B', 'X').Replace('F', 'Z');
            string sifreliMetin = MD5Sifrele(metinCpuHdd).ToUpper();
            string yazilimKodu = sifreliMetin.Substring(1, 3) + sifreliMetin.Substring(8, 6) + sifreliMetin.Substring(20, 3) + sifreliMetin.Substring(28, 3) + sifreliMetin.Substring(16, 1);

            string yazilimKoduIlk = yazilimKodu;

            yazilimKodu = yazilimKodu + "BeyazEsya31";

            yazilimKodu = MD5Sifrele(yazilimKodu).ToUpper();

            string lisansKodu = yazilimKodu.Substring(1, 3) + yazilimKodu.Substring(8, 6) + yazilimKodu.Substring(20, 3) + yazilimKodu.Substring(28, 3) + yazilimKodu.Substring(16, 1);

            lisansKodu = lisansKodu.Insert(12, "-");
            lisansKodu = lisansKodu.Insert(8, "-");
            lisansKodu = lisansKodu.Insert(4, "-");

            string birlesikKod = yazilimKodu + lisansKodu;

            if (File.Exists("Lisans.l"))
            {
                StreamReader sr = new StreamReader("Lisans.l");
                string okunan = sr.ReadLine();
                sr.Close();
                if (MD5Sifrele(birlesikKod) == okunan)
                    return true;
                else
                    return false;

            }
            else
                return false;

        }

    }
}
