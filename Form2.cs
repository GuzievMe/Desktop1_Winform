using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHomeApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       
        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Location = new Point(Random.Shared.Next(30, 300), Random.Shared.Next(30, 300));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new();
            f3.Show();
            //Visible = false;
        }
    }
}
