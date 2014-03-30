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
      this.btnShowWait2 = new System.Windows.Forms.Button();
      this.btnCloseWait = new System.Windows.Forms.Button();
      this.btnCloseWait2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnShowMessage
      // 
      this.btnShowMessage.Location = new System.Drawing.Point(12, 12);
      this.btnShowMessage.Name = "btnShowMessage";
      this.btnShowMessage.Size = new System.Drawing.Size(100, 23);
      this.btnShowMessage.TabIndex = 0;
      this.btnShowMessage.Text = "Show Message";
      this.btnShowMessage.UseVisualStyleBackColor = true;
      this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
      // 
      // btnWait
      // 
      this.btnWait.Location = new System.Drawing.Point(12, 41);
      this.btnWait.Name = "btnWait";
      this.btnWait.Size = new System.Drawing.Size(100, 23);
      this.btnWait.TabIndex = 1;
      this.btnWait.Text = "Show Wait";
      this.btnWait.UseVisualStyleBackColor = true;
      this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
      // 
      // btnShowWait2
      // 
      this.btnShowWait2.Location = new System.Drawing.Point(12, 70);
      this.btnShowWait2.Name = "btnShowWait2";
      this.btnShowWait2.Size = new System.Drawing.Size(100, 23);
      this.btnShowWait2.TabIndex = 2;
      this.btnShowWait2.Text = "Show Wait 2";
      this.btnShowWait2.UseVisualStyleBackColor = true;
      this.btnShowWait2.Click += new System.EventHandler(this.btnShowWait2_Click);
      // 
      // btnCloseWait
      // 
      this.btnCloseWait.Location = new System.Drawing.Point(118, 41);
      this.btnCloseWait.Name = "btnCloseWait";
      this.btnCloseWait.Size = new System.Drawing.Size(100, 23);
      this.btnCloseWait.TabIndex = 3;
      this.btnCloseWait.Text = "Close Wait";
      this.btnCloseWait.UseVisualStyleBackColor = true;
      this.btnCloseWait.Click += new System.EventHandler(this.btnCloseWait_Click);
      // 
      // btnCloseWait2
      // 
      this.btnCloseWait2.Location = new System.Drawing.Point(118, 70);
      this.btnCloseWait2.Name = "btnCloseWait2";
      this.btnCloseWait2.Size = new System.Drawing.Size(100, 23);
      this.btnCloseWait2.TabIndex = 4;
      this.btnCloseWait2.Text = "Close Wait 2";
      this.btnCloseWait2.UseVisualStyleBackColor = true;
      this.btnCloseWait2.Click += new System.EventHandler(this.btnCloseWait2_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(492, 473);
      this.Controls.Add(this.btnCloseWait2);
      this.Controls.Add(this.btnCloseWait);
      this.Controls.Add(this.btnShowWait2);
      this.Controls.Add(this.btnWait);
      this.Controls.Add(this.btnShowMessage);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnShowMessage;
    private System.Windows.Forms.Button btnWait;
    private System.Windows.Forms.Button btnShowWait2;
    private System.Windows.Forms.Button btnCloseWait;
    private System.Windows.Forms.Button btnCloseWait2;
  }
}

