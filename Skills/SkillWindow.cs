using marekbar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marekbar
{
    public partial class SkillWindow : Form
    {
        public Skill Skill = Skill.New();
        public bool NeedSave = false;
        public SkillWindow()
        {
            InitializeComponent();
            Rate.SelectedIndex = 0;
        }

        public void save(object sender, EventArgs args) 
        {
            Skill.Name = NameOfSkill.Text;
            Skill.Description = Description.Text;
            Skill.FromDate = FromDate.Value;
            Skill.UpdateDate = DateTime.Now;
            Skill.Mark = (marekbar.Rate)Rate.SelectedIndex;
            Skill.StillInterestedIn = StillInterestedInYes.Checked;
            NeedSave = true;
            this.status.Text = "Zmiany zapisane"; 
            this.Close();
        }

        public void back(object sender, EventArgs args)
        {
            this.Close();
        }

        public void setSkill(Skill skill)
        {
            NameOfSkill.Text = skill.Name;
            Description.Text = skill.Description;
            FromDate.Value = skill.FromDate;
            Rate.SelectedIndex = (int)skill.Mark;
            StillInterestedInYes.Checked = skill.StillInterestedIn;
            Skill = skill;
        }
    }
}
