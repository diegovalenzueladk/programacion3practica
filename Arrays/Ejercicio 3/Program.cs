using System.Net.Http.Headers;
using System.Net.Mail;

namespace ejercicio3;
class Program
{
    static void Main (string [] args)
    {
        Console.WriteLine("--- USO DE .LENGTH Y BUCLE FOR  ---");
        Console.WriteLine("--- EJERCICIO 1 ---");

        int[] edades = { 25,12,14,35 };
        int cantidadElementos = edades.Length;
        Console.WriteLine("El Arreglo Tiene " + cantidadElementos + " Elementos");
        for (int i = 0; i < cantidadElementos; i++)
        {
            Console.WriteLine("Índice " + i + ": La edad es " + edades[i]);
        }
        Console.WriteLine("\nPresione Enter para continuar...");
        Console.ReadLine();

        //--------------------------------------------------------
        Console.WriteLine("--- EJERCICIO 2 ---");

        string[] nombre={"claudia","alejo","graciela","diego","thiago"};
        int cantidadNombre = nombre.Length;
        Console.WriteLine ("El Arreglo tiene " +cantidadNombre+ " Elementos");
        for(int i =0; i < cantidadNombre; i++)
        {
            Console.WriteLine("Indice "+i+" Nombre: "+nombre[i]);
        }
        Console.WriteLine("\nPresione Enter para continuar...");
        Console.ReadLine();
        
        //---------------------------------------------------------
        Console.WriteLine("--- EJERCICIO 3 ---"); 
        Double[] precio={20.9,52.4,44.2,53.9,11.9};
        int cantidadPrecio= precio.Length;
        Console.WriteLine("El Arreglo tiene " + cantidadPrecio +" Elementos");
        for(int i=0 ; i< cantidadPrecio ; i++)
        {
            Console.WriteLine("Indice "+ i +" Precio: "+ precio[i]);
        }
        Console.WriteLine("\nPresione Enter para continuar...");
        Console.ReadLine();
        //----------------------------------------------------------
        Console.WriteLine("--- EJERCICIO 4 ---"); 
        int[] valores = { 10, 20, 30, 40 };
        int cantidadValores = valores.Length;
        Console.WriteLine("El Arreglo tiene "+ cantidadValores +" Elementos");

        for (int i = 0; i < cantidadValores; i++)
        {
            Console.WriteLine("Indice " + i + " Valor " + valores[i]);
        }
        Console.WriteLine("\nPresione Enter para continuar...");
        Console.ReadLine();
        //----------------------------------------------------------
        Console.WriteLine("--- EJERCICIO 5 ---");
        Char[] letra={'D','J','E','C','Q','L','Z'};
        int cantidadLetras= letra.Length;
        Console.WriteLine("El Arreglo tiene "+cantidadLetras + " Elementos");
        for( int i=0 ; i < cantidadLetras ; i++)
        {
            Console.WriteLine("Indice "+ i +" Letra "+ letra[i]);
        }
        Console.WriteLine("\nPresione Enter Para Cerrar...");
        Console.ReadLine(); 
    }
}
