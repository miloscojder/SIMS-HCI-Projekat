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
using Controller;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for ScheduleAppointmentPatient.xaml
    /// </summary>

  

    public partial class ScheduleAppointmentPatient : Window
    {
        
        public enum Priority { DATE, DOCTOR }
        public User prenosilac = new User();
        public List<String> Termini { get; set; }
        public string SelektovanTermin { get; set; }
        public List<String> Doktori { get; set; }
        public string SelektovanDoktor { get; set; }
        public Priority priority;
        public static int counter = 0;          //ovo treba da bude globalno, da li ovo valja?
        List<DateTime> listaVremenaZakazivanja = new List<DateTime>();
        TimeSpan timeSpan = new TimeSpan(7, 0, 0, 0, 0);
        private static int kolikoSamDatumaNasao = 0;
        public HospitalController hospitalController = new HospitalController();

        //globalni brojac

        public ScheduleAppointmentPatient()
        {
            InitializeComponent();
            this.DataContext = this;

            string[] termini = File.ReadAllLines(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\terminiak.txt", Encoding.UTF8);
            Termini = new List<string>(termini);

            string[] doktori = File.ReadAllLines(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\doktoriak.txt", Encoding.UTF8);
            Doktori = new List<string>(doktori);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            priority = Priority.DATE;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            priority = Priority.DOCTOR;
        }

        private void SendRequestClick(object sender, RoutedEventArgs e)
        {

            Hospital hospitalData = new Hospital();
            hospitalData = hospitalController.GetAllHospitalsData();

            //atni spam zastita? proveriti ovo malo
            foreach (DateTime datum in listaVremenaZakazivanja)
            {
                if ((DateTime.Now.Date - datum.Date) > timeSpan)    
                {
                    listaVremenaZakazivanja.Remove(datum);
                    hospitalData.activityCounter--;                                                              
                }    
            }        
            
            if(hospitalData.activityCounter > 10)                             
            {
                MessageBox.Show("Blokirani ste zbog spamovanja, javite nam se za vise informacija");
                //window close        
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            } 
            else 
            {
                hospitalData.activityCounter++;
                hospitalController.WriteHospitalToJason(hospitalData);

                
                listaVremenaZakazivanja.Add(DateTime.Now);

                DateTime choosenDate = new DateTime();

                String nesto = (string)Combobox1.SelectedItem;
                string[] preuzeto = nesto.Split(':');

                choosenDate = (DateTime)IzaberiDatum.SelectedDate;
                choosenDate = new DateTime(IzaberiDatum.SelectedDate.Value.Year, IzaberiDatum.SelectedDate.Value.Month, IzaberiDatum.SelectedDate.Value.Day, Convert.ToInt32(preuzeto[0]), Convert.ToInt32(preuzeto[1]), 0);

                string izabraniDoktor = (string)Combobox2.SelectedItem;

                List<DateTime> doktoroviTermini = JsonConvert.DeserializeObject<List<DateTime>>(File.ReadAllText(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Data\zauzetiDoktor.json"));
                    
                foreach(DateTime dt in doktoroviTermini)
                {
                    if(dt.Date == choosenDate.Date && dt.Hour == choosenDate.Hour && dt.Minute == choosenDate.Minute) {
                    kolikoSamDatumaNasao++;
                    }
                }
                
                if(kolikoSamDatumaNasao>=1)
                {
                   AcceptNewAppointmentPatient anap = new AcceptNewAppointmentPatient(/*a,*/ priority, choosenDate, izabraniDoktor);
                   anap.Show();
                    this.Close();
                } 
                else
                {
                    Appointment newAppointment = new Appointment();
                    Random rid = new Random();
                    newAppointment.id = rid.Next(1, 1000);
                    newAppointment.roomName = "R1";
                    newAppointment.doctorUsername = izabraniDoktor;
                    newAppointment.StartTime = choosenDate;

                    AppointmentsPage ap = new AppointmentsPage(newAppointment);
                    ap.Show();
                    this.Close();
                }
              
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
            this.Close();
        }
    }
}
