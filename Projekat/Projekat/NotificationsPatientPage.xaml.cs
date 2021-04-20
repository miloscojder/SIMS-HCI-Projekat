﻿using System;
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
    /// Interaction logic for NotificationsPatientPage.xaml
    /// </summary>
    public partial class NotificationsPatientPage : Window
    {

        List<Notification> posrednaListaNotifikacija = new List<Notification>();


        public NotificationsPatientPage()
        {
            InitializeComponent();
            this.DataContext = this;

            List<Notification> notifications = new List<Notification>();

            notifications = JsonConvert.DeserializeObject<List<Notification>>(File.ReadAllText(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\notificationsak.json"));

            lvNotificationList.ItemsSource = notifications;

            //  File.WriteAllText(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\notificationsak.json", JsonConvert.SerializeObject(notifications));
            posrednaListaNotifikacija = notifications;
        }

       

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
        }
    }
}
