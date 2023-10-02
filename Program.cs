using System.ComponentModel.Design;
using System.Xml;
namespace lol
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("1. Игра: угадай число ");
            Console.WriteLine("2. Таблица умножения ");
            Console.WriteLine("3. Вывод делителей числа ");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите программу:");
            while (true)
            {
                int deistvie = Convert.ToInt32(Console.ReadLine());
                if (deistvie == 1)
                {
                    deistvie1();
                }
                if (deistvie == 2)
                {
                    deistvie2();
                }
                if (deistvie == 3)
                {
                    deistvie3();

                }
                if (deistvie == 4)
                {
                    deistvie4();
                    break;
                }
            }
        }
        static void deistvie1()
        {
            {
                Random rand = new Random();
                int chislo = rand.Next(0, 101);
                while (true)
                {
                    Console.Write("Введите число :");
                    int a = Convert.ToInt32(Console.ReadLine());
                    {
                        if (a > chislo)
                        {
                            Console.WriteLine("меньше надо ");
                        }
                        else if (a < chislo)
                        {
                            Console.WriteLine("больше надо ");
                        }
                        else if (a == chislo)
                        {
                            Console.WriteLine("угадал(а)");
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("1. Игра: угадай число ");
            Console.WriteLine("2. Таблица умножения ");
            Console.WriteLine("3. Вывод делителей числа ");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите программу:");

        }
        static void deistvie2()
        {
            {
                Console.WriteLine("Таблица умножения: ");
                int[,] matrix = new int[10, 10];
                for (int m = 1; m < matrix.GetLength(0); m++)
                {
                    for (int n = 1; n < matrix.GetLength(1); n++)
                    {
                        Console.Write(matrix[m, n] + m * n + "\t");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("1. Игра: угадай число ");
            Console.WriteLine("2. Таблица умножения ");
            Console.WriteLine("3. Вывод делителей числа ");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите программу:");
        }
        static void deistvie3()
        {

            {
                Console.Write("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.WriteLine("\n 1. Игра: угадай число ");
            Console.WriteLine(" 2. Таблица умножения ");
            Console.WriteLine(" 3. Вывод делителей числа ");
            Console.WriteLine(" 4. Выход");
            Console.Write(" Выберите программу:");

        }
        static void deistvie4()
        {
            {
                Console.WriteLine("ты заходи, если че");
            }

        }
    }
}

