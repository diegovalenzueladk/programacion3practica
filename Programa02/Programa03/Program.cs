namespace program03;
class Program
{
    static void Main (string[]args)
    {
        //----------- CUENTAS DEL MES------------------//
        Console.WriteLine("------CUENTAS DEL MES------");
        int luz=100000;
        int gas=7000;
        int internet=30000;
        int agua=10000;
        int suma =luz+gas+internet+agua;

        Console.WriteLine("---------ABRIL---------");
        Console.WriteLine("FACTURA DE LA LUZ:     $"+ luz );
        Console.WriteLine("FACTURA DEL GAS:       $"+ gas );
        Console.WriteLine("FACTURA DEL INTERNET:  $"+ agua);
        Console.WriteLine("FACTURA DEL AGUA:      $"+ internet );
        Console.WriteLine("'TOTAL DE GASTOS MES:  $"+ suma+"'");
    }
}