using Controller;
using Model;
using Projekat.Controller;
using Projekat.Model;
using Service;
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
        private MovingStaticEquipmentController movingStaticController = new MovingStaticEquipmentController();
        private List<StaticEquipment> staticEquipments = new List<StaticEquipment>();
        private readonly RoomController roomController = new RoomController();
        int staticId;

        public TransferStaticEquipment()
        {
            InitializeComponent();
            staticDataGrid.ItemsSource = staticEquipmentController.GetAll();
            MovingStaticEquipment();
        }

        //proverava datum pri pokretanju
        private void MovingStaticEquipment()
        {
            List<MovingStaticEquipment> listOfStatic = movingStaticController.GetAll();
            foreach (MovingStaticEquipment staticToMove in listOfStatic)
            {
                if (staticToMove.DateTime.Ticks <= DateTime.Now.Ticks)
                {
                    roomController.MoveStaticEquipment(staticToMove.StaticId, staticToMove.RoomId);
                    movingStaticController.DeleteEquipment(staticToMove.Id);
                }

            }
        }

            private void MoveToTransfer_Click(object sender, RoutedEventArgs e)
        {
            StaticEquipment equipment = (StaticEquipment)staticDataGrid.SelectedItems[0];
            acceptButton.Visibility = Visibility.Visible;
            cancelButton.Visibility = Visibility.Visible;

            staticId = equipment.Id;
            name.Text = equipment.Name;
            toRoom.Text = equipment.RoomId.ToString();
        }

        private void AcceptTransfer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime pickerDate = SelectedDate();
                int id = movingStaticController.GenerateNewId();
                int roomId = Int32.Parse(toRoom.Text);
                MovingStaticEquipment movingStatic =  new MovingStaticEquipment(id, staticId, roomId, pickerDate);
                movingStaticController.Save(movingStatic);
                staticId = -1;
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
        private DateTime SelectedDate()
        {
            DateTime pickedDate = date.SelectedDate.Value;
            int hours = Int32.Parse(startTime.Text.Split(':')[0]);
            int minutes = Int32.Parse(startTime.Text.Split(':')[1]);
            DateTime renovationDateTime = new DateTime(pickedDate.Year, pickedDate.Month, pickedDate.Day, hours, minutes, 00);
            return renovationDateTime;
        }

    }
    }

