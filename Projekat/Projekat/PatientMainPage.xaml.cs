using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.IO;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for PatientMainPage.xaml
    /// </summary>
    public partial class PatientMainPage : Window
    {
        public PatientMainPage()
        {
            InitializeComponent();



            List<Notification> notifications = new List<Notification>();
            notifications = JsonConvert.DeserializeObject<List<Notification>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\notificationsak.json"));


            foreach (Notification n in notifications)
            {
                if (((n.Date.Date == DateTime.Now.Date) && (DateTime.Now.Hour == (n.Date.Hour - 3)) && (DateTime.Now.Minute == n.Date.Minute)) || ((n.Date.Date == DateTime.Now.Date) && (DateTime.Now.Hour >= (n.Date.Hour - 3))))
                {
                    MessageBox.Show("Vase danasnje obavestenje je: " + n.Name + " " + n.Description);
                }
            }


            /* treba da postoje home, appointments, medical record ,profile ,notifications, questions, info, hospital pictures with link
             
                boja neka svetlo plava/svetlo zelena
                slika neke random bolnice koja vodi do njenog cenovnika i ocenjivanje nje i doktora njenih, za sada to moze biti dugme, za ovu kontrolnu tacku, to cu poslijes kontat
                
                

            */


        }
        /*
        private void MyAppointmentsButton_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
        }*/

        private void SeeHospitalButton_Click(object sender, RoutedEventArgs e)
        {
            HospitalViewPatientPage hvpp = new HospitalViewPatientPage(null);
            hvpp.Show();
        }

        private void PatientProfileButton_Click(object sender, RoutedEventArgs e)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
        }

        private void NotificationButton_Click_1(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage();
            npp.Show();
        }

        private void HomePageButton_Click(object sender, RoutedEventArgs e)
        {
            PatientMainPage pmp = new PatientMainPage();
            pmp.Show();
        }

        private void MyAppointmentsButton_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
        }

        private void MedicalRecordButton_Click(object sender, RoutedEventArgs e)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
            pmrp.Show();
        }

        private void QandAButton_Click(object sender, RoutedEventArgs e)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
        }
    }
}
