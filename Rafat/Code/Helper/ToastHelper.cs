using Rafat.Gui.ToastGui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafat.Code.Helper
{
    public static class ToastHelper
    {
        public static void ShowAddToast()
        {
            ToastForm.Instance("New Record", "data added successfully").Show();
        }

        public static void ShowEditToast()
        {
            ToastForm.Instance("Data Edit", "data  Updated successfully").Show();
        }

        public static void ShowDeleteToast()
        {
            ToastForm.Instance("Data Delete", "data  Deleted successfully").Show();
        }
    }
}
