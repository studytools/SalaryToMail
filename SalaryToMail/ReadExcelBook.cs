using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryToMail
{
  public delegate void ActionSelectBook(string bookName);

  public partial class ReadExcelBook : Form
  {
    public event ActionSelectBook SelectBooked;

    public ReadExcelBook()
    {
      InitializeComponent();
    }

    public void AddItems(List<string> books)
    {
      listBoxBooks.BeginUpdate();
      listBoxBooks.DataSource = books;
      listBoxBooks.SelectedIndex = listBoxBooks.Items.Count - 1;
      listBoxBooks.EndUpdate();
    }

    private void onMouseDoubleClick(object sender, MouseEventArgs e)
    {
      SelectBooked(listBoxBooks.Text);
      this.Close();
    }

    private void buttonOpenBook_Click(object sender, EventArgs e)
    {
      SelectBooked(listBoxBooks.Text);
      this.Close();
    }
  }
}
