# 161417
Manuel Alejandro Gonzalez Carrillo

System.Object.Equals(Object o) comprueba si dos objetos son iguales.

System.Object.ReferenceEquals(Object o) comprueba si dos referencias apuntan al mismo objeto.

System.Object.Finalize() es invocado por el recolector de basura para liberar el objeto.

System.Object.GetHashCode() se emplea en la implementación colecciones de objetos (del tipo System.Collections.HashTable) y debe implementarse en las subclases de System.Object para crear buenas funciones hash (por defecto, se utiliza la identidad del objeto).

System.Object.GetType() devuelve el tipo de un objeto (punto de entrada para el sistema de reflexión de la plataforma .NET).

System.Object.MemberwiseClone() crea un clon del objeto utilizando la capacidad de reflexión de la plataforma .NET

System.Object.ToString() devuelve una representación textual del objeto. Por defecto, devuelve el nombre de la clase, por lo que deberemos implementarlo nosotros. No está diseñado para mostrar mensajes al usuario (para esa función se debería utilizar el interfaz IFormattable)



System
Tipos muy frecuentemente usados, como los los tipos básicos, tablas, excepciones, fechas, números aleatorios, recolector de basura, entrada/salida  en consola, etc.

System.Collections
Colecciones de datos de uso común como pilas, colas, listas, diccionarios, etc.

System.Data
Manipulación de bases de datos. Forman la denominada arquitectura ADO.NET.

System.IO
Manipulación de ficheros y otros flujos de datos.

System.Net
Realización de comunicaciones en red.


System.Reflection
    

Acceso a los metadatos que acompañan a los módulos de código.

System.Runtime.Remoting
    

Acceso a objetos remotos.

System.Security
    

Acceso a la política de seguridad en que se basa el CLR.

System.Threading
    

Manipulación de hilos.

System.Web.UI.WebControls
    

Creación de interfaces de usuario basadas en ventanas para aplicaciones Web.

System.Windows.Forms
    

Creación de interfaces de usuario basadas en ventanas para aplicaciones estándar.

System.XML
    

Acceso a datos en formato XML.
