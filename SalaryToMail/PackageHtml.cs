using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryToMail
{
  public class PackageHtml
  {
    public struct Employee
    {
      public string data;
      public string email;
    }

    public List<Employee> employeeData;

    public PackageHtml()
    {
      employeeData = new List<Employee>();
    }

    public void SetDataSet(string book_name,ref DataSet data)
    {

      employeeData.Clear();
      Employee emp = new Employee();

      string tableHeader = "";
      string tableRow = "";

      //格式化表头
      for(int i = 0; i < data.Tables[0].Columns.Count -1; i++)
      {
        tableHeader += "<td>" + data.Tables[0].Columns[i].ToString() + "</td>";
      }

      foreach (DataRow row in data.Tables[0].Rows)
      {

        tableRow = "";
        for(int i = 0; i < row.ItemArray.Length-1; i++)
        {
          tableRow += "<td>" + row.ItemArray.GetValue(i).ToString() + "</td>";
        }

        emp.email = row.ItemArray.GetValue(row.ItemArray.Length - 1).ToString();

        emp.data = string.Format(@"<table style='width: 100 %;' 
          cellpadding='1' cellspacing='0' border='1' bordercolor='#000000'>
          <tbody><caption><h1>{0}</h1></caption>
          <tr>{1}</tr><tr>{2}</tr></tbody></table><br>",
          book_name, tableHeader, tableRow);

        employeeData.Add(emp);
      }
    }


  }//public class PackageHtml
}
