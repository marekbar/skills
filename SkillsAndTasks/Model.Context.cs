﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkillsAndTasks
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class marekbarEntities : DbContext
    {
        public marekbarEntities()
            : base("name=marekbarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserSkills> UserSkills { get; set; }
    
        public virtual int delUserSkills(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delUserSkills", idParameter);
        }
    
        public virtual ObjectResult<getUserSkills_Result> getUserSkills(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getUserSkills_Result>("getUserSkills", idParameter);
        }
    
        public virtual int modUserSkills(Nullable<int> id, Nullable<int> user_id, Nullable<int> skill_id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            var skill_idParameter = skill_id.HasValue ?
                new ObjectParameter("skill_id", skill_id) :
                new ObjectParameter("skill_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("modUserSkills", idParameter, user_idParameter, skill_idParameter);
        }
    
        public virtual int skillDelete(Nullable<int> skill_id)
        {
            var skill_idParameter = skill_id.HasValue ?
                new ObjectParameter("skill_id", skill_id) :
                new ObjectParameter("skill_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("skillDelete", skill_idParameter);
        }
    
        public virtual ObjectResult<skillGet_Result> skillGet(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<skillGet_Result>("skillGet", idParameter);
        }
    
        public virtual ObjectResult<skillGetAll_Result> skillGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<skillGetAll_Result>("skillGetAll");
        }
    
        public virtual int skillUpdate(Nullable<int> id, string name, string description)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("skillUpdate", idParameter, nameParameter, descriptionParameter);
        }
    
        public virtual int taskDelete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("taskDelete", idParameter);
        }
    
        public virtual ObjectResult<taskGet_Result> taskGet(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<taskGet_Result>("taskGet", idParameter);
        }
    
        public virtual ObjectResult<taskGetAll_Result> taskGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<taskGetAll_Result>("taskGetAll");
        }
    
        public virtual int taskUpdate(Nullable<int> id, string task, string description, Nullable<System.DateTime> creation_date, Nullable<int> created_by, Nullable<int> assigned_to_user, Nullable<System.DateTime> modification_date, Nullable<int> modified_by, Nullable<bool> is_finished, string status)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var taskParameter = task != null ?
                new ObjectParameter("task", task) :
                new ObjectParameter("task", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            var creation_dateParameter = creation_date.HasValue ?
                new ObjectParameter("creation_date", creation_date) :
                new ObjectParameter("creation_date", typeof(System.DateTime));
    
            var created_byParameter = created_by.HasValue ?
                new ObjectParameter("created_by", created_by) :
                new ObjectParameter("created_by", typeof(int));
    
            var assigned_to_userParameter = assigned_to_user.HasValue ?
                new ObjectParameter("assigned_to_user", assigned_to_user) :
                new ObjectParameter("assigned_to_user", typeof(int));
    
            var modification_dateParameter = modification_date.HasValue ?
                new ObjectParameter("modification_date", modification_date) :
                new ObjectParameter("modification_date", typeof(System.DateTime));
    
            var modified_byParameter = modified_by.HasValue ?
                new ObjectParameter("modified_by", modified_by) :
                new ObjectParameter("modified_by", typeof(int));
    
            var is_finishedParameter = is_finished.HasValue ?
                new ObjectParameter("is_finished", is_finished) :
                new ObjectParameter("is_finished", typeof(bool));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("taskUpdate", idParameter, taskParameter, descriptionParameter, creation_dateParameter, created_byParameter, assigned_to_userParameter, modification_dateParameter, modified_byParameter, is_finishedParameter, statusParameter);
        }
    
        public virtual int userDelete(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("userDelete", idParameter);
        }
    
        public virtual ObjectResult<userGet_Result> userGet(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<userGet_Result>("userGet", idParameter);
        }
    
        public virtual ObjectResult<userGetAll_Result> userGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<userGetAll_Result>("userGetAll");
        }
    
        public virtual int userUpdate(Nullable<int> id, string name, string surname, string login, string password, string town, string mail, string phone)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("surname", surname) :
                new ObjectParameter("surname", typeof(string));
    
            var loginParameter = login != null ?
                new ObjectParameter("login", login) :
                new ObjectParameter("login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var townParameter = town != null ?
                new ObjectParameter("town", town) :
                new ObjectParameter("town", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("userUpdate", idParameter, nameParameter, surnameParameter, loginParameter, passwordParameter, townParameter, mailParameter, phoneParameter);
        }
    
        public virtual int checkUser(string login, string password)
        {
            var loginParameter = login != null ?
                new ObjectParameter("login", login) :
                new ObjectParameter("login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("checkUser", loginParameter, passwordParameter);
        }
    
        public virtual int userLoginExists(string login, ObjectParameter result)
        {
            var loginParameter = login != null ?
                new ObjectParameter("login", login) :
                new ObjectParameter("login", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("userLoginExists", loginParameter, result);
        }
    
        public virtual int userAccountActivate(string code, ObjectParameter result)
        {
            var codeParameter = code != null ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("userAccountActivate", codeParameter, result);
        }
    
        public virtual int userSetCode(Nullable<int> id, string code)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var codeParameter = code != null ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("userSetCode", idParameter, codeParameter);
        }
    
        public virtual int userAdd(string name, string surname, string login, string password, string town, string mail, string phone, string code)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("surname", surname) :
                new ObjectParameter("surname", typeof(string));
    
            var loginParameter = login != null ?
                new ObjectParameter("login", login) :
                new ObjectParameter("login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var townParameter = town != null ?
                new ObjectParameter("town", town) :
                new ObjectParameter("town", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var codeParameter = code != null ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("userAdd", nameParameter, surnameParameter, loginParameter, passwordParameter, townParameter, mailParameter, phoneParameter, codeParameter);
        }
    
        public virtual ObjectResult<userSkillsGetAll_Result> userSkillsGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<userSkillsGetAll_Result>("userSkillsGetAll");
        }
    
        public virtual ObjectResult<Nullable<decimal>> taskAdd(string task, string description, Nullable<System.DateTime> creation_date, Nullable<int> created_by, Nullable<int> assigned_to_user, Nullable<System.DateTime> modification_date, Nullable<int> modified_by, Nullable<bool> is_finished, string status)
        {
            var taskParameter = task != null ?
                new ObjectParameter("task", task) :
                new ObjectParameter("task", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            var creation_dateParameter = creation_date.HasValue ?
                new ObjectParameter("creation_date", creation_date) :
                new ObjectParameter("creation_date", typeof(System.DateTime));
    
            var created_byParameter = created_by.HasValue ?
                new ObjectParameter("created_by", created_by) :
                new ObjectParameter("created_by", typeof(int));
    
            var assigned_to_userParameter = assigned_to_user.HasValue ?
                new ObjectParameter("assigned_to_user", assigned_to_user) :
                new ObjectParameter("assigned_to_user", typeof(int));
    
            var modification_dateParameter = modification_date.HasValue ?
                new ObjectParameter("modification_date", modification_date) :
                new ObjectParameter("modification_date", typeof(System.DateTime));
    
            var modified_byParameter = modified_by.HasValue ?
                new ObjectParameter("modified_by", modified_by) :
                new ObjectParameter("modified_by", typeof(int));
    
            var is_finishedParameter = is_finished.HasValue ?
                new ObjectParameter("is_finished", is_finished) :
                new ObjectParameter("is_finished", typeof(bool));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("taskAdd", taskParameter, descriptionParameter, creation_dateParameter, created_byParameter, assigned_to_userParameter, modification_dateParameter, modified_byParameter, is_finishedParameter, statusParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> addUserSkills(Nullable<int> user_id, Nullable<int> skill_id)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            var skill_idParameter = skill_id.HasValue ?
                new ObjectParameter("skill_id", skill_id) :
                new ObjectParameter("skill_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("addUserSkills", user_idParameter, skill_idParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> skillsAdd(string name, string description)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("skillsAdd", nameParameter, descriptionParameter);
        }
    }
}
