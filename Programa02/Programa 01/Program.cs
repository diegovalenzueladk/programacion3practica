namespace Programa01;
class Program
{
    static void Main (string [] args)
    {
        //-----------STOCK DE CELULARES EN SERVICE TECNICO-------------------//
        Console.WriteLine("------SERVICE TECNICO------");
        int celularesrotos= 29;
        int celularereparados = 63;
        int celularesventas = 20;
        int celularesentrega= 10;
        int suma = celularesentrega+celularereparados+celularesentrega+celularesrotos+celularesventas;

        Console.WriteLine("-----STOCK DE CELULARES-----");
        Console.WriteLine("CELULARES ROTOS:        "+ celularesrotos );
        Console.WriteLine("CELULARES REPARADO:     "+ celularereparados );
        Console.WriteLine("CELULARES A LA VENTA:   "+ celularesventas);
        Console.WriteLine("CELULARES PARA ENTREGA: "+ celularesentrega);
        Console.WriteLine("TOTAL DE CELULARES:     "+ suma);
        


    }
}
