using System;

namespace InterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("콘솔로거 사용합니다");

            ILogger logger = new ConsoleLogger();
            logger.Writelog("기본 콘솔 로그입니다.");
            logger.WriteError("에러메시지!!!!!");

            ILogger ClimateLogger = new FileLogger(); // ver 1.0 climatelogger에서
                                                      // ver1.2 file logger로 변경
            ClimateLogger.Writelog("맑음");
            ClimateLogger.WriteError("문제발생!");

            ILogger Logger2 = new ClimateLogger();
            Logger2.Writelog("흐림");
            //Logger2.WriteError("!!!!!!");
        }
    }
}
