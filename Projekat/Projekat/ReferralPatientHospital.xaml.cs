
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
        public ReferralPatientHospital(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;

            StaticEquipmentRepository staticEquipmentRepository = new StaticEquipmentRepository();
            List<StaticEquipment> staticEquipments = staticEquipmentRepository.GetAll();
            dataGrid1.ItemsSource = staticEquipments;

            Name.Text = p.firstName;
            Surname.Text = p.lastName;


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



            Patient p = new Patient();
            p.firstName = Name.Text;
            p.lastName = Surname.Text;

           
       
            HospitalReferrals a = new HospitalReferrals(ida, date, end, r, p);
            hospitalReferralsController.CreateReferral(a);


            HospitalReferralss ap = new HospitalReferralss();
            ap.Show();
        }
    }
}
