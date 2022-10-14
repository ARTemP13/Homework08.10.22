using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;


namespace Tumakov08
{
    internal class Program
    {
        static void SrTemp(int[,] arr)
        {
            Dictionary<string, int> month = new Dictionary<string, int>();
            int[] sum = new int[12];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    sum[i] += arr[i, j] / 30;
                }

            }

            int x;
            for (int g = 0; g < 12; g++)
            {
                for (int i = g + 1; i < 12; i++)
                {

                    if (sum[g] > sum[i])
                    {
                        x = sum[g];
                        sum[g] = sum[i];
                        sum[i] = x;
                    }
                }
            }
            month.Add("Январь", sum[0]);
            month.Add("Февраль", sum[1]);
            month.Add("Март", sum[2]);
            month.Add("Апрель", sum[3]);
            month.Add("Май", sum[4]);
            month.Add("Июнь", sum[5]);
            month.Add("Июль", sum[6]);
            month.Add("Август", sum[7]);
            month.Add("Сентябрь", sum[8]);
            month.Add("Октябрь", sum[9]);
            month.Add("Ноябрь", sum[10]);
            month.Add("Декабрь", sum[11]);

            foreach (var i in month)
            {
                Console.WriteLine(i);
            }

        }


        static void Mat(int m, int n, int n1, int m1)
        {
            int[,] matrix1 = new int[n, m];
            int[,] matrix2 = new int[n1, m1];
            int[,] matrix3 = new int[n, m];
            Console.WriteLine("Введите 1 матрицу");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n");

            }
            Console.WriteLine("Введите 2 матрицу");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                        matrix3[i, j] += matrix1[i, j] * matrix2[i, j];
                        Console.WriteLine(matrix3[i, j]);
                }
            }



        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6.1");
            List<string> list = new List<string>();
            string path = " C:/Users/apers/OneDrive/Рабочий стол/C#.txt ";
            StreamReader f = new StreamReader(path);
            while (!f.EndOfStream)
            {
                string s = f.ReadLine();
                list.Add(s);
            }
            f.Close();
            int gl = 0;
            int sg = 0;

            foreach (string i in list)
            {
                
                for (int j = 0; j < i.Length; j++)
                {
                    if (i[j] == 'а' || i[j] == 'о' || i[j] == 'у' || i[j] == 'ы' || i[j] == 'э' || i[j] == 'е' || i[j] == 'ё' || i[j] == 'и' || i[j] == 'ю' || i[j] == 'я' || i[j] == 'А' || i[j] == 'О' || i[j] == 'У' || i[j] == 'Ы' || i[j] == 'Э' || i[j] == 'Е' || i[j] == 'Ё' || i[j] == 'И' || i[j] == 'Ю' || i[j] == 'Я')
                    {
                        gl++;
                    }
                    else if (i[j] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        sg++;
                    }
                }
                Console.WriteLine($"Согласных = {sg}, Гласных = {gl}");
            }
            Console.ReadKey();










            Console.WriteLine("Задание 6.2");
            Console.WriteLine("Введите кол-во строчек и столбцов в 1 матрице: ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во строчек и столбцов во 2 матрице: ");
            int m1 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            Mat(m, n, m1, n1);
            Console.ReadKey();
            



            Console.WriteLine("Задание 6.3");
            Random random = new Random();
            int[,] temp = new int[12, 30];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temp[i, j] = random.Next(-40, 40);
                }
            }
            SrTemp(temp);
            Console.ReadKey();
        }
    }
}
