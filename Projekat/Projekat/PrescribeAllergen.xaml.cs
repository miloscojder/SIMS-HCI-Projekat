
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

namespace Projekat
{
   
    public partial class PrescribeAllergen : Window
    {
        int ida;
        public PrescriptionController prescriptionController = new PrescriptionController();
        //public MedicalRecord md;
        public PrescribeAllergen(Prescription p, Patient pe)
        {
            InitializeComponent();
            this.DataContext = this;
            Name.Text = pe.firstName;
            Surname.Text = pe.lastName;
           // Allergic.Text = pe.record.Allergen;
            ida = p.Id;
            Medicine.Text = p.Medicine;
            Quantity.Text = p.Quantity;
            Instruction.Text = p.Instruction;
        }

        private void PrescribeMedicine(object sender, RoutedEventArgs e)
        {
            Prescription pr = new Prescription();
            Patient p = new Patient();
            MedicalRecord mmm = new MedicalRecord();
            pr.Id = ida;
            pr.Medicine = Medicine.Text;
            mmm.Allergen = Allergic.Text;
            pr.Quantity = Quantity.Text;
            pr.Instruction = Instruction.Text;
            p.firstName = Name.Text;
            p.lastName = Surname.Text;

            if (pr.Medicine == mmm.Allergen)
            {
                MessageBox.Show("You entered patients allergen!");
                this.Close();
                String medi = pr.Medicine;
                mmm.Allergen = Allergic.Text;
                String qe = pr.Quantity;
                String insi = pr.Instruction;
                p.firstName = Name.Text;
                p.lastName = Surname.Text;
                Prescription pre = new Prescription(ida, medi, qe, insi, p);
                PrescribeAllergen prr = new PrescribeAllergen(pre, p);
                prr.Show();

            } else
            {
                Prescription a = new Prescription(ida, pr.Medicine, pr.Quantity, pr.Instruction, p);
                prescriptionController.CreatePrescription(a);


                MessageBox.Show("Medicine prescribed!");
                this.Close();

                Prescriptions ap = new Prescriptions();
                ap.Show();
                Close();
            }

        }
    }
}
