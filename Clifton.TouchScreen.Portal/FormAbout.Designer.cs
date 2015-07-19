namespace Clifton.TouchScreen.Portal {
    partial class FormAbout{
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
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.ll_HomePage = new System.Windows.Forms.LinkLabel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = global::Clifton.TouchScreen.Portal.Properties.Resources.logo;
            this.pb_Logo.Location = new System.Drawing.Point(12, 12);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(128, 128);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(419, 120);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // ll_HomePage
            // 
            this.ll_HomePage.AutoSize = true;
            this.ll_HomePage.Location = new System.Drawing.Point(148, 68);
            this.ll_HomePage.Name = "ll_HomePage";
            this.ll_HomePage.Size = new System.Drawing.Size(82, 13);
            this.ll_HomePage.TabIndex = 2;
            this.ll_HomePage.TabStop = true;
            this.ll_HomePage.Text = "https://clifton.io";
            this.ll_HomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_HomePage_LinkClicked);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(148, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(208, 25);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Touch Screen Portal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "© 2007 - 2015 Clifton Consulting Group";
            // 
            // FormAbout
            // 
            this.AcceptButton = this.btn_Close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(506, 152);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.ll_HomePage);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.pb_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About This Program";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.LinkLabel ll_HomePage;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label2;
    }
}