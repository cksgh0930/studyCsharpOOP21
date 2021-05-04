using System;

namespace InterfaceTestApp
{
    class ClimateLogger : ILogger //ver 1.0에서 개발
    {
        public void WriteError(string error)
        {
            throw new NotImplementedException();
        }

        public void Writelog(string weather)
        {
            Console.WriteLine($"날씨로그[{DateTime.Now.ToShortDateString()}] : 현재 날씨 {weather}");
        }
    }
}
