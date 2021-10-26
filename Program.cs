using System;

namespace ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            Console.WriteLine(program.AddPositionArrray(1, 2, 3, 4, 5, 6, 7)[1]);

            Console.ReadLine();
           
        }


        private int[] AddPositionArrray( params int [] numbers )
        {
            int[] result = new int[numbers.Length];
            for (int i= 0; i < numbers.Length; i++)
            {
                result[i] = numbers[i] + i;
            }

            return result;
        }
    }
}
