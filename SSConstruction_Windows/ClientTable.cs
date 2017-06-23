using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSConstruction_Windows
{
    public partial class ClientTable : Form
    {
        string aadhar=null;
        string AmountPaid = null;
        string RoomPrice = null;
        string fullname = null;
        string address = null;
        string phone = null;
        string documents = null;
        string RoomBooked = null;
        public ClientTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection n = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database1.mdf; Integrated Security = True");
            n.Open();
            String query = "Select * From Customer where Full_Name LIKE'"+textBox_SearchQuery.Text+"%' or Adhar_No LIKE'"+textBox_SearchQuery.Text+ "%' or Room_Booked LIKE'" + textBox_SearchQuery.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, n);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataTableClient.DataSource = dt;


        }

        private void textBox_SearchQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            OptionPage op = new OptionPage();
            op.ShowDialog();
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

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            SqlConnection n = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database1.mdf; Integrated Security = True");
            n.Open();
            String query = "Select * From Customer";
            SqlDataAdapter da = new SqlDataAdapter(query, n);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataTableClient.DataSource = dt;
        }

        private void dataTableClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected = dataTableClient.Rows[index];
            String Aadhar_No = selected.Cells["Adhar_No"].Value.ToString();
            String Amount_Paid = selected.Cells["Amount_Paid"].Value.ToString();
            String Room_Price = selected.Cells["Room_Price"].Value.ToString();
            String Full_Name = selected.Cells["Full_Name"].Value.ToString();
            String Address = selected.Cells["Address"].Value.ToString();
            String Phone_No = selected.Cells["Phone_No"].Value.ToString();
            String Documents = selected.Cells["Documents"].Value.ToString();
            String Room_Booked = selected.Cells["Room_Booked"].Value.ToString();

            RoomPrice = Room_Price;
            AmountPaid = Amount_Paid;
            aadhar = Aadhar_No;
            fullname = Full_Name;
            address = Address;
            phone = Phone_No;
            documents = Documents;
            RoomBooked = Room_Booked;
            CLientOption n = new CLientOption(aadhar,fullname,address,phone,documents,RoomBooked,RoomPrice,AmountPaid);
            n.ShowDialog();
            // Available n = new Available(Aadhar_No);
            //n.ShowDialog();
        }

       
    }
}
