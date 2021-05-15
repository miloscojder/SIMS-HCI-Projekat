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
        NotifficationController notifficationController = new NotifficationController();
        public List<string> Termini { get; set; }
        Notification posrednik = new Notification();
        List<Notification> notifications = new List<Notification>();

        public UpdateNotifficationPatientPage(Notification chossenNotification)
        {
            InitializeComponent();
            this.DataContext = this;

            OldNotificationNameTextBox.Text = chossenNotification.Name;
            OldNotificationDescTextBox.Text = chossenNotification.Description;
            OldNotificationDateTextBox.Text = Convert.ToString(chossenNotification.Date);
            OldNotificationDaysTextBox.Text = Convert.ToString(chossenNotification.DaysLeft);

            posrednik = chossenNotification;
                
            string[] termini = File.ReadAllLines(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8);
            Termini = new List<string>(termini);
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

            notifications = notifficationController.GetAllNotifications();

            string hoursAndMinutes = (String)NewNotificationHourComboBox.SelectedItem;
            string[] choosenHours = hoursAndMinutes.Split(':');
            DateTime formedDate = new DateTime(NewNotificationDateDatePicker.SelectedDate.Value.Year, NewNotificationDateDatePicker.SelectedDate.Value.Month, NewNotificationDateDatePicker.SelectedDate.Value.Day, Convert.ToInt32(choosenHours[0]), Convert.ToInt32(choosenHours[1]), 0);

            posrednik.Name = NewNotificationNameTextBox.Text;
            posrednik.Description = NewNotificationDescTextBox.Text;
            posrednik.Date = formedDate;
            posrednik.DaysLeft = Convert.ToInt32(NewNotificationDaysTextBox.Text);

            if(posrednik.Date.Date < DateTime.Now.Date)
            {
                MessageBox.Show("You cant choose date in past");
            }

            for (int i = 0; i < notifications.Count; i++)
            {
                Notification n = notifications[i];
                if (n.Id == posrednik.Id)
                {
                   notifications.Remove(n);
                }
            }

            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\notificationsak.json", JsonConvert.SerializeObject(notifications));

            NotificationsPatientPage npp = new NotificationsPatientPage(posrednik);
            npp.Show();
        }

        private void CancelButton_Click_1(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null);
            npp.Show();
        }
    }
}
