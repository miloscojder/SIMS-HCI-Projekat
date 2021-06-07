
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
using LiveCharts.Wpf;
using LiveCharts;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for ChartDoctorRatings.xaml
    /// </summary>
    public partial class ChartDoctorRatings : Window
    {

        public DoctorController doctorController = new DoctorController();


        public ChartDoctorRatings()
        {
            InitializeComponent();
            SetCommand();

            List<string> usernames = new List<string>();
            List<double> grades = new List<double>();
            List<Doctor> doctors = doctorController.GetAllDoctors();

            for (int i = 0; i < doctors.Count; i++)
            {
                grades.Add(doctors[i].Grade);
                usernames.Add(doctors[i].Username);
            }
            
            SeriesCollection = new SeriesCollection();

            ChartValues<double> nesto = new ChartValues<double>();
            for(int i =0; i<grades.Count; i++)
            {
                nesto.Add(grades[i]);
            }

            SeriesCollection.Add(new ColumnSeries { Title = "Rating", Values = nesto });

            DoctorUsernameLabels = new string[doctors.Count];
            for(int i =0; i<doctors.Count; i++)
            {
                DoctorUsernameLabels[i] = usernames[i];
            }

            Formatter = value => value.ToString("N");

            this.DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] DoctorUsernameLabels { get; set; }
        

        public Func<double, string> Formatter { get; set; }

        private RelayCommand returnCommand;
        public RelayCommand ReturnCommand
        {
            get { return returnCommand; }
            set
            {
                returnCommand = value;
            }
        }

        public Boolean ReturnCanExecute(object sender)
        {
            return true;
        }

        public void ReturnExecute(object sender)
        {
            HospitalViewPatientPage hvpp = new HospitalViewPatientPage(null);
            hvpp.Show();
            this.Close();
        }

        public void SetCommand()
        {
            ReturnCommand = new RelayCommand(ReturnExecute, ReturnCanExecute);
        }

    }
}
