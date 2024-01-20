/*1.- Menú matemàtic
Fer un menú amb 9 opcions (8 + q per sortir). Cada opció del menú cridarà a una acció Maxim,
Mcd, Mcm, Factorial, Combinatori, MostrarDivisorMajor, EsPrimer, NPrimersPrimers que
demanarà les entrades validades, farà els càlculs, i mostrarà el resultat. Les entrades hauran de
ser validades per algunes de les funcions de validació. Cal presentar un projecte únic amb totes
les funcions i accions proposades a més a més del programa principal que implementa el
menú.*/

using System;
using System.Threading.Channels;

namespace Menu_Emma_Joaquim
{
    class Program
    {
        static ConsoleColor colorMenu = ConsoleColor.Green;
        static ConsoleColor colorCase = ConsoleColor.Cyan;
        //dissabte a les 23:59

        //MAIN:Fem la crida de les altres funcions 
        static void Main(string[] args)
        {
            Console.ForegroundColor = colorMenu;
            string R = "";
            do
                Menu(R);
            while (R != "q");
        }

        static string Menu(string R)
        {
            //Crear un menu. Et te que tornar el numero que has posat en el menu per saber quan el programa pot parar (quan poses 0).
            Console.Clear();
            Console.ForegroundColor = colorMenu;
            Console.WriteLine("*-------------------------------------*");
            Console.WriteLine(" MENÚ D'OPCIONS MATEMÀTIQUES");
            Console.WriteLine("*----------------------------*" +
                "\n ||  1.-MAXIM" +
                "\n ||  2.-MCD" +
                "\n ||  3.-MCM" +
                "\n ||  4.-FACTORIAL" +
                "\n ||  5.-COMBINATORI" +
                "\n ||  6.-MOSTRAR DIVISOR MAJOR" +
                "\n ||  7.-ES PRIMER" +
                "\n ||  8.-NPRIMERS PRIMERS" +
                "\n ||  0.-TANCAR PROGRAMA \n*----------------------------*");
            Console.Write(" Selecciona l'opció que desitja: ");
            R = Console.ReadLine();
            Console.Clear();
            int num, num1, num2;
            bool resultat;
            switch (R)
            {
                case "1":
                    num1 = DemanarValors();
                    num2 = DemanarValors();
                    num = Maxim(num1, num2);
                    R = "El màxim és: " + num;
                    break;
                case "2":
                    num1 = DemanarValors();
                    num2 = DemanarValors();
                    num = MCD(num1, num2);
                    R = "El maxim comú divisor de " + num1 + " i " + num2 + " és: " + num;
                    break;
                case "3":
                    num1 = DemanarValors();
                    num2 = DemanarValors();
                    num = MCM(num1, num2);
                    R = "El minim comú múltiple de " + num1 + " i " + num2 + " és: " + num;
                    break;
                case "4":
                    num1 = DemanarValors();
                    Factorial(num1);
                    break;
                case "5":
                    num1 = DemanarValors();
                    num2 = DemanarValors();
                    Combinatori(num1, num2);
                    break;
                case "6":
                    num1 = DemanarValors();
                    num = MostrarDivisorMajor(num1);
                    R = "El divisor major és: " + num;
                    break;
                case "7":
                    num1 = DemanarValors();
                    resultat = EsPrimer(num1);
                    if (resultat == true)
                        R = "";
                    else if (resultat == false)
                        R = "no ";
                    R = "El numero " + R + "és primer.";
                    break;
                case "8":
                    num1 = DemanarValors();
                    NPrimersPrimers(num1);
                    break;
                case "0":
                    resultat = Sortida();
                    if (resultat == true)
                    {
                        Console.WriteLine("Estas sortint del menú d'operacions");
                        R = "q";
                        if (R == "q")
                            return R;
                    }/*En la prova2 funciona el menú de sortida però no entren els valors en el if. Hem probat a canviar les variables que retornava entre d'altres però
                      * seguia sense funcionar i l'hem deixat com a la prova2 al final.*/
                    break;
                default:
                    R = "Introdueix una opció vàlida,sisplau";
                    break;
            }
            Console.ReadKey();
            return R;
        }
        static int DemanarValors()
        {
            Console.ForegroundColor = colorCase;
            int num;
            Console.Write("Introdueix un valor: ");
            num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        //Màxim
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
        static int Factorial(int num)
        {

            int res = 1;
            for (int i = 1; i <= num; i++)
                res *= i;
            return res;
        }
        //Combinatori
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
        //EsPrimer
        static bool EsPrimer(int num)
        {
            int nombreDivisors = 0;
            bool resultat;
            for (int i = 1; i <= num / 2 && nombreDivisors == 0; i++)
            {
                if (num % i == 0)
                {
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
        static string NPrimersPrimers(int num)
        {
            int nombreDivisors = 0, posibleprimer = 2;
            string primers = "";
            for (int cont = 0;cont<num ; posibleprimer++)
            {
                for (int i = 1; i <= posibleprimer / 2 && nombreDivisors == 0; i++)
                {
                    if (posibleprimer % i == 0)
                    {
                        nombreDivisors++;
                    }
                }
                if (nombreDivisors == 0)
                {
                    cont++;
                    if (cont == 1)
                        primers = "" + posibleprimer;
                    else
                        primers = primers + ", " + posibleprimer;
                }
            }
            return primers;
        }
        static bool Sortida()
        {
            char q;
            bool res;
            Console.WriteLine("Presiona la 'q' per a confirmar.");
            q = Convert.ToChar(Console.ReadLine());
            if (q == 'q' || q == 'Q')
                res = true;
            else
            {
                Console.WriteLine("Cancelat.");
                res = false;
            }
            return res;
        }
    }
}