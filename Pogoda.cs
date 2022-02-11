using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace LAB3
{
   public  class Pogoda
    {
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private string comment;
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        public Pogoda()
        {
            this.year = 0;
            this.comment = "Unknow";
        }
        public Pogoda(int year1, string comment1)
        {
            year = year1;
            comment = comment1;
        }
        public void Input(Pogoda[] arr) //Метод для заповнення масиву об'єктів
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                Console.WriteLine("\tВвід "+ (i + 1) +" записа");
                arr[i] =  new Pogoda();
                Console.Write("Введіть рік:\t");
                arr[i].year = int.Parse(Console.ReadLine());
                Console.Write("\nВведіть коментар:\t");
                arr[i].comment = Console.ReadLine();
                Console.WriteLine("\n");
            }
        }
        public Pogoda Output(Pogoda[]arr) // Метод для виведення масиву об'єктів
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("#####################################################");
                Console.WriteLine("\tВивід " + (i + 1) + "записа");
                Console.Write("Рік:\t\t" + arr[i].year + "\nКоментарій:\t" + arr[i].comment);
                Console.WriteLine("\n");
            }
            return this;
        }
        public void LastWord(Pogoda[]arr) //Метод для виведення останнього слова з поля "коментар"
        {
            int lastElement = arr.Length -1;
            string[] str;
            string lastWord ;

            for (int i = 0; i <  arr.Length; i++)
            {
                if(arr[i].comment == arr[lastElement].comment)
                {
                    string text = arr[i].comment;
                    str = text.Split(new char[] { ' ' });
                    lastWord = str[str.Length-1];
                    Console.WriteLine("\n\tОстаннє слово:\t" + lastWord);                   
                    Console.WriteLine();
                }
            }
           
        }
    }
}
