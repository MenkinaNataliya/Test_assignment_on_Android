using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Тестовое_задание
{


    class Program
    {
        static void Main(string[] args)
        {
            int[] tag = { 2, 3, 4, 5, 9, 10, 11, 12, 16, 17, 18, 19 };

           
            Stopwatch watch = new Stopwatch();
            watch.Start();///////////////////////////////////
                var setList = new SetsSystem(tag);
                setList.Union(1, 4);
                setList.Union(4, 5);
                setList.Union(2, 3);
                setList.Union(2, 6);
                setList.Union(6, 3);
                setList.Union(3, 7);
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        setList.Find(i, j);
                    }
                    for (int j = 0; j < 20; j++)
                    {
                        setList.Union(i, j);
                    }
            }

            watch.Stop();/////////////////////////////////////////
            Console.WriteLine("Время выполнения List : " + watch.ElapsedMilliseconds + "сек.\r\n" );
            watch.Reset();

            watch.Start();
            var setDictionary = new SetsSystemWithDictionary(tag);

            setDictionary.Union(1, 4);
            setDictionary.Union(4, 5);
            setDictionary.Union(2, 3);
            setDictionary.Union(2, 6);
            setDictionary.Union(6, 3);
            setDictionary.Union(3, 7);
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    setDictionary.Find(i, j);
                }
                for (int j = 0; j < 20; j++)
                {
                    setDictionary.Union(i, j);
                }
            }


            watch.Stop();
            Console.WriteLine("Время выполнения  Dictionary: " + watch.ElapsedMilliseconds + "сек.\r\n");
            Console.ReadLine();

        }

       
    }
}
