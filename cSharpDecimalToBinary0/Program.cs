using System;

namespace cSharpDecimalToBinary0
{
    class Program
    {
        static void Main(string[] args)
        {
            int decNumber, remi = 0,i, mul=0;
            int[] rem = new int[10];
            Console.Write("Enter a number....: ");
            decNumber = int.Parse(Console.ReadLine());

            while(decNumber > 0)
            {
                for(i=0; decNumber>0; i++)
                {
                    rem[i] = decNumber % 2;
                    decNumber = decNumber / 2;

                }
                for (int a=i-1; a>=0; a--)
                {
                    remi = rem[a];
                    mul = mul * 10 + remi;

                }
                Console.WriteLine(mul);

            }
        }
    }
}
