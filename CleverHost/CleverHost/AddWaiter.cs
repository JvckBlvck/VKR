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
    public partial class AddWaiter : Form
    {
        private TextBox focusedTextbox = null;
        public AddWaiter()
        {
            InitializeComponent();
            //touchScreen1.OnUserControlButtonClicked += new TouchScreen.ButtonClickedEventHandler(touchScreen1_OnUserControlButtonClicked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentName, currentFirstTable, currentLastTable, currentGuestNumber, currentMaxGuestNumber;

            int.TryParse(textBox1.Text, out currentName);
            int.TryParse(textBox2.Text, out currentMaxGuestNumber);

            currentFirstTable = 0;
            currentLastTable = 0;
            currentGuestNumber = 0;
            
            Form1.Waiters.Add(new Waiter() { name = currentName, firstTable = currentFirstTable, lastTable = currentLastTable, guestNumber = currentGuestNumber, maxGuestsNumber = currentMaxGuestNumber});
            Form1.waitersNumber++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int currentName, currentFirstTable, currentLastTable, currentGuestNumber, currentMaxGuestNumber;

            int.TryParse(textBox1.Text, out currentName);
            int.TryParse(textBox2.Text, out currentFirstTable);

            currentFirstTable = 0;
            currentLastTable = 0;
            currentGuestNumber = 0;

            Form1.Waiters.Add(new Waiter() { name = currentName, firstTable = currentFirstTable, lastTable = currentLastTable, guestNumber = currentGuestNumber, maxGuestsNumber = currentMaxGuestNumber });
            Form1.waitersNumber++;
            Form1.waiterIndex = 0;

            this.Close();

            Gusts_in_or_out newForm = new Gusts_in_or_out();
            newForm.Show();
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

        private void AddWaiter_Load(object sender, EventArgs e)
        {

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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
        }
    }
}
