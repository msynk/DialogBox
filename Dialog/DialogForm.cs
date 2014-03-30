using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dialog
{
  partial class DialogForm : Form
  {
    public string Title { get; private set; }
    public string Message { get; private set; }
    public MessageBoxIcon BoxIcon { get; set; }
    public MessageBoxButtons BoxButtons { get; set; }
    public string Details { get; private set; }

    public Icon DialogIcon { get; private set; }

    #region Members

    private const int MarginY = 10;
    private const int MarginX = 16;
    private const int ButtonSpace = 5;
    private const int CheckboxSpace = 15;
    private const int TextMarginY = 30;

    /// <summary>
    /// Min set width.
    /// </summary>
    private int _minWidth;

    /// <summary>
    /// Min set height.
    /// </summary>
    private int _minHeight;

    /// <summary>
    /// The min required width of the button and checkbox row. Sum of button widths + checkbox width + margins.
    /// </summary>
    private int _minButtonRowWidth;

    #endregion

    #region DialogForm

    /// <summary>
    /// Create a new instance of the dialog box with a message and title and a standard windows messagebox icon.
    /// </summary>
    /// <param name="message">Message text.</param>
    /// <param name="title">Dialog Box title.</param>
    /// <param name="buttons">Dialog Box buttons.</param>
    /// <param name="details">Dialog Box detils.</param>
    /// <param name="icon">Standard system messagebox icon.</param>
    public DialogForm(string message, string title, MessageBoxIcon icon = MessageBoxIcon.None, MessageBoxButtons buttons = MessageBoxButtons.OK, string details = null)
      : this(message, title, GetMessageBoxIcon(icon), buttons, details) { BoxIcon = icon; }

    /// <summary>
    /// Create a new instance of the dialog box with a message and title and a custom windows icon.
    /// </summary>
    /// <param name="message">Message text.</param>
    /// <param name="title">Dialog Box title.</param>
    /// <param name="buttons">Dialog Box buttons.</param>
    /// <param name="details">Dialog Box detils.</param>
    /// <param name="icon">Custom icon.</param>
    public DialogForm(string message, string title, Icon icon, MessageBoxButtons buttons = MessageBoxButtons.OK, string details = null)
    {
      InitializeComponent();

      Message = message;
      Title = title;
      DialogIcon = icon;
      Details = details;
      BoxButtons = buttons;

      if (DialogIcon == null)
      {
        tbMessage.Location = new Point(MarginX, MarginY);
      }

      SetupButtons();
      Icon = icon;
    }

    /// <summary>
    /// Paint the System Icon in the top left corner.
    /// </summary>
    /// <param name="e"></param>
    protected override void OnPaint(PaintEventArgs e)
    {
      if (DialogIcon != null)
      {
        var g = e.Graphics;
        g.DrawIconUnstretched(DialogIcon, new Rectangle(MarginX, MarginY, DialogIcon.Width, DialogIcon.Height));
      }

      base.OnPaint(e);
    }

    private void DialogBox_Load(object sender, EventArgs e)
    {
      if (!btn1.Visible)
      {
        SetButtons(new[] { "تایید" }, new[] { DialogResult.OK });
      }
      _minButtonRowWidth += 2 * MarginX; //add margin to the ends

      //SetDialogSize();
      SetButtonRowLocations();

      //btnToggleDetails.Text = "جزئيات \u2129";// + char.ConvertFromUtf32(8595);

      btnToggleDetails.Visible = !string.IsNullOrEmpty(Details);

      Text = Title;
      tbMessage.Text = Message;
      tbDetails.Text = Details;
    }

    #endregion

    #region Utilities

    private IButtonControl GetButton(int number)
    {
      switch (number)
      {
        case 1:
          return btn1;
        case 2:
          return btn2;
        case 3:
          return btn3;
      }
      return null;
    }

    private void SetupButtons()
    {
      switch (BoxButtons)
      {
        case MessageBoxButtons.OK:
          SetButtons(new[] { "تایید" }, new[] { DialogResult.OK });
          break;
        case MessageBoxButtons.OKCancel:
          SetButtons(new[] { "تایید", "انصراف" }, new[] { DialogResult.OK, DialogResult.Cancel }, 1, 2);
          break;
        case MessageBoxButtons.YesNo:
          SetButtons(new[] { "بله", "خیر" }, new[] { DialogResult.Yes, DialogResult.No }, 1, 2);
          break;
        case MessageBoxButtons.YesNoCancel:
          SetButtons(new[] { "بله", "خیر", "انصراف" }, new[] { DialogResult.Yes, DialogResult.No, DialogResult.Cancel }, 1, 3);
          break;
        case MessageBoxButtons.RetryCancel:
          SetButtons(new[] { "دوباره", "انصراف" }, new[] { DialogResult.Retry, DialogResult.Cancel }, 1, 2);
          break;
        case MessageBoxButtons.AbortRetryIgnore:
          SetButtons(new[] { "توقف", "دوباره", "انصراف" }, new[] { DialogResult.Abort, DialogResult.Retry, DialogResult.Cancel }, 1, 3);
          break;
      }
    }

    /// <summary>
    /// Get system icon for MessageBoxIcon.
    /// </summary>
    /// <param name="icon">The MessageBoxIcon value.</param>
    /// <returns>SystemIcon type Icon.</returns>
    private static Icon GetMessageBoxIcon(MessageBoxIcon icon)
    {
      switch (icon)
      {
        case MessageBoxIcon.Asterisk:
          return SystemIcons.Asterisk;
        case MessageBoxIcon.Error:
          return SystemIcons.Error;
        case MessageBoxIcon.Exclamation:
          return SystemIcons.Exclamation;
        case MessageBoxIcon.Question:
          return SystemIcons.Question;
        default:
          return null;
      }
    }

    /// <summary>
    /// Sets button text and returns the width.
    /// </summary>
    /// <param name="btn">Button object.</param>
    /// <param name="text">Text of the button.</param>
    /// <param name="tab">TabIndex of the button.</param>
    /// <param name="dr">DialogResult of the button.</param>
    /// <returns>Width of the button.</returns>
    private static int SetButtonParams(Button btn, string text, int tab, DialogResult dr)
    {
      btn.Text = text;
      btn.Visible = true;
      btn.DialogResult = dr;
      btn.TabIndex = tab;

      return btn.Size.Width;
    }

    /// <summary>
    /// Auto fits the dialog box to fit the text and the buttons.
    /// </summary>
    private void SetDialogSize()
    {
      var requiredWidth = tbMessage.Location.X + tbMessage.Size.Width + MarginX;
      requiredWidth = requiredWidth > _minButtonRowWidth ? requiredWidth : _minButtonRowWidth;
      var requiredHeight = tbMessage.Location.Y + tbMessage.Size.Height - btn2.Location.Y + ClientSize.Height + TextMarginY;

      var minSetWidth = ClientSize.Width > _minWidth ? ClientSize.Width : _minWidth;
      var minSetHeight = ClientSize.Height > _minHeight ? ClientSize.Height : _minHeight;

      var s = new Size
      {
        Width = requiredWidth > minSetWidth ? requiredWidth : minSetWidth,
        Height = requiredHeight > minSetHeight ? requiredHeight : minSetHeight
      };
      ClientSize = s;
    }

    /// <summary>
    /// Sets the buttons and checkboxe location.
    /// </summary>
    private void SetButtonRowLocations()
    {
      int formWidth = ClientRectangle.Width;

      int x = formWidth - MarginX;
      int y = btn1.Location.Y;

      if (btn3.Visible)
      {
        x -= btn3.Size.Width;
        btn3.Location = new Point(x, y);
        x -= ButtonSpace;
      }

      if (btn2.Visible)
      {
        x -= btn2.Size.Width;
        btn2.Location = new Point(x, y);
        x -= ButtonSpace;
      }

      x -= btn1.Size.Width;
      btn1.Location = new Point(x, y);

      if (chkBx.Visible)
        chkBx.Location = new Point(MarginX, chkBx.Location.Y);

    }

    #endregion

    #region Setup API

    /// <summary>
    /// Sets the min size of the dialog box. If the text or button row needs more size then the dialog box will size to fit the text.
    /// </summary>
    /// <param name="width">Min width value.</param>
    /// <param name="height">Min height value.</param>
    public void SetMinSize(int width, int height)
    {
      _minWidth = width;
      _minHeight = height;
    }

    /// <summary>
    /// Create up to 3 buttons with no DialogResult values.
    /// </summary>
    /// <param name="names">Array of button names. Must of length 1-3.</param>
    public void SetButtons(params string[] names)
    {
      var drs = new DialogResult[names.Length];
      for (var i = 0; i < names.Length; i++)
      {
        drs[i] = DialogResult.None;
      }
      SetButtons(names, drs);
    }

    /// <summary>
    /// Create up to 3 buttons with given DialogResult values.
    /// </summary>
    /// <param name="names">Array of button names. Must of length 1-3.</param>
    /// <param name="results">Array of DialogResult values. Must be same length as names.</param>
    /// <param name="acceptNumber">Accept Button number. Must be 1-3.</param>
    /// <param name="cancelNumber">Cancel Button number. Must be 1-3.</param>
    public void SetButtons(string[] names, DialogResult[] results, int acceptNumber = 1, int cancelNumber = -1)
    {
      if (names == null) throw new ArgumentNullException("btnText", "Button Text is null");
      var count = names.Length;
      if (count < 1 || count > 3) throw new ArgumentException("Invalid number of buttons. Must be between 1 and 3.");

      //---- Set Button 1
      _minButtonRowWidth += SetButtonParams(btn1, names[0], acceptNumber == 1 ? 1 : 2, results[0]);
      if (cancelNumber == -1) cancelNumber = 1;
      //---- Set Button 2
      if (count > 1)
      {
        _minButtonRowWidth += SetButtonParams(btn2, names[1], acceptNumber == 2 ? 1 : 3, results[1]) + ButtonSpace;
        if (cancelNumber == -1) cancelNumber = 2;
      }

      //---- Set Button 3
      if (count > 2)
      {
        _minButtonRowWidth += SetButtonParams(btn3, names[2], acceptNumber == 3 ? 1 : 4, results[2]) + ButtonSpace;
        if (cancelNumber == -1) cancelNumber = 3;
      }

      AcceptButton = GetButton(acceptNumber);
      CancelButton = GetButton(cancelNumber);

    }

    public void SetButtons(Dictionary<string, DialogResult> buttons, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
    {
      var count = buttons.Count;
      var names = new string[count];
      var drs = new DialogResult[count];
      var i = 0;
      foreach (var button in buttons)
      {
        names[i] = button.Key;
        drs[i] = button.Value;
        i++;
      }
      var def = 0;
      switch (defaultButton)
      {
        case MessageBoxDefaultButton.Button1:
          def = 1;
          break;
        case MessageBoxDefaultButton.Button2:
          def = 2;
          break;
        case MessageBoxDefaultButton.Button3:
          def = 3;
          break;
      }
      SetButtons(names, drs, def);
    }

    /// <summary>
    /// Enables the checkbox. By default the checkbox is unchecked.
    /// </summary>
    /// <param name="text">Text of the checkbox.</param>
    public void SetCheckbox(string text)
    {
      SetCheckbox(text, false);
    }

    /// <summary>
    /// Enables the checkbox and the default checked state.
    /// </summary>
    /// <param name="text">Text of the checkbox.</param>
    /// <param name="chcked">Default checked state of the box.</param>
    public void SetCheckbox(string text, bool chcked)
    {
      chkBx.Visible = true;
      chkBx.Text = text;
      chkBx.Checked = chcked;
      _minButtonRowWidth += chkBx.Size.Width + CheckboxSpace;
    }

    #endregion

    #region Result API

    /// <summary>
    /// If visible checkbox was checked.
    /// </summary>
    public bool CheckboxChecked { get { return chkBx.Checked; } }

    /// <summary>
    /// Gets the button that was pressed.
    /// </summary>
    public DialogBoxResult DialogBoxResult { get; private set; }

    private void btn_Click(object sender, EventArgs e)
    {
      if (sender == btn1)
      {
        DialogBoxResult = DialogBoxResult.Button1;
      }
      else if (sender == btn2)
      {
        DialogBoxResult = DialogBoxResult.Button2;
      }
      else if (sender == btn3)
      {
        DialogBoxResult = DialogBoxResult.Button3;
      }

      if (((Button)sender).DialogResult == DialogResult.None)
      {
        Close();
      }
    }

    #endregion

    private void btnToggleDetails_Click(object sender, EventArgs e)
    {
      tbDetails.Visible = !tbDetails.Visible;
      var height = tbDetails.Visible ? 290 : 158;
      ClientSize = new Size(500, height);
    }
  }
}
