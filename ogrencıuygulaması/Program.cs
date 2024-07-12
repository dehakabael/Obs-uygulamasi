namespace ogrencıuygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            ogrencı öğrenci1 = new ogrencı(230910082, "Deha", "Kabael", 70, 55, 55, "Ufuküniversitesi");


            Console.WriteLine("Obs uygulamsına hoş geldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçin");

            Console.WriteLine("1- Öğrencinin bilgilerini göster 2- Öğrencinin Ortalamasını göster 3- Öğrencinin Okulunu göster 4-Çıkış yap");

            while (kontrol) {

                string secım = Console.ReadLine();

                switch (secım)
                {
                    case "1":
                        öğrenci1.ogrencibilgilerinigöster();
                        break;
                    case "2":
                        double ogrenciortlama = öğrenci1.ogrencıortalamabul();
                        Console.WriteLine(("Öğrencinin Ortalaması") + ogrenciortlama );
                        break;

                    case "3":
                        öğrenci1.okulgetır();
                        break;

                    case "4":
                        kontrol = false;
                        break;



                }

            }
            



        }
    }
}
