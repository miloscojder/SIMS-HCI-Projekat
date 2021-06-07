
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Controller;
using Repository;

namespace Projekat
{
   
    public partial class ScheduleAppointment : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public StaticEquipmentController staticEquipmentController = new StaticEquipmentController();
        public Appointment ap = new Appointment();
        public Patient patient = new Patient();
        public Room room = new Room();
        public List<String> types { get; set; }
        public String selekt { get; set; }
        public ScheduleAppointment(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;
            StaticEquipmentRepository staticEquipmentRepository = new StaticEquipmentRepository();
            List<StaticEquipment> staticEquipments = staticEquipmentRepository.GetAll();
            dataGrid1.ItemsSource = staticEquipments;

            patient = p;

            string[] typess = File.ReadAllLines(@"C:/Users/krist/source/repos/SIMS-Projekat/Projekat/Projekat/Data/apptype.txt");
            types = new List<String>(typess) ;
        }

        private void Select(object sender, RoutedEventArgs e) 
        {
            
                StaticEquipment s = (StaticEquipment)dataGrid1.SelectedItems[0];

            RoomName.Text = s.room.Name;
            room = s.room;
        }

        private void Schedule(object sender, RoutedEventArgs e)
        {


            int ida = appointmentController.GenerateNewId();
            String date = Date.Text;
            String hours = Hours.Text;
            String hourss = Hourss.Text;
            String start = hours;
            String end = hourss;
            String duration = Duration.Text;

            String selectType = (String)Type.SelectedItem;

            if(selectType == TypeOfAppointment.Examination.ToString())
            {
                ap.AppointmentType = TypeOfAppointment.Examination;
            } else
            {
                ap.AppointmentType = TypeOfAppointment.Operation;
            }
            
            
            Appointment o = new Appointment(ida, date, start, duration, end, room.Name, patient.Username, DoctorWindow.loginDoctor.Username, ap.AppointmentType);
            appointmentController.ScheduleDoctor(o);

            MessageBox.Show("Appointment scheduled!");
            this.Close();

            DoctorWindow app = new DoctorWindow(DoctorWindow.loginDoctor);
            app.Show();
            Close();

           
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            DoctorWindow app = new DoctorWindow(DoctorWindow.loginDoctor);
            app.Show();
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
