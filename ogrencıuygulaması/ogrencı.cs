using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrencıuygulaması
{
    internal class ogrencı
    {
        private int ogrencıno;
        private string ısım;
        private string soyısım;
        private int vize1;
        private int vize2;
        private int fınal;
        private string okulısmı;

        public ogrencı(int ogrencıno, string ısım, string soyısım, int vize1, int vize2, int fınal, string okulısmı)
        {
            this.ogrencıno = ogrencıno;
            this.ısım = ısım;
            this.soyısım = soyısım;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.fınal = fınal;
            this.okulısmı = okulısmı;
        }

        public void ogrencibilgilerinigöster()
        {
            Console.WriteLine("Öğrenci numarası" + ogrencıno);
            Console.WriteLine("Öğrenci ismi " + ısım);
            Console.WriteLine("Öğrenci soyadı " + soyısım);
            Console.WriteLine("Öğrenci vize 1 " + vize1);
            Console.WriteLine("Öğrenci vize 2 " + vize2);
            Console.WriteLine("Öğrenci final " + fınal);
            Console.WriteLine(("Öğrenci okulun ismi ") + okulısmı);


        }

        public double ogrencıortalamabul()
        {
          double ortalama = vize1*0.2 + vize2*0.2 + fınal*0.6;
            return ortalama;
        }
        
        public void okulgetır()
        {
            Console.WriteLine(("Öğrencinin okuduğu ismi") + okulısmı);
            return;
        }

    }
}
