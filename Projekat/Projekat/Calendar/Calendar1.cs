using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Calendar
{
    public class Calendar1 : Control
    {
        public ObservableCollection<Day1> Days { get; set; }
        public ObservableCollection<string> DayNames { get; set; }
        public static readonly DependencyProperty CurrentDateProperty = DependencyProperty.Register("CurrentDate", typeof(DateTime), typeof(Calendar1));

        public event EventHandler<DayChangedEventArgs> DayChanged;

        public DateTime CurrentDate
        {
            get { return (DateTime)GetValue(CurrentDateProperty); }
            set { SetValue(CurrentDateProperty, value); }
        }

        static Calendar1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Calendar1), new FrameworkPropertyMetadata(typeof(Calendar1)));
        }

        public Calendar1()
        {
            DataContext = this;
            CurrentDate = DateTime.Today;

       
            DayNames = new ObservableCollection<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Days = new ObservableCollection<Day1>();
            BuildCalendar(DateTime.Today);
        }

        public void BuildCalendar(DateTime targetDate)
        {
            Days.Clear();

            //Calculate when the first day of the month is and work out an 
            //offset so we can fill in any boxes before that.
            DateTime d = new DateTime(targetDate.Year, targetDate.Month, 1);
            int offset = DayOfWeekNumber(d.DayOfWeek);
            if (offset != 1) d = d.AddDays(-offset);
  
            //Show 6 weeks each with 7 days = 42
            for (int box = 1; box <= 42; box++)
            {
                Day1 day = new Day1 { Date = d, Enabled = true, IsTargetMonth = targetDate.Month == d.Month };
                day.PropertyChanged += Day_Changed;
                day.IsToday = d == DateTime.Today;
                Days.Add(day);
                d = d.AddDays(1);
            }
        }

        private void Day_Changed(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Notes") return;
            if (DayChanged == null) return;

            DayChanged(this, new DayChangedEventArgs(sender as Day1));
        }

        private static int DayOfWeekNumber(DayOfWeek dow)
        {
            return Convert.ToInt32(dow.ToString("D"));
        }
    }

    public class DayChangedEventArgs : EventArgs
    {
        public Day1 Day1 { get; private set; }
        public DayChangedEventArgs(Day1 Day1)
        {
            this.Day1 = Day1;
        }
    }

}
