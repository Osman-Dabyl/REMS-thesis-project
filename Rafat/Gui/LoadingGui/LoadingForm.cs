﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;

namespace Rafat.Gui.LoadingGui
{
    public partial class LoadingForm : Form
    {
        private static LoadingForm? _loadingForm;
        private static Main _main;

        public LoadingForm()
        {
            InitializeComponent();
            this.Owner = _main;
        }

        public static LoadingForm Instance(Main main)
        {
        
            _main = main;
            return _loadingForm ?? (_loadingForm = new LoadingForm());
        

        }
    }
}
