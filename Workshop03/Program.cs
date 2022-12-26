namespace Workshop03
{
    internal class Program
    {
//        [20:29, 25.12.2022]
//        Ayşegül Albayrak: 3)
//[20:30, 25.12.2022] Ayşegül Albayrak: 
            static void Main(string[] args)
        {
            //Klavyeden girilen 6 basamaklı bir sayının tüm basamaklarındaki sayıları toplayıp yazdıran programı hazırlayınız
            Console.WriteLine("Lütfen 6 haneli bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int birlerbas, onlarbas, yuzlerbas, binlerbas, onbinlerbas, yuzbinlerbas, kacbasamak, sayiyedek, toplam;
            kacbasamak = 0;
            sayiyedek = sayi;
            while (sayiyedek != 0)
            {
                sayiyedek /= 10;
                kacbasamak++;
            }

            if (kacbasamak == 6)
            {

                yuzbinlerbas = (sayi % 1000000) / 100000;
                onbinlerbas = (sayi % 100000) / 10000;
                binlerbas = (sayi % 10000) / 1000;
                yuzlerbas = (sayi % 1000) / 100;
                onlarbas = (sayi % 100) / 10;
                birlerbas = (sayi % 10);
                toplam = yuzbinlerbas + onbinlerbas + binlerbas + yuzlerbas + onlarbas + birlerbas;
                Console.WriteLine("Toplam: " + toplam);


            }

            else
            {
                Console.WriteLine("Lütfen  4 haneli bir tam sayı girdiğinizden emin olun.");
            }
        }
    }
}