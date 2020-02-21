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
            string close = null;
            string resant = null;
            int val1, val2,res;
            float resdiv;
            string op;
            float result = 0;
            do
            {
                Console.WriteLine("Que operación desea hacer?");
                Console.WriteLine("(+) Suma");
                Console.WriteLine("(-) Resta");
                Console.WriteLine("(*) Multiplicar");
                Console.WriteLine("(/) Dividir");
                Console.WriteLine("(m) Memoria");
                op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        Console.WriteLine("Suma");//Detectar tipo de operador
                        Console.WriteLine("Escribe el primer numero");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        val2 = int.Parse(Console.ReadLine());
                        res = val1 + val2;
                        result = res;
                        Console.WriteLine(res);
                        Console.WriteLine("Desea utilizar el resultado anterior?");                     
                        resant = Console.ReadLine();
                        if (resant == "no")
                        {
                            break;
                        }
                        Console.WriteLine("Escribe el valor a sumar");
                        val1 = int.Parse(Console.ReadLine());
                        res = val1 + res;
                        Console.WriteLine(res);
                        break;
                    case "-":
                        Console.WriteLine("Resta");
                        Console.WriteLine("Escribe el primer numero");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        val2 = int.Parse(Console.ReadLine());
                        res = val1 - val2;
                        result = res;
                        Console.WriteLine(res);
                        Console.WriteLine(res);
                        Console.WriteLine("Desea utilizar el resultado anterior?");
                        resant = Console.ReadLine();
                        if (resant == "no")
                        {
                            break;
                        }
                        Console.WriteLine("Escribe el valor a restar");
                        val1 = int.Parse(Console.ReadLine());
                        res = val1- res;
                        Console.WriteLine(res);
                        break;
                    case "*":
                        Console.WriteLine("Multiplicar");//Detectar tipo de operador
                        Console.WriteLine("Escribe el primer numero");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        val2 = int.Parse(Console.ReadLine());
                        res = val1 * val2;
                        result = res;
                        Console.WriteLine(res);
                        Console.WriteLine(res);
                        Console.WriteLine("Desea utilizar el resultado anterior?");
                        resant = Console.ReadLine();
                        if (resant == "no")
                        {
                            break;
                        }
                        Console.WriteLine("Escribe el valor a Multiplicar"); 
                        val1 = int.Parse(Console.ReadLine());
                        res = val1 * res;
                        Console.WriteLine(res);
                        break;
                    case "/":
                        Console.WriteLine("Dividir");//Detectar tipo de operador  
                        Console.WriteLine("Escribe el primer numero");
                        val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo numero");
                        val2 = int.Parse(Console.ReadLine());
                        resdiv = val1 / val2;
                        result = resdiv;
                        Console.WriteLine(resdiv);
                        Console.WriteLine("Desea utilizar el resultado anterior?");
                        resant = Console.ReadLine();
                        if (resant == "no")
                        {
                            break;
                        }
                        Console.WriteLine("Escribe el valor a sumar");
                        val1 = int.Parse(Console.ReadLine());
                        resdiv = val1 / resdiv;
                        Console.WriteLine(resdiv);
                        break;
                    case "m":
                        Class1 memo = new Class1();
                        memo.LeerMemoria();
                        break;
                }
                Console.WriteLine("Desea volver a usar la calculadora?");
                close = Console.ReadLine();
            } while (close == "si");
            if(close == "no") {
                Console.WriteLine("Gracias por usar la calculadora y no olvides tomar aguita :D <3");
            }
            Console.ReadKey();
        }
    }
}