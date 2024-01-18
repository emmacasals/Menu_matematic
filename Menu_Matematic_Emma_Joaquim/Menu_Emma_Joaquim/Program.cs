/*1.- Menú matemàtic
Fer un menú amb 9 opcions (8 + q per sortir). Cada opció del menú cridarà a una acció Maxim,
Mcd, Mcm, Factorial, Combinatori, MostrarDivisorMajor, EsPrimer, NPrimersPrimers que
demanarà les entrades validades, farà els càlculs, i mostrarà el resultat. Les entrades hauran de
ser validades per algunes de les funcions de validació. Cal presentar un projecte únic amb totes
les funcions i accions proposades a més a més del programa principal que implementa el
menú.*/

namespace Menu_Emma_Joaquim
{
    class Program
    {
        static ConsoleColor colorMenu = ConsoleColor.Green; 

//dissabte a les 23:59

//MAIN:Fem la crida de les altres funcions 
static void Main(string[] args)
{
    int R = 1;
    do
        Menu(R);
    while (R != 0);
}

static int Menu(int R)
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
        "\n 9.-SORTIDA \n");
    Console.WriteLine("Selecciona la opció que desitja: ");
    R = Convert.ToInt32(Console.ReadLine());

    if (R == 0)
        return R;

    switch (R)
    {
        case 1:
            Maxim();
            break;
        case 2:
            MCD();
            break;
        case 3:
            MCM();
            break;
        case 4:
            Factorial();
            break;
        case 5:
            Combinatori();
            break;
        case 6:
            MostrarDivisorMajor();
            break;
        case 7:
            EsPrimer();
            break;
        case 8:
            NPrimersPrimers();
            break;
        case 9:
            Console.WriteLine("Estas sortint del menú d'operacions");
            break;
        default:
            Console.WriteLine("Introdueix una opció vàlida,sisplau");
            break;
    }
    Console.ReadKey();
    return (R);
}

//Maxim
static int Maxim(int num1, int num2)
{
    Console.WriteLine("Sisplau introdueix un número per dir-te quin és el màxim");
    num1 = Convert.ToInt32(Console.ReadLine());
    num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 > num2)
    {
        Console.WriteLine("");
    }
    else if (num2 > num1)
    {

    }
}
//Mcd
static int MCD(int num)
{
}
//Mcm
static int MCM(int num)
{
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
}
//EsPrimer
static int EsPrimer(int num)
{
}
//NPrimersPrimers
static double NPrimersPrimers(int n, int m)
{
}

static char Sortida(char q)
{
    q = Convert.ToChar(Console.ReadLine);
    if (q == q)
    {
        Menu();
    }
}
}