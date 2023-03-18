namespace AccountingAPP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCustomer = new System.Windows.Forms.ToolStrip();
            this.btnCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnNewAccounting = new System.Windows.Forms.ToolStripButton();
            this.BtnReportPay = new System.Windows.Forms.ToolStripButton();
            this.BtnReportRecive = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labPay = new System.Windows.Forms.Label();
            this.labRecive = new System.Windows.Forms.Label();
            this.labBalance = new System.Windows.Forms.Label();
            this.btnRefreshMAin = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStripCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(749, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePass});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(78, 24);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(187, 26);
            this.btnChangePass.Text = "عملیات رمز ورود";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // toolStripCustomer
            // 
            this.toolStripCustomer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnNewAccounting,
            this.BtnReportPay,
            this.BtnReportRecive,
            this.btnRefreshMAin});
            this.toolStripCustomer.Location = new System.Drawing.Point(0, 27);
            this.toolStripCustomer.Name = "toolStripCustomer";
            this.toolStripCustomer.Size = new System.Drawing.Size(749, 67);
            this.toolStripCustomer.TabIndex = 1;
            this.toolStripCustomer.Text = "toolStrip2";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::AccountingAPP.Properties.Resources._1371476468_preferences_contact_list;
            this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(90, 64);
            this.btnCustomers.Text = "طرف حساب";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnNewAccounting
            // 
            this.btnNewAccounting.Image = global::AccountingAPP.Properties.Resources._1371476499_todo_list;
            this.btnNewAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAccounting.Name = "btnNewAccounting";
            this.btnNewAccounting.Size = new System.Drawing.Size(92, 64);
            this.btnNewAccounting.Text = "تراکنش جدید";
            this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewAccounting.Click += new System.EventHandler(this.btnNewAccounting_Click);
            // 
            // BtnReportPay
            // 
            this.BtnReportPay.Image = global::AccountingAPP.Properties.Resources.servicesCosts;
            this.BtnReportPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnReportPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReportPay.Name = "BtnReportPay";
            this.BtnReportPay.Size = new System.Drawing.Size(124, 64);
            this.BtnReportPay.Text = " گزارش پرداخت ها";
            this.BtnReportPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReportPay.Click += new System.EventHandler(this.BtnReportPay_Click);
            // 
            // BtnReportRecive
            // 
            this.BtnReportRecive.Image = global::AccountingAPP.Properties.Resources._1370791030_credit_card;
            this.BtnReportRecive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnReportRecive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReportRecive.Name = "BtnReportRecive";
            this.BtnReportRecive.Size = new System.Drawing.Size(107, 64);
            this.BtnReportRecive.Text = " گزارش دریافت";
            this.BtnReportRecive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReportRecive.Click += new System.EventHandler(this.BtnReportRecive_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccountingAPP.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtdate,
            this.txtTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(749, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtdate
            // 
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(17, 20);
            this.txtdate.Text = "1";
            // 
            // txtTime
            // 
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(17, 20);
            this.txtTime.Text = "2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labBalance);
            this.groupBox1.Controls.Add(this.labRecive);
            this.groupBox1.Controls.Add(this.labPay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(360, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش این ماه :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافتی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "پرداختی :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "مانده :";
            // 
            // labPay
            // 
            this.labPay.Location = new System.Drawing.Point(6, 83);
            this.labPay.Name = "labPay";
            this.labPay.Size = new System.Drawing.Size(284, 21);
            this.labPay.TabIndex = 0;
            this.labPay.Text = "0";
            // 
            // labRecive
            // 
            this.labRecive.Location = new System.Drawing.Point(6, 43);
            this.labRecive.Name = "labRecive";
            this.labRecive.Size = new System.Drawing.Size(284, 21);
            this.labRecive.TabIndex = 0;
            this.labRecive.Text = "0";
            // 
            // labBalance
            // 
            this.labBalance.Location = new System.Drawing.Point(6, 130);
            this.labBalance.Name = "labBalance";
            this.labBalance.Size = new System.Drawing.Size(284, 21);
            this.labBalance.TabIndex = 0;
            this.labBalance.Text = "0";
            // 
            // btnRefreshMAin
            // 
            this.btnRefreshMAin.Image = global::AccountingAPP.Properties.Resources._1371476368_Synchronize;
            this.btnRefreshMAin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefreshMAin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshMAin.Name = "btnRefreshMAin";
            this.btnRefreshMAin.Size = new System.Drawing.Size(76, 64);
            this.btnRefreshMAin.Text = "بروزرسانی";
            this.btnRefreshMAin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshMAin.Click += new System.EventHandler(this.btnRefreshMAin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStripCustomer);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripCustomer.ResumeLayout(false);
            this.toolStripCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStripCustomer;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton btnNewAccounting;
        private System.Windows.Forms.ToolStripButton BtnReportPay;
        private System.Windows.Forms.ToolStripButton BtnReportRecive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtdate;
        private System.Windows.Forms.ToolStripStatusLabel txtTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem btnChangePass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labBalance;
        private System.Windows.Forms.Label labRecive;
        private System.Windows.Forms.Label labPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnRefreshMAin;
    }
}

