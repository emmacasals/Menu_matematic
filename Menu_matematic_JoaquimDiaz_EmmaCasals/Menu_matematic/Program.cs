﻿/*1.- Menú matemàtic
Fer un menú amb 9 opcions (8 + q per sortir). Cada opció del menú cridarà a una acció Maxim,
Mcd, Mcm, Factorial, Combinatori, MostrarDivisorMajor, EsPrimer, NPrimersPrimers que
demanarà les entrades validades, farà els càlculs, i mostrarà el resultat. Les entrades hauran de
ser validades per algunes de les funcions de validació. Cal presentar un projecte únic amb totes
les funcions i accions proposades a més a més del programa principal que implementa el
menú.*/


//MAIN:Fem la crida de les altres funcions 
static void Main(string[] args)
{
    int R=1;
    do
        Menu(R);
    while (R != 0);
}
static int Menu(int R)
{

    R = Convert.ToInt32(Console.ReadLine());
    //Crear un menu. Et te que tornar el numero que has posat en el menu per saber quan el programa pot parar (quan poses 0).
    if (R == 0)
        return R;
    return R;
}
//Maxim
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
