
using System;
using System.Windows.Forms;

namespace UI
{

    public partial class PatientInformation : Form
    {
        private ListBox patientList;

        public PatientInformation(ListBox list)
        {
            InitializeComponent();
            patientList = list;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string patientInfo = textBox4.Text + " - " + textBox1.Text;

            patientList.Items.Add(patientInfo);

            MessageBox.Show("Patient information saved!");

            this.Close();
        }
    }
}
