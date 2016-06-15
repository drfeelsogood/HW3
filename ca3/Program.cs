using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int[] arrayWithEvenNumber = new int[10];
            int number;
            Random rnd = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                do
                {
                    number = rnd.Next(20);
                } while (myArray.Contains(number));
                myArray[i] = number;
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("Even numbers in array are: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    if (!arrayWithEvenNumber.Contains(myArray[i]))
                    {
                        arrayWithEvenNumber[i] = myArray[i];
                        Console.WriteLine(arrayWithEvenNumber[i]);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
