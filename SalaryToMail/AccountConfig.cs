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
  public partial class AccountConfig : Form
  {
    public AccountConfig()
    {
      InitializeComponent();


      textBoxsmpt.Text = ConfigurationManager.AppSettings["smtp"];
      textBoxPort.Text = ConfigurationManager.AppSettings["port"];
      textBoxAccount.Text = ConfigurationManager.AppSettings["username"];

      if (bool.Parse(ConfigurationManager.AppSettings["savepasswordchecked"]))
      {
        Encryption dec = new Encryption();
        textBoxPassword.Text = dec.Decode(ConfigurationManager.AppSettings["password"]);
        checkBoxSavePassword.Checked = true;
      }
      else
      {
        textBoxPassword.Text = "";
        checkBoxSavePassword.Checked = false;
      }

    }

    private bool PasswordIsEmpty()
    {
      return string.IsNullOrEmpty(textBoxPassword.Text);
    }

    private void buttonTestConnect_Click(object sender, EventArgs e)
    {
        if (PasswordIsEmpty())
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
      if (checkBoxSavePassword.Checked && PasswordIsEmpty())
      {
        MessageBox.Show("密码不能为空!");
        return;
      }

      Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      if (checkBoxSavePassword.Checked)
      {
        Encryption dec = new Encryption();
        config.AppSettings.Settings["password"].Value = dec.Encode(textBoxPassword.Text);
        config.AppSettings.Settings["savepasswordchecked"].Value = "true";
      }
      else
      {
        config.AppSettings.Settings["password"].Value = "";
        config.AppSettings.Settings["savepasswordchecked"].Value = "false";
      }

      config.AppSettings.Settings["smtp"].Value = textBoxsmpt.Text;
      config.AppSettings.Settings["port"].Value = textBoxPort.Text;
      config.AppSettings.Settings["username"].Value = textBoxAccount.Text;

      config.Save(ConfigurationSaveMode.Modified);
      System.Configuration.ConfigurationManager.RefreshSection("appSettings");
    }

  }//public partial class AccountConfig : Form
}//namespace WindowsFormsApp1
