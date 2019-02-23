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
    }

}
