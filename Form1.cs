using System.Reflection.Emit;
using System.Windows.Forms;

using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.Devices;
using System.Reflection.Metadata;
using System.Diagnostics.Tracing;
using System.ComponentModel.Design;
using System.Reflection;
using System.ComponentModel;
using System.CodeDom;

namespace WinFormsHomeApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int start_X = 0, start_Y = 0;
        int end_X, end_Y;

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 f2 = new();
            f2.Show();
            //Visible = false;
        }

        private void Form1_MouseUp(object sender, EventArgs e)
        {
            end_X = ((MouseEventArgs)e).X; end_Y = ((MouseEventArgs)e).Y;
            if (end_X - start_X >= 10 && end_Y - start_Y >= 10)
            {
                System.Windows.Forms.Label dynLabel = new()
                {
                    Text = "LabelDrown",
                    Location = new Point(start_X, start_Y),
                    Size = new(end_X - start_X, end_Y - start_Y),
                    BackColor = Color.SkyBlue 
                };
                this.Controls.Add(dynLabel);
                dynLabel.MouseDown  += (sender, e) => this.Text = $"{start_X} - { start_Y } : {end_X} - { end_Y }  " +
                $"   S = {(end_X - start_X) * (end_Y - start_Y)}";


                dynLabel.DoubleClick += (sen, e) => dynLabel.Dispose();
            }
            else
            {
                DialogResult result = MessageBox.Show("Burada dortkeni 10 x 10 dan balaca ceke bilmersen !!! ", "Yalnish", MessageBoxButtons.OK ,
                MessageBoxIcon.Error);
                
                
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            start_X = ((MouseEventArgs)e).X; dynamic? a = e as MouseEventArgs; start_Y = a!.Y;
        }

        
    }
}