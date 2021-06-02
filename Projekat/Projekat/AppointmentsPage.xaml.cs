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
using Projekat.Model;
using Controller;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for Appointments.xaml
    /// </summary>
    public partial class AppointmentsPage : Window
    {
       
        public List<DateTime> activityTime = new List<DateTime>();
        public TimeSpan timeSpanForReset = new TimeSpan(7, 0, 0, 0, 0);
        public HospitalController hospitalController = new HospitalController();

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
            ScheduleAppointmentPatient sap = new ScheduleAppointmentPatient();
            sap.Show();
            this.Close();
        }

        private void CancButton_Click_1(object sender, RoutedEventArgs e)
        {

            Hospital hospitalData = new Hospital();
            hospitalData = hospitalController.GetAllHospitalsData();

            hospitalController.DeleteOutDatedActivities(activityTime,  timeSpanForReset);        // u ovo cu morati da ukljucim pacijenta

            if(hospitalData.activityCounter > 10)
            {
                MessageBox.Show("You are blocked because of spaming");
                PatientMainPage pmp = new PatientMainPage(PatientMainPage.prenosilac);
                pmp.Show();
                this.Close();
            }
            else
            {
               
                if (lvAppointmentsPatient.SelectedItems.Count < 1)
                {
                    MessageBox.Show("You must choose at least one appointment.");
                }
                else
                {
                    hospitalData.activityCounter++;
                    Appointment ac = (Appointment)lvAppointmentsPatient.SelectedItems[0];

                    List<Appointment> svi = new List<Appointment>();
                    List<Appointment> newSvi = new List<Appointment>();

                    svi = JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json"));

                    foreach (Appointment a in svi)
                    {
                        if (a.id != ac.id)
                        {
                            newSvi.Add(a);
                        }
                    }

                    File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json", JsonConvert.SerializeObject(newSvi));

                    hospitalController.WriteHospitalToJason(hospitalData);

                    MessageBox.Show("Vas pregled je otkazan.");
                    AppointmentsPage app = new AppointmentsPage(null);
                    app.Show();
                    this.Close();
                }
            }

        }

        private void RescButton_Click_2(object sender, RoutedEventArgs e)
        {

            if (lvAppointmentsPatient.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must select at least 1 appointment.");
            }
            else
            {
                Appointment ach = (Appointment)lvAppointmentsPatient.SelectedItems[0];

                TimeSpan timeSpan = new TimeSpan(1, 0, 0, 0, 0);

                if (ach.StartTime.Date - DateTime.Now.Date <= timeSpan)
                {
                    MessageBox.Show("Ne mozete promeniti ovaj termin.");

                    AppointmentsPage ap = new AppointmentsPage(null);
                    ap.Show();
                    this.Close();
                }
                else
                {
                    RescheduleAppointmentPatientPage rapp = new RescheduleAppointmentPatientPage(ach);
                    rapp.Show();
                    this.Close();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientMainPage pmp = new PatientMainPage(PatientMainPage.prenosilac);
            pmp.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null);
            npp.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
            pmrp.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
            this.Close();
        }
    }
}
