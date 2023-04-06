namespace OrderSystem
{
    partial class Func_MemberInfo
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
            this.btn_ModifyInfo = new System.Windows.Forms.Button();
            this.btn_ModifyConfirm = new System.Windows.Forms.Button();
            this.btn_ModifyCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ModifyInfo
            // 
            this.btn_ModifyInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ModifyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ModifyInfo.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_ModifyInfo.Location = new System.Drawing.Point(445, 11);
            this.btn_ModifyInfo.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_ModifyInfo.Name = "btn_ModifyInfo";
            this.btn_ModifyInfo.Size = new System.Drawing.Size(150, 50);
            this.btn_ModifyInfo.TabIndex = 4;
            this.btn_ModifyInfo.Text = "修改資料";
            this.btn_ModifyInfo.UseVisualStyleBackColor = false;
            this.btn_ModifyInfo.Click += new System.EventHandler(this.btn_ModifyInfo_Click);
            // 
            // btn_ModifyConfirm
            // 
            this.btn_ModifyConfirm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ModifyConfirm.Enabled = false;
            this.btn_ModifyConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ModifyConfirm.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_ModifyConfirm.Location = new System.Drawing.Point(609, 11);
            this.btn_ModifyConfirm.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_ModifyConfirm.Name = "btn_ModifyConfirm";
            this.btn_ModifyConfirm.Size = new System.Drawing.Size(150, 50);
            this.btn_ModifyConfirm.TabIndex = 5;
            this.btn_ModifyConfirm.Text = "確認修改";
            this.btn_ModifyConfirm.UseVisualStyleBackColor = false;
            this.btn_ModifyConfirm.Click += new System.EventHandler(this.btn_ModifyConfirm_Click);
            // 
            // btn_ModifyCancel
            // 
            this.btn_ModifyCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ModifyCancel.Enabled = false;
            this.btn_ModifyCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ModifyCancel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btn_ModifyCancel.Location = new System.Drawing.Point(773, 11);
            this.btn_ModifyCancel.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_ModifyCancel.Name = "btn_ModifyCancel";
            this.btn_ModifyCancel.Size = new System.Drawing.Size(150, 50);
            this.btn_ModifyCancel.TabIndex = 6;
            this.btn_ModifyCancel.Text = "取消修改";
            this.btn_ModifyCancel.UseVisualStyleBackColor = false;
            this.btn_ModifyCancel.Click += new System.EventHandler(this.btn_ModifyCancel_Click);
            // 
            // Func_MemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1368, 72);
            this.Controls.Add(this.btn_ModifyCancel);
            this.Controls.Add(this.btn_ModifyConfirm);
            this.Controls.Add(this.btn_ModifyInfo);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Func_MemberInfo";
            this.Text = "MemberInfoFuncFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ModifyInfo;
        private System.Windows.Forms.Button btn_ModifyConfirm;
        private System.Windows.Forms.Button btn_ModifyCancel;
    }
}