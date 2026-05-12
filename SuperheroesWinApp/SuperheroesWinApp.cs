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

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }

        private void AdminSuperheroesButton_Click(object sender, EventArgs e)
        {
            AdminDataGrid.DataSource = SelectAllFromTable("superheroes");
            ChangeLabelTo(AdminSuperheroesLabel);
        }

        private void AdminProblemsButton_Click(object sender, EventArgs e)
        {
            AdminDataGrid.DataSource = SelectAllFromTable("problems");
            ChangeLabelTo(AdminProblemsLabel);
        }

        private void AdminCreateHeroButton_Click(object sender, EventArgs e)
        {
            CreateHero createHero = new CreateHero();
            createHero.Show();
            //AdminDataGrid.DataSource = SelectAllFromTable("superheroes");
            //AdminDataGrid.Update();
            //AdminDataGrid.Refresh();
        }

        private void AdminSearchButton_Click(object sender, EventArgs e)
        {
            SearchForHero searchForHero = new SearchForHero();
            searchForHero.Show();
            //AdminDataGrid.DataSource = SearchForHero.SearchedDataGrid;
        }

        private void AdminUpdateButton_Click(object sender, EventArgs e)
        {
            UpdateHero updateHero = new UpdateHero();
            updateHero.Show();
        }

        private void AdminDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteHero deleteHero = new DeleteHero();
            deleteHero.Show();
        }
        private void AdminlogOutButton_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void HeroProfileButton_Click(object sender, EventArgs e)
        {
            HeroDataGrid.DataSource = SelectFromTableWhere("superheroes", "Id", FindSuperheroID());
            ChangeLabelTo(HeroProfileLabel);
        }

        private void HeroProblemsButton_Click(object sender, EventArgs e)
        {
            HeroDataGrid.DataSource = SelectFromTableWhere("problems", "Department_Id", FindSuperheroDepartmentID());
            ChangeLabelTo(HeroProblemsLabel);
        }

        private void HeroHeroicActsButton_Click(object sender, EventArgs e)
        {
            HeroDataGrid.DataSource = SelectFromTableWhere("heroic_act", "Superhero_Id", FindSuperheroID());
            ChangeLabelTo(HeroHeroicActsLabel);
        }

        private void HeroLogOutButton_Click(object sender, EventArgs e)
        {
            LogOut();
        }




        public void CheckLogin()
        {            
            if (FindSuperheroID() == 0)
            {
                loginErrorMessage.Visible = true;
                loginErrorMessage.Text = "Incorrect username or password";
            }
            else
            {
                loginGroupBox.Visible = false;
                LabelPanel.Visible = true;
                if (usernameTextbox.Text == "admin")
                {
                    AdminCRUDButtons.Visible = true;
                    AdminNav.Visible = true;
                    AdminDataGrid.Visible = true;

                    AdminDataGrid.DataSource = SelectAllFromTable("superheroes");
                    ChangeLabelTo(AdminSuperheroesLabel);
                }
                else
                {
                    HeroDataGrid.Visible = true;
                    HeroNav.Visible = true;
                    HeroDataGrid.DataSource = SelectFromTableWhere("superheroes", "Id", FindSuperheroID());
                    ChangeLabelTo(HeroProfileLabel);
                    HeroNavName.Text = FindSuperheroName();
                }
            }
        }

        public void ChangeLabelTo(Label visibleLabel)
        {
            HeroProfileLabel.Visible = false;
            HeroProblemsLabel.Visible = false;
            HeroHeroicActsLabel.Visible = false;
            AdminSuperheroesLabel.Visible = false;
            AdminProblemsLabel.Visible = false;

            visibleLabel.Visible = true;
        }

        public int FindSuperheroID()
        {
            string idQuery = "SELECT Superhero_ID FROM logins WHERE Username = @username and password = @password";
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand sqlcmd = new SqlCommand(idQuery, con))
                {
                    sqlcmd.Parameters.Add("@username", SqlDbType.VarChar).Value = usernameTextbox.Text;
                    sqlcmd.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextbox.Text;
                    con.Open();
                    int value = 0;
                    if (sqlcmd.ExecuteScalar() == DBNull.Value || sqlcmd.ExecuteScalar() == null)
                    {
                        return value;
                    }
                    else
                    {
                        value = (int)sqlcmd.ExecuteScalar();
                        return value;
                    }
                }
            }
        }

        public int FindSuperheroDepartmentID()
        {
            string depIdQuery = "SELECT Department_id FROM superheroes WHERE Id = @id";
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand sqlcmd = new SqlCommand(depIdQuery, con))
                {
                    sqlcmd.Parameters.Add("@id", SqlDbType.Int).Value = FindSuperheroID();
                    con.Open();
                    int value;
                    value = (int)sqlcmd.ExecuteScalar();
                    return value;
                }
            }
        }

        public string FindSuperheroName()
        {
            string depIdQuery = "SELECT Name FROM superheroes WHERE Id = @id";
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand sqlcmd = new SqlCommand(depIdQuery, con))
                {
                    sqlcmd.Parameters.Add("@id", SqlDbType.Int).Value = FindSuperheroID();
                    con.Open();
                    string name;
                    name = (string)sqlcmd.ExecuteScalar();
                    return name;
                }
            }
        }

        public DataTable SelectAllFromTable(string tableName)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from {tableName}", con);
            DataTable dataTable = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
        }

        public DataTable SelectFromTableWhere(string tableName, string columnName, int condition)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from {tableName} where {columnName} = {condition}", con);
            DataTable dataTable = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
        }

        public void LogOut()
        {
            AdminCRUDButtons.Visible = false;
            AdminNav.Visible = false;
            AdminDataGrid.Visible = false;
            HeroNav.Visible = false;
            HeroDataGrid.Visible = false;
            LabelPanel.Visible = false;
            loginErrorMessage.Visible = false;
            loginGroupBox.Visible = true;

            usernameTextbox.Text = "";
            passwordTextbox.Text = "";
        }
    }
}
