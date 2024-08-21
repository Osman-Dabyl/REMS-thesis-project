using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rafat.Gui.ReportGui
{
    public partial class ReportLoading : Form
    {


        public ReportLoading()
        {
            InitializeComponent();
            progressBar1.Style = ProgressBarStyle.Marquee;
            
        }

        // Update progress manually from the calling code
    }

}

