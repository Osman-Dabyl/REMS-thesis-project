using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafat.Code.Helper
{
    public static class MsgHelper
    {
        public static void ShowServerError()
        {
            MessageBox.Show("it seems like server error, please try again later",
                  "Conncetion Error"
                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowRequiredFields()
        {
            MessageBox.Show("All filed are required ",
                  "Required Fields"
                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowDuplicatedItems()
        {
            MessageBox.Show("This item already exist, please choose another one ",
                  "Dublicated Items"
                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowEmptyDataGridView()
        {
            MessageBox.Show("To perform this action, you must select at least one row in the DataGrid",
                  "Empty DataGrid"
                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowDeleteSelectRow()
        {
            MessageBox.Show("For this action, you must select at least one row in the DataGrid ",
                  "Delete Action"
                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool ShowDeleteDialog()
        {
           var result= MessageBox.Show("Are you sure you want to delete this item ? ",
                  "Delete Action"
                  , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ShowNumberValid()
        {
            MessageBox.Show("Please enter a number value ",
                  "Wrong Value"
                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowValidLogin()
        {
            MessageBox.Show("Please enter a valid login ",
                  "Wrong Value"
                  , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
