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
    public partial class FormMain : Form
    {
        private enum DataType
        {
            Skill,
            Task,
            Employer,
            Job
        }

        private String SearchHint = "wpisz szukane słowo";

        private Data data = null;
        public FormMain()
        {
            InitializeComponent();
            grid.CellMouseEnter += (a, b) =>
            {
                try
                {
                    if (b.RowIndex != null && b.RowIndex >= 0)
                    {
                        grid.CurrentCell = grid.Rows[b.RowIndex].Cells[0];
                        grid.Rows[b.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Yellow;
                        grid.Rows[b.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                }
                catch { }
            };
        }

        private void dodajUmiejętnośćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var skill = new SkillWindow();
            skill.FormClosing += (window, args) => {
                var child = (SkillWindow)window;
                if (data.Push(child.Skill))
                {
                    status.Text = "Dane uaktualnione";
                    ChooseType.SelectedIndex = 0;
                    ShowInGrid();
                }
                else
                {
                    status.Text = "Nie udało się uaktualnić danych";
                }
            };
            skill.Show();
        }

        private void initialize()
        {
                data = new Data();
                if (data.Error != "")
                {
                    errors.Click += (o, e) => {
                        MessageBox.Show(data.Error, "Awaria", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        errors.Visible = false;
                    };
                    errors.Visible = true;
                    
                }


            ChooseType.SelectedIndex = 0;
            ShowInGrid();
        }

        private void ShowInGrid()
        {
            var names = new String[] { };
            String phrase = searchBox.Text.ToUpper();
            DataType Type = (DataType)ChooseType.SelectedIndex;
            grid.DataSource = null;
            switch (Type)
            {
                case DataType.Skill:
                    {
                        names = Skill.Names;
                        if (phrase == "" || phrase.Contains(SearchHint.ToUpper()))
                        {
                            grid.DataSource = data.Skills;
                        }
                        else
                        {
                            grid.DataSource = data.Skills.Where(col =>
                                col.Id.ToString().Contains(phrase) ||
                                col.Name.ToUpper().Contains(phrase) ||
                                col.Mark.ToString().ToUpper().Contains(phrase) ||
                                col.FromDate.ToString().ToUpper().Contains(phrase) ||
                                col.UpdateDate.ToString().ToUpper().Contains(phrase)
                                ).ToList();
                        }
                    }
                    break;
                case DataType.Task:
                    {
                        names = marekbar.Task.Names;
                        if (phrase == "" || phrase.Contains(SearchHint.ToUpper()))
                        {
                            grid.DataSource = data.Tasks;
                        }
                        else
                        {
                            grid.DataSource = data.Tasks.Where(col =>
                                col.Id.ToString().Contains(phrase) ||
                                col.Name.ToUpper().Contains(phrase) ||
                                col.Description.ToUpper().Contains(phrase) ||
                                col.Date.ToString().ToUpper().Contains(phrase)
                                ).ToList();
                        }
                    }
                    break;
                case DataType.Employer:
                    {
                        names = marekbar.Employer.Names;
                        if (phrase == "" || phrase.Contains(SearchHint.ToUpper()))
                        {
                            grid.DataSource = data.Employers;
                        }
                        else
                        {
                            grid.DataSource = data.Employers.Where(col =>
                                col.Id.ToString().Contains(phrase) ||
                                col.Name.ToUpper().Contains(phrase) ||
                                col.Description.ToUpper().Contains(phrase) ||
                                col.Mail.ToUpper().Contains(phrase) ||
                                col.Phone.ToUpper().Contains(phrase) ||
                                col.Street.ToUpper().Contains(phrase) ||
                                col.BuildingNumber.ToUpper().Contains(phrase) ||
                                col.InternalBuildingNumber.ToUpper().Contains(phrase)
                                ).ToList();
                        }
                    }
                    break;
                case DataType.Job:
                    {
                        names = marekbar.Job.Names;
                        if (phrase == "" || phrase.Contains(SearchHint.ToUpper()))
                        {
                            grid.DataSource = data.Jobs;
                        }
                        else
                        {
                            grid.DataSource = data.Jobs.Where(col =>
                                col.Id.ToString().Contains(phrase) ||
                                col.Name.ToUpper().Contains(phrase) ||
                                col.Description.ToUpper().Contains(phrase) ||
                                col.FromDate.ToString().ToUpper().Contains(phrase) ||
                                col.ToDate.ToString().ToUpper().Contains(phrase)
                                ).ToList();
                        }
                    }
                    break;
            }
            grid.Refresh();

            int width = 60;
            int height = 150;
            for (int i = 0; i < grid.ColumnCount; i++)
            {
                grid.Columns[i].HeaderText = names[i];
                width += grid.Columns[i].Width;
            }
            for (int j = 0; j < grid.RowCount; j++)
            {
                height += grid.Rows[j].Height;
            }
            this.Width = width;
            this.Height = height;
            if (grid.RowCount == 0)
            {
                status.Text = "Brak danych";
                usunTool.Enabled = false;
                edytujTool.Enabled = false;
            }
            else
            {
                status.Text = "";
                usunTool.Enabled = true;
                edytujTool.Enabled = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            initialize();
            searchBox.Text = SearchHint;
        }

        private void editSkillRow(DataGridViewRow row)
        {
            Skill skill = Skill.New();
            skill.Id = (int)row.Cells[0].Value;
            skill.Name = (String)row.Cells[1].Value;
            skill.Description = (String)row.Cells[2].Value;
            skill.Mark = (Rate)row.Cells[3].Value;
            skill.FromDate = (DateTime)row.Cells[4].Value;
            skill.StillInterestedIn = (bool)row.Cells[5].Value;
            skill.UpdateDate = (DateTime)row.Cells[6].Value;

            SkillWindow edit = new SkillWindow();
            edit.FormClosing += (window, args) =>
            {
                var child = (SkillWindow)window;
                if (data.Push(child.Skill))
                {
                    status.Text = "Dane uaktualnione";
                    ShowInGrid();
                }
                else
                {
                    status.Text = "Nie udało się uaktualnić danych";
                }
            };
            edit.setSkill(skill);
            edit.Show();
        }

        private void editTaskRow(DataGridViewRow row)
        {
            marekbar.Task task = marekbar.Task.New();
            task.Id = (int)row.Cells[0].Value;
            task.Name = (String)row.Cells[1].Value;
            task.Description = (String)row.Cells[2].Value;
            task.Date = (DateTime)row.Cells[3].Value;
            task.Level = (DifficultyLevel)row.Cells[4].Value;

            TaskWindow edit = new TaskWindow();
            edit.FormClosing += (window, args) =>
            {
                var child = (TaskWindow)window;
                if (data.Push(child.Task))
                {
                    status.Text = "Dane uaktualnione";
                    ShowInGrid();
                }
                else
                {
                    status.Text = "Nie udało się uaktualnić danych";
                }
            };
            edit.setTask(task);
            edit.Show();
        }

        private void editEmployerRow(DataGridViewRow row)
        {
            marekbar.Employer employer = marekbar.Employer.New();
            employer.Id = (int)row.Cells[0].Value;
            employer.Name = (String)row.Cells[1].Value;
            employer.Description = (String)row.Cells[2].Value;
            employer.Mail = (String)row.Cells[3].Value;
            employer.Phone = (String)row.Cells[4].Value;
            employer.City = (String)row.Cells[5].Value;
            employer.Street = (String)row.Cells[6].Value;
            employer.BuildingNumber = (String)row.Cells[7].Value;
            employer.InternalBuildingNumber = (String)row.Cells[8].Value;

            EmployerWindow edit = new EmployerWindow();
            edit.FormClosing += (window, args) =>
            {
                var child = (EmployerWindow)window;
                if (data.Push(child.Employer))
                {
                    status.Text = "Dane uaktualnione";
                    ShowInGrid();
                }
                else
                {
                    status.Text = "Nie udało się uaktualnić danych";
                }
            };
            edit.setEmployer(employer);
            edit.Show();
        }

        private void editJobRow(DataGridViewRow row)
        {
            int id = (int)row.Cells[0].Value;
            var job = data.Jobs.Where(j => j.Id == id).FirstOrDefault();

            var edit = new JobWindow();
            edit.SetEmployerList(ref data.Employers);
            edit.FormClosing += (window, args) =>
            {
                var child = (JobWindow)window;
                if (data.Push(child.Job))
                {
                    status.Text = "Dane uaktualnione";
                    ShowInGrid();
                }
                else
                {
                    status.Text = "Nie udało się uaktualnić danych";
                }
            };
            edit.setJob(job);
            edit.Show();
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            ShowInGrid();
        }

        private void ChooseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowInGrid();
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        private void toolClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool closeConfirmed = false;
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeConfirmed)
            {
                if (MessageBox.Show("Czy chcesz zamknąć program?", "Zamykanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == System.Windows.Forms.DialogResult.Yes)
                {
                    closeConfirmed = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                    this.BringToFront();
                }
            }
        }

        private void dodajZadanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var task = new TaskWindow();
            task.FormClosing += (window, args) =>
            {
                var child = (TaskWindow)window;
                if (data.Push(child.Task))
                {
                    status.Text = "Dane uaktualnione";
                    ChooseType.SelectedIndex = 1;
                    ShowInGrid();
                }
                else
                {
                    status.Text = "Nie udało się uaktualnić danych";
                }
            };
            task.Show();
        }

        private void dataFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Data.GetFolder);
        }

        private void appFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath);
        }

        private void edytujTool_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                DataType type = (DataType)ChooseType.SelectedIndex;     
                switch (type)
                {
                    case DataType.Skill:
                        {
                            editSkillRow(grid.SelectedRows[0]);
                        }
                        break;
                    case DataType.Task:
                        {
                            editTaskRow(grid.SelectedRows[0]);
                        }
                        break;
                    case DataType.Employer:
                        {
                            editEmployerRow(grid.SelectedRows[0]);
                        }
                        break;
                    case DataType.Job:
                        {
                            editJobRow(grid.SelectedRows[0]);
                        }
                        break;
                }
            }
        }

        private void usunTool_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Czy chcesz usunąć wybraną pozycję?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataType type = (DataType)ChooseType.SelectedIndex;
                    DataGridViewRow row = grid.SelectedRows[0];
                    switch (type)
                    {
                        case DataType.Skill:
                            {
                                if(data.DeleteSkill((int)row.Cells[0].Value))
                                {
                                    status.Text = "Umiejętność została usunięta";
                                    ShowInGrid();
                                }
                                else
                                {
                                    status.Text = "Usuwanie nie powiodło się";
                                }
                            }
                            break;
                        case DataType.Task:
                            {
                                if (data.DeleteTask((int)row.Cells[0].Value))
                                {
                                    status.Text = "Zadanie zostało usunięte";
                                    ShowInGrid();
                                }
                                else
                                {
                                    status.Text = "Usuwanie nie powiodło się";
                                }
                            }
                            break;
                        case DataType.Employer:
                            {
                                if (data.DeleteEmployer((int)row.Cells[0].Value))
                                {
                                    status.Text = "Pracodawca został usunięty";
                                    ShowInGrid();
                                }
                                else
                                {
                                    status.Text = "Usuwanie nie powiodło się";
                                }
                            }
                            break;
                        case DataType.Job:
                            {
                                if (data.DeleteJobs((int)row.Cells[0].Value))
                                {
                                    status.Text = "Praca została usunięta";
                                    ShowInGrid();
                                }
                                else
                                {
                                    status.Text = "Usuwanie nie powiodło się";
                                }
                            }
                            break;
                    }
                }
            }
        }

        private void employerTool_Click(object sender, EventArgs e)
        {
            var employer = new EmployerWindow();
            employer.FormClosing += (window, args) =>
            {
                var child = (EmployerWindow)window;
                if (data.Push(child.Employer))
                {
                    status.Text = "Dane uaktualnione";
                    ChooseType.SelectedIndex = 2;
                    ShowInGrid();
                }
                else
                {
                    status.Text = "Nie udało się uaktualnić danych";
                }
            };
            employer.Show();
        }

        private void addJob_Click(object sender, EventArgs e)
        {
            var job = new JobWindow();
            job.SetEmployerList(ref data.Employers);
            job.FormClosing += (window, args) =>
            {
                var child = (JobWindow)window;
                if (data.Push(child.Job))
                {
                    status.Text = "Dane uaktualnione";
                    ChooseType.SelectedIndex = 3;
                    ShowInGrid();
                }
                else
                {
                    status.Text = "Nie udało się uaktualnić danych";
                }
            };
            job.Show();
        }

        private void errors_MouseHover(object sender, EventArgs e)
        {
            errors.BackColor = Color.Black;
        }

        private void errors_MouseLeave(object sender, EventArgs e)
        {
            errors.BackColor = Color.Transparent;
        }

        private void packData_Click(object sender, EventArgs e)
        {
            if (data.ZipFolder())
            {
                status.Text = "Folder danych spakowany";
                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
            }
            else {
                status.Text = "Folder danych nie został spakowany";
            }
        }

        private void pokazywaczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("jestem sobie glonojadek", "Agnieszka");
         }

    }
}
