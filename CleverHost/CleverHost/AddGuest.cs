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
    public partial class AddGuest : Form
    {
        public AddGuest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentGuests, currentChildRoom, currentLoniless;
            int.TryParse(textBox1.Text, out currentGuests);
            if (checkBox1.Checked == true)
                currentChildRoom = 1;
            else
                currentChildRoom = 0;
            if (checkBox2.Checked == true)
                currentLoniless = 1;
            else
                currentLoniless = 0;
                
            

            int waiter = 0, table = 0;

            Form1.result = "";

            foreach (Table myTable in Form1.Tables)
                if ((myTable.waiter == 0) && (myTable.seats >= currentGuests) && (currentLoniless <= myTable.loneliness) && (currentChildRoom <= myTable.childRoom))
                    table = myTable.number;

            if ((Form1.Waiters[Form1.waiterIndex].guestNumber + currentGuests) <= Form1.Waiters[Form1.waiterIndex].maxGuestsNumber)
                waiter = Form1.Waiters[Form1.waiterIndex].name;

            else
            {
                for (int i = Form1.waiterIndex; i < Form1.waitersNumber; i++)
                    if ((Form1.Waiters[i].guestNumber + currentGuests) <= Form1.Waiters[i].maxGuestsNumber)
                        waiter = Form1.Waiters[i].name;
                if (waiter == 0) 
                    for (int i =0; i<Form1.waiterIndex; i++)
                        if ((Form1.Waiters[i].guestNumber + currentGuests) <= Form1.Waiters[i].maxGuestsNumber)
                            waiter = Form1.Waiters[i].name;
            }

            if (waiter != 0)
            {
                Form1.waiterIndex++;
                if (Form1.waiterIndex == Form1.waitersNumber)
                    Form1.waiterIndex = 0;
            }

            if ((waiter == 0) && (table == 0))
            {
                Form1.result = "No one table for you. Change conditions, or wait. No one waiter, wait.";
                Form1.Guests.Add(new Guest() { number = currentGuests, needChildRoom = currentChildRoom, needLoneliness = currentLoniless, tableNumber = table, waiterNumber = waiter });

                ResultForWait newForm = new ResultForWait();
                newForm.Show();
            }
            if ((waiter == 0) && (table != 0))
            {
                Form1.result = "Table number " + table + ". No one waiter, wait.";
                Form1.Guests.Add(new Guest() { number = currentGuests, needChildRoom = currentChildRoom, needLoneliness = currentLoniless, tableNumber = table, waiterNumber = waiter });

                ResultForWait newForm = new ResultForWait();
                newForm.Show();
            }
            if ((waiter != 0) && (table == 0))
            {
                Form1.result = "No one table for you. Change conditions, or wait. Waiter " + waiter + ".";
                Form1.Guests.Add(new Guest() { number = currentGuests, needChildRoom = currentChildRoom, needLoneliness = currentLoniless, tableNumber = table, waiterNumber = waiter });

                ResultForWait newForm = new ResultForWait();
                newForm.Show();
            }
            if ((waiter != 0) && (table != 0))
            {
                Form1.result = "Table number " + table + ". Waiter " + waiter + ".";

                foreach (Waiter myWaiter in Form1.Waiters)
                    if (myWaiter.name == waiter)
                        myWaiter.guestNumber += currentGuests;

                for (int i = 0; i < table.ToString().Length; i++)
                    foreach (Table myTable in Form1.Tables)
                        if (myTable.number.ToString().Contains(table.ToString()[i]))
                            myTable.waiter = waiter;

                Result newForm = new Result();
                newForm.Show();
            }

            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddGuest_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
        }
    }
}
