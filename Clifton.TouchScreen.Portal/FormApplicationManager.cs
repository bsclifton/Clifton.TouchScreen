using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Clifton.TouchScreen;

namespace Clifton.TouchScreen.Portal {
    public partial class FormApplicationManager : Form {
        #region Members

        private List<ITouchScreenApplication> applications = null; ///List of applications that are loaded
        private EventHandler refreshMethod = null; ///Event handler which fires when application is restarted or killed
        private BindingSource datasource = null; ///Used to force update on DataGridView

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="applications">List of applications that are loaded</param>
        /// <param name="refreshMethod">Event handler which fires when application is restarted or killed</param>
        public FormApplicationManager(List<ITouchScreenApplication> applications, EventHandler refreshMethod) {
            if (applications == null) {
                throw new ArgumentNullException("List<ITouchScreenApplication> must not be null!");
            }
            this.applications = applications;
            if (refreshMethod == null) {
                throw new ArgumentNullException("EventHandler must not be null!");
            }
            this.refreshMethod = refreshMethod;

            InitializeComponent();
            ControlHelper.FormatDefaultDataGrid(ref dgApplicationList);

            this.datasource = new BindingSource();
            this.datasource.DataSource = applications;
            dgApplicationList.DataSource = datasource;
        }

        private void btn_Kill_Click(object sender, EventArgs e) {
            ITouchScreenApplication SelectedApplication = dgApplicationList.SelectedRows[0].DataBoundItem as ITouchScreenApplication;
            if (SelectedApplication != null) {
                string ApplicationName = SelectedApplication.DisplayName;
                try {
                    SelectedApplication.Dispose();
                    MessageBox.Show("Application \"" + ApplicationName + "\" was successfully killed.");
                    applications.Remove(SelectedApplication);
                    refreshMethod(sender, e);
                    datasource.CurrencyManager.Refresh();
                } catch (Exception ex) {
                    MessageBox.Show("Error while killing application \"" + ApplicationName + "\".\n\n" + ex.ToString());
                }
            }
        }

        private void btn_Restart_Click(object sender, EventArgs e) {
            ITouchScreenApplication SelectedApplication = dgApplicationList.SelectedRows[0].DataBoundItem as ITouchScreenApplication;
            if (SelectedApplication != null) {
                string ApplicationName = SelectedApplication.DisplayName;
                try {
                    int ApplicationIndex = dgApplicationList.SelectedRows[0].Index;//_Applications.IndexOf(SelectedApplication);
                    Type ApplicationType = SelectedApplication.GetType();
                    //show a stopping progress bar?
                    SelectedApplication.Dispose();
                    //show a starting progress bar?
                    applications[ApplicationIndex] = (ITouchScreenApplication)Activator.CreateInstance(ApplicationType);
                    MessageBox.Show("Application \"" + ApplicationName + "\" was successfully restarted.");
                    refreshMethod(sender, e);
                    datasource.CurrencyManager.Refresh();
                } catch (Exception ex) {
                    MessageBox.Show("Error while restarting application \"" + ApplicationName + "\".\n\n" + ex.ToString());
                }
            }
        }
    }
}