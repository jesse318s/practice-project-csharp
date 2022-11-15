namespace JSitesM1
{
    partial class frmReceipt
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
            this.lbxReceipt = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxTip = new System.Windows.Forms.GroupBox();
            this.rdo25 = new System.Windows.Forms.RadioButton();
            this.rdo20 = new System.Windows.Forms.RadioButton();
            this.rdo15 = new System.Windows.Forms.RadioButton();
            this.gbxTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxReceipt
            // 
            this.lbxReceipt.FormattingEnabled = true;
            this.lbxReceipt.ItemHeight = 16;
            this.lbxReceipt.Location = new System.Drawing.Point(242, 17);
            this.lbxReceipt.Name = "lbxReceipt";
            this.lbxReceipt.Size = new System.Drawing.Size(329, 292);
            this.lbxReceipt.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxTip
            // 
            this.gbxTip.Controls.Add(this.rdo25);
            this.gbxTip.Controls.Add(this.rdo20);
            this.gbxTip.Controls.Add(this.rdo15);
            this.gbxTip.Location = new System.Drawing.Point(242, 331);
            this.gbxTip.Name = "gbxTip";
            this.gbxTip.Size = new System.Drawing.Size(329, 51);
            this.gbxTip.TabIndex = 3;
            this.gbxTip.TabStop = false;
            this.gbxTip.Text = "Tip";
            // 
            // rdo25
            // 
            this.rdo25.AutoSize = true;
            this.rdo25.Location = new System.Drawing.Point(224, 21);
            this.rdo25.Name = "rdo25";
            this.rdo25.Size = new System.Drawing.Size(54, 20);
            this.rdo25.TabIndex = 2;
            this.rdo25.TabStop = true;
            this.rdo25.Text = "25%";
            this.rdo25.UseVisualStyleBackColor = true;
            this.rdo25.CheckedChanged += new System.EventHandler(this.rdo25_CheckedChanged);
            // 
            // rdo20
            // 
            this.rdo20.AutoSize = true;
            this.rdo20.Location = new System.Drawing.Point(115, 21);
            this.rdo20.Name = "rdo20";
            this.rdo20.Size = new System.Drawing.Size(54, 20);
            this.rdo20.TabIndex = 1;
            this.rdo20.TabStop = true;
            this.rdo20.Text = "20%";
            this.rdo20.UseVisualStyleBackColor = true;
            this.rdo20.CheckedChanged += new System.EventHandler(this.rdo20_CheckedChanged);
            // 
            // rdo15
            // 
            this.rdo15.AutoSize = true;
            this.rdo15.Checked = true;
            this.rdo15.Location = new System.Drawing.Point(6, 21);
            this.rdo15.Name = "rdo15";
            this.rdo15.Size = new System.Drawing.Size(54, 20);
            this.rdo15.TabIndex = 0;
            this.rdo15.TabStop = true;
            this.rdo15.Text = "15%";
            this.rdo15.UseVisualStyleBackColor = true;
            this.rdo15.CheckedChanged += new System.EventHandler(this.rdo15_CheckedChanged);
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxTip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbxReceipt);
            this.Name = "frmReceipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.gbxTip.ResumeLayout(false);
            this.gbxTip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxReceipt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxTip;
        private System.Windows.Forms.RadioButton rdo25;
        private System.Windows.Forms.RadioButton rdo20;
        private System.Windows.Forms.RadioButton rdo15;
    }
}