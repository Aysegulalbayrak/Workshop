namespace Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
           1) Klavyeden girilen A ve B gibi iki sayıyı,  sadece toplama ve çıkarma işlemlerini kullanarak (direkt çarpma işlemi kullanmadan) çarpma işlemini yapan ve bunun sonucunu ekrana, ekranın geri plan rengi beyaz ve ekrana yazılan mesajın rengi kırmızı olacak şekilde yazan programı yazınız.

           */
            int A = 0, B = 0;
            int Sonuc = 0;
            Console.WriteLine("Lütfen 1.sayıyı giriniz: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2.sayıyı giriniz: ");
            B = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < A; i++)
            {
                Sonuc += B;

            }
            Console.BackgroundColor = ConsoleColor.White; //arkaplan rengi
            Console.ForegroundColor = ConsoleColor.Red; //yazı rengi

            Console.WriteLine("Çarpma işleminin sonucu: " + Sonuc);


        }
    }
}