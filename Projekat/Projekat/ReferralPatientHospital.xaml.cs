
using Model;
using System;
using Controller;
using Repository;
using System.Windows;
using System.Collections.Generic;
using System.IO;

namespace Projekat
{
   
    public partial class ReferralPatientHospital : Window
    {
        
        public HospitalReferralsController hospitalReferralsController = new HospitalReferralsController();
        public StaticEquipmentController staticEquipmentController = new StaticEquipmentController();
        public Patient patient = new Patient();
        public ReferralPatientHospital(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;

            StaticEquipmentRepository staticEquipmentRepository = new StaticEquipmentRepository();
            List<StaticEquipment> staticEquipments = staticEquipmentRepository.GetAll();
            dataGrid1.ItemsSource = staticEquipments;

            patient.firstName = p.firstName;
            patient.lastName = p.lastName;


        }

        private void Select(object sender, RoutedEventArgs e)
        {

            StaticEquipment s = (StaticEquipment)dataGrid1.SelectedItems[0];

            RoomName.Text = s.room.Name;
        }

        private void Referral(object sender, RoutedEventArgs e)
        {

            
            int ida = hospitalReferralsController.GenerateNewId();
            String date = Date.Text;
            String end = EndDate.Text;

            Room r = new Room();
            r.Name = RoomName.Text;
           
       
            HospitalReferrals a = new HospitalReferrals(ida, date, end, r, patient);
            hospitalReferralsController.CreateReferral(a);


            HospitalReferralss ap = new HospitalReferralss();
            ap.Show();
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            HospitalReferralss h = new HospitalReferralss();
            h.Show();
            Close();
        }
    }
}
