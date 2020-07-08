namespace Carreteras.InformeCarretera
{
    partial class carretera_RV
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
            this.Carretera = new Carreteras.InformeCarretera.Carretera();
            this.CARRETERABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CARRETERATableAdapter = new Carreteras.InformeCarretera.CarreteraTableAdapters.CARRETERATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Carretera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARRETERABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtCarretera";
            reportDataSource1.Value = this.CARRETERABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Carreteras.InformeCarretera.Carretera_Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(726, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // Carretera
            // 
            this.Carretera.DataSetName = "Carretera";
            this.Carretera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CARRETERABindingSource
            // 
            this.CARRETERABindingSource.DataMember = "CARRETERA";
            this.CARRETERABindingSource.DataSource = this.Carretera;
            // 
            // CARRETERATableAdapter
            // 
            this.CARRETERATableAdapter.ClearBeforeFill = true;
            // 
            // carretera_RV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 467);
            this.Controls.Add(this.reportViewer1);
            this.Name = "carretera_RV";
            this.Text = "carretera_RV";
            this.Load += new System.EventHandler(this.carretera_RV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Carretera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CARRETERABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CARRETERABindingSource;
        private Carretera Carretera;
        private CarreteraTableAdapters.CARRETERATableAdapter CARRETERATableAdapter;
    }
}