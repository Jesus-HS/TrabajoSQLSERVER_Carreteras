namespace Carreteras
{
    partial class categoria_RV
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Categoria = new Carreteras.InformeCategoria.Categoria();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CATEGORIATableAdapter = new Carreteras.InformeCategoria.CategoriaTableAdapters.CATEGORIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CATEGORIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // CATEGORIABindingSource
            // 
            this.CATEGORIABindingSource.DataMember = "CATEGORIA";
            this.CATEGORIABindingSource.DataSource = this.Categoria;
            // 
            // Categoria
            // 
            this.Categoria.DataSetName = "Categoria";
            this.Categoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DTCategoria";
            reportDataSource1.Value = this.CATEGORIABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Carreteras.InformeCategoria.Categoria_Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(734, 524);
            this.reportViewer1.TabIndex = 0;
            // 
            // CATEGORIATableAdapter
            // 
            this.CATEGORIATableAdapter.ClearBeforeFill = true;
            // 
            // categoria_RV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 524);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "categoria_RV";
            this.Text = "reportviewer";
            this.Load += new System.EventHandler(this.reportviewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CATEGORIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Categoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CATEGORIABindingSource;
        private InformeCategoria.Categoria Categoria;
        private InformeCategoria.CategoriaTableAdapters.CATEGORIATableAdapter CATEGORIATableAdapter;
    }
}