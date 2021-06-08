using Model;
using System;
using System.Collections.Generic;
using System.Windows;
using Controller;
using Repository;
using System.IO;
using System.Text;
using System.Windows.Media;

namespace Projekat
{
  
    public partial class ShowChangesA : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public User u = new User();
        public List<String> Terminii { get; set; }
        public string SelektovanTermin { get; set; }
        public List<Appointment> appointments
        {
            get;
            set;
        }
        public Appointment ap = new Appointment();
     
        public ShowChangesA(Appointment appoin)
        {
            InitializeComponent();

            AppointmentRepository appointmentRepository = new AppointmentRepository();
            List<Appointment> appointments = appointmentRepository.GetAll();
            dataGrid.ItemsSource = appointments;
            Duration.Text = appoin.Duration;

            ap.id = appoin.id;
            ap.RoomName = appoin.RoomName;
            ap.PatientUsername = appoin.PatientUsername;
            ap.PatientUsername = appoin.PatientUsername;
            ap.AppointmentType = appoin.AppointmentType;
            

            string[] terminii = File.ReadAllLines(@"C:\Users\krist\source\repos\SIMS-Projekat\Projekat\Projekat\Data\terminiak.txt");
            Terminii = new List<string>(terminii);
         
        }

        public void doThings(string param)
        {
            Resch.Background = new SolidColorBrush(Color.FromRgb(32, 64, 128));
            Title = param;
        }
        private void Save(object sender, RoutedEventArgs e)
        {
            DateTime newchoosenDate = new DateTime();
            String duration = Duration.Text;

            String selektTermin = (String)Termini.SelectedItem;
            string[] preuzeto = selektTermin.Split(':');

            newchoosenDate = (DateTime)IzaberiDatum.SelectedDate;
            newchoosenDate = new DateTime(IzaberiDatum.SelectedDate.Value.Year, IzaberiDatum.SelectedDate.Value.Month, IzaberiDatum.SelectedDate.Value.Day, Convert.ToInt32(preuzeto[0]), Convert.ToInt32(preuzeto[1]), 0);


            Appointment a = new Appointment(ap.id, newchoosenDate, duration, ap.AppointmentType, ap.RoomName, ap.PatientUsername, DoctorWindow.loginDoctor.Username);
            appointmentController.RescheduleDoctor(a);

            DoctorWindow api = new DoctorWindow(DoctorWindow.loginDoctor);
            api.Show();
            Close();


        }

        private void Back(object sender, RoutedEventArgs e)
        {
            
            DoctorWindow a = new DoctorWindow(DoctorWindow.loginDoctor);
            a.Show();
            Close();
        }

     
    }
}
