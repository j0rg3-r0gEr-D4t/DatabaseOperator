using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseOperator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string server = "";
            string user = "";
            string password = "";
            string connection = "";
            string query = "";

            if (Srv_Name.Text == "" || Usr_Name.Text == "" || Usr_Pwd.Text == "")
            {
                lblConnStatus.Text = "You must fill all fields!";
            }
            else
            {
                server = Srv_Name.Text;
                user = Usr_Name.Text;
                password = Usr_Pwd.Text;

                connection = "Data Source=" + server + ";User ID=" + user + ";Password=" + password;
                lblConnStatus.Text = "Trying connection parameters";
                query = "SELECT name FROM sys.databases";

                try
                {
                    SqlDataReader dr;
                    SqlConnection con = new SqlConnection(connection);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cbDB.Items.Add(dr.GetValue(0));
                    }
                }
                catch (Exception ex)
                { }
            }
        }

        private void cbDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
