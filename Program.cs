using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;        
using System.Threading.Tasks;
using System.Windows;

namespace LAB3
{

    class Program
    {       
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть кількість записів: ");
            int size = int.Parse(Console.ReadLine());

            Pogoda[]arr = new Pogoda[size];
            Pogoda pogoda = new Pogoda();

            MeasurementTemperature[] arr2 = new MeasurementTemperature[size];
            MeasurementTemperature measurementTemperature = new MeasurementTemperature();

            pogoda.Input(arr);
            pogoda.Output(arr);
            Console.WriteLine("\n\n1 Завдання: Виміри з мінімальною температурою.");
            pogoda.LastWord(arr);
            Console.WriteLine("\n\n\n");
            measurementTemperature.Input(arr2);
            measurementTemperature.Output(arr2);
            Console.WriteLine("2 Завдання: знайти елемент з найбільшою кількістю слів у коментарі до виміру. ");
            measurementTemperature.MinTemperature(arr2);
            Console.WriteLine("3 Завдання: знайти останнє слово коментаря до погоди ");
            measurementTemperature.MaxCountWordInTheComment(arr2);
            

            


        }
    }
}
