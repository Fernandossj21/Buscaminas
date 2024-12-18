namespace WinMine
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(90, 70);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minas";
            // 
            // txtMinas
            // 
            this.txtMinas.Location = new System.Drawing.Point(47, 38);
            this.txtMinas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMinas.Name = "txtMinas";
            this.txtMinas.Size = new System.Drawing.Size(67, 20);
            this.txtMinas.TabIndex = 2;
            this.txtMinas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ancho";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(47, 12);
            this.txtAncho.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtAncho.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(67, 20);
            this.txtAncho.TabIndex = 2;
            this.txtAncho.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtAncho.ValueChanged += new System.EventHandler(this.txtWidth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(172, 12);
            this.txtAltura.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtAltura.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(67, 20);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtAltura.ValueChanged += new System.EventHandler(this.txtHeight_ValueChanged);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 98);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configuracion";
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.txtMinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtMinas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtAncho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtAltura;
    }
}