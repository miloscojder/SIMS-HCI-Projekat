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

    public partial class ViewSchedule : Window
    {
        public AppointmentController appointmentController = new AppointmentController();

        public List<Appointment> Appointmentsa
        {
            get;
            set;
        }
        public ViewSchedule()
        {
            InitializeComponent();

            AppointmentRepository appointmentRepository = new AppointmentRepository();
            List<Appointment> appointments = appointmentRepository.GetAll();
            dataGrid.ItemsSource = appointments;
            OperationRepository operationRepository = new OperationRepository();
            List<Operations> operations = operationRepository.GetAll();
            dataGrid.ItemsSource = operations;
        }

        
    }
}
