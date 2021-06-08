using Model;
using Projekat.Controller;
using Projekat.Model;
using Projekat.Repository;

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

    public partial class ViewRejectedMedicines : Window
    {
        private MedicinesController medicinesController = new MedicinesController();
        private Medicines medi = new Medicines();

       
        public ViewRejectedMedicines()
        {
            InitializeComponent();
            String status = "Rejected";
            MedicinesRepository medicinesRepository = new MedicinesRepository();
            List<Medicines> med = medicinesRepository.GetAllStatus(status);
            dataGrid.ItemsSource = med;
            

            
        }


        private void Back(object sender, RoutedEventArgs e)
        {
            ViewMedecine sc = new ViewMedecine();
            sc.Show();
            Close();


        }


    }
}
