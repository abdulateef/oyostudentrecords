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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 100000;
            timer1.Tick += timer1_Tick;

        }
        Timer showtime = new Timer();
        private void Form1_Shown(object sender, EventArgs e)
        {
            showtime = new Timer();
            showtime.Interval = 100000;
            showtime.Start();
            showtime.Tick += timer1_Tick;
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
            
        }

        void showtime_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showtime.Stop();
            this.Hide();
        }
    }
}
