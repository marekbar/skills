using marekbar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Skills
{
    public partial class JobWindow : Form
    {
        public Job Job = Job.New();
        public bool NeedSave = false;
        private List<int> ids = new List<int>();

        public JobWindow()
        {
            InitializeComponent();
        }

        public void clear(object sender, EventArgs args)
        {
            Job.Clear();
            setJob(Job);
        }

        public void back(object sender, EventArgs args)
        {
            this.Close();
        }

        public void save(object sender, EventArgs args)
        {
            Job.Name = JobTitle.Text;
            Job.Description = Description.Text;
            Job.FromDate = From.Value;
            Job.ToDate = To.Value;
            Job.EmployerKey = ids.Count > 0 ? ids.ToArray()[Employer.SelectedIndex] : 0;
            NeedSave = true;
            this.Close();
        }

        public void setJob(Job job)
        {
            JobTitle.Text = job.Name;
            Description.Text = job.Description;
            From.Value = job.FromDate;
            To.Value = job.ToDate;
        }

        public void SetEmployerList(ref List<Employer> list)
        {
            int index = 0;
            int select = index;
            foreach(var employer in list)
            {
                Employer.Items.Add(employer.Name);
                ids.Add(employer.Id);
                index++;
                if (employer.Id == Job.EmployerKey)
                {
                    select = index;
                }
            }

            if (list.Count > 0)
            {
                Employer.SelectedIndex = select;
            }
        }
    }
}
