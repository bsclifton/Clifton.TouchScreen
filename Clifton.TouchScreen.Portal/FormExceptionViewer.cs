using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clifton.TouchScreen.Portal {
    public partial class FormExceptionViewer : Form {
        private Exception exception;

        public string ErrorDetails {
            get { return txt_ExceptionDescription.Text; }
            set { txt_ExceptionDescription.Text = value; }
        }

        public FormExceptionViewer(Exception ex) {
            InitializeComponent();

            this.exception = ex;
            ErrorDetails = ex.ToString();
        }
    }
}