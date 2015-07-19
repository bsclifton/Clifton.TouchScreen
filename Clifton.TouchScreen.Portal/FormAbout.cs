using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clifton.TouchScreen.Portal {
    public partial class FormAbout : Form {
        public FormAbout() {
            InitializeComponent();
        }

        private void ll_HomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "https://clifton.io";
            psi.UseShellExecute = true;
            System.Diagnostics.Process.Start(psi);
        }
    }
}