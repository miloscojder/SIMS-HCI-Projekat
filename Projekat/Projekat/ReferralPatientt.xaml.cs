
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
        public ReferralPatientt(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;
            Name.Text = p.firstName;
            Surname.Text = p.lastName;

            string[] specialtiess = File.ReadAllLines(@"C:/Users/krist/source/repos/SIMS-Projekat/Projekat/Projekat/Data/specialties.txt");
            specialties = new List<string>(specialtiess);

        }

        private void Referral(object sender, RoutedEventArgs e)
        {

            Appointment app = new Appointment();
            int ida = referralPatientController.GenerateNewId();
            String date = Date.Text;
            String hours = Hours.Text;
            String minutes = Minutes.Text;
            String hourss = Hourss.Text;
            String minutess = Minutess.Text;
            String start = hours + ":" + minutes;
            String end = hourss + ":" + minutess;
            String duration = Duration.Text;
            String expl = Explain.Text;


            Room r = new Room();
            r.Name = RoomName.Text;
           


            Patient p = new Patient();
            p.firstName = Name.Text;
            p.lastName = Surname.Text;

           
            string selectSpecialty = (string)Combobox1.SelectedItem;
            

            ReferralPatient a = new ReferralPatient(ida, date, start, duration, end, expl, r, p, selectSpecialty);
            referralPatientController.CreateReferral(a);

         
             MessageBox.Show("Patient referraled!");
            this.Close();

            ViewReferrals ap = new ViewReferrals();
            ap.Show();
        }
    }
}
