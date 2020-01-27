using system;
//importamos la libreria principal

namespace practica1
{
    class program //Esta es una clase base
    {
        //Variable de la Clase.
        static string nombre = "Manuel";

        static void Main(string[] args) //args = {"Manuel","20","Mexicano"}Arreglo de informacion personal
        {
            //Respondemos en el primer argumento
            Console.WriteLine($"Hello {args[0]} {args[1]}");
        } 
    }
}