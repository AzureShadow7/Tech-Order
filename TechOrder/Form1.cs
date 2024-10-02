using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechOrder
{
    public partial class TechOrder : Form
    {
        //Form form1;
        //Form form2;
        public TechOrder()
        {
            InitializeComponent();
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

            

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            TechOrderMainPage form2 = new TechOrderMainPage();
            form2.ShowDialog();
        }
    }
}
