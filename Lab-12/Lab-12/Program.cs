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
            string animalString = animal.ToString();

            Animal first = (Animal)collections.Collection_1_1[0].Clone();
            Animal last = (Animal)collections.Collection_1_1[collections.Collection_1_1.Count - 1].Clone();
            Animal middle = (Animal)collections.Collection_1_1[collections.Collection_1_1.Count / 2].Clone();

            string firstString = collections.Collection_1_2[0];
            string lastString = collections.Collection_1_2[collections.Collection_1_2.Count - 1];
            string middleString = collections.Collection_1_2[collections.Collection_1_2.Count / 2];
            Console.WriteLine("Тип коллекции                         Первый    Последний    Средний    Несуществующий");
            {
                // Время 1
                Stopwatch sw = new Stopwatch();
                sw.Restart();                
                bool fc = collections.Collection_1_1.Contains(first);
                sw.Stop();
                int searchF = (int)sw.ElapsedTicks;

                sw.Restart();
                bool lc = collections.Collection_1_1.Contains(last);
                sw.Stop();
                int searchL = (int)sw.ElapsedTicks;

                sw.Restart();
                bool mc = collections.Collection_1_1.Contains(middle);
                sw.Stop();
                int searchM = (int)sw.ElapsedTicks;

                sw.Restart();
                bool nc = collections.Collection_1_1.Contains(animal);
                sw.Stop();
                int searchN = (int)sw.ElapsedTicks;

                Console.WriteLine("List<Animal>                           "+searchF+"       "+searchL+"         "+searchM+"       "+searchN);
            }
            {
                // Время 2
                Stopwatch sw = new Stopwatch();
                sw.Restart();
                bool fc = collections.Collection_1_2.Contains(firstString);
                sw.Stop();
                int searchF = (int)sw.ElapsedTicks;

                sw.Restart();
                bool lc = collections.Collection_1_2.Contains(lastString);
                sw.Stop();
                int searchL = (int)sw.ElapsedTicks;

                sw.Restart();
                bool mc = collections.Collection_1_2.Contains(middleString);
                sw.Stop();
                int searchM = (int)sw.ElapsedTicks;

                sw.Restart();
                bool nc = collections.Collection_1_2.Contains(animalString);
                sw.Stop();
                int searchN = (int)sw.ElapsedTicks;

                Console.WriteLine("List<string>                           " + searchF + "        " + searchL + "         " + searchM + "       " + searchN);
            }

            {
                // Время 3
                Stopwatch sw = new Stopwatch();
                sw.Restart();
                bool fc = collections.Collection_2_1.ContainsKey(first);
                sw.Stop();
                int searchF = (int)sw.ElapsedTicks;

                sw.Restart();
                bool lc = collections.Collection_2_1.ContainsKey(last);
                sw.Stop();
                int searchL = (int)sw.ElapsedTicks;

                sw.Restart();
                bool mc = collections.Collection_2_1.ContainsKey(middle);
                sw.Stop();
                int searchM = (int)sw.ElapsedTicks;

                sw.Restart();
                bool nc = collections.Collection_2_1.ContainsKey(animal);
                sw.Stop();
                int searchN = (int)sw.ElapsedTicks;

                Console.WriteLine("Dictionary<Animal,Bird> - Key          " + searchF + "         " + searchL + "            " + searchM + "          " + searchN);
            }
            {
                // Время 4
                Stopwatch sw = new Stopwatch();
                sw.Restart();
                bool fc = collections.Collection_2_2.ContainsKey(firstString);
                sw.Stop();
                int searchF = (int)sw.ElapsedTicks;

                sw.Restart();
                bool lc = collections.Collection_2_2.ContainsKey(lastString);
                sw.Stop();
                int searchL = (int)sw.ElapsedTicks;

                sw.Restart();
                bool mc = collections.Collection_2_2.ContainsKey(middleString);
                sw.Stop();
                int searchM = (int)sw.ElapsedTicks;

                sw.Restart();
                bool nc = collections.Collection_2_2.ContainsKey(animalString);
                sw.Stop();
                int searchN = (int)sw.ElapsedTicks;

                Console.WriteLine("Dictionary<string,Bird> - Key          " + searchF + "        " + searchL + "            " + searchM + "          " + searchN);
            }
            {
                // Время 5
                //искомые элементы
                // Известно, что вес равен дальности полёта
                Bird firstB = new Bird(first.Name, first.Weight, (int)first.Weight);
                Bird lastB = new Bird(last.Name, last.Weight, (int)last.Weight);
                Bird middleB = new Bird(middle.Name, middle.Weight, (int)middle.Weight);
                Stopwatch sw = new Stopwatch();
                sw.Restart();
                bool fc = collections.Collection_2_1.ContainsValue(firstB);
                sw.Stop();
                int searchF = (int)sw.ElapsedTicks;

                sw.Restart();
                bool lc = collections.Collection_2_1.ContainsValue(lastB);
                sw.Stop();
                int searchL = (int)sw.ElapsedTicks;

                sw.Restart();
                bool mc = collections.Collection_2_1.ContainsValue(middleB);
                sw.Stop();
                int searchM = (int)sw.ElapsedTicks;

                sw.Restart();
                bool nc = collections.Collection_2_1.ContainsValue(bird);
                sw.Stop();
                int searchN = (int)sw.ElapsedTicks;

                Console.WriteLine("Dictionary<Animal,Bird> - Value        " + searchF + "      " + searchL + "          " + searchM + "         " + searchN);
            }          

            Console.ReadKey();
        }
    }
}
