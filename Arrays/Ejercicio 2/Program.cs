namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- INICIALIZACIÓN DIRECTA Y FOREACH ---");
        Console.WriteLine("--- EJERCICIO 1 ---");

        string[] frutas = { "manzana", "uva", "banana", "naranja" };
        Console.WriteLine("\nLista de frutas usando foreach:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine("- " + fruta);
        }
        Console.WriteLine("\nPresione Enter para continuar...");
        Console.ReadLine();

        //------------------------------------------------------------
        Console.WriteLine("--- EJERCICIO 2 ---");
        string [] nombres={"Diego","Claudia","Sergio","Hector","Maria"};
        Console.WriteLine("\nLista de nombres usando foreach:");
        foreach(string nombre in nombres)
        {
            Console.WriteLine("# "+ nombre);
        }
        Console.WriteLine("\nPrecione ENTER para continuar...");
        Console.ReadLine();
        //-------------------------------------------------------------
        Console.WriteLine("--- EJERCICIO 3 --- ");
        string [] paises = {"Argentina", "Chile", "Peru", "Bolivia"};
        Console.WriteLine("\nLista de paises con foreach:");
        foreach (string pais in paises)
        {
            Console.WriteLine("País: " + pais);
        }
        Console.WriteLine("\nPrecione ENTER para continuar...");
        Console.ReadLine();
        //--------------------------------------------------------------
        Console.WriteLine("--- EJERCICIO 4 ---");
        string [] colores={"Blanco","Verde","Azul","Negro"};
        Console.WriteLine("\nListado de colores con foreach: ");
        foreach (string color in colores)
        {
            Console.WriteLine("Color: "+color);
        }
        Console.WriteLine("\nPrecione ENTER para continuar...");
        Console.ReadLine();
        //---------------------------------------------------------------
        Console.WriteLine("--- EJERCICIO 5 ---");
        string [] aprobados={"Valdez_Diego","Gomez_Facundo","Arancibia_Elva","Pedernera_Camila"};
        Console.WriteLine("\nListado De Aprobados : ");
        foreach (string aprobado in aprobados)
        {
            Console.WriteLine("- "+aprobado);
        }
        Console.WriteLine("\nPrecione ENTER Para CERRAR...");
        Console.ReadLine();


    }
}
