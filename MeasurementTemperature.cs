using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
   public class MeasurementTemperature : Pogoda 
    {
        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        private double temperature;
        public double Temperature
        { 
             get { return temperature; }
             set { temperature = value; }
        }

        private string comment;
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public MeasurementTemperature()
        {
            date = "00.00.0000";
            temperature = 0;
            comment = "Unknow";
        }
        public MeasurementTemperature(string date1, double temperature1, string comment1)
        {
            this.date = date1;
            this.temperature = temperature1;
            this.comment = comment1;
        }
        public void Input(MeasurementTemperature[] arr)  //Метод для вводу даних в масив об'єктів
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                Console.WriteLine("\tВвід " + (i + 1) + " записа");
                arr[i] = new MeasurementTemperature();
                Console.Write("Введіть дату:\t");
                arr[i].date = Console.ReadLine();
                Console.Write("\nВведіть температуру:\t");
                arr[i].temperature = double.Parse(Console.ReadLine());
                Console.Write("\nВведіть коментар:\t");
                arr[i].comment = Console.ReadLine();
                Console.WriteLine("\n");
            }
        }  
        public MeasurementTemperature Output(MeasurementTemperature[] arr)  //Метод для виводу даних з масива об'єктів
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("######################################################");
                Console.WriteLine("\tВивід " + (i + 1) + "записа");
                Console.WriteLine("Дата: " + arr[i].date + "\nТемпература: " + arr[i].temperature + "\nКоментарій: " + arr[i].comment);
                Console.WriteLine("\n");
            }
            return this;
        } 
        public double MinTemperature(MeasurementTemperature[] arr) //Метод для знаходження мынымальноъ температури
        {
            double minTemperature = arr[0].temperature;
            for (int i = 1;i < arr.Length;i++)
            {
                if(arr[i].temperature < minTemperature)
                {
                    minTemperature = arr[i].temperature;
                }               
             }

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].temperature == minTemperature)
                {
                    Console.WriteLine("\n\n\tДень з мінімальною температурою:\nДата:\t" +arr[i].date + "\nТемпература:\t" + arr[i].temperature + "\nКоментар:\t" + arr[i].comment );
                }
            }
            return minTemperature;
        } //Вимір з мінімальною температурою
        public void MaxCountWordInTheComment(MeasurementTemperature[] arr) //Метод для підрахування кількості слів в масиві рядків
        {
            int[] CountWord = new int[arr.Length];
            string[] str;
            for (int i = 0;i < arr.Length;i++)
            {
                
                CountWord[i] = 0;
                string text = arr[i].comment;              
                str = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                CountWord[i] = str.Length;

            }
            var maxCount = CountWord.Max();
           var result =  Array.IndexOf(CountWord, maxCount);
            for (int i = result; i < arr.Length; i++)
            {
                if (arr[i] == arr[result])
                {
                    Console.WriteLine("\n\tМаксимальна кількість слів в коментарі знаходиться в " + (i) + " елементі масива\n");
                    Console.Write("Дата:\t" + arr[i].date + "\nТемпература:\t" + arr[i].temperature + "\nКоментар:\t" + arr[i].comment + $"        Кількість слів: ({maxCount})"  + "\n");
                }
            }
            
        }
    }

}
