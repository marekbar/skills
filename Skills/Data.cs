using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace marekbar
{
    public class Data
    {
        #region MAIN
        private String SkillsFilename = "\\skills.xml";
        private String TasksFilename = "\\tasks.xml";
        private String EmployersFilename = "\\employers.xml";
        private String JobsFilename = "\\jobs.xml";

        public List<Skill> Skills = new List<Skill>();
        public List<Task> Tasks = new List<Task>();
        public List<Employer> Employers = new List<Employer>();
        public List<Job> Jobs = new List<Job>();
        public String Error = "";
        public static String GetFolder
        {
            get
            {
                var docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var folder = docs + "\\Umiejętności i zadania";
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                return folder;
            }
        }

        public bool ZipFolder()
        {
            try
            {
                using (ZipFile zip = new ZipFile())
                {
                    zip.AddDirectory(GetFolder);
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                    zip.Strategy = Ionic.Zlib.CompressionStrategy.Default;
                    zip.Comment = "Utworzone przez program Umiejętności i zadania " + System.DateTime.Now.ToString("G");
                    zip.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Umiejętności i zadania.zip");
                }
                return true;
            }
            catch { return false; }
        }
        public Data()
        {

            SkillsFilename = GetFolder + SkillsFilename;
            TasksFilename = GetFolder + TasksFilename;
            EmployersFilename = GetFolder + EmployersFilename;
            JobsFilename = GetFolder + JobsFilename;

            Skills = Xml.Restore<List<Skill>>(SkillsFilename);
            if (Xml.Error != XmlSerializeError.NONE) Error += ("Uszkodzony plik skills.xml\n" + Xml.Message);
            Tasks = Xml.Restore<List<Task>>(TasksFilename);
            if (Xml.Error != XmlSerializeError.NONE) Error += ("\nUszkodzony plik tasks.xml\n" + Xml.Message);

            Employers = Xml.Restore<List<Employer>>(EmployersFilename);
            if (Xml.Error != XmlSerializeError.NONE) Error += ("\nUszkodzony plik employers.xml\n" + Xml.Message);

            Jobs = Xml.Restore<List<Job>>(JobsFilename);
            if (Xml.Error != XmlSerializeError.NONE) Error += ("\nUszkodzony plik jobs.xml\n" + Xml.Message);
        }
        #endregion

        #region PUSH
        public bool Push(Skill skill)
        {
            if (skill.Name == "") return false;
            if (skill.Id == 0)
            {
                if (Skills.Where(s => s.Name == skill.Name).ToList().Count == 0)
                {
                    if (Skills.Count > 0)
                    {
                        skill.Id = Skills.Max(s => s.Id) + 1;
                    }
                    else
                    {
                        skill.Id = 1;
                    }
                    Skills.Add(skill);
                    return SaveSkills();
                }
            }
            else
            {
                return Skills.Where(s => s.Id == skill.Id).First().Update(skill) && SaveSkills();
            }
            return false;
        }

        public bool Push(Task task)
        {
            if (task.Name == "") return false;
            if (task.Id == 0)
            {
                if (Tasks.Where(t => t.Name == task.Name).ToList().Count == 0)
                {
                    if (Tasks.Count > 0)
                    {
                        task.Id = Tasks.Max(t => t.Id) + 1;
                    }
                    else
                    {
                        task.Id = 1;
                    }
                    Tasks.Add(task);
                    return SaveTasks();
                }
            }
            else
            {
                return Tasks.Where(t => t.Id == task.Id).First().Update(task) && SaveTasks();
            }
            return false;
        }

        public bool Push(Employer employer)
        {
            if (employer.Name == "") return false;
            if (employer.Id == 0)
            {
                if (Employers.Where(t => t.Name == employer.Name).ToList().Count == 0)
                {
                    if (Employers.Count > 0)
                    {
                        employer.Id = Employers.Max(t => t.Id) + 1;
                    }
                    else
                    {
                        employer.Id = 1;
                    }
                    Employers.Add(employer);
                    return SaveEmployers();
                }
            }
            else
            {
                return Employers.Where(t => t.Id == employer.Id).First().Update(employer) && SaveEmployers();
            }
            return false;
        }

        public bool Push(Job job)
        {
            if (job.Name == "") return false;
            if (job.Id == 0)
            {
                if (Jobs.Where(t => t.Name == job.Name).ToList().Count == 0)
                {
                    if (Jobs.Count > 0)
                    {
                        job.Id = Jobs.Max(t => t.Id) + 1;
                    }
                    else
                    {
                        job.Id = 1;
                    }
                    Jobs.Add(job);
                    return SaveJobs();
                }
            }
            else
            {
                return Jobs.Where(t => t.Id == job.Id).First().Update(job) && SaveJobs();
            }
            return false;
        }

        #endregion

        #region SAVE

        private bool SaveSkills()
        {
            return Xml.Save<List<Skill>>(Skills,SkillsFilename);
        }

        private bool SaveTasks()
        {
            return Xml.Save<List<Task>>(Tasks, TasksFilename);
        }

        private bool SaveEmployers()
        {
            return Xml.Save<List<Employer>>(Employers, EmployersFilename);
        }

        public bool SaveJobs()
        {
            return Xml.Save<List<Job>>(Jobs, JobsFilename);
        }
        #endregion

        #region DELETE
        public bool DeleteSkill(int id)
        {
            Skills.RemoveAll(r => r.Id == id);
            return Skills.Where(c => c.Id == id).Count() == 0 && SaveSkills();
        }

        public bool DeleteTask(int id)
        {
            Tasks.RemoveAll(r => r.Id == id);
            return Tasks.Where(c => c.Id == id).Count() == 0 && SaveTasks();
        }

        public bool DeleteEmployer(int id)
        {
            Employers.RemoveAll(e => e.Id == id);
            return Employers.Where(e => e.Id == id).Count() == 0 && SaveEmployers();
        }

        public bool DeleteJobs(int id)
        {
            Jobs.RemoveAll(j => j.Id == id);
            return Jobs.Where(j => j.Id == id).Count() == 0 && SaveJobs();
        }
        #endregion

    }
}
