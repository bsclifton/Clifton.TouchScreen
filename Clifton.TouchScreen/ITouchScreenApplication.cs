using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;

namespace Clifton.TouchScreen {
    public delegate void TouchScreenBasicEvent();

    public abstract class ITouchScreenApplication : IDisposable {
        #region Members

        private Stack<ITouchScreenApplicationScreen> screenStack = new Stack<ITouchScreenApplicationScreen>();
        private List<TouchScreenEvent> events = new List<TouchScreenEvent>();
        private DateTime creationTime = DateTime.Now;

        #endregion

        #region Events

        public event TouchScreenBasicEvent OnMenuChanged = null;
        public event TouchScreenBasicEvent OnScreenPushed = null;

        #endregion

        #region Properties

        public DateTime CreationTime {
            get { return creationTime; }
        }
        public ITouchScreenApplicationScreen CurrentScreen {
            get { return screenStack.Peek(); }
        }
        public string DisplayName { 
            get; private set; 
        }
        public List<TouchScreenEvent> Events {
            get { return events; }
        }
        public abstract Image TaskbarImage { get; }
        public string Version {
            get { return this.GetType().Assembly.GetName().Version.ToString(); }
        }

        #endregion

        public ITouchScreenApplication(string displayName) {
            //null /empty check
            if (string.IsNullOrWhiteSpace(displayName)) {
                throw new ArgumentException("DisplayName cannot be null or zero length!");
            }

            //check for invalid characters
            char[] InvalidCharacters = new char[] { '\\', '/', ':', '*', '?', '\"', '<', '>', '|' };
            if (displayName.IndexOfAny(InvalidCharacters) != -1) {
                throw new ArgumentException("DisplayName cannot contain any of the following characters: \\/:*?\"<>|");
            }

            //TODO: make sure this program isn't already registered?
            DisplayName = displayName;

            //load the application's configuration from disk
            ConfigurationLoad();
        }

        #region Methods

        public void ClearEventHandlers() {
            OnMenuChanged = null;
            OnScreenPushed = null;
        }

        protected abstract void ConfigurationLoad();

        protected abstract void ConfigurationSave();

        public string GetApplicationConfigurationPath() {
            string strPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString() + "\\TouchScreenPortal";

            if (!Directory.Exists(strPath)) {
                Directory.CreateDirectory(strPath);
            }

            strPath += ("\\" + DisplayName);
            if (!Directory.Exists(strPath)) {
                Directory.CreateDirectory(strPath);
            }

            return strPath;
        }

        public bool PopScreen() {
            if (screenStack.Count > 0) {
                ITouchScreenApplicationScreen screen = screenStack.Peek();
                if (screen != null) {
                    //pop the current screen and dispose
                    screenStack.Pop().Dispose();
                }
            }
            return screenStack.Count != 0;
        }

        public void PushScreen(ITouchScreenApplicationScreen screen) {
            if (screen == null) {
                throw new ArgumentNullException("ITouchScreenApplicationScreen must not be null!");
            }

            //set this class as the parent application
            screen.SetParent(this);

            //push the screen onto stack
            screenStack.Push(screen);

            //trigger the screen pushed event
            if (OnScreenPushed != null) {
                OnScreenPushed();
            }
        }

        //RegisterEvent();
        //RegisterEvent();

        #endregion

        #region IDisposable Implementation

        public virtual void Dispose() {
            //dispose of the screens
            while (PopScreen()) ;

            //save the application's configuration to disk
            ConfigurationSave();
        }

        #endregion
    }
}