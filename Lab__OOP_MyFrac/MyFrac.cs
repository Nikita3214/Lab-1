using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__OOP_MyFrac
{
    class MyFrac
    {
        long a; 
        long b;
        public MyFrac(long a_, long b_)
        {
            long nsd = AlgEuclid(Math.Abs(a_), Math.Abs(b_)); 
            a = a_ / nsd;
            b = b_ / nsd;
            if (a < 0 && b < 0)
            {
                a = -a;
                b = -b;
            }
            else if (b < 0)
            {
                a = -a;
                b = -b;
            }
        }
        private long AlgEuclid(long a, long b)            
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return Math.Max(a, b);
        }
        public override string ToString()              //Формує рядкове подання дробу, у вигляді, наприклад "17/7".
        {
            return a + "/" + b;
        }
        public  string ToStringWithIntegerPart()          //рядковее подання дробу з виділенням цілої частини.
        {
            if (a > 0)
                return "(" + a / b + " + " + a % b + "/" + b + ")"; 
            else
            {
                return "-(" + a / b + " + " + -a % b + "/" + b + ")";
            }
        }
        public double DoubleValue()                      //формує дійсне значення дробу.
        {
            return 1.0 * a / b;
        }
        public static MyFrac operator +(MyFrac f1, MyFrac f2)  //обраховує суму дробів.
        {
            return new MyFrac(f1.a * f2.b + f1.b * f2.a, f1.b * f2.b);
        }

        public static MyFrac operator -(MyFrac f1, MyFrac f2)   //обраховує різницю дробів.
        {
            return new MyFrac(f1.a * f2.b - f1.b * f2.a, f1.b * f2.b);
        }

        public static MyFrac operator *(MyFrac f1, MyFrac f2)    //обраховує множення дробів.
        {
            return new MyFrac(f1.a * f2.a, f1.b * f2.b);
        }

        public static MyFrac operator /(MyFrac f1, MyFrac f2)   //обраховує ділення дробів.
        {
            return new MyFrac(f1.a * f2.b, f1.b * f2.a);
        }

        static public MyFrac GetRGR113LeftSum(long n)           
        {
            MyFrac ans = new MyFrac(1, (2 * 1 - 1) * (2 * 1 + 1));
            for (int i = 2; i <= n; i++)
            { ans += new MyFrac(1, (2 * i - 1) * (2 * i + 1)); }
            return ans;
        }
  
        static public MyFrac GetRGR115LeftSum(long n)         
        {
            MyFrac ans = new MyFrac(1, 1);
            for (int i = 2; i <= n; i++)
            { ans *= new MyFrac(1, 1) - new MyFrac(1, (i * i)); }
            return ans;
        }
    }
}