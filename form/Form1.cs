using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP;

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void valid(object sender, EventArgs e)
        {
            MessageBox.Show(((UserControl1)sender).IPAdress);
        }

        public void notvalid(object sender, EventArgs e)
        {
            MessageBox.Show("The IP is not valid!!!");
        }

private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
