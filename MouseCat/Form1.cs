using MouseCat.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseCat
{
    public partial class Cat : Form
    {
        public Cat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
        }

        private void MousePb_MouseHover(object sender, EventArgs e)
        {
            MousePb.Location = new Point((int)(new Random().Next(0, 1920)), (int)(new Random().Next(0, 1080)));
        }
    }
}
