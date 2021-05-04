using Model;
using System;
using System.Collections.Generic;
using System.Windows;
using Controller;
using Repository;
namespace Projekat
{
  
    public partial class ShowChangesA : Window
    {
        public AppointmentController appointmentController = new AppointmentController();

        public List<Appointment> appointments
        {
            get;
            set;
        }
        public ShowChangesA(Appointment appoin)
        {
            InitializeComponent();

            AppointmentRepository appointmentRepository = new AppointmentRepository();
            List<Appointment> appointments = appointmentRepository.GetAll();
            dataGrid.ItemsSource = appointments;
            
        }

        private void Save(object sender, RoutedEventArgs e)
        {
        
            String ida = Id.Text;
            String date = Date.Text;
            String hours = Hours.Text;
            String minutes = Minutes.Text;
            String hourss = Hourss.Text;
            String minutess = Minutess.Text;
            String start = hours + ":" + minutes;
            String end = hourss + ":" + minutess;
            String duration = Duration.Text;


           // Appointment a = new Appointment(ida, date, start, duration, end);
           // appointmentController.RescheduleDoctor(a);

            Appointments ap = new Appointments();
            ap.Show();


        }
    }
}
