using Newtonsoft.Json;
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
            int i= 0;
            //Lectura de nuestro json iterable
            foreach ((var key,var item) in dbObject)//item=grupo de memoria
            {   
                Console.WriteLine("-----------------");
                Console.WriteLine("Dato en memoria:");
                MemoriaData memoriaData = new MemoriaData(DateTime.Now,item["operacion"].ToString(),(int) item["resultado"]);
                this.db.Add(memoriaData);
                Console.WriteLine("Fecha:");
                Console.WriteLine(key.ToString());//Fecha
                Console.WriteLine("Operacion a hacer:");
                Console.WriteLine(memoriaData.operacion);//Operacion
                Console.WriteLine("Resultado:");
                Console.WriteLine(memoriaData.resultado.ToString());//Resultado
                i++;
            }
        }
        public int GetMemoriaData(String key)
        {
            int index = int.Parse(key);
            MemoriaData data = db[index];
            return data.resultado;
        }
        public void GetMemoriaData(MemoriaData data)
        {
            db.Add(data);
            int i= 0;
            db.ForEach((MemoriaData memoriadata) =>
            {
                Console.WriteLine("Dato en memoria: ({0})", i);
                Console.WriteLine("{0} - {1}", memoriadata.fecha.ToLongDateString(),memoriadata.fecha.ToLongTimeString());
                Console.WriteLine("Operacion: {0}", memoriadata.operacion);
                Console.WriteLine("Resultado: {0}", memoriadata.resultado.ToString());
                Console.WriteLine("-----------\n");
                i++;
            });
            string json = JsonConvert.SeriaLizeObject(db.ToArray(), formatting.Indented);
            string archivoDB = "../../../db.json";
            File.WriteAllText(archivoDB, json);
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
        //public void multidimencional()
        static void Main()
        {
            bool salir = false;
            while (!salir)
            {
                /*int[,] array = new int[4, 2];
                Console.WriteLine(array);*/
                Console.WriteLine("Arreglo sencillo");
                string[]sencillo = { "Rojo", "Blanco", "Morado" };
                Console.WriteLine("[{0}]", string.Join(",", sencillo));
                Console.WriteLine("Arreglo 2 Dimesiones");
                int[,] dosDimensiones = new int[5, 5];
                for(int i =0; i< dosDimensiones.GetLength(0); i++)
                {
                    for(int j = 0; j < dosDimensiones.GetLength(1); j++)
                    {
                        dosDimensiones[i, j] = i + j;
                        Console.WriteLine("{0},{1}={2}", i, j, dosDimensiones[i, j]);
                    }
                }
                Console.WriteLine("[{0}]", string.Join(",", dosDimensiones));
                Console.WriteLine("Arreglo 3 Dimesiones");
                int[,,] tresDimensiones = new int[5, 5, 5];
                for (int i = 0; i < dosDimensiones.GetLength(0); i++)
                {
                    for (int j = 0; j < tresDimensiones.GetLength(1); j++)
                    {
                        for(int k = 0; k < tresDimensiones.GetLength(2); k++)
                        {
                            tresDimensiones[i, j, k] = i + j + k;
                            Console.WriteLine("{0},{1},{2}={3}", i, j,k, tresDimensiones[i, j, k]);
                        }
                    }
                }
                Console.WriteLine("[{0}]", string.Join(",", tresDimensiones));
                Console.WriteLine("Arreglo 4 Dimesiones");
                int[,,,] cuatroDimensiones = new int[5, 5, 5, 5];
                for (int i = 0; i < cuatroDimensiones.GetLength(0); i++)
                {
                    for (int j = 0; j < cuatroDimensiones.GetLength(1); j++)
                    {
                        for (int k = 0; k < cuatroDimensiones.GetLength(2); k++)
                        {
                            for (int m = 0; m < cuatroDimensiones.GetLength(3); m++)
                            {
                                cuatroDimensiones[i, j, k, m] = i + j + k + m;
                                Console.WriteLine("{0},{1},{2},{3}={4}", i, j, k,m, cuatroDimensiones[i, j, k, m]);
                            }
                        }
                    }
                }
                string exit = Console.ReadLine();
                if(exit == "y")
                {
                    salir = true;
                }

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