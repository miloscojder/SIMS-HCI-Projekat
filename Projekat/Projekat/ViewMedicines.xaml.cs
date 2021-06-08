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
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Model;
using Controller;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for ViewMedicines.xaml
    /// </summary>
    public partial class ViewMedicines : Window
    {
        private MedicinesController medicinesController = new MedicinesController();
        int id;
        
        public ViewMedicines()
        {
            InitializeComponent();
            MedicinesRepository medicinesRepository = new MedicinesRepository();
            List<Medicines> medicines = medicinesRepository.GetAll();
            dataGridMedicines.ItemsSource = medicines;


        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow director = new DirectorWindow();
            director.Show();
            Close();
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            DirectorCorectingRejectingMedicine dcrm = new DirectorCorectingRejectingMedicine();
            dcrm.Show();
            
        }

        private void DeleteMedicine_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Medicines medicines = (Medicines)dataGridMedicines.SelectedItems[0];
                medicinesController.DeleteMedicines(medicines.Id);
            }
            catch
            {
                MessageBox.Show("You have to select a room to delete!");
            }
        }

 /*       private void RejectedMedShow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Medicines med = (Medicines)dataGridRejectedMedicines.SelectedItems[0];
                id = med.Id;
                createMedicine.Visibility = Visibility.Collapsed;
                rejectMedicine.Visibility = Visibility.Visible;
                

                name.Text = med.Name;
                details.Text = med.Details;

            }
            catch
            {
                MessageBox.Show("You have to fill in all input boxes!");
            }
        }*/

 /*       private void Reject_Medicine_Click(object sender, RoutedEventArgs e)
        {
            int id = medicinesController.GenerateNewId();
            string medicineName = name.Text;
            string medicineDetails = details.Text;
            string medicineAlternative = alternative.Text;
            Medicines newMedicine = new Medicines(id, medicineName, medicineDetails, medicineAlternative);
            medicinesController.UpdateMedicines(newMedicine);
            id = -1;
        }*/
 /*       private void New_Medicine_Click(object sender, RoutedEventArgs e)
        {
            int id = medicinesController.GenerateNewId();
            string medicineName = name.Text;
            string medicineDescription = details.Text;

            Medicines med = new Medicines(id, medicineName, medicineDescription, " ");
            
            
            try
            {
                medicinesController.Save(med);
            }
            catch
            {
                MessageBox.Show("You have to fill in all input boxes!");
            }*/
        }
    }

