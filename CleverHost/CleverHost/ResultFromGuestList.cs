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
    public partial class ResultFromGuestList : Form
    {
        public ResultFromGuestList()
        {
            InitializeComponent();
        }

        private void ResultFromGuestList_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.result;
        }
    }
}
