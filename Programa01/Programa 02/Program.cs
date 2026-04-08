namespace Programa02;

    class Program 
{
    static void Main (string[] args)
    {
        Console.WriteLine("\n SISTEMA DE REGISTRO ALUMNO ");
      
        Console.WriteLine("Ingrese Apellido y Nombre");
        string nombre= Console.ReadLine();    

        Console.WriteLine("ingrese Edad");
        string edadalumno = Console.ReadLine();
        int edad = int.Parse(edadalumno);

        Console.WriteLine("ingrese DNI");
        string dni = Console.ReadLine();

        Console.WriteLine("ingrese numero de celular");
        string telalumno = Console.ReadLine();
        int tel = int.Parse(telalumno);

        Console.WriteLine("Ingresa Carrera");
        string carrera = Console.ReadLine();

        Console.WriteLine("\n--PERFIL ALUMNO--");
        Console.WriteLine("APELLIDO Y NOMBRE:" + nombre );
        Console.WriteLine("DNI:" + dni);
        Console.WriteLine("EDAD:" + edad );
        Console.WriteLine("NUMERO DE CELULAR:" + tel);
        Console.WriteLine("CARRERA:" + carrera);
    }
}