using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 1. Write a C# program that takes two numbers as input and returns true or false when both numbers are even or odd
          // 2. Write a C# program which takes 2 string input from user and return if second string is in first string. Example. 1st input: Azərbaycan, 2nd input: can, Result should be true because can is in Azərbaycan
          //  3. Get 2 int number input from user and calculate the exact input1 / input2. Example: 16, 5. Result should be 3.2 not 3.
          //  4. Practise type conversions (different options), types and operators
                        
            
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
