using System.Threading;
using System.Windows.Forms;

namespace Dialog
{
  public partial class WaitingForm2 : Form
  {
    public static WaitingForm2 Instance { get; private set; }
    public static SynchronizationContext SyncContext { get; set; }


    private readonly bool _closeOnClick;
    public WaitingForm2(string message, bool closeOnClick)
    {
      _closeOnClick = closeOnClick;
      InitializeComponent();
      if (!string.IsNullOrEmpty(message))
      {
        lblMessage.Text = message;
      }
    }

    public static void ShowForm(string message, bool closeOnClick)
    {
      if (Instance != null) return;

      if (SyncContext == null)
      {
        SyncContext = SynchronizationContext.Current;
      }
      SyncContext.Send(s => Instance = new WaitingForm2(message, closeOnClick), null);
      SyncContext.Post(state => Instance.ShowDialog(), null);
    }

    public static void CloseForm()
    {
      if (Instance == null) return;

      Instance.Close();
      Instance = null;
    }

    private void WaitingForm2_Click(object sender, System.EventArgs e)
    {
      if (_closeOnClick)
      {
        Close();
      }
    }

    private void lblMessage_Click(object sender, System.EventArgs e)
    {
      if (_closeOnClick)
      {
        Close();
      }
    }

  }
}
