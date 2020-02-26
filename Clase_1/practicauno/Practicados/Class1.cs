using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practicados
{
    class Memoria
    {
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
//Agregar formato a la fecha, tipo de operacion y resultado