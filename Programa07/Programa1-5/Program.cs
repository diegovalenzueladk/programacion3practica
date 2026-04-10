namespace programa7;
class Program
{
    static void Main (string [] args)
    {
     // --- CONSTANTES DE CÁLCULO Y CONTROL ---
            const decimal TASA_IVA = 0.21m; // 21% fijo
            const bool MODO_PRUEBA = false; // Control de seguridad
            const char SIMBOLO_PESO = '$';

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

            decimal precioBase = 1500.50m;
            decimal impuestoCalculado = precioBase * TASA_IVA;
            decimal total = precioBase + impuestoCalculado;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
            Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);
            Console.WriteLine("\nPrecione ENTER para continuar...");  
            Console.ReadLine();

        // Ejercicio 1
         Console.WriteLine("------DESCUENTO POR PAGO EN EFECTIVO------");
        const decimal descuento=0.15m; 
        char peso ='$';
        decimal precio= 6700;
        decimal calculoefectivo= precio * descuento;
        decimal totalpagar= precio - calculoefectivo;
        
        Console.WriteLine("\nPrecio del repuesto del vehiculo");
        Console.WriteLine("con debito o tarjeta");
        Console.WriteLine("TOTAL A PAGAR: "+peso+precio);
        Console.WriteLine("\nDescuento paga en efectivo");
        Console.WriteLine("TOTAL A PAGAR: "+peso +totalpagar);
        Console.WriteLine("\nPrecione ENTER para continuar...");  
        Console.ReadLine();

        // Ejercicio 2
        Console.WriteLine("------RECARGO POR PAGO ATRASADO------");
        const decimal recargo=0.32m; 
        decimal pagovencido= 94000;
        decimal calcularpago= pagovencido * recargo;
        decimal pagoactual= pagovencido + calcularpago;
        
        Console.WriteLine("\nTOTAL A PAGAR VENCIDO: "+peso+pagovencido);
        Console.WriteLine("TOTAL A PAGAR ACTUAL CON RECARGO DEL "+(recargo*100)+" % : " +peso+pagoactual);
        Console.WriteLine("\nSe le informa que tiene un plazo de 5 dias para pagar sino se cobra otro recargo de "+(recargo*100)+" %");
        Console.WriteLine("\nPrecione ENTER para continuar...");  
        Console.ReadLine();

        // ejercicio 3
        Console.WriteLine("------PORCENTAJE DE PROPINA------");
        const decimal propina=0.03m; 
        decimal preciosin= 13000;
        decimal calcularpropina= preciosin * propina;
        decimal preciocon= preciosin + calcularpropina;
        
        Console.WriteLine("\nTOTAL A PAGAR: "+peso+preciosin);
        Console.WriteLine("\nPrecio sugerido con propina de un "+(propina*100)+" %");
        Console.WriteLine("TOTAL A PAGAR:"+peso+preciocon);
        Console.WriteLine("\nSe le informa que solo es una sugerencia... muchas gracias vuelva pronto!!");
        Console.WriteLine("\nPrecione ENTER para continuar...");  
        Console.ReadLine();

        // ejercicio 4
        Console.WriteLine("------AUMENTO DE VEHICULO POR MES------");
        const decimal aumento=0.02m; 
        decimal preciomoto= 25000;
        decimal calcularpreciomoto= preciomoto * aumento;
        decimal preciomotocon= preciosin + calcularpreciomoto;
        
        Console.WriteLine("\nPRECIO ACTUAL DE LA MOTO: "+peso+preciomoto);
        Console.WriteLine("\nLa moto tiene un aumento de "+(aumento*100)+" % mensual");
        Console.WriteLine("PRECIO ESTIMADO PROXIMO MES:"+peso+preciomotocon);
        Console.WriteLine("\nHasta luego...");
        Console.WriteLine("\nPrecione ENTER para continuar...");  
        Console.ReadLine();

        // ejercicio 5
        Console.WriteLine("------CARGA COMBUSTIBLE------");
        decimal preciolitronasfta= 2114;
        decimal litrosauto= 50;
        decimal calculartotal= preciolitronasfta * litrosauto;
    
        Console.WriteLine("\nPRECIO POR LITRO: "+peso+preciolitronasfta);
        Console.WriteLine("TOTAL DE LITROS VENDIDO:"+litrosauto +" L");
        Console.WriteLine("PRECIO TOTAL A PAGAR: "+peso+calculartotal);
        Console.WriteLine("\nMuchas gracias... Vuelva pronto");
        Console.WriteLine("\nPrecione ENTER para SALIR...");  
        Console.ReadLine();

    }
}