using System;
namespace marekbar
{
    public class Task
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }
        public DifficultyLevel Level { get; set; }

        public static Task New()
        {
            Task task = new Task();
            task.Clear();
            return task;
        }
        
        public void Clear()
        {
            Id = 0;
            Name = "";
            Description = "";
            Date = DateTime.Now;
            Level = DifficultyLevel.Łatwe;
        }

        public bool Update(Task task)
        {
            Name = task.Name;
            Description = task.Description;
            Date = task.Date;
            Level = task.Level;
            return false;
        }
        public static String[] Names = new String[] { "Id", "Nazwa", "Opis", "Kiedy", "Poziom" };
    }
}
