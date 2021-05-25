using Model;
using System;
using System.Collections.Generic;
using System.Windows;
using Controller;
using Repository;
namespace Projekat
{
  
    public partial class ExtendHospital : Window
    {
        public HospitalReferralsController hospitalReferralsController = new HospitalReferralsController();

        public List<Appointment> appointments
        {
            get;
            set;
        }
        int id;
        Room room = new Room();
        Patient patient = new Patient();
        public ExtendHospital(HospitalReferrals hos)
        {
            InitializeComponent();

            HospitalReferralsRepository hospitalReferralsRepository = new HospitalReferralsRepository();
            List<HospitalReferrals> referrals = hospitalReferralsRepository.GetAll();
            dataGriid.ItemsSource = referrals;
            Date.Text = hos.Date;
            EndDate.Text = hos.EndDate;
            id = hos.Id;
            room.Name = hos.Room.Name;
            patient.firstName = hos.Patient.firstName;
            patient.lastName = hos.Patient.lastName;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
        
            
            String date = Date.Text;
          
            String end = EndDate.Text;


            HospitalReferrals a = new HospitalReferrals(id, date, end, room, patient);
            hospitalReferralsController.Update(a);

            HospitalReferralss ap = new HospitalReferralss();
            ap.Show();
            Close();


        }
    }
}
