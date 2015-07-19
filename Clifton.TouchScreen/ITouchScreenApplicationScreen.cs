using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Clifton.TouchScreen {
    public class ITouchScreenApplicationScreen : UserControl, IDisposable {
        #region Members

        private List<TouchScreenApplicationMenuItem> menuOptions = new List<TouchScreenApplicationMenuItem>();
        private ITouchScreenApplication parent = null;

        #endregion

        #region Properties

        public List<TouchScreenApplicationMenuItem> MenuOptions {
            get { return menuOptions; }
        }
        public ITouchScreenApplication ParentTouchScreenApplication {
            get { return parent; }
        }

        #endregion

        public ITouchScreenApplicationScreen() {
        }

        #region Methods

        internal void SetParent(ITouchScreenApplication parent) {
            if (parent == null) {
                throw new ArgumentNullException("ITouchScreenApplication must not be null!");
            }
            this.parent = parent;
        }

        protected void RegisterMenu(string name, int order, TouchScreenApplicationMenuAction action) {
            menuOptions.Add(new TouchScreenApplicationMenuItem(name, order, action));
        }

        protected void RegisterMenu(string name, int order, EventHandler customEventHandler) {
            menuOptions.Add(new TouchScreenApplicationMenuItem(name, order, customEventHandler));
        }

        #endregion

        #region IDisposable Implementation

        public new virtual void Dispose() {
            base.Dispose();
        }

        #endregion
    }
}
