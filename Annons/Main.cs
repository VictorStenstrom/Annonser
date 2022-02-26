using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Annons
{
    public partial class Main : Form
    {
        public string _dtbcon = ConfigurationManager.ConnectionStrings["MyAd"].ConnectionString;
        string _userIdInput;
        string currentId;
        string currentUserClick;
        int currentCategory = 0;
        SqlConnection con;

        private void cmdSpara_Click(object sender, EventArgs e)
        {
            if (currentCategory > 0)
            {
                SetData();
                GetData();
            }
            else
                MessageBox.Show("Vänligen välj kategori");
        }
        
        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }


        private void cmdSearchAd_Click(object sender, EventArgs e)
        {
            SearchAd();
        }

   
        private void cmdShowAd_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void comShowCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCategory = comShowCategories.SelectedIndex;
            currentCategory++;
        }
        private void btnSortPrice_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount > 0)
            {
                this.dataGridView1.Sort(this.dataGridView1.Columns["price"], ListSortDirection.Ascending);
            }
        }
        private void btnSortDate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                this.dataGridView1.Sort(this.dataGridView1.Columns["dateCreated"], ListSortDirection.Ascending);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                currentId = row.Cells["Id"].Value.ToString();
                txtTitle.Text = row.Cells["title"].Value.ToString();
                txtDescription.Text = row.Cells["description"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();

            }
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            currentUserClick = dataGridView1.Rows[e.RowIndex].Cells["title"].FormattedValue.ToString();
        }
        private void cmdShowInfo_Click(object sender, EventArgs e)
        {
            string showAllInfo = "Select * from Ads where title = '" + currentUserClick + "'";
            ShowValues(showAllInfo);
        }

        public Main(string userInput)
        {
            _userIdInput = userInput;
            con = new SqlConnection(_dtbcon);
            InitializeComponent();
            ShowCaterories();
        }

        private string UserId
        {
            get { return this._userIdInput; }
            set { this._userIdInput = value; }
        }

        void SetData()
        {
            if (txtUserNameInput.Text == _userIdInput)
            {
                string DataSetCmd = "Insert into Ads (title,description,price,categoryId,userId) values('" + txtTitle.Text + "','" +
                                  txtDescription.Text + "'," + txtPrice.Text + "," + currentCategory + ", (SELECT Id FROM Users WHERE userName ='" + UserId + "'))";
                ExecuteSqlCmd(DataSetCmd);
            }
            else
                MessageBox.Show("Skriv in ditt användarnamn för verifiering");
        }

        void UpdateData()
        {
            if (txtUserNameInput.Text == _userIdInput)
            {
                string updateCmd = "Update Ads set title = '" + txtTitle.Text + "' where Id = " + currentId +
                                 "Update Ads set description = '" + txtDescription.Text + "' where Id = " + currentId +
                                 "Update Ads set price = '" + txtPrice.Text + "' where Id = " + currentId + "";
                ExecuteSqlCmd(updateCmd);
                GetData();
            }
            else
                MessageBox.Show("Skriv in ditt användarnamn för verifiering");
        }
       
        void DeleteData()
        {
            if (txtUserNameInput.Text == _userIdInput)
            {
                string deleteCmd = "Delete from Ads where Id =" + currentId + "";
                ExecuteSqlCmd(deleteCmd);
                GetData();
            }
            else
                MessageBox.Show("Skriv in ditt användarnamn för verifiering");
        }

        void GetData()
        {
            string getDataCmd = "Select Id, title, description, price, dateCreated from Ads";
            ShowValues(getDataCmd);
        }

        void ShowCaterories()
        {
            using (SqlCommand cmd = new SqlCommand("Select * from Categories", con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comShowCategories.Items.Add(reader.GetValue(1));
                    }
                con.Close();
                }
            }
            ClearFields();
        }

        void SearchAd()
        {
            string searchCmd = "Select distinct Ads.Id, title, description, price from Ads, Categories where title like '" + txtSearch.Text +
                               "%' and categoryId =" + currentCategory + "";
            ShowValues(searchCmd);
            ClearFields();
        }

        void ExecuteSqlCmd(string cmdInput)
        {
            using (SqlCommand cmd = new SqlCommand(cmdInput, con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            ClearFields();
        }

        void ShowValues(string cmdInput)
        {
            using (SqlCommand cmd = new SqlCommand(cmdInput, con))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        void ClearFields()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtSearch.Clear();
            txtUserNameInput.Clear();
        }
    }
}