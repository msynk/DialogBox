using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dialog
{
  public class DialogBox
  {
    public static DialogResult ShowGridError(string title, string message, string details)
    {
      var dialogType = typeof(Form).Assembly.GetType("System.Windows.Forms.PropertyGridInternal.GridErrorDlg");
      var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());
      dialog.Text = title;
      dialogType.GetProperty("Message").SetValue(dialog, message, null);
      dialogType.GetProperty("Details").SetValue(dialog, details, null);
      return dialog.ShowDialog();
    }

    //out DialogBoxResult boxResult
    public static DialogResult Show(string message, string title = null, MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxButtons buttons = MessageBoxButtons.OK, string details = null)
    {
      var dialogForm = new DialogForm(message, title, icon, buttons, details);
      return dialogForm.ShowDialog();
    }

    public static DialogResult Show(string message, Dictionary<string, DialogResult> buttons, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1, string title = null, MessageBoxIcon icon = MessageBoxIcon.None, string details = null)
    {
      var dialogForm = new DialogForm(message, title, icon, details: details);
      dialogForm.SetButtons(buttons);
      return dialogForm.ShowDialog();
    }


    public static void ShowWait(string message = "")
    {
      WaitingForm.ShowForm(message);
    }

    public static void CloseWait()
    {
      WaitingForm.CloseForm();
    }
  }
}
