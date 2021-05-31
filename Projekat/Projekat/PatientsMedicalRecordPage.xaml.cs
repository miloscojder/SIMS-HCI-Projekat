﻿using Model;
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

namespace Projekat
{
    /// <summary>
    /// Interaction logic for PatientsMedicalRecordPage.xaml
    /// </summary>
    public partial class PatientsMedicalRecordPage : Window
    {
        
        MedicalRecordController medicalRecordController = new MedicalRecordController();
        PrescriptionController prescriptionController = new PrescriptionController();
       
        public PatientsMedicalRecordPage()
        {
            InitializeComponent();
            this.DataContext = this;

            List<MedicalRecord> patientsRecords = new List<MedicalRecord>();
            patientsRecords = medicalRecordController.GetAllRecordsByPatientsUsername(PatientMainPage.prenosilac.Username);
           
            List<Prescription> patientsPrescriptions = new List<Prescription>();
            patientsPrescriptions = prescriptionController.GetAllPrescriptionsByPatientsUsername(PatientMainPage.prenosilac.Username);


            lvMedicalRecord.ItemsSource = patientsRecords;            
            lvPrescriptions.ItemsSource = patientsPrescriptions;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientMainPage pmp = new PatientMainPage(PatientMainPage.prenosilac);
            pmp.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppointmentsPage ap = new AppointmentsPage(null);
            ap.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NotificationsPatientPage npp = new NotificationsPatientPage(null);
            npp.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PatientsMedicalRecordPage pmrp = new PatientsMedicalRecordPage();
            pmrp.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PatientQandAPage pqap = new PatientQandAPage();
            pqap.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PatientProfilePage ppp = new PatientProfilePage();
            ppp.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ReferralViewPatientPage rvpp = new ReferralViewPatientPage();
            rvpp.Show();
            this.Close();
        }
    }
}
