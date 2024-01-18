using System;

namespace proves1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 33;
            int nombreDivisors = 0;
            //Fer algorisme
            //Demanar valors de sortida
            for (int i = 2; i <= num / 2 && nombreDivisors == 0; i++)
            {
                if (num % i == 0)
                {
                    //Donar valors de sortida
                    nombreDivisors++;
                }
            }
            if (nombreDivisors == 0)
            {
                Console.WriteLine("Es primer");
            }
            else
            {
                Console.WriteLine("No es primer");
            }
        }
    }
}