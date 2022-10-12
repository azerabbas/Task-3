using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CutVeYaTek();
            //SozuTap();
            Hesabla();
        }

        static void CutVeYaTek()
        {
            Console.WriteLine("Enter number");
            int numb = int.Parse(Console.ReadLine());

            if (numb%2==0)
            {
                Console.WriteLine("Double");
            }
            else
            {
                Console.WriteLine("Single");
            }
        }

        static void SozuTap()
        {
            Console.WriteLine("Bir soz daxil edin : ");
            string soz = Console.ReadLine();
            Console.WriteLine("Axtarmaq istediyiniz soz ve ya herfi daxil edin : ");
            string axtarilanSoz = Console.ReadLine();
            int yoxla = soz.IndexOf(axtarilanSoz);

            if (yoxla>-1)
            {
                Console.WriteLine("Axtardighiniz soz ve ya herf daxil olunan soz ve ya cumle ichinde movcuddur");

            }
            else
            {
                Console.WriteLine("Axtardighiniz soz ve ya herf daxil olunan soz ve ya cumle ichinde yoxdur");
            }

        }
        static void Hesabla()
        {
            Console.WriteLine("Birinci reqemi daxil edin : ");
            double birinciReqem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ikinci reqemi daxil edin : ");
            double ikinciReqem = Convert.ToDouble(Console.ReadLine());

            double netice = birinciReqem/ikinciReqem;
            Console.WriteLine(netice);


        }
    }
}
