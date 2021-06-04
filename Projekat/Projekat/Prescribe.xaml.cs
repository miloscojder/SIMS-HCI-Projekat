
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

namespace Projekat
{
   
    public partial class Prescribe : Window
    {
        public PrescriptionController prescriptionController = new PrescriptionController();
        Patient pe = new Patient();
        public MedicalRecord md;
        public Prescribe(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;
            String status = "Accepted";
            MedicinesRepository medicinesRepository = new MedicinesRepository();
            List<Medicines> medicines = medicinesRepository.GetAllStatus(status);
            dataGrid.ItemsSource = medicines;
            pe.firstName = p.firstName;
            pe.lastName = p.lastName;
            Allergic.Text = p.record.Allergen;
        }

        private void PrescribeMedicine(object sender, RoutedEventArgs e)
        {
            //Prescription pr = new Prescription();
           // Patient pe = new Patient();
            MedicalRecord medicalRecord = new MedicalRecord();
            int ida = prescriptionController.GenerateNewId();
            String med = Medicine.Text;
            //mmm.Allergen = Allergic.Text;
            medicalRecord.Allergen = Allergic.Text;
            String q = Quantity.Text;
            String ins = q + "x" + Instruction.Text + " pill per day";
           
            

            if (med == medicalRecord.Allergen)
            {
                MessageBox.Show("YOU ENTERED PATIENTS ALLERGEN!");
                
            } else
            {


                Prescription a = new Prescription(ida, med, q, ins, pe);
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

        private void LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Close();

        }

        private void View(object sender, RoutedEventArgs e)
        {
            Prescription.Text = "Patient: " + pe.firstName.ToString() + " " + pe.lastName.ToString() + "\n" + "Medicine: " + Medicine.Text + "\n" + "Instruction: " + Quantity.Text + " box " + Instruction.Text + " pill per day";
        }

        private void Select(object sender, RoutedEventArgs e)
        {
            Medicines m = (Medicines)dataGrid.SelectedItems[0];
            Medicine.Text = m.Name;
        }
    }
}
