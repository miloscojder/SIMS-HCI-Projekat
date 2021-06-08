
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
        public String patient;
        public List<String> Termini { get; set; }
        public string SelektovanTermin { get; set; }
        public List<String> types { get; set; }
        public String selekt { get; set; }
        public ScheduleAppointment(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;
            StaticEquipmentRepository staticEquipmentRepository = new StaticEquipmentRepository();
            List<StaticEquipment> staticEquipments = staticEquipmentRepository.GetAll();
            dataGrid1.ItemsSource = staticEquipments;

            patient = p.Username;

            string[] termini = File.ReadAllLines(@"C:\Users\krist\source\repos\SIMS-Projekat\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8);
            Termini = new List<string>(termini);

            string[] typess = File.ReadAllLines(@"C:/Users/krist/source/repos/SIMS-Projekat/Projekat/Projekat/Data/apptype.txt");
            types = new List<String>(typess) ;
        }

        private void Select(object sender, RoutedEventArgs e) 
        {
            
                StaticEquipment s = (StaticEquipment)dataGrid1.SelectedItems[0];

            RoomName.Text = s.room.Name;
        }

        private void Schedule(object sender, RoutedEventArgs e)
        {
            DateTime choosenDate = new DateTime();

            int ida = appointmentController.GenerateNewId();
           
            String duration = Duration.Text;
            
            String selektTermin = (String)Termin.SelectedItem;
            string[] preuzeto = selektTermin.Split(':');
            String selectType = (String)Type.SelectedItem;

            if(selectType == TypeOfAppointment.Examination.ToString())
            {
                ap.AppointmentType = TypeOfAppointment.Examination;
            } else
            {
                ap.AppointmentType = TypeOfAppointment.Operation;
            }

            choosenDate = (DateTime)IzaberiDatum.SelectedDate;
            choosenDate = new DateTime(IzaberiDatum.SelectedDate.Value.Year, IzaberiDatum.SelectedDate.Value.Month, IzaberiDatum.SelectedDate.Value.Day, Convert.ToInt32(preuzeto[0]), Convert.ToInt32(preuzeto[1]), 0);


            Appointment o = new Appointment(ida, choosenDate, duration, ap.AppointmentType, RoomName.Text, patient , DoctorWindow.loginDoctor.Username);
            appointmentController.ScheduleDoctor(o);

            MessageBox.Show("Appointment scheduled!");
            

            DoctorWindow app = new DoctorWindow(DoctorWindow.loginDoctor);
            app.Show();
            Close();

           
        }

        

        public void doThings(string param)
        {
            Appoi.Background = new SolidColorBrush(Color.FromRgb(32, 64, 128));
            Title = param;
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            DoctorWindow app = new DoctorWindow(DoctorWindow.loginDoctor);
            app.Show();
            Close();
        }

       
    }
}
