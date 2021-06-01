using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverHost
{
    public partial class ListOfTables : Form
    {
        public ListOfTables()
        {
            InitializeComponent();
        }

        private void ListOfTables_Load(object sender, EventArgs e)
        {
            foreach (Table myTable in Form1.Tables)
                label1.Text += "Number " + myTable.number + ", seats " + myTable.seats + ", leftnumber " + myTable.leftNumber + ", rightnumber" + myTable.rightNumber + ", childroom" + myTable.childRoom + ", loniless" + myTable.loneliness + ", waiter" + myTable.waiter + "\n";
        }
    }
}
