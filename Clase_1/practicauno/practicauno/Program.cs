using System;

namespace practicauno
{
    class Program
    {
        //Variable de la Clase.
        static string nombre = "Manuel";
        static void Main(string[] args)
        {
            //Respondemos con el primer argumento y segundo.
            //Condicion se debe de cunmplir todas las sentencias si utilizamos &&
            //Condicion se debe de cunmplir cualquier las sentencias si utilizamos ||
            //Tipos de comparación: >(Mayor) <(Menos) ==(Igual) >=(Mayor igual) <=(Menor igual) !=(Diferente que)
            // !false, is true 
            if (args[0].Length > 0 && args[0] == nombre)//Da un dato booleano "true or false"
            {
                Console.WriteLine($"Hello {args[0]}  {args[1]}");
            }else
            {
                Console.WriteLine("User unauthorized");
            }
        }
    }
}