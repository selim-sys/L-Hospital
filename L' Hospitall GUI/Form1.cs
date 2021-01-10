using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    
    public partial class Form1 : Form
    {
        List<Patient> patients;
        Patient Patient;
        public Form1()
        {
            patients = new List<Patient>();
            Patient = new Patient();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblFirstname_Click(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (var patient in patients)
            {
                if (patient.FirstName.ToLower()+patient.LastName.ToLower() == textFind.Text.ToLower())
                {
                    lblFind.Text = $"Name : {patient.FirstName + patient.LastName} \n Age : {patient.Age}\n Gender : {patient.Gender} \n PhoneNumber : {patient.PhoneNumber}\n Email : {patient.Email}\n Address : {patient.Address}\n Disease : {patient.Disease}\n";
                }
            }
        }

        private void lblSearcH_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Patient.FirstName = textFirstName.Text;
            Patient.LastName = textLastName.Text;
            Patient.PhoneNumber = textNumber.Text;
            Patient.Email = textEmail.Text;
            Patient.Address = textAddress.Text;
            Patient.Age = int.Parse(textAge.Text);
            Patient.Gender = comboGender.Text;
            Patient.Disease = textDepartment.Text;
            patients.Add(Patient);
            MessageBox.Show("Added Successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textFirstName.Text = "";
            textLastName.Text = "";
            textEmail.Text = "";
            textDepartment.Text = "";
            textAge.Text = "";
            textNumber.Text = "";
            comboGender.Text = "";
            textAddress.Text = "";
            lblFind.Text = "";
           
        }

        
    }
}
