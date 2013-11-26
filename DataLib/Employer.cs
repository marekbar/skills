using System;
using System.Xml.Serialization;
namespace marekbar
{
    public class Employer
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Mail { get; set; }
        public String Phone { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public String BuildingNumber{get; set;}
        public String InternalBuildingNumber { get; set; }

        public Employer() { }

        public void Clear()
        {
            Id = 0;
            Name = Description = Mail = Phone = City = Street = BuildingNumber = InternalBuildingNumber = "";
        }

        public bool Update(Employer employer)
        {
            Id = employer.Id;
            Name = employer.Name;
            Description = employer.Description;
            Mail = employer.Mail;
            Phone = employer.Phone;
            City = employer.City;
            Street = employer.Street;
            BuildingNumber = employer.BuildingNumber;
            InternalBuildingNumber = employer.InternalBuildingNumber;
            return true;
        }

        public static Employer New()
        {
            Employer employer = new Employer();
            employer.Clear();
            return employer;
        }

        public static String[] Names = new String[] { "Id", "Pracodawca", "Opis", "Email", "Telefon", "Miasto", "Ulica", "Numer budynku", "Numer w budynku"};
    }
}
