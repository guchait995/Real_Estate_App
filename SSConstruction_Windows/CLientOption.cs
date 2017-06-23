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
    public partial class CLientOption : Form
    {
        string aadhar = null;
        string AmountPaid = null;
        string RoomPrice = null;
        string fullname = null;
        string address = null;
        string phone = null;
        string documents = null;
        String RoomBooked = null;
        public CLientOption(String Aadhar_No, String Full_Name, String Address, String Phone_No, String Documents, String Room_Booked, String Room_Price, String Amount_Paid)
        {
            RoomPrice = Room_Price;
            AmountPaid = Amount_Paid;
            aadhar = Aadhar_No;
            fullname = Full_Name;
            address = Address;
            phone = Phone_No;
            documents = Documents;
            RoomBooked = Room_Booked;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long Amount = long.Parse(AmountPaid);
            Pay pay = new Pay(AmountPaid, aadhar, RoomPrice);
            pay.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Registration n = new Registration();
            n.setText(fullname, address, aadhar, phone, documents);
        n.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection n = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database1.mdf; Integrated Security = True");
            String query = "DELETE FROM Customer where Adhar_No='" + aadhar + "'";
            SqlCommand h2 = new SqlCommand(query, n);
            SqlDataReader ReadData1;
            try
            {
                n.Open();
                ReadData1 = h2.ExecuteReader();
                MessageBox.Show("Client Profile Deleted");
                n.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Available n = new Available(aadhar,RoomBooked);
            n.ShowDialog();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_Minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelBooking_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database1.mdf; Integrated Security = True");
            SqlConnection con1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database2.mdf; Integrated Security = True");

            String Query1 = "Update Customer SET Room_Booked ='0',Room_Price='0',Amount_Paid='0',Amount_Due='0' where Adhar_No='" + aadhar + "';";
            String Query2 = "Update ROOM SET Booked ='NO' where RoomId='" + RoomBooked + "';";

            SqlCommand command = new SqlCommand(Query1, con);
            SqlCommand command1 = new SqlCommand(Query2, con1);


            SqlDataReader Read;
            SqlDataReader Read1;
            try
            {
                con.Open();
                con1.Open();
                Read1 = command1.ExecuteReader();
                Read = command.ExecuteReader();
                MessageBox.Show("Booking Cancelled");

            }
            catch (Exception)
            {

                MessageBox.Show("Cancellation Failed");
            }
        }
    }
}
