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
    /// Interaction logic for ViewMedicines.xaml
    /// </summary>
    public partial class ViewMedicines : Window
    {
        private MedicinesController medicinesController = new MedicinesController();
        public ViewMedicines()
        {
            InitializeComponent();
            MedicinesRepository medicinesRepository = new MedicinesRepository();
            List<Medicines> rooms = medicinesRepository.GetAll();
            dataGridMedicines.ItemsSource = rooms;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow director = new DirectorWindow();
            director.Show();
            Close();
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
    }
}
