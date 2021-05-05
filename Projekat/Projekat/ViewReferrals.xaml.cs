using Model;
using System;
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
using Controller;
using Repository;

namespace Projekat
{

    public partial class ViewReferrals : Window
    {
        public ReferralPatientController referralPatientController = new ReferralPatientController();

        public List<ReferralPatient> referal
        {
            get;
            set;
        }
        public ViewReferrals()
        {
            InitializeComponent();

            ReferralPatientRepository referralPatientRepository = new ReferralPatientRepository();
           List<ReferralPatient> referal = referralPatientRepository.GetAll();
            dataGrid.ItemsSource = referal;
           
        }

        private void Referral(object sender, RoutedEventArgs e)
        {

            ViewPatients p = new ViewPatients();
            p.Show();
            Close();


        }


    }
}
