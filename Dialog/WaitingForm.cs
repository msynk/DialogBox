using System.Threading;
using System.Windows.Forms;

namespace Dialog
{
  partial class WaitingForm : Form
  {
    protected static WaitingForm CurrentInstance;
    protected bool IsClosing;

    public WaitingForm()
    {
      InitializeComponent();
      waitingTimer.Interval = 50;
      waitingTimer.Start();
    }

    private void waitingTimer_Tick(object sender, System.EventArgs e)
    {
      if (!IsClosing) return;

      Close();
    }

    public static void ShowForm(string message = "")
    {
      var t = new Thread(() =>
      {
        CurrentInstance = new WaitingForm();
        if (!string.IsNullOrEmpty(message))
        {
          CurrentInstance.lblMessage.Text = message;
        }
        Application.Run(CurrentInstance);
      });
      t.IsBackground = true;
      t.SetApartmentState(ApartmentState.STA);
      t.Start();
    }

    public static void CloseForm()
    {
      CurrentInstance.IsClosing = true;
    }
  }
}
