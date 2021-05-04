using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    class FileLogger : ILogger
    {
        private StreamWriter writer; //stream writer 파일을 쓰면서 작업
        public FileLogger(string path)
        {
            writer = File.CreateText(path); // 파일 만들기
            writer.AutoFlush = true; // 자동으로 데이터 내림
        }

        public void writelog(string message)
        {
            writer.WriteLine($"Filelog {DateTime.Now}\t>>>>> {message}");
        }
    }
}
