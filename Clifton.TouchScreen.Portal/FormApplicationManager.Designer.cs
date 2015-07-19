namespace Clifton.TouchScreen.Portal {
    partial class FormApplicationManager{
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
            this.btn_Kill = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.dgApplicationList = new System.Windows.Forms.DataGridView();
            this.dgcApplicationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgApplicationList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Kill
            // 
            this.btn_Kill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Kill.Location = new System.Drawing.Point(183, 334);
            this.btn_Kill.Name = "btn_Kill";
            this.btn_Kill.Size = new System.Drawing.Size(141, 52);
            this.btn_Kill.TabIndex = 2;
            this.btn_Kill.Text = "Kill";
            this.btn_Kill.UseVisualStyleBackColor = true;
            this.btn_Kill.Click += new System.EventHandler(this.btn_Kill_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restart.Location = new System.Drawing.Point(350, 334);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(141, 52);
            this.btn_Restart.TabIndex = 3;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(16, 411);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(475, 52);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close Application Manager";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_About
            // 
            this.btn_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_About.Location = new System.Drawing.Point(16, 334);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(141, 52);
            this.btn_About.TabIndex = 1;
            this.btn_About.Text = "About";
            this.btn_About.UseVisualStyleBackColor = true;
            // 
            // dgApplicationList
            // 
            this.dgApplicationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcApplicationName,
            this.dgcVersion,
            this.dgcStartTime});
            this.dgApplicationList.Location = new System.Drawing.Point(16, 12);
            this.dgApplicationList.Name = "dgApplicationList";
            this.dgApplicationList.Size = new System.Drawing.Size(475, 302);
            this.dgApplicationList.TabIndex = 6;
            // 
            // dgcApplicationName
            // 
            this.dgcApplicationName.DataPropertyName = "DisplayName";
            this.dgcApplicationName.HeaderText = "Application Name";
            this.dgcApplicationName.Name = "dgcApplicationName";
            this.dgcApplicationName.ReadOnly = true;
            // 
            // dgcVersion
            // 
            this.dgcVersion.DataPropertyName = "Version";
            this.dgcVersion.HeaderText = "Version";
            this.dgcVersion.Name = "dgcVersion";
            this.dgcVersion.ReadOnly = true;
            // 
            // dgcStartTime
            // 
            this.dgcStartTime.DataPropertyName = "CreationTime";
            this.dgcStartTime.HeaderText = "Start Time";
            this.dgcStartTime.Name = "dgcStartTime";
            this.dgcStartTime.ReadOnly = true;
            // 
            // FormApplicationManager
            // 
            this.AcceptButton = this.btn_Close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(506, 480);
            this.ControlBox = false;
            this.Controls.Add(this.dgApplicationList);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.btn_Kill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormApplicationManager";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Touch Screen Portal Application Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgApplicationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Kill;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.DataGridView dgApplicationList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcApplicationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcStartTime;
    }
}