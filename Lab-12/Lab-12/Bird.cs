using System;

namespace Lab_12
{
    // Это производный класс - Птица. Птица - производный класса от животного.
    class Bird:Animal, ICloneable
    {
        // задаём значения по умолчанию для обработки исключений 
        protected int flightDistance = 0;

        //конструктор без параметров
        public Bird():base()
        {
            
        }
        //конструктор с параметрами
        public Bird(string name, double weight, int flightDistance):base(name, weight)
        {
            FlightDistance = flightDistance;
        }

        // получение доступа к полям класса
        public int FlightDistance
        {
            set
            {
                if (value > 0) flightDistance = value;
            }
            get { return flightDistance; }
        }
      

        // переопределённый виртуальный метод
        public override void ShowCreature()
        {
            Console.WriteLine("Это птица. Её зовут {0}. Она может пролететь до {1} километров за раз.", name, flightDistance);
        }


        // реализуем метод интерфейса ICloneable
        public object Clone()
        {
            return new Bird("Clone-"+this.name, this.weight, this.flightDistance);
        }

        // 12 ЛАБОРАТОРНАЯ Ссылка на объект базового классf
 
        public Animal BaseAnimal
        {
            get { return new Animal(name, weight); }
        }

    }
}
