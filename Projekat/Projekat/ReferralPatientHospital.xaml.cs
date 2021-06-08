
using Model;
using System;
using Controller;
using Repository;
using System.Windows;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media;
using Service;

namespace Projekat
{
   
    public partial class ReferralPatientHospital : Window
    {
        
        public HospitalReferralsController hospitalReferralsController = new HospitalReferralsController();
        //    public StaticEquipmentController staticEquipmentController = new StaticEquipmentController();
        StaticEquipmentRepository staticEquipmentRepository = new StaticEquipmentRepository();
        public StaticEquipment staticEquipment = new StaticEquipment();

        public Patient patient = new Patient();
        public ReferralPatientHospital(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;

            
            List<StaticEquipment> staticEquipments = staticEquipmentRepository.GetAllBedrooms();
            dataGrid1.ItemsSource = staticEquipments;

            patient.firstName = p.firstName;
            patient.lastName = p.lastName;


        }

        

        private void Select(object sender, RoutedEventArgs e)
        {

            staticEquipment = (StaticEquipment)dataGrid1.SelectedItems[0];
            RoomName.Text = staticEquipment.room.Name;
        }

        private void Referral(object sender, RoutedEventArgs e)
        {

            
            int ida = hospitalReferralsController.GenerateNewId();
            String date = Date.Text;
            String end = EndDate.Text;

            Room r = new Room();
            r.Name = RoomName.Text;

            
              
                if (staticEquipment.AvailableBeds == 0)
                {
                    MessageBox.Show("Room is full!");
                }
                else
                {
                    staticEquipment.AvailableBeds = staticEquipment.AvailableBeds - 1;
                staticEquipmentRepository.UpdateEquipment(staticEquipment);

                HospitalReferrals a = new HospitalReferrals(ida, date, end, r, patient, staticEquipment);
                hospitalReferralsController.CreateReferral(a);



                HospitalReferralss ap = new HospitalReferralss();
                ap.Show();
            }

            


            
        }

     

        private void Back(object sender, RoutedEventArgs e)
        {
            HospitalReferralss h = new HospitalReferralss();
            h.Show();
            Close();
        }
    }
}
