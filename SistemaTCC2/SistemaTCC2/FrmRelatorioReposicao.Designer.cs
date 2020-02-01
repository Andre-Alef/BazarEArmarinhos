namespace SistemaTCC2
{
    partial class FrmRelatorioReposicao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.relatorioreposicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSRelatorios = new SistemaTCC2.DSRelatorios();
            this.DTreposicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsRelatorios1 = new SistemaTCC2.DSRelatorios();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioreposicaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTreposicaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios1)).BeginInit();
            this.SuspendLayout();
            // 
            // relatorioreposicaoBindingSource
            // 
            this.relatorioreposicaoBindingSource.DataMember = "relatorioreposicao";
            this.relatorioreposicaoBindingSource.DataSource = this.DSRelatorios;
            // 
            // DSRelatorios
            // 
            this.DSRelatorios.DataSetName = "DSRelatorios";
            this.DSRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DTreposicaoBindingSource
            // 
            this.DTreposicaoBindingSource.DataMember = "DTreposicao";
            this.DTreposicaoBindingSource.DataSource = this.DSRelatorios;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImage = global::SistemaTCC2.Properties.Resources.BorRepor;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource2.Name = "DSReposicao2";
            reportDataSource2.Value = this.relatorioreposicaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaTCC2.RptReposicao2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(35, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(824, 402);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsRelatorios1
            // 
            this.dsRelatorios1.DataSetName = "DSRelatorios";
            this.dsRelatorios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(839, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(20, 20);
            this.button6.TabIndex = 30;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FrmRelatorioReposicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaTCC2.Properties.Resources.BorRepor;
            this.ClientSize = new System.Drawing.Size(867, 425);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatorioReposicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmRelatorioReposicao";
            this.Load += new System.EventHandler(this.FrmRelatorioReposicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioreposicaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTreposicaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DTreposicaoBindingSource;
        private DSRelatorios DSRelatorios;
        private DSRelatorios dsRelatorios1;
        private System.Windows.Forms.BindingSource relatorioreposicaoBindingSource;
        private System.Windows.Forms.Button button6;
    }
}