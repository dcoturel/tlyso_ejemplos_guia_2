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
                    linea = linea + matriz[fila, columna];
                    columna = columna + 1;
                } while (columna < kiTamano);
                Console.WriteLine(linea);
                fila = fila + 1;
            } while (fila < kiTamano);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }


    }
}
