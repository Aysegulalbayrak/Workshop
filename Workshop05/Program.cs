namespace Workshop05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Girilen 4 haneli bir tam sayının yüzler hanesindeki sayı degerinin 3 ile bölümünden elde edilen kalanın aynı sayının birler hanesindeki deger ile farkını bulan programı yazın.
            Console.WriteLine("Lütfen 4 haneli bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int yuzlerbas, kalan, sonuc;
            int kacbasamak = 0;
            int sayiyedek = sayi;
            while (sayiyedek != 0)
            {
                sayiyedek /= 10;
                kacbasamak++;
            }
            if (kacbasamak == 4)
            {
                yuzlerbas = (sayi % 1000) / 100;
                kalan = yuzlerbas % 3;
                sonuc = (sayi % 10) - kalan;

                if (sonuc >= 0)
                {
                    Console.WriteLine(sonuc);
                }
                else
                {
                    Console.WriteLine(sonuc * -1);
                }

            }

            else
            {
                Console.WriteLine("Lütfen  4 haneli bir tam sayı girdiğinizden emin olun.");
            }
        }
    }
}