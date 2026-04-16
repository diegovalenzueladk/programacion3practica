namespace PracticaLogica;
class Program
{
    static void Main(string[] args)
    {
        int cantidad = 20;
        string[] nombres = new string[cantidad];
        int[] edades = new int[cantidad];

        // Pedir datos
        Console.WriteLine("-- INGRESE LOS SIGUIENTE "+cantidad+" NOMBRES Y EDADES --");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Nombre "+i+": ");
            nombres[i] = Console.ReadLine();

            Console.Write("Edad "+i+": ");
            edades[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
        }

        // Mostrar resultados
        Console.WriteLine("\n---DATOS INGRESADOS---");
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write(i+" _"+nombres[i] + " tiene " + edades[i] + " años - ");

            if (edades[i] > 30)
                Console.WriteLine("Puede Ingresar");
            else
                Console.WriteLine("No puede ingresar, vuelva a casa.");
        }
        Console.WriteLine("Precione ENTER para Salir...");
        Console.ReadLine();
    }
}