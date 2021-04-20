using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using Controller;
using Repository;

namespace Projekat
{
  
    public partial class ShowUpdate : Window
    {
        public AnamnesisController anamnesisController = new AnamnesisController();


        public List<Anamnesis> anamnesses
        {
            get;
            set;
        }
        public ShowUpdate(Anamnesis  an)
        {
            InitializeComponent();

            AnamnesisRepository anamnesisRepository = new AnamnesisRepository();
            List<Anamnesis> anamnesses = anamnesisRepository.GetAll();
            dataGrid.ItemsSource = anamnesses;

        }

        private void Save(object sender, RoutedEventArgs e)
        {
            String ida = Id.Text;
            String anam = Anam.Text;
            


            Anamnesis a = new Anamnesis(ida, anam);
            anamnesisController.UpdateAnamnesis(a);

            Anamnesiss ap = new Anamnesiss();
            ap.Show();



        }
    }
}
