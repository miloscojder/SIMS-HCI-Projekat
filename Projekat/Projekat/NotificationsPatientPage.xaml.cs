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
        List<Notification> posrednaListaNotifikacija = new List<Notification>();
        private List<Notification> notifications;
        NotifficationController notifficationController = new NotifficationController();

        public NotificationsPatientPage(Notification n) 
        {
            InitializeComponent();
            this.DataContext = this;

            notifications = notifficationController.GetAllNotifications();
            if (n != null)
            {
                notifications.Add(n);
            }

            lvNotificationList.ItemsSource = notifications;
            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\notificationsak.json", JsonConvert.SerializeObject(notifications));
        }

       
        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientMainPage pmp = new PatientMainPage();
            pmp.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null);
            npp.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
            pmrp.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
        }

        private void CreateButton_Click_6(object sender, RoutedEventArgs e)
        {
            CreateNotifficationPatientPage cnpp = new CreateNotifficationPatientPage();
            cnpp.Show();
        }

        private void UpdateButton_Click_7(object sender, RoutedEventArgs e)
        {
            if (lvNotificationList.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must choose at least one notiffication for update");
            }
            else
            {
                Notification selectedNotiffication = (Notification)lvNotificationList.SelectedItems;                
                UpdateNotifficationPatientPage unpp = new UpdateNotifficationPatientPage(selectedNotiffication);
                unpp.Show();

            }
        }

        private void DeleteButton_Click_8(object sender, RoutedEventArgs e)
        {
            if(lvNotificationList.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must select at least one notification to delete it");
            }
            else
            {
                Notification selectedNotification = (Notification)lvNotificationList.SelectedItems[0];
                List<Notification> allNotifications = notifficationController.GetAllNotifications();
                List<Notification> newNotifications = new List<Notification>();

                foreach(Notification n in allNotifications) {
                    if(n.Id != selectedNotification.Id) {
                        newNotifications.Add(n);
                    }
                }

                File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\notificationsak.json", JsonConvert.SerializeObject(newNotifications));
                MessageBox.Show("You deleted selected notification");
                this.Close();
            }
        }
    }
}
