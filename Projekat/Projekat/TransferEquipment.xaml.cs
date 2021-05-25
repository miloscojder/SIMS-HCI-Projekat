using Controller;
using Model;
using Repository;
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
   
    public partial class TransferEquipment : Window
    {
        public TransferEquipment()
        {
            InitializeComponent();
            dynamicEquipments = dynamicEquipmentController.GetAll();
            dataGridDynamicEquipment.ItemsSource = dynamicEquipments;
            lb_transfers.Items.Clear();
            IspisivanjeSpiskaDinamickeOpreme();
        }

        DynamicEquipmentController dynamicEquipmentController = new DynamicEquipmentController();
        List<DynamicEquipment> dynamicEquipments = new List<DynamicEquipment>();
        EquipmentType eqType1 = (EquipmentType)1;
        int id1;


        private void IspisivanjeSpiskaDinamickeOpreme() {
            var spisakDinamickeOpreme = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\dynamicTransfer.txt";

            foreach (string line in File.ReadAllLines(spisakDinamickeOpreme))
            {
                lb_transfers.Items.Add(line);
            }

        }


        private void MoveDynamic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DynamicEquipment equipment = (DynamicEquipment)dataGridDynamicEquipment.SelectedItems[0];
                id1 = equipment.Id;
                cancelMoving.Visibility = Visibility.Visible;

                dynamicName.Text = equipment.Name;
                dynamicQuantity.Text = equipment.Quantity.ToString();
            }
            catch
            {
                MessageBox.Show("You have to fill in all input boxes!");
            }

            }
        private void CancelDynamic_Click(object sender, RoutedEventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
            Close();
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {
            string textname = dynamicName.Text;
            int quantity = Int32.Parse(dynamicQuantity.Text);
            DynamicEquipment equipment = new DynamicEquipment(id1, textname, eqType1, quantity);
            dynamicEquipmentController.MoveDynamicEquipment(equipment);
           
            id1 = -1;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    
}
