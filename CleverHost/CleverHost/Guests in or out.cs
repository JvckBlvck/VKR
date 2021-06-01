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
    public partial class Gusts_in_or_out : Form
    {
        public Gusts_in_or_out()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGuest newForm = new AddGuest();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuestOut2 newForm = new GuestOut2();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListOfTables newForm = new ListOfTables();
            newForm.Show();
        }
    }
}
