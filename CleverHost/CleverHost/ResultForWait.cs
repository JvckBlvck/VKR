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
    public partial class ResultForWait : Form
    {
        public ResultForWait()
        {
            InitializeComponent();
        }

        private void ResultForWait_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Guests.Remove(Form1.Guests.Last());

            AddGuest newForm = new AddGuest();
            this.Close();
        }
    }
}
