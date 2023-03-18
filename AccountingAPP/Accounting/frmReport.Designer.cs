namespace AccountingAPP
{
    partial class frmReport
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEditeAction = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteAction = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshAction = new System.Windows.Forms.ToolStripButton();
            this.btnPrintAction = new System.Windows.Forms.ToolStripButton();
            this.grboxSearch = new System.Windows.Forms.GroupBox();
            this.btnFillter = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labAztarikh = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.MaskedTextBox();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.labCustomer = new System.Windows.Forms.Label();
            this.dgReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiiReport = new Stimulsoft.Report.StiReport();
            this.toolStrip1.SuspendLayout();
            this.grboxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditeAction,
            this.btnDeleteAction,
            this.btnRefreshAction,
            this.btnPrintAction});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEditeAction
            // 
            this.btnEditeAction.Image = global::AccountingAPP.Properties.Resources._1371475973_document_edit;
            this.btnEditeAction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditeAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditeAction.Name = "btnEditeAction";
            this.btnEditeAction.Size = new System.Drawing.Size(59, 64);
            this.btnEditeAction.Text = "ویرایش";
            this.btnEditeAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditeAction.Click += new System.EventHandler(this.btnEditeAction_Click);
            // 
            // btnDeleteAction
            // 
            this.btnDeleteAction.Image = global::AccountingAPP.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDeleteAction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteAction.Name = "btnDeleteAction";
            this.btnDeleteAction.Size = new System.Drawing.Size(45, 64);
            this.btnDeleteAction.Text = "حذف";
            this.btnDeleteAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteAction.Click += new System.EventHandler(this.btnDeleteAction_Click);
            // 
            // btnRefreshAction
            // 
            this.btnRefreshAction.Image = global::AccountingAPP.Properties.Resources._1371476368_Synchronize;
            this.btnRefreshAction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefreshAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshAction.Name = "btnRefreshAction";
            this.btnRefreshAction.Size = new System.Drawing.Size(76, 64);
            this.btnRefreshAction.Text = "بروزرسانی";
            this.btnRefreshAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshAction.Click += new System.EventHandler(this.btnRefreshAction_Click);
            // 
            // btnPrintAction
            // 
            this.btnPrintAction.Image = global::AccountingAPP.Properties.Resources._1371476276_Print;
            this.btnPrintAction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrintAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintAction.Name = "btnPrintAction";
            this.btnPrintAction.Size = new System.Drawing.Size(44, 64);
            this.btnPrintAction.Text = "چاپ";
            this.btnPrintAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintAction.Click += new System.EventHandler(this.btnPrintAction_Click);
            // 
            // grboxSearch
            // 
            this.grboxSearch.Controls.Add(this.btnFillter);
            this.grboxSearch.Controls.Add(this.txtTo);
            this.grboxSearch.Controls.Add(this.label3);
            this.grboxSearch.Controls.Add(this.labAztarikh);
            this.grboxSearch.Controls.Add(this.txtFrom);
            this.grboxSearch.Controls.Add(this.comboCustomer);
            this.grboxSearch.Controls.Add(this.labCustomer);
            this.grboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxSearch.Location = new System.Drawing.Point(12, 70);
            this.grboxSearch.Name = "grboxSearch";
            this.grboxSearch.Size = new System.Drawing.Size(728, 80);
            this.grboxSearch.TabIndex = 1;
            this.grboxSearch.TabStop = false;
            this.grboxSearch.Text = "جستوجو";
            // 
            // btnFillter
            // 
            this.btnFillter.Location = new System.Drawing.Point(6, 34);
            this.btnFillter.Name = "btnFillter";
            this.btnFillter.Size = new System.Drawing.Size(86, 29);
            this.btnFillter.TabIndex = 6;
            this.btnFillter.Text = "ثبت";
            this.btnFillter.UseVisualStyleBackColor = true;
            this.btnFillter.Click += new System.EventHandler(this.btnFillter_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(107, 35);
            this.txtTo.Mask = "0000/00/00";
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 27);
            this.txtTo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "تا تاریخ :";
            // 
            // labAztarikh
            // 
            this.labAztarikh.AutoSize = true;
            this.labAztarikh.Location = new System.Drawing.Point(388, 38);
            this.labAztarikh.Name = "labAztarikh";
            this.labAztarikh.Size = new System.Drawing.Size(65, 20);
            this.labAztarikh.TabIndex = 3;
            this.labAztarikh.Text = "از تاریخ :";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(292, 35);
            this.txtFrom.Mask = "0000/00/00";
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 27);
            this.txtFrom.TabIndex = 2;
            // 
            // comboCustomer
            // 
            this.comboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(459, 35);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(158, 28);
            this.comboCustomer.TabIndex = 1;
            this.comboCustomer.SelectedIndexChanged += new System.EventHandler(this.comboCustomer_SelectedIndexChanged);
            // 
            // labCustomer
            // 
            this.labCustomer.AutoSize = true;
            this.labCustomer.Location = new System.Drawing.Point(623, 38);
            this.labCustomer.Name = "labCustomer";
            this.labCustomer.Size = new System.Drawing.Size(89, 20);
            this.labCustomer.TabIndex = 0;
            this.labCustomer.Text = "طرف حساب :";
            // 
            // dgReport
            // 
            this.dgReport.AllowUserToAddRows = false;
            this.dgReport.AllowUserToDeleteRows = false;
            this.dgReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgReport.Location = new System.Drawing.Point(12, 185);
            this.dgReport.Name = "dgReport";
            this.dgReport.ReadOnly = true;
            this.dgReport.RowTemplate.Height = 24;
            this.dgReport.Size = new System.Drawing.Size(728, 256);
            this.dgReport.TabIndex = 7;
            this.dgReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReport_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerID";
            this.Column2.HeaderText = "طرف حساب";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Amount";
            this.Column3.HeaderText = "مبلع";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DataType";
            this.Column4.HeaderText = "تاریخ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Description";
            this.Column5.HeaderText = "بابت";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // stiiReport
            // 
            this.stiiReport.CookieContainer = null;
            this.stiiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiiReport.ReportAlias = "Report";
            this.stiiReport.ReportGuid = "ac4567bd550b407d8758d9983d68a8b6";
            this.stiiReport.ReportName = "Report";
            this.stiiReport.ReportSource = null;
            this.stiiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiiReport.UseProgressInThread = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 453);
            this.Controls.Add(this.dgReport);
            this.Controls.Add(this.grboxSearch);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grboxSearch.ResumeLayout(false);
            this.grboxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEditeAction;
        private System.Windows.Forms.ToolStripButton btnDeleteAction;
        private System.Windows.Forms.ToolStripButton btnRefreshAction;
        private System.Windows.Forms.ToolStripButton btnPrintAction;
        private System.Windows.Forms.GroupBox grboxSearch;
        private System.Windows.Forms.Button btnFillter;
        private System.Windows.Forms.MaskedTextBox txtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labAztarikh;
        private System.Windows.Forms.MaskedTextBox txtFrom;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label labCustomer;
        private System.Windows.Forms.DataGridView dgReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Stimulsoft.Report.StiReport stiiReport;
    }
}