using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeni_proje
{
    class Program
    {
        static void Main(string[] args)
        {
            a:
            Console.WriteLine("Vize kaç ? ");
            double Sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final kaç ? ");
            double Sayi2 = Convert.ToDouble(Console.ReadLine());
            double toplam = (Sayi1 * 0.40) + (Sayi2 * 0.60);
// sayılar yine virgüllü olduğundan double kullandık
            if (toplam >= 90)
            {
                Console.WriteLine("AA - GEÇTİ: "+toplam+" ");
                goto a;
            }
            else if (toplam >= 80 && toplam <= 89)
            {
                Console.WriteLine("BA - GEÇTİ: " + toplam + " ");
                goto a;
            }
            else if (toplam >= 70 && toplam <= 79)
         	{
                Console.WriteLine("BB - GEÇTİ: " + toplam + " ");
                goto a;
            }
            else if (toplam >= 65 && toplam <= 69)
            {
                Console.WriteLine("CB - GEÇTİ: " + toplam + " ");
                goto a;
                
            }  else if (toplam >= 60 && toplam <= 64)
            {
                Console.WriteLine("CC - GEÇTİ: " + toplam + " ");
                goto a;

            }
            else if (toplam >= 55 && toplam <= 59)
            {
                Console.WriteLine("DD - ŞARTLI GEÇTİ: " + toplam + " ");
                goto a;
            }
            else if (toplam >= 50 && toplam <= 54)
            {
                Console.WriteLine("DC - ŞARTLI GEÇTİ : " + toplam + " ");
                goto a;
            }
            else if (toplam >= 30 && toplam <= 49)
            {
                Console.WriteLine("FD - KALDI : " + toplam + " ");
                goto a;
            }
            else if (toplam >= 0 && toplam <= 29)
            {
                Console.WriteLine("FF - KALDI : " + toplam + " ");
                goto a;
            }
        }
    }
}
