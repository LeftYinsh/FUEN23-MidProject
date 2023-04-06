namespace OrderSystem
{
    partial class MemberMenuForm
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
            this.btn_MemberInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MemberInformation
            // 
            this.btn_MemberInformation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MemberInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MemberInformation.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_MemberInformation.Location = new System.Drawing.Point(18, 12);
            this.btn_MemberInformation.Name = "btn_MemberInformation";
            this.btn_MemberInformation.Size = new System.Drawing.Size(180, 60);
            this.btn_MemberInformation.TabIndex = 4;
            this.btn_MemberInformation.Text = "會員資料";
            this.btn_MemberInformation.UseVisualStyleBackColor = false;
            // 
            // MemberMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(216, 789);
            this.Controls.Add(this.btn_MemberInformation);
            this.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "MemberMenuForm";
            this.Text = "MemberMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MemberInformation;
    }
}