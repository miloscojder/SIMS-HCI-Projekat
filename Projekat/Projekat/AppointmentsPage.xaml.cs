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


            //   AppointmentFileStorage storage = new AppointmentFileStorage();
            //               List<Appointment> termini = storage.GetAll();

            // char delimeter = ',';
            // string fileToRead = @"C:\Users\Korisnik\source\repos\Sims-Hci\Sims-Hci\appointments.txt";
            // string currentLine = string.Empty;
            List<Appointment> spisak = new List<Appointment>();


            /*     using (StreamReader reader = new StreamReader(fileToRead))
                 {
                     while ((currentLine = reader.ReadLine()) != null)
                     {*/

            spisak = JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json"));

            /*
             Appointment temp = new Appointment();

                     string[] parths = currentLine.Split(delimeter);

                     temp.Id = parths[0];
                     temp.TimeStart = Convert.ToDateTime(parths[1]);
                     temp.Duration = Convert.ToDouble(parths[2]);
                     temp.Finished = Convert.ToBoolean(parths[3]);
                     temp.EndTime = Convert.ToDateTime(parths[4]);


                     //popraviti ovo
                     /*  temp.room.Name = parths[5];
                      // temp.patient.Username = parths[6];
                       temp.doctor.Username = parths[6];
        */
            /*
                     temp.roomName = parths[5];
                     temp.doctorUsername = parths[6];

                     spisak.Add(temp);
            */
            //    }
            //        }



            /*
            using (TextWriter tw = new StreamWriter(@"C:\Users\Korisnik\source\repos\Sims-Hci\Sims-Hci\appointments.txt"))
            {
                foreach (Appointment line in spisak)
                {
                    tw.WriteLine(line.);
                }
            }
          */


            if (a != null)
            {
                spisak.Add(a);
            }

            lvAppointmentsPatient.ItemsSource = spisak;


            //Ovo ne radi skroz dobro ali radi
            List<Notification> notifications = new List<Notification>();
            notifications = JsonConvert.DeserializeObject<List<Notification>>(File.ReadAllText(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\notificationsak.json"));

            foreach (Notification n in notifications)
            {
                if ((n.Date.Date == DateTime.Now.Date) && (DateTime.Now.Hour >= (n.Date.Hour - 1)) && (DateTime.Now.Minute==n.Date.Minute))
                {
                    MessageBox.Show("Vase danasnje obavestenje je: " + n.Name + " " + n.Description);
                }
            }

            File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json", JsonConvert.SerializeObject(spisak));


            /*

            try
            {
                FileOutputStream fs = new FileOutputStream(@"C:\Users\Korisnik\source\repos\Sims-Hci\Sims-Hci\appointments.txt")
            }*/


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


            // using (StreamReader file = new StreamReader(@"C:\Users\Korisnik\source\repos\Sims-Hci\Sims-Hci\appointments.txt"))
            //          {
            /*    while ((line = file.ReadLine()) != null)
                {
                    String[] parts = line.Split(',');
                    if (parts[0] != ac.Id.ToString())
                    {
                        lines.Add(line);
                    }

                }
          }

            File.WriteAllText(@"C:\Users\Korisnik\source\repos\Sims-Hci\Sims-Hci\appointments.json", lines);
          // File.WriteAllLines(@"C:\Users\Korisnik\source\repos\Sims-Hci\Sims-Hci\appointments.txt", lines);
            */

            //  }


            //    }
        }

        private void RescButton_Click_2(object sender, RoutedEventArgs e)
        {

            Appointment ach = (Appointment)lvAppointmentsPatient.SelectedItems[0];
            RescheduleAppointmentPatientPage rapp = new RescheduleAppointmentPatientPage(ach);
            rapp.Show();

        }

        private void NotificationsButton_Click(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage();
            npp.Show();
        }
    }
}
