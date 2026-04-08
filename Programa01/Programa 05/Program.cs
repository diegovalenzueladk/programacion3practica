namespace Programa05;
class Program
{
    static void Main (string[] args)
    {
      Console.WriteLine("\n----DATOS DEL DETENIDO----");
      Console.WriteLine("INGRESE APELLIDO Y NOMBRE COMPLETOS...");
      string nombre = Console.ReadLine();
      Console.WriteLine("INGRESE DOCUMENTO NACIONAL DE IDENTIDAD..."); 
      string dni = Console.ReadLine(); 
      Console.WriteLine("INGRESE DOMICILIO...");
      string domicilio = Console.ReadLine();  
      Console.WriteLine("INGRESE NACIONALIDAD...");
      string nacionalidad = Console.ReadLine();  
      Console.WriteLine("INGRESE CAUSA...");
      string causa = Console.ReadLine();  

      Console.WriteLine("\n----DATOS DEL DETENIDO----");
      Console.WriteLine("NOMBRE:       "+ nombre);
      Console.WriteLine("DNI:          "+ dni);  
      Console.WriteLine("DOMICILIO:    "+ domicilio);  
      Console.WriteLine("NACIONALIDAD: "+ nacionalidad);  
      Console.WriteLine("CAUSA:        "+ causa); 

    }
}
