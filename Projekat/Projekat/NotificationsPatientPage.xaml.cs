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
using Controller;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for NotificationsPatientPage.xaml
    /// </summary>
    public partial class NotificationsPatientPage : Window
    {           
        public List<Notification> thisPatientsNotifications;
        public NotifficationController notifficationController = new NotifficationController();
        public List<Notification> allNotifications;

        public NotificationsPatientPage(Notification newNotification)     //user ce biti globalan na main page i odatle cu ga uveg pozivati
        {
            InitializeComponent();
            this.DataContext = this;
          

            allNotifications = notifficationController.GetAllNotifications();           
            notifficationController.DeleteOutOfBoundsNotifications(allNotifications);   // do this in GetAllNotifications() in repository
            notifficationController.ShouldIAdd(newNotification, allNotifications);      // wont be needed if you save there
            notifficationController.WriteNotificationsToJason(allNotifications);

            thisPatientsNotifications = notifficationController.FindNotificationsByPatientUsername(PatientMainPage.prenosilac.Username);
            lvNotificationList.ItemsSource = thisPatientsNotifications;
        }

       
        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
            this.Close();
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

        private void CreateButton_Click_6(object sender, RoutedEventArgs e)
        {
            CreateNotifficationPatientPage cnpp = new CreateNotifficationPatientPage();
            cnpp.Show();
            this.Close();
        }

        private void UpdateButton_Click_7(object sender, RoutedEventArgs e)
        {     
            try 
            {
                Notification selectedNotiffication = (Notification)lvNotificationList.SelectedItems[0];                
                UpdateNotifficationPatientPage unpp = new UpdateNotifficationPatientPage(selectedNotiffication);
                unpp.Show();
                this.Close();
            }
            catch (System.ArgumentOutOfRangeException exeption)
            {
                MessageBox.Show("Item not selected");
            }
        }

        private void DeleteButton_Click_8(object sender, RoutedEventArgs e)
        {            
            try
            {
                Notification selectedNotification = (Notification)lvNotificationList.SelectedItems[0];
                List<Notification> allNotifications = notifficationController.GetAllNotifications();

                notifficationController.DeleteNotificationById(selectedNotification.Id);
                notifficationController.WriteNotificationsToJason(allNotifications);

                MessageBox.Show("You deleted selected notification");
                PatientMainPage pmp = new PatientMainPage(PatientMainPage.prenosilac);
                pmp.Show();
                this.Close();
            }
            catch (System.ArgumentOutOfRangeException exeption)
            {
                MessageBox.Show("Item not selected");
            }
        }
    }
}
