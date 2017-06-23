using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSConstruction_Windows
{
    
    public partial class Pay : Form
    {

        String Paid=null;
        String aadhar = null;
        String Room_Price = null;
        public Pay(String Paid,String Aadhar,String Room_Price)
        {
            this.Paid = Paid;
            this.aadhar = Aadhar;
            this.Room_Price = Room_Price;
            InitializeComponent();
        }

        private void textBoxPayConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBoxPay.Text).Equals(textBoxPayConfirm.Text))
            {
                SqlConnection n = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database1.mdf; Integrated Security = True");
                double Paid_Amount = double.Parse(Paid);
                String g = textBoxPay.Text;
                double Amount = double.Parse(g);
                double Total = Amount + Paid_Amount;
                double Amount_Due = double.Parse(Room_Price) - Total;
                String query1 = "UPDATE Customer SET Amount_paid = '" + Total.ToString() + "',Amount_Due='" + Amount_Due.ToString() + "' Where Adhar_No ='" + aadhar + "'";
                SqlCommand h2 = new SqlCommand(query1, n);
                SqlDataReader ReadData1;
                try
                {
                    n.Open();
                    ReadData1 = h2.ExecuteReader();
                    MessageBox.Show("Payment Complete");
                    n.Close();
                }
                catch (Exception Exp)
                {
                    MessageBox.Show(Exp.Message);

                }
            }
            else
            {
                MessageBox.Show("Amount Unmatched");
            }
    }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
