using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clifton.TouchScreen.Portal {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try {
                Application.Run(new FormPortal());
            } catch (Exception ex) {
                FormExceptionViewer ev = new FormExceptionViewer(ex);
                DialogResult dr = ev.ShowDialog();
                Application.Exit();
            }
        }
    }
}