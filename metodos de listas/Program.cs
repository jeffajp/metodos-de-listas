//metodos de listas en c#
/*
 * funciones: complementar un programa ser mas ordenado, para ahorrar codigo, se encarga de llamar a algo
 
 add= agrega un elemento al final de la lista, aumenta de tamaño
remove= elimina un elemento por su valor, elimina el primero que enceuntra, lo que se elimina se queda vacio.
clear= elimina todos los elementos, la lista queda vacia pero sigue existiendo. numeros.clear();
insert= agrega un elemento en una posicion especifica, cuando se agrega se corre para la derecha
contains= verifica si un elemento existe se usa bool para ver si algo esta en la lista si es verdadero o falso si esta o no
sort= ordenar una lista ascendente y alfabeticamente 
reverse= invierte el orden de la lista de derecha a izquierdda i viseversa 5-10-7 lo cambia a 7-10-5 numeros.revers();
indexOf= optiene la posicion de un elemento
find= busca el primer elemento que cumpla con la condicion se usa como expresion lambda int n = numeros.Find(x => x > 5); se parece al if
AddRange= agraga varios elementos, recibe otra lista numeros.addrange(new int[]{1,2,3]); nombres.addreange(new list<string> {"pedro","marta"});
Removeat= elimina por posicion 
Removeall= elimina todos los que cumplan condicion elimina todos los que se llaman juan en una lista
exists= verifica si existe algun elemento con esa condicion
foreach= recorre la lista ejecuta una accion para cada elemento
 ToUpper= pasa todo a mayuscula
toarray= convierte una lista en arreglo  int[] arr = numeros.ToArray(); string[] arr = nombres.ToArray();

*/

int opcion;

do
{
    Console.WriteLine("1. comida rapida: ");
    Console.WriteLine("2. comida de casa: ");
    Console.WriteLine("3. salir: ");

    opcion = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("seleccione la comida: ");
            break;

        case 2:
            Console.WriteLine("seleccione comida en casa: ");
            break;
      
        default:
            Console.WriteLine("gracias por usar el menu: ");
            break;

    }


} while (opcion != 3);