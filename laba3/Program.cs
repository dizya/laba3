using System;

namespace laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Для вывода инфорамции о танке нажмите \"1\" \nЕсли хотите выйти из программы нажмите \"2\"");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Info();
                }
                if (a == 2)
                {
                    break;
                }
            }
        }
        private static void Info()
        {
            while (true)
            {
                Tiger tiger = new Tiger();
                Console.WriteLine(tiger.Info());
                Console.WriteLine("Нажмите \"1\" чтобы прочесть информацию с Википедии \nЕсли хотите выйти из программы нажмите \"2\"");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 1)
                {
                    Console.WriteLine(Tiger.Description());
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
