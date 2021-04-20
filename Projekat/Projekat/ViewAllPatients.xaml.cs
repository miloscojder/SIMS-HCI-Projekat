using Model;
using Repository;
using Controller;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for ViewAllPatients.xaml
    /// </summary>
    public partial class ViewAllPatients : Window
    {
        private PatientController patient_controller = new PatientController();

        public List<Patient> patients { get; set; }
       // public List<Patient> patients = new List<Patient>();
        public ViewAllPatients()
        {
            InitializeComponent();
            PatientRepository patient_repository = new PatientRepository();
            List<Patient> patients = patient_repository.GetAll();

            lvDataBinding.ItemsSource = patients;
        }

        private void Delete_Patient(object sender, RoutedEventArgs e)
        {

            try
            {
                Patient patient = (Patient)lvDataBinding.SelectedItems[0];
                // patients.Remove(patient);
                 lvDataBinding.Items.Refresh();
                 patient_controller.Delete(patient);
                MessageBox.Show("Patient Succesfuly deleted!");
            }

                /*Patient deletePatient = (Patient)lvDataBinding.SelectedItems[0]; S
            patients.Remove(deletePatient);
                lvDataBinding.Items.Refresh();
                storage.Delete(deletePatient);
                MessageBox.Show("Patient Succesfuly deleted!");*/
       
           catch
            {
                MessageBox.Show("You have to select a patient to delete!");
            }
        }

        private void UpdatedPatient(object sender, RoutedEventArgs e)
        {

        }
    }
}
