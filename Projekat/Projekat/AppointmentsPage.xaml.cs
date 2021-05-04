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
using Newtonsoft.Json;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for Appointments.xaml
    /// </summary>
    public partial class AppointmentsPage : Window

    {
        public AppointmentsPage(Appointment a)
        {
            InitializeComponent();
            this.DataContext = this;

            List<Appointment> spisak = new List<Appointment>();
            spisak = getAppointments();

            if (a != null)
            {
                spisak.Add(a);
            }

            lvAppointmentsPatient.ItemsSource = spisak;


            //Ovo ne radi skroz dobro ali radi
            List<Notification> notifications = new List<Notification>();
            notifications = JsonConvert.DeserializeObject<List<Notification>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\notificationsak.json"));


            foreach (Notification n in notifications)
            {
                if (((n.Date.Date == DateTime.Now.Date) && (DateTime.Now.Hour == (n.Date.Hour - 3)) && (DateTime.Now.Minute == n.Date.Minute)) || ((n.Date.Date == DateTime.Now.Date) && (DateTime.Now.Hour >= (n.Date.Hour - 3))))
                {
                    MessageBox.Show("Vase danasnje obavestenje je: " + n.Name + " " + n.Description);
                }
            }

            SaveAppointments(spisak);

        }

        //morace da stoji u drugom sloju
        private static void SaveAppointments(List<Appointment> spisak)
        {
            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json", JsonConvert.SerializeObject(spisak));
        }

        //morace da stoji u drugom sloju
        private static List<Appointment> getAppointments()
        {
            return JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json"));
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ScheduleAppointmentPatient sa = new ScheduleAppointmentPatient();
            sa.Show();
        }

        private void CancButton_Click_1(object sender, RoutedEventArgs e)
        {
            Appointment ac = (Appointment)lvAppointmentsPatient.SelectedItems[0];


            List<Appointment> svi = new List<Appointment>();
            List<Appointment> newSvi = new List<Appointment>();

            svi = JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json"));


            foreach (Appointment a in svi)
            {
                if (a.Id != ac.Id)
                {
                    newSvi.Add(a);
                }
            }

            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json", JsonConvert.SerializeObject(newSvi));

            MessageBox.Show("Vas pregled je otkazan.");
            this.Close();

        }

        private void RescButton_Click_2(object sender, RoutedEventArgs e)
        {

            Appointment ach = (Appointment)lvAppointmentsPatient.SelectedItems[0];

            TimeSpan timeSpan = new TimeSpan(1, 0, 0, 0, 0);

            if (ach.StartTime.Date - DateTime.Now.Date <= timeSpan)
            {
                MessageBox.Show("Ne mozete promeniti ovaj termin.");


                AppointmentsPage ap = new AppointmentsPage(null);
                ap.Show();
            }
            else
            {
                RescheduleAppointmentPatientPage rapp = new RescheduleAppointmentPatientPage(ach);
                rapp.Show();
            }
        }

        private void NotificationsButton_Click(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage();
            npp.Show();
        }
    }
}
