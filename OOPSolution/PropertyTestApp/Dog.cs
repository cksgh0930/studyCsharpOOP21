﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        private int age;
        //private string name;

        public string Name { get; set; } = "멍멍이";//자동구현 프로퍼티
        public string Color { get; set; } = "누런";


        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                {
                    if (value < 0)
                    {
                        this.age = 1;
                    }
                    else if (value > 15)
                    {
                        this.age = 15;
                    }
                    else
                        this.age=Age;
                }
            }
        }

        
        /*public string GetName() { return this.name; }

public void SetName(string name) { this.name = name; }


//값을 사용
public int GetAge() { return this.age; }

//값을 설정
   public void SetAge(int age) 
{ if (age<0)
   { 
       this.age = 1; 
   }
else if (age>15)
   {
       this.age = 15;
   }
else 
   this.age = age; }

//Eat,Sleep,Bark는 생략*/
    }
}
