
namespace Programa01;

    class Program 
{
    static void Main (string[] args)
    {
        Console.WriteLine("\n--SISTEMA DE REGISTRO DE MASCOTA--");

            Console.WriteLine("Ingrese nombre de mascota");
            string nombre = Console.ReadLine();

            Console.WriteLine("ingrese la edad de la mascota");
            string edadmascota = Console.ReadLine();
            int edad = int.Parse(edadmascota);

            Console.WriteLine("Ingresa el peso de la mascota");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- PERFIL CREADO ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Peso: " + peso + " kg");

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }
}            