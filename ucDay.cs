using System;
using System.Drawing;
using System.Windows.Forms;

namespace Event_Calender
{
    public partial class ucDay : UserControl
    {
        MainForm MainForm;
        public ucDay(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void ucDay_Load(object sender, EventArgs e)
        {

        }

        public void Update(DateTime day)
        {
            lblDate.Text = day.Day.ToString();

            if (day.Month != MainForm.SelectedDate.Month) {
                panel1.BackColor = Color.FromArgb(160, 160, 160);
            }
            else {
                panel1.BackColor = Color.White;
            }
        }
    }
}
