
namespace Arreglos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonPromedio = new System.Windows.Forms.Button();
            this.textBoxPrimero = new System.Windows.Forms.TextBox();
            this.textBoxSegundo = new System.Windows.Forms.TextBox();
            this.textBoxTercero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNotaMayor = new System.Windows.Forms.Button();
            this.buttonNotaMenor = new System.Windows.Forms.Button();
            this.buttonOrdenarNombres = new System.Windows.Forms.Button();
            this.labelAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.Location = new System.Drawing.Point(395, 230);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(99, 23);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "Arreglo";
            this.buttonArreglo.UseVisualStyleBackColor = true;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(500, 230);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(321, 173);
            this.listBoxResultado.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(3, 96);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 23);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(84, 12);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContenido.Size = new System.Drawing.Size(321, 188);
            this.textBoxContenido.TabIndex = 3;
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(395, 259);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(99, 23);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(395, 318);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(99, 23);
            this.buttonOrdenar.TabIndex = 5;
            this.buttonOrdenar.Text = "Ordenar Notas";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonPromedio
            // 
            this.buttonPromedio.Enabled = false;
            this.buttonPromedio.Location = new System.Drawing.Point(408, 430);
            this.buttonPromedio.Name = "buttonPromedio";
            this.buttonPromedio.Size = new System.Drawing.Size(86, 23);
            this.buttonPromedio.TabIndex = 6;
            this.buttonPromedio.Text = "Promedio";
            this.buttonPromedio.UseVisualStyleBackColor = true;
            this.buttonPromedio.Click += new System.EventHandler(this.buttonPromedio_Click);
            // 
            // textBoxPrimero
            // 
            this.textBoxPrimero.Location = new System.Drawing.Point(520, 432);
            this.textBoxPrimero.Name = "textBoxPrimero";
            this.textBoxPrimero.Size = new System.Drawing.Size(58, 20);
            this.textBoxPrimero.TabIndex = 7;
            this.textBoxPrimero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSegundo
            // 
            this.textBoxSegundo.Location = new System.Drawing.Point(632, 432);
            this.textBoxSegundo.Name = "textBoxSegundo";
            this.textBoxSegundo.Size = new System.Drawing.Size(58, 20);
            this.textBoxSegundo.TabIndex = 8;
            this.textBoxSegundo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTercero
            // 
            this.textBoxTercero.Location = new System.Drawing.Point(743, 432);
            this.textBoxTercero.Name = "textBoxTercero";
            this.textBoxTercero.Size = new System.Drawing.Size(58, 20);
            this.textBoxTercero.TabIndex = 9;
            this.textBoxTercero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Primero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Segundo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tercero";
            // 
            // buttonNotaMayor
            // 
            this.buttonNotaMayor.Location = new System.Drawing.Point(395, 347);
            this.buttonNotaMayor.Name = "buttonNotaMayor";
            this.buttonNotaMayor.Size = new System.Drawing.Size(99, 23);
            this.buttonNotaMayor.TabIndex = 14;
            this.buttonNotaMayor.Text = "Nota Mayor";
            this.buttonNotaMayor.UseVisualStyleBackColor = true;
            this.buttonNotaMayor.Click += new System.EventHandler(this.buttonNotaMayor_Click);
            // 
            // buttonNotaMenor
            // 
            this.buttonNotaMenor.Location = new System.Drawing.Point(395, 376);
            this.buttonNotaMenor.Name = "buttonNotaMenor";
            this.buttonNotaMenor.Size = new System.Drawing.Size(99, 23);
            this.buttonNotaMenor.TabIndex = 15;
            this.buttonNotaMenor.Text = "Nota Menor";
            this.buttonNotaMenor.UseVisualStyleBackColor = true;
            this.buttonNotaMenor.Click += new System.EventHandler(this.buttonNotaMenor_Click);
            // 
            // buttonOrdenarNombres
            // 
            this.buttonOrdenarNombres.Location = new System.Drawing.Point(395, 288);
            this.buttonOrdenarNombres.Name = "buttonOrdenarNombres";
            this.buttonOrdenarNombres.Size = new System.Drawing.Size(99, 23);
            this.buttonOrdenarNombres.TabIndex = 16;
            this.buttonOrdenarNombres.Text = "Ordenar Nombres";
            this.buttonOrdenarNombres.UseVisualStyleBackColor = true;
            this.buttonOrdenarNombres.Click += new System.EventHandler(this.buttonOrdenarNombres_Click);
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Location = new System.Drawing.Point(198, 435);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(204, 13);
            this.labelAviso.TabIndex = 17;
            this.labelAviso.Text = "*Es necesario ordenar notas previamente.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 467);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.buttonOrdenarNombres);
            this.Controls.Add(this.buttonNotaMenor);
            this.Controls.Add(this.buttonNotaMayor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTercero);
            this.Controls.Add(this.textBoxSegundo);
            this.Controls.Add(this.textBoxPrimero);
            this.Controls.Add(this.buttonPromedio);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonPromedio;
        private System.Windows.Forms.TextBox textBoxPrimero;
        private System.Windows.Forms.TextBox textBoxSegundo;
        private System.Windows.Forms.TextBox textBoxTercero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNotaMayor;
        private System.Windows.Forms.Button buttonNotaMenor;
        private System.Windows.Forms.Button buttonOrdenarNombres;
        private System.Windows.Forms.Label labelAviso;
    }
}

