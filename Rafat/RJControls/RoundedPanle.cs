using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rafat.RJControls
{
    

    public class RoundedPanel : Panel
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Set rounded corners
            IntPtr handle = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20);
            this.Region = Region.FromHrgn(handle);
        }
    }

}
