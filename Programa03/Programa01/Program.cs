namespace programa01;
class Program
{
    static void Main (string []arge)
    {
        Console.WriteLine("-----BIENVENIDOS A LA ACEITERA------");
        decimal precioaceite1l=1.24m;
        decimal precioaceite10l=6.71m;
        decimal precioaceite100l=60.45m;
        Console.WriteLine("-PRECIO DEL ACEITE DE OLIVA EXTRA PURO-");
        Console.WriteLine("ACEITE DE OLIVA POR LITRO:     $"+ precioaceite1l);
        Console.WriteLine("ACEITE DE OLIVA POR 10 LITROS: $"+ precioaceite10l);
        Console.WriteLine("ACEITE DE OLIVA POR 100 LITROS:$"+ precioaceite100l);
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Presiona ENTER para cerrar");
        Console.ReadLine();

    }
}
