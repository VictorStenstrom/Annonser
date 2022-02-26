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
    public partial class Main2 : Form
    {
        public string _dtbcon = ConfigurationManager.ConnectionStrings["MyAd"].ConnectionString;
        SqlConnection con;
        int currentCategory = 0;
        string currentUserClick;
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAd();
        }

        private void btnShowAds_Click(object sender, EventArgs e)
        {
            GetData();
        }
        private void comCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCategory = comShowCategories.SelectedIndex;
            currentCategory++;
        }
        private void btnShowAllInfo_Click(object sender, EventArgs e)
        {
            string showAllInfo = "Select * from Ads where title = '" + currentUserClick + "'";
            ShowValues(showAllInfo);
        }
        private void btnSortPrice_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentUserClick = dataGridView1.Rows[e.RowIndex].Cells["title"].FormattedValue.ToString();
        }

        public Main2()
        {
            con = new SqlConnection(_dtbcon);
            InitializeComponent();
            ShowCaterories();
        }

        void GetData()
        {
            using (SqlCommand cmd = new SqlCommand("Select title, price, dateCreated from Ads", con))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        void SearchAd()
        {
            string userCmd = "Select distinct title from Ads, Categories where title like '" + txtSearch.Text + "%' and categoryId =" + currentCategory + "";
            using (SqlCommand cmd = new SqlCommand(userCmd, con))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
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

    }
}
