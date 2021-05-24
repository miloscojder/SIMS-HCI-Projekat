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
using Projekat.Model;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for Appointments.xaml
    /// </summary>
    public partial class AppointmentsPage : Window
    {

        public List<DateTime> activityTime = new List<DateTime>();
        TimeSpan timeSpan = new TimeSpan(7, 0, 0, 0, 0);

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
            return JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(@"C:\Users\cojder\Desktop\SIMS_Projekat\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json"));
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ScheduleAppointmentPatient sap = new ScheduleAppointmentPatient();
            sap.Show();
            this.Close();
        }

        private void CancButton_Click_1(object sender, RoutedEventArgs e)
        {

            StorageForSomeData sfsd = new StorageForSomeData();
            sfsd = JsonConvert.DeserializeObject<StorageForSomeData>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\hospitaldata.json"));


            foreach (DateTime datum in activityTime)
            {
                if ((DateTime.Now.Date - datum.Date) > timeSpan)
                {
                    activityTime.Remove(datum);
                    sfsd.activityCounter--;                                                     
                    File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\hospitaldata.json", JsonConvert.SerializeObject(sfsd));
                }
            }

            if(sfsd.activityCounter > 10)
            {
                MessageBox.Show("Blokirani ste zbog spamovanja, javite nam se za vise informacija");
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
            else
            {
               
                if (lvAppointmentsPatient.SelectedItems.Count < 1)
                {
                    MessageBox.Show("You must choose at leas one appointment.");
                }
                else
                {
                    sfsd.activityCounter++;
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
                    File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\hospitaldata.json", JsonConvert.SerializeObject(sfsd));

                    MessageBox.Show("Vas pregled je otkazan.");
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
            PatientMainPage pmp = new PatientMainPage(null);
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
