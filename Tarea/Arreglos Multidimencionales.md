Los arreglos multidimensionales tienen más de una dimensión. En C#, las dimensiones se manejan por medio de un par de corchetes, dentro de los que se escriben los valores de cada dimensión, separados por comas.

Operaciones.

Para manejar un arreglo, las operaciones a efectuarse son:

    *Declaración del arreglo
    *Creación del arreglo
    *Inicialización de de los elementos del arreglo
    *Acceso a los elementos del arreglo.

Declaración.

La sintaxis para declarar un arreglo multidimensional es la siguiente:

<tipo> [ , …] < identificador > ;

Creación.

La creación de un arreglo multidimensional consiste en reservar espacio en la memoria para todos sus elementos, utilizando la siguiente sintaxis:

< identificador > = new <tipo> [ dim1, dim2 … dimN ] ;

Inicialización.

Un arreglo es un objeto que,cuando es creado por el compilador, se le asignan automáticamente valores iniciales predeterminados a cada uno de sus elementos, de acuerdo a los siguientes criterios:

Si el tipo del arreglo es numérico, a sus elementos se les asigna el valor cero.
Si el tipo del arreglo es char, a sus elementos se les asigna el valor ‘\u0000’.
Si el tipo del arreglo es bool, a sus elementos se les asigna el valor false.
Si el tipo del arreglo es una clase, a sus elementos se les asigna el valor null.
Cuando se requiere asignar valores iniciales diferentes de los predeterminados, es posible agrupar las operaciones de declaración, creación e inicialización en una sola instrucción, por ejemplo:

int [ , , ] tridim={{{12, 59, 70, 45} , {20, 16, 29, 48} , {93, 75, 43, 10}},

{{44, 72, 30, 24} , {60, 89, 39, 61} , {99, 52, 34, 47}}};
Acceso.

Se puede acceder a los valores de los elementos de un arreglo bidimensional a través del nombre del arreglo y dos subíndices. Los subíndices deben escribirse entre corchetes y representa la posición del elemento en el arreglo. Así, podemos referirnos a un elemento del arreglo escribiendo el nombre del arreglo y los subíndices del elemento entre corchetes. Los valores de los subíndices empiezan en cero para el primer elemento, hasta el tamaño del arreglo menos uno.

https://clasesadsi.wordpress.com/2017/03/07/arreglos-unidimensionales-y-multidimensionales/ 

https://riptutorial.com/es/vba/example/17455/arreglos-multidimensionales
