using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;


namespace Lib
{
    internal class clsUtilControls
    {
        /*
         Life Cycle Of Control (Like TextBox) :
        Enter Event
        Leave Event
        Validating Event
        Validated Event
        LostFocus Event
         */
        private static void txtBox_Validating(object txtsender, object errorprovidersender, CancelEventArgs e, bool HasDefaultText)
        {
            if ((string.IsNullOrWhiteSpace(((TextBox)txtsender).Text) || String.IsNullOrEmpty(((TextBox)txtsender).Text)) || HasDefaultText)
            {
                e.Cancel = true;//Block leaving the control till the validation passes
                ((ErrorProvider)errorprovidersender).SetError(((TextBox)txtsender),"text boxs can't be empty");

            }
            else
            {
                e.Cancel = false;//Allow leaving control
                ((ErrorProvider)errorprovidersender).SetError(((TextBox)txtsender), "");
            }
        }

        public delegate void textboxvalidate(object txtsender, object errorprovidersender, CancelEventArgs e , bool HasDefaultText);

        public static textboxvalidate ValidateTextBox = txtBox_Validating;

       

    }
}
