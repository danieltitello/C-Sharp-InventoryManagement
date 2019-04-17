using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lockers
{
    public partial class Main : Form
    {
        //string with the name of the server and details
        public string conString = "Data Source=DTITELLX-MOBL\\SQLEXPRESS;Initial Catalog = Lockers; Integrated Security = True";

        int login = 0; //flag controlling login access
        String password,WWID = "";
        String CObjectwwid,CObjectpassword = "";

       
        public Main()
        {
            InitializeComponent();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_usb_Click(object sender, EventArgs e)
        {
            if(login == 1)//if wwid and password match with the database
            {
                UsbSticks Main_Form1 = new UsbSticks();
                Main_Form1.ShowDialog();//open windows form1
                
            }
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            WWID = TBUsername.Text;//receiving info from the user
            password = TBPassword.Text;//receiving info from the user

            //creating connection with the database
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            //verifying if the connection was successful
            if (con.State == System.Data.ConnectionState.Open)
            {
                //create a dataReader to pull the data from the sql query
                SqlDataReader dataReader;

                //if both textbox are not empty
                if (WWID != "" && password != "")
                {
                    //selecting the rows that match the wwid
                    String q = "SELECT * FROM USERS where CONVERT(NVARCHAR(MAX), WWID) = @wwid";
                    SqlCommand cmd = new SqlCommand(q, con);

                    //add the parameter used in the where condition
                    cmd.Parameters.AddWithValue("@wwid", WWID);

                    //datareader receives the result of the query
                    dataReader = cmd.ExecuteReader();

                   
                        //executing while there are rows returning from the query
                        while (dataReader.Read())
                        {

                            CObjectwwid = CObjectwwid + dataReader.GetValue(1);//converting object to string
                            CObjectpassword = CObjectpassword + dataReader.GetValue(3);//converting object to string

                            if (WWID == CObjectwwid && password == CObjectpassword)
                            {
                                login = 1;
                                CObjectwwid = "";
                                CObjectpassword = "";
                            }
                            else
                            {
                                login = 0;
                                CObjectwwid = "";
                                CObjectpassword = "";
                            }
                        }
                        if (login == 1)
                        {
                            labelOutputLogin.Text = "Access granted!";
                        }
                        else
                        {
                            labelOutputLogin.Text = "Access denied. Try again!";
                        }
                    //dataReader.Close();
                    cmd.Dispose();
                }//if both textbox are not empty
            }//verifying if the connection was successful
        }//button

        private void btn_assets_Click(object sender, EventArgs e)
        {
            if (login == 1)//if wwid and password match with the database
            {
                Assets Form1_Upload = new Assets();
                Form1_Upload.ShowDialog();//open windows UploadLockers
            }  
        }
    }
}
