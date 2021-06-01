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
    public partial class WaitersSelect : Form
    {
        public WaitersSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Waiters.Add(new Waiter() { name = 1, firstTable = 1, lastTable = 3, guestNumber = 0, maxGuestsNumber = 6 });
            Form1.Waiters.Add(new Waiter() { name = 2, firstTable = 4, lastTable = 6, guestNumber = 0, maxGuestsNumber = 12 });
            Form1.Waiters.Add(new Waiter() { name = 3, firstTable = 7, lastTable = 9, guestNumber = 0, maxGuestsNumber = 18 });

            Form1.waiterIndex = 0;
            Form1.waitersNumber = 3;

            AddWaiter newForm = new AddWaiter();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.waitersNumber = 0;

            AddWaiter newForm = new AddWaiter();
            newForm.Show();
        }
    }
}
