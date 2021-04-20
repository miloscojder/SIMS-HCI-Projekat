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
  
    public partial class ShowUpdate : Window
    {

        public List<Anamnesis> anamnesses
        {
            get;
            set;
        }
        public ShowUpdate(Anamnesis  an)
        {
            InitializeComponent();
            this.DataContext = this;


            anamnesses = new List<Anamnesis>();

            anamnesses.Add(an);
            
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Anamnesis a = (Anamnesis)dataGrid.SelectedItems[0];
           
            
            String anamnesis = (String)Anam.Text;
            String id = Convert.ToString(Id.Text);
           
   
            String line1;
            using (StreamReader file = new StreamReader(@"C:/Users/krist/Desktop/Projekat/anamnesis.txt"))
            {

                while ((line1 = file.ReadLine()) != null)
                {
                    string[] parts = line1.Split(',');
                    line1 = anamnesis + id;
                   

                  
                }

                file.Close();
            }

           

        }
    }
}
