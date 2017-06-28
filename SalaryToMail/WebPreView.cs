using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SalaryToMail
{
  public partial class WebPreView : Form
  {

    public WebPreView()
    {
      InitializeComponent();
    }

    private string mailHeader { get; set; }

    public void SetMailHeader(ref List<PackageHtml.Employee> lstr)
    {
      string footersstr = System.Text.RegularExpressions.Regex.Replace(ConfigurationManager.AppSettings["footers"], "[\r\n]", "<br>");

      string prestr = "";
      foreach (PackageHtml.Employee str in lstr)
      {
        prestr += "<hr style='text - align:left; background - color:#FF5151;height:9px' />";
        prestr += "<br> Email: " + str.email  +  "所发内容如下:";
        prestr += "<hr style='text - align:left; background - color:#66B3FF;height:3px' />";
        prestr += str.data;
        prestr += footersstr;
        prestr += "<hr style='text - align:left; background - color:#FF5151;height:9px' />";
      }

      webBrowser1.DocumentText = prestr;
    }
  }
}
