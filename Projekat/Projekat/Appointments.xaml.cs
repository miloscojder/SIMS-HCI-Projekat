using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using Repository;
using Controller;


namespace Projekat
{

    public partial class Appointments : Window
    {
        public AppointmentController appointmentController = new AppointmentController();

        public List<Appointment> appointmentss
        {
            get;
            set;
        }
        public PatientController patientController = new PatientController();

        public List<Patient> patients
        {
            get;
            set;
        }
        public Anamnesis anam = new Anamnesis();
        public Appointments()
        {
            InitializeComponent();

            AppointmentRepository appointmentRepository = new AppointmentRepository();
            List<Appointment> appointments = appointmentRepository.GetAll();
            dataGridic.ItemsSource = appointments;
           

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            User u = new User();
            DoctorWindow sc = new DoctorWindow(u);
            sc.Show();
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
            ViewMedicines m = new ViewMedicines();
            m.Show();
            Close();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Appointment a = (Appointment)dataGridic.SelectedItems[0];
            appointmentController.Cancel(a);

            Appointments ap = new Appointments();
            ap.Show();
            Close();
        }

        private void Reschedule(object sender, RoutedEventArgs e)
        {
           
            Appointment a = (Appointment)dataGridic.SelectedItems[0];
            ShowChangesA sc = new ShowChangesA(a);
            sc.Show();
            Close();


        }

        private void Schedule(object sender, RoutedEventArgs e)
        {
            ViewPatients sa = new ViewPatients();
            sa.Show();
            Close();


        }
        private void Anamnesiss(object sender, RoutedEventArgs e)
        {

            Anamnesiss sc = new Anamnesiss();
            sc.Show();


        }

        
    }
}
