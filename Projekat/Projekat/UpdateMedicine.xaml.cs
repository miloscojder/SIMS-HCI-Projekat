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
    /// Interaction logic for UpdateMedicine.xaml
    /// </summary>
    public partial class UpdateMedicine : Window
    {
        private MedicinesController medicinesController = new MedicinesController();
        int id;
        public UpdateMedicine()
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

            Medicines medicines = new Medicines(id, medicinesname, medicinesdetail, medicinesalternative);
            medicinesController.UpdateMedicines(medicines);
            id = -1;

            ViewMedicines vr = new ViewMedicines();
            vr.Show();
            Close();
        }
        private void CancelMedicines_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow dr = new DirectorWindow();
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


            }
            catch
            {
                MessageBox.Show("You have to fill in all input boxes!");
            }
        }
    }
}
