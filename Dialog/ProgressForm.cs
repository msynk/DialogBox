using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace Dialog
{
    public partial class ProgressForm : Form
    {
	public static DialogBoxResult CreateAndShowForm()
	{
	    var form = new ProgressForm ();
	    form.ShowDialog();
	    if (form.DialogResult == DialogResult.OK) {
		return DialogBoxResult.Button1;
	    } else {
		return DialogBoxResult.Button2;
	    }
	}

	public ProgressForm ()
	{
	    InitializeComponent ();
	    backgroundWorker1 = new BackgroundWorker();
	    backgroundWorker1.DoWork += this.backgroundWorker1_DoWork;
	    backgroundWorker1.WorkerReportsProgress = true;
	    backgroundWorker1.WorkerSupportsCancellation = true;
	    backgroundWorker1.ProgressChanged += this.backgroundWorker1_OnProgressChanged;
	    backgroundWorker1.RunWorkerCompleted += this.backgroundWorker1_OnRunWorkerCompleted;
	    backgroundWorker1.RunWorkerAsync();
	}

	private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
	    BackgroundWorker worker = sender as BackgroundWorker;

	    for (int i = 1; i <= 50; i++)
	    {
		if (worker.CancellationPending == true)
		{
		    e.Cancel = true;
		    Trace.WriteLine ("Нить остановлена");
		    break;
		}
		else
		{
		    // Perform a time consuming operation and report progress.
		    System.Threading.Thread.Sleep(500);
		    worker.ReportProgress(i * 200);
		}
	    }
	    Trace.WriteLine ("Нить отработала");
	}

	void backgroundWorker1_OnProgressChanged(object sender, ProgressChangedEventArgs e)
	{
	    this.progressBar1.Value = e.ProgressPercentage/100;
	}

	void backgroundWorker1_OnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
	    this.Close ();
	}

	private void OnFormClosing_Handler(object sender, System.Windows.Forms.FormClosingEventArgs e)
	{
	    backgroundWorker1.CancelAsync();
	}

	private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
