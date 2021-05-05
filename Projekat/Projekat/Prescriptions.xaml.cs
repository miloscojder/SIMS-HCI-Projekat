using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using Repository;
using Controller;

namespace Projekat
{

    public partial class Prescriptions : Window
    {
        public PrescriptionController prescriptionController = new PrescriptionController();
        public List<Prescription> prescriptions
        {
            get;
            set;
        }
        public Prescriptions()
        {
            InitializeComponent();
            PrescriptionRepository prescriptionRepository = new PrescriptionRepository();
            List<Prescription> prescriptions = prescriptionRepository.GetAll();
            dataGrid.ItemsSource = prescriptions;
        }

      

        private void Prescribe(object sender, RoutedEventArgs e)
        {

            
            ViewPatients sa = new ViewPatients();
            sa.Show();


        }
    }
}
