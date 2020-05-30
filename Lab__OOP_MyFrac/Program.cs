using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__OOP_MyFrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть чисельник дробу:");
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введiть знаменник дробу:");
            long k = Convert.ToInt64(Console.ReadLine());
            MyFrac f = new MyFrac(n, k);
            Console.WriteLine(f);
            Console.WriteLine("Введiть чисельник дробу, який використовуватиметься для арифметичних дiй:");
            n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введiть знаменник дробу, який використовуватиметься для арифметичних дiй:");
            k = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введiть число n для GetRGR113LeftSum:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть число n для GetRGR115LeftSum:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            MyFrac f2 = new MyFrac(n, k);
            Console.WriteLine(f2);
            Console.WriteLine("Перший дрiб у форматi MyFrac:\n" + f);
            Console.WriteLine("Другий дрiб у форматi MyFrac:\n" + f2);
            Console.WriteLine("Перший дрiб з видiленою цiлою частиною:\n" + f.ToStringWithIntegerPart());
            Console.WriteLine("Другий дрiб з видiленою цiлою частиною:\n" + f2.ToStringWithIntegerPart());
            Console.WriteLine("Дiйсне значення першого дробу:\n" + f.DoubleValue());
            Console.WriteLine("Дiйсне значення другого дробу:\n" + f2.DoubleValue());
            Console.WriteLine("Сума дробiв:\n" + (f + f2));
            Console.WriteLine("Рiзниця дробiв:\n" + (f - f2));
            Console.WriteLine("Добуток дробiв:\n" + (f * f2));
            Console.WriteLine("Частка дробiв:\n" + (f / f2));
            Console.WriteLine("GetRGR113LeftSum:\n" + MyFrac.GetRGR113LeftSum(n1));
            Console.WriteLine("GetRGR115LeftSum:\n" + MyFrac.GetRGR115LeftSum(n2));
            Console.ReadKey();
        }
    }
}
