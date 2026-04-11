namespace Programa05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            // Cadena de texto (string) - Comillas dobles ""
            string nombre = "Claudia Marconi";
            Console.WriteLine(" TIPO TEXTO (string):");
            Console.WriteLine("   Valor guardado: " + nombre);

            // Carácter único (char) - Comillas simples ''
            char inicialNombre = 'C';
            Console.WriteLine("\n TIPO CARÁCTER (char):");
            Console.WriteLine("   Valor guardado: '" + inicialNombre + "'");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}