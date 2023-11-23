using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio13v2
{
    public class Pantallas
    {

        public static int[] arreglo = new int[2];
        public static int[] arreglo2 = new int[2];
        public static int[] general = { 9, 0, 0, 0, 0, 0 };
        public static string[] satisfecNonombre = { "siuuu", "Nada satisfecho", "No muy satisfecho", "Tolerable", "Satisfecho", "Muy satisfecho" };

        public static int pantallaPrincipal()
        {
            Console.Clear();
            Console.Write("=================================\n" +
                "Encuestas de Calidad\n" +
                "=================================\n" +
                "1: Realizar Encuesta\n" +
                "2: Ver datos registrados\n" +
                "3: Eliminar un dato\n" +
                "4: Ordenar datos de mayor a menor\n" +
                "5: Salir\n" +
                "=================================\n");
            return imprimir("Ingrese una opción: ");
        }

        public static int dato;
        public static int cont = 0;
        public static int cont2 = 0;
        public static int orden = 1;
        public static int orden2 = 1;

        public static int encuesta()
        {
            Console.Clear();
            Console.Write("===============================\n" +
                "Nivel de Satisfacción\n" +
                "===============================\n" +
                "¿Qué tan satisfecho está con la\n" +
                "atención de nuestra tienda?\n" +
                "1: Nada satisfecho\n" +
                "2: No muy satisfecho\n" +
                "3: Tolerable\n" +
                "4: Satisfecho\n" +
                "5: Muy satisfecho\n" +
                "==============================\n" +
                "Ingrese una opción: ");
            dato = int.Parse(Console.ReadLine());


            for (int i = dato; i == dato; i++)
            {
                general[i]++;

            }

            for (int i = orden2; i < arreglo2.Length; i++)
            {
                arreglo2[i] = dato;
                orden2++;
            }

            int[] nuevoArreglo2 = new int[arreglo2.Length + 1];
            for (int i = 1; i < arreglo2.Length; i++)
            {
                nuevoArreglo2[i] = arreglo2[i];
            }
            arreglo2 = nuevoArreglo2;


            for (int i = orden; i < arreglo.Length; i++)
            {
                arreglo[orden] = cont;
                cont++;
                orden++;
            }
            int[] nuevoArreglo = new int[arreglo.Length + 1];
            for (int i = 1; i < arreglo.Length; i++)
            {
                nuevoArreglo[i] = arreglo[i];
            }
            arreglo = nuevoArreglo;

            return nivelSatisfecho();
        }

        static int nivelSatisfecho()
        {
            int opcion = 0;
            Console.Clear();
            Console.Write("===============================\n" +
                "Nivel de Satisfacción\n" +
                "===============================\n" +
                "\n" +
                "\n" +
                "¡Gracias por participar\n" +
                "\n" +
                "\n" +
                "===============================\n");
            Console.ReadKey();
            return opcion;
        }

        public static int verDatos()
        {
            int opcion = 0;
            Console.Clear();
            Console.Write("===============================\n" +
                "Ver datos ordenados\n" +
                "===============================\n");
            for (int i = 1; i < arreglo.Length - 1; i++)
            {
                Console.Write("[" + arreglo2[i] + "] ");
            }
            Console.Write("\n");


            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(general[i] + " personas :\t" + satisfecNonombre[i]);
            }
            Console.ReadKey();
            return opcion;
        }


        public static int elimininarDatos()
        {
            int opcion = 0;
            Console.Clear();
            Console.Write("===============================\n" +
                "Eliminar un dato\n" +
                "===============================\n" +
                "\n");
            for (int i = 1; i < arreglo.Length - 1; i++)
            {
                Console.Write(arreglo[i].ToString("000") + ": [" + arreglo2[i] + "] ");
            }
            Console.Write("\n" +
                "===============================\n" +
                "Ingrese la posición a eliminar: ");

            int posicion = int.Parse(Console.ReadLine());

            int[] nuevoArreglo3 = new int[arreglo.Length - 1];

            for (int i = 0; i < arreglo.Length - 1; i++)
            {

                if (posicion > i)
                {
                    nuevoArreglo3[i] = arreglo[i];
                }
                else
                {
                    nuevoArreglo3[i] = arreglo[i + 1];
                }
            }
            arreglo = nuevoArreglo3;


            int[] nuevoArreglo4 = new int[arreglo2.Length - 1];
            for (int i = 1; i < arreglo2.Length - 1; i++)
            {

                if (posicion + 1 > i)
                {
                    nuevoArreglo4[i] = arreglo2[i];
                }
                else
                {
                    nuevoArreglo4[i] = arreglo2[i + 1];
                }
            }
            arreglo2 = nuevoArreglo4;

            for (int i = 1; i < arreglo.Length - 1; i++)
            {
                Console.Write(arreglo[i].ToString("000") + ": [" + arreglo2[i] + "] ");
            }

            Console.Write("\n===============================\n" +
                "\n");
            Console.ReadKey();
            return opcion;
        }

        public static int ordenarDatos()
        {
            int opcion = 0;
            Console.Clear();
            Console.Write("===============================\n" +
                "Ordenar datos\n" +
                "===============================\n" +
                "\n");
            for (int i = 1; i < arreglo.Length - 1; i++)
            {
                Console.Write(arreglo[i].ToString("000") + ": [" + arreglo2[i] + "] ");
            }
            Console.Write("\n" +
                "\n===============================\n" +
                "\nPresione una tecla para ordenar ");
             Console.ReadKey();
            Console.Write("\n");
            for (int ordenar = 1; ordenar < arreglo2.Length-1; ordenar++)
            {
                for (int j = 1; j < arreglo2.Length - 2; j++)
                {
                    if (arreglo2[j] > arreglo2[j + 1])
                    {
                        int aux = arreglo2[j + 1];
                        arreglo2[j + 1] = arreglo2[j];
                        arreglo2[j] = aux;
                    }
                }
            }
            Console.Write("\n");
            for (int i = 1; i < arreglo.Length - 1; i++)
            {
                Console.Write(arreglo[i].ToString("000") + ": [" + arreglo2[i] + "] ");
            }
            Console.Write("\n");
            Console.Write("\n===============================\n" +
                "\n");
            Console.Write("Presione una tecla para regresar... ");
            Console.ReadKey();
            return opcion;
        }

        static int imprimir(string Texto)
        {
            Console.Write(Texto);
            return int.Parse(Console.ReadLine());
        }
    }
}
