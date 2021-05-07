using System;
using System.Collections.Generic;

namespace GenericCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("일반화 컬렉션 테스트 =====");

            List<int> List = new List<int>();
            for (int i =1; i<=100; i++)
            {
                List.Add(i);
            }
            var sum = 0;
            foreach (var item in List)
            {
                sum += item;
            }
            Console.WriteLine($"1~100의 합 = {sum}");
            List.RemoveAt(10);
            List.RemoveAt(20);
            List.RemoveAt(30);
            List.RemoveAt(40);
            List.RemoveAt(50);
            List.Insert(11, 5000);
            var index60 = List.IndexOf(60);

            foreach (var item in List)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Queue<string> lines = new Queue<string>();
            lines.Enqueue("첫번째 손님");
            lines.Enqueue("두번째 손님");
            lines.Enqueue("세번째 손님");
            lines.Enqueue("네번째 손님");
            lines.Enqueue("다섯번째 손님");

            while ( lines.Count>0)
            {
                Console.WriteLine(lines.Dequeue());
            }

            //중요!!
            Dictionary<string, int> dics = new Dictionary<string, int>();
            dics["하나"] = 1;
            dics["둘"] = 2;
            dics["셋"] = 3;
            dics["넷"] = 4;
            dics["다섯"] = 5;

            Console.WriteLine(dics["하나"]);
            Console.WriteLine(dics["다섯"]);
           
            foreach (var item in dics)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
    }
}
