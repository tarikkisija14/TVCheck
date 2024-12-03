using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVCheck.WinApp.Helpers;

namespace TvCheck.WinApp.Helpers
{
    public class Validatorr
    {
        public static bool ValidateEntry(Control control, ErrorProvider err, string message)
        {
            bool IsValidInput = true;
            if (control is PictureBox pictureBox && pictureBox.Image == null)
            {
                IsValidInput = false;
            }
            else if (control is ComboBox comboBox && comboBox.SelectedIndex<0)
                IsValidInput = false;
            else if(control is TextBox textBox && !textBox.Text.isSet())
                IsValidInput = false;
            else if(control is RichTextBox richTextBox&& richTextBox.Text.isSet())
                IsValidInput = false;


            if(!IsValidInput)
            {
                err.SetError(control, message); 
            }
            else
            {
                err.Clear();
            }


            return IsValidInput;

        }
    }
}
