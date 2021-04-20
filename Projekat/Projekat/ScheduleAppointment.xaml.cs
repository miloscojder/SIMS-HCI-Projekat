
using Model;
using System;
using Controller;
using Repository;
using System.Windows;


namespace Projekat
{
   
    public partial class ScheduleAppointment : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public PatientRepository patientRepository = new PatientRepository();
        public RoomRepository roomRepository = new RoomRepository();
        public ScheduleAppointment()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Schedule(object sender, RoutedEventArgs e)
        {

            Appointment app = new Appointment();
            String ida = Id.Text;
            String date = Date.Text;
            String hours = Hours.Text;
            String minutes = Minutes.Text;
            String hourss = Hourss.Text;
            String minutess = Minutess.Text;
            String start = hours + ":" + minutes;
            String end = hourss + ":" + minutess;
            String duration = Duration.Text;

            Room r = new Room();
           // r.Id = Idr.Text;
           // app.patient.SetId(Idr.Text);// = Idr.Text;
          //  app.room.Id = Idr.Text;


            Patient p = new Patient();
            p.Id=Idp.Text;
           // patientRepository.GetById(Idp.Text);

            //roomRepository.GetById(Idr.Text);


            Appointment a = new Appointment(ida, date, start, duration, end, r, p );
            appointmentController.ScheduleDoctor(a);

         
             MessageBox.Show("Appointment scheduled!");
            this.Close();

            Appointments ap = new Appointments();
            ap.Show();
        }
    }
}
