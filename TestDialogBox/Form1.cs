using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using Dialog;

namespace TestDialogBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
	    SetupButtonsPositions ();
    }
	private void SetupButtonsPositions()
	{
	    var buttons = new List<Button>();
	    int totalwidth = 0;
	    int totalheight = 0;
	    foreach (var ctl in this.Controls)
	    {
		if (ctl is Button)
		{
		    var b = (Button)ctl;
		    buttons.Add(b);
		    totalwidth += b.Size.Width;
		    totalheight += b.Size.Height;
		}
	    }
	    int count = buttons.Count;
	    var spacingx = (this.ClientSize.Width - totalwidth) / (count + 2);
	    var spacingy = (this.ClientSize.Height - totalheight) / (count + 2);
	    int runningWidth = 0;
	    int runningHeight = 0;
	    for (int pos = 0; pos < buttons.Count; ++pos)
	    {
		int posx = spacingx /*+ runningWidth + pos * spacingx*/;
		int posy = spacingy + runningHeight + pos * spacingy;
		buttons[pos].Location = new System.Drawing.Point(posx, posy);
		runningWidth += buttons[pos].Size.Width;
		runningHeight += buttons[pos].Size.Height;
	    }
	}
	private void OnSizeChanged_Handler(object sender, EventArgs e)
	{
	    SetupButtonsPositions ();
	}
	private void btnShowProgressForm_Click(object sender, EventArgs e)
	{
	    var result = ProgressForm.CreateAndShowForm();
	    if (result == DialogBoxResult.Button1) {
		Trace.WriteLine ("Процесс был успешно выполнен");
	    } else {
		Trace.WriteLine ("Процесс был принудительно завершен");
	    }
	}
	private void btnShowProgressFormModal_Click(object sender, EventArgs e)
	{
	    // Start the BackgroundWorker.
	    var result = ProgressForm.CreateAndShowForm();
	    if (result == DialogBoxResult.Button1) {
		Trace.WriteLine ("Процесс был успешно выполнен");
	    } else {
		Trace.WriteLine ("Процесс был принудительно завершен");
	    }
	}



    private void btnShowMessage_Click(object sender, EventArgs e)
    {
      /*var result =*/ DialogBox.Show("این یک خطاست. جان اصغر!", "هشدار خطا", MessageBoxIcon.Asterisk, MessageBoxButtons.AbortRetryIgnore, "اینها همگی جزئیات خطا هستند.");
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
