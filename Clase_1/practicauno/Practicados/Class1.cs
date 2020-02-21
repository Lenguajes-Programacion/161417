using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practicados
{
    class Class1
    {
        public void LeerMemoria()
        {
            string archivoDB = "../../../db.json";//Ubicación del archivo
            StreamReader reader = new StreamReader(archivoDB);//Lee en tiempo real el archivo
            var dbJSON = reader.ReadToEnd();
            //Prueba de lectura
            var dbObject = JObject.Parse(dbJSON);//Hacemos que lo interprete
            var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();//Carga lo que esta en el arreglo
            //var result = dbObject["arreglo"][0].ToString();//Carga lo que esta en el arreglo en el nivel 0

            //Lectura de nuestro json iterable
            foreach (var item in dbObject)//item=grupo de memoria
            {
                Console.WriteLine("Dato en memoria:");
                Console.WriteLine(result.ToString());
            }
        }
    }
}
