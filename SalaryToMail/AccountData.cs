using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryToMail
{
  public class AccountData
  {
    //member variables
    public string StrSMTP;
    public int IPort;
    public string StrUserName;
    public string StrPassword;
    public bool IsSavePassword;

    public AccountData()
    {
      ReadAccountData();
    }

    public void ReadAccountData()
    {
      StrSMTP = ConfigurationManager.AppSettings["smtp"];
      IPort = int.Parse(ConfigurationManager.AppSettings["port"]);
      StrUserName = ConfigurationManager.AppSettings["username"];
      IsSavePassword = bool.Parse(ConfigurationManager.AppSettings["savepasswordchecked"]);

      if (IsSavePassword)
      {
        Encryption dec = new Encryption();
        StrPassword = dec.Decode(ConfigurationManager.AppSettings["password"]);
      }
      else
      {
        StrPassword = "";
      }
    }

    public void WriteAccountData()
    {
      Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

      config.AppSettings.Settings["smtp"].Value = StrSMTP;
      config.AppSettings.Settings["port"].Value = IPort.ToString();
      config.AppSettings.Settings["username"].Value = StrUserName;

      if (IsSavePassword)
      {
        Encryption dec = new Encryption();
        config.AppSettings.Settings["password"].Value = dec.Encode(StrPassword);
        config.AppSettings.Settings["savepasswordchecked"].Value = "true";
      }
      else
      {
        config.AppSettings.Settings["password"].Value = "";
        config.AppSettings.Settings["savepasswordchecked"].Value = "false";
      }

      config.Save(ConfigurationSaveMode.Modified);
      System.Configuration.ConfigurationManager.RefreshSection("appSettings");
    }

  }
}
