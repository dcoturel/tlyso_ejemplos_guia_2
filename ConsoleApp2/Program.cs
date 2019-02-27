using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ejercicio = 0;
            Console.WriteLine("Ingrese el numero de ejercicio a ejecutar");
            ejercicio = Convert.ToInt32(Console.ReadLine());
            switch (ejercicio)
            {
                case 1:
                    ejercicio1();
                    break;
                case 2:
                    ejercicio2();
                    break;
                case 3:
                    ejercicio3();
                    break;
                case 4:
                    ejercicio4();
                    break;
                case 5:
                    ejercicio5();
                    break;
                case 6:
                    ejercicio6();
                    break;
                case 7:
                    ejercicio7();
                    break;
                case 8:
                    ejercicio8();
                    break;
                case 9:
                    ejercicio9();
                    break;
                case 10:
                    ejercicio10();
                    break;
            }
        }

        private static void ejercicio1() {
            const int kiTamano = 5;
            int[,] matriz = new int[kiTamano, kiTamano];
            int fila = 0;
            int columna = 0;
            String linea = "";

            do
            {
                columna = 0;
                do {

                    if (fila == columna || (fila + columna) == kiTamano - 1)
                    {
                        matriz[fila, columna] = 1;
                    }
                    else
                    {
                        matriz[fila, columna] = 0;
                    }
                    columna = columna + 1;
                } while (columna < kiTamano);
                fila = fila + 1;
            } while (fila < kiTamano);

            fila = 0;
            do {
                columna = 0;
                linea = "";
                do {
                    linea = linea + "\t" + matriz[fila, columna];
                    columna = columna + 1;
                } while (columna < kiTamano);
                Console.WriteLine(linea);
                fila = fila + 1;
            } while (fila < kiTamano);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        private static void ejercicio2() {
            const int kiFilas = 20;
            const int kiColumnas = 5;
            int[,] matriz = new int[kiFilas, kiColumnas];
            int fila = 0;
            int columna = 0;
            String linea = "";
            int contador = 0;

            do
            {
                columna = 0;
                do
                {

                    contador = contador + 1;
                    matriz[fila, columna] = contador;
                    columna = columna + 1;
                } while (columna < kiColumnas);
                fila = fila + 1;
            } while (fila < kiFilas);

            fila = 0;
            do
            {
                columna = 0;
                linea = "";
                do
                {
                    linea = linea + "\t" + matriz[fila, columna];
                    columna = columna + 1;
                } while (columna < kiColumnas);
                Console.WriteLine(linea);
                fila = fila + 1;
            } while (fila < kiFilas);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        private static void ejercicio3()
        {
            const int kiFilas = 20;
            const int kiColumnas = 5;
            int[,] matriz = new int[kiFilas, kiColumnas];
            int fila = 0;
            int columna = 0;
            String linea = "";
            int contador = 0;

            do
            {

                if (fila % 2 == 0)
                {
                    columna = 0;
                    do
                    {

                        contador = contador + 1;
                        matriz[fila, columna] = contador;
                        columna = columna + 1;
                    } while (columna < kiColumnas);
                }
                else
                {
                    columna = kiColumnas -1;
                    do
                    {

                        contador = contador + 1;
                        matriz[fila, columna] = contador;
                        columna = columna - 1;
                    } while (columna >= 0);

                }

                fila = fila + 1;
            } while (fila < kiFilas);

            fila = 0;
            do
            {
                columna = 0;
                linea = "";
                do
                {
                    linea = linea + "\t" + matriz[fila, columna];
                    columna = columna + 1;
                } while (columna < kiColumnas);
                Console.WriteLine(linea);
                fila = fila + 1;
            } while (fila < kiFilas);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        private static void ejercicio4()
        {
            const int kiFilas = 20;
            const int kiColumnas = 5;
            int[,] matriz = new int[kiFilas, kiColumnas];
            int fila = 0;
            int columna = 0;
            String linea = "";
            int contador = 101;

            do
            {

                if (columna % 2 == 0)
                {
                    fila = 0;
                    do
                    {

                        contador = contador - 1;
                        matriz[fila, columna] = contador;
                        fila = fila + 1;
                    } while (fila < kiFilas);
                }
                else
                {
                    fila = kiFilas - 1;
                    do
                    {

                        contador = contador - 1;
                        matriz[fila, columna] = contador;
                        fila = fila - 1;
                    } while (fila >= 0);

                }

                columna = columna + 1;
            } while (columna < kiColumnas);

            fila = 0;
            do
            {
                columna = 0;
                linea = "";
                do
                {
                    linea = linea + "\t" + matriz[fila, columna];
                    columna = columna + 1;
                } while (columna < kiColumnas);
                Console.WriteLine(linea);
                fila = fila + 1;
            } while (fila < kiFilas);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        private static void ejercicio5()
        {
            const int kiFilas = 20;
            const int kiColumnas = 5;
            int[,] matriz = new int[kiFilas, kiColumnas];
            int fila = 0;
            int columna = 0;
            String linea = "";
            int contador = 0;

            do
            {

                    columna = kiColumnas - 1;
                    do
                    {

                        contador = contador + 1;
                        matriz[fila, columna] = contador;
                        columna = columna - 1;
                    } while (columna >= 0);

                fila = fila + 1;
            } while (fila < kiFilas);

            fila = 0;
            do
            {
                columna = 0;
                linea = "";
                do
                {
                    linea = linea + "\t" + matriz[fila, columna];
                    columna = columna + 1;
                } while (columna < kiColumnas);
                Console.WriteLine(linea);
                fila = fila + 1;
            } while (fila < kiFilas);

            Console.WriteLine("Press any key");
            Console.ReadKey();

        }

        private static void ejercicio6()
        {
            const int filas = 100;
            String nombreIngresar = "";
            String direccionIngresar = "";
            String telefonoIngresar = "";
            String[] nombres = new String[filas];
            String[] direcciones = new string[filas];
            String[] telefonos = new String[filas];
            String Continuar = "S";
            String nombreBuscar = "";
            int posicion = 0;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese un nombre de cliente");
                    nombreIngresar = Console.ReadLine();
                    if (nombreIngresar.Equals("")) {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (nombreIngresar.Equals(""));

                do
                {
                    Console.WriteLine("Ingrese una direccion");
                    direccionIngresar = Console.ReadLine();
                    if (direccionIngresar.Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (direccionIngresar.Equals(""));


                do
                {
                    Console.WriteLine("Ingrese un telefono");
                    telefonoIngresar = Console.ReadLine();
                    if (telefonoIngresar.Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (telefonoIngresar.Equals(""));

                nombres[posicion] = nombreIngresar;
                telefonos[posicion] = telefonoIngresar;
                direcciones[posicion] = direccionIngresar;
                nombreIngresar = "";
                telefonoIngresar = "";
                direccionIngresar = "";
                posicion = posicion + 1;

                do
                {
                    Console.WriteLine("¿Desea continuar cargando clientes? S/N");
                    Continuar = Console.ReadLine().ToUpper();
                    if (!Continuar.Equals("S") && !Continuar.Equals("N"))
                    {
                        Console.WriteLine("Debe ingresar S o N");
                    }
                } while (!Continuar.Equals("S") && !Continuar.Equals("N"));

            } while (Continuar.Equals("S") && posicion < filas);

            do
            {
                Console.WriteLine("Ingrese un nombre de cliente");
                nombreBuscar = Console.ReadLine();
                if (nombreBuscar.Equals(""))
                {
                    Console.WriteLine("Debe ingresar un valor");
                }
            } while (nombreBuscar.Equals(""));

            posicion = 0;

            do
            {
                posicion = posicion + 1;
            } while (!nombres[posicion].Equals(nombreBuscar)&&posicion<filas-1);

            if (nombres[posicion].Equals(nombreBuscar))
            {
                Console.WriteLine("Nombre: " + nombres[posicion]);
                Console.WriteLine("Direccion: " + direcciones[posicion]);
                Console.WriteLine("Telefono: " + telefonos[posicion]);
            }
            else
            {
                Console.WriteLine("No se registra cliente con el nombre ingresado");
            }

            Console.WriteLine("Press any key");
            Console.Read();
        }

        private static void ejercicio7()
        {
            const int filas = 100;
            const int notaAprobada = 4;
            String[] alumnos = new String[filas];
            int[] notas = new int[filas];
            String alumnoIngresar = "";
            int notaIngresar = 0;
            int posicion = 0;
            String Continuar = "S";

            do
            {
                do
                {
                    Console.WriteLine("Ingrese un nombre de alumno");
                    alumnoIngresar = Console.ReadLine();
                    if (alumnoIngresar.Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (alumnoIngresar.Equals(""));

                do
                {
                    Console.WriteLine("Ingrese una nota");
                    notaIngresar = Convert.ToInt32(Console.ReadLine());
                    if (notaIngresar<0||notaIngresar>10)
                    {
                        Console.WriteLine("Debe ingresar un valor entre 0 y 10");
                    }
                } while (notaIngresar < 0 || notaIngresar > 10);

                alumnos[posicion] = alumnoIngresar;
                notas[posicion] = notaIngresar;

                do
                {
                    Console.WriteLine("¿Desea continuar cargando notas? S/N");
                    Continuar = Console.ReadLine().ToUpper();
                    if (!Continuar.Equals("S") && !Continuar.Equals("N"))
                    {
                        Console.WriteLine("Debe ingresar S o N");
                    }
                } while (!Continuar.Equals("S") && !Continuar.Equals("N"));

                posicion = posicion + 1;
            } while (Continuar.Equals("S") && posicion < filas);

            posicion = 0;
            Console.WriteLine("Alumnos aprobados:");
            do
            {
                if (notas[posicion]>notaAprobada)
                {
                    Console.WriteLine(alumnos[posicion]);
                }
                posicion = posicion + 1;
            } while (posicion < filas);

            Console.WriteLine("Press any key");
            Console.Read();
        }

        private static void ejercicio8()
        {
            const int filas = 100;
            const int columnas = 2;
            const int colCodigo = 0;
            const int colRazonSocial = 1;

            String[, ] clientes = new String[filas, columnas];
            double[] ventas = new double[filas];

            String[] clienteMasVenta = new string[columnas];
            double ventaMaxima = 0;

            String[] clienteMenosVenta = new string[columnas];
            double ventaMinima = 0;

            double promedioVenta = 0;

            String codigoIngresar = "";
            String razonSocialIngresar = "";
            double ventaIngresar = 0;

            int posicion = 0;
            String Continuar = "S";

            do
            {
                codigoIngresar = "";
                razonSocialIngresar = "";
                ventaIngresar = 0;

                do
                {
                    Console.WriteLine("Ingrese un codigo de cliente");
                    codigoIngresar = Console.ReadLine();
                    if (codigoIngresar.Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (codigoIngresar.Equals(""));

                do
                {
                    Console.WriteLine("Ingrese una razon social");
                    razonSocialIngresar = Console.ReadLine();
                    if (razonSocialIngresar.Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (razonSocialIngresar.Equals(""));

                do
                {
                    Console.WriteLine("Ingrese las ventas del periodo");
                    ventaIngresar = Convert.ToDouble(Console.ReadLine());
                    if (ventaIngresar.Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (ventaIngresar.Equals(""));

                clientes[posicion, colCodigo] = codigoIngresar;
                clientes[posicion, colRazonSocial] = razonSocialIngresar;
                ventas[posicion] = ventaIngresar;

                do
                {
                    Console.WriteLine("¿Desea continuar cargando notas? S/N");
                    Continuar = Console.ReadLine().ToUpper();
                    if (!Continuar.Equals("S") && !Continuar.Equals("N"))
                    {
                        Console.WriteLine("Debe ingresar S o N");
                    }
                } while (!Continuar.Equals("S") && !Continuar.Equals("N"));

                posicion = posicion + 1;
            } while (Continuar.Equals("S") && posicion < filas);

            posicion = 0;

            do
            {
                if (posicion == 0)
                {
                    ventaMaxima = ventas[posicion];
                    clienteMasVenta[colCodigo] = clientes[posicion, colCodigo];
                    clienteMasVenta[colRazonSocial] = clientes[posicion, colRazonSocial];

                    ventaMinima = ventas[posicion];
                    clienteMenosVenta[colCodigo] = clientes[posicion, colCodigo];
                    clienteMenosVenta[colRazonSocial] = clientes[posicion, colRazonSocial];

                }
                else
                {
                    if (ventas[posicion]>ventaMaxima)
                    {
                        ventaMaxima = ventas[posicion];
                        clienteMasVenta[colCodigo] = clientes[posicion, colCodigo];
                        clienteMasVenta[colRazonSocial] = clientes[posicion, colRazonSocial];
                    }
                    if (ventas[posicion] < ventaMinima)
                    {
                        ventaMinima = ventas[posicion];
                        clienteMenosVenta[colCodigo] = clientes[posicion, colCodigo];
                        clienteMenosVenta[colRazonSocial] = clientes[posicion, colRazonSocial];
                    }
                }
                promedioVenta = promedioVenta + ventas[posicion];
                posicion = posicion + 1;
            } while (posicion < filas - 1 && clientes[posicion, colCodigo] != null);

            Console.WriteLine("Cliente con mas ventas: " + clienteMasVenta[colCodigo] + " - " + clienteMasVenta[colRazonSocial]);
            Console.WriteLine("Ventas: " + ventaMaxima);

            Console.WriteLine("Cliente con menos ventas: " + clienteMenosVenta[colCodigo] + " - " + clienteMenosVenta[colRazonSocial]);
            Console.WriteLine("Ventas: " + ventaMinima);

            Console.WriteLine("Venta promedio: " + promedioVenta / posicion);

            Console.WriteLine("Press any key");
            Console.Read();
        }

        private static void ejercicio9()
        {
            const int filas = 5;
            String[] palabras = new String[filas];
            String palabraIngresar = "";
            String auxiliar = "";
            int posicion = 0;
            int contPasadas = 0;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese una palabra");
                    palabraIngresar = Console.ReadLine();
                    if (palabraIngresar.Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (palabraIngresar.Equals(""));
                palabras[posicion] = palabraIngresar;
                posicion = posicion + 1;
            } while (posicion < filas);

            posicion = 0;

            do
            {
                Console.WriteLine("# " + posicion + ": " + palabras[posicion]);
                posicion = posicion + 1;
            } while (posicion < filas);

            posicion = 0;

            do
            {
                posicion = 0;
                do
                {
                    if (String.Compare(palabras[posicion], palabras[posicion + 1], StringComparison.Ordinal) > 0)
                    {
                        auxiliar = palabras[posicion];
                        palabras[posicion] = palabras[posicion + 1];
                        palabras[posicion + 1] = auxiliar;
                    }
                    posicion = posicion + 1;
                } while (posicion < filas - 1);
                contPasadas = contPasadas + 1;
            } while (contPasadas < filas -1);

            posicion = 0;

            do
            {
                Console.WriteLine("# " + posicion + ": " + palabras[posicion]);
                posicion = posicion + 1;
            } while (posicion < filas);

            Console.WriteLine("Press any key");
            Console.Read();

        }

        private static void ejercicio10()
        {
            const int filas = 1000;
            const int columnas = 3;
            const int colCodigo = 0;
            const int colRazonSocial = 1;
            const int colDomicilio = 2;
            String[, ] clientes = new String[filas, columnas];
            int posicion = 0;
            int columnaFiltrar = 0;
            int contPasadas = 0;
            int contColumnas = 0;
            String continuar = "";
            String auxiliar;

            do
            {

                do
                {
                    Console.WriteLine("Ingrese codigo");
                    clientes[posicion, colCodigo] = Console.ReadLine();
                    if (clientes[posicion, colCodigo].Equals("")) {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (clientes[posicion, colCodigo].Equals(""));

                do
                {
                    Console.WriteLine("Ingrese razon social");
                    clientes[posicion, colRazonSocial] = Console.ReadLine();
                    if (clientes[posicion, colRazonSocial].Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (clientes[posicion, colRazonSocial].Equals(""));

                do
                {
                    Console.WriteLine("Ingrese domicilio");
                    clientes[posicion, colDomicilio] = Console.ReadLine();
                    if (clientes[posicion, colDomicilio].Equals(""))
                    {
                        Console.WriteLine("Debe ingresar un valor");
                    }
                } while (clientes[posicion, colDomicilio].Equals(""));

                
                do
                {
                    Console.WriteLine("¿Desea continuar cargando notas? S/N");
                    continuar = Console.ReadLine().ToUpper();
                    if (!continuar.Equals("S") && !continuar.Equals("N"))
                    {
                        Console.WriteLine("Debe ingresar S o N");
                    }
                } while (!continuar.Equals("S") && !continuar.Equals("N"));
                posicion = posicion + 1;
            } while (posicion < filas && continuar.Equals("S"));

            do
            {
                Console.WriteLine("Ingrese columna por la cual ordenara el listado:");
                Console.WriteLine("1. Codigo");
                Console.WriteLine("2. Razon social");
                Console.WriteLine("3. Domicilio");
                columnaFiltrar = Convert.ToInt32(Console.ReadLine());
                if (columnaFiltrar < colCodigo || columnaFiltrar > colDomicilio)
                {
                    Console.WriteLine("Debe ingresar un valor entre 1 y 3");
                }
            } while (columnaFiltrar < colCodigo || columnaFiltrar > colDomicilio);

            posicion = 0;

            do
            {
                posicion = 0;
                do
                {
                    contColumnas = 0;
                    if (clientes[posicion + 1, columnaFiltrar]!=null)
                    {
                        if (String.Compare(clientes[posicion, columnaFiltrar], clientes[posicion + 1, columnaFiltrar], StringComparison.Ordinal) > 0)
                        {
                            do
                            {

                                auxiliar = clientes[posicion, contColumnas];
                                clientes[posicion, contColumnas] = clientes[posicion + 1, contColumnas];
                                clientes[posicion + 1, contColumnas] = auxiliar;
                                contColumnas = contColumnas + 1;
                            } while (contColumnas < columnas);

                        }
                    }                    
                    posicion = posicion + 1;
                } while (posicion < filas - 1);
                contPasadas = contPasadas + 1;
            } while (contPasadas < filas - 1);

            posicion = 0;

            do
            {
                Console.WriteLine("# " + posicion + "\t" + clientes[posicion, colCodigo] + "\t" + clientes[posicion, colRazonSocial] + "\t" + clientes[posicion, colDomicilio]);
                posicion = posicion + 1;
            } while (posicion < filas -1 && clientes[posicion, colCodigo] != null);

            Console.WriteLine("Press any key");
            Console.Read();
        }
    }

}
