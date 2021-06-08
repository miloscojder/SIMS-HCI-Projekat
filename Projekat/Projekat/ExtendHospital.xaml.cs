using Model;
using System;
using System.Collections.Generic;
using System.Windows;
using Controller;
using Repository;
using System.Windows.Media;

namespace Projekat
{
  
    public partial class ExtendHospital : Window
    {
        public HospitalReferralsController hospitalReferralsController = new HospitalReferralsController();
        public StaticEquipment staticEquipment = new StaticEquipment();
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
            staticEquipment = hos.staticEquipment;
        }

        public void doThings(string param)
        {
            ExtendH.Background = new SolidColorBrush(Color.FromRgb(32, 64, 128));
            Title = param;
        }
        private void Save(object sender, RoutedEventArgs e)
        {
        
            
            String date = Date.Text;
          
            String end = EndDate.Text;


            HospitalReferrals a = new HospitalReferrals(id, date, end, room, patient, staticEquipment);
            hospitalReferralsController.Update(a);

            HospitalReferralss ap = new HospitalReferralss();
            ap.Show();
            Close();


        }

        private void Back(object sender, RoutedEventArgs e)
        {
            HospitalReferralss ap = new HospitalReferralss();
            ap.Show();
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
