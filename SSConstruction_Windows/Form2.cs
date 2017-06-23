using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSConstruction_Windows
{
    public partial class OptionPage : Form
    {
        public OptionPage()
        {
            InitializeComponent();
        }

        private void OptionPage_Load(object sender, EventArgs e)
        {

            this.Opacity = 0.5;
            timerOption.Start();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
           
        Registration r1 = new Registration();
         r1.ShowDialog();
         
        }

        private void button_Admin_Click(object sender, EventArgs e)
        {
            AddPlot n = new AddPlot();
            n.ShowDialog();
            this.Dispose();
        }

        private void button_Table_Click(object sender, EventArgs e)
        {
            ClientTable ct = new ClientTable();
            ct.ShowDialog();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timerOption_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.075;
            }
            else
            {
                timerOption.Stop();
            }
        }

        private void button_Minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRoom n = new AddRoom();
            n.ShowDialog();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Available n = new Available("Check",null);
            n.ShowDialog();
            this.Dispose();
        }
    }
}
