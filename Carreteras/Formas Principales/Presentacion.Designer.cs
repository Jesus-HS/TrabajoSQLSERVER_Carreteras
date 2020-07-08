namespace Carreteras
{
    partial class frmIntroduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntroduccion));
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblIniciar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.lblAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAyuda.Location = new System.Drawing.Point(156, 353);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(96, 32);
            this.lblAyuda.TabIndex = 24;
            this.lblAyuda.Text = "Ayuda";
            this.lblAyuda.Click += new System.EventHandler(this.lblAyuda_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.lblSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalir.Location = new System.Drawing.Point(156, 385);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(73, 32);
            this.lblSalir.TabIndex = 23;
            this.lblSalir.Text = "Salir";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.lblInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInformacion.Location = new System.Drawing.Point(156, 321);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(163, 32);
            this.lblInformacion.TabIndex = 22;
            this.lblInformacion.Text = "Información";
            this.lblInformacion.Click += new System.EventHandler(this.lblInformacion_Click);
            // 
            // lblIniciar
            // 
            this.lblIniciar.AutoSize = true;
            this.lblIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.lblIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIniciar.Location = new System.Drawing.Point(156, 289);
            this.lblIniciar.Name = "lblIniciar";
            this.lblIniciar.Size = new System.Drawing.Size(92, 32);
            this.lblIniciar.TabIndex = 21;
            this.lblIniciar.Text = "Entrar";
            this.lblIniciar.Click += new System.EventHandler(this.lblIniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carreteras.Properties.Resources._94468554_2279121785715686_2480796895698485248_n;
            this.pictureBox1.Location = new System.Drawing.Point(417, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pbFondo
            // 
            this.pbFondo.Image = global::Carreteras.Properties.Resources.intro;
            this.pbFondo.Location = new System.Drawing.Point(0, 0);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(840, 528);
            this.pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFondo.TabIndex = 20;
            this.pbFondo.TabStop = false;
            this.pbFondo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFondo_MouseMove);
            // 
            // frmIntroduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblIniciar);
            this.Controls.Add(this.pbFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIntroduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblIniciar;
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

