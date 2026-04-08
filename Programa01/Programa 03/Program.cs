namespace Programa03;

    class Program 
{
    static void Main (string[] args)
    {
       Console.WriteLine("\n--REGISTRO DE AUTOMOVIL O MOTOCICLETA--");
        
        Console.WriteLine("ingrese que vehiculo es AUTOMOVIL o MOTOCICLETA");
        string vehiculo= Console.ReadLine();

        Console.WriteLine("Ingrese Marca y Modelo");
        string marca = Console.ReadLine();
        
        Console.WriteLine("Ingrese Año del Vehiculo");
        string añovehiculo = Console.ReadLine();
        int año = int.Parse(añovehiculo);

        Console.WriteLine("Ingrese numero de Chasis o Cuadro");
        string chasis = Console.ReadLine();

        Console.WriteLine("Ingrese numero Motor");
        string motor = Console.ReadLine();

        Console.WriteLine("ingrese Apellido y Nombre de titular del vehiculo");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese DNI titular");
        string dni = Console.ReadLine();
        

        Console.WriteLine("Ingrese Numero Celular");
        string tel = Console.ReadLine();

        Console.WriteLine("\n---PERFIL DEL VEHICULO---");
        Console.WriteLine("VEHICULO:             "+ vehiculo);
        Console.WriteLine("MARCA Y MODELO:       "+ marca);
        Console.WriteLine("AÑO:                  "+ año);
        Console.WriteLine("N* DE MOTOR:          "+ motor);
        Console.WriteLine("N* DE CHASIS/CUADRO:  "+ chasis);
        Console.WriteLine("TITULAR:              "+ nombre);
        Console.WriteLine("DNI:                  "+ dni);
        Console.WriteLine("N* DE TELEFONO:       "+ tel );

    }
}
