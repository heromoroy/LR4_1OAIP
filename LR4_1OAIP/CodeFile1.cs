using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LR4_1OAIP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 31
            Console.WriteLine("Файл input находится в @/LR4_1OAIP/LR4_1OAIP/bin/Debug");
            Console.WriteLine("Файл output.txt находится в @/LR4_1OAIP/LR4_1OAIP/bin/Debug");
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
            int N = Convert.ToInt32(Console.ReadLine());
            string str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            int[] mas = new int[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = Convert.ToInt32(str_elem[i]);
            }
            // максимальный элемент кратный 10 (если нет, то 1000)
            Console.WriteLine("Задание 1:");
            int t = -100001;
            int t3 = 0;
            for (int p = 0; p <= N-1; p++)
            {
                if (mas[p] > t)
                {
                    if (mas[p] % 10 == 0 || mas[p] % 1000 == 0)
                    {
                        t = mas[p];
                        t3 = p;
                    }
                }
            }
            Console.WriteLine(String.Format("{0}", t));

            // минимальный элемент кратный 7 (если нет, то -1000)
            Console.WriteLine("Задание 2:");
            int t2 = 99999;
            int t3_2 = 0;
            for (int j = 0; j <= N-1; j++)
            {
                if (mas[j] < t2)
                {
                    if (mas[j] % 7 == 0 || mas[j] % -1000 == 0)
                    {
                        t2 = mas[j];
                        t3_2 = j;
                    }
                }
            }
            Console.WriteLine(String.Format("{0}", t2));
            // проверка на последовательность чисел (костылек такой, небольшой, можно было лучше, но можно было не вгонять меня в несуществующие долги, да, бухгалтерия?)
            if (t3_2 < t3)
            {
                int temp = t3;
                t3 = t3_2;
                t3_2 = temp;
            }
            // список  элементов исходного  массива,  лежащих  между  значениями, найденными в задачах 1) и 2)
            Console.WriteLine("Задание 3:");
            for (int k = t3+1; k < t3_2; k++)
            {
                    Console.WriteLine(String.Format("{0} ", mas[k]));
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
            Console.WriteLine();
            Console.WriteLine("Расчеты завершены, нажмите любую кнопку чтобы выйти");
            Console.ReadKey();
        }
    }
}