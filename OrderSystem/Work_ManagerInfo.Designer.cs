namespace OrderSystem
{
    partial class Work_ManagerInfo
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
            this.lbl_ManagerInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ManagerInfo
            // 
            this.lbl_ManagerInfo.AutoSize = true;
            this.lbl_ManagerInfo.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_ManagerInfo.Location = new System.Drawing.Point(573, 18);
            this.lbl_ManagerInfo.Name = "lbl_ManagerInfo";
            this.lbl_ManagerInfo.Size = new System.Drawing.Size(222, 50);
            this.lbl_ManagerInfo.TabIndex = 2;
            this.lbl_ManagerInfo.Text = "管理員資料";
            // 
            // Work_ManagerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1368, 789);
            this.Controls.Add(this.lbl_ManagerInfo);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Work_ManagerInfo";
            this.Text = "Work_ManagerInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ManagerInfo;
    }
}