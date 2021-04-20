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
    /// Interaction logic for AcceptRescheduleAppointment.xaml
    /// </summary>
    public partial class AcceptRescheduleAppointmentPatientPage : Window
    {

        Appointment posrednik1 = new Appointment();

        public AcceptRescheduleAppointmentPatientPage(Appointment posred, ScheduleAppointmentPatient.Priority priority, DateTime date, String doctorsUsername)
        {
            InitializeComponent();
            this.DataContext = this;

            if (priority == ScheduleAppointmentPatient.Priority.DATE)
            {
                Appointment a = new Appointment();

               // a.TimeStart = date;
                List<Appointment> appointmentsDateChecked = new List<Appointment>();


                //ovde treba dodati provere da li su doktori i sale slobodni
                
                string[] doktori = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\doktoriak.txt", Encoding.UTF8);
                string[] sale = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\saleak.txt", Encoding.UTF8);
                Random random = new Random();


                // za sad stoji 3 jer je receno da se ponude tri, bice do kraja fajla pa dok ne nadje prva tri slobodna
                for (int i = 0; i < 3; i++)
                {
                    a = new Appointment(date, doktori[i], sale[i]);   //foreach ( doktor in doktori ) if (doktor[i].isFree == true, //foreach ( sala in sale ) if (sale[i].isFree == true)
                    a.Id = Convert.ToString(random.Next(1, 1000));  
                    a.AppointmentType = TypeOfAppointment.Examination;

                    appointmentsDateChecked.Add(a);
                }


                lvAcceptRescheduleAppointment.ItemsSource = appointmentsDateChecked;

            }
            else
            {
                Appointment a = new Appointment();


                a.doctorUsername = doctorsUsername;

                List<Appointment> appointmentDoctorChecked = new List<Appointment>();

                string[] sale = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\saleak.txt", Encoding.UTF8);
                Random random = new Random();

                List<DateTime> timeList = new List<DateTime>();

                for (int i = 0; i < 3; i++)
                {
                    timeList.Add(date.AddHours(i));
                }

                for (int i = 0; i < 3; i++)
                {
                    a = new Appointment(timeList[i], doctorsUsername, sale[i]);
                    a.Id = Convert.ToString(random.Next(1, 1000));
                    a.AppointmentType = TypeOfAppointment.Examination;

                    appointmentDoctorChecked.Add(a);
                }


                lvAcceptRescheduleAppointment.ItemsSource = appointmentDoctorChecked;
            }


            posrednik1.doctorUsername = posred.doctorUsername;
            posrednik1.Id = posred.Id;
            posrednik1.roomName = posred.roomName;
            posrednik1.StartTime = posred.StartTime;
            posrednik1.AppointmentType = posred.AppointmentType;

        }

        private void AcceptRescButton_Click(object sender, RoutedEventArgs e)
        {
            Appointment app = (Appointment)lvAcceptRescheduleAppointment.SelectedItems[0];


            TimeSpan timeSpan = new TimeSpan(2, 0, 0, 0, 0);

            //  System.Windows.MessageBox.Show(Convert.ToString(timeSpan));


            if (((app.StartTime.Date - posrednik1.StartTime.Date) >= timeSpan) || (posrednik1.StartTime > app.StartTime))
            {
                MessageBox.Show("Vas pregled je zakazan u losem terminu.");
                this.Close();

                AppointmentsPage a = new AppointmentsPage(null);
                a.Show();

            }
            else
            {

                //     System.Windows.MessageBox.Show(posrednik1.Id);  OVDE JE DOBAR

                //dodaj ucitavanje iz fajla, brisanje posrednika1 i dodavanje app u listu

                List<Appointment> svi = new List<Appointment>();
                List<Appointment> newSvi = new List<Appointment>();

                svi = JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json"));


                foreach (Appointment appo in svi)
                {
                    if (appo.Id != posrednik1.Id)
                    {
                        newSvi.Add(appo);
                    }
                }

                File.WriteAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\appointmentsak.json", JsonConvert.SerializeObject(newSvi));

                AppointmentsPage a = new AppointmentsPage(app);
                a.Show();
            }
        }
    }
}
