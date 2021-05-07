using System;

namespace DelegateTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //일반적 호출
            Caculator calc = new Caculator();
            Console.WriteLine($"3+5={calc.Plus(3, 5)}");
            Console.WriteLine($"3/5={calc.Divide(3, 5)}");

            //대리자 호출
            CalcDelegate callback;
            callback = new CalcDelegate(calc.Plus);
            Console.WriteLine($"3+5={callback(3, 5)}");
            callback = new CalcDelegate(calc.Multiple);
            Console.WriteLine($"3*5={callback(3, 5)}");

        }
    }
}
