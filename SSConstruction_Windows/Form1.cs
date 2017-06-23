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
    public partial class LogIn : Form
    {

        public LogIn()
        {
            
            InitializeComponent();
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            timer1.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login();
            this.Dispose();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<=1.0)
            {
                this.Opacity += 0.075;
            }
            else
            {
                timer1.Stop();
            }
        }



        void login()
        {
            String user = textBoxUserName.Text;
            String Password = textBox_LoginPassword.Text;
            if (user.Equals("Swapan") && (Password.Equals("1234")))

            {
                MessageBox.Show("Successfully Loged In..");
                this.Hide();
               OptionPage f = new OptionPage();
                f.ShowDialog();
               
                 
               

            }
            else
                MessageBox.Show("Wrong Username and Password");

        }


    }
}
