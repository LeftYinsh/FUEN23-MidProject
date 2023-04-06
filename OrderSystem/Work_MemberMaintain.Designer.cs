namespace OrderSystem
{
    partial class Work_MemberMaintain
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
            this.lbl_MemberMaintain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_MemberMaintain
            // 
            this.lbl_MemberMaintain.AutoSize = true;
            this.lbl_MemberMaintain.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_MemberMaintain.Location = new System.Drawing.Point(593, 18);
            this.lbl_MemberMaintain.Name = "lbl_MemberMaintain";
            this.lbl_MemberMaintain.Size = new System.Drawing.Size(182, 50);
            this.lbl_MemberMaintain.TabIndex = 2;
            this.lbl_MemberMaintain.Text = "會員管理";
            // 
            // Work_MemberMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1368, 789);
            this.Controls.Add(this.lbl_MemberMaintain);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Work_MemberMaintain";
            this.Text = "Work_MemberMaintain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MemberMaintain;
    }
}