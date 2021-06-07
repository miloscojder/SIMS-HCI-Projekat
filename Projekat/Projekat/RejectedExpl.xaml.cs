﻿
using System;
using System.Windows;
using Projekat.Controller;
using Projekat.Model;
using Projekat.Repository;
using System.Collections.Generic;
using System.IO;

namespace Projekat
{

    public partial class RejectedExpl : Window
    {

        private MedicinesController medicinesController = new MedicinesController();
        int id;
        private Medicines medi = new Medicines();
       
          public RejectedExpl()
          {
            InitializeComponent();

            MedicinesRepository medicinesRepository = new MedicinesRepository();
            List<Medicines> medis = medicinesRepository.GetAll();
            dataGrid.ItemsSource = medis;

        } 

        public void SaveChanges(object sender, RoutedEventArgs e)
        {

            Medicines p = (Medicines)dataGrid.SelectedItems[0];

            medi.Name = p.Name;
            medi.Id = p.Id;
            medi.Details = p.Details;
            medi.Alternative = p.Alternative;
            String status = new string("Rejected");
            medi.StatusType = status;
            String exp = Rejection.Text;

            Medicines a = new Medicines(medi.Id, medi.Name, medi.Details, medi.Alternative, exp, medi.StatusType);
            medicinesController.UpdateMedicines(a);

            ViewMedecine sc = new ViewMedecine();
            sc.Show();
            Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            ViewMedecine m = new ViewMedecine();
            m.Show();
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
