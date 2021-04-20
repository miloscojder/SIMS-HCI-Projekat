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


namespace Projekat
{
    /// <summary>
    /// Interaction logic for AcceptNewAppointment.xaml
    /// </summary>
    public partial class AcceptNewAppointmentPatient : Window
    {
        public AcceptNewAppointmentPatient(/*Appointment a,*/ ScheduleAppointmentPatient.Priority priority, DateTime choosenDate, string izabraniDoctor)
        {
            InitializeComponent();
            this.DataContext = this;

            if (priority == ScheduleAppointmentPatient.Priority.DATE)
            {
                Appointment a = new Appointment();

                a.StartTime = choosenDate;
                //      System.Windows.MessageBox.Show(Convert.ToString(a.TimeStart));

                List<Appointment> appointmentsDateChecked = new List<Appointment>();

                string[] doktori = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\doktoriak.txt", Encoding.UTF8);
                string[] sale = File.ReadAllLines(@"C:\Users\Korisnik\Desktop\asdas\SIMS-HCI-Projekat-main\Projekat\Projekat\Data\saleak.txt", Encoding.UTF8);
                Random random = new Random(); // za sad koristim random za id.. bice pretraga u fajlu pa onaj koji fali ili ako su svi tu poslednji + 1

                //   System.Windows.MessageBox.Show(doktori[0]);
                //   System.Windows.MessageBox.Show(doktori[0] + " " + sale[0]);


                for (int i = 0; i < 3; i++)
                {
                    a = new Appointment(choosenDate, doktori[i], sale[i]);
                    a.Id = Convert.ToString(random.Next(1, 1000));
                    //a.doctorUsername = doktori[i];
                    //a.roomName = sale[i];
                    a.AppointmentType = TypeOfAppointment.Examination;
                    //System.Windows.MessageBox.Show();  

                    appointmentsDateChecked.Add(a);


                }
                //             System.Windows.MessageBox.Show(appointmentsDate[2].doctorsName);
                //System.Windows.MessageBox.Show(appointmentsDateChecked[0].roomName);    //A4 -> treci u nizu


                lvAcceptAppointment.ItemsSource = appointmentsDateChecked;


            }
            else
            {

                Appointment a = new Appointment();

                a.doctorUsername = izabraniDoctor;

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
                    a = new Appointment(timeList[i], izabraniDoctor, sale[i]);


                    //     a.roomName = sale[i];
                    a.Id = Convert.ToString(random.Next(1, 1000));
                    //                    a.TimeStart = timeList[i];

                    a.AppointmentType = TypeOfAppointment.Examination;
                    appointmentsDoctorChecked.Add(a);
                }

                lvAcceptAppointment.ItemsSource = appointmentsDoctorChecked;

            }
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            Appointment app = (Appointment)lvAcceptAppointment.SelectedItems[0];

            AppointmentsPage appo = new AppointmentsPage(app);
            appo.Show();


        }
    }
}