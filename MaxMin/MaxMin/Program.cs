using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace MaxMin

{

    class Program

    {

        static void Main(string[] args)

        {



            StreamReader r = new StreamReader(@"C:\PT\input.txt");// открываем для чтения данных файл

            string[] k = r.ReadLine().Split(' ');// читаем данные в виде строки и делим его на отдельные строки и храним его в виде массива




            int _min = int.Parse(k[0]);// даем значение минимуму и максимуму

            int _max = int.Parse(k[0]);

            foreach (string i in k) // пробегаемся по каждому элементу массива

            {

                int l = int.Parse(i);// превращаем каждый элемент в число

                _min = Math.Min(_min, l);// обновляем каждый раз и минимум и максимум

                _max = Math.Max(_max, l);
                
            }



            Console.WriteLine("minimum is {0}, maximum is {1}", _min, _max);// выводим на экран полученные значения

            Console.ReadKey();





        }

    }

}