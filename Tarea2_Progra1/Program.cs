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
                Console.WriteLine("Operaciones con tipos de datos\n");

                int int1 = 5, int2 = 4, suma=(int1+int2);
                Console.WriteLine("La suma de los enteros {0} y {1} es: {2}", int1,int2,suma);

                decimal dec1 = 10.5m, dec2 = 7.2m, resta = (dec1 - dec2);
                Console.WriteLine("La resta de los decimales {0} y {1} es: {2}", dec1,dec2,resta);

                float flot1 = 5.3f, flot2 = 2.3f, producto = (flot1 * flot2);
                Console.WriteLine("El producto de los decimales {0} y {1} es: {2}", flot1, flot2, producto);

                //Uso de try catch
                try
                {
                    Console.WriteLine("\nIngrese el primer número entero:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo número entero:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int division = num1 / num2;
                    int modulo = num1 % num2;
                    Console.WriteLine("La división de los enteros {0} y {1} es: {2}", num1, num2, division);
                    Console.WriteLine("El módulo de los enteros {0} y {1} es: {2}", num1, num2, modulo);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se ingresó un número no entero", ex.Message);
                }

                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Uso de char y string\n");

                try
                {
                    Console.WriteLine("Ingrese una cadena de texto");
                    string? cadenaTexto = Console.ReadLine();
                    string cadenaReves = new string (cadenaTexto?.Reverse().ToArray());
                    string encontrarPalabra = "programación";
                    int contarVocal = 0;

                    Console.WriteLine("La cadena '{0}' en mayúsculas: {1}", cadenaTexto, cadenaTexto?.ToUpper());
                    Console.WriteLine("La cadena '{0}' en minúsculas: {1}", cadenaTexto, cadenaTexto?.ToLower());
                    Console.WriteLine("La cadena '{0}' al revés: {1}", cadenaTexto, cadenaReves);
                    if (cadenaTexto.Contains(encontrarPalabra))
                    {
                        Console.WriteLine("La palabra {0} se encuentra en la cadena de texto", encontrarPalabra);
                    }
                    else
                    {
                        Console.WriteLine("No está la palabra '{0}' en la cadena papito :c", encontrarPalabra);
                    }

                    //Contar Vocal
                    foreach (char vocal in cadenaTexto)
                    {
                        if ("aeiouAEIOU".Contains(vocal))
                        {
                            contarVocal++;
                        }
                    }
                    Console.WriteLine("El número de vocales en el texto es: " + contarVocal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
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