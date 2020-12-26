using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class AJob : UserControl
    {
        private PlanItem job;
        public AJob(PlanItem job)
        {
            InitializeComponent();
            statusBox.DataSource = PlanItem.listStatus;
            this.Job = job;
            ShowInfo();
        }
        void ShowInfo()
        {
            textBox1.Text = Job.Job;
            nmToHours.Value = Job.StartTime.X;
            nmToMinutes.Value = Job.StartTime.Y;
            nmToHours2.Value = Job.EndTime.X;
            nmToMinutes2.Value = Job.EndTime.Y;
            statusBox.SelectedIndex = PlanItem.listStatus.IndexOf(Job.Status);
            checkBox1.Checked = PlanItem.listStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;

        }

        public PlanItem Job { get => job; set => job = value; }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
