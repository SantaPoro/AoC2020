using System;
using System.Collections.Generic;

namespace AoC1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            string line;
            int numberOne = 0;
            int numberTwo = 0;
            int numberThree = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("input.txt");
            while ((line = file.ReadLine()) != null)
            {
                input.Add(int.Parse(line));
            }
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    for (int k = 0; k < input.Count; k++)
                    {
                        if (input[i] + input[j] + input[k] == 2020)
                        {
                            numberOne = input[i];
                            numberTwo = input[j];
                            numberThree = input[k];
                        }
                    }
                }
            }
            Console.Write(numberTwo + "*" + numberOne + "*" + numberThree + "=" + numberTwo * numberOne * numberThree);
            Console.ReadLine();
        }
    }
}
