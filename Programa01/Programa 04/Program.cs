namespace Programa04;
class Program
{
    static void Main ( string [] args)
    {
        Console.WriteLine("\n----REGISTRO DE PERSONAS----");

        Console.WriteLine("ingrese Apellido y Nombres");
        string nombre= Console.ReadLine();

        Console.WriteLine("Ingrese Edad");
        string edadpersona= Console.ReadLine();
        int edad = int.Parse(edadpersona);

        Console.WriteLine("Ingrese documento nacional de identidad");
        string dni = Console.ReadLine();

        Console.WriteLine("ingrese Ciudad y Pronvicia");
        string ciudad = Console.ReadLine();

        Console.WriteLine("ingrese Calle donde vive");
        string numer = Console.ReadLine();

        Console.WriteLine("ingrese altura de la calle donde vive");
        string alturacalle= Console.ReadLine();
        int altura=int.Parse(alturacalle);

        Console.WriteLine("ingrese sexualida ej:MASCULINO-FEMENINO");
        string sexualida = Console.ReadLine();

        Console.WriteLine("ingrese Numero de Telefono Celular");
        string tel = Console.ReadLine();
        
        Console.WriteLine("ingrese correo electronico");
        string correo= Console.ReadLine();
        
        Console.WriteLine("\n---DATOS DE LA PERSONA---");
        Console.WriteLine("APELLIDO Y NOMBRE:       "+ nombre);
        Console.WriteLine("EDAD:                    "+ edad );
        Console.WriteLine("DNI:                     "+ dni);
        Console.WriteLine("DOMICILIO:               "+ ciudad + " "+numer+" "+ altura);
        Console.WriteLine("CORREO ELECTRONICO:      "+ correo);
    }

    
}
