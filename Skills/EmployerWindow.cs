using marekbar;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Skills
{
    public partial class EmployerWindow : Form
    {
        public Employer Employer = Employer.New();
        public bool NeedSave = false;

        public EmployerWindow()
        {
            InitializeComponent();
        }

        public void setEmployer(Employer employer)
        {
            NameOfEmployer.Text = employer.Name;
            Description.Text = employer.Description;
            Mail.Text = employer.Mail;
            Phone.Text = employer.Phone;
            City.Text = employer.City;
            BuildingNumber.Text = employer.BuildingNumber;
            InternalBuildingNumber.Text = employer.InternalBuildingNumber;
            Employer = employer;
        }

        public void back(object sender, EventArgs args)
        {
            this.Close();
        }

        public void clear(object sender, EventArgs args)
        {
            Employer.Clear();
            setEmployer(Employer);
        }

        public void save(object sender, EventArgs args)
        {
            Employer.Name = NameOfEmployer.Text;
            Employer.Description = Description.Text;
            Employer.Mail = Mail.Text;
            Employer.Phone = Phone.Text;
            Employer.City = City.Text;
            Employer.BuildingNumber = BuildingNumber.Text;
            Employer.InternalBuildingNumber = InternalBuildingNumber.Text;
            NeedSave = true;
            this.Close();
        }

    }
}
