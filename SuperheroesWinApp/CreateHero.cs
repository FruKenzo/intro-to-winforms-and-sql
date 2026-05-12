using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperheroesWinApp
{
    public partial class CreateHero : Form
    {
        private readonly string conString = "Data Source=SOP-CZC9508NW0\\SQLEXPRESS;Initial Catalog=superheroes_inc;Integrated Security=True";

        public CreateHero()
        {
            InitializeComponent();
        }

        private void CreateHero_Load(object sender, EventArgs e)
        {
            CreateHeroDepIDNumUpDown.Maximum = GetHighestDepID();
        }

        private void CreateHeroButton_Click(object sender, EventArgs e)
        {
            CreateNewHero();
        }

        private void CreateHeroCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CreateNewHero()
        {
            if (String.IsNullOrWhiteSpace(CreateheroNameTextbox.Text) || 
                String.IsNullOrWhiteSpace(CreateHeroWeaknessTextbox.Text) || 
                String.IsNullOrWhiteSpace(CreateheroPowerTextbox.Text))
            {
                MessageBox.Show("Please fill out all fields");
                //CreateHeroErrorMessage.Visible = true;
                //CreateHeroErrorMessage.Text = "Please fill out all fields marked with *";
            }
            else if (CreateheroNameTextbox.Text.Length > 30)
            {
                MessageBox.Show("Name cannot be longer than 30 characters");
                //CreateHeroErrorMessage.Visible = true;
                //CreateHeroErrorMessage.Text = "Name cannot be longer than 30 characters";
            }
            else if (CreateheroPowerTextbox.Text.Length > 50 ||
                    CreateHeroWeaknessTextbox.Text.Length > 50)
            {
                MessageBox.Show("Power or weakness cannot be longer than 50 characters");

                //CreateHeroErrorMessage.Visible = true;
                //CreateHeroErrorMessage.Text = "Power or weakness cannot be lomger than 50 characters";
            }
            else
            {
                //CreateHeroErrorMessage.Visible = true;
                //CreateHeroErrorMessage.Text = "error";
                string query =
                "INSERT INTO superheroes (Name, Power, Level, Weakness, Department_Id) VALUES (@name, @power, @level, @weakness, @department_id)";
                using (SqlConnection con = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = CreateheroNameTextbox.Text;
                        cmd.Parameters.Add("@power", SqlDbType.VarChar).Value = CreateheroPowerTextbox.Text;
                        cmd.Parameters.Add("@level", SqlDbType.Int).Value = CreateHeroLevelNumUpDown.Value;
                        cmd.Parameters.Add("@weakness", SqlDbType.VarChar).Value = CreateHeroWeaknessTextbox.Text;
                        cmd.Parameters.Add("@department_id", SqlDbType.Int).Value = CreateHeroDepIDNumUpDown.Value;
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Hero was created");
                            this.Close();
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }
            }
        }

        public int GetHighestDepID()
        {
            string depIDQuery = "SELECT Department_Id FROM departments ORDER BY Department_Id DESC";
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(depIDQuery, con))
                {
                    con.Open();
                    int value = (Int32)cmd.ExecuteScalar();
                    return value;
                }
            }
        }

        //public DataTable SelectAllFromTable(string tableName)
        //{
        //    SqlConnection con = new SqlConnection(conString);
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand($"select * from {tableName}", con);
        //    DataTable dataTable = new DataTable();
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    dataTable.Load(reader);
        //    return dataTable;
        //}
    }
}
