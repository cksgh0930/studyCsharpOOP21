using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작!");

            int[] array = new int[5];
            for (int i = 0; i<=5; i++)
            {
                try
                {
                    array[i] = (i + 1); //1,2,3,4,5
                }
                catch (Exception ex)
                {

                    
                    Console.WriteLine($"문제발생 : {ex.Message} 관리자 문의 요망: Main(16~)");

                }
                
            }

            Console.WriteLine("다른 로직 수행");
            //...
            int[] list = { 107, 108, 109 };
            try
            {
                string message = null;
                Console.WriteLine(message.Length);

                var result = list[1] / 0;
                for (int i = 0; i<5;i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine($"예외발생 : {ex.Message}");
                //index out of range 예외시 다른일 처리
                Console.WriteLine("IndexOutOfRangeException 이후 처리!");
            }

            catch ( DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                
                Console.WriteLine("DivideByZeroException 이후 처리!");
            }

            catch(NullReferenceException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine($"입력 다시 부탁드립니다.");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            Console.WriteLine("프로그램 종료!");//
        }
    }
}
