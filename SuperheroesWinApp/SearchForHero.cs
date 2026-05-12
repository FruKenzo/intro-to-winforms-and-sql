using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperheroesWinApp
{
    public partial class SearchForHero : Form
    {

        public static DataTable SearchedDataGrid;
        private readonly string conString = "Data Source=SOP-CZC9508NW0\\SQLEXPRESS;Initial Catalog=superheroes_inc;Integrated Security=True";

        public SearchForHero()
        {
            InitializeComponent();
        }

        private void SearchHeroPickColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickFromDropDownMenu();
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void CancelSearchButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void Search()
        {
            string searchQuery = "SELECT * FROM superheroes WHERE " +
                SearchHeroPickColumn.Text + " = @value";
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(searchQuery, con))
                {
                    switch (SearchHeroPickColumn.Text.ToLower())
                    {
                        case "id":
                            {
                                cmd.Parameters.Add("@value", SqlDbType.Int).Value =
                                    SearchHeroIDUpDown.Value;
                                break;
                            }
                        case "name":
                            {
                                cmd.Parameters.Add("@value", SqlDbType.VarChar).Value =
                                    SearchNameTextbox.Text;
                                break;
                            }
                        case "department_id":
                            {
                                cmd.Parameters.Add("@value", SqlDbType.Int).Value =
                                    SearchDepIDUpDown.Value;
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Invalid value");
                                break;
                            }
                    }
                    con.Open();
                    SearchedDataGrid = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();
                    SearchedDataGrid.Load(reader);

                    //DataSet ds = new DataSet();
                    //SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //da.Fill(ds);
                    //dataGridView1.DataSource = ds.Tables[0];
                    
                    this.Close();

                }
            }
        }

        //public SqlCommand AddQueryParameter(SqlCommand cmd)
        //{

        //}

        public void ChangeInputTo(NumericUpDown visibleInput)
        {
            SearchHeroIDUpDown.Visible = false;
            SearchNameTextbox.Visible = false;
            SearchDepIDUpDown.Visible = false;

            visibleInput.Visible = true;
        }

        public void ChangeInputTo(TextBox visibleInput)
        {
            SearchHeroIDUpDown.Visible = false;
            SearchNameTextbox.Visible = false;
            SearchDepIDUpDown.Visible = false;

            visibleInput.Visible = true;
        }

        public void PickFromDropDownMenu()
        {
            switch (SearchHeroPickColumn.Text.ToLower())
            {
                case "id":
                    {
                        ChangeInputTo(SearchHeroIDUpDown);
                        break;
                    }
                case "name":
                    {
                        ChangeInputTo(SearchNameTextbox);
                        break;
                    }
                case "department_id":
                    {
                        ChangeInputTo(SearchDepIDUpDown);
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Please pick a thing from the drop down menu");
                        break;
                    }
            }
        }

        //public string Thing()
        //{
        //    switch (SearchHeroPickColumn.SelectedIndex)
        //    {
        //        case 0:
        //            {
        //                return SearchHeroIDUpDown.ToString();
        //            }
        //        case 1:
        //            {
        //                return SearchDepIDUpDown.ToString();
        //            }
        //        case 2:
        //            {
        //                return SearchNameTextbox.Text;
        //            }
        //        default:
        //            {
        //                MessageBox.Show("Please pick a thing from the drop down menu");
        //                return null;
        //            }
        //    }
        //}

        private void SearchForHero_Load(object sender, EventArgs e)
        {
            SearchHeroIDUpDown.Maximum = GetHighestID("superheroes", "Id");
            SearchDepIDUpDown.Maximum = GetHighestID("departments", "Department_Id");
        }

        public int GetHighestID(string table, string column)
        {
            string depIDQuery = $"SELECT {column} FROM {table} ORDER BY {column} DESC";
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

        
    }
}
