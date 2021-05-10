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
using Model;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for Reschedule.xaml
    /// </summary>
    public partial class RescheduleAppointmentPatientPage : Window
    {

        //public enum Priority { DATE, DOCTOR }

        public List<String> Termini { get; set; }
        public string SelektovanTermin { get; set; }
        public List<String> Doktori { get; set; }
        public string SelektovanDoktor { get; set; }
        public ScheduleAppointmentPatient.Priority priority;

        Appointment posrednik = new Appointment();

        public RescheduleAppointmentPatientPage(Appointment a)
        {
            InitializeComponent();
            this.DataContext = this;

            

            string[] termini = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8);
            Termini = new List<string>(termini);

            string[] doktori = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\doktoriak.txt", Encoding.UTF8);
            Doktori = new List<string>(doktori);

            posrednik.doctorUsername = a.doctorUsername;
            posrednik.roomName = a.roomName;
            posrednik.id = a.id;
            posrednik.StartTime = a.StartTime;
            posrednik.appointmentType = a.appointmentType;
            //  System.Windows.MessageBox.Show(a.roomName + " " + a.doctorUsername);           radi dobro

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            priority = ScheduleAppointmentPatient.Priority.DATE;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            priority = ScheduleAppointmentPatient.Priority.DOCTOR;
        }

        private void SendRequestButton_Click(object sender, RoutedEventArgs e)
        {

            DateTime newChoosenDate = new DateTime();

            String nesto = (string)Combobox1.SelectedItem;
            string[] preuzeto = nesto.Split(':');

            newChoosenDate = (DateTime)IzaberiDatum.SelectedDate;
            newChoosenDate = new DateTime(IzaberiDatum.SelectedDate.Value.Year, IzaberiDatum.SelectedDate.Value.Month, IzaberiDatum.SelectedDate.Value.Day, Convert.ToInt32(preuzeto[0]), Convert.ToInt32(preuzeto[1]), 0);

            string izabraniDoktor = (string)Combobox2.SelectedItem;


            // System.Windows.MessageBox.Show(posrednik.roomName + " " + posrednik.doctorUsername);

            AcceptRescheduleAppointmentPatientPage arapp = new AcceptRescheduleAppointmentPatientPage(posrednik, priority, newChoosenDate, izabraniDoktor);
            arapp.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
        }
    }
}
