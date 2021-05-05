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

    public partial class ViewMedecine : Window
    {
        private MedicinesController medicinesController = new MedicinesController();

       
        public ViewMedecine()
        {
            InitializeComponent();

            MedicinesRepository medicinesRepository = new MedicinesRepository();
            List<Medicines> rooms = medicinesRepository.GetAll();
            dataGrid.ItemsSource = rooms; ;
        }

        
    }
}
