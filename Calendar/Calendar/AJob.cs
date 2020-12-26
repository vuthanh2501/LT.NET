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
        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove{edited -= value;}
        }
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e){
            

        }
        private void btnEdit_Click(object sender, EventArgs e){
            Job.Job = textBox1.Text;
            Job.StartTime = new Point((int)nmToHours.Value, (int)nmToMinutes.Value);
            Job.EndTime = new Point((int)nmToHours2.Value, (int)nmToMinutes2.Value);
            Job.Status = PlanItem.listStatus[statusBox.SelectedIndex];

            if (edited != null)
                edited(this, new EventArgs());
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            statusBox.SelectedIndex = checkBox1.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
        }
    }
}
