﻿namespace QLGR.Presentation
{
    partial class frmInPhieuSuaChua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInPhieuSuaChua));
            this.vWPHIEUSUAXEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPhieuSuaChuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPhieuSuaChua = new QLGR.DSPhieuSuaChua();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vW_PHIEUSUAXETableAdapter = new QLGR.DSPhieuSuaChuaTableAdapters.VW_PHIEUSUAXETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vWPHIEUSUAXEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPhieuSuaChuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPhieuSuaChua)).BeginInit();
            this.SuspendLayout();
            // 
            // vWPHIEUSUAXEBindingSource
            // 
            this.vWPHIEUSUAXEBindingSource.DataMember = "VW_PHIEUSUAXE";
            this.vWPHIEUSUAXEBindingSource.DataSource = this.dSPhieuSuaChuaBindingSource;
            // 
            // dSPhieuSuaChuaBindingSource
            // 
            this.dSPhieuSuaChuaBindingSource.DataSource = this.dSPhieuSuaChua;
            this.dSPhieuSuaChuaBindingSource.Position = 0;
            // 
            // dSPhieuSuaChua
            // 
            this.dSPhieuSuaChua.DataSetName = "DSPhieuSuaChua";
            this.dSPhieuSuaChua.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PhieuSuaChua";
            reportDataSource1.Value = this.vWPHIEUSUAXEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGR.Bill_Report.PhieuSuaChua.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(960, 857);
            this.reportViewer1.TabIndex = 0;
            // 
            // vW_PHIEUSUAXETableAdapter
            // 
            this.vW_PHIEUSUAXETableAdapter.ClearBeforeFill = true;
            // 
            // frmInPhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 857);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInPhieuSuaChua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In phiếu sửa chửa";
            this.Load += new System.EventHandler(this.frmInPhieuSuaChua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vWPHIEUSUAXEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPhieuSuaChuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPhieuSuaChua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSPhieuSuaChua dSPhieuSuaChua;
        private System.Windows.Forms.BindingSource dSPhieuSuaChuaBindingSource;
        private System.Windows.Forms.BindingSource vWPHIEUSUAXEBindingSource;
        private DSPhieuSuaChuaTableAdapters.VW_PHIEUSUAXETableAdapter vW_PHIEUSUAXETableAdapter;
    }
}