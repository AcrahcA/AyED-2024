namespace _0___ConversorTemperaturasGUI
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
            this.boton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Grados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gradosF = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gradosK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(48, 137);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 0;
            this.boton.Text = "Enviar";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Engrese los Grados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Grados
            // 
            this.Grados.Location = new System.Drawing.Point(23, 78);
            this.Grados.Name = "Grados";
            this.Grados.Size = new System.Drawing.Size(100, 20);
            this.Grados.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "fahrenheit";
            // 
            // gradosF
            // 
            this.gradosF.AutoSize = true;
            this.gradosF.Location = new System.Drawing.Point(224, 43);
            this.gradosF.Name = "gradosF";
            this.gradosF.Size = new System.Drawing.Size(23, 13);
            this.gradosF.TabIndex = 4;
            this.gradosF.Text = "0°F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "kelvin";
            // 
            // gradosK
            // 
            this.gradosK.AutoSize = true;
            this.gradosK.Location = new System.Drawing.Point(224, 78);
            this.gradosK.Name = "gradosK";
            this.gradosK.Size = new System.Drawing.Size(24, 13);
            this.gradosK.TabIndex = 6;
            this.gradosK.Text = "0°K";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gradosK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gradosF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Grados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gradosF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label gradosK;
    }
}

