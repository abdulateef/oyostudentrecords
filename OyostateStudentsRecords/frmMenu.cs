using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyostateStudentsRecords
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serverBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //if(Global.Status == "Yes")
            //{
            //    adminMenuToolStripMenuItem.Enabled = false;
            //}
        }

        private void registerStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmregisterstudent regstudent = new frmregisterstudent();
            regstudent.Show();
        }

        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmoption option = new frmoption();
            option.Show();
        }

        private void viewRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmviewrecords viewrecord = new frmviewrecords();
            viewrecord.Show();
        }

        private void localBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbackup backup = new frmbackup();
            backup.Show();

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About frmabout = new About();
            frmabout.Show();

        }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcreatenewuser newuser = new frmcreatenewuser();
            newuser.Show();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmupdate update = new frmupdate();
            update.Show();
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmresetpassword resetpass = new frmresetpassword();
            resetpass.Show();

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdelete delete = new frmdelete();
            delete.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
