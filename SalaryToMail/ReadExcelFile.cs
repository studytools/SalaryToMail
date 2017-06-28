using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SalaryToMail
{
  public class ReadExcelFile
  {
    private string connectionString;
    public string bookName { get; set; }


    public void OpenConnection(string filePath, ref List<string> books)
    {
      connectionString = "Provider=Microsoft.ACE.OLEDB.16.0; Data Source = " +
        filePath + ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1';";

      using (OleDbConnection connection = new OleDbConnection(connectionString))
      {
        try
        {
          connection.Open();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
          return;
        }

        DataTable sheetsTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
          new object[] { null, null, null, "Table" }); //得到所有sheet的名字

        foreach (DataRow row in sheetsTable.Rows)
        {
          books.Add(row["TABLE_NAME"].ToString());
        }
      }
    }

    public void ReadBook(string book,ref DataSet data)
    {
      bookName = System.Text.RegularExpressions.Regex.Replace(book, "[$']", "");
      string sql = string.Format("SELECT * FROM [{0}]", book); //查询字符串
      OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connectionString);
      adapter.Fill(data);
    }

  }//public class ReadExcelFile
}//namespace WindowsFormsApp1
