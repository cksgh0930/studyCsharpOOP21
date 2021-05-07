using System;

namespace GenericMyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i =0;i<list.Length; i++)
            {
                list[i] = 100;
            }
            for (int i=0; i<list.Length; i++)
            {
                Console.Write($"{list[i]}\t");
            }

            MyList<string> liststring = new MyList<string>();
            for (int i = 0; i < liststring.Length; i++)
            {
                liststring[i] = "Hello"+(i+1);
            }
            for (int i = 0; i < liststring.Length; i++)
            {
                Console.Write($"{liststring[i]}\t");
            }


            MyList<object> listobj = new MyList<object>();

            listobj[0] = 111;
            listobj[1] = 3.14;
                listobj[2] = "Hello";
            for (int i = 0; i < liststring.Length; i++)
            {
                Console.Write($"{listobj[i]}\t");
            }
                


        }
    }
}
