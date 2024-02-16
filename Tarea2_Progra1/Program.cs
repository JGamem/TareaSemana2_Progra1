byte option = 0;

do
{
    if (option is < 1 or > 4)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Menú \n");
        Console.WriteLine("1. Conversión de tipos");
        Console.WriteLine("2. Operaciones con tipos de datos");
        Console.WriteLine("3. Uso de char y string");
        Console.WriteLine("4. Uso de tipos de datos numéricos");
        Console.WriteLine("5. Salir\n");
        Console.WriteLine("Ingrese una opción");
    }

    if (byte.TryParse(Console.ReadLine(), out option))
    {
        switch (option)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Conversión de tipos\n");
                
                //Entero a decimal
                int numInt = 15;
                decimal enteroDecimal = Convert.ToDecimal(numInt);
                Console.WriteLine("Entero a decimal: {0}",enteroDecimal);
                //Decimal a float
                decimal numDec = 5.5m;
                float decimalFloat = Convert.ToSingle(numDec);
                Console.WriteLine("Decimal a flotante: {0}", decimalFloat);
                //Flotante a entero
                float numFloat = 8.5f;
                int floatInt = Convert.ToInt32(numFloat);
                Console.WriteLine("Flotante a decimal: {0}", floatInt);
                //Caracter a entero
                char caracter = 'd';
                int charInt = Convert.ToInt32(caracter);
                Console.WriteLine("Caracter a entero: {0}", charInt);
                //Entero a caracter
                int entero = 99;
                char intChar = Convert.ToChar(entero);
                Console.WriteLine("Entero a char: {0}", intChar);
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("Operaciones con tipos de datos");
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Uso de char y string");
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Uso de tipos de datos numéricos");
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("Saliendo del menú...");
                break;
            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Intente nuevamente con una opción válida");
                Thread.Sleep(2000);
                break;
        }
    }

    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor, ingrese un número válido");
        Thread.Sleep(2000);
    }
} while (option != 5);