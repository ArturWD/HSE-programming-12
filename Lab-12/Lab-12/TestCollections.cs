using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    class TestCollections
    {
        private List<Animal> collection_1_1 = new List<Animal>();
        private List<string> collection_1_2 =new List<string>();
        private Dictionary<Animal, Bird> collection_2_1 = new Dictionary<Animal, Bird>();
        private Dictionary<string, Bird> collection_2_2 = new Dictionary<string, Bird>();

        public TestCollections(int count)
        {
            if (count < 3) throw new RangeArrayException("Слишком мало элементов в массиве!");
            for (int i = 0; i < count; i++)
            {
                Bird value = GetValue(i);
                // получаем родителя через свойство дочернего класса
                var key = value.BaseAnimal;
                Collection_1_1.Add( key);
                Collection_1_2.Add( key.ToString());
                Collection_2_1.Add( key, value);
                Collection_2_2.Add( key.ToString(), value);
            }
        }
        // создание уникального объекта
        private static Bird GetValue(int key)
        {
            return new Bird("Bird_№_"+key.ToString(), key+10, key+10);
        }
        public Dictionary<string, Bird> Collection_2_2
        {
            get { return collection_2_2; }
            set { collection_2_2 = value; }
        }

        public Dictionary<Animal, Bird> Collection_2_1
        {
            get { return collection_2_1; }
            set { collection_2_1 = value; }
        }

        public List<string> Collection_1_2
        {
            get { return collection_1_2; }
            set { collection_1_2 = value; }
        }

        public List<Animal> Collection_1_1
        {
            get { return collection_1_1; }
            set { collection_1_1 = value; }
        }

        public void Add(Bird bird)
        {
            collection_1_1.Add(bird.BaseAnimal);
            collection_1_2.Add((bird.BaseAnimal).ToString());
            collection_2_1.Add(bird.BaseAnimal, bird);
            collection_2_2.Add((bird.BaseAnimal).ToString(), bird);
        }
        public void Remove(Bird bird)
        {
            collection_1_1.Remove(bird.BaseAnimal);
            collection_1_2.Remove((bird.BaseAnimal).ToString());
            collection_2_1.Remove(bird.BaseAnimal);
            collection_2_2.Remove((bird.BaseAnimal).ToString());
        }
    }
}
