namespace Examen
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
            this.cancelarbutton1 = new System.Windows.Forms.Button();
            this.aceptarbutton2 = new System.Windows.Forms.Button();
            this.usuariolabel1 = new System.Windows.Forms.Label();
            this.clavelabel2 = new System.Windows.Forms.Label();
            this.usuariotextBox1 = new System.Windows.Forms.TextBox();
            this.clavetextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelarbutton1
            // 
            this.cancelarbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarbutton1.Location = new System.Drawing.Point(294, 190);
            this.cancelarbutton1.Name = "cancelarbutton1";
            this.cancelarbutton1.Size = new System.Drawing.Size(75, 32);
            this.cancelarbutton1.TabIndex = 0;
            this.cancelarbutton1.Text = "Cancelar";
            this.cancelarbutton1.UseVisualStyleBackColor = true;
            // 
            // aceptarbutton2
            // 
            this.aceptarbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarbutton2.Location = new System.Drawing.Point(183, 190);
            this.aceptarbutton2.Name = "aceptarbutton2";
            this.aceptarbutton2.Size = new System.Drawing.Size(77, 32);
            this.aceptarbutton2.TabIndex = 1;
            this.aceptarbutton2.Text = "Aceptar";
            this.aceptarbutton2.UseVisualStyleBackColor = true;
            this.aceptarbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuariolabel1
            // 
            this.usuariolabel1.AutoSize = true;
            this.usuariolabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariolabel1.Location = new System.Drawing.Point(98, 73);
            this.usuariolabel1.Name = "usuariolabel1";
            this.usuariolabel1.Size = new System.Drawing.Size(67, 20);
            this.usuariolabel1.TabIndex = 2;
            this.usuariolabel1.Text = "Usuario";
            // 
            // clavelabel2
            // 
            this.clavelabel2.AutoSize = true;
            this.clavelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clavelabel2.Location = new System.Drawing.Point(110, 134);
            this.clavelabel2.Name = "clavelabel2";
            this.clavelabel2.Size = new System.Drawing.Size(51, 20);
            this.clavelabel2.TabIndex = 3;
            this.clavelabel2.Text = "Clave";
            // 
            // usuariotextBox1
            // 
            this.usuariotextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariotextBox1.Location = new System.Drawing.Point(183, 67);
            this.usuariotextBox1.Name = "usuariotextBox1";
            this.usuariotextBox1.Size = new System.Drawing.Size(186, 27);
            this.usuariotextBox1.TabIndex = 4;
            // 
            // clavetextBox2
            // 
            this.clavetextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clavetextBox2.Location = new System.Drawing.Point(183, 128);
            this.clavetextBox2.Name = "clavetextBox2";
            this.clavetextBox2.Size = new System.Drawing.Size(186, 27);
            this.clavetextBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 321);
            this.Controls.Add(this.clavetextBox2);
            this.Controls.Add(this.usuariotextBox1);
            this.Controls.Add(this.clavelabel2);
            this.Controls.Add(this.usuariolabel1);
            this.Controls.Add(this.aceptarbutton2);
            this.Controls.Add(this.cancelarbutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarbutton1;
        private System.Windows.Forms.Button aceptarbutton2;
        private System.Windows.Forms.Label usuariolabel1;
        private System.Windows.Forms.Label clavelabel2;
        private System.Windows.Forms.TextBox usuariotextBox1;
        private System.Windows.Forms.TextBox clavetextBox2;
    }
}

