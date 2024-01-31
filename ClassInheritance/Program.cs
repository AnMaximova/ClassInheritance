using System;
using ClassInheritance;

class Program
{
    static void Main()
    {
        // создаем массивы разных видов
        HeirArray[] test = new HeirArray[3];
        test[0] = new OneDimensionalArray(10);
        test[1] = new TwoDimensionalArray(5, 5);
        test[2] = new StepDimensionalArray(4);
        // вывод массива и среднего
        for (int i = 0; i < test.Length; i++)
        {
            test[i].OutArr();
            Console.WriteLine($"Среднее значение элементов массива равно {test[i].Average()} \n");
        }
    }
}
