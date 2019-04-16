namespace Trapezio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAream = new System.Windows.Forms.Label();
            this.lblBasep = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtBasem = new System.Windows.Forms.TextBox();
            this.txtBasep = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAream
            // 
            this.lblAream.AutoSize = true;
            this.lblAream.Location = new System.Drawing.Point(45, 55);
            this.lblAream.Name = "lblAream";
            this.lblAream.Size = new System.Drawing.Size(59, 13);
            this.lblAream.TabIndex = 0;
            this.lblAream.Text = "Base maior";
            // 
            // lblBasep
            // 
            this.lblBasep.AutoSize = true;
            this.lblBasep.Location = new System.Drawing.Point(45, 89);
            this.lblBasep.Name = "lblBasep";
            this.lblBasep.Size = new System.Drawing.Size(63, 13);
            this.lblBasep.TabIndex = 1;
            this.lblBasep.Text = "Base menor";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(45, 127);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(45, 167);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Area:";
            // 
            // txtBasem
            // 
            this.txtBasem.Location = new System.Drawing.Point(130, 55);
            this.txtBasem.Name = "txtBasem";
            this.txtBasem.Size = new System.Drawing.Size(100, 20);
            this.txtBasem.TabIndex = 4;
            // 
            // txtBasep
            // 
            this.txtBasep.Location = new System.Drawing.Point(130, 89);
            this.txtBasep.Name = "txtBasep";
            this.txtBasep.Size = new System.Drawing.Size(100, 20);
            this.txtBasep.TabIndex = 5;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(130, 127);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(118, 237);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(248, 236);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValor.Location = new System.Drawing.Point(130, 167);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(123, 15);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "                                      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBasep);
            this.Controls.Add(this.txtBasem);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBasep);
            this.Controls.Add(this.lblAream);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAream;
        private System.Windows.Forms.Label lblBasep;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtBasem;
        private System.Windows.Forms.TextBox txtBasep;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblValor;
    }
}

