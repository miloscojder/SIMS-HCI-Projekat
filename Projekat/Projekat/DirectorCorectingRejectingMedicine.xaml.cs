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
    /// <summary>
    /// Interaction logic for DirectorCorectingRejectingMedicine.xaml
    /// </summary>
    public partial class DirectorCorectingRejectingMedicine : Window
    {

        private MedicinesController medicinesController = new MedicinesController();
        private Medicines medi = new Medicines();
        int id;

        public DirectorCorectingRejectingMedicine()
        {
            InitializeComponent();
            InitializeComponent();
            String status = "Rejected";
            MedicinesRepository medicinesRepository = new MedicinesRepository();
            List<Medicines> med = medicinesRepository.GetAllStatus(status);
            dataGrid.ItemsSource = med;


        }

        private void UpdateMedicine_Click(object sender, RoutedEventArgs e)
        {

            string medicinesname = name.Text;
            string medicinesdetail = details.Text;
            string medicinesalternative = alternative.Text;
            string statustype = statusType.Text;
            string explanations = explanation.Text;

            Medicines medicines = new Medicines(id, medicinesname, medicinesdetail, medicinesalternative,explanations, statustype);
            medicinesController.UpdateMedicines(medicines);
            id = -1;

            ViewMedicines vr = new ViewMedicines();
            vr.Show();
            Close();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            ViewMedecine sc = new ViewMedecine();
            sc.Show();
            Close();


        }

        private void SelectMedicines_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Medicines medicines = (Medicines)dataGrid.SelectedItems[0];
                id = medicines.Id;



                name.Text = medicines.Name;
                details.Text = medicines.Details;
                alternative.Text = medicines.Alternative;
                statusType.Text = "Waiting";


            }
            catch
            {
                MessageBox.Show("You have to fill in all input boxes!");
            }



        }
    }
}
