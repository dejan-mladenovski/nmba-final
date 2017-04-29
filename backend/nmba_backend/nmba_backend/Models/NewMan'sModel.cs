using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
    

namespace nmba_backend.Models
{
    public class NewMan_sModel: DbContext
    {
        public NewMan_sModel(): base("name = DefaultConnection")
        {
            Database.SetInitializer<NewMan_sModel>(new CreateDatabaseIfNotExists<NewMan_sModel>());
        }


        public virtual DbSet <Course> Courses { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet <ActiveCourse> ActiveCourses { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet <Event> Events { get; set; }
        public virtual DbSet <Enrollment> Enrollments { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Qna> Qna_s { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet <Student> Students { get; set; }
        public virtual DbSet <Teacher> Teachers { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet <Staff> Employees { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

    }
}