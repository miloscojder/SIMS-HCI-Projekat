
using Model;
using System;
using Controller;
using Repository;
using System.Windows;
using System.Collections.Generic;
using System.IO;

namespace Projekat
{
   
    public partial class ReferralPatientt : Window
    {
        
        public ReferralPatientController referralPatientController = new ReferralPatientController();
        public List<String> specialties { get; set; }
        public String selekt { get; set; }
        public Patient patient = new Patient();
        public ReferralPatientt(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;
            patient.firstName = p.firstName;
            patient.lastName = p.lastName;

            string[] specialtiess = File.ReadAllLines(@"C:/Users/krist/source/repos/SIMS-Projekat/Projekat/Projekat/Data/specialties.txt");
            specialties = new List<string>(specialtiess);

        }

        private void Referral(object sender, RoutedEventArgs e)
        {

            Appointment app = new Appointment();
            int ida = referralPatientController.GenerateNewId();
            String date = Date.Text;
            String hours = Hours.Text;
            String hourss = Hourss.Text;
            String start = hours;
            String end = hourss;
            String duration = Duration.Text;
            String expl = Explain.Text;


            Room r = new Room();
            r.Name = RoomName.Text;

           
            string selectSpecialty = (string)Combobox1.SelectedItem;
            

            ReferralPatient a = new ReferralPatient(ida, date, start, duration, end, expl, r, patient, selectSpecialty);
            referralPatientController.CreateReferral(a);


            ViewReferrals ap = new ViewReferrals();
            ap.Show();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            ViewReferrals v = new ViewReferrals();
            v.Show();
            Close();

        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }
    }
}
