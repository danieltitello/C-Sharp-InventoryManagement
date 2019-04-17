using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


//versao1.1.17/04/2019
//preciso entender como funciona o cmd



namespace Lockers
{
    public partial class UsbSticks : Form
    {
        //string with the name of the server and details
        public string conString = "Data Source=DTITELLX-MOBL\\SQLEXPRESS;Initial Catalog = Lockers; Integrated Security = True";

        public UsbSticks()
        {
            InitializeComponent();
           
        }
        
        private void brn_confirm_Click(object sender, EventArgs e)
        {
            //declaring variables that will receive that data coming from the textbox
            String WWID;
            String SerialNumber;
            String KeyNumber;
            String Color;
            String Location;
            String DateReturned;

            //receiving the data from the textbox
            WWID = TBWWID.Text;
            SerialNumber = TBSerialNumber.Text;
            KeyNumber = TBKeyNumber.Text;
            Color = TBColor.Text;
            Location = TBLocation.Text;
            DateReturned = TBDayReturned.Text;

            //connecting with the database
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            //verifying with the connection was successful
            if (con.State == System.Data.ConnectionState.Open)
            {
                //if WWID/KEYNUMBER/COLOR were filled, insert into the database
                if(WWID != "" && KeyNumber != "" && Color != "")
                {

                    String q = "INSERT INTO LOCKER(WWID,DateOfMov,SerialNumber,KeyNumber,Color,Location) VALUES ('" + TBWWID.Text.ToString() + "','" + TBDayReturned.Text.ToString() + "','" + TBSerialNumber.Text.ToString() + "','" + TBKeyNumber.Text.ToString() + "','" + TBColor.Text.ToString() + "','" + TBLocation.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();

                    labeloOutput.Text = "Registered in the database";
                    //clearing the fields
                    labeloOutput.Text = "";
                    TBWWID.Text = "";
                    TBSerialNumber.Text = "";
                    TBDayReturned.Text = "";
                    TBKeyNumber.Text = "";
                    TBColor.Text = "";
                    TBLocation.Text = "";
                }
                else
                {
                    //if some of the mandatory fields were not filled, do it again.
                    MessageBox.Show("Try again");
                    labeloOutput.Text = "";
                }
             }//connection
        }//button insert
        private void btn_search_Click(object sender, EventArgs e)
        {
            //declaring variables that will receive that data coming from the textbox
            String wwid;
            String color;
            String keyNumber;

            //receiving the data from the textbox 
            wwid = TBWWIDSearch.Text;
            keyNumber = TBKeyNumberSearch.Text;
            color = TBColorSearch.Text;

            //connecting with the database
            SqlConnection con = new SqlConnection(conString);
            con.Open();
          
            //if connection was successful
            if (con.State == System.Data.ConnectionState.Open)
            {
                //create a dataReader to pull the data from the sql query
                //create the datatable to store the info into the datagridview
                SqlDataReader dataReader;
                DataTable t = new DataTable();

                //adding the name of the columns
                t.Columns.Add("WWID", typeof(String));
                t.Columns.Add("KeyNumber", typeof(String));
                t.Columns.Add("Color", typeof(String));
                t.Columns.Add("DateOfMovement", typeof(String));
                t.Columns.Add("SerialNumber", typeof(String));
                t.Columns.Add("Location", typeof(String));
                
                //if wwid is not empty, i will select it
                if (wwid != "")
                {
                    String q = "SELECT WWID, KeyNumber, Color,DateOfMov, SerialNumber,Location FROM LOCKER where CONVERT(NVARCHAR(MAX), WWID) = @wwid";
                    SqlCommand cmd = new SqlCommand(q, con);

                    //add the parameter used in the where condition
                    cmd.Parameters.AddWithValue("@wwid", wwid);

                    //datareader receives the result of the query
                    dataReader = cmd.ExecuteReader();

                    //if there is some info returned by the query
                    if (dataReader.Read())
                    {
                        //while there is info (rows) returned by the query
                        while (dataReader.Read())
                        {
                            //write the info into the rows of the data table
                            t.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3), dataReader.GetValue(4), dataReader.GetValue(5));
                            //datagrid view receives the datatable
                            dataGridView1.DataSource = t;

                        }
                    }
                    else
                    {
                        //it means it didnt find anything
                        MessageBox.Show("Nothing found");
                        dataGridView1.DataSource = "";
                    }
                    //dataReader.Close();
                    cmd.Dispose();
                }
                else if(color != "" && keyNumber != "")
                {
                    String q = "SELECT WWID, KeyNumber, Color,DateOfMov,SerialNumber,Location FROM LOCKER where CONVERT(NVARCHAR(MAX), KEYNUMBER) = @KeyNumber AND  CONVERT(NVARCHAR(MAX), COLOR) = @Color";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@KeyNumber", keyNumber);
                    cmd.Parameters.AddWithValue("@Color", color);
                    dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        while (dataReader.Read())
                        {
                            t.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3), dataReader.GetValue(4), dataReader.GetValue(5));
                            dataGridView1.DataSource = t;
                            //dataReader.Close();
                            cmd.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nothing found");
                        dataGridView1.DataSource = "";
                    }
                }//else for color and key number
            }//connection
            con.Close();
        }//button search

  

        private void button1_Click(object sender, EventArgs e)
        {
            Assets Form1_Upload = new Assets();
            Form1_Upload.ShowDialog();//open UploadLockers = laptop
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
