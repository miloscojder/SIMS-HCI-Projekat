using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Model;
using Controller;
using Repository;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for ViewEquipment.xaml
    /// </summary>
    public partial class ViewEquipment : Window
    {
        private StaticEquipmentController staticEquipmentController = new StaticEquipmentController();
        private DynamicEquipmentController dynamicEquipmentController = new DynamicEquipmentController();
        int id;
        int id1;
        EquipmentType eqType;
        EquipmentType eqType1;
        public ViewEquipment()
        {
            InitializeComponent();
            StaticEquipmentRepository staticEquipmentRepository = new StaticEquipmentRepository();
            List<StaticEquipment> staticEquipments = staticEquipmentRepository.GetAll();
            dataGridStaticEquipment.ItemsSource = staticEquipments;

            DynamicEquipmentRepository dynamicEquipmentRepository = new DynamicEquipmentRepository();
            List<DynamicEquipment> dynamicEquipments = dynamicEquipmentRepository.GetAll();
            dataGridDynamicEquipment.ItemsSource = dynamicEquipments;

        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StaticEquipment equipment = (StaticEquipment)dataGridStaticEquipment.SelectedItems[0];

                id = equipment.Id;
                name.Text = equipment.Name;
                eqType = equipment.Type;
                roomId.Text = equipment.RoomId.ToString();
                quantity.Text = equipment.Quantity.ToString();

            }
            catch
            {
                MessageBox.Show("You have to fill in all input boxes!");
            }
            
        }

        private void SelectDynamic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DynamicEquipment equipment = (DynamicEquipment)dataGridDynamicEquipment.SelectedItems[0];

                id1 = equipment.Id;
                name1.Text = equipment.Name;
                eqType1 = equipment.Type;
                quantity1.Text = equipment.Quantity.ToString();

            }
            catch
            {
                MessageBox.Show("You have to fill in all input boxes!");
            }
            
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {

            string equipmentname = name.Text;
            int eqquantity = Int32.Parse(quantity.Text);
            

            StaticEquipment stequipment = new StaticEquipment(id, equipmentname,Int32.Parse(roomId.Text), eqType,eqquantity);
            staticEquipmentController.UpdateEquipment(stequipment);
            id = -1;

            ViewEquipment ve = new ViewEquipment();
            ve.Show();
            
            
        }
        private void UpdateDynamic_Click(object sender, RoutedEventArgs e)
        {

            string equipmentname = name1.Text;
            int eqquantity = Int32.Parse(quantity1.Text);


            DynamicEquipment dtequipment = new DynamicEquipment(id1, equipmentname, eqType1, eqquantity);
            dynamicEquipmentController.UpdateEquipment(dtequipment);
            id1 = -1;

            ViewEquipment ve = new ViewEquipment();
            ve.Show();
            
        }
        private void TransferDynamic_Click(object sender, RoutedEventArgs e)
        {
            TransferEquipment dynamicTransfer = new TransferEquipment();
            dynamicTransfer.Show();

        }
        private void TransferStatic_Click(object sender, RoutedEventArgs e)
        {
            TransferStaticEquipment staticTransfer = new TransferStaticEquipment();
            staticTransfer.Show();

        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            CreateEquipment ce = new CreateEquipment();
            ce.Show();
            Close();
        }

        private void CreateDynamic_Click(object sender, RoutedEventArgs e)
        {
            CreateDynamicEquipment ce = new CreateDynamicEquipment();
            ce.Show();
            Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StaticEquipment staticEquipment = (StaticEquipment)dataGridStaticEquipment.SelectedItems[0];
                staticEquipmentController.DeleteEquipment(staticEquipment.Id);
                Close();            }
            catch
            {
                MessageBox.Show("You have to select a room to delete!");
            }
            
        }

        private void DeleteDynamic_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               DynamicEquipment dynamicEquipment = (DynamicEquipment)dataGridDynamicEquipment.SelectedItems[0];
                dynamicEquipmentController.DeleteEquipment(dynamicEquipment.Id);
            }
            catch
            {
                MessageBox.Show("You have to select a room to delete!");
            }
            
        }
    }
}
