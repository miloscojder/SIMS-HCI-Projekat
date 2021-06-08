using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using Controller;
using Repository;

using System.Windows.Media;

namespace Projekat
{

    public partial class ViewPatients : Window
    {
        public PatientController patientController = new PatientController();
        public List<Patient> patient = new List<Patient>();
        public static Patient patientNew = new Patient();

        public List<Patient> patients
        {
            get;
            set;
        }
       
        public ViewPatients()
        {
            InitializeComponent();

            PatientRepository patientRepository = new PatientRepository();
           List<Patient> patients = patientRepository.GetAll();
            dataGridd.ItemsSource = patients;
            Name.Content = DoctorWindow.loginDoctor.firstName;
            Surname.Content = DoctorWindow.loginDoctor.lastName;
            Id.Content = DoctorWindow.loginDoctor.id;
            jmbg.Content = DoctorWindow.loginDoctor.Jmbg;
            Date.Content = DoctorWindow.loginDoctor.DateOfBirth;
            Email.Content = DoctorWindow.loginDoctor.EMail;
            Phone.Content = DoctorWindow.loginDoctor.PhoneNumber;
            Spec.Content = DoctorWindow.loginDoctor.Specialty;
        }

        public void doThings(string param)
        {
            HelpPatient.Background = new SolidColorBrush(Color.FromRgb(32, 64, 128));
            Title = param;
        }

        public void GiveAnamnesis(object sender, RoutedEventArgs e)
        {

            patientNew = (Patient)dataGridd.SelectedItems[0];
            CreateAnamnesis sc = new CreateAnamnesis(patientNew);
            sc.Show();
            Close();


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

       
        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }


        private void PrescribeMedicine(object sender, RoutedEventArgs e)
        {
            patientNew = (Patient)dataGridd.SelectedItems[0];
            Prescribe sc = new Prescribe(patientNew);
            sc.Show();
            Close();


        }

        private void ReferralPatient(object sender, RoutedEventArgs e)
        {

            patientNew = (Patient)dataGridd.SelectedItems[0];
            ReferralPatientt sc = new ReferralPatientt(patientNew);
            sc.Show();
            Close();


        }

        private void ReferralHospital(object sender, RoutedEventArgs e)
        {

            patientNew = (Patient)dataGridd.SelectedItems[0];
            ReferralPatientHospital sc = new ReferralPatientHospital(patientNew);
            sc.Show();
            Close();


        }


        public void ScheduleAppointment(object sender, RoutedEventArgs e)
        {

            patientNew = (Patient)dataGridd.SelectedItems[0];
            ScheduleAppointment sc = new ScheduleAppointment(patientNew);
            sc.Show();
            Close();

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            DoctorWindow sc = new DoctorWindow(DoctorWindow.loginDoctor);
            sc.Show();
            Close();


        }

        private void ReferralP(object sender, RoutedEventArgs e)
        {
            Referrals m = new Referrals();
            m.Show();
            Close();
        }
      

        private void Search(object sender, RoutedEventArgs e)
        {
            String name = SearchT.Text;
            String surname = SearchTe.Text;
            PatientRepository patientRepository = new PatientRepository();
            List<Patient> patients = patientRepository.GetAllName(name, surname);
            dataGridd.ItemsSource = patients;
            
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            PatientRepository patientRepository = new PatientRepository();
            List<Patient> patients = patientRepository.GetAll();
            dataGridd.ItemsSource = patients;
        }
    }
}
