using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Clifton.TouchScreen.Portal {
    public partial class FormPortal : Form {
        private List<ITouchScreenApplication> applications = new List<ITouchScreenApplication>();
        private ITouchScreenApplication currentApplication = null;
        private DateTime logonTime = DateTime.Now;
        private byte volume = 255;

        public FormPortal() {
            InitializeComponent();
            LoadLibraries();
        }

        /// <summary>
        /// This will search the Applications folder for valid ITouchScreenApplications and initialize them.
        /// </summary>
        public void LoadLibraries() {
            try {
                string LibraryPath = Application.StartupPath + "\\Applications";
                if (!Directory.Exists(LibraryPath)) {
                    return;
                }

                string[] Files = Directory.GetFiles(LibraryPath, "*.dll", SearchOption.TopDirectoryOnly);

                //load each compatible assembly
                foreach (string File in Files) {

                    if (File.ToUpper().Contains("\\CLIFTON.TOUCHSCREEN.DLL"))
                        continue;

                    Assembly asm = Assembly.LoadFile(File);
                    Type[] t = asm.GetTypes();
                    foreach (Type tt in t) {
                        if (string.Compare(tt.BaseType.FullName, "Clifton.TouchScreen.ITouchScreenApplication") == 0) {
                            ITouchScreenApplication tsa = (ITouchScreenApplication)Activator.CreateInstance(tt);
                            applications.Add(tsa);
                        }
                    }
                }

                //refresh the taskbar to show the applications
                OnRefreshTaskbar(null, null);
            } catch (Exception) {
                //this will cause the program to exit.
                FormPortal_FormClosed(null, null);
                throw;
            }
        }

        private void OnRefreshTaskbar(object sender, EventArgs e) {
            List<Control> ToRemove = new List<Control>();

            //remove old controls
            foreach (Control c in gb_Taskbar.Controls) {
                if (c.Name.Contains("btn_TouchScreenApplication")) {
                    ToRemove.Add(c);
                }
            }
            foreach (Control c in ToRemove) {
                gb_Taskbar.Controls.Remove(c);
            }

            //add new application controls
            int index = 0;
            foreach (ITouchScreenApplication app in applications) {
                Button b = new Button();

                b.Width = b.Height = 64;

                b.Name = "btn_TouchScreenApplication" + index;
                b.Text = app.DisplayName;
                b.Left = (btn_TaskbarLeft.Right + 21) + ((b.Width + 10) * index);
                b.Top = 21;
                b.Tag = app;
                b.Click += new EventHandler(Button_OnApplicationClick);

                app.ClearEventHandlers();
                app.OnMenuChanged += new TouchScreenBasicEvent(Screen_OnMenuChanged);
                app.OnScreenPushed += new TouchScreenBasicEvent(Screen_OnPush);

                b.TabIndex = index++;

                gb_Taskbar.Controls.Add(b);
            }

            //load a default application
            if (applications.Count > 0) {
                currentApplication = applications[0];
                UpdateMenu();
                UpdateScreen();
            }
            return;
        }

        #region Application Update Code (redraw, get menus, etc)

        /// <summary>
        /// 
        /// </summary>
        private void UpdateMenu() {
            if ((currentApplication != null) && (currentApplication.CurrentScreen != null)) {
                List<TouchScreenApplicationMenuItem> menu = currentApplication.CurrentScreen.MenuOptions;
                List<Control> toRemove = new List<Control>();

                foreach (Control ctrl in gb_Menu.Controls) {
                    Button btn = ctrl as Button;
                    if ((btn != null) && (btn.Name == "btn_MenuSwap")) {
                        continue;
                    }
                    toRemove.Add(ctrl);
                }
                foreach (Control ctrl in toRemove) {
                    gb_Menu.Controls.Remove(ctrl);
                }

                int i = 0;

                if (menu != null) {
                    //sort by ORDER here
                    //..

                    //create menu
                    foreach (TouchScreenApplicationMenuItem mi in menu) {
                        Button b = new Button();

                        b.Width = b.Height = 64;

                        b.Name = "btn_TouchScreenApplicationMenuItem" + i;
                        b.Text = mi.Name;
                        b.Left = 18;
                        b.Top = (gb_Menu.ClientRectangle.Top + 21) + ((b.Height + 10) * i);

                        b.TabIndex = i;

                        gb_Menu.Controls.Add(b);
                        switch (mi.Action) {
                            case TouchScreenApplicationMenuAction.About:
                                b.Click += new EventHandler(Menu_OnAbout);
                                break;

                            case TouchScreenApplicationMenuAction.Pop:
                                b.Click += new EventHandler(Menu_OnPop);
                                break;

                            case TouchScreenApplicationMenuAction.CustomAction:
                                if (mi.CustomEventHandler != null) {
                                    b.Click += new EventHandler(mi.CustomEventHandler);
                                }
                                break;
                        }
                        i++;
                    }
                }
            }
            return;
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpdateScreen() {
            if (currentApplication != null) {
                ITouchScreenApplicationScreen tsas = currentApplication.CurrentScreen;
                UserControl uc = tsas as UserControl;
                if (uc != null) {

                    //remove old control
                    Control[] old = gb_Applications.Controls.Find("uc_Form", false);
                    if (old != null) {
                        foreach (Control c in old) {
                            gb_Applications.Controls.Remove(c);
                        }
                    }

                    //add new control 
                    uc.Name = "uc_Form";
                    uc.Left = 16;
                    uc.Top = 22;
                    uc.Height = (gb_Applications.ClientRectangle.Bottom - 38);
                    uc.Width = (gb_Applications.ClientRectangle.Right - 32);
                    uc.Visible = true;
                    uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                    gb_Applications.Controls.Add(uc);
                    uc.BringToFront();
                }
            }
        }

        #endregion

        #region Default Button / Menu Action Code

        private void Button_OnApplicationClick(object sender, EventArgs e) {
            Button b = sender as Button;
            if ((b != null) && (b.Tag != null)) {
                currentApplication = (ITouchScreenApplication)b.Tag;
                UpdateMenu();
                UpdateScreen();
            }
        }

        private void Menu_OnAbout(object sender, EventArgs e) {
            MessageBox.Show("LOL!  ABOUT SCREEN HERE!!");
        }

        private void Menu_OnPop(object sender, EventArgs e) {
            if (currentApplication != null) {
                currentApplication.PopScreen();
                UpdateMenu();
                UpdateScreen();
            }
        }

        #endregion

        #region ITouchScreenApplication Events

        /// <summary>
        /// Event which occurs when the side menu has been updated by the screen.
        /// </summary>
        private void Screen_OnMenuChanged() {
            UpdateMenu();
        }
        /// <summary>
        /// Event which occurs when a new screen is created.
        /// </summary>
        private void Screen_OnPush() {
            UpdateMenu();
            UpdateScreen();
        }

        #endregion

        /// <summary>
        /// When the portal closes, shut down all the apps.
        /// </summary>
        private void FormPortal_FormClosed(object sender, FormClosedEventArgs e) {
            foreach (ITouchScreenApplication tsa in applications) {
                tsa.Dispose();
            }

            Application.Exit();
        }

        private void pb_Logo_Click(object sender, EventArgs e) {
            FormOptions options = new FormOptions(logonTime, volume);
            DialogResult dr = options.ShowDialog();

            options.Dispose();
            options = null;

            switch (dr) {
                //About
                case DialogResult.Yes: {
                        FormAbout about = new FormAbout();
                        about.ShowDialog();
                        about.Dispose();
                        about = null;
                    }
                    break;

                //Application Manager
                case DialogResult.No: {
                        FormApplicationManager mgr = new FormApplicationManager(applications, new EventHandler(OnRefreshTaskbar));
                        dr = mgr.ShowDialog();
                        mgr.Dispose();
                        mgr = null;
                    }
                    break;

                //Exit
                case DialogResult.Abort:
                    dr = MessageBox.Show("Are you sure you want to exit?  All running programs will be closed!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) {
                        FormPortal_FormClosed(null, null);
                    }
                    return;
            }
        }

        private void btn_MenuSwap_Click(object sender, EventArgs e) {
            if (btn_MenuSwap.Text == ">>") {
                //set the anchors
                gb_Logo.Anchor = (AnchorStyles.Right | AnchorStyles.Top);
                gb_Menu.Anchor = (AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
                //move the control
                gb_Taskbar.Location = new Point(10, 10);
                gb_Applications.Location = new Point(10, 114);
                gb_Logo.Location = new Point(20 + gb_Taskbar.Width, 10);
                gb_Menu.Location = new Point(20 + gb_Taskbar.Width, 114);
                btn_MenuSwap.Text = "<<";
            } else {
                //reset anchors
                gb_Logo.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                gb_Menu.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
                //move the control
                gb_Logo.Location = new Point(10, 10);
                gb_Menu.Location = new Point(10, 114);
                gb_Taskbar.Location = new Point(120, 10);
                gb_Applications.Location = new Point(120, 114);
                btn_MenuSwap.Text = ">>";
            }
        }
    }
}