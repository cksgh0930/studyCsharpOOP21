using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public int Age { get; set; }

        public Cat() { /* Nothing*/}

        public Cat(string name, string color, int age)
        {
            //initialization
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
         public Cat(string name, string color)
        {
            //초기화
            this.Name = name;
            this.Color = color;
            this.Age = 1;
        }
        public Cat(string color, int age)
        {
            this.Color = color;
            this.Age = age;
        }
        public void Meow() { Console.WriteLine("{0} {1}, 야옹!", this.Color, this.Name); }//0에다가 this랑 name이 들어감

        
        public override void Sleep()
        {
            //base.Sleep(); 부모의 Sleep() 실행
            //이후 자식 클래스의 Sleep내용 실행
            Console.WriteLine($"{this.Color}고양이{this.Name}이(가)ZZ잡니다!");
        }

    }
}
