using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lockers
{
    public partial class Assets : Form
    {
        //declaring the variables that will receive that values from the textboxes
        String date, WWID, model, serialNumber, tech, serialNumberSsd, notes = "";
        String selectedItemAction, selectedItemReason, selectedItemStock = "";

        //string with the name of the server and details
        public string conString = "Data Source=DTITELLX-MOBL\\SQLEXPRESS;Initial Catalog = Lockers; Integrated Security = True";

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public Assets()
        {
            InitializeComponent();
        }

        
        private void btn_AdvanceMode_Click(object sender, EventArgs e)
        {
            AdvanceSearch Upload_Advance = new AdvanceSearch();
            Upload_Advance.ShowDialog();//open AdvanceSearch
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //receiving the values from each textbox and listbox
            date = TBDate.Text;
            WWID = TBWwid.Text;
            serialNumber = TBSerialNumber.Text;
            tech = TBTech.Text;
            serialNumberSsd = TBSSD.Text;
            notes = TBNotes.Text;
            model = TBModel.Text;
            selectedItemAction = listBoxAction.Items[listBoxAction.SelectedIndex].ToString();
            selectedItemReason = listBoxReason.Items[listBoxReason.SelectedIndex].ToString();
            selectedItemStock = listBoxStock.Items[listBoxStock.SelectedIndex].ToString();

            //connecting to the database
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            //verifying with the connection was successful
            if (con.State == System.Data.ConnectionState.Open)
            {
                //if WWID/KEYNUMBER/COLOR were filled, insert into the database
                if (WWID != "" && date != "" && serialNumber != "" && tech != "" && selectedItemAction != "" && selectedItemReason != "" && selectedItemStock != "")
                {
                    String q = "INSERT INTO LAPTOP(MOVEMENT,DateOfMov,WWID,SERIALNUMBER,TECH,REASON, SSDSN,LOCATION,MODEL) VALUES ('" + selectedItemAction.ToString() + "','" + date.ToString() + "','" + WWID.ToString() + "','" + serialNumber.ToString() + "','" + tech.ToString() + "','" + selectedItemReason.ToString() + "','" + serialNumberSsd.ToString() + "','" + selectedItemStock.ToString() + "','" + model.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();

                    //clearing the fields
                    TBDate.Text = "";
                    TBSerialNumber.Text = "";
                    TBWwid.Text = "";
                    TBTech.Text = "";
                    TBSSD.Text = "";
                    TBNotes.Text = "";
                    TBModel.Text = "";
                    listBoxReason.ClearSelected();
                    listBoxAction.ClearSelected();
                    listBoxStock.ClearSelected();
                    cmd.Dispose();
                }
                else
                {
                    //if some of the mandatory fields were not filled, do it again.
                    MessageBox.Show("Try again - Complete all the fields");
                }//END OF ELSE
            } //IF OF CONNECTION
        }//END OF BUTTON INSERT


        private void btn_search_Click(object sender, EventArgs e)
        {
            //receiving the values from each textbox and listbox
            WWID = TBWWIDSearch.Text;
            serialNumber = TBSerialNumberSearch.Text;

            //connecting with the database
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            //verifying with the connection was successful
            if (con.State == System.Data.ConnectionState.Open)
            {
                //create a dataReader to pull the data from the sql query
                //create the datatable to store the info into the datagridview
                SqlDataReader dataReader;
                DataTable tUpload = new DataTable();

                //adding the name of the columns
                tUpload.Columns.Add("TransactionId", typeof(String));
                tUpload.Columns.Add("Movement", typeof(String));
                tUpload.Columns.Add("DateOfMov", typeof(String));
                tUpload.Columns.Add("WWID", typeof(String));
                tUpload.Columns.Add("Model", typeof(String));
                tUpload.Columns.Add("SerialNumber", typeof(String));
                tUpload.Columns.Add("Tech", typeof(String));
                tUpload.Columns.Add("Reason", typeof(String));
                tUpload.Columns.Add("SSDSN", typeof(String));
                tUpload.Columns.Add("Location", typeof(String));

                //if wwid is not empty, i will select it
                if (WWID != "")
                {
                    String q = "SELECT * FROM LAPTOP where CONVERT(NVARCHAR(MAX), WWID) = @wwid";
                    SqlCommand cmd = new SqlCommand(q, con);

                    //add the parameter used in the where condition
                    cmd.Parameters.AddWithValue("@wwid", WWID);

                    //datareader receives the result of the query
                    dataReader = cmd.ExecuteReader();

                    //if there is some info returned by the query
                    if (dataReader.Read())
                    {
                        //while there is info (rows) returned by the query
                        while (dataReader.Read())
                        {

                            //write the info into the rows of the data table
                            tUpload.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3), dataReader.GetValue(4), dataReader.GetValue(5), dataReader.GetValue(6), dataReader.GetValue(7), dataReader.GetValue(8), dataReader.GetValue(9));
                            //datagrid view receives the datatable
                            dataGridViewAssets.DataSource = tUpload;

                        }
                    }
                    else
                    {
                        //it means it didnt find anything
                        MessageBox.Show("Nothing found");
                        dataGridViewAssets.DataSource = "";
                    }

                    //dataReader.Close();
                    cmd.Dispose();

                }
                else if (serialNumber != "")
                {
                    String q = "SELECT * FROM LAPTOP where CONVERT(NVARCHAR(MAX), SERIALNUMBER) = @serialnumber";
                    SqlCommand cmd = new SqlCommand(q, con);

                    //add the parameter used in the where condition
                    cmd.Parameters.AddWithValue("@serialnumber", serialNumber);

                    //datareader receives the result of the query
                    dataReader = cmd.ExecuteReader();

                    //if there is some info returned by the query
                    if (dataReader.Read())
                    {
                        //while there is info (rows) returned by the query
                        while (dataReader.Read())
                        {

                            //write the info into the rows of the data table
                            tUpload.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3), dataReader.GetValue(4), dataReader.GetValue(5), dataReader.GetValue(6), dataReader.GetValue(7), dataReader.GetValue(8), dataReader.GetValue(9));
                            //datagrid view receives the datatable
                            dataGridViewAssets.DataSource = tUpload;

                        }
                    }
                    else
                    {
                        //it means it didnt find anything
                        MessageBox.Show("Nothing found");
                        dataGridViewAssets.DataSource = "";
                    }
                    //dataReader.Close();
                    cmd.Dispose();
                }//else if serial number
            }//verifying with the connection was successful
        }//button search
    }//publin class
}//namespace
