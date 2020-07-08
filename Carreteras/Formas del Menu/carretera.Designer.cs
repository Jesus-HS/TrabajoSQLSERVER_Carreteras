namespace Carreteras
{
    partial class frmCarretera
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidCategoria = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbInsertar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.pbBorrar = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.cmdGenerarInforme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(447, 219);
            this.dataGridView1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Carreteras.Properties.Resources.otrofondo;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 231);
            this.panel1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtidCategoria);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtKm);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(14, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 114);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "idCategoria";
            // 
            // txtidCategoria
            // 
            this.txtidCategoria.Location = new System.Drawing.Point(96, 78);
            this.txtidCategoria.Name = "txtidCategoria";
            this.txtidCategoria.Size = new System.Drawing.Size(100, 22);
            this.txtidCategoria.TabIndex = 5;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(96, 22);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "idCarretera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kilometros:";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(96, 50);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 22);
            this.txtKm.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdGenerarInforme);
            this.groupBox1.Controls.Add(this.pbInsertar);
            this.groupBox1.Controls.Add(this.pbEditar);
            this.groupBox1.Controls.Add(this.pbBorrar);
            this.groupBox1.Controls.Add(this.pbBuscar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(228, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 206);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // pbInsertar
            // 
            this.pbInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInsertar.Image = global::Carreteras.Properties.Resources.comprobar;
            this.pbInsertar.Location = new System.Drawing.Point(6, 21);
            this.pbInsertar.Name = "pbInsertar";
            this.pbInsertar.Size = new System.Drawing.Size(70, 69);
            this.pbInsertar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInsertar.TabIndex = 5;
            this.pbInsertar.TabStop = false;
            this.pbInsertar.Click += new System.EventHandler(this.pbInsertar_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditar.Image = global::Carreteras.Properties.Resources.pluma;
            this.pbEditar.Location = new System.Drawing.Point(82, 96);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(70, 69);
            this.pbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditar.TabIndex = 8;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // pbBorrar
            // 
            this.pbBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBorrar.Image = global::Carreteras.Properties.Resources.cerrar;
            this.pbBorrar.Location = new System.Drawing.Point(82, 21);
            this.pbBorrar.Name = "pbBorrar";
            this.pbBorrar.Size = new System.Drawing.Size(70, 69);
            this.pbBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBorrar.TabIndex = 6;
            this.pbBorrar.TabStop = false;
            this.pbBorrar.Click += new System.EventHandler(this.pbBorrar_Click);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBuscar.Image = global::Carreteras.Properties.Resources.lupa;
            this.pbBuscar.Location = new System.Drawing.Point(6, 96);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(70, 69);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBuscar.TabIndex = 7;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // cmdGenerarInforme
            // 
            this.cmdGenerarInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.cmdGenerarInforme.FlatAppearance.BorderSize = 0;
            this.cmdGenerarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenerarInforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdGenerarInforme.Location = new System.Drawing.Point(6, 171);
            this.cmdGenerarInforme.Name = "cmdGenerarInforme";
            this.cmdGenerarInforme.Size = new System.Drawing.Size(146, 28);
            this.cmdGenerarInforme.TabIndex = 12;
            this.cmdGenerarInforme.Text = "Generar Informe";
            this.cmdGenerarInforme.UseVisualStyleBackColor = false;
            this.cmdGenerarInforme.Click += new System.EventHandler(this.cmdGenerarInforme_Click);
            // 
            // frmCarretera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCarretera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "carretera";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInsertar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidCategoria;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbInsertar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.PictureBox pbBorrar;
        private System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Button cmdGenerarInforme;
    }
}