namespace Dialog
{
  partial class DialogForm
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
      this.chkBx = new System.Windows.Forms.CheckBox();
      this.btn1 = new System.Windows.Forms.Button();
      this.btn2 = new System.Windows.Forms.Button();
      this.btn3 = new System.Windows.Forms.Button();
      this.tbMessage = new System.Windows.Forms.TextBox();
      this.btnToggleDetails = new System.Windows.Forms.Button();
      this.tbDetails = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // chkBx
      // 
      this.chkBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chkBx.AutoSize = true;
      this.chkBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.chkBx.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkBx.Location = new System.Drawing.Point(6, 123);
      this.chkBx.Name = "chkBx";
      this.chkBx.Size = new System.Drawing.Size(102, 22);
      this.chkBx.TabIndex = 22;
      this.chkBx.Text = "دیگر نمایش نده";
      this.chkBx.UseVisualStyleBackColor = true;
      this.chkBx.Visible = false;
      // 
      // btn1
      // 
      this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btn1.AutoSize = true;
      this.btn1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn1.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
      this.btn1.Location = new System.Drawing.Point(239, 118);
      this.btn1.Name = "btn1";
      this.btn1.Size = new System.Drawing.Size(76, 35);
      this.btn1.TabIndex = 5;
      this.btn1.Text = "Button1";
      this.btn1.UseVisualStyleBackColor = true;
      this.btn1.Visible = false;
      this.btn1.Click += new System.EventHandler(this.btn_Click);
      // 
      // btn2
      // 
      this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btn2.AutoSize = true;
      this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn2.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
      this.btn2.Location = new System.Drawing.Point(321, 118);
      this.btn2.Name = "btn2";
      this.btn2.Size = new System.Drawing.Size(78, 35);
      this.btn2.TabIndex = 6;
      this.btn2.Text = "Button2";
      this.btn2.UseVisualStyleBackColor = true;
      this.btn2.Visible = false;
      this.btn2.Click += new System.EventHandler(this.btn_Click);
      // 
      // btn3
      // 
      this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btn3.AutoSize = true;
      this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn3.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
      this.btn3.Location = new System.Drawing.Point(405, 118);
      this.btn3.Name = "btn3";
      this.btn3.Size = new System.Drawing.Size(79, 35);
      this.btn3.TabIndex = 7;
      this.btn3.Text = "Button3";
      this.btn3.UseVisualStyleBackColor = true;
      this.btn3.Visible = false;
      this.btn3.Click += new System.EventHandler(this.btn_Click);
      // 
      // tbMessage
      // 
      this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.tbMessage.BackColor = System.Drawing.SystemColors.Control;
      this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbMessage.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
      this.tbMessage.Location = new System.Drawing.Point(57, 12);
      this.tbMessage.Multiline = true;
      this.tbMessage.Name = "tbMessage";
      this.tbMessage.ReadOnly = true;
      this.tbMessage.Size = new System.Drawing.Size(427, 100);
      this.tbMessage.TabIndex = 23;
      this.tbMessage.Text = "[Message]";
      // 
      // btnToggleDetails
      // 
      this.btnToggleDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnToggleDetails.AutoSize = true;
      this.btnToggleDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnToggleDetails.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
      this.btnToggleDetails.Location = new System.Drawing.Point(114, 118);
      this.btnToggleDetails.Name = "btnToggleDetails";
      this.btnToggleDetails.Size = new System.Drawing.Size(75, 35);
      this.btnToggleDetails.TabIndex = 5;
      this.btnToggleDetails.Text = "جزئيات";
      this.btnToggleDetails.UseVisualStyleBackColor = true;
      this.btnToggleDetails.Click += new System.EventHandler(this.btnToggleDetails_Click);
      // 
      // tbDetails
      // 
      this.tbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.tbDetails.BackColor = System.Drawing.SystemColors.Control;
      this.tbDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbDetails.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
      this.tbDetails.Location = new System.Drawing.Point(2, 159);
      this.tbDetails.Multiline = true;
      this.tbDetails.Name = "tbDetails";
      this.tbDetails.ReadOnly = true;
      this.tbDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.tbDetails.Size = new System.Drawing.Size(499, 129);
      this.tbDetails.TabIndex = 23;
      this.tbDetails.Text = "[Details]";
      this.tbDetails.Visible = false;
      // 
      // DialogForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.CancelButton = this.btn1;
      this.ClientSize = new System.Drawing.Size(500, 158);
      this.ControlBox = false;
      this.Controls.Add(this.tbDetails);
      this.Controls.Add(this.tbMessage);
      this.Controls.Add(this.btn3);
      this.Controls.Add(this.chkBx);
      this.Controls.Add(this.btnToggleDetails);
      this.Controls.Add(this.btn1);
      this.Controls.Add(this.btn2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DialogForm";
      this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.RightToLeftLayout = true;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "[Title]";
      this.Load += new System.EventHandler(this.DialogBox_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox chkBx;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.TextBox tbMessage;
    private System.Windows.Forms.Button btnToggleDetails;
    private System.Windows.Forms.TextBox tbDetails;
  }
}