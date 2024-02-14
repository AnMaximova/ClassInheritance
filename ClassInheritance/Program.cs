using System;
using ClassInheritance;

class Program
{
    static void Main()
    {
        // создаем массивы разных видов
        HeirArray[] test = new HeirArray[6];
        Console.WriteLine("Ввод размеров массивов, заполнение случайными числами");
        test[0] = new OneDimensionalArray();
        test[1] = new TwoDimensionalArray();
        test[2] = new StepDimensionalArray();
        Console.WriteLine("Ввод массивов пользователем");
        Console.WriteLine("Введите одномерный массив");
        test[3] = new OneDimensionalArray(true);
        Console.WriteLine("Введите двумерный массив");
        test[4] = new TwoDimensionalArray(true);
        Console.WriteLine("Введите ступеньчатый массив");
        test[5] = new StepDimensionalArray(true);
        // вывод массива и среднего
        for (int i = 0; i < test.Length; i++)
        {
            test[i].OutArr();
            Console.WriteLine($"Среднее значение элементов массива равно {test[i].Average()} \n");
        }
    }
}
