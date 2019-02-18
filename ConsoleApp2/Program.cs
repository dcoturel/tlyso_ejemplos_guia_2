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


    }
}
