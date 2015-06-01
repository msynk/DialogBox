namespace Dialog
{
    partial class ProgressForm
    {
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose (bool disposing)
	{
	    if (disposing && (components != null)) {
		components.Dispose ();
	    }
	    base.Dispose (disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent ()
	{
	    this.progressBar1 = new System.Windows.Forms.ProgressBar();
	    this.SuspendLayout ();
	    // 
	    // progressBar1
	    // 
	    this.progressBar1 = new System.Windows.Forms.ProgressBar(); 
	    this.progressBar1.Location = new System.Drawing.Point (10, 10);
	    this.progressBar1.Size = new System.Drawing.Size (580, 20);

	    // 
	    // WaitingForm2
	    // 
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
	    this.ClientSize = new System.Drawing.Size (600, 200);
	    this.Name = "ProgressForm";
	    this.ShowInTaskbar = false;
	    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
	    this.Text = "ProgressForm";
	    this.FormClosing += this.OnFormClosing_Handler;
	    this.Controls.Add (progressBar1);
	    this.ResumeLayout (false);

	}

	#endregion
	private System.Windows.Forms.ProgressBar progressBar1;

    }
}
