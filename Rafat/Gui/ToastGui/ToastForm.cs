using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rafat.Gui.ToastGui
{
    public partial class ToastForm : Form
    {
        private static ToastForm _toastForm;
        public static string Title;
        public static string Description;
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        public ToastForm()
        {
            InitializeComponent();

            
        }

        public static ToastForm Instance(string title, string description)
        {
            Title = title;
            Description = description;
            return (_toastForm = new ToastForm());
        }

        private void timerToast_Tick(object sender, EventArgs e)
        {
            this.Close();
            timerToast.Enabled = false;
        }

        private void ToastForm_Activated(object sender, EventArgs e)
        {
            IntPtr handle = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20);
            this.Region = Region.FromHrgn(handle);
            PositionToast();
            PlayNotificationSound();
            labelTitle.Text = Title;
            labelDescription.Text = Description;
            timerToast.Interval = Properties.Settings.Default.ToastDuration;
            timerToast.Enabled = true;
        }

        private void PositionToast()
        {
           
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(workingArea.Right - this.Width - 10, workingArea.Top + 10);
        }

        private void PlayNotificationSound()
        {
            try
            {
                string soundFilePath = @"C:\Users\hp.osampc\Downloads\mixkit-interface-option-select-2573.wav";
                SoundPlayer player = new SoundPlayer(soundFilePath);
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }
    }
}
