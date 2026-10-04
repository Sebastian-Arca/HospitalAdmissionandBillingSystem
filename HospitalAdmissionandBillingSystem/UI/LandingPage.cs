
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            PatientInformation patientForm = new PatientInformation(listBox1);
            patientForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LandingPage landingPage =new LandingPage();

            landingPage.Show();

            this.Hide();
        }
    }
}
