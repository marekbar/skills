using System;
namespace marekbar
{
    public class Job
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int EmployerKey { get; set; }

        public Job() { }

        public void Clear()
        {
            Id = 0;
            Name = "";
            Description = "";
            FromDate = DateTime.Now;
            ToDate = DateTime.Now;
            EmployerKey = 0;
        }

        public bool Update(Job job)
        {
            Id = job.Id;
            Name = job.Name;
            Description = job.Description;
            FromDate = job.FromDate;
            ToDate = job.ToDate;
            EmployerKey = job.EmployerKey;
            return true;
        }
        public static Job New()
        {
            Job job = new Job();
            job.Clear();
            return job;
        }
        public static String[] Names = new String[] { "Id", "Stanowisko", "Opis", "Od kiedy", "Do kiedy", "Pracodawca"};
    }
}
