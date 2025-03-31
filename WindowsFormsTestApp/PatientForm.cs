using System.Windows.Forms;

namespace WindowsFormsTestApp
{
    public partial class PatientForm : Form
    {
        public Patient Patient { get; private set; }

        public PatientForm(Patient patient = null)
        {
            InitializeComponent();

            if (patient != null)
            {
                Patient = patient;
                txtFirstName.Text = patient.FirstName;
                txtLastName.Text = patient.LastName;
                txtUniqueId.Text = patient.UniqueId;
                txtPhone.Text = patient.Phone;
                txtAddress.Text = patient.Address;
            }
            else
            {
                Patient = new Patient();
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Patient.FirstName = txtFirstName.Text;
            Patient.LastName = txtLastName.Text;
            Patient.UniqueId = txtUniqueId.Text;
            Patient.Phone = txtPhone.Text;
            Patient.Address = txtAddress.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
