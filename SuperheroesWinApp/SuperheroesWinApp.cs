using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperheroesWinApp
{
    public partial class SuperheroesWinApp : Form
    {
        private readonly string conString = "Data Source=SOP-CZC9508NW0\\SQLEXPRESS;Initial Catalog=superheroes_inc;Integrated Security=True";

        public SuperheroesWinApp()
        {
            InitializeComponent();
        }

        private void SuperheroesWinApp_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(conString);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from departments", con);
            //DataTable dataTable = new DataTable();
            //SqlDataReader reader = cmd.ExecuteReader();
            //dataTable.Load(reader);
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }



        public void CheckLogin()
        {
            string query = "SELECT * from logins WHERE Username = @username and password = @password";
            string returnValue = "";
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand sqlcmd = new SqlCommand(query, con))
                {
                    sqlcmd.Parameters.Add("@username", SqlDbType.VarChar).Value = usernameTextbox.Text;
                    sqlcmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextbox.Text;
                    con.Open();
                    returnValue = (string)sqlcmd.ExecuteScalar();
                }
            }
            if (String.IsNullOrEmpty(returnValue))
            {
                //MessageBox.Show("Incorrect username or password");
                loginErrorMessage.Text = "Incorrect username or password";
                return;
            }
            else
            {
                //MessageBox.Show("You logged in");
                loginGroupBox.Visible = false;
                if (usernameTextbox.Text == "admin")
                {
                    AdminCRUDButtons.Visible = true;
                    AdminNav.Visible = true;
                    AdminDataGrid.Visible = true;

                    SelectAllFromTable("superheroes");
                }
                else
                {
                    HeroDataGrid.Visible = true;
                    HeroNav.Visible = true;
                    string idQuery = "SELECT Superhero_Id FROM logins WHERE Username = @username and password = @password";
                    string value;
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        using (SqlCommand sqlcmd = new SqlCommand(idQuery, con))
                        {
                            sqlcmd.Parameters.Add("@username", SqlDbType.VarChar).Value = usernameTextbox.Text;
                            sqlcmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextbox.Text;
                            con.Open();
                            value = (string)sqlcmd.ExecuteScalar();
                        }
                    }
                    SelectFromTableWhere("superheroes", "Id", Convert.ToInt32(value));
                }
            }
        }

        public void SelectAllFromTable(string tableName)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from {tableName}", con);
            DataTable dataTable = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            AdminDataGrid.DataSource = dataTable;
        }

        public void SelectFromTableWhere(string tableName, string columnName, int condition)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from {tableName} where {columnName} = {condition}", con);
            DataTable dataTable = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            AdminDataGrid.DataSource = dataTable;
        }

        private void AdminProblemsButton_Click(object sender, EventArgs e)
        {
            SelectAllFromTable("problems");
        }

        private void AdminSuperheroesButton_Click(object sender, EventArgs e)
        {
            SelectAllFromTable("superheroes");
        }
    }
}
