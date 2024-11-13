using Event_Calender;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Event_Calender
{
    public partial class MainForm : Form
    {
        public DateTime SelectedDate = DateTime.Now;
        ucDay[] Days = new ucDay[42];
        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdateCalender()
        {
            DateTime firstOfMonth = new DateTime(SelectedDate.Year, SelectedDate.Month, 1);
            DateTime prevSun = firstOfMonth.AddDays(-(int)firstOfMonth.DayOfWeek);
            for (int i = 0; i < 42; i++) {
                DateTime date = prevSun.AddDays(i);
                Days[i].Update(date);
            }
            lblYear.Text = SelectedDate.Year.ToString();
            lblMonth.Text = SelectedDate.ToString("MMMM");
        }

        private void btnMonthBack_Click(object sender, EventArgs e)
        {
            SelectedDate = SelectedDate.AddMonths(-1);
            UpdateCalender();
        }

        private void btnMonthForward_Click(object sender, EventArgs e)
        {
            SelectedDate = SelectedDate.AddMonths(1);
            UpdateCalender();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 42; i++) {
                ucDay day = new ucDay(this);
                TablePanel.Controls.Add(day);
                Days[i] = day; 
            }
            UpdateCalender();
        }
    }
}