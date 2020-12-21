
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Calendar
{
    public partial class Form1 : Form
    {
        #region Peoperties
        private string filePath = "data.xml";
        private List<List<Button>> matrix;
        private PlanData job;
        public PlanData Job { get => job; set => job = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
      

        private List<string> dayOfWeeks = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        
        public Form1()
        {
            InitializeComponent();
            loadMatrix();
            try
            {
               Job = DeserializeFromXML(filePath) as PlanData;
            }
            catch { setDefaultJob(); }
            }
        void setDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem()
            { Date = DateTime.Now, 
                StartTime = new Point(4, 0), 
                EndTime = new Point(5, 0), 
                Job = "Test Data", 
                Status = PlanItem.listStatus[(int)EPlanItem.COMING]
            });
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                StartTime = new Point(5, 0),
                EndTime = new Point(5, 0),
                Job = "Test Data",
                Status = PlanItem.listStatus[(int)EPlanItem.COMING]
            });
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                StartTime = new Point(5, 0),
                EndTime = new Point(5, 0),
                Job = "Test Data",
                Status = PlanItem.listStatus[(int)EPlanItem.COMING]
            });
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                StartTime = new Point(5, 0),
                EndTime = new Point(5, 0),
                Job = "Test Data",
                Status = PlanItem.listStatus[(int)EPlanItem.COMING]
            });
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                StartTime = new Point(5, 0),
                EndTime = new Point(5, 0),
                Job = "Test Data",
                Status = PlanItem.listStatus[(int)EPlanItem.COMING]
            });
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now.AddDays(-1),
                StartTime = new Point(5, 0),
                EndTime = new Point(5, 0),
                Job = "Test Data",
                Status = PlanItem.listStatus[(int)EPlanItem.COMING]
            });
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            addNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }
        void SetDefaultDay()
        {
            dtPicker.Value = DateTime.Now;
        }
       
        //Tạo button ngày trong tháng.
        void loadMatrix()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(0, 0)
            };
           
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.DateButtonWidth, Height = Cons.DateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y);
                    btn.Click += btn_Click;
                    panelDayOfMonth.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldBtn = btn;
                    oldBtn.FlatStyle = FlatStyle.Flat;
                    oldBtn.FlatAppearance.BorderColor = Color.YellowGreen;
                   
                }
                oldBtn = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(0, oldBtn.Location.Y + Cons.DateButtonHeight)
                };
               
            }

            SetDefaultDay();
           // addNumberIntoMatrixByDate(dtPicker.Value);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((sender as Button).Text))
                return;
            Form2 daily = new Form2( new DateTime(dtPicker.Value.Year, dtPicker.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            daily.ShowDialog();
        }


        //Kiểm tra số ngày của tháng bất kỳ
        int DayOfMonth( DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if (date.Year % 4 == 0 && date.Year % 100 != 0 || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;

            }
        }
        //Thêm button vào trang lịch
        void addNumberIntoMatrixByDate(DateTime date)
        {
            clearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
           
            int line = 0;
            for(int i = 1; i<=DayOfMonth(date); i++)
            {
                int col = dayOfWeeks.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][col];
                btn.Text = i.ToString();
                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }
                if (isEqualDate(useDate, date))
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.Red;
                    btn.FlatAppearance.BorderSize = 1;
                }
                if (col >= 6)
                    line++;
                useDate = useDate.AddDays(1);
                
            }
        }
       
        void clearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.Empty;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.FlatAppearance.BorderSize = 1;


                }
            }
        }
        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        private void btnPre_Click(object sender, EventArgs e)
        {
            dtPicker.Value = dtPicker.Value.AddMonths(-1);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            dtPicker.Value = dtPicker.Value.AddMonths(1);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefaultDay();
        }

        //Lưu trữ dữ liệu xuống file dạng .xml
        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(PlanData));
            xs.Serialize(fs,data);
            fs.Close();
        }
        //Load dữ liệu từ file .xml lên.
       private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(PlanData));
                object result = xs.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch(Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
            }
          
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filePath); 
        }
    }
}