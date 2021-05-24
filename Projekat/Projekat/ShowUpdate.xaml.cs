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
            Anam.Text = an.Anamnesy;
            FirstName.Text = an.Patient.firstName;
            LastName.Text = an.Patient.lastName;
            id = an.Id;
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
