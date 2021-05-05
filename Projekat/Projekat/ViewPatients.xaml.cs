using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Controller;
using Repository;

namespace Projekat
{

    public partial class ViewPatients : Window
    {
        public PatientController patientController = new PatientController();

        public List<Patient> patients
        {
            get;
            set;
        }
        public Anamnesis anam = new Anamnesis();
        public ViewPatients()
        {
            InitializeComponent();

            PatientRepository patientRepository = new PatientRepository();
           List<Patient> patients = patientRepository.GetAll();
            dataGrid.ItemsSource = patients;
        }

        public void GiveAnamnesis(object sender, RoutedEventArgs e)
        {

            Patient p = (Patient)dataGrid.SelectedItems[0];
            CreateAnamnesis sc = new CreateAnamnesis(p);
            sc.Show();
            Close();


        }

        private void PrescribeMedicine(object sender, RoutedEventArgs e)
        {

            Patient p = (Patient)dataGrid.SelectedItems[0];
            Prescribe sc = new Prescribe(p);
            sc.Show();
            Close();


        }

        private void ReferralPatient(object sender, RoutedEventArgs e)
        {

            Patient p = (Patient)dataGrid.SelectedItems[0];
            ReferralPatientt sc = new ReferralPatientt(p);
            sc.Show();
            Close();


        }

        public void ScheduleAppointment(object sender, RoutedEventArgs e)
        {

            Patient p = (Patient)dataGrid.SelectedItems[0];
            ScheduleAppointment sc = new ScheduleAppointment(p);
            sc.Show();
            Close();

        }

        public void ScheduleOperation(object sender, RoutedEventArgs e)
        {

            Patient p = (Patient)dataGrid.SelectedItems[0];
            ScheduleOperation sc = new ScheduleOperation(p);
            sc.Show();
            Close();

        }

    }
}
