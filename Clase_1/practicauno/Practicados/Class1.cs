using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practicados
{
    class Memoria
    {
        public List<MemoriaData> db = new List<MemoriaData>();
        public Memoria()
        {
            db = new List<MemoriaData>();
        }
        public void LeerMemoria()
        {
            string archivoDB = "../../../db.json";//Ubicación del archivo
            StreamReader reader = new StreamReader(archivoDB);//Lee en tiempo real el archivo
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);//Hacemos que lo interprete
            //Prueba de lectura
            //var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();//Carga lo que esta en el arreglo
            //var result = dbObject["arreglo"][0].ToString();//Carga lo que esta en el arreglo en el nivel 0

            //Lectura de nuestro json iterable
            foreach ((var key,var item) in dbObject)//item=grupo de memoria
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Dato en memoria:");
                MemoriaData memoriaData = new MemoriaData(DateTime.Now,item["operacion"].ToString(),(int) item["resultado"]);
                Console.WriteLine("Fecha:");
                Console.WriteLine(key.ToString());//Fecha
                Console.WriteLine("Operacion a hacer:");
                Console.WriteLine(memoriaData.operacion);//Operacion
                Console.WriteLine("Resultado:");
                Console.WriteLine(memoriaData.resultado.ToString());//Resultado

            }
        }
        public int GetMemoriaData(String key)
        {
            int index = int.Parse(key);
            MemoriaData data = db[index];
            return data.resultado;
        }
        public void arreglo()
        {
            string[] Colores = { "Rojo", "Blanco", "Morado" };
            /*List<string> colores = ["Rojo", "Blanco", "Morado"];
            colores.Sort();*/
            Array.Sort(Colores);
            Array.ForEach(Colores, (item) => {
                Console.WriteLine(item);
            });
            String color = Array.Find(Colores, (item) =>
            {
                return item.Length > 4;
            });
            Console.WriteLine(color);
            Console.WriteLine("Accede a tus colores y separalos con coma (,)");
            String colorUser = Console.ReadLine();
            string[] newColors = colorUser.Split(' ');
            Console.WriteLine(newColors);//Nuevo arreglo "newColors"
        }
        public void multidimencional()
        {
            int[,] array = new int[4, 2];
            Console.WriteLine(array);
        }
    }
    class MemoriaData
    {
        public DateTime fecha;
        public String operacion;
        public int resultado;

        public MemoriaData(DateTime date,String operation,int result){
            fecha = date;
            operacion = operation;
            resultado = result;
        }
    }

}