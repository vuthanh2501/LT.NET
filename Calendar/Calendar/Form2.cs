using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form2 : Form
    {
        private DateTime date;
        private PlanData job;
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public Form2(DateTime date, PlanData job)
        {
            InitializeComponent();
            this.Date = date;
            this.Job = job;
            
            fPanel.Width = panel2.Width;
            fPanel.Height = panel2.Height;
            panel2.Controls.Add(fPanel);
            
            dateTimePicker1.Value = Date;

        }
        void ShowJobByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (Job != null && Job.Job != null)
            {
                List<PlanItem> todayJob = GetJobByDate(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                   addJob(todayJob[i]);
                   
                }
            }
        }

        private void AJob_Edited(object sender, EventArgs e)
        {
            
        }

        private void AJob_Deleted(object sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            PlanItem job = uc.Job;
            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }
        void addJob(PlanItem job)
        {
            AJob aJob = new AJob(job);
            aJob.Edited += AJob_Edited;
            aJob.Deleted += AJob_Deleted;
            fPanel.Controls.Add(aJob);
        }

        List<PlanItem> GetJobByDate(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();

        }
        public DateTime Date { get => date; set => date = value; }
        public PlanData Job { get => job; set => job = value; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        

        private void todayLB_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void addJobLb_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { Date = dateTimePicker1.Value };
            Job.Job.Add(item);
            addJob(item);
        }
    }
}
