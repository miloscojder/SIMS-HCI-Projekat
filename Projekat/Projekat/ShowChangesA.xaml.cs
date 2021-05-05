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
        int id;
        Room room = new Room();
        Patient patient = new Patient();
        public ShowChangesA(Appointment appoin)
        {
            InitializeComponent();

            AppointmentRepository appointmentRepository = new AppointmentRepository();
            List<Appointment> appointments = appointmentRepository.GetAll();
            dataGrid.ItemsSource = appointments;
            Date.Text = appoin.Date;
            Duration.Text = appoin.duration;
            String hours = "";
            String minutes = "";
            Hourss.Text = hours;
            Minutess.Text = minutes;
            String start = hours + ":" + minutes;
            start = appoin.timeStart;
            String hours1 = "";
            String minutes1 = "";
            Hours.Text = hours1;
            Minutes.Text = minutes1;
            String end = hours + ":" + minutes;
            end = appoin.endTime;
            id = appoin.id;
            room.Name = appoin.room.Name;
            patient.firstName = appoin.patient.firstName;
            patient.lastName = appoin.patient.lastName;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
        
            
            String date = Date.Text;
            String hours = Hours.Text;
            String minutes = Minutes.Text;
            String hourss = Hourss.Text;
            String minutess = Minutess.Text;
            String end = hours + ":" + minutes;
            String start = hourss + ":" + minutess;
            String duration = Duration.Text;


            Appointment a = new Appointment(id, date, start, duration, end, room, patient);
            appointmentController.RescheduleDoctor(a);

            Appointments ap = new Appointments();
            ap.Show();
            Close();


        }
    }
}
