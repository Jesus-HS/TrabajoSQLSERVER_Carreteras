namespace Carreteras
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pbFondo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmdTramo = new System.Windows.Forms.Button();
            this.cmdComuna = new System.Windows.Forms.Button();
            this.cmdCarretera = new System.Windows.Forms.Button();
            this.cmdCategoria = new System.Windows.Forms.Button();
            this.lblSalir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFondo
            // 
            this.pbFondo.BackColor = System.Drawing.Color.Transparent;
            this.pbFondo.Image = global::Carreteras.Properties.Resources.Sin_título_11;
            this.pbFondo.Location = new System.Drawing.Point(0, 0);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(844, 419);
            this.pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFondo.TabIndex = 10;
            this.pbFondo.TabStop = false;
            this.pbFondo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.pictureBox2.Image = global::Carreteras.Properties.Resources.la_carretera;
            this.pictureBox2.Location = new System.Drawing.Point(513, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // cmdTramo
            // 
            this.cmdTramo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.cmdTramo.FlatAppearance.BorderSize = 0;
            this.cmdTramo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTramo.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTramo.ForeColor = System.Drawing.Color.White;
            this.cmdTramo.Location = new System.Drawing.Point(161, 253);
            this.cmdTramo.Name = "cmdTramo";
            this.cmdTramo.Size = new System.Drawing.Size(287, 44);
            this.cmdTramo.TabIndex = 19;
            this.cmdTramo.Text = "Tramo";
            this.cmdTramo.UseVisualStyleBackColor = false;
            this.cmdTramo.Click += new System.EventHandler(this.cmdTramo_Click);
            // 
            // cmdComuna
            // 
            this.cmdComuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.cmdComuna.FlatAppearance.BorderSize = 0;
            this.cmdComuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComuna.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComuna.ForeColor = System.Drawing.Color.White;
            this.cmdComuna.Location = new System.Drawing.Point(161, 303);
            this.cmdComuna.Name = "cmdComuna";
            this.cmdComuna.Size = new System.Drawing.Size(287, 44);
            this.cmdComuna.TabIndex = 18;
            this.cmdComuna.Text = "Comuna";
            this.cmdComuna.UseVisualStyleBackColor = false;
            this.cmdComuna.Click += new System.EventHandler(this.cmdComuna_Click);
            // 
            // cmdCarretera
            // 
            this.cmdCarretera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.cmdCarretera.FlatAppearance.BorderSize = 0;
            this.cmdCarretera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCarretera.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCarretera.ForeColor = System.Drawing.Color.White;
            this.cmdCarretera.Location = new System.Drawing.Point(161, 203);
            this.cmdCarretera.Name = "cmdCarretera";
            this.cmdCarretera.Size = new System.Drawing.Size(287, 44);
            this.cmdCarretera.TabIndex = 17;
            this.cmdCarretera.Text = "Carretera";
            this.cmdCarretera.UseVisualStyleBackColor = false;
            this.cmdCarretera.Click += new System.EventHandler(this.cmdCarretera_Click);
            // 
            // cmdCategoria
            // 
            this.cmdCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.cmdCategoria.FlatAppearance.BorderSize = 0;
            this.cmdCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCategoria.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCategoria.ForeColor = System.Drawing.Color.White;
            this.cmdCategoria.Location = new System.Drawing.Point(161, 153);
            this.cmdCategoria.Name = "cmdCategoria";
            this.cmdCategoria.Size = new System.Drawing.Size(287, 44);
            this.cmdCategoria.TabIndex = 16;
            this.cmdCategoria.Text = "Categoria";
            this.cmdCategoria.UseVisualStyleBackColor = false;
            this.cmdCategoria.Click += new System.EventHandler(this.cmdCategoria_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.lblSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalir.Location = new System.Drawing.Point(158, 350);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(41, 17);
            this.lblSalir.TabIndex = 21;
            this.lblSalir.Text = "Salir";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 416);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmdTramo);
            this.Controls.Add(this.cmdComuna);
            this.Controls.Add(this.cmdCarretera);
            this.Controls.Add(this.cmdCategoria);
            this.Controls.Add(this.pbFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFondo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cmdTramo;
        private System.Windows.Forms.Button cmdComuna;
        private System.Windows.Forms.Button cmdCarretera;
        private System.Windows.Forms.Button cmdCategoria;
        private System.Windows.Forms.Label lblSalir;
    }
}