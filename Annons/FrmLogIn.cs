using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Annons
{
    public partial class FrmLogIn : Form
    {   
        public string _dtbcon = ConfigurationManager.ConnectionStrings["MyAd"].ConnectionString;
        SqlConnection con;

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string cmd = "select * from users where userName ='" + txtUsername.Text + "' and password= '" + txtPassword.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            
            if (dt.Rows.Count == 1)
            {
                Main FrmMain = new Main(txtUsername.Text);
                this.Hide();
                FrmMain.Show();
            }
            else
           
            MessageBox.Show("Fel användarnamn eller lösenord");
            ClearFields();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            Main2 FrmMain2 = new Main2();
            this.Hide();
            FrmMain2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != String.Empty && txtPassword.Text != String.Empty && txtSurname.Text != String.Empty && 
                txtAdress.Text != String.Empty && txtPhonenumb.Text != String.Empty)
            {
                string userCmd = "Insert into Users (userName, userSurname, address, pNumber, password) values('" + txtUsername.Text +
                "','" + txtSurname.Text + "','" + txtAdress.Text + "','" + txtPhonenumb.Text + "','" + txtPassword.Text + "')";
                using (SqlCommand cmd = new SqlCommand(userCmd, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                ClearFields();
                MessageBox.Show("Användarkonto skapat");
            }
            else
                MessageBox.Show("Fyll i alla fält");
        }
        public FrmLogIn()
        {
            con = new SqlConnection(_dtbcon);
            InitializeComponent();
        }
        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtSurname.Clear();
            txtAdress.Clear();
            txtPhonenumb.Clear();
        }
    }
}
