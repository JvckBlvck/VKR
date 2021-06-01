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
    public partial class GuestOut : Form
    {
        public GuestOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentNumber;
            int.TryParse(textBox1.Text, out currentNumber);
            
            foreach (Table myTable in Form1.Tables)
                for (int i = 0; i < currentNumber.ToString().Length; i++)
                    if (myTable.number.ToString().Contains(currentNumber.ToString()[i]))
                        myTable.waiter = 0;

            int table = 0, waiter = 0;

            int currentGuest = 0;

            foreach (Guest myGuest in Form1.Guests)
            {
                foreach (Table myTable in Form1.Tables)
                    if ((myTable.waiter == 0) && (myTable.seats >= myGuest.number) && (myGuest.needLoneliness <= myTable.loneliness) && (myGuest.needChildRoom <= myTable.childRoom))
                        table = myTable.number;

                if ((Form1.Waiters[Form1.waiterIndex].guestNumber + myGuest.number) <= Form1.Waiters[Form1.waiterIndex].maxGuestsNumber)
                    waiter = Form1.Waiters[Form1.waiterIndex].name;

                else
                {
                    for (int i = Form1.waiterIndex; i < Form1.waitersNumber; i++)
                        if ((Form1.Waiters[i].guestNumber + myGuest.number) <= Form1.Waiters[i].maxGuestsNumber)
                            waiter = Form1.Waiters[i].name;
                    if (waiter == 0)
                        for (int i = 0; i < Form1.waiterIndex; i++)
                            if ((Form1.Waiters[i].guestNumber + myGuest.number) <= Form1.Waiters[i].maxGuestsNumber)
                                waiter = Form1.Waiters[i].name;
                }

                if ((waiter != 0) && (table != 0))
                {
                    Form1.waiterIndex++;
                    if (Form1.waiterIndex == Form1.waitersNumber)
                        Form1.waiterIndex = 0;

                    foreach (Waiter myWaiter in Form1.Waiters)
                        if (myWaiter.name == waiter)
                            myWaiter.guestNumber += myGuest.number;

                    for (int i = 0; i < table.ToString().Length; i++)
                        foreach (Table myTable in Form1.Tables)
                            if (myTable.number.ToString().Contains(table.ToString()[i]))
                                myTable.waiter = waiter;
                    Form1.result = "Table: for " + myGuest.number + "your table is:" + table + "your waiter is " + waiter + "\n";

                    Form1.Guests.RemoveAt(currentGuest);
                    currentGuest--;

                    ResultFromGuestList newForm = new ResultFromGuestList();
                    newForm.Show();
                }
                currentGuest++;
            }
            
            this.Close();
        }
    }
}
