using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hill
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;
            while (Exit == false)
            {
                var foos1 = Console.ReadLine();
                string[] str1 = foos1.Split(',');

                Decimal MinDiff = findMin(str1);
                Console.WriteLine(MinDiff);
            }
        }

        public static decimal findMin(string[] str2)
        {
            decimal result1=0;
            decimal result2 = 0;
            int l = str2.Length;
            decimal[] arr1 = new decimal[l];
            decimal[] ascending = new decimal[l];
            

            for (int x=0; x < l;x++)
            {
                arr1[x] = Convert.ToDecimal(str2[x]);
                ascending[x] = Convert.ToDecimal(str2[x]);
            }

            Array.Sort(ascending);

            for (int x = 0; x < l; x++)
            {
               result1 = Math.Abs (arr1[x] - ascending[x]);

            if (result1 > result2)
                {

                    result2 = result1;
                }
            }
            return result2;
        }
    }
}
