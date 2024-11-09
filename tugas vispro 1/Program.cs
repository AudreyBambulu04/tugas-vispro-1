using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_vispro_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f;
            Console.Write("Masukkan nilai a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai b : ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;

            Console.WriteLine("\nc = hasil pertambahan a + b = {0}", c);
            Console.WriteLine("d = hasil pengurangan a - b = {0}", d);
            Console.WriteLine("e = hasil perkalian a x b = {0}", e);
            Console.WriteLine("f = hasil pembagian a : b = {0}", f);

            bool CompareC1, CompareC2, CompareD1, CompareD2, CompareC3, CompareD3;
            CompareC1 = c < e;
            CompareC2 = c > e;
            CompareD1 = d <= f;
            CompareD2 = d >= f;
            CompareC3 = c == e;
            CompareD3 = d != f;


            Console.WriteLine("\nmaka c < e adalah {0}", CompareC1);
            Console.WriteLine("maka c > e adalah {0}", CompareC2);
            Console.WriteLine("maka d <= f adalah {0}", CompareD1);
            Console.WriteLine("maka d >= f adalah {0}", CompareD2);
            Console.WriteLine("maka c = e adalah {0}", CompareC3);
            Console.WriteLine("maka d != f adalah {0}", CompareD3);
        }
    }
}
      