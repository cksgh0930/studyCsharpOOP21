using System;

namespace DelegateChainApp
{
    delegate int Calculate(int a, int b); // 계산기 대리자를 선언
    class Program
    {
        static  void Main(string[] args)
        {
            

            Calculate calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine($"a+b={calc(3, 5)}");
        }
        /*static void Main(string[] args)
        {
            FireStation station = new FireStation();
            ThereIsAFire fireHouse = new ThereIsAFire(station.Call119);
            fireHouse += new ThereIsAFire(station.ShotOut);
            fireHouse += new ThereIsAFire(station.Escape);
            //대리자 실행
            fireHouse("우리집");

            ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
            fireWoorim += new ThereIsAFire(station.Escape);
            //대리자 실행
            fireWoorim("우림 라이온 벨리");
        }*/
    }
}
