using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Min_Prime_number
{
    class Program
    {
        static bool IsPrime(int x)//проверяем на простоту
        {


            int cnt = 0;
            //находим количество делителей
            for (int i = 1; i <= x; ++i)
            {
                if (x % i == 0)
                {
                    cnt++;
                }
            }
            if (cnt == 2) return true;
            return false;
        }
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"C:\PT\input.txt");// открываем для чтения данных файл
            string[] k = r.ReadLine().Split(' ');// читаем данные в виде строки и делим его на отдельные строки и храним его в виде массива
            int _min = int.MaxValue;// даем значение минимуму
            foreach (string i in k) // пробегаемся по каждому элементу массива
            {
                int a = int.Parse(i);// превращаем строку в число
                if (IsPrime(a))// проверяем на простоту
                {
                    _min = Math.Min(_min, a);// обновляем каждый раз минимум
                }
            }
            StreamWriter o = new StreamWriter(@"C:\PT\output.txt");// создать или если существует открыть файл для вывода минимального простого числа
            if (_min != int.MaxValue)
            {
                o.WriteLine(_min);
            }
            else
                o.WriteLine("An array is prime-empty");
           o.Flush(); // метод, который записывает данные в файл 
        }
    }
}
