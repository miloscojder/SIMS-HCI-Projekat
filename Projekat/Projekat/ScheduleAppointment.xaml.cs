
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using Controller;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekat
{
   
    public partial class ScheduleAppointment : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public ScheduleAppointment()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Schedule(object sender, RoutedEventArgs e)
        {
           
           
            String ida = Id.Text;
            String date = Date.Text;
            String hours = Hours.Text;
            String minutes = Minutes.Text;
            String hourss = Hourss.Text;
            String minutess = Minutess.Text;
            String start = hours + ":" + minutes;
            String end = hourss + ":" + minutess;
            String duration = Duration.Text;
        //    Room idroom = Rid;
           // Patient idpatient = Pid.Text;
           // String type = type.Text;




            //    TipPregleda t = new TipPregleda();
            Appointment a = new Appointment(ida, date, start, duration, end);
            appointmentController.ScheduleDoctor(a);

            Appointments ap = new Appointments();
            ap.Show();

           /* int sign = 0;
            String line = "";

            using (StreamReader file = new StreamReader(@"C:/Users/krist/Desktop/pacijenti.txt"))
            {

                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts[4] == ida)
                    {
                        sign++;
                        break;
                    }
                }

                file.Close();
            }
            if (sign == 0)
            {
                MessageBox.Show("Patient not found");
                return;
                
            }


            //sada gledam da li je vreme okej tj da li se poklapa sa nekim
            String line1;
            String id=""; //id pregleda
          
            using (StreamReader file = new StreamReader(@"C:\Users\krist\Desktop\appointments.txt"))
            {

                while ((line1 = file.ReadLine()) != null)
                {
                    string[] parts = line1.Split(',');
                    String date11 = Convert.ToString(parts[3]);
                    String date22 = date11;
                    id = parts[0];

                  
                }

                file.Close();
            }
            String Idnovi = Convert.ToString(id)+1;
            sign = 0;

            //gledam da li postoji unijeta sala
            using (StreamReader file = new StreamReader(@"C:\Users\krist\Desktop\rooms.txt"))
            {

                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts[0] ==idRoom)
                    {
                        sign++;
                        break;
                    }
                }

                file.Close();
            }

            if (sign == 0)
            {
                MessageBox.Show("Room does not exists");
                return;
            }

            //stavljam sve u red kako bi bilo u fajlu
            String red =Idnovi.ToString()+ "," + ida + "," +  date1 + "," + duration.ToString() +
                "," +idRoom;



            AppointmentFileStorage fajl = new AppointmentFileStorage(@"C:\Users\krist\Desktop\appointments.txt");
             fajl.Save(red,true);

             MessageBox.Show("Appointment scheduled!");
            this.Close(); */
        }
    }
}
