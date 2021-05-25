
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Controller;
using Model;
using Repository;

namespace Projekat
{

    public partial class DoctorWindow : Window
    {
        public PatientController patientController = new PatientController();
        

        public List<Patient> patients
        {
            get;
            set;
        }
        public Anamnesis anam = new Anamnesis();
        public DoctorWindow(User user)
        {
            InitializeComponent();

            AppointmentRepository appointmentRepository = new AppointmentRepository();
            List<Appointment> appointments = appointmentRepository.GetAll();
            dataGridd.ItemsSource = appointments;

            OperationRepository operationRepository = new OperationRepository();
            List<Operations> operations = operationRepository.GetAll();
            dataGridd1.ItemsSource = operations;

            Name.Content = user.firstName;
            Surname.Content = user.lastName;
            Id.Content = user.id;
            jmbg.Content = user.Jmbg;
            Date.Content = user.DateOfBirth;
            Email.Content = user.EMail;
            Phone.Content = user.PhoneNumber;
            Spec.Content = user.doctor.Specialty;

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

        private void ReferralP(object sender, RoutedEventArgs e)
        {
            Referrals m = new Referrals();
            m.Show();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RequestCRUD rq = new RequestCRUD();
            rq.Show();
            Close();
        }
    }
}