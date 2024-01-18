namespace Proves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string R;
            int num1, num2, num;
            num1 = 4;
            num2 = 5;
            num= Maxim(num1, num2);
            R = "El màxim és: " + num;
            Timer(R);
        }
        static int Maxim(int num1, int num2)
        {
            int num = 0;
            if (num1 > num2)
            {
                num = num1;
            }
            else if (num2 > num1)
            {
                num = num2;
            }
            return num;
        }
        static void Timer(string R)
        {
            //temp 3-5 segons
            Console.WriteLine(R);
        }
    }
}