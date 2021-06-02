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


namespace Projekat
{
    /// <summary>
    /// Interaction logic for AcceptNewAppointment.xaml
    /// </summary>
    public partial class AcceptNewAppointmentPatient : Window
    {
     

        public AcceptNewAppointmentPatient(ScheduleAppointmentPatient.Priority priority, DateTime choosenDate, string izabraniDoctor)
        {
            InitializeComponent();
            this.DataContext = this;

            if (priority == ScheduleAppointmentPatient.Priority.DATE)
            {
                Appointment a = new Appointment();

                a.StartTime = choosenDate;

                List<Appointment> appointmentsDateChecked = new List<Appointment>();

               // string[] doktori = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\doktoriak.txt", Encoding.UTF8);
                string[] sale = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\saleak.txt", Encoding.UTF8);
                Random random = new Random(); 

                for (int i = 0; i < 3; i++)
                {
               //     a = new Appointment(choosenDate, doktori[i], sale[i]);
                    a.id = random.Next(1, 1000);
                    a.AppointmentType = TypeOfAppointment.Examination;
  
                    appointmentsDateChecked.Add(a);
                }                            

                lvAcceptAppointment.ItemsSource = appointmentsDateChecked;
            }
            else
            {
                Appointment a = new Appointment();

                //a.doctorUsername = izabraniDoctor;

                List<Appointment> appointmentsDoctorChecked = new List<Appointment>();
                string[] sale = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\saleak.txt", Encoding.UTF8);
                Random random = new Random();

                List<DateTime> timeList = new List<DateTime>();

                for (int i = 0; i < 3; i++)
                {
                    timeList.Add(choosenDate.AddDays(i));
                }

                for (int i = 0; i < 3; i++)
                {
              //      a = new Appointment(timeList[i], izabraniDoctor, sale[i]);
                    a.id = random.Next(1, 1000);
                    a.AppointmentType = TypeOfAppointment.Examination;

                    appointmentsDoctorChecked.Add(a);
                }

                lvAcceptAppointment.ItemsSource = appointmentsDoctorChecked;
            }
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            if (lvAcceptAppointment.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must choose at least 1 appointment");
            }
            else
            {
                Appointment app = (Appointment)lvAcceptAppointment.SelectedItems[0];

                AppointmentsPage appo = new AppointmentsPage(app);
                appo.Show();
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsPage app = new AppointmentsPage(null);
            app.Show();
            this.Close();
        }
    }
}