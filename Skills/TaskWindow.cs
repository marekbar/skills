using marekbar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Skills
{
    public partial class TaskWindow : Form
    {
        public Task Task = Task.New();
        public bool NeedSave = false;
        public TaskWindow()
        {
            InitializeComponent();
            Level.SelectedIndex = 0;
        }

        public void save(object sender, EventArgs args)
        {
            Task.Name = NameOfTask.Text;
            Task.Description = Description.Text;
            Task.Date = When.Value;
            Task.Level = (DifficultyLevel)Level.SelectedIndex;
            NeedSave = true;
            this.Close();
        }

        public void back(object sender, EventArgs args)
        {
            this.Close();
        }

        public void setTask(Task task)
        {
            this.NameOfTask.Text = task.Name;
            this.Description.Text = task.Description;
            this.Level.SelectedIndex = (int)task.Level;
            this.When.Value = task.Date;
            this.Task = task;
        }
    }
}
