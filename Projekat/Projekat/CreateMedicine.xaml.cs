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
using Projekat.Model;
using Projekat.Controller;
using Projekat.Repository;

namespace Projekat
{

    public partial class CreateMedicine : Window
    {
        private MedicinesController medicinesController = new MedicinesController();
        public CreateMedicine()
        {
            InitializeComponent();
            MedicinesRepository medicinesRepository = new MedicinesRepository();
            List<Medicines> medicines = medicinesRepository.GetAll();
            
        }

        private void SendRequest_Click(object sender, RoutedEventArgs e)
        {
            int ind = medicinesController.GenerateNewId();
            string medicinesname = name.Text;
            string medicinesdetails = details.Text;
            string medicinesalternative = alternative.Text;
            Medicines medicines = new Medicines(ind, medicinesname, medicinesdetails, medicinesalternative);
            medicinesController.Save(medicines);

            ViewMedicines vm = new ViewMedicines();
            vm.Show();
            Close();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow dr = new DirectorWindow();
            dr.Show();
            Close();
        }



    }


}
