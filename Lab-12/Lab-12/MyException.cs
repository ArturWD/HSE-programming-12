using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    class RangeArrayException : ApplicationException
    {

        // Реализуем стандартные конструкторы,
        public RangeArrayException() : base() { }
        public RangeArrayException(string str) : base(str) { }
        // Переопределяем метод ToStringO для класса RangeArrayException.
        public override string ToString()
        {
            return Message;
        }
    }
}
