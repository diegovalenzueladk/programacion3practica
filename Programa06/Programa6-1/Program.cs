using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace Programa6;
class Program
{
    static void Main (string []args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP = "GameMaster Pro";
            const string VERSION = "v1.0.2";
            const int EDAD_MINIMA = 18;

            Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");
            
                     // Intento de uso con constantes (sin estructuras de control)
            const int EDAD_CLIENTE = 20;
            const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
            Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
            Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

                      // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
            Console.WriteLine("Constante VERSION = " + VERSION);
            Console.WriteLine("");
            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();
            
            // --- EJEMPLO 1 --- //
            const string USUARIO = "bope_br";
            const string JUEGO = "COUNTER STRIKE (v2.2.1)";
            const string CONTRASEÑA= "bope123";
            bool INGRESAR= true;
            Console.WriteLine("=== Hola bienvenidos a "+JUEGO+" ===");
            Console.WriteLine("Usuario: '"+USUARIO+"'");
            Console.WriteLine("Contraseña: '"+CONTRASEÑA+"'");
            Console.WriteLine("Son Correcto? :"+INGRESAR);
            Console.WriteLine("CARGANDO... "+JUEGO+" MUCHAS GRACIAS...!!");
            Console.WriteLine("");
            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();
          
            // --- EJEMPLO 2 --- //
            const string NOMBRE = "Facebook";
            const string VERS = "v1.0.2";
            const int MINIMA = 18;

            Console.WriteLine("==== '" + NOMBRE + " (" + VERS + ")' ====");
            Console.WriteLine("Cargando datos del sistema...");
            Console.WriteLine("Restricción: Prohibido el ingreso a menores de " + MINIMA + " años.");
            
            const int CLIENTE = 22;
            const bool PUEDEINGRESAR = CLIENTE >= MINIMA; 

            Console.WriteLine("\nVerificando cliente de " + CLIENTE + " años...");
            Console.WriteLine("Edad mínima: " + MINIMA);
            Console.WriteLine("Acceso permitido : " + PUEDEINGRESAR);
            Console.WriteLine("");
            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();

            // --- EJEMPLO 3 --- //
            const string app= "Straba";
            const string ver= "(2.0)";
            const int ruta=30000;
            const int rutmin=5;
            const bool puedercargar= ruta >= rutmin;
            
            Console.WriteLine("=== "+app+ver+" ===");
            Console.WriteLine("Verificando datos...");
            Console.WriteLine("Advertencia 'Solo se cargan ruta mayores a "+ rutmin+" km'");
            Console.WriteLine("Cargando ruta :" + puedercargar);
            Console.WriteLine("Ruta cargada, distancia recorrida de '"+ruta+" km"+"' Felicidades!!");
            Console.WriteLine("");
            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();
            
            // --- EJEMPLO 4 --- //
            const string local = "MOTOFAST";
            const string tituar = "Fabricio Balderrama";
            const string moto= "Honda cg 150cc";
            const int motokm= 3000;
            const int maxkm= 3000;
            const bool ingresoo = motokm <= maxkm;

            Console.WriteLine("====== "+local+" =====");
            Console.WriteLine("Advertencia Solo ingresar motos con '"+maxkm+"km' o menos... ");
            Console.WriteLine("Datos de la moto para realizar service");
            Console.WriteLine("Titular: '"+tituar+"'");
            Console.WriteLine("Moto: '"+moto+"'");
            Console.WriteLine("km: '"+motokm+"'");
            Console.WriteLine("Ingreso Permitido :"+INGRESAR);
            Console.WriteLine("Hasta luego... Nosotros lo llamaremos!");
            Console.WriteLine("");
            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();


            // --- EJEMPLO 5 --- //
            const string p = "VERIFICACION DE SEGURIDAD";
            const string j = "diego";
            const string c= "diego123";

            Console.WriteLine("=== "+p+" ===");
            Console.WriteLine("=====Ingrese su datos===== ");
            Console.Write("\nUsuario: ");
            string j1 = Console.ReadLine();
            Console.Write("\nContraseña: ");
            string c1 = Console.ReadLine();

            bool datoscorrectos= (j==j1) && (c==c1);

            Console.WriteLine("\nlos datos son Correcto? :"+datoscorrectos);
            Console.WriteLine("!!...MUCHAS GRACIAS...!!");
            Console.WriteLine("");
            Console.WriteLine("\nPresiona ENTER para Cerrar...");
            Console.ReadLine();



    }
}