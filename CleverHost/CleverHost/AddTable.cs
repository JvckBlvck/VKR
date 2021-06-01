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
    public partial class AddTable : Form
    {
        private TextBox focusedTextbox = null;
        public AddTable()
        {
            InitializeComponent();
            //touchScreen1.OnUserControlButtonClicked += new TouchScreen.ButtonClickedEventHandler(touchScreen1_OnUserControlButtonClicked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentNumber, currentSeats, currentLeftNumber, currentRightNumber, currentChildRoom, currentLoniless, currentWaiter;

            int.TryParse(textBox1.Text, out currentNumber);
            int.TryParse(textBox2.Text, out currentSeats);
            if (checkBox1.Checked == true)
                int.TryParse(textBox3.Text, out currentLeftNumber);
            else
                currentLeftNumber = 0;
            if (checkBox3.Checked == true)
                int.TryParse(textBox4.Text, out currentRightNumber);
            else
                currentRightNumber = 0;
            if (checkBox5.Checked == true)
                currentChildRoom = 1;
            else
                currentChildRoom = 0;
            if (checkBox7.Checked == true)
                currentLoniless = 1;
            else
                currentLoniless = 0;

            currentWaiter = 0;

            Form1.Tables.Add(new Table() { number = currentNumber, seats = currentSeats, leftNumber = currentLeftNumber, rightNumber = currentRightNumber, childRoom = currentChildRoom, loneliness = currentLoniless, waiter = currentWaiter});
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentNumber, currentSeats, currentLeftNumber, currentRightNumber, currentChildRoom, currentLoniless, currentWaiter;

            int.TryParse(textBox1.Text, out currentNumber);
            int.TryParse(textBox2.Text, out currentSeats);
            if (checkBox1.Checked == true)
                int.TryParse(textBox3.Text, out currentLeftNumber);
            else
                currentLeftNumber = 0;
            if (checkBox3.Checked == true)
                int.TryParse(textBox4.Text, out currentRightNumber);
            else
                currentRightNumber = 0;
            if (checkBox5.Checked == true)
                currentChildRoom = 1;
            else
                currentChildRoom = 0;
            if (checkBox7.Checked == true)
                currentLoniless = 1;
            else
                currentLoniless = 0;
            
            currentWaiter = 0;

            foreach (Table myTable in Form1.Tables)
                if (myTable.rightNumber != 0)
                {
                    foreach (Table myRightTable in Form1.Tables)
                        if (myRightTable.number == myTable.rightNumber)
                            Form1.Tables.Add(new Table() { number = ((myTable.number*10)+myRightTable.number), seats = myTable.seats+myRightTable.seats, leftNumber = myTable.leftNumber, rightNumber = myRightTable.rightNumber, childRoom = myTable.childRoom, loneliness = myTable.loneliness, waiter = myTable.waiter});
                }

            //ListOfTables mynewForm = new ListOfTables();
            //mynewForm.Show();

            this.Close();

            WaitersSelect newForm = new WaitersSelect();
            newForm.Show();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void AddTable_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            checkBox3.Checked = false;
            checkBox4.Checked = true;
            checkBox5.Checked = false;
            checkBox6.Checked = true;
            checkBox7.Checked = false;
            checkBox8.Checked = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
        }

        protected void touchScreen1_OnUserControlButtonClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (focusedTextbox != null)
            {
                if (b.Text == "Back")
                {
                    if (focusedTextbox.Text.Length > 1)
                    {
                        focusedTextbox.Text = focusedTextbox.Text.Substring(0, focusedTextbox.Text.Length - 1);
                    }
                    else
                    {
                        focusedTextbox.Text = string.Empty;
                    }
                }
                else
                {
                    if (MyGlobal.bTouch)
                        focusedTextbox.Text = b.Text;
                    else
                    {
                        MyGlobal.bTouch = false;
                        focusedTextbox.Text += b.Text;
                    }
                }
            }
        }
    }
}
