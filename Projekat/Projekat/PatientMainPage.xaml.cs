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
using Repository;
using Controller;
using Service;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for PatientMainPage.xaml
    /// </summary>
    public partial class PatientMainPage : Window
    {
        NotifficationController notifficationController = new NotifficationController();
        List<Notification> notifications;
        User prenosilac = new User();

        public PatientMainPage(User loggedUser)
        {
            InitializeComponent();
           prenosilac = loggedUser;

        //    MessageBox.Show(passenger.Username);

            notifications = notifficationController.GetAllNotifications();
            notifficationController.IsItTime(notifications);           
        }
       

        private void SeeHospitalButton_Click(object sender, RoutedEventArgs e)
        {
            HospitalViewPatientPage hvpp = new HospitalViewPatientPage(null);
            hvpp.Show();
            this.Close();
        }

        private void PatientProfileButton_Click(object sender, RoutedEventArgs e)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
            this.Close();
        }

        private void NotificationButton_Click_1(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null,prenosilac);
            npp.Show();
            this.Close();
        }

        private void HomePageButton_Click(object sender, RoutedEventArgs e)
        {
            PatientMainPage pmp = new PatientMainPage(null);
            pmp.Show();
            this.Close();
        }

        private void MyAppointmentsButton_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null, prenosilac);
            ap.Show();
            this.Close();
        }

        private void MedicalRecordButton_Click(object sender, RoutedEventArgs e)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage(prenosilac);
            pmrp.Show();
            this.Close();
        }

        private void QandAButton_Click(object sender, RoutedEventArgs e)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
            this.Close();
        }
    }
}
