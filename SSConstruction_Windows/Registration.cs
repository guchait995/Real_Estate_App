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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                String Full_Name = textBox_FullName.Text;
            String Aadhar = textBox_Aadhar.Text;
            
            String Address = textBox_Address.Text;
            String Phone = textBox_Phone.Text;
            String Docs = null;
            try
            {
              Docs = checkedListBox_Docs.SelectedItem.ToString();

            }
            catch (Exception)
            {
                Docs = null;
                
            }
            if (Aadhar.Length != 12)
            {
                MessageBox.Show("Enter Valid Aadhar");
            }
            else if (Full_Name.Length <= 2)
            {
                MessageBox.Show("Name Too Short Enter Valid Name ");
            }
            else if (Phone.Length <= 10)
            {
                MessageBox.Show("enter Valid 10 digit mobile no");
            }
            else if (Address.Length <= 3)
            {
                MessageBox.Show("Address Too Short Enter Valid Address");
            }
            else if (Docs == null)
            {
                MessageBox.Show("Reselect Document Please");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database1.mdf; Integrated Security = True");
                String Query = "Insert into Customer(Adhar_No,Full_Name,Address,Phone_No,Documents,Room_Booked,Room_Price,Amount_Paid,Amount_Due) values('" + Aadhar + "','" + Full_Name + "','" + Address + "','" + Phone + "','" + Docs + "','0','0','0','0');";
                SqlCommand command = new SqlCommand(Query, con);
                SqlDataReader Read;
                try
                {
                    con.Open();
                    Read = command.ExecuteReader();
                    MessageBox.Show("Client Added");

                }
                catch (Exception Exp)
                {

                    MessageBox.Show("Duplicate Aadhar No.");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {

            this.Hide();
        }


        public void setText(String FullName, String Address, String Aadhar, String Phone, String Docs)
        {
            textBox_FullName.Text = FullName;
            textBox_Aadhar.Text = Aadhar;
            textBox_Address.Text = Address;
            textBox_Phone.Text = Phone;
            int index = 0;
            

           if (Docs.Equals("Aadhar Card"))
            {
                index = 0;
            }
            else if (Docs.Equals("Voter Id Card"))
            {

                index = 1;
            }

            else if(Docs.Equals("PAN Card"))
            {
                index = 2;
            }
            else if(Docs.Equals("Driving Liscense"))
            {
                index = 3;
            }

            checkedListBox_Docs.SetItemChecked(index, true);


        }

        private void button2_Click(object sender, EventArgs e)
        {

            String Full_Name = textBox_FullName.Text;
            String Aadhar = textBox_Aadhar.Text;
            if (CheckUser(Aadhar) == 1)
            {



                String Address = textBox_Address.Text;
                String Phone = textBox_Phone.Text;
                String Docs = null;
                try
                {
                    Docs = checkedListBox_Docs.SelectedItem.ToString();

                }
                catch (Exception)
                {
                    Docs = null;

                }
                try
                {
                    Docs = checkedListBox_Docs.SelectedItem.ToString();

                }
                catch (Exception)
                {
                    Docs = null;

                }
                if (Aadhar.Length != 12)
                {
                    MessageBox.Show("Enter Valid Aadhar");
                }
                else if (Full_Name.Length <= 2)
                {
                    MessageBox.Show("Name Too Short Enter Valid Name ");
                }
                else if (Phone.Length < 10)
                {
                    MessageBox.Show("enter Valid 10 digit mobile no");
                }
                else if (Address.Length <= 3)
                {
                    MessageBox.Show("Address Too Short Enter Valid Address");
                }
                else if (Docs == null)
                {
                    MessageBox.Show("Reselect Document Please");
                }
                else
                {

                    MessageBox.Show("Document Updated " + Docs + "Added");
                    SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database1.mdf; Integrated Security = True");
                    String Query = "Update Customer SET Full_Name='" + Full_Name + "',Address='" + Address + "',Phone_No='" + Phone + "',Documents='" + Docs + "' where Adhar_No='" + Aadhar + "';";
                    SqlCommand command = new SqlCommand(Query, con);
                    SqlDataReader Read;
                    try
                    {
                        con.Open();
                        Read = command.ExecuteReader();
                        MessageBox.Show("Client Details Updated");

                    }
                    catch (Exception Exp)
                    {

                        MessageBox.Show("Couldnt Update Client");
                    }
                }
            }
            else
            {
                MessageBox.Show("Register First");
            }
        }

        public int CheckUser(String user)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database1.mdf; Integrated Security = True");
            String query = "Select * From Customer where Adhar_No='" + user + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
           
            try
            {
                da.Fill(dt);
            }
            catch (Exception)
            {

                
            }
                
            if(dt.Rows.Count==0)
            {
               
                return 0;
            }
            else
            {
                return 1;
            }

        }


        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {
            

                }

        private void textBox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char g=e.KeyChar;
            if(!Char.IsDigit(g) && g!=8 && g != 46)
            {
                e.Handled = true;
                MessageBox.Show("Entering Number are only Allowed");
            }
          
        }

        private void textBox_Aadhar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char g = e.KeyChar;
            if (!Char.IsDigit(g) && g != 8 && g != 46)
            {
                e.Handled = true;
                MessageBox.Show("Entering Number are only Allowed");
            }
        }
    }
}
