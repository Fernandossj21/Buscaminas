namespace WinMine
{
    partial class Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demo));
            this.txtMinas = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pnlValues = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.pnlValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Image = ((System.Drawing.Image)(resources.GetObject("Canvas.Image")));
            this.Canvas.Location = new System.Drawing.Point(0, 31);
            this.Canvas.Size = new System.Drawing.Size(284, 230);
            // 
            // txtMinas
            // 
            this.txtMinas.Location = new System.Drawing.Point(36, 6);
            this.txtMinas.Name = "txtMinas";
            this.txtMinas.ReadOnly = true;
            this.txtMinas.Size = new System.Drawing.Size(80, 20);
            this.txtMinas.TabIndex = 2;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(199, 6);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(78, 20);
            this.txtTiempo.TabIndex = 2;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(124, 4);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(69, 23);
            this.btnEmpezar.TabIndex = 3;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackgroundImage = global::WinMine.Properties.Resources.config;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.Location = new System.Drawing.Point(6, 4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(23, 23);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // pnlValues
            // 
            this.pnlValues.Controls.Add(this.btnEmpezar);
            this.pnlValues.Controls.Add(this.txtMinas);
            this.pnlValues.Controls.Add(this.btnConfig);
            this.pnlValues.Controls.Add(this.txtTiempo);
            this.pnlValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlValues.Location = new System.Drawing.Point(0, 0);
            this.pnlValues.Name = "pnlValues";
            this.pnlValues.Size = new System.Drawing.Size(284, 31);
            this.pnlValues.TabIndex = 4;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pnlValues);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Demo";
            this.Text = "Buscaminas";
            this.Canvas_MouseUp += new System.EventHandler<System.Windows.Forms.MouseEventArgs>(this.Demo_Canvas_MouseUp);
            this.Load += new System.EventHandler(this.Demo_Load);
            this.Controls.SetChildIndex(this.pnlValues, 0);
            this.Controls.SetChildIndex(this.Canvas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.pnlValues.ResumeLayout(false);
            this.pnlValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinas;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel pnlValues;
    }
}

