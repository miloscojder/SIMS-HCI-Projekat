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
        public User u = new User();
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
            Duration.Text = appoin.Duration;
            String hours = "";
            hours = appoin.TimeStart;
            Hourss.Text = hours;
            String hours1 = "";
            hours1 = appoin.EndTime;
            Hours.Text = hours1;
            id = appoin.id;
            room.Name = appoin.RoomName;
            patient.Username = appoin.PatientUsername;
          //  patient.lastName = appoin.Patient.lastName;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
        
            
            String date = Date.Text;
            String hours = Hours.Text;
            String hourss = Hourss.Text;
            String end = hours;
            String start = hourss;
            String duration = Duration.Text;

            string type = "Examination";


           // Appointment a = new Appointment(id, date, start, duration, end, room, patient, type);
           // appointmentController.RescheduleDoctor(a);

            DoctorWindow ap = new DoctorWindow(DoctorWindow.loginDoctor);
            ap.Show();
            Close();


        }

        private void Back(object sender, RoutedEventArgs e)
        {
            
            DoctorWindow a = new DoctorWindow(DoctorWindow.loginDoctor);
            a.Show();
            Close();
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }
    }
}
