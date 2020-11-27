namespace microbiologiaDeAlimentos
{
    partial class FormDesarrollo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonAplicaciones = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAplicaciones
            // 
            this.botonAplicaciones.BackColor = System.Drawing.Color.Purple;
            this.botonAplicaciones.Font = new System.Drawing.Font("Arial Black", 19F, System.Drawing.FontStyle.Bold);
            this.botonAplicaciones.ForeColor = System.Drawing.Color.White;
            this.botonAplicaciones.Location = new System.Drawing.Point(52, 256);
            this.botonAplicaciones.Name = "botonAplicaciones";
            this.botonAplicaciones.Size = new System.Drawing.Size(375, 137);
            this.botonAplicaciones.TabIndex = 4;
            this.botonAplicaciones.Text = "IPMP 2013";
            this.botonAplicaciones.UseVisualStyleBackColor = false;
            this.botonAplicaciones.Click += new System.EventHandler(this.botonAplicaciones_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Arial Black", 19F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(542, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 137);
            this.button1.TabIndex = 5;
            this.button1.Text = "Modelo Crecimiento de Bacterias";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDesarrollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonAplicaciones);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormDesarrollo";
            this.Text = "FormDesarrollo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAplicaciones;
        private System.Windows.Forms.Button button1;
    }
}