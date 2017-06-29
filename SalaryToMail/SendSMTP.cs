using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using AegisImplicitMail;
using System.Configuration;

namespace SalaryToMail
{
  public class SendSMTP
  {
    public static void SendEmail(
      string bookName, string strFooters,ref PackageHtml data, ref AccountData ac)
    {
      if(string.IsNullOrEmpty(bookName) || data.employeeData.Count == 0)
      {
        System.Windows.Forms.MessageBox.Show("没有数据可以发送!");
        return;
      }

      //Create Smtp Client
      var mailer = new MimeMailer(ac.StrSMTP, ac.IPort);
      mailer.User = ac.StrUserName;
      mailer.Password = ac.StrPassword;
      mailer.SslType = SslMode.Ssl;
      mailer.AuthenticationMode = AuthenticationType.Base64;

      string footersstr = System.Text.RegularExpressions.Regex.Replace(strFooters, "[\r\n]", "<br>");
      foreach (PackageHtml.Employee str in data.employeeData)
      {
        //Generate Message
        var mailMessage = new MimeMailMessage();
        mailMessage.From = new MimeMailAddress(ac.StrUserName);
        mailMessage.To.Add(str.email);
        mailMessage.SubjectEncoding = Encoding.BigEndianUnicode;
        mailMessage.Subject = bookName;
        mailMessage.Body = str.data+footersstr;
        mailer.SendCompleted += AsynCompleteEvent;
        mailer.SendMail(mailMessage);
      }

    }


    //Call back function
    private static void AsynCompleteEvent(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
    {
      if (!String.IsNullOrEmpty(e.UserState.ToString()))
        Console.Out.WriteLine(e.UserState.ToString());
      Console.Out.WriteLine("is it canceled? " + e.Cancelled);

      if (e.Error != null)
        Console.Out.WriteLine("Error : " + e.Error.Message);
    }

  }
}
