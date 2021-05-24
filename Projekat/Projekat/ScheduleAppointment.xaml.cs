
using Model;
using System;
using Controller;
using Repository;
using System.Windows;
using System.Collections.Generic;

namespace Projekat
{
   
    public partial class ScheduleAppointment : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public PatientRepository patientRepository = new PatientRepository();
        public RoomRepository roomRepository = new RoomRepository();
        public ScheduleAppointment(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;
            Name.Text = p.firstName;
            Surname.Text = p.lastName;

        }

        private void Schedule(object sender, RoutedEventArgs e)
        {

            Appointment app = new Appointment();
            int ida = appointmentController.GenerateNewId();
            String date = Date.Text;
            String hours = Hours.Text;
            String minutes = Minutes.Text;
            String hourss = Hourss.Text;
            String minutess = Minutess.Text;
            String start = hours + ":" + minutes;
            String end = hourss + ":" + minutess;
            String duration = Duration.Text;


            Room r = new Room();
            r.Name = RoomName.Text;
           


            Patient p = new Patient();
            p.firstName = Name.Text;
            p.lastName = Surname.Text;

            app.AppointmentType = TypeOfAppointment.Examination;
            TypeOfAppointment type = app.AppointmentType;

             Appointment a = new Appointment(ida, date, start, duration, end, r, p, type);
            appointmentController.ScheduleDoctor(a);

         
             MessageBox.Show("Appointment scheduled!");
            this.Close();

            Appointments ap = new Appointments();
            ap.Show();
        }
    }
}
