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

            {
                // Время 1
                //искомые элементы
                var first = collections.Collection_1_1[0];
                var last = collections.Collection_1_1[collections.Collection_1_1.Count - 1];
                var middle = collections.Collection_1_1[collections.Collection_1_1.Count / 2];
                Stopwatch sw = new Stopwatch();
                sw.Start();

                collections.Collection_1_1.Contains(first);
                collections.Collection_1_1.Contains(last);
                collections.Collection_1_1.Contains(middle);
                collections.Collection_1_1.Contains(animal);
                sw.Stop();
                Console.WriteLine("Время коллекции 1-1: " + (sw.ElapsedMilliseconds).ToString() + "  мсек");
            }
            //{
            //    // Время 2
            //    //искомые элементы
            //    var first = collections.Collection_1_2[0];
            //    var last = collections.Collection_1_2[collections.Collection_1_2.Count - 1];
            //    var middle = collections.Collection_1_2[collections.Collection_1_2.Count / 2];
            //    Stopwatch sw = new Stopwatch();
            //    sw.Start();

            //    collections.Collection_1_2.Contains(first);
            //    collections.Collection_1_2.Contains(last);
            //    collections.Collection_1_2.Contains(middle);
            //    collections.Collection_1_2.Contains(animal.ToString());

            //    sw.Stop();
            //    Console.WriteLine("Время коллекции 1-2: " + (sw.ElapsedMilliseconds).ToString() + "  мсек");
            //}

            //{
            //    // Время 3
            //    //искомые элементы
            //    Animal first=null, last=null, middle=null;
            //    int index = 0;
            //    foreach (var item in collections.Collection_2_1)
            //    {
            //        if (index == 0) first = item.Key;
            //        if (index == collections.Collection_2_1.Count - 1) last = item.Key;
            //        if (index == collections.Collection_2_1.Count / 2) middle = item.Key;
            //        index++;
            //    }
            //    Stopwatch sw = new Stopwatch();
            //    sw.Start();

            //    bool fc = collections.Collection_2_1.ContainsKey(first);
            //    bool lc = collections.Collection_2_1.ContainsKey(last);
            //    bool mc = collections.Collection_2_1.ContainsKey(middle);
            //    bool nc = collections.Collection_2_1.ContainsKey(animal);

            //    sw.Stop();
            //    Console.Write("Время коллекции 2-1 по ключу: " + (sw.ElapsedMilliseconds).ToString() + "  мсек");
            //}

            //// Время 4
            ////искомые элементы
            //var first = collections.Collection_1_1[0];
            //var last = collections.Collection_1_1[collections.Collection_1_1.Count - 1];
            //var middle = collections.Collection_1_1[collections.Collection_1_1.Count / 2];
            //System.Diagnostics.Stopwatch sw = new Stopwatch();
            //sw.Start();

            //collections.Collection_1_1.Contains(first);
            //collections.Collection_1_1.Contains(last);
            //collections.Collection_1_1.Contains(middle);
            //collections.Collection_1_1.Contains(animal);

            //sw.Stop();
            //Console.Write("Время коллекции 1-1: " + (sw.ElapsedMilliseconds).ToString() + "  мсек");



            Console.ReadKey();
        }
    }
}
