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
        int id;

        public ShowUpdate(Anamnesis  an)
        {
            InitializeComponent();

            AnamnesisRepository anamnesisRepository = new AnamnesisRepository();
            List<Anamnesis> anamnesses = anamnesisRepository.GetAll();
            dataGrid.ItemsSource = anamnesses;
            Anam.Text = an.anamnesy;
            FirstName.Text = an.patient.firstName;
            LastName.Text = an.patient.lastName;
            id = an.id;
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            String anam = Anam.Text;
            Patient p = new Patient();
            p.firstName = FirstName.Text;
            p.lastName = LastName.Text;

            Anamnesis an = new Anamnesis(id, anam, p);
            anamnesisController.UpdateAnamnesis(an);

            Anamnesiss ap = new Anamnesiss();
            ap.Show();



        }
    }
}
