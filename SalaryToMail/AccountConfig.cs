using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using AegisImplicitMail;
using System.Net.Mail;
using System.Net;

namespace SalaryToMail
{
  public delegate void SendEmailNow();

  public partial class AccountConfig : Form
  {
    AccountData accountData;
    public event SendEmailNow SendEmailNowHeahEvent;

    public AccountConfig(ref AccountData ac)
    {
      InitializeComponent();

      accountData = ac;

      textBoxsmpt.Text = accountData.StrSMTP;
      textBoxPort.Text = accountData.IPort.ToString();
      textBoxAccount.Text = accountData.StrUserName;

      if (accountData.IsSavePassword)
      {
        textBoxPassword.Text = accountData.StrPassword;
        checkBoxSavePassword.Checked = true;
      }
      else
      {
        textBoxPassword.Text = "";
        checkBoxSavePassword.Checked = false;
      }

    }

    private void buttonTestConnect_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxPassword.Text))
        {
          MessageBox.Show("密码不能为空!");
          return;
        }
       
       var message = new MimeMailMessage();
       message.From = new MimeMailAddress(textBoxAccount.Text);
       message.To.Add(textBoxAccount.Text);
       
       message.Subject = "测试邮件";
       message.SubjectEncoding = Encoding.UTF8;
       message.Body = @"这是在测试你的帐户设置时 Send SMTP 自动发送的电子邮件。";
       
       int.TryParse(textBoxPort.Text, out int port);
       var mailer = new MimeMailer(textBoxsmpt.Text, port);
       mailer.User = textBoxAccount.Text;
       mailer.Password = textBoxPassword.Text;
       mailer.SslType = SslMode.Ssl;
       mailer.AuthenticationMode = AuthenticationType.Base64;
       
       mailer.SendCompleted += AsyncaccountConfigEvent;
       mailer.SendMailAsync(message);

    }

    public void AsyncaccountConfigEvent(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
    {
      if (!String.IsNullOrEmpty(e.UserState.ToString()))
        MessageBox.Show(e.UserState.ToString());
      Console.Out.WriteLine("is it canceled? " + e.Cancelled);

      if (e.Error != null)
        Console.Out.WriteLine("Error : " + e.Error.Message);
    }

    private void textBoxPort_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    private void buttonSaveAccountConfig_Click(object sender, EventArgs e)
    {
      if (checkBoxSavePassword.Checked && string.IsNullOrEmpty(textBoxPassword.Text))
      {
        MessageBox.Show("密码不能为空!");
        return;
      }

      accountData.StrSMTP = textBoxsmpt.Text;
      accountData.IPort = int.Parse(textBoxPort.Text);
      accountData.StrUserName = textBoxAccount.Text;
      accountData.StrPassword = textBoxPassword.Text;
      accountData.IsSavePassword = checkBoxSavePassword.Checked;

      accountData.WriteAccountData();
    }

    private void buttonSend_Click(object sender, EventArgs e)
    {
      if (SendEmailNowHeahEvent != null) SendEmailNowHeahEvent();
    }
  }//public partial class AccountConfig : Form
}//namespace WindowsFormsApp1
