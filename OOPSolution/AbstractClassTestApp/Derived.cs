using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTestApp
{
    class Derived : AbstractBase
    {
        public override void AbstractMethod() //overrid에서 다시 재정의
        {
            Console.WriteLine("Derived.AbstractMethod() 실행");
            base.PrivateMethod();
        }
    }
}
