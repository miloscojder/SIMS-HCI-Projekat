using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
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
            dataGridd.ItemsSource = patients;
        }

        public void GiveAnamnesis(object sender, RoutedEventArgs e)
        {

            Patient p = (Patient)dataGridd.SelectedItems[0];
            CreateAnamnesis sc = new CreateAnamnesis(p);
            sc.Show();
            Close();


        }
        

        private void Aprove(object sender, RoutedEventArgs e)
        {

        }

        private void SeeAll(object sender, RoutedEventArgs e)
        {
            ViewMedecine m = new ViewMedecine();
            m.Show();
            Close();
        }

        private void Patients(object sender, RoutedEventArgs e)
        {
            ViewPatients m = new ViewPatients();
            m.Show();
            Close();
        }
        private void AnamnesisClick(object sender, RoutedEventArgs e)
        {
            Anamnesiss m = new Anamnesiss();
            m.Show();
            Close();
        }

        private void Prescribe(object sender, RoutedEventArgs e)
        {
            Prescriptions m = new Prescriptions();
            m.Show();
            Close();
        }

        private void AppointmentClick(object sender, RoutedEventArgs e)
        {
            Appointments m = new Appointments();
            m.Show();
            Close();
        }

        private void OperationsClick(object sender, RoutedEventArgs e)
        {
            Operationss m = new Operationss();
            m.Show();
            Close();
        }
        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }


        private void PrescribeMedicine(object sender, RoutedEventArgs e)
        {

            Patient p = (Patient)dataGridd.SelectedItems[0];
            Prescribe sc = new Prescribe(p);
            sc.Show();
            Close();


        }

        private void ReferralPatient(object sender, RoutedEventArgs e)
        {

            Patient p = (Patient)dataGridd.SelectedItems[0];
            ReferralPatientt sc = new ReferralPatientt(p);
            sc.Show();
            Close();


        }

        private void ReferralHospital(object sender, RoutedEventArgs e)
        {

            Patient p = (Patient)dataGridd.SelectedItems[0];
            ReferralPatientHospital sc = new ReferralPatientHospital(p);
            sc.Show();
            Close();


        }


        public void ScheduleAppointment(object sender, RoutedEventArgs e)
        {

            Patient p = (Patient)dataGridd.SelectedItems[0];
            ScheduleAppointment sc = new ScheduleAppointment(p);
            sc.Show();
            Close();

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            User u = new User();
            DoctorWindow sc = new DoctorWindow(u);
            sc.Show();
            Close();


        }

        private void ReferralP(object sender, RoutedEventArgs e)
        {
            Referrals m = new Referrals();
            m.Show();
            Close();
        }
        public void ScheduleOperation(object sender, RoutedEventArgs e)
        {

            Patient p = (Patient)dataGridd.SelectedItems[0];
            ScheduleOperation sc = new ScheduleOperation(p);
            sc.Show();
            Close();

        }

    }
}
