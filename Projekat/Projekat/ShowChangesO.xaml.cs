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
  
    public partial class ShowChangesO : Window
    {
        public OperationController operationController = new OperationController();

        public List<Operations> operations
        {
            get;
            set;
        }
        int id;
        Room room = new Room();
        Patient patient = new Patient();
        public ShowChangesO(Operations op)
        {
            InitializeComponent();

        OperationRepository operationRepository = new OperationRepository();
        List<Operations> operations = operationRepository.GetAll();
        dataGrid.ItemsSource = operations;
            Date.Text = op.Date;
            Duration.Text = op.Duration;
            String hours = "";
            String minutes = "";
            Hourss.Text = hours;
            Minutess.Text = minutes;
            String start = hours + ":" + minutes;
            start = op.TimeStart;
            String hours1 = "";
            String minutes1 = "";
            Hours.Text = hours1;
            Minutes.Text = minutes1;
            String end = hours1 + ":" + minutes1;
            end = op.EndTime;
            id = op.id;
            room.Name = op.room.Name;
            patient.firstName = op.patient.firstName;
            patient.lastName = op.patient.lastName;

        }

    private void Save(object sender, RoutedEventArgs e)
    {

            String date = Date.Text;
            String hours = Hours.Text;
            String minutes = Minutes.Text;
            String hourss = Hourss.Text;
            String minutess = Minutess.Text;
            String end = hours + ":" + minutes;
            String start = hourss + ":" + minutess;
            String duration = Duration.Text;



             Operations a = new Operations(id, date, start, duration, end, room, patient);
                operationController.RescheduleDoctor(a);

            Operationss ap = new Operationss();
        ap.Show();


    }

       
    }
}
