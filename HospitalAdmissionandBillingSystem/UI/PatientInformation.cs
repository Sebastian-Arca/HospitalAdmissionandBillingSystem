using System;
using System.Windows.Forms;

namespace UI
{
    public partial class PatientInformation : Form
    {
        private LandingPage landing;

        public PatientInformation(LandingPage landingPage)
        {
            InitializeComponent();
            landing = landingPage;
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text + "    " + textBox1.Text;
            string room = textBox7.Text;
            string type = comboBox1.Text;
            string admissionDate =
                dateTimePicker1.Value.ToShortDateString();
            string status = "Pending";

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter the patient's name.");
                return;
            }

            landing.AddPatient(
                name, room, type, admissionDate, status
            );

            MessageBox.Show("Patient information saved!");

            landing.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            landing.Show();
            this.Hide();
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            dateTimePicker1.Value = DateTime.Today;
        }
    }
}