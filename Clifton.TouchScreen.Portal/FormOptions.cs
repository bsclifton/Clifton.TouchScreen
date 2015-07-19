using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Clifton.TouchScreen.Portal {
    public partial class FormOptions : Form {
        #region Imports
        [DllImport("winmm.dll")]
        private static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        private static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);
        #endregion

        private const int globalTickSize = 50;

        public FormOptions(DateTime logonTime, byte volumeApplication) {
            InitializeComponent();

            lbl_Username.Text = "You are logged in as " + Environment.UserDomainName + "\\" + Environment.UserName + ".";
            lbl_Logon.Text = "Logon Date: " + logonTime;

            SetVolumeDefault(volumeApplication);
        }

        private void SetVolumeDefault(byte volumeApplication) {
            //application volume
            tb_VolumeApplication.Value = volumeApplication;

            //global volume
            uint CurrVol = 0;
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            //scale this to the trackbar size (50)
            tb_VolumeGlobal.Value = (CalcVol / (ushort.MaxValue / globalTickSize));
        }

        private void tb_VolumeGlobal_Scroll(object sender, EventArgs e) {
            int NewVolume = ((ushort.MaxValue / globalTickSize) * tb_VolumeGlobal.Value);

            //set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void tb_VolumeApplication_Scroll(object sender, EventArgs e) {
            //TODO: fire the volume changed event here
        }
    }
}