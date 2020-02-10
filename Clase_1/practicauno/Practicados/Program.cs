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
            bool close_app = true;
            int val1, val2, res;
            float resdiv;
            string op;
            while (close_app)
            {
            
            Console.WriteLine("Que operación desea hacer?");
            Console.WriteLine("(+) Suma");
            Console.WriteLine("(-) Resta");
            Console.WriteLine("(*) Multiplicar");
            Console.WriteLine("(/) Dividir");
            Console.WriteLine("(s) Salir");
            op = Console.ReadLine();
            
            Console.WriteLine("Escribe el primer numero");
            val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo numero");
            val2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine("Suma");//Detectar tipo de operador  
                    res = val1 + val2;
                    Console.WriteLine(res);
                    break;
                case "-":
                    Console.WriteLine("Resta");//Detectar tipo de operador  
                    res = val1 - val2;
                    Console.WriteLine(res);
                    break;
                case "*":
                    Console.WriteLine("Multiplicar");//Detectar tipo de operador  
                    res = val1 * val2;
                    Console.WriteLine(res);
                    break;
                case "/":
                    Console.WriteLine("Dividir");//Detectar tipo de operador  
                    resdiv = val1 / val2;
                    Console.WriteLine(resdiv);
                    break;
                case "s":
                    Console.WriteLine("Salir");//Detectar tipo de operador
                    Console.WriteLine("Adios");
                    close_app = false;
                    break;
                default:
                    Console.WriteLine("Opción desconocida");
                    break;
            }
            }
        }
    }
}
