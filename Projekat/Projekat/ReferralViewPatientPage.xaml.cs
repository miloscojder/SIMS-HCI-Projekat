using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Controller;
using Model;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for ReferralViewPatientPage.xaml
    /// </summary>
    public partial class ReferralViewPatientPage : Window
    {

        public ReferralPatientController ReferralPatientController = new ReferralPatientController();
        public HospitalReferralsController referralsController = new HospitalReferralsController();

        public ReferralViewPatientPage()
        {
            InitializeComponent();
            this.DataContext = this;

            List<ReferralPatient> referralPatients = new List<ReferralPatient>();
            referralPatients = ReferralPatientController.GerAllReferralsByPatientsUsername(PatientMainPage.prenosilac.Username);

            List<HospitalReferrals> hospitalReferrals = new List<HospitalReferrals>();
            hospitalReferrals = referralsController.GetAllHospitalRefferalsByPatientsUsername(PatientMainPage.prenosilac.Username);

            lvHospitalReferrals.ItemsSource = hospitalReferrals;
            lvRaferrals.ItemsSource = referralPatients;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
            pmrp.Show();
            this.Close();
        }
    }
}
