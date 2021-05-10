using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = @"C:\Test\Help\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath, FileMode.Open));

            while (sr.EndOfStream==false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            
            sr.Close();
            //텍스트 파일 읽어오는 부분
            Console.WriteLine("파일 읽기 완료");
            string writePath = @"C:\Test\Help\KCH.txt";
            StreamWriter sw = new StreamWriter(new FileStream(writePath, FileMode.Create));

            sw.Write("hello, world");
            sw.Write("안녕하세여");
            sw.Write(3.141592f);
            sw.Close();

            Console.WriteLine("파일 작성을 완료");
        }
    }
}
