
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
using Controller;
using Projekat.Model;
using Projekat.Repository;
using System.Collections.ObjectModel;


namespace Projekat
{
   
    public partial class Prescribe : Window
    {
        public PrescriptionController prescriptionController = new PrescriptionController();
        public Patient pe = new Patient();
        Point startPoint = new Point();

      

        public Prescribe(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;
            String status = "Accepted";
            MedicinesRepository medicinesRepository = new MedicinesRepository();
            List<Medicines> medicines = medicinesRepository.GetAllStatus(status);
            dataGrid.ItemsSource = medicines;
            pe = p;
            Allergic.Text = p.record.Allergen;

           
        }


        
        private void PrescribeMedicine(object sender, RoutedEventArgs e)
        {
           
            
            int ida = prescriptionController.GenerateNewId();
            Medicines liste = (Medicines)dataGrid.SelectedItems[0];            
            pe.record.Allergen = Allergic.Text;
            string qq = Quantity.Text;
            String q = Quantity.Text + "box";
            String ins = Quantity.Text + "x" + Instruction.Text + " pill per day";



            if (liste.Name == pe.record.Allergen)
            {
                MessageBox.Show("YOU ENTERED PATIENTS ALLERGEN!");
                

            }
            
           
            else {
               

                Prescription a = new Prescription(ida, liste.Name, q, ins, pe);
                prescriptionController.CreatePrescription(a);


                MessageBox.Show("Medicine prescribed!");


                Prescriptions ap = new Prescriptions();
                ap.Show();
                Close();



            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Prescriptions p = new Prescriptions();
            p.Show();
            Close();

        }
        private void Select(object sender, RoutedEventArgs e)
        {

            Medicines s = (Medicines)dataGrid.SelectedItems[0];

            MedicineName.Text = s.Name;
           
        }



        private void View(object sender, RoutedEventArgs e)
        {
           
            Prescription.Text = "Patient: " + pe.firstName.ToString() + " " + pe.lastName.ToString() + "\n" + "Medicine: " + MedicineName.Text + "\n" + "Instruction: " + Quantity.Text + " box " + Instruction.Text + " pill per day";
        }

        
      
    }
}
