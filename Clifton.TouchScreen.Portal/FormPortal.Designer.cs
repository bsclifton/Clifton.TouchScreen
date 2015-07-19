namespace Clifton.TouchScreen.Portal {
    partial class FormPortal{
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
            this.gb_Menu = new System.Windows.Forms.GroupBox();
            this.gb_Applications = new System.Windows.Forms.GroupBox();
            this.gb_Taskbar = new System.Windows.Forms.GroupBox();
            this.btn_TaskbarRight = new System.Windows.Forms.Button();
            this.btn_TaskbarLeft = new System.Windows.Forms.Button();
            this.gb_Logo = new System.Windows.Forms.GroupBox();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.btn_MenuSwap = new System.Windows.Forms.Button();
            this.gb_Menu.SuspendLayout();
            this.gb_Taskbar.SuspendLayout();
            this.gb_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Menu
            // 
            this.gb_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_Menu.Controls.Add(this.btn_MenuSwap);
            this.gb_Menu.Location = new System.Drawing.Point(10, 114);
            this.gb_Menu.Name = "gb_Menu";
            this.gb_Menu.Size = new System.Drawing.Size(100, 322);
            this.gb_Menu.TabIndex = 6;
            this.gb_Menu.TabStop = false;
            this.gb_Menu.Text = "Menu";
            // 
            // gb_Applications
            // 
            this.gb_Applications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Applications.Location = new System.Drawing.Point(120, 114);
            this.gb_Applications.Name = "gb_Applications";
            this.gb_Applications.Size = new System.Drawing.Size(502, 322);
            this.gb_Applications.TabIndex = 7;
            this.gb_Applications.TabStop = false;
            this.gb_Applications.Text = "Application";
            // 
            // gb_Taskbar
            // 
            this.gb_Taskbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Taskbar.Controls.Add(this.btn_TaskbarRight);
            this.gb_Taskbar.Controls.Add(this.btn_TaskbarLeft);
            this.gb_Taskbar.Location = new System.Drawing.Point(120, 10);
            this.gb_Taskbar.Name = "gb_Taskbar";
            this.gb_Taskbar.Size = new System.Drawing.Size(502, 100);
            this.gb_Taskbar.TabIndex = 8;
            this.gb_Taskbar.TabStop = false;
            this.gb_Taskbar.Text = "Program Taskbar";
            // 
            // btn_TaskbarRight
            // 
            this.btn_TaskbarRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TaskbarRight.Enabled = false;
            this.btn_TaskbarRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaskbarRight.Location = new System.Drawing.Point(423, 21);
            this.btn_TaskbarRight.Name = "btn_TaskbarRight";
            this.btn_TaskbarRight.Size = new System.Drawing.Size(64, 64);
            this.btn_TaskbarRight.TabIndex = 4;
            this.btn_TaskbarRight.Text = ">>";
            this.btn_TaskbarRight.UseVisualStyleBackColor = true;
            // 
            // btn_TaskbarLeft
            // 
            this.btn_TaskbarLeft.Enabled = false;
            this.btn_TaskbarLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaskbarLeft.Location = new System.Drawing.Point(15, 21);
            this.btn_TaskbarLeft.Name = "btn_TaskbarLeft";
            this.btn_TaskbarLeft.Size = new System.Drawing.Size(64, 64);
            this.btn_TaskbarLeft.TabIndex = 3;
            this.btn_TaskbarLeft.Text = "<<";
            this.btn_TaskbarLeft.UseVisualStyleBackColor = true;
            // 
            // gb_Logo
            // 
            this.gb_Logo.Controls.Add(this.pb_Logo);
            this.gb_Logo.Location = new System.Drawing.Point(10, 10);
            this.gb_Logo.Name = "gb_Logo";
            this.gb_Logo.Size = new System.Drawing.Size(100, 100);
            this.gb_Logo.TabIndex = 10;
            this.gb_Logo.TabStop = false;
            this.gb_Logo.Text = "Clifton";
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Logo.Image = global::Clifton.TouchScreen.Portal.Properties.Resources.logo;
            this.pb_Logo.Location = new System.Drawing.Point(9, 15);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(82, 76);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 10;
            this.pb_Logo.TabStop = false;
            this.pb_Logo.Click += new System.EventHandler(this.pb_Logo_Click);
            // 
            // btn_MenuSwap
            // 
            this.btn_MenuSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MenuSwap.Location = new System.Drawing.Point(18, 246);
            this.btn_MenuSwap.Name = "btn_MenuSwap";
            this.btn_MenuSwap.Size = new System.Drawing.Size(64, 64);
            this.btn_MenuSwap.TabIndex = 0;
            this.btn_MenuSwap.Text = ">>";
            this.btn_MenuSwap.UseVisualStyleBackColor = true;
            this.btn_MenuSwap.Click += new System.EventHandler(this.btn_MenuSwap_Click);
            // 
            // FormPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Controls.Add(this.gb_Logo);
            this.Controls.Add(this.gb_Taskbar);
            this.Controls.Add(this.gb_Applications);
            this.Controls.Add(this.gb_Menu);
            this.Name = "FormPortal";
            this.ShowIcon = false;
            this.Text = "Touch Screen Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPortal_FormClosed);
            this.gb_Menu.ResumeLayout(false);
            this.gb_Taskbar.ResumeLayout(false);
            this.gb_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Menu;
        private System.Windows.Forms.GroupBox gb_Applications;
        private System.Windows.Forms.GroupBox gb_Taskbar;
        private System.Windows.Forms.Button btn_TaskbarRight;
        private System.Windows.Forms.Button btn_TaskbarLeft;
        private System.Windows.Forms.GroupBox gb_Logo;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button btn_MenuSwap;
    }
}