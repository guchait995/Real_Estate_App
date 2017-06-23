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
    public partial class AddPlot : Form
    {
        public AddPlot()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Plot_Number = label_Plot_Number.Text;
            String Plot_Address = textBox_Plot_Address.Text;
            String Plot_Owner = textBox_Plot_Owner.Text;
            String Plot_Area = textBox_Plot_Area.Text;
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\SOURAV\Documents\Visual Studio 2015\Projects\SSConstruction_Windows\SSConstruction_Windows\Database2.mdf; Integrated Security = True");
            String query= "insert into PLOT(PLotId,Plot_Address,Plot_Owner,Plot_Area) values('"+Plot_Number+ "','" + Plot_Address + "','" + Plot_Owner + "','" + Plot_Area + "');";
            SqlCommand command = new SqlCommand(query,con);
            SqlDataReader Read;
            try
            {
                con.Open();
                Read = command.ExecuteReader();
                MessageBox.Show("Plot Added");

            }
            catch (Exception)
            {

                MessageBox.Show("Failed to Add Plot");
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            OptionPage n = new OptionPage();
            n.ShowDialog();
        }

        private void button_Minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_AddRoom_Click(object sender, EventArgs e)
        {
            AddRoom n = new AddRoom();
            n.ShowDialog();
        }

        private void AddPlot_Load(object sender, EventArgs e)
        {

        }
    }
}
