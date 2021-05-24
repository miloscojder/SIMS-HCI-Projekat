
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
using Repository;

namespace Projekat
{
   
    public partial class ScheduleOperation : Window
    {
        public OperationController operationController = new OperationController();
        public DynamicEquipmentController dynamicEquipmentController = new DynamicEquipmentController();
        public StaticEquipmentController staticEquipmentController = new StaticEquipmentController();
        public ScheduleOperation(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;
            StaticEquipmentRepository staticEquipmentRepository = new StaticEquipmentRepository();
            List<StaticEquipment> staticEquipments = staticEquipmentRepository.GetAll();
            dataGrid1.ItemsSource = staticEquipments;

            Name.Text = p.firstName;
            Surname.Text = p.lastName;
        }

        private void Select(object sender, RoutedEventArgs e) 
        {
            
                StaticEquipment s = (StaticEquipment)dataGrid1.SelectedItems[0];

            RoomName.Text = s.room.Name;
        }

        private void Schedule(object sender, RoutedEventArgs e)
        {


            int ida = operationController.GenerateNewId();
            String date = Date.Text;
            String hours = Hours.Text;
            String minutes = Minutes.Text;
            String hourss = Hourss.Text;
            String minutess = Minutess.Text;
            String start = hours + ":" + minutes;
            String end = hourss + ":" + minutess;
            String duration = Duration.Text;

            Patient p = new Patient();
            p.firstName = Name.Text;
            p.lastName = Surname.Text;

           // StaticEquipment a = (StaticEquipment)dataGrid1.SelectedItems[0];
           // DynamicEquipment d = (DynamicEquipment)dataGrid2.SelectedItems[0];

          //  RoomName.Text = a.room.Name;
            //RoomName.Text = d.room.Name;

            Room r = new Room();
            r.Name = RoomName.Text;


            Operations o = new Operations(ida, date, start, duration, end, r, p);
            operationController.ScheduleOperation(o);

            Operationss ap = new Operationss();
            ap.Show();
            Close();

           
        }

      
    }
}
