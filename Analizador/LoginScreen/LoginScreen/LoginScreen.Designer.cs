namespace MACOY
{
    partial class LoginScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.Animacion = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.label3);
            this.panelContenedor.Controls.Add(this.lblCount);
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.panelBarra);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(600, 350);
            this.panelContenedor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 96);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lato Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tecnológico Superior de El Mante";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(533, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Compilador realizado para lenguajes y autómatas para el Instituto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //is.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(314, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "%";
           //his.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Lato Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(274, 199);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(24, 25);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "0";
      //    this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MACOY.Properties.Resources.icons8_Code_100px;
            this.pictureBox1.Location = new System.Drawing.Point(115, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "??? ??? CODE";
           //his.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.panelBarra.Location = new System.Drawing.Point(0, 250);
            this.panelBarra.MaximumSize = new System.Drawing.Size(600, 40);
            this.panelBarra.MinimumSize = new System.Drawing.Size(0, 5);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(0, 5);
            this.panelBarra.TabIndex = 0;
            // 
            // Animacion
            // 
            this.Animacion.Tick += new System.EventHandler(this.Animacion_Tick);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Timer Animacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}

