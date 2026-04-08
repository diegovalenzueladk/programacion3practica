namespace Programa02;
class Program
{
    static void Main (string [] args)
    {
        Console.WriteLine("---CONCESIONARIA DE MOTOS----");
        Console.WriteLine("-----------------------------");

        int motos750=10;
        int motos250=15;
        int motos150=10;
        int motos110=50;
        int suma=motos110+motos150+motos250+motos750;


        Console.WriteLine("--------STOCK DE MOTOS-------");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("CILINDRADA           CANTIDAD");
        Console.WriteLine(" 110CC                 "+motos110);
        Console.WriteLine(" 150CC                 "+motos150);
        Console.WriteLine(" 250cc                 "+motos250);
        Console.WriteLine(" 750cc                 "+motos750);
        Console.WriteLine("-----------------------------");

        

    }
}
