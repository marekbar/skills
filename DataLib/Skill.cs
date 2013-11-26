using System;

namespace marekbar
{
    public class Skill
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Rate Mark { get; set; }
        public DateTime FromDate { get; set; }
        public Boolean StillInterestedIn { get; set; }
        public DateTime UpdateDate { get; set; }

        public Skill() { }

        public void Clear()
        {
            this.Id = 0;
            this.Name = "";
            this.Description = "";
            this.Mark = Rate.Słyszałem;
            this.FromDate = DateTime.Now;
            this.StillInterestedIn = false;
            this.UpdateDate = DateTime.Now;
        }

        public static Skill New()
        {
            Skill skill = new Skill();
            skill.Clear();
            return skill;
        }

        public bool Update(Skill skill)
        {
            this.Name = skill.Name;
            this.Description = skill.Description;
            this.FromDate = skill.FromDate;
            this.Mark = skill.Mark;
            this.StillInterestedIn = skill.StillInterestedIn;
            this.UpdateDate = DateTime.Now;
            return true;
        }

        public static String[] Names = new String[] { "Id", "Nazwa", "Opis", "Ocena", "Od kiedy", "Aktualne", "Modyfikacja"};
    }
}
