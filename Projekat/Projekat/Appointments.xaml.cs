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

        public List<Appointment> appointments
        {
            get;
            set;
        }
        public Appointments()
        {
            InitializeComponent();
            AppointmentRepository appointmentRepository = new AppointmentRepository();
            List<Appointment> appointments = appointmentRepository.GetAll();
            dataGrid.ItemsSource = appointments;
           
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Appointment a = (Appointment)dataGrid.SelectedItems[0];
            appointmentController.Cancel(a);

            Appointments ap = new Appointments();
            ap.Show();
        }

        private void Reschedule(object sender, RoutedEventArgs e)
        {
           
            Appointment a = (Appointment)dataGrid.SelectedItems[0];
            ShowChangesA sc = new ShowChangesA(a);
            sc.Show();


        }

        private void Schedule(object sender, RoutedEventArgs e)
        {

        
            ScheduleAppointment sa = new ScheduleAppointment();
            sa.Show();


        }
        private void Anamnesiss(object sender, RoutedEventArgs e)
        {

            Anamnesiss sc = new Anamnesiss();
            sc.Show();


        }
    }
}
