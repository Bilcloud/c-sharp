using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultInteger=0,res, intA, intB;

            string strA, strB, strC;
            

            Console.Write("Enter value for A:");
            strA = Console.ReadLine();
            Console.Write("Enter value for B:");
            strB = Console.ReadLine();

            if (!int.TryParse(strA, out intA))
            {
                Console.WriteLine("Numeric value required for A");
                Console.Write("Enter any key to continue:");
                Console.ReadLine();
                return;
            }

            if (!int.TryParse(strB, out intB))
            {
                Console.WriteLine("Numeric value required for B");
                Console.Write("Enter any key to continue:");
                Console.ReadLine();
                return;
            }


            res = product2Int(intA, intB);
            Console.WriteLine("Method A results = {0}", res.ToString());

            product2Int(intA, intB, out resultInteger);
            Console.WriteLine("Method B results = {0}", resultInteger.ToString());

            product2IntWithRef(intA, intB, ref resultInteger);
            Console.WriteLine("Method C results = {0}", resultInteger.ToString());

            Console.ReadLine();
        }

        static int product2Int(int numberAInteger, int numberBInteger)
        {
            return numberAInteger * numberBInteger;
        }

        static void product2Int(int numberAInteger, int numberBInteger, out int numberCInteger)
        {
            numberCInteger= numberAInteger * numberBInteger;
        }

        static void product2IntWithRef(int numberAInteger, int numberBInteger, ref int numberCInteger)
        {
            numberCInteger = numberAInteger * numberBInteger;
        }
    }
}
