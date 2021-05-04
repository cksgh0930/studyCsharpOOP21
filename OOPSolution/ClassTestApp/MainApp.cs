using System;

namespace ClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("고양이 객체 생성");

            Cat kitty = new Cat();//객체를 생성 ->인스턴스

            kitty.Name = "키티";
                kitty.Age = 3;
            kitty.Color = "하얀색";
            kitty.Meow();

            Cat nero = new()
            {
                Name = "네로",
                Age = 12,
                Color = "검은"
            };
            nero.Meow();

            Cat mimi = new Cat("미미", "노랑", 3);//이걸 더 자주 사용
            mimi.Meow();

            Cat coco = new("코코", "얼룩이");
            coco.Age = 2;
            coco.Meow();

            Cat noname = new Cat("은색", 10);
            noname.Name = "야옹이";
            noname.Meow();


            var list = (First : "Cat",Second : "Dog",Third :  "Pig",55);
            Console.Write($"튜플 첫번째 : {list.First}");
            Console.Write($"튜플 두번째 : {list.Item2}");
            Console.Write($"튜플 세번째 : {list.Item3}");
            Console.Write($"튜플 네번째 : {list.Item4}");

        }
    }
}
