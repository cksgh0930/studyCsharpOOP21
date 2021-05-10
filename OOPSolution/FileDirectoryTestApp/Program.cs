using System;
using System.IO;

namespace FileDirectoryTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string path = @"C:\Test\Help\mui\0412"; //verbatim string
            var dirs = Directory.GetDirectories(path);

            foreach (var item in dirs)
            {
                Console.WriteLine(item);
                var dirinfo = new DirectoryInfo(item);
                Console.WriteLine($"{dirinfo.Name}/{dirinfo.Attributes}/{dirinfo.CreationTime}");
            }

            var files = Directory.GetFiles(path);
            foreach (var item in files)
            {
                Console.WriteLine(item);
                var fileInfo = new FileInfo(item);
                Console.WriteLine($"{fileInfo.Name}/{fileInfo.Attributes}/{fileInfo.CreationTime}/{fileInfo.Length}");
            }

            */
            string newPath = @"C:\Test\Help"; //디렉토리, 파일을 생성할 위치
            int dirNum = 0; // 디렉토리 1씩 증가시켜 중복 피하기위한 정수

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "x")
                {
                    break;
                }
                else
                {
                    //파일/폴더 만드는 로직
                    if(input == "file")
                    {
                        var fileName = $"SampleFile_{DateTime.Now.ToString("ff")}.txt";
                        var fullPath = @"{newPath}\{dirName}";
                        File.Create(fullPath);
                    }
                    else if (input == "dir")
                    {
                        //Console.WriteLine("디렉토리 생성");
                        var dirName = "SampleDirectory";
                        var fullPath = @$"{newPath}\{dirName}"; // @"C:\Test\Help"\SampleDirectory
                        if(Directory.Exists(fullPath))
                        {
                            Directory.CreateDirectory(fullPath);
                        }
                        else
                        {
                            dirNum++;
                            fullPath = @$"{newPath}\{dirName}+{dirNum}";
                            Directory.CreateDirectory(fullPath);
                        }
                    }
                    else
                    {
                        Console.WriteLine("file/dir로 값을 입력하세요");
                    }
                }
            }

            Console.WriteLine("프로그램 종료");


        }
    }
}
