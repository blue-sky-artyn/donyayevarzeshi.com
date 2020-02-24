using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb; //Excel, access ,..
using System.Data;

public partial class tst_con : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region Method I
// Step 1 (connection)
        // From the connection string in webconfig file
        string ConStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conType1 = new SqlConnection(ConStr);

        // OR create conecction string localy in file

        SqlConnection conType2 = new SqlConnection("Server=94.130.88.60/SQL2016,2016;Database=archtec2_sport;Uid=archtec2_enter;Password=Admin@123;");

// Step 2 (SQL query)
        SqlCommand cmdType1 = new SqlCommand("select * from tblNewsDetails", conType1);

        // OR
        SqlCommand cmdType2 = new SqlCommand();
        cmdType2.CommandText = "select * from tblNewsDetails";
        cmdType2.Connection = conType1;

 // Step 3 (open connection)
        conType1.Open();

// Step 4 (Execute command)
        SqlDataReader dataReader = cmdType1.ExecuteReader(); //It return query reponse in the SQL format, so it must store in data reader obj

// Step 5 (use returned query response)
        gvData.DataSource = dataReader;
        gvData.DataBind();

//Step 6 (after finishing and useing of connection, the connection must be closed)
        conType1.Close();

        #endregion





        #region Method II
// Step 1 (connection)
            // OR create conecction string localy in file

            SqlConnection conType22 = new SqlConnection("Server=94.130.88.60/SQL2016,2016;Database=archtec2_sport;Uid=archtec2_enter;Password=Admin@123;");

        // From the connection string in webconfig file
        string ConStr2 = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        using (SqlConnection conType12 = new SqlConnection(ConStr2))
        {


// Step 3 (open connection)
            conType12.Open();

            #region commands' types
// Step 2 (SQL query)
    //------------------------ When the result is a bunch of valies
            //instead of injection text box directly to query,which cause injection attack, we use parametized query 
            SqlCommand cmdType12 = new SqlCommand("select * from tblNewsDetails where newsDetTitle like @titleNews", conType12);
            cmdType12.Parameters.AddWithValue("@titleNews", TextBox1.Text + "%"); //% beacuse it is wild card for comparision (like)     

            // OR
            SqlCommand cmdType22 = new SqlCommand();
            cmdType22.CommandText = "select * from tblNewsDetails";
            cmdType22.Connection = conType12;
    
    //------------------------ When the result is a singla value
            SqlCommand scalableValueCmd = new SqlCommand("select COUNT(*) from tblNewsDetails", conType12);
            int rowCount = (int)scalableValueCmd.ExecuteScalar();


    //------------------------ When the result is a value and it is command to execute
            SqlCommand insertCommandCmd = new SqlCommand("insert into tblAdmin values(" + "'bashar','123','Ali','Bashar','','','','','20200223','1')"  , conType12);
            int rowsNoAffected = (int)insertCommandCmd.ExecuteNonQuery();  //Total rows which are affected will be returned

            #endregion

            dataHtml.InnerText = "rows: " + rowCount + ", row(s) affected:" + rowsNoAffected;
// Step 4 (Execute command and store result)
    //------------------------ When the result is a bunch of valies
            using (SqlDataReader dataReader2 = cmdType12.ExecuteReader()) //It return query reponse in the SQL format, so it must store in data reader obj (treat as a variable with data reader obj)
            {
                //Data reader just read to fprward and there is no way to go backward
                
                //need to create a tempelory table 
                DataTable table = new DataTable();
                //these are col name in temp table
                table.Columns.Add("ID");
                table.Columns.Add("Title");
                table.Columns.Add("Description");
                table.Columns.Add("NewCol");



                while (dataReader2.Read()) // to read one by one
                {
                    // we are going to add new col which is not exist in table and make new view of table

                    DataRow dataRow = table.NewRow();

                    int idReadFromDatabase = (int)dataReader2["id"]; // read method an item from database

                    //insert rows to twmpelory table
                    dataRow["ID"] = idReadFromDatabase;
                    dataRow["Title"] = dataReader2["newsDetTitle"];
                    dataRow["Description"] = dataReader2["newsDetDetails"];
                    dataRow["NewCol"] = "OK";

                    table.Rows.Add(dataRow);

                }
// Step 5 (use returned query response)
                //read from data reader as source
                gvData.DataSource = dataReader2;
                gvData.DataBind();

                //OR 
                //read from data table as source
                gvData.DataSource = table;
                gvData.DataBind();

            }

//Step 6 (after finishing and useing of connection, the connection must be closed)
            //no need to close connection any more
        }
        

        #endregion

    }
}