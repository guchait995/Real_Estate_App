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
    public partial class Available : Form
    {
        String Room = null;
        String Room_Pr = null;
        String Aadhar = null;
        String plotid = null;
       
        String bedroom = null;
        String bathroom = null;
        String balcony = null;
        
        String area = null;
        public Available(string username,String Room_Booked)
        {
            Aadhar = username;

            InitializeComponent();
        }

        private void Available_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet2.ROOM' table. You can move, or remove it, as needed.
            this.rOOMTableAdapter.Fill(this.database2DataSet2.ROOM);
            // TODO: This line of code loads data into the 'database2DataSet1.PLOT' table. You can move, or remove it, as needed.
            this.pLOTTableAdapter.Fill(this.database2DataSet1.PLOT);

        }

        private void comboBox_PlotAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection n = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database2.mdf; Integrated Security = True");
            n.Open();

           string PlotId = "00"+(comboBox_PlotAddress.SelectedIndex+1).ToString();
            String query = "Select * From ROOM where PlotId LIKE'" + PlotId + "%' and Booked LIKE 'NO'";
            SqlDataAdapter da = new SqlDataAdapter(query, n);
            DataTable dt = new DataTable();
            da.Fill(dt);
            String g = dt.ToString();
            
            dataAvailable.DataSource = dt;

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
            OptionPage n = new OptionPage();
            n.ShowDialog();
            this.Dispose();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            String BathRoom = comboBox2.SelectedItem.ToString();
            String BedRoom = comboBox1.Text;
            SqlConnection n = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database2.mdf; Integrated Security = True");
            n.Open();

            string PlotId = "00" + (comboBox_PlotAddress.SelectedIndex + 1).ToString();
            String query = "Select * From ROOM where PlotId LIKE'" + PlotId + "%' and Booked LIKE 'NO' and Bath_Room LIKE'" + BathRoom + "%'and Bed_Room LIKE'" + BedRoom + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, n);
            DataTable dt = new DataTable();
            da.Fill(dt);
            String g = dt.ToString();

            dataAvailable.DataSource = dt;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String BedRoom = comboBox1.SelectedItem.ToString();
            SqlConnection n = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database2.mdf; Integrated Security = True");
            n.Open();

            string PlotId = "00" + (comboBox_PlotAddress.SelectedIndex + 1).ToString();
            String query = "Select * From ROOM where PlotId LIKE'" + PlotId + "%' and Booked LIKE 'NO' and Bed_Room LIKE'" + BedRoom+ "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, n);
            DataTable dt = new DataTable();
            da.Fill(dt);
            String g = dt.ToString();

            dataAvailable.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Aadhar.Equals("Check"))
            {
               Registration n = new Registration();
               n.ShowDialog();
            }
            else
            {
                SqlConnection con1 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database1.mdf; Integrated Security = True");
                SqlConnection con2 = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database2.mdf; Integrated Security = True");

                String query1 = "UPDATE Customer SET Room_Booked = '"+Room+"', Room_Price = '"+Room_Pr+"' Where Adhar_No ='"+Aadhar+"'";
                String query2 = "UPDATE ROOM SET Booked = 'YES' Where RoomId ='" + Room + "'";
                SqlCommand h1= new SqlCommand(query1, con1);
                SqlCommand h2 = new SqlCommand(query2, con2);
                SqlDataReader ReadData1;
                SqlDataReader ReadData2;

                try
                {
                    con1.Open();
                    con2.Open();
                    ReadData2 = h1.ExecuteReader();
                    ReadData1 = h2.ExecuteReader();
                    MessageBox.Show("Successfully Booked Room");
                    
                }
                catch (Exception Exp)
                {
                    MessageBox.Show(Exp.Message);

                }


            }

        }

        private void dataAvailable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected = dataAvailable.Rows[index];
            String RoomId = selected.Cells["RoomId"].Value.ToString();
            Room = RoomId;
            String PlotId = selected.Cells["PlotId"].Value.ToString();
            plotid = PlotId;
            String Bed_Room = selected.Cells["Bed_Room"].Value.ToString();
            bedroom = Bed_Room;
            String Bath_Room = selected.Cells["Bath_Room"].Value.ToString();
            bathroom = Bath_Room;
            String Balcony = selected.Cells["Balcony"].Value.ToString();
            balcony = Balcony;
            String Room_Area = selected.Cells["Room_Area"].Value.ToString();
            area = Room_Area;
            String Room_Price = selected.Cells["Room_Price"].Value.ToString();
            Room_Pr = Room_Price;
            String Booked= selected.Cells["Booked"].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AddRoom n = new AddRoom();
            n.setupdate(plotid, Room, bedroom, bathroom, balcony, area, Room_Pr);
            n.ShowDialog();
            
        }
    }
}
