
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Controller;
using Model;

using Repository;

namespace Projekat
{

    public partial class DoctorWindow : Window
    {
        public PatientController patientController = new PatientController();
        public static Doctor loginDoctor = new Doctor();
        


        public DoctorWindow(Doctor doctor)
        {
            InitializeComponent();
            loginDoctor = doctor;

            AppointmentRepository appointmentRepository = new AppointmentRepository();
            List<Appointment> appointments = appointmentRepository.GetAllAppointmentsForDoctorUser(doctor);
            dataGridd.ItemsSource = appointments;
            Appi.IsSelected = true;

            Name.Content = doctor.firstName;
            Surname.Content = doctor.lastName;
            Id.Content = doctor.id;
            jmbg.Content = doctor.Jmbg;
            Date.Content = doctor.DateOfBirth.ToString();
            Email.Content = doctor.EMail;
            Phone.Content = doctor.PhoneNumber;
            Spec.Content = doctor.Specialty;
           
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

        private void ReferralP(object sender, RoutedEventArgs e)
        {
            Referrals m = new Referrals();
            m.Show();
            Close();
        }



        private void SeeAll(object sender, RoutedEventArgs e)
        {
            ViewMedecine m = new ViewMedecine();
            m.Show();
            Close();
        }

        private void Reschedule(object sender, RoutedEventArgs e)
        {
            Appointment a = (Appointment)dataGridd.SelectedItems[0];
            ShowChangesA sc = new ShowChangesA(a);
            sc.Show();
            Close();
        }

        private void Schedule(object sender, RoutedEventArgs e)
        {
            ViewPatients sc = new ViewPatients();
            sc.Show();
            Close();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Appointment a = (Appointment)dataGridd.SelectedItems[0];
            AppointmentRepository appointmentRepository = new AppointmentRepository();
            appointmentRepository.Cancel(a);
            DoctorWindow d = new DoctorWindow(loginDoctor);
            d.Show();
            Close();
        }
    }
}