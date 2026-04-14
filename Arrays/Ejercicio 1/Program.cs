namespace Ejercicio01;
class Program

{
    static void Main (string[]args)
    {
         int[] numeros = new int[3];
        numeros[0] = 52;
        numeros[1] = 19;
        numeros[2] = 28;

        Console.WriteLine("--- FUNDAMENTOS CON ARREGLOS ---");
        Console.WriteLine("--- EJERCICIO 1 ---");

        Console.WriteLine("Valor en índice 0: " + numeros[0]);
        Console.WriteLine("Valor en índice 1: " + numeros[1]);
        Console.WriteLine("Valor en índice 2: " + numeros[2]);

        Console.WriteLine("\nPresione Enter para continuar...");
        Console.ReadLine();

        //------------------------------------------------------

        int[] numeros1= new int[4];
        numeros1[0]=23;
        numeros1[1]=25;
        numeros1[2]=27;
        numeros1[3]=29;
        Console.WriteLine("--- EJERCICIO 2 ---");
        Console.WriteLine("Valor en índice 0: " +numeros1[0]);
        Console.WriteLine("Valor en índice 1: " +numeros1[1]);
        Console.WriteLine("Valor en índice 2: " +numeros1[2]);
        Console.WriteLine("Valor en índice 3: " +numeros1[3]);
        Console.WriteLine("\nPresione Enter para continuar...");
        Console.ReadLine();

        //-----------------------------------------------------
        int [] numeros2= new int[5];
        numeros2[0]=33;
        numeros2[1]=35;
        numeros2[2]=37;
        numeros2[3]=39;
        numeros2[4]=30;
        Console.WriteLine("--- EJERCICIO 3 ---");
        Console.WriteLine("Valor en índice 0: " +numeros2[0]);
        Console.WriteLine("Valor en índice 1: " +numeros2[1]);
        Console.WriteLine("Valor en índice 2: " +numeros2[2]);
        Console.WriteLine("Valor en índice 3: " +numeros2[3]);
        Console.WriteLine("valor en indice 4: " +numeros2[4]);
        Console.WriteLine("\nPresione Enter para continuar...");
        Console.ReadLine();

        //------------------------------------------------------
        int[] numeros3= new int[2];
        numeros3[0]=45;
        numeros3[1]=42;
        Console.WriteLine("--- EJERCICIO 4 ---");
        Console.WriteLine("valores en indice 0: "+numeros3[0]);
        Console.WriteLine("valores en indice 1: "+numeros3[1]);
        Console.WriteLine("\nPresiones Enter Para Continuar...");
        Console.ReadLine();
        //--------------------------------------------------------
        int[] edades= new int[4];
        edades[0]=11;
        edades[1]=9;
        edades[2]=45;
        edades[3]=12;
        Console.WriteLine("--- EJERCICIO 5 ---");
        Console.WriteLine("Juan tiene "+edades[0] +" años");
        Console.WriteLine("Melisa tiene "+edades[1] +" años");
        Console.WriteLine("Octavio tiene "+edades[2] +" años");
        Console.WriteLine("Angela tiene "+edades[3] +" años");
        Console.WriteLine("\nPrecione Enter Para Salir" );


    }
}
