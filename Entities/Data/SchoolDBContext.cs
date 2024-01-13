using Microsoft.EntityFrameworkCore;
using Entities;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace University.Data
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext
            (DbContextOptions<SchoolDBContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }


}