using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SalaryToMail
{
  public partial class Form1 : Form
  {
    ReadExcelFile readExcelFile;
    PackageHtml packageHtml;

    public Form1()
    {
      InitializeComponent();

      readExcelFile = new ReadExcelFile();
      packageHtml = new PackageHtml();

      textBoxFooters.Text = ConfigurationManager.AppSettings["footers"];

    }

    private void buttonOpen_Click(object sender, EventArgs e)
    {
      System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      openFileDialog1.InitialDirectory = "d:\\";
      openFileDialog1.Filter = "Excel files (*.xls)|*.xls;*.xlsx|All files (*.*)|*.*";
      openFileDialog1.FilterIndex = 1;
      openFileDialog1.RestoreDirectory = true;
      if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        ReadExcelBook book = new ReadExcelBook();

        List<string> books_name = new List<string>();
        readExcelFile.OpenConnection(openFileDialog1.FileName,ref books_name);
        book.AddItems(books_name);
        book.SelectBooked += Book_SelectBooked;
        book.ShowDialog();

      }

    }

    private void Book_SelectBooked(string bookName)
    {
      DataSet bookData = new DataSet();
      readExcelFile.ReadBook(bookName, ref bookData);
      dataGridView1.DataSource = bookData.Tables[0];
      packageHtml.SetDataSet(readExcelFile.bookName, ref bookData);

    }

    private void buttonSendEmail_Click(object sender, EventArgs e)
    {
      if (bool.Parse(ConfigurationManager.AppSettings["savepasswordchecked"]))
      {
        SendSMTP.SendEmail(readExcelFile.bookName,ref packageHtml);
      }
      else
      {
        AccountConfig account_config = new AccountConfig();
        account_config.ShowDialog();
      }

    }

    private void buttonSetAccountConfig_Click(object sender, EventArgs e)
    {
      AccountConfig account_config = new AccountConfig();
      account_config.ShowDialog();
    }

    private void buttonSendPreview_Click(object sender, EventArgs e)
    {
      WebPreView wpv = new WebPreView();
      wpv.SetMailHeader(ref packageHtml.employeeData);
      wpv.ShowDialog();
    }

    private void textBoxFooters_TextChanged(object sender, EventArgs e)
    {
      Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      config.AppSettings.Settings["footers"].Value = textBoxFooters.Text;
      config.Save(ConfigurationSaveMode.Modified);
      System.Configuration.ConfigurationManager.RefreshSection("appSettings");
    }
  }
}
