using System;
using System.Diagnostics;
namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            //Создадим коллекции
            Console.WriteLine("Количество элементов");
            int count = Convert.ToInt32(Console.ReadLine());
            var collections = new TestCollections( count );
            // Создадим несуществующие оюъекты для тестов
            var bird = new Bird("Co-Co", 2, 34);
            var animal = bird.BaseAnimal;


            Animal first = (Animal)collections.Collection_1_1[0].Clone();
            Animal last = (Animal)collections.Collection_1_1[collections.Collection_1_1.Count - 1].Clone();
            Animal middle = (Animal)collections.Collection_1_1[collections.Collection_1_1.Count / 2].Clone();

            string firstString = collections.Collection_1_2[0];
            string lastString = collections.Collection_1_2[collections.Collection_1_2.Count - 1];
            string middleString = collections.Collection_1_2[collections.Collection_1_2.Count / 2];
            {
                // Время 1
                //искомые элементы
                Stopwatch sw = new Stopwatch();
                sw.Start();
                
                bool fc = collections.Collection_1_1.Contains(first);
                bool lc = collections.Collection_1_1.Contains(last);
                bool mc = collections.Collection_1_1.Contains(middle);
                bool nc = collections.Collection_1_1.Contains(animal);
                sw.Stop();
                Console.WriteLine("Время коллекции 1-1: " + (sw.ElapsedTicks).ToString() + "  тиков");
            }
            {
                // Время 2
                //искомые элементы
                Stopwatch sw = new Stopwatch();
                sw.Start();

                bool fc = collections.Collection_1_2.Contains(firstString);
                bool lc = collections.Collection_1_2.Contains(lastString);
                bool mc = collections.Collection_1_2.Contains(middleString);
                bool nc = collections.Collection_1_2.Contains(animal.ToString());

                sw.Stop();
                Console.WriteLine("Время коллекции 1-2: " + (sw.ElapsedTicks).ToString() + "  тиков");
            }

            {
                // Время 3
                //искомые элементы
                Stopwatch sw = new Stopwatch();
                sw.Start();
                
                bool fc = collections.Collection_2_1.ContainsKey(first);
                bool lc = collections.Collection_2_1.ContainsKey(last);
                bool mc = collections.Collection_2_1.ContainsKey(middle);
                bool nc = collections.Collection_2_1.ContainsKey(animal);
                sw.Stop();
                Console.Write("Время коллекции 2-1 по ключу: " + (sw.ElapsedTicks).ToString() + "  тиков");
            }

            



            Console.ReadKey();
        }
    }
}
