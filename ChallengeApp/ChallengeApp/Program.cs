using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 45660028;

        int[] counts = new int[10]; 

        foreach (char digitChar in number.ToString()) 
        {
            int digit = int.Parse(digitChar.ToString()); 

            counts[digit]++; 
        }

        
        for (int i = 0; i < counts.Length; i++)
        {
            Console.WriteLine("Cyfra {0}: {1} wystąpień", i, counts[i]);
        }
    }
}

