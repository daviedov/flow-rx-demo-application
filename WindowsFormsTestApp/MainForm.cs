using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsTestApp
{
    public partial class MainForm : Form
    {
        private List<Patient> patients = new List<Patient>
        {
            new Patient { FirstName = "John", LastName = "Doe", UniqueId = "P001", Phone = "1234567890", Address = "123 Main St" },
            new Patient { FirstName = "Jane", LastName = "Smith", UniqueId = "P002", Phone = "0987654321", Address = "456 Elm St" },
            new Patient { FirstName = "Alice", LastName = "Johnson", UniqueId = "P003", Phone = "1112223333", Address = "789 Oak St" },
            new Patient { FirstName = "Bob", LastName = "Brown", UniqueId = "P004", Phone = "4445556666", Address = "321 Pine St" },
            new Patient { FirstName = "Charlie", LastName = "Davis", UniqueId = "P005", Phone = "7778889999", Address = "654 Cedar St" },
            new Patient { FirstName = "David", LastName = "Miller", UniqueId = "P006", Phone = "2223334444", Address = "987 Birch St" },
            new Patient { FirstName = "Eve", LastName = "Wilson", UniqueId = "P007", Phone = "5556667777", Address = "741 Maple St" },
            new Patient { FirstName = "Frank", LastName = "Moore", UniqueId = "P008", Phone = "8889990000", Address = "852 Walnut St" },
            new Patient { FirstName = "Grace", LastName = "Taylor", UniqueId = "P009", Phone = "3334445555", Address = "963 Spruce St" },
            new Patient { FirstName = "Henry", LastName = "Anderson", UniqueId = "P010", Phone = "6667778888", Address = "147 Cherry St" }
        };

        public MainForm()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            dgvPatients.DataSource = null;
            dgvPatients.DataSource = patients;
            dgvPatients.Columns["Address"].Visible = false;
        }

        private void tsAddPatient_Click(object sender, EventArgs e)
        {
            var patientForm = new PatientForm();
            if (patientForm.ShowDialog() == DialogResult.OK)
            {
                patients.Add(patientForm.Patient);
                LoadPatients();
            }
        }

        private void dgvPatients_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                var selectedPatient = dgvPatients.SelectedRows[0].DataBoundItem as Patient;
                var patientForm = new PatientForm(selectedPatient);
                if (patientForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPatients();
                }
            }
        }
    }
}
