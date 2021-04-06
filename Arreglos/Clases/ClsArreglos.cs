using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Clases
{
    class ClsArreglos
    {
        private int[] ArregloTemporal;
        private int[] datos;
        private int i, j, datoTemporal, minimo;
        private int tamanoArreglo = 0;

        private string[] NombreTemporal;
        private string[] nombres;
        private string Auxiliar;

        public int GetTamañoArreglo()
        {
            return datos.Length;
        }

        public ClsArreglos(int[] arreglo)
        {
            datos = arreglo;
            tamanoArreglo = datos.Length; //Número de datos.
        }

        public ClsArreglos(string[] arreglo)
        {
            nombres = arreglo;
            tamanoArreglo = nombres.Length;
        }

        /// <summary>
        /// Burbuja.
        /// Intercambiar cada pareja consecutiva no ordenada.
        /// </summary>
        /// <returns></returns>
        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;

            for (i = 0; i < tamanoArreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporal[i] > ArregloTemporal[j])
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }



        //--------------TAREA----------------

        public int[] MetodoSeleccion()
        {
            ArregloTemporal = datos;

            for(i = 0; i < tamanoArreglo; i++)
            {
                minimo = i;
                for(j = i + 1; j < tamanoArreglo; j++)
                {
                    if(ArregloTemporal[j] < ArregloTemporal[minimo])
                    {
                        minimo = j;
                    }
                }
                datoTemporal = ArregloTemporal[i];
                ArregloTemporal[i] = ArregloTemporal[minimo];
                ArregloTemporal[minimo] = datoTemporal;
            }
            return ArregloTemporal;
        }

        public int[] MetodoInsercion()
        {
            ArregloTemporal = datos;
            for(i = 0; i < tamanoArreglo; i++)
            {
                datoTemporal = ArregloTemporal[i];
                j = i - 1;
                while(j >= 0 && ArregloTemporal[j] > datoTemporal)
                {
                    ArregloTemporal[j + 1] = ArregloTemporal[j];
                    j--;
                }
                ArregloTemporal[j + 1] = datoTemporal;
            }
            return ArregloTemporal;
        }

        public string[] MetodoBurbujaNombre()
        {
            NombreTemporal = nombres;

            //Comparison<string> comparador = new Comparison<string>((cadena1, cadena2) => cadena1.CompareTo(cadena2));
            //Array.Sort(NombreTemporal, comparador);

            for (i = 0; i < tamanoArreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoArreglo; j++)
                {
                    if (NombreTemporal[i].CompareTo(NombreTemporal[j]) > 0)
                    {
                        Auxiliar = NombreTemporal[i];
                        NombreTemporal[i] = NombreTemporal[j];
                        NombreTemporal[j] = Auxiliar;
                    }
                }
            }
            return NombreTemporal;
        }
    }
}
