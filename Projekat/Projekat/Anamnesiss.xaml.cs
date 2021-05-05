using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Repository;
using Controller;

namespace Projekat
{

    public partial class Anamnesiss : Window
    {
        public AnamnesisController anamnesisController = new AnamnesisController();
        public List<Anamnesis> anamneses
        {
            get;
            set;
        }
        public Anamnesiss()
        {
            InitializeComponent();
            AnamnesisRepository anamnesisRepository = new AnamnesisRepository();
            List<Anamnesis> anamneses = anamnesisRepository.GetAll();
            dataGrid.ItemsSource = anamneses;
        }

       

        private void Update(object sender, RoutedEventArgs e)
        {
           
            Anamnesis a = (Anamnesis)dataGrid.SelectedItems[0];
            ShowUpdate sc = new ShowUpdate(a);
            sc.Show();
            Close();


        }

       
    }
}
