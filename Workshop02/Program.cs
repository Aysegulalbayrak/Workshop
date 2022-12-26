namespace Workshop02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) 1-100 arasındaki tüm asal sayıları ekrana yazdıran programı hazırlayınız.
            Console.WriteLine("*** 1-100 ARASI ASAL SAYILAR *** ");
            for (int i = 2; i < 101; i++)
            {
                bool isAsal = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isAsal = false;

                    }

                }
                if (isAsal)
                {
                    Console.WriteLine("-> " + i);

                }


            }


        }
    }
}