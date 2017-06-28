namespace SalaryToMail
{
  partial class ReadExcelBook
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
      this.listBoxBooks = new System.Windows.Forms.ListBox();
      this.buttonOpenBook = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // listBoxBooks
      // 
      this.listBoxBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listBoxBooks.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.listBoxBooks.FormattingEnabled = true;
      this.listBoxBooks.ItemHeight = 24;
      this.listBoxBooks.Location = new System.Drawing.Point(12, 12);
      this.listBoxBooks.Name = "listBoxBooks";
      this.listBoxBooks.Size = new System.Drawing.Size(290, 412);
      this.listBoxBooks.TabIndex = 0;
      this.listBoxBooks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.onMouseDoubleClick);
      // 
      // buttonOpenBook
      // 
      this.buttonOpenBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOpenBook.Location = new System.Drawing.Point(163, 437);
      this.buttonOpenBook.Name = "buttonOpenBook";
      this.buttonOpenBook.Size = new System.Drawing.Size(139, 33);
      this.buttonOpenBook.TabIndex = 1;
      this.buttonOpenBook.Text = "打开";
      this.buttonOpenBook.UseVisualStyleBackColor = true;
      this.buttonOpenBook.Click += new System.EventHandler(this.buttonOpenBook_Click);
      // 
      // ReadExcelBook
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(318, 482);
      this.Controls.Add(this.listBoxBooks);
      this.Controls.Add(this.buttonOpenBook);
      this.Name = "ReadExcelBook";
      this.Text = "ReadExcelBook";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox listBoxBooks;
    private System.Windows.Forms.Button buttonOpenBook;
  }
}