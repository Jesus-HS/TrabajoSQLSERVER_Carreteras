namespace Carreteras.InformeTramo
{
    partial class Tramo_RV
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
            this.Tramo = new Carreteras.InformeTramo.Tramo();
            this.TRAMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TRAMOTableAdapter = new Carreteras.InformeTramo.TramoTableAdapters.TRAMOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tramo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRAMOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtTramo";
            reportDataSource1.Value = this.TRAMOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Carreteras.InformeTramo.Tramo_Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Tramo
            // 
            this.Tramo.DataSetName = "Tramo";
            this.Tramo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TRAMOBindingSource
            // 
            this.TRAMOBindingSource.DataMember = "TRAMO";
            this.TRAMOBindingSource.DataSource = this.Tramo;
            // 
            // TRAMOTableAdapter
            // 
            this.TRAMOTableAdapter.ClearBeforeFill = true;
            // 
            // Tramo_RV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Tramo_RV";
            this.Text = "Tramo_RV";
            this.Load += new System.EventHandler(this.Tramo_RV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tramo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRAMOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TRAMOBindingSource;
        private Tramo Tramo;
        private TramoTableAdapters.TRAMOTableAdapter TRAMOTableAdapter;
    }
}