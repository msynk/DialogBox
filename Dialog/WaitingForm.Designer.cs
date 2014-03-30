namespace Dialog
{
  partial class WaitingForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.waitingTimer = new System.Windows.Forms.Timer(this.components);
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblMessage = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // UpdateTimer
      // 
      this.waitingTimer.Tick += new System.EventHandler(this.waitingTimer_Tick);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lblMessage);
      this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBox1.Location = new System.Drawing.Point(0, -5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(300, 205);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      // 
      // lblMessage
      // 
      this.lblMessage.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
      this.lblMessage.Location = new System.Drawing.Point(6, 10);
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new System.Drawing.Size(288, 189);
      this.lblMessage.TabIndex = 1;
      this.lblMessage.Text = "لطفا صبر کنید ...";
      this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // WaitingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(300, 200);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "WaitingForm";
      this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.RightToLeftLayout = true;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "WaitingForm";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer waitingTimer;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lblMessage;
  }
}