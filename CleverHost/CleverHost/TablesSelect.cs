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
    public partial class Form1 : Form
    {
        public static List<Table> Tables = new List<Table>();
        public static List<Waiter> Waiters = new List<Waiter>();
        public static List<Guest> Guests = new List<Guest>();
        public static string result;
        public static int waiterIndex;
        public static int waitersNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Tables.Add(new Table() { number = 1, seats = 2, leftNumber = 0, rightNumber = 0, childRoom = 0, loneliness = 1, waiter = 0 });
            Tables.Add(new Table() { number = 2, seats = 4, leftNumber = 0, rightNumber = 3, childRoom = 0, loneliness = 0, waiter = 0 });
            Tables.Add(new Table() { number = 23, seats = 8, leftNumber = 0, rightNumber = 0, childRoom = 0, loneliness = 0, waiter = 0 });
            Tables.Add(new Table() { number = 3, seats = 4, leftNumber = 2, rightNumber = 0, childRoom = 0, loneliness = 0, waiter = 0 });
            Tables.Add(new Table() { number = 4, seats = 4, leftNumber = 0, rightNumber = 5, childRoom = 1, loneliness = 0, waiter = 0 });
            Tables.Add(new Table() { number = 45, seats = 8, leftNumber = 0, rightNumber = 6, childRoom = 1, loneliness = 0, waiter = 0 });
            Tables.Add(new Table() { number = 456, seats = 12, leftNumber = 0, rightNumber = 0, childRoom = 1, loneliness = 0, waiter = 0 });
            Tables.Add(new Table() { number = 5, seats = 4, leftNumber = 4, rightNumber = 6, childRoom = 1, loneliness = 0, waiter = 0 });
            Tables.Add(new Table() { number = 56, seats = 8, leftNumber = 4, rightNumber = 0, childRoom = 1, loneliness = 0, waiter = 0 });
            Tables.Add(new Table() { number = 6, seats = 4, leftNumber = 5, rightNumber = 0, childRoom = 1, loneliness = 0, waiter = 0 });
            Tables.Add(new Table() { number = 7, seats = 6, leftNumber = 0, rightNumber = 0, childRoom = 1, loneliness = 1, waiter = 0 });
            Tables.Add(new Table() { number = 8, seats = 4, leftNumber = 0, rightNumber = 9, childRoom = 0, loneliness = 0, waiter = 0 });
            Tables.Add(new Table() { number = 89, seats = 8, leftNumber = 0, rightNumber = 0, childRoom = 0, loneliness = 0, waiter = 0 });
            Tables.Add(new Table() { number = 9, seats = 4, leftNumber = 8, rightNumber = 0, childRoom = 0, loneliness = 0, waiter = 0 });


            //WaitersSelect newForm = new WaitersSelect();
            AddGues2 newForm = new AddGues2();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddTable newForm = new AddTable();
            newForm.Show();

        }
    }
}
