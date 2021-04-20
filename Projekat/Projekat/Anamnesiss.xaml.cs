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

namespace Projekat
{

    public partial class Anamnesiss : Window
    {
        public List<Anamnesis> anamneses
        {
            get;
            set;
        }
        public Anamnesiss()
        {
            InitializeComponent();
            this.DataContext = this;

            anamneses = new List<Anamnesis>();
            //AnamnesisFileStorage fajl = new AnamnesisFileStorage(@"C:\Users\krist\Desktop\anamnesis.txt");
           // anamneses = fajl.GetAll();
        }

       

        private void Update(object sender, RoutedEventArgs e)
        {
           
            Anamnesis a = (Anamnesis)dataGridAnamnesis.SelectedItems[0];
            ShowUpdate sc = new ShowUpdate(a);
            sc.Show();


        }

        private void Create(object sender, RoutedEventArgs e)
        {

        
            CreateAnamnesis sa = new CreateAnamnesis();
            sa.Show();


        }
    }
}
