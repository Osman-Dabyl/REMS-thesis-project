using Rafat.Gui.LoadingGui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rafat.Gui.loading
{
    public partial class LoadingUserControl : UserControl
    {
        private static Panel _panel;
        private static LoadingUserControl _loadindg;

        public LoadingUserControl()
        {
            InitializeComponent();

         
            this.Dock = DockStyle.Fill;

        }

        public static LoadingUserControl Instance(Panel panel)
        {
            _panel = panel;
          
            return _loadindg ?? (_loadindg = new ());
        }


    }
}
