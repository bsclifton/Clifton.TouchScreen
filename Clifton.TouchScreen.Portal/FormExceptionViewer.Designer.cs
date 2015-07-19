namespace Clifton.TouchScreen.Portal {
    partial class FormExceptionViewer{
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
            this.txt_ExceptionDescription = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_SaveToDisk = new System.Windows.Forms.Button();
            this.btn_ReportError = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ExceptionDescription
            // 
            this.txt_ExceptionDescription.AcceptsReturn = true;
            this.txt_ExceptionDescription.AcceptsTab = true;
            this.txt_ExceptionDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ExceptionDescription.Location = new System.Drawing.Point(12, 32);
            this.txt_ExceptionDescription.Multiline = true;
            this.txt_ExceptionDescription.Name = "txt_ExceptionDescription";
            this.txt_ExceptionDescription.ReadOnly = true;
            this.txt_ExceptionDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ExceptionDescription.Size = new System.Drawing.Size(482, 132);
            this.txt_ExceptionDescription.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Close.Location = new System.Drawing.Point(394, 215);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(102, 23);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_SaveToDisk
            // 
            this.btn_SaveToDisk.Location = new System.Drawing.Point(203, 215);
            this.btn_SaveToDisk.Name = "btn_SaveToDisk";
            this.btn_SaveToDisk.Size = new System.Drawing.Size(185, 23);
            this.btn_SaveToDisk.TabIndex = 2;
            this.btn_SaveToDisk.Text = "Save error details to disk";
            this.btn_SaveToDisk.UseVisualStyleBackColor = true;
            // 
            // btn_ReportError
            // 
            this.btn_ReportError.Enabled = false;
            this.btn_ReportError.Location = new System.Drawing.Point(12, 215);
            this.btn_ReportError.Name = "btn_ReportError";
            this.btn_ReportError.Size = new System.Drawing.Size(185, 23);
            this.btn_ReportError.TabIndex = 1;
            this.btn_ReportError.Text = "Report error to clifton.io";
            this.btn_ReportError.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Error Details";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "If this error keeps occuring, you should either report the error to clifton.io " +
                "or save to disk and email to support@clifton.io.  I will take a look at the prob" +
                "lem and hopefully fix it.  Thanks";
            // 
            // FormExceptionViewer
            // 
            this.AcceptButton = this.btn_Close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 250);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ReportError);
            this.Controls.Add(this.btn_SaveToDisk);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.txt_ExceptionDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExceptionViewer";
            this.Text = "An error occured - the program must close";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ExceptionDescription;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_SaveToDisk;
        private System.Windows.Forms.Button btn_ReportError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}