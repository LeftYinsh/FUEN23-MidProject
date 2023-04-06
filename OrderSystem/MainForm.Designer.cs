namespace OrderSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_WorkArea = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_MenuArea = new System.Windows.Forms.Panel();
            this.panel_FuncArea = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel_WorkArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_WorkArea
            // 
            this.panel_WorkArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_WorkArea.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_WorkArea.Controls.Add(this.label1);
            this.panel_WorkArea.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.panel_WorkArea.Location = new System.Drawing.Point(216, 0);
            this.panel_WorkArea.Name = "panel_WorkArea";
            this.panel_WorkArea.Size = new System.Drawing.Size(1368, 789);
            this.panel_WorkArea.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 40F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(454, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "歡迎使用訂單系統";
            // 
            // panel_MenuArea
            // 
            this.panel_MenuArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_MenuArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_MenuArea.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.panel_MenuArea.Location = new System.Drawing.Point(0, 0);
            this.panel_MenuArea.Name = "panel_MenuArea";
            this.panel_MenuArea.Size = new System.Drawing.Size(216, 789);
            this.panel_MenuArea.TabIndex = 8;
            // 
            // panel_FuncArea
            // 
            this.panel_FuncArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_FuncArea.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_FuncArea.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.panel_FuncArea.Location = new System.Drawing.Point(216, 789);
            this.panel_FuncArea.Name = "panel_FuncArea";
            this.panel_FuncArea.Size = new System.Drawing.Size(1368, 72);
            this.panel_FuncArea.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.Location = new System.Drawing.Point(18, 795);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(180, 60);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "離開系統";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel_WorkArea);
            this.Controls.Add(this.panel_FuncArea);
            this.Controls.Add(this.panel_MenuArea);
            this.Font = new System.Drawing.Font("新細明體", 9F);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainForm";
            this.Text = "商品訂單系統";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_WorkArea.ResumeLayout(false);
            this.panel_WorkArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_WorkArea;
        private System.Windows.Forms.Panel panel_MenuArea;
        private System.Windows.Forms.Panel panel_FuncArea;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
    }
}

