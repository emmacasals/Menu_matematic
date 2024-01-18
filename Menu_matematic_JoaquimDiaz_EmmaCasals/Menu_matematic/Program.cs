/*1.- Menú matemàtic
Fer un menú amb 9 opcions (8 + q per sortir). Cada opció del menú cridarà a una acció Maxim,
Mcd, Mcm, Factorial, Combinatori, MostrarDivisorMajor, EsPrimer, NPrimersPrimers que
demanarà les entrades validades, farà els càlculs, i mostrarà el resultat. Les entrades hauran de
ser validades per algunes de les funcions de validació. Cal presentar un projecte únic amb totes
les funcions i accions proposades a més a més del programa principal que implementa el
menú.*/


//MAIN:Fem la crida de les altres funcions 
static void Main(string[] args)
{
    string R;
    do
    {
        R="";
        Menu(R);
    }
    while (R != "0");
}
static void Menu(string R)
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
    Console.Write("Selecciona la opció que desitja: ");
    R = Convert.ToInt32(Console.ReadLine());
    if (R == 0)
        return R;
    switch (R)
    {
        case 1:
            Maxim();
            Timer();
            break;
        case 2:
            MCD();
            Timer();
            break;
        case 3:
            MCM();
            Timer();
            break;
        case 4:
            Factorial();
            Timer();
            break;
        case 5:
            Combinatori();
            Timer();
            break;
        case 6:
            MostrarDivisorMajor();
            Timer();
            break;
        case 7:
            EsPrimer();
            Timer();
            break;
        case 8:
            NPrimersPrimers();
            Timer();
            break;
        case 9:
            Console.WriteLine("Estas sortint del menú d'operacions");
            Timer();
            break;
        default:
            Console.WriteLine("Introdueix una opció vàlida,sisplau");
            Timer();
            break;
    }
    Console.ReadKey();
    return R;
}
//Maxim
static void Timer()
{

}
static int Maxim(int num)
{
  
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
//COMBINATORI FACTORIAL
static double Combinatori(int n, int m)
{
    double resultat;
    resultat = Factorial(n) / (Factorial(m)) / Factorial(n - m);
    return resultat;
}

//Combinatori
//COMBINATORI FACTORIAL
static double Combinatori(int n, int m)
{
    double resultat;
    resultat = Factorial(n) / (Factorial(m)) / Factorial(n - m);
    return resultat;
}
//MostrarDivisorMajor
static int MCD(int num)
{

}
//EsPrimer
static int MCD(int num)
{

}
//NPrimersPrimers
//COMBINATORI FACTORIAL
static double Combinatori(int n, int m)
{

}
static int MostrarDivisorMajor(int num)
{

}
static int EsPrimer(int num)
{

}
static int NPrimersPrimers(int num)
{

}
//Console.WindowHeight = 15    (Separar l'altura i amplada)
//Console.WindowWidth = 60
//Crear un timer per a mostrar el resultat abans de tornar al menu.