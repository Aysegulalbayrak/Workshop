namespace Workshop06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6) Bir bankamatik müşterisine bankamatikten çekmek istediği para sorulacak. Çekeceği paraya göre kaç tane 200’lük, kaç tane 100’lük, kaç tane 50’lik, kaç tane 20’lik, kaç tane 10’luk ve kaç tane 5’lik verilmesi gerektiğini bulan programı yazın.
            int cekilecekPara, verilecekPara ,ikiyuzluk=0, yuzluk=0, ellilik=0, yirmilik=0, onluk=0, beslik=0,birlik=0;
            Console.WriteLine( "Lütfen çekmek istediğiniz miktarı giriniz: ");
            cekilecekPara = Convert.ToInt32(Console.ReadLine());
            
            if (cekilecekPara >=200)
            {
                ikiyuzluk = cekilecekPara / 200;
                cekilecekPara = cekilecekPara % 200;


            }
            if (cekilecekPara >=100)
            {
                yuzluk = cekilecekPara / 100;
                cekilecekPara = cekilecekPara % 100;

            }
            if (cekilecekPara>=50)
            {
                ellilik = cekilecekPara / 50;
                cekilecekPara = cekilecekPara % 50;
            }
            if (cekilecekPara >=20)
            {
                yirmilik = cekilecekPara / 20;
                cekilecekPara = cekilecekPara % 20;

            }
            if (cekilecekPara>=10)
            {

                onluk = cekilecekPara / 10;
                cekilecekPara = cekilecekPara % 10;
            }
            if (cekilecekPara>=5)
            {
                beslik = cekilecekPara / 5;
                cekilecekPara = cekilecekPara % 5;
            }
            if (cekilecekPara >= 1)
            {
                birlik = cekilecekPara / 1;
                cekilecekPara = cekilecekPara % 1;
            }
            if (cekilecekPara==0)
            {
                verilecekPara = 200 * ikiyuzluk + 100 * yuzluk + 50 * ellilik + 20 * yirmilik + 10 * onluk + 5 * beslik + birlik;
                Console.WriteLine("200'lük: {0}, 100'lük: {1} ,50'lik: {2}, 20'lik: {3} ,10'lük: {4} , 5'lk: {5} , 1'lik: {6} ",ikiyuzluk,yuzluk,ellilik,yirmilik,onluk,beslik,birlik);
                Console.WriteLine("Verilen Para: "+  verilecekPara);
            }

            


        }
    }
}