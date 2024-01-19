/*1.- Menú matemàtic
Fer un menú amb 9 opcions (8 + q per sortir). Cada opció del menú cridarà a una acció Maxim,
Mcd, Mcm, Factorial, Combinatori, MostrarDivisorMajor, EsPrimer, NPrimersPrimers que
demanarà les entrades validades, farà els càlculs, i mostrarà el resultat. Les entrades hauran de
ser validades per algunes de les funcions de validació. Cal presentar un projecte únic amb totes
les funcions i accions proposades a més a més del programa principal que implementa el
menú.*/

using System.Threading.Channels;

namespace Menu_Emma_Joaquim
{
    class Program
    {
        static ConsoleColor colorMenu = ConsoleColor.Green;

        //dissabte a les 23:59

        //MAIN:Fem la crida de les altres funcions 
        static void Main(string[] args)
        {
            string R = "";
            do
                Menu(R);
            while (R != "0");
        }

        static string Menu(string R)
        {
            //Crear un menu. Et te que tornar el numero que has posat en el menu per saber quan el programa pot parar (quan poses 0).
            Console.Clear();
            Console.WriteLine("MENÚ D'OPCIONS MATEMÀTIQUES");
            Console.WriteLine("\n" +
                "\n 1.-MAXIM" +
                "\n 2.-MCD" +
                "\n 3.-MCM" +
                "\n 4.-FACTORIAL" +
                "\n 5.-COMBINATORI" +
                "\n 6.-MOSTRAR DIVISOR MAJOR" +
                "\n 7.-ES PRIMER" +
                "\n 8.-NPRIMERS PRIMERS" +
                "\n 0.-TANCAR PROGRAMA \n");
            Console.Write("Selecciona la opció que desitja: ");
            R = Console.ReadLine();
            Console.Clear();
            int num, num1, num2;
            bool resultat;
            switch (R)
            {
                case "1":
                    num1 = DemanarValors();
                    num2 = DemanarValors();
                    num=Maxim(num1, num2);
                    R = "El màxim és: " + num;
                    Timer(R);
                    break;
                case "2":
                    num1=DemanarValors();
                    num2=DemanarValors();
                    num = MCD(num1, num2);
                    R = "El maxim comú divisor de " + num1 + " i " + num2 + " és: " + num; 
                    Timer(R);
                    break;
                case "3":
                    num1 = DemanarValors();
                    num2 = DemanarValors();
                    num = MCM(num1,num2);
                    R = "El minim comú múltiple de " + num1 + " i " + num2 + " és: " + num;
                    Timer(R);
                    break;
                case "4":
                    num1 = DemanarValors();
                    num2 = DemanarValors();
                    Factorial();
                    Timer(R);
                    break;
                case "5":
                    num1 = DemanarValors();
                    num2 = DemanarValors();
                    Combinatori();
                    Timer(R);
                    break;
                case "6":
                    num1 = DemanarValors();
                    num = MostrarDivisorMajor(num1);
                    R = "El divisor major és: " + num;
                    Timer(R);
                    break;
                case "7":
                    num1 = DemanarValors();
                    resultat = EsPrimer(num1);
                    if (resultat == true)
                        R = "";
                    else if (resultat == false)
                        R = "no ";
                    R = "El numero " + R +"és primer.";
                    Timer(R);
                    break;
                case "8":
                    num1 = DemanarValors();
                    num2 = DemanarValors();
                    NPrimersPrimers();
                    Timer(R);
                    break;
                case "0":
                    Console.WriteLine("Presiona la 'q' per a confirmar.");
                    char lletra='0';
                    resultat = Sortida(lletra);
                    if (resultat == true)
                    {
                        R = "Estas sortint del menú d'operacions";
                        Timer(R);
                        R = "0";
                        if (R == "0")
                            return R;
                    }
                    break;
                default:
                    R="Introdueix una opció vàlida,sisplau";
                    Timer(R);
                    break;
            }
            Console.ReadKey();
            return R;
        }

        //Maxim
        static int DemanarValors(int num)
        {
            Console.Write("Introdueix un valor: ");
            num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        static void Timer(string R)
        {
            //temp 3-5 segons
            Console.WriteLine(R);
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
            else if (num1 == num2)
            {
                num = num1;
            }
            return num;
        }
        //Mcd
        static int MCD(int num1, int num2)
        {
            int mcd = 0;
            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                    mcd = i;
            }
            return mcd;
        }
        //Mcm
        static int MCM(int num1, int num2)
        {
            int multiple, mcm;
            mcm = num1 * num2;
            for (multiple = num1 * num2; multiple > num1; multiple--)
            {
                if (mcm % multiple == 0)
                    mcm = multiple;
            }
            return mcm;
        }
        //Factorial
        //Aquesta es la més correcta
        static int Factorial(int num)
        {

            int res = 1;
            for (int i = 1; i <= num; i++)
                res *= i;
            return res;
        }
        /*
        static double Factorial(double num)
        {

            int res = 1;
            for (int i = 1; i <= num; i++)
                res *= i;
            return res;
        }
        */


        //Combinatori
        //COMBINATORI FACTORIAL
        static double Combinatori(int n, int m)
        {
            double resultat;
            resultat = Factorial(n) / (Factorial(m)) / Factorial(n - m);
            return resultat;
        }
        //MostrarDivisorMajor
        static int MostrarDivisorMajor(int num)
            {
            int i;
                for (i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0 && i > num / 2)
                    {
                      Console.Write(i);
                    }
                
                }
            return (i);
            }
        }

    }
    //EsPrimer
    static bool EsPrimer(int num)
        {
            int nombreDivisors = 0;
            bool resultat;
            //Fer algorisme
            //Demanar valors de sortida
            for (int i = 1; i <= num / 2 && nombreDivisors == 0; i++)
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
                resultat = true;
            }
            else
            {
                Console.WriteLine("No es primer");
                resultat = false;
            }
            return resultat;
        }
        //NPrimersPrimers
        static double NPrimersPrimers(int n, int m)
        {
        }

        static bool Sortida(char q)
        {
            q = Convert.ToChar(Console.ReadLine());
            if (q == 'q' || q == 'Q')
                return true;
            else
                Console.WriteLine("Cancelat.");
            return false;
        }
    }
}