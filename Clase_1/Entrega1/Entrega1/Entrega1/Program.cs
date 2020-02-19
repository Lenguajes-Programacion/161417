using System;
//Entrega 100
namespace Entrega1
{
    class Program
    {
        static string nombre = "Manuel";
        static void Main(string[] args)
        {
            string opc, op;
            string close1 = null;
            string close = null;
            string resant = null;
            string salir = null;
            int val1, val2, res;
            float resdiv;
            float result = 0;
            do
            {
                Console.WriteLine("Que desea hacer?\n");
                Console.WriteLine("Argumentos y comprobación (a)");
                Console.WriteLine("Usar calculadora (c)");
                Console.WriteLine("Salir (s)");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "a":
                        do
                        {
                            Console.WriteLine("Hola, ¿Cual es tu nombre?");
                            nombre = Console.ReadLine();
                            if (nombre == "Manuel")
                            {
                                Console.WriteLine("Hola Manuel");
                            }
                            else
                            {
                                Console.WriteLine("User unauthorized");
                            }
                            Console.WriteLine("Desea comprobar de nuevo?");
                            close1 = Console.ReadLine();
                        } while (close1 == "si");
                        if (close1 == "no")
                        {
                            Console.WriteLine("Gracias por comprobar");
                        }
                        Console.ReadKey();
                        break;
                    case "c":
                        do
                        {
                            Console.WriteLine("Que operación desea hacer?");
                            Console.WriteLine("(+) Suma");
                            Console.WriteLine("(-) Resta");
                            Console.WriteLine("(*) Multiplicar");
                            Console.WriteLine("(/) Dividir");
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
                                    res = val1 - res;
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
                            }
                            Console.WriteLine("Desea volver a usar la calculadora?");
                            close = Console.ReadLine();
                        } while (close == "si");
                        if (close == "no")
                        {
                            Console.WriteLine("Gracias por usar la calculadora y no olvides tomar aguita :D <3");
                        }
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("Desea salir del programa?");
                salir = Console.ReadLine();
            } while (salir == "no");
            if (salir == "si")
            {
                Console.WriteLine("Gracias por usar el programa y no olvides tomar aguita :D <3");
            }
            Console.ReadKey();
        }
    }
}

