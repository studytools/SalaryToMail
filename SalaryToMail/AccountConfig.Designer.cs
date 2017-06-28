namespace SalaryToMail
{
  partial class AccountConfig
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
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxAccount = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.buttonSaveAccountConfig = new System.Windows.Forms.Button();
      this.checkBoxSavePassword = new System.Windows.Forms.CheckBox();
      this.buttonTestConnect = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxsmpt = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxPort = new System.Windows.Forms.TextBox();
      this.buttonSend = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label1.Location = new System.Drawing.Point(30, 117);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "邮箱:";
      // 
      // textBoxAccount
      // 
      this.textBoxAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxAccount.Location = new System.Drawing.Point(95, 117);
      this.textBoxAccount.MinimumSize = new System.Drawing.Size(250, 20);
      this.textBoxAccount.Name = "textBoxAccount";
      this.textBoxAccount.Size = new System.Drawing.Size(300, 21);
      this.textBoxAccount.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label2.Location = new System.Drawing.Point(30, 158);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "密码:";
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxPassword.Location = new System.Drawing.Point(95, 158);
      this.textBoxPassword.MinimumSize = new System.Drawing.Size(250, 20);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.PasswordChar = '*';
      this.textBoxPassword.Size = new System.Drawing.Size(300, 21);
      this.textBoxPassword.TabIndex = 3;
      this.textBoxPassword.UseSystemPasswordChar = true;
      this.textBoxPassword.WordWrap = false;
      // 
      // buttonSaveAccountConfig
      // 
      this.buttonSaveAccountConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonSaveAccountConfig.Location = new System.Drawing.Point(283, 239);
      this.buttonSaveAccountConfig.MaximumSize = new System.Drawing.Size(80, 20);
      this.buttonSaveAccountConfig.MinimumSize = new System.Drawing.Size(80, 20);
      this.buttonSaveAccountConfig.Name = "buttonSaveAccountConfig";
      this.buttonSaveAccountConfig.Size = new System.Drawing.Size(80, 20);
      this.buttonSaveAccountConfig.TabIndex = 6;
      this.buttonSaveAccountConfig.Text = "保存";
      this.buttonSaveAccountConfig.UseVisualStyleBackColor = true;
      this.buttonSaveAccountConfig.Click += new System.EventHandler(this.buttonSaveAccountConfig_Click);
      // 
      // checkBoxSavePassword
      // 
      this.checkBoxSavePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.checkBoxSavePassword.AutoSize = true;
      this.checkBoxSavePassword.Location = new System.Drawing.Point(95, 199);
      this.checkBoxSavePassword.Name = "checkBoxSavePassword";
      this.checkBoxSavePassword.Size = new System.Drawing.Size(72, 16);
      this.checkBoxSavePassword.TabIndex = 4;
      this.checkBoxSavePassword.Text = "保存密码";
      this.checkBoxSavePassword.UseVisualStyleBackColor = true;
      // 
      // buttonTestConnect
      // 
      this.buttonTestConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonTestConnect.Location = new System.Drawing.Point(188, 239);
      this.buttonTestConnect.MaximumSize = new System.Drawing.Size(80, 20);
      this.buttonTestConnect.MinimumSize = new System.Drawing.Size(80, 20);
      this.buttonTestConnect.Name = "buttonTestConnect";
      this.buttonTestConnect.Size = new System.Drawing.Size(80, 20);
      this.buttonTestConnect.TabIndex = 5;
      this.buttonTestConnect.Text = "测试连接";
      this.buttonTestConnect.UseVisualStyleBackColor = true;
      this.buttonTestConnect.Click += new System.EventHandler(this.buttonTestConnect_Click);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label3.Location = new System.Drawing.Point(30, 35);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(59, 20);
      this.label3.TabIndex = 0;
      this.label3.Text = "smtp:";
      // 
      // textBoxsmpt
      // 
      this.textBoxsmpt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxsmpt.Location = new System.Drawing.Point(95, 35);
      this.textBoxsmpt.MinimumSize = new System.Drawing.Size(250, 20);
      this.textBoxsmpt.Name = "textBoxsmpt";
      this.textBoxsmpt.Size = new System.Drawing.Size(300, 21);
      this.textBoxsmpt.TabIndex = 0;
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.label4.Location = new System.Drawing.Point(30, 76);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(59, 20);
      this.label4.TabIndex = 0;
      this.label4.Text = "端口:";
      // 
      // textBoxPort
      // 
      this.textBoxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxPort.Location = new System.Drawing.Point(95, 76);
      this.textBoxPort.MinimumSize = new System.Drawing.Size(120, 20);
      this.textBoxPort.Name = "textBoxPort";
      this.textBoxPort.Size = new System.Drawing.Size(165, 21);
      this.textBoxPort.TabIndex = 1;
      this.textBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPort_KeyPress);
      // 
      // buttonSend
      // 
      this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonSend.Location = new System.Drawing.Point(369, 239);
      this.buttonSend.MaximumSize = new System.Drawing.Size(80, 20);
      this.buttonSend.MinimumSize = new System.Drawing.Size(80, 20);
      this.buttonSend.Name = "buttonSend";
      this.buttonSend.Size = new System.Drawing.Size(80, 20);
      this.buttonSend.TabIndex = 9;
      this.buttonSend.Text = "发送";
      this.buttonSend.UseVisualStyleBackColor = true;
      this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
      // 
      // AccountConfig
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 287);
      this.Controls.Add(this.buttonSend);
      this.Controls.Add(this.buttonTestConnect);
      this.Controls.Add(this.checkBoxSavePassword);
      this.Controls.Add(this.buttonSaveAccountConfig);
      this.Controls.Add(this.textBoxPassword);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxPort);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBoxsmpt);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxAccount);
      this.Controls.Add(this.label1);
      this.MinimumSize = new System.Drawing.Size(500, 325);
      this.Name = "AccountConfig";
      this.Text = "AccountConfig";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxAccount;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.Button buttonSaveAccountConfig;
    private System.Windows.Forms.CheckBox checkBoxSavePassword;
    private System.Windows.Forms.Button buttonTestConnect;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxsmpt;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxPort;
    private System.Windows.Forms.Button buttonSend;
  }
}