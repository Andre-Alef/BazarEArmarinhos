namespace SistemaTCC2
{
    partial class FrmRelatorios
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
            this.cadastroclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSRelatorios = new SistemaTCC2.DSRelatorios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsRelatorios1 = new SistemaTCC2.DSRelatorios();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios1)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastroclientesBindingSource
            // 
            this.cadastroclientesBindingSource.DataMember = "cadastroclientes";
            this.cadastroclientesBindingSource.DataSource = this.DSRelatorios;
            // 
            // DSRelatorios
            // 
            this.DSRelatorios.DataSetName = "DSRelatorios";
            this.DSRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "DsClientes";
            reportDataSource1.Value = this.cadastroclientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaTCC2.RptCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(843, 401);
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
            this.button6.Location = new System.Drawing.Point(814, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 23);
            this.button6.TabIndex = 30;
            this.button6.Text = "X";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SistemaTCC2.Properties.Resources.BorRepor;
            this.ClientSize = new System.Drawing.Size(867, 425);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Relatorios";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.FrmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRelatorios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cadastroclientesBindingSource;
        private DSRelatorios DSRelatorios;
        private DSRelatorios dsRelatorios1;
        private System.Windows.Forms.Button button6;
    }
}