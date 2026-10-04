using System;
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
            PatientInformation patientForm = new PatientInformation(this);
            patientForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        public void AddPatient(string name, string room,
            string type, string admissionDate, string status)
        {
            dataGridView1.Rows.Add(
                name, room, type, admissionDate, status
            );
        }
    }
}