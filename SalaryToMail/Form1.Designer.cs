namespace SalaryToMail
{
  partial class Form1
  {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.buttonOpen = new System.Windows.Forms.Button();
      this.buttonSendEmail = new System.Windows.Forms.Button();
      this.buttonSetAccountConfig = new System.Windows.Forms.Button();
      this.buttonSendPreview = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxFooters = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonOpen
      // 
      this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOpen.Location = new System.Drawing.Point(294, 14);
      this.buttonOpen.MaximumSize = new System.Drawing.Size(110, 30);
      this.buttonOpen.MinimumSize = new System.Drawing.Size(110, 30);
      this.buttonOpen.Name = "buttonOpen";
      this.buttonOpen.Size = new System.Drawing.Size(110, 30);
      this.buttonOpen.TabIndex = 0;
      this.buttonOpen.Text = "打开Excel文件";
      this.buttonOpen.UseVisualStyleBackColor = true;
      this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
      // 
      // buttonSendEmail
      // 
      this.buttonSendEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonSendEmail.Location = new System.Drawing.Point(526, 13);
      this.buttonSendEmail.MaximumSize = new System.Drawing.Size(110, 30);
      this.buttonSendEmail.MinimumSize = new System.Drawing.Size(110, 30);
      this.buttonSendEmail.Name = "buttonSendEmail";
      this.buttonSendEmail.Size = new System.Drawing.Size(110, 30);
      this.buttonSendEmail.TabIndex = 1;
      this.buttonSendEmail.Text = "发送";
      this.buttonSendEmail.UseVisualStyleBackColor = true;
      this.buttonSendEmail.Click += new System.EventHandler(this.buttonSendEmail_Click);
      // 
      // buttonSetAccountConfig
      // 
      this.buttonSetAccountConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonSetAccountConfig.Location = new System.Drawing.Point(178, 13);
      this.buttonSetAccountConfig.MaximumSize = new System.Drawing.Size(110, 30);
      this.buttonSetAccountConfig.MinimumSize = new System.Drawing.Size(110, 30);
      this.buttonSetAccountConfig.Name = "buttonSetAccountConfig";
      this.buttonSetAccountConfig.Size = new System.Drawing.Size(110, 30);
      this.buttonSetAccountConfig.TabIndex = 2;
      this.buttonSetAccountConfig.Text = "设置";
      this.buttonSetAccountConfig.UseVisualStyleBackColor = true;
      this.buttonSetAccountConfig.Click += new System.EventHandler(this.buttonSetAccountConfig_Click);
      // 
      // buttonSendPreview
      // 
      this.buttonSendPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonSendPreview.Location = new System.Drawing.Point(410, 14);
      this.buttonSendPreview.MaximumSize = new System.Drawing.Size(110, 30);
      this.buttonSendPreview.MinimumSize = new System.Drawing.Size(110, 30);
      this.buttonSendPreview.Name = "buttonSendPreview";
      this.buttonSendPreview.Size = new System.Drawing.Size(110, 30);
      this.buttonSendPreview.TabIndex = 4;
      this.buttonSendPreview.Text = "预览...";
      this.buttonSendPreview.UseVisualStyleBackColor = true;
      this.buttonSendPreview.Click += new System.EventHandler(this.buttonSendPreview_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToResizeRows = false;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 13F);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(13, 13);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
      dataGridViewCellStyle2.NullValue = "0";
      this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.RowTemplate.ReadOnly = true;
      this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.Size = new System.Drawing.Size(559, 267);
      this.dataGridView1.TabIndex = 5;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.buttonSendEmail);
      this.groupBox1.Controls.Add(this.buttonOpen);
      this.groupBox1.Controls.Add(this.buttonSendPreview);
      this.groupBox1.Controls.Add(this.buttonSetAccountConfig);
      this.groupBox1.Location = new System.Drawing.Point(-72, 336);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(644, 50);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 286);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 12);
      this.label1.TabIndex = 7;
      this.label1.Text = "附加信息:";
      // 
      // textBoxFooters
      // 
      this.textBoxFooters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxFooters.Location = new System.Drawing.Point(81, 286);
      this.textBoxFooters.Multiline = true;
      this.textBoxFooters.Name = "textBoxFooters";
      this.textBoxFooters.Size = new System.Drawing.Size(253, 44);
      this.textBoxFooters.TabIndex = 8;
      this.textBoxFooters.TextChanged += new System.EventHandler(this.textBoxFooters_TextChanged);
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.Location = new System.Drawing.Point(12, 395);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(560, 144);
      this.textBox1.TabIndex = 9;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 551);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.textBoxFooters);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.dataGridView1);
      this.MinimumSize = new System.Drawing.Size(600, 450);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonOpen;
    private System.Windows.Forms.Button buttonSendEmail;
    private System.Windows.Forms.Button buttonSetAccountConfig;
    private System.Windows.Forms.Button buttonSendPreview;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxFooters;
    private System.Windows.Forms.TextBox textBox1;
  }
}

