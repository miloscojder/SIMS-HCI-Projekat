using Controller;
using Model;
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

namespace Projekat
{

    public partial class TransferStaticEquipment : Window
    {
        private StaticEquipmentController staticEquipmentController = new StaticEquipmentController();
        private RoomController roomController = new RoomController();
        private List<StaticEquipment> staticEquipments = new List<StaticEquipment>();
        int id;

        public TransferStaticEquipment()
        {
            InitializeComponent();
            staticDataGrid.ItemsSource = staticEquipmentController.GetAll();
        }

        private void MoveToTransfer_Click(object sender, RoutedEventArgs e)
        {
            StaticEquipment equipment = (StaticEquipment)staticDataGrid.SelectedItems[0];
            acceptButton.Visibility = Visibility.Visible;
            cancelButton.Visibility = Visibility.Visible;

            id = equipment.Id;
            name.Text = equipment.Name;
            toRoom.Text = equipment.RoomId.ToString();
        }

        private void AcceptTransfer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime pickerDate = transfer_date.SelectedDate.Value;
                DateTime TransferDateTime = new DateTime(pickerDate.Year, pickerDate.Month, pickerDate.Day, 00, 00, 00);
                roomController.MoveStaticEquipment(id, Int32.Parse(toRoom.Text), TransferDateTime);
                id = -1;
                CancelTransfer_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Please enter the date of transfer");
            }
        }
            private void CancelTransfer_Click(object sender, RoutedEventArgs e)
            {
                name.Text = "";
                toRoom.Text = "";
                acceptButton.Visibility = Visibility.Collapsed;
                cancelButton.Visibility = Visibility.Collapsed;
            }

        }
    }

