using System;
using System.Windows.Forms;
using Dialog;

namespace TestDialogBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnShowMessage_Click(object sender, EventArgs e)
    {
      var result = DialogBox.Show("این یک خطاست. جان اصغر!", "هشدار خطا", MessageBoxIcon.Asterisk, MessageBoxButtons.AbortRetryIgnore, "اینها همگی جزئیات خطا هستند.");
    }

    private void btnWait_Click(object sender, EventArgs e)
    {
      DialogBox.ShowWait("بابا جان صبر کن دیگه ...");

    }

    private void btnShowWait2_Click(object sender, EventArgs e)
    {
      DialogBox.ShowWait2(closeOnClick: true);
    }

    private void btnCloseWait_Click(object sender, EventArgs e)
    {
      DialogBox.CloseWait();
    }

    private void btnCloseWait2_Click(object sender, EventArgs e)
    {
      DialogBox.CloseWait2();
    }
  }
}
