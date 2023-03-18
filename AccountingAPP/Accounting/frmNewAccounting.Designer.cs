namespace AccountingAPP
{
    partial class frmNewAccounting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAccounting));
            this.gropAshkhas = new System.Windows.Forms.GroupBox();
            this.dgCustomerName = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfillter = new System.Windows.Forms.TextBox();
            this.labCustName = new System.Windows.Forms.Label();
            this.txtNameCust = new System.Windows.Forms.TextBox();
            this.labTarakonesh = new System.Windows.Forms.Label();
            this.lanPrise = new System.Windows.Forms.Label();
            this.labDescription = new System.Windows.Forms.Label();
            this.rbRecive = new System.Windows.Forms.RadioButton();
            this.rbPay = new System.Windows.Forms.RadioButton();
            this.txtMablagh = new System.Windows.Forms.NumericUpDown();
            this.btnSaveIt = new System.Windows.Forms.Button();
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.gropAshkhas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMablagh)).BeginInit();
            this.SuspendLayout();
            // 
            // gropAshkhas
            // 
            this.gropAshkhas.Controls.Add(this.dgCustomerName);
            this.gropAshkhas.Controls.Add(this.txtfillter);
            this.gropAshkhas.Location = new System.Drawing.Point(12, 12);
            this.gropAshkhas.Name = "gropAshkhas";
            this.gropAshkhas.Size = new System.Drawing.Size(257, 421);
            this.gropAshkhas.TabIndex = 0;
            this.gropAshkhas.TabStop = false;
            this.gropAshkhas.Text = "اشخاص";
            // 
            // dgCustomerName
            // 
            this.dgCustomerName.AllowUserToAddRows = false;
            this.dgCustomerName.AllowUserToDeleteRows = false;
            this.dgCustomerName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomerName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgCustomerName.Location = new System.Drawing.Point(0, 66);
            this.dgCustomerName.Name = "dgCustomerName";
            this.dgCustomerName.ReadOnly = true;
            this.dgCustomerName.RowTemplate.Height = 24;
            this.dgCustomerName.Size = new System.Drawing.Size(245, 338);
            this.dgCustomerName.TabIndex = 0;
            this.dgCustomerName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomerName_CellClick);
            this.dgCustomerName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomerName_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "نام شخص";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txtfillter
            // 
            this.txtfillter.Location = new System.Drawing.Point(0, 27);
            this.txtfillter.Name = "txtfillter";
            this.txtfillter.Size = new System.Drawing.Size(245, 28);
            this.txtfillter.TabIndex = 1;
            this.txtfillter.TextChanged += new System.EventHandler(this.txtFillter_TextChanged);
            // 
            // labCustName
            // 
            this.labCustName.AutoSize = true;
            this.labCustName.Location = new System.Drawing.Point(567, 12);
            this.labCustName.Name = "labCustName";
            this.labCustName.Size = new System.Drawing.Size(107, 21);
            this.labCustName.TabIndex = 1;
            this.labCustName.Text = "طرف حساب :";
            // 
            // txtNameCust
            // 
            this.txtNameCust.Location = new System.Drawing.Point(304, 9);
            this.txtNameCust.Name = "txtNameCust";
            this.txtNameCust.ReadOnly = true;
            this.txtNameCust.Size = new System.Drawing.Size(257, 28);
            this.txtNameCust.TabIndex = 2;
            // 
            // labTarakonesh
            // 
            this.labTarakonesh.AutoSize = true;
            this.labTarakonesh.Location = new System.Drawing.Point(567, 78);
            this.labTarakonesh.Name = "labTarakonesh";
            this.labTarakonesh.Size = new System.Drawing.Size(101, 21);
            this.labTarakonesh.TabIndex = 1;
            this.labTarakonesh.Text = "نوع تراکنش :";
            // 
            // lanPrise
            // 
            this.lanPrise.AutoSize = true;
            this.lanPrise.Location = new System.Drawing.Point(567, 149);
            this.lanPrise.Name = "lanPrise";
            this.lanPrise.Size = new System.Drawing.Size(52, 21);
            this.lanPrise.TabIndex = 1;
            this.lanPrise.Text = "مبلغ :";
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.Location = new System.Drawing.Point(567, 217);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(84, 21);
            this.labDescription.TabIndex = 1;
            this.labDescription.Text = "توضیحات :";
            // 
            // rbRecive
            // 
            this.rbRecive.AutoSize = true;
            this.rbRecive.Location = new System.Drawing.Point(471, 76);
            this.rbRecive.Name = "rbRecive";
            this.rbRecive.Size = new System.Drawing.Size(78, 25);
            this.rbRecive.TabIndex = 3;
            this.rbRecive.TabStop = true;
            this.rbRecive.Text = "دریافت";
            this.rbRecive.UseVisualStyleBackColor = true;
            // 
            // rbPay
            // 
            this.rbPay.AutoSize = true;
            this.rbPay.Location = new System.Drawing.Point(364, 78);
            this.rbPay.Name = "rbPay";
            this.rbPay.Size = new System.Drawing.Size(82, 25);
            this.rbPay.TabIndex = 3;
            this.rbPay.TabStop = true;
            this.rbPay.Text = "پرداخت";
            this.rbPay.UseVisualStyleBackColor = true;
            // 
            // txtMablagh
            // 
            this.txtMablagh.Location = new System.Drawing.Point(304, 147);
            this.txtMablagh.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtMablagh.Name = "txtMablagh";
            this.txtMablagh.Size = new System.Drawing.Size(257, 28);
            this.txtMablagh.TabIndex = 4;
            // 
            // btnSaveIt
            // 
            this.btnSaveIt.Location = new System.Drawing.Point(486, 422);
            this.btnSaveIt.Name = "btnSaveIt";
            this.btnSaveIt.Size = new System.Drawing.Size(75, 38);
            this.btnSaveIt.TabIndex = 5;
            this.btnSaveIt.Text = "ثبت";
            this.btnSaveIt.UseVisualStyleBackColor = true;
            this.btnSaveIt.Click += new System.EventHandler(this.btnSaveIt_Click);
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.txtMablagh;
            this.rangeValidator1.ErrorMessage = "مبلغ وارد شده صحیح نمی باشد!";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "999999999999";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtNameCust;
            this.requiredFieldValidator1.ErrorMessage = "لطفا یک شخص را از جدول انتخاب کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(304, 217);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(257, 199);
            this.txtDescription.TabIndex = 6;
            // 
            // frmNewAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 478);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSaveIt);
            this.Controls.Add(this.txtMablagh);
            this.Controls.Add(this.rbPay);
            this.Controls.Add(this.rbRecive);
            this.Controls.Add(this.txtNameCust);
            this.Controls.Add(this.labDescription);
            this.Controls.Add(this.lanPrise);
            this.Controls.Add(this.labTarakonesh);
            this.Controls.Add(this.labCustName);
            this.Controls.Add(this.gropAshkhas);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNewAccounting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.frmNewAccounting_Load);
            this.gropAshkhas.ResumeLayout(false);
            this.gropAshkhas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMablagh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gropAshkhas;
        private System.Windows.Forms.DataGridView dgCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtfillter;
        private System.Windows.Forms.Label labCustName;
        private System.Windows.Forms.TextBox txtNameCust;
        private System.Windows.Forms.Label labTarakonesh;
        private System.Windows.Forms.Label lanPrise;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.RadioButton rbRecive;
        private System.Windows.Forms.RadioButton rbPay;
        private System.Windows.Forms.NumericUpDown txtMablagh;
        private ValidationComponents.RangeValidator rangeValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.Button btnSaveIt;
        private System.Windows.Forms.TextBox txtDescription;
    }
}