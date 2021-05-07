using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTestApp
{
    delegate int CalcDelegate(int a, int b); // 대리자 선언
    class Caculator
    {
        public int Plus(int a, int b) { return a + b; }
        public int Minus(int a, int b) { return a - b; }

        public int Multiple ( int a, int b) { return a * b; }
        public int Divide(int a, int b) { return a / b; }
        
    }
}
