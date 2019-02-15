using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        // создаем функцию, которая проверяет является ли число простым или нет
        public static bool Ex(int a)
        {
            int k = 0; //создаем новую переменную, чтобы посчитать количество делителей числа
            for (int j = 1; j <= a; j++) //пробегаемся от 1 до самого числа, чтобы найти делителей данного числа
            {
                if (a % j == 0)
                {
                    k++; //если число делится без остатков, то увеличиваем переменную k на 1
                }
            }
            if (k == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // создаем функцию, чтобы прочесть числа из файла
        public static string Read()
        {
            StreamReader sr = new StreamReader("input.txt");
            string s = sr.ReadToEnd();
            sr.Close();
            return s;
        }

        static void Main(string[] args)
        {
            String s = Read();
            string[] arr = s.Split();
            // выводим все простые числа в другом файле
            StreamWriter sw = new StreamWriter("output.txt");
            for (int i = 0; i < arr.Length; i++)
            {
                if (Ex(int.Parse(arr[i])) == true)
                {
                    sw.Write(arr[i] + " ");
                }
            }
            sw.Close();
        }
    }
}