using System;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            Console.WriteLine("Введите начало диапазона: ");
            int arrayBegin = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона: ");
            int arrayEnd = int.Parse(Console.ReadLine());

            if (arrayBegin < 0 && arrayEnd > 0)
            {
                arraySize = -arrayBegin + arrayEnd;
                ++arraySize;
            }else
            {
                arraySize = arrayEnd - arrayBegin;
                arraySize++;
            }


            var someArray = new RangeOfArray(arraySize);
            someArray.First = arrayBegin;
            someArray.Last = arrayEnd;

            for (int i= someArray.First; i <= someArray.Last; i++)
            {
                Console.Write("Введите значение массива: ");
                someArray[i]= Console.ReadLine();
            }

            for (int i = someArray.First; i <= someArray.Last; i++)
            {
                Console.Write($"{someArray[i]}  ");
            }

           

        }
    }
}
