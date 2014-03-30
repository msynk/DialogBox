namespace TestDialogBox
{
  partial class Form1
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
      this.btnShowMessage = new System.Windows.Forms.Button();
      this.btnWait = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnShowMessage
      // 
      this.btnShowMessage.Location = new System.Drawing.Point(101, 81);
      this.btnShowMessage.Name = "btnShowMessage";
      this.btnShowMessage.Size = new System.Drawing.Size(100, 23);
      this.btnShowMessage.TabIndex = 0;
      this.btnShowMessage.Text = "Show Message";
      this.btnShowMessage.UseVisualStyleBackColor = true;
      this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
      // 
      // btnWait
      // 
      this.btnWait.Location = new System.Drawing.Point(101, 120);
      this.btnWait.Name = "btnWait";
      this.btnWait.Size = new System.Drawing.Size(100, 23);
      this.btnWait.TabIndex = 1;
      this.btnWait.Text = "Show Wait";
      this.btnWait.UseVisualStyleBackColor = true;
      this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(288, 266);
      this.Controls.Add(this.btnWait);
      this.Controls.Add(this.btnShowMessage);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnShowMessage;
    private System.Windows.Forms.Button btnWait;
  }
}

