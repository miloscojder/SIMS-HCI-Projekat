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

    public partial class UpdateMedecine : Window
    {
        private MedicinesController medicinesController = new MedicinesController();
        int id;
        private Medicines med = new Medicines();
        
        public UpdateMedecine()
        {
            InitializeComponent();
            MedicinesRepository medicinesRepository = new MedicinesRepository();
            List<Medicines> medicines = medicinesRepository.GetAll();
            dataGridUpdateMedicine.ItemsSource = medicines;
            
        }

        private void UpdateMedicines_Click(object sender, RoutedEventArgs e)
        {

            string medicinesname = name.Text;
            string medicinesdetail = details.Text;
            string medicinesalternative = alternative.Text;
            string status = med.StatusType;
            string exp = null;

            Medicines medicin = new Medicines(id, medicinesname, medicinesdetail, medicinesalternative, exp, status);
            medicinesController.UpdateMedicines(medicin);
            id = -1;

            ViewMedecine vr = new ViewMedecine();
            vr.Show();
            Close();
        }
        private void CancelMedicines_Click(object sender, RoutedEventArgs e)
        {
            ViewMedecine dr = new ViewMedecine();
            dr.Show();
            Close();
        }

        private void SelectMedicines_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Medicines medicines = (Medicines)dataGridUpdateMedicine.SelectedItems[0];
                id = medicines.Id;



                name.Text = medicines.Name;
                details.Text = medicines.Details;
                alternative.Text = medicines.Alternative;
                med.StatusType = medicines.StatusType;


            }
            catch
            {
                MessageBox.Show("You have to fill in all input boxes!");
            }
        }
    }
}
