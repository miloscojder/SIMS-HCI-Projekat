using Model;
using Projekat.Controller;
using Projekat.Model;
using Projekat.Repository;
using Repository;
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

namespace Projekat
{

    public partial class ViewMedecine : Window
    {
        private MedicinesController medicinesController = new MedicinesController();
        private Medicines med = new Medicines();

       
        public ViewMedecine()
        {
            InitializeComponent();

            MedicinesRepository medicinesRepository = new MedicinesRepository();
            List<Medicines> rooms = medicinesRepository.GetAll();
            dataGrid.ItemsSource = rooms;
            AppointmentRepository appointmentRepository = new AppointmentRepository();
            List<Appointment> appointments = appointmentRepository.GetAll();
            dataGridd.ItemsSource = appointments;
            OperationRepository operationRepository = new OperationRepository();
            List<Operations> operations = operationRepository.GetAll();
            dataGridd1.ItemsSource = operations;


        }


        private void Back(object sender, RoutedEventArgs e)
        {
            ViewMedicines m = new ViewMedicines();
            m.Show();
            Close();


        }



       private void Aprove(object sender, RoutedEventArgs e)
        {
            Medicines p = (Medicines)dataGrid.SelectedItems[0];
            
            med.Name = p.Name;
            med.Id = p.Id;
            med.Details = p.Details;
            med.Alternative = p.Alternative;
            String status = new string("Accepted");
            med.StatusType = status;
            String exp = null;

            Medicines a = new Medicines(med.Id, med.Name, med.Details, med.Alternative, exp, med.StatusType);
            medicinesController.UpdateMedicines(a);

            ViewMedecine sc = new ViewMedecine();
            sc.Show();
            Close();
        }
      
        private void Update(object sender, RoutedEventArgs e)

        {
            UpdateMedecine me = new UpdateMedecine();
            me.Show();
            Close();
        }
        private void Reject(object sender, RoutedEventArgs e)
        {

            RejectedExpl r = new RejectedExpl();
            r.Show();
            Close();

        }
     

        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }


        private void Patients(object sender, RoutedEventArgs e)
        {
            ViewPatients m = new ViewPatients();
            m.Show();
            Close();
        }

        private void AnamnesisClick(object sender, RoutedEventArgs e)
        {
            Anamnesiss m = new Anamnesiss();
            m.Show();
            Close();
        }

        private void Prescribe(object sender, RoutedEventArgs e)
        {
            Prescriptions m = new Prescriptions();
            m.Show();
            Close();
        }

        private void AppointmentClick(object sender, RoutedEventArgs e)
        {
            Appointments m = new Appointments();
            m.Show();
            Close();
        }

        private void OperationsClick(object sender, RoutedEventArgs e)
        {
            Operationss m = new Operationss();
            m.Show();
            Close();
        }

        private void ReferralP(object sender, RoutedEventArgs e)
        {
            Referrals m = new Referrals();
            m.Show();
            Close();
        }


        private void SeeAll(object sender, RoutedEventArgs e)
        {
            ViewMedicines m = new ViewMedicines();
            m.Show();
            Close();
        }

        private void MedecineRejected(object sender, RoutedEventArgs e)
        {
            ViewRejectedMedicines m = new ViewRejectedMedicines();
            m.Show();
            Close();
        }
        

    }
}
