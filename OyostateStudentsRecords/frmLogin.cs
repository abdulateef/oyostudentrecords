using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyostateStudentsRecords
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private string GetConnection()
        {
            return "DRIVER={MySQL ODBC 3.51 Driver};Server=localhost;Database=oyostudentsrecords;User Id=root;Password=";
        }

        private void controlvalidator() 
        {
            if(txtpassword.Text == "")
            {
                errorProvider1.SetError(txtpassword, "password cannot be empty");
            }
            if(comboBox1.SelectedText == "")
            {
                errorProvider1.SetError(comboBox1, "Select Your User Name");
            }
        }
        private void Loadusername()
        {

            try
            {
                OdbcConnection newconnectiononline = new OdbcConnection(GetConnection());
                newconnectiononline.Open();

                string query = ("Select username  FROM login");
                OdbcCommand command = new OdbcCommand(query, newconnectiononline);
                //DataTable dt = new DataTable();
                OdbcDataReader Dr = command.ExecuteReader();
                while(Dr.Read())
                {
                    query = Dr[0].ToString();
                    comboBox1.Items.Add(query);

                }

                Dr.Close();
            }
            catch(Exception ex)
            {

                MessageBox.Show("Opps!!! an error has occured please contact the admin");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Loadusername();
            
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            controlvalidator();

            if(comboBox1.Text == "")
            {
                MessageBox.Show("Username cannot be emoty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                comboBox1.Focus();
                return;
            }

            if(txtpassword.Text == "" )
            {
                MessageBox.Show("password cannot be emoty", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtpassword.Focus();
                return;
            }
            OdbcConnection connnect = new OdbcConnection(GetConnection());
            connnect.Open();
            string password = txtpassword.Text;
            string username = comboBox1.Text;
            OdbcCommand cmd = new OdbcCommand("select status,username,password from login where username='" + comboBox1.Text + "' AND password='" + txtpassword.Text + "'", connnect);
            OdbcDataReader reader = null;
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Global.Status = reader["status"].ToString();
            }
            Global.UserID = comboBox1.Text.ToString();
            if(dt.Rows.Count > 0)
            {
                frmMenu frmmenu = new frmMenu();
                frmmenu.Show();
                this.Hide();

            }
            else
            {
                DialogResult dialogResult = new  DialogResult();
                dialogResult = MessageBox.Show("Have you forgotten your password?", "Error LogIn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
               {
                   //
               }
                else if(dialogResult == DialogResult.No)
                {
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Hide();
                }

            }
            connnect.Close();
        }

       
        private void comboBox1_MouseHover(object sender, EventArgs e)
        {

            toolTip1 = new ToolTip();
            this.toolTip1.Show("Select your User Name", comboBox1);
        }

        private void txtpassword_MouseHover(object sender, EventArgs e)
        {
            toolTip1 = new ToolTip();
            this.toolTip1.Show("Enter your password", txtpassword);
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Dispose();
        }

        private void txtpassword_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Dispose();
        }

    }
}
