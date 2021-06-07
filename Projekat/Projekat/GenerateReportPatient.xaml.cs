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
using System.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Controller;
using Model;
using Syncfusion.Pdf.Grid;
using System.Data;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for GenerateReportPatient.xaml
    /// </summary>
    public partial class GenerateReportPatient : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public List<Appointment> appoitnemnts = new List<Appointment>();
        
        public GenerateReportPatient()
        {
            InitializeComponent();
            this.DataContext = this;
            SetCommands();

            appoitnemnts = appointmentController.GetAppointmentsByPatientsUsername(PatientMainPage.prenosilac.Username);
            

        }

        private RelayCommand createReportCommand;
        public RelayCommand CreateReportCommand
        {
            get { return createReportCommand; }
            set
            {
                createReportCommand = value;
            }
        }

        private RelayCommand returnCommand;
        public RelayCommand ReturnCommand
        {
            get { return returnCommand; }
            set
            {
                returnCommand = value;
            }
        }

        public Boolean ReturnCanExecute(Object sender)
        {
            return true;
        }

        public void ReturnExecute(Object sender)
        {
            SeeAppointmentListPatient salp = new SeeAppointmentListPatient();
            salp.Show();
            this.Close();
        }

        public Boolean CreateReportCanExecute(Object sender)
        {
            return true;
        }

        public void CreateReportExecute(Object sender)
        {


            if ((StartDatePicker.SelectedDate == null) | (EndDatePicker.SelectedDate == null))
            {
                MessageBox.Show("You must pick start and end time!");
            }
            else
            {
                List<Appointment> wantedPeriod = new List<Appointment>();
                int counter = 0;

                foreach(Appointment a in appoitnemnts)
                {
                    if ((a.StartTime > StartDatePicker.SelectedDate)&& (a.StartTime < EndDatePicker.SelectedDate))
                    {
                        wantedPeriod.Add(a);
                        counter++;
                    }
                }

                MessageBox.Show("You created pdf report!");

                PdfDocument doc = new PdfDocument();
               
                PdfPage page = doc.Pages.Add();
               
                PdfGrid pdfGrid = new PdfGrid();
                PdfStringFormat drawFormat = new PdfStringFormat();
                PdfGraphics graphics = page.Graphics;
                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
                PdfFont font1 = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
                RectangleF bounds = new RectangleF(new PointF(10, 10), new SizeF(page.Graphics.ClientSize.Width - 30, page.Graphics.ClientSize.Height - 20));

                graphics.DrawString("Report for you!", font, PdfBrushes.Black, bounds.X+200, bounds.Y , drawFormat);
                graphics.DrawString("These are appointments for time period that you picked: ", font1, PdfBrushes.Black,bounds.X,bounds.Y+40, drawFormat);
               
                DataTable dataTable = new DataTable();
                
                dataTable.Columns.Add("Date");
                dataTable.Columns.Add("Doctor");
                dataTable.Columns.Add("Room");

                for (int i = 0; i < counter; i++) {
                    dataTable.Rows.Add(new object[] {wantedPeriod[i].StartTime,wantedPeriod[i].DoctorUsername ,wantedPeriod[i].RoomName });               
                }
                    
                pdfGrid.DataSource = dataTable;
               
                pdfGrid.Draw(page, new PointF(10, 90));

                graphics.DrawString("Enjoy your day and stay healty and care for others!", font1, PdfBrushes.Black, bounds.X, bounds.Y + 240, drawFormat);


                doc.Save(@"C:\Projekat Sims\SIMS-HCI-Projekat\Projekat\Projekat\Report\Proba.pdf");
                SeeAppointmentListPatient salp = new SeeAppointmentListPatient();
                salp.Show();
                this.Close();
            }
            
        }


        public void SetCommands()
        {
            ReturnCommand = new RelayCommand(ReturnExecute, ReturnCanExecute);
            CreateReportCommand = new RelayCommand(CreateReportExecute, CreateReportCanExecute);
        }
    }
}
