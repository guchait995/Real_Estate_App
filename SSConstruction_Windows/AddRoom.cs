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
    public partial class AddRoom : Form
    {
        String plotid = null;
        String roomid = null;
        String bedroom = null;
        String bathroom = null;
        String balcony = null;
        String price = null;
        String area=null;
        public AddRoom()
        {

            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet.PLOT' table. You can move, or remove it, as needed.
            this.pLOTTableAdapter.Fill(this.database2DataSet.PLOT);

        }

        private void button_Back_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

      

      

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database2.mdf; Integrated Security = True");
            string PlotId = "00"+((comboBox_Plot_No.SelectedIndex)+1).ToString();
            string RoomId = PlotId+comboBox_Floor.SelectedItem.ToString() + comboBox_RoomNo.SelectedItem.ToString();
            string BedRoom = comboBox_BedRoom.SelectedItem.ToString();
            string BathRoom = comboBox_BathRoom.SelectedItem.ToString();
            string Balcony = comboBox_Balcony.SelectedItem.ToString();
            string Price = textBox_RoomPrice.Text;
            string area = textBox_RoomArea.Text;
            String Query = "Insert into ROOM(RoomId,PlotId,Bed_Room,Bath_Room,Balcony,Room_Area,Room_Price,Booked) values('" + RoomId + "','"+ PlotId+ "','" + BedRoom + "','" + BathRoom + "','" +Balcony  + "','" + area + "','" + Price + "','NO');";
            SqlCommand command = new SqlCommand(Query, con);
            SqlDataReader Read;
            try
            {
                con.Open();
                MessageBox.Show(RoomId);
                Read = command.ExecuteReader();
                MessageBox.Show("Room Added");

            }
            catch (Exception Exp)
            {

                MessageBox.Show(Exp.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void comboBox_RoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database2.mdf; Integrated Security = True");
            string PlotId = "00" + ((comboBox_Plot_No.SelectedIndex) + 1).ToString();

            string RoomId = PlotId + comboBox_Floor.SelectedItem.ToString() + comboBox_RoomNo.SelectedItem.ToString();
            string BedRoom = comboBox_BedRoom.SelectedItem.ToString();
            string BathRoom = comboBox_BathRoom.SelectedItem.ToString();
            string Balcony = comboBox_Balcony.SelectedItem.ToString();
            string Price = textBox_RoomPrice.Text;
            string area = textBox_RoomArea.Text;
            MessageBox.Show(RoomId);
            String Query = "Update ROOM SET RoomId='" + RoomId + "',PlotId='" + PlotId + "',Bed_Room='" + BedRoom + "',Bath_Room='" + BathRoom + "',Balcony='" + Balcony + "',Room_Area='" + area + "',Room_Price='" + Price + "' where RoomId='"+RoomId+"';";
            SqlCommand command = new SqlCommand(Query, con);
            SqlDataReader Read;
            try
            {
                con.Open();
                MessageBox.Show(RoomId);
                Read = command.ExecuteReader();
                MessageBox.Show("Room Updated");

            }
            catch (Exception Exp)
            {

                MessageBox.Show(Exp.Message);
            }
        }
        //
        //set Field to update
        //
        public void setupdate(String plotid, String Room, String bedroom, String bathroom, String balcony, String area, String Room_Pr)
        {
            // char[] room = new char[8];
            //room = Room.ToCharArray();
            // string roomno = (room[6] + room[7]).ToString();
            //string floor = (room[4] + room[5]).ToString();
            char[] room = Room.ToCharArray();
            string plot = room[0].ToString() + room[1].ToString() + room[2].ToString();
            string floor = room[3].ToString() + room[4].ToString() + room[5].ToString();
            string roomno = room[6].ToString()+ room[7].ToString();
           comboBox_Floor.SelectedItem = floor;
            comboBox_RoomNo.SelectedItem = roomno;
            MessageBox.Show(plotid);
            // comboBox_Plot_No.SelectedIndex =(PlotId);
            //comboBox_Floor.SelectedIndex =int.Parse(floor) ;
            // comboBox_RoomNo.SelectedIndex = int.Parse(roomno);
            comboBox_Plot_No.SelectedItem = plot;
            comboBox_BedRoom.SelectedItem =(bedroom) ;
            comboBox_Balcony.SelectedItem = (balcony);
            comboBox_BathRoom.SelectedItem = (bathroom);
            comboBox_Balcony.SelectedItem = (balcony);
            textBox_RoomArea.Text = area;
            textBox_RoomPrice.Text = Room_Pr;

        }



    }
}
