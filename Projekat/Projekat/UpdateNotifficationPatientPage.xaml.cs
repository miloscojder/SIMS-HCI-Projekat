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
using Model;
using Controller;
using System.IO;
using Newtonsoft.Json;

namespace Projekat
{    
    /// <summary>
    /// Interaction logic for UpdateNotifficationPatientPage.xaml
    /// </summary>
    public partial class UpdateNotifficationPatientPage : Window
    {
        public NotifficationController notifficationController = new NotifficationController();
        public List<string> Termini { get; set; }
        public Notification choosenNotification = new Notification();
        public List<Notification> notifications = new List<Notification>();
        public User prenosilac = new User();

        public UpdateNotifficationPatientPage(Notification selectedNotification, User loggedUser)
        {
            InitializeComponent();
            this.DataContext = this;
            prenosilac = loggedUser;

            OldNotificationNameTextBox.Text = selectedNotification.Name;
            OldNotificationDescTextBox.Text = selectedNotification.Description;
            OldNotificationDateTextBox.Text = Convert.ToString(selectedNotification.Date);
            OldNotificationDaysTextBox.Text = Convert.ToString(selectedNotification.DaysLeft);

            choosenNotification = selectedNotification;
                
            string[] termini = File.ReadAllLines(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8);
            Termini = new List<string>(termini);
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                notifications = notifficationController.GetAllNotifications();

                string hoursAndMinutes = (String)NewNotificationHourComboBox.SelectedItem;
                string[] choosenHours = hoursAndMinutes.Split(':');
                DateTime formedDate = new DateTime(NewNotificationDateDatePicker.SelectedDate.Value.Year, NewNotificationDateDatePicker.SelectedDate.Value.Month, NewNotificationDateDatePicker.SelectedDate.Value.Day, Convert.ToInt32(choosenHours[0]), Convert.ToInt32(choosenHours[1]), 0);

                choosenNotification = new Notification(NewNotificationNameTextBox.Text, NewNotificationDescTextBox.Text, formedDate, Convert.ToInt32(NewNotificationDaysTextBox.Text), choosenNotification.Id,prenosilac.Username);

                notifficationController.DeleteNotificationById(choosenNotification.Id);
                notifficationController.WriteNotificationsToJason(notifications);
               
                NotificationsPatientPage npp = new NotificationsPatientPage(choosenNotification,prenosilac);
                npp.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                notifficationController.IsDateChoosenCorectlly(choosenNotification.Date.Date);
            }
            
        }

        private void CancelButton_Click_1(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null,prenosilac);
            npp.Show();
            this.Close();
        }

    }
}
