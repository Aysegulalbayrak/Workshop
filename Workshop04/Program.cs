namespace Workshop04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Bir ders için yapılan iki ara sınav ve bir genel sınav sonucu değerlendirilerek geçme notları hesaplanacaktır. Bu dersin geçme notu 1. ara sınav notunun %20’si, 2. ara sınav notunun %30’u ve genel sınav notunun %50’si toplanarak hesaplanmaktadır. Geçme notunu hesaplayan ve sonucu ekrana yazdıran programı yazın.
            double araSınav1, araSınav2, genelSınav, gecmeNotu;

            Console.WriteLine("Lütfen 1. Ara sınav notunuzu giriniz: ");
            araSınav1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Ara sınav notunuzu giriniz: ");
            araSınav2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen Genel sınav notunuzu giriniz: ");
            genelSınav = Convert.ToDouble(Console.ReadLine());

            araSınav1 = araSınav1 * 0.2;
            araSınav2 = araSınav2 * 0.3;
            genelSınav = genelSınav * 0.5;
            gecmeNotu = araSınav1 + araSınav2 + genelSınav;
            Console.WriteLine("Geçme Notu: " + gecmeNotu);

        }
    }
}