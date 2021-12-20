
namespace Tarea
{
    partial class LLamadodecarpeta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCargar = new System.Windows.Forms.TextBox();
            this.btncargar = new System.Windows.Forms.Button();
            this.Carpetas = new System.Windows.Forms.ListBox();
            this.Archivos = new System.Windows.Forms.ListBox();
            this.Texto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abrir carpetas";
            // 
            // txtCargar
            // 
            this.txtCargar.Location = new System.Drawing.Point(134, 33);
            this.txtCargar.Name = "txtCargar";
            this.txtCargar.Size = new System.Drawing.Size(245, 20);
            this.txtCargar.TabIndex = 1;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(557, 23);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(97, 38);
            this.btncargar.TabIndex = 2;
            this.btncargar.Text = "Cargar carpetas";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // Carpetas
            // 
            this.Carpetas.FormattingEnabled = true;
            this.Carpetas.Location = new System.Drawing.Point(35, 95);
            this.Carpetas.Name = "Carpetas";
            this.Carpetas.Size = new System.Drawing.Size(176, 225);
            this.Carpetas.TabIndex = 3;
            this.Carpetas.SelectedIndexChanged += new System.EventHandler(this.Carpetas_SelectedIndexChanged);
            // 
            // Archivos
            // 
            this.Archivos.FormattingEnabled = true;
            this.Archivos.Location = new System.Drawing.Point(267, 95);
            this.Archivos.Name = "Archivos";
            this.Archivos.Size = new System.Drawing.Size(192, 225);
            this.Archivos.TabIndex = 4;
            this.Archivos.SelectedIndexChanged += new System.EventHandler(this.Archivos_SelectedIndexChanged);
            // 
            // Texto
            // 
            this.Texto.FormattingEnabled = true;
            this.Texto.Location = new System.Drawing.Point(527, 95);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(205, 225);
            this.Texto.TabIndex = 5;
            // 
            // LLamadodecarpeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.Archivos);
            this.Controls.Add(this.Carpetas);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.txtCargar);
            this.Controls.Add(this.label1);
            this.Name = "LLamadodecarpeta";
            this.Text = "Ejercicio de tarea";
            this.Load += new System.EventHandler(this.LLamadodecarpeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCargar;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.ListBox Carpetas;
        private System.Windows.Forms.ListBox Archivos;
        private System.Windows.Forms.ListBox Texto;
    }
}

