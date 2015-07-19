namespace Clifton.TouchScreen.Portal {
    partial class FormOptions{
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
            this.gb_LogonInformation = new System.Windows.Forms.GroupBox();
            this.lbl_Logon = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.gb_VolumeControl = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_VolumeApplication = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_VolumeGlobal = new System.Windows.Forms.TrackBar();
            this.gb_Options = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_ApplicationManager = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.gb_LogonInformation.SuspendLayout();
            this.gb_VolumeControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_VolumeApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_VolumeGlobal)).BeginInit();
            this.gb_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_LogonInformation
            // 
            this.gb_LogonInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_LogonInformation.Controls.Add(this.lbl_Logon);
            this.gb_LogonInformation.Controls.Add(this.lbl_Username);
            this.gb_LogonInformation.Location = new System.Drawing.Point(12, 3);
            this.gb_LogonInformation.Name = "gb_LogonInformation";
            this.gb_LogonInformation.Size = new System.Drawing.Size(416, 72);
            this.gb_LogonInformation.TabIndex = 4;
            this.gb_LogonInformation.TabStop = false;
            this.gb_LogonInformation.Text = "Logon Information";
            // 
            // lbl_Logon
            // 
            this.lbl_Logon.Location = new System.Drawing.Point(6, 47);
            this.lbl_Logon.Name = "lbl_Logon";
            this.lbl_Logon.Size = new System.Drawing.Size(278, 17);
            this.lbl_Logon.TabIndex = 1;
            this.lbl_Logon.Text = "Logon Date:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.Location = new System.Drawing.Point(6, 21);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(278, 17);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "You are logged in as";
            // 
            // gb_VolumeControl
            // 
            this.gb_VolumeControl.Controls.Add(this.label2);
            this.gb_VolumeControl.Controls.Add(this.tb_VolumeApplication);
            this.gb_VolumeControl.Controls.Add(this.label1);
            this.gb_VolumeControl.Controls.Add(this.tb_VolumeGlobal);
            this.gb_VolumeControl.Location = new System.Drawing.Point(12, 277);
            this.gb_VolumeControl.Name = "gb_VolumeControl";
            this.gb_VolumeControl.Size = new System.Drawing.Size(416, 166);
            this.gb_VolumeControl.TabIndex = 9;
            this.gb_VolumeControl.TabStop = false;
            this.gb_VolumeControl.Text = "Volume Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Application Volume";
            // 
            // tb_VolumeApplication
            // 
            this.tb_VolumeApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_VolumeApplication.Location = new System.Drawing.Point(9, 111);
            this.tb_VolumeApplication.Maximum = 255;
            this.tb_VolumeApplication.Name = "tb_VolumeApplication";
            this.tb_VolumeApplication.Size = new System.Drawing.Size(401, 45);
            this.tb_VolumeApplication.TabIndex = 11;
            this.tb_VolumeApplication.TickFrequency = 5;
            this.tb_VolumeApplication.Scroll += new System.EventHandler(this.tb_VolumeApplication_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Global Volume";
            // 
            // tb_VolumeGlobal
            // 
            this.tb_VolumeGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_VolumeGlobal.LargeChange = 1;
            this.tb_VolumeGlobal.Location = new System.Drawing.Point(9, 43);
            this.tb_VolumeGlobal.Maximum = 50;
            this.tb_VolumeGlobal.Name = "tb_VolumeGlobal";
            this.tb_VolumeGlobal.Size = new System.Drawing.Size(401, 45);
            this.tb_VolumeGlobal.TabIndex = 9;
            this.tb_VolumeGlobal.Scroll += new System.EventHandler(this.tb_VolumeGlobal_Scroll);
            // 
            // gb_Options
            // 
            this.gb_Options.Controls.Add(this.button2);
            this.gb_Options.Controls.Add(this.button1);
            this.gb_Options.Controls.Add(this.btn_Cancel);
            this.gb_Options.Controls.Add(this.btn_Exit);
            this.gb_Options.Controls.Add(this.btn_ApplicationManager);
            this.gb_Options.Controls.Add(this.btn_About);
            this.gb_Options.Location = new System.Drawing.Point(12, 81);
            this.gb_Options.Name = "gb_Options";
            this.gb_Options.Size = new System.Drawing.Size(416, 190);
            this.gb_Options.TabIndex = 10;
            this.gb_Options.TabStop = false;
            this.gb_Options.Text = "Options";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(280, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 64);
            this.button2.TabIndex = 9;
            this.button2.Text = "Empty Button";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(280, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "Empty Button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(144, 107);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(128, 64);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Close This Window";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btn_Exit.Location = new System.Drawing.Point(8, 107);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(128, 64);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Quit Program";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_ApplicationManager
            // 
            this.btn_ApplicationManager.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_ApplicationManager.Location = new System.Drawing.Point(144, 29);
            this.btn_ApplicationManager.Name = "btn_ApplicationManager";
            this.btn_ApplicationManager.Size = new System.Drawing.Size(128, 64);
            this.btn_ApplicationManager.TabIndex = 5;
            this.btn_ApplicationManager.Text = "Application Manager";
            this.btn_ApplicationManager.UseVisualStyleBackColor = true;
            // 
            // btn_About
            // 
            this.btn_About.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_About.Location = new System.Drawing.Point(8, 29);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(128, 64);
            this.btn_About.TabIndex = 4;
            this.btn_About.Text = "About This Program";
            this.btn_About.UseVisualStyleBackColor = true;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 455);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Options);
            this.Controls.Add(this.gb_VolumeControl);
            this.Controls.Add(this.gb_LogonInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Touch Screen Portal";
            this.gb_LogonInformation.ResumeLayout(false);
            this.gb_VolumeControl.ResumeLayout(false);
            this.gb_VolumeControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_VolumeApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_VolumeGlobal)).EndInit();
            this.gb_Options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_LogonInformation;
        private System.Windows.Forms.Label lbl_Logon;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.GroupBox gb_VolumeControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tb_VolumeApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_VolumeGlobal;
        private System.Windows.Forms.GroupBox gb_Options;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ApplicationManager;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}