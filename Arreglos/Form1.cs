using Arreglos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        private int[] resultado1;
        private int[] resultado2;
        private int[] resultado3;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int[] arreglo = new int[5];
            arreglo[0] = 10;
            arreglo[1] = 8;
            arreglo[2] = 16;
            arreglo[3] = 36;
            arreglo[4] = 1;

            ClsArreglos ObjArreglo = new ClsArreglos(arreglo);
            int[] resultado = ObjArreglo.MetodoBurbuja();
            //var otro = arreglo[].sort;
           
            for (int indice = 0; indice < resultado.Length; indice++)
            {
                //listBoxResultado.Items.Add(arreglo[indice]);
                listBoxResultado.Items.Add($"valor = {resultado[indice]}");
            }

            //foreach(int r in arreglo)
            //{
            //    listBoxResultado.Items.Add(r);
            //}
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\jeant\Desktop";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBoxContenido.Text = resultado;
            }
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int contador = 0;
            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    listBoxResultado.Items.Add(datos[1]);
                }
                contador++;
            }
        }



        //---------------------------TAREA------------------------------

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int[] Parcial1 = new int[ArregloNotas.Length - 1];
            int[] Parcial2 = new int[ArregloNotas.Length - 1];
            int[] Parcial3 = new int[ArregloNotas.Length - 1];
            int contador = 0;
            
            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    Parcial1[contador - 1] = Convert.ToInt32(datos[2]);
                    Parcial2[contador - 1] = Convert.ToInt32(datos[3]);
                    Parcial3[contador - 1] = Convert.ToInt32(datos[4]);
                }
                contador++;
            }
            
            ClsArreglos ObjParcial1 = new ClsArreglos(Parcial1);
            ClsArreglos ObjParcial2 = new ClsArreglos(Parcial2);
            ClsArreglos ObjParcial3 = new ClsArreglos(Parcial3);
            
            resultado1 = ObjParcial1.MetodoBurbuja();
            resultado2 = ObjParcial2.MetodoSeleccion();
            resultado3 = ObjParcial3.MetodoInsercion();

            listBoxResultado.Items.Add("Primero Segundo Tercero");

            for (int indice = 0; indice < resultado1.Length; indice++)
            {
                listBoxResultado.Items.Add($"{resultado1[indice]}\t{resultado2[indice]}\t{resultado3[indice]}");
            }
            buttonPromedio.Enabled = true;
            labelAviso.Visible = false;
        }

        private void buttonPromedio_Click(object sender, EventArgs e)
        {
            int TamañoArreglo = resultado1.Length;
            double PromedioPrimero = 0;
            double PromedioSegundo = 0;
            double PromedioTercero = 0;

            for(int i = 0; i < TamañoArreglo; i++)
            {
                PromedioPrimero += resultado1[i];
                PromedioSegundo += resultado2[i];
                PromedioTercero += resultado3[i];
            }
            PromedioPrimero /= TamañoArreglo;
            PromedioSegundo /= TamañoArreglo;
            PromedioTercero /= TamañoArreglo;

            textBoxPrimero.Text = Convert.ToString(Math.Round(PromedioPrimero,2));
            textBoxSegundo.Text = Convert.ToString(Math.Round(PromedioSegundo,2));
            textBoxTercero.Text = Convert.ToString(Math.Round(PromedioTercero,2));
        }

        private void buttonNotaMayor_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int[] nota = new int[3];
            string[] nombre = new string[3];
            int contador = 0;

            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');

                    if (Convert.ToInt32(datos[2]) > nota[0])
                    {
                        nota[0] = Convert.ToInt32(datos[2]);
                        nombre[0] = datos[1];
                    }

                    if (Convert.ToInt32(datos[3]) > nota[1])
                    {
                        nota[1] = Convert.ToInt32(datos[3]);
                        nombre[1] = datos[1];
                    }

                    if (Convert.ToInt32(datos[4]) > nota[2])
                    {
                        nota[2] = Convert.ToInt32(datos[4]);
                        nombre[2] = datos[1];
                    }

                }
                contador++;
            }
            listBoxResultado.Items.Add($"Parcial 1: {nombre[0]} {nota[0]}");
            listBoxResultado.Items.Add($"Parcial 2: {nombre[1]} {nota[1]}");
            listBoxResultado.Items.Add($"Parcial 3: {nombre[2]} {nota[2]}");
        }

        private void buttonNotaMenor_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int[] nota = new int[3];
            string[] nombre = new string[3];
            int contador = 0;

            nota[0] = 2;
            nota[1] = 2;
            nota[2] = 2;

            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');

                    if (Convert.ToInt32(datos[2]) < nota[0])
                    {
                        nota[0] = Convert.ToInt32(datos[2]);
                        nombre[0] = datos[1];
                    }

                    if (Convert.ToInt32(datos[3]) < nota[1])
                    {
                        nota[1] = Convert.ToInt32(datos[3]);
                        nombre[1] = datos[1];
                    }

                    if (Convert.ToInt32(datos[4]) < nota[2])
                    {
                        nota[2] = Convert.ToInt32(datos[4]);
                        nombre[2] = datos[1];
                    }

                }
                contador++;
            }
            listBoxResultado.Items.Add($"Parcial 1: {nombre[0]} {nota[0]}");
            listBoxResultado.Items.Add($"Parcial 2: {nombre[1]} {nota[1]}");
            listBoxResultado.Items.Add($"Parcial 3: {nombre[2]} {nota[2]}");
        }

        private void buttonOrdenarNombres_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            int contador = 0;
            string[] nombres = new string[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    nombres[contador - 1] = datos[1];
                }
                contador++;
            }

            ClsArreglos ObjNombres = new ClsArreglos(nombres);
            string[] resultado = ObjNombres.MetodoBurbujaNombre();

            for (int indice = 0; indice < resultado.Length; indice++)
            {
                listBoxResultado.Items.Add(resultado[indice]);
            }
        }
    }
}
