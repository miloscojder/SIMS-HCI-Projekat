using Controller;
using Model;
using Newtonsoft.Json;
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
    /// <summary>
    /// Interaction logic for DoctorAssessment.xaml
    /// </summary>
    public partial class DoctorAssessment : Window
    {
        private DoctorController doctorController = new DoctorController();
        private List<Doctor> doctors = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Data\\doctorsak.json"));

        public DoctorAssessment()
        {
            InitializeComponent();
            doctorAssessmentDataGrid.ItemsSource = doctors;
        }
    }
}
