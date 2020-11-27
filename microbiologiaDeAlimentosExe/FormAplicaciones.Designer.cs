namespace microbiologiaDeAlimentos
{
    partial class FormAplicaciones
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
            this.labelTit = new System.Windows.Forms.Label();
            this.labelTexto = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonEnf = new System.Windows.Forms.RadioButton();
            this.radioButtonVirus = new System.Windows.Forms.RadioButton();
            this.radioButtonProd = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTit
            // 
            this.labelTit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelTit.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTit.Location = new System.Drawing.Point(137, 34);
            this.labelTit.Name = "labelTit";
            this.labelTit.Size = new System.Drawing.Size(711, 44);
            this.labelTit.TabIndex = 0;
            this.labelTit.Text = "Aplicaciones de la microbología de alimentos.";
            // 
            // labelTexto
            // 
            this.labelTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelTexto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTexto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelTexto.Location = new System.Drawing.Point(483, 123);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(450, 499);
            this.labelTexto.TabIndex = 4;
            this.labelTexto.Text = " ";
            this.labelTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.IndianRed;
            this.buttonSalir.Location = new System.Drawing.Point(226, 605);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(123, 44);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonProd);
            this.groupBox1.Controls.Add(this.radioButtonVirus);
            this.groupBox1.Controls.Add(this.radioButtonEnf);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 339);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aplicaciones:";
            // 
            // radioButtonEnf
            // 
            this.radioButtonEnf.AutoSize = true;
            this.radioButtonEnf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButtonEnf.ForeColor = System.Drawing.Color.Red;
            this.radioButtonEnf.Location = new System.Drawing.Point(6, 56);
            this.radioButtonEnf.Name = "radioButtonEnf";
            this.radioButtonEnf.Size = new System.Drawing.Size(310, 64);
            this.radioButtonEnf.TabIndex = 7;
            this.radioButtonEnf.TabStop = true;
            this.radioButtonEnf.Text = "Enfermedades de \r\ntransmisión alimentaria.";
            this.radioButtonEnf.UseVisualStyleBackColor = false;
            this.radioButtonEnf.CheckedChanged += new System.EventHandler(this.radioButtonEnf_CheckedChanged);
            // 
            // radioButtonVirus
            // 
            this.radioButtonVirus.AutoSize = true;
            this.radioButtonVirus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButtonVirus.ForeColor = System.Drawing.Color.Red;
            this.radioButtonVirus.Location = new System.Drawing.Point(6, 150);
            this.radioButtonVirus.Name = "radioButtonVirus";
            this.radioButtonVirus.Size = new System.Drawing.Size(140, 34);
            this.radioButtonVirus.TabIndex = 8;
            this.radioButtonVirus.TabStop = true;
            this.radioButtonVirus.Text = "Virología.";
            this.radioButtonVirus.UseVisualStyleBackColor = false;
            this.radioButtonVirus.CheckedChanged += new System.EventHandler(this.radioButtonVirus_CheckedChanged);
            // 
            // radioButtonProd
            // 
            this.radioButtonProd.AutoSize = true;
            this.radioButtonProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radioButtonProd.ForeColor = System.Drawing.Color.Red;
            this.radioButtonProd.Location = new System.Drawing.Point(6, 226);
            this.radioButtonProd.Name = "radioButtonProd";
            this.radioButtonProd.Size = new System.Drawing.Size(322, 34);
            this.radioButtonProd.TabIndex = 9;
            this.radioButtonProd.TabStop = true;
            this.radioButtonProd.Text = "Producción de alimentos.";
            this.radioButtonProd.UseVisualStyleBackColor = false;
            this.radioButtonProd.CheckedChanged += new System.EventHandler(this.radioButtonProd_CheckedChanged);
            // 
            // FormAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.labelTit);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormAplicaciones";
            this.Text = "Aplicaciones de la microbología de alimentos.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTit;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonVirus;
        private System.Windows.Forms.RadioButton radioButtonEnf;
        private System.Windows.Forms.RadioButton radioButtonProd;
    }
}