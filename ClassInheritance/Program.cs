using System;
using ClassInheritance;

class Program
{
    static void Main()
    {
        // создаем массивы разных видов
        HeirArray[] test = new HeirArray[6];
        test[0] = new OneDimensionalArray(10);
        test[1] = new TwoDimensionalArray(5,3);
        test[2] = new StepDimensionalArray(4);
        Console.WriteLine("Ввод массивов пользователем");
        Console.WriteLine("Введите одномерный массив");
        test[3] = new OneDimensionalArray(5,input_mode:true);
        Console.WriteLine("Введите двумерный массив");
        test[4] = new TwoDimensionalArray(2,2,true);
        Console.WriteLine("Введите ступеньчатый массив");
        test[5] = new StepDimensionalArray(2, input_mode:true);
        // вывод массива и среднего
        for (int i = 0; i < test.Length; i++)
        {
            test[i].OutArr();
            Console.WriteLine($"Среднее значение элементов массива равно {test[i].Average()} \n");
        }
    }
}
