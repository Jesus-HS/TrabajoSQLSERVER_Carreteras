namespace Carreteras.InformeComuna
{
    partial class Comuna_RV
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Comuna = new Carreteras.InformeComuna.Comuna();
            this.COMUNABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.COMUNATableAdapter = new Carreteras.InformeComuna.ComunaTableAdapters.COMUNATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Comuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMUNABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 63;
            reportDataSource1.Name = "dtComuna";
            reportDataSource1.Value = this.COMUNABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Carreteras.InformeComuna.Comuna_Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(727, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // Comuna
            // 
            this.Comuna.DataSetName = "Comuna";
            this.Comuna.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // COMUNABindingSource
            // 
            this.COMUNABindingSource.DataMember = "COMUNA";
            this.COMUNABindingSource.DataSource = this.Comuna;
            // 
            // COMUNATableAdapter
            // 
            this.COMUNATableAdapter.ClearBeforeFill = true;
            // 
            // Comuna_RV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 449);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Comuna_RV";
            this.Text = "Comuna_RV";
            this.Load += new System.EventHandler(this.Comuna_RV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Comuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMUNABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource COMUNABindingSource;
        private Comuna Comuna;
        private ComunaTableAdapters.COMUNATableAdapter COMUNATableAdapter;
    }
}