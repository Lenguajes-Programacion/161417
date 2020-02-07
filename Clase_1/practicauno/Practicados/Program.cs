using System;

namespace Practicados
{
    class Program
    {
        //Proyecto Calculadora
        //Se espera recivir 2 argumentos valor1 (Int), valor2 (String) operador
        //valor3 (int)
        //Responder resultado en (int)
        static void Main(string[] args)
        {
            switch (args[1])
            {
                case "+":
                    Console.WriteLine("Es una suma");//Detectar tipo de operador                   
                    break;
                default:
                    Console.WriteLine("Los argumentos no cuentan con un operador valido:" + args[1]);
                    break;
            }
        }
    }
}
