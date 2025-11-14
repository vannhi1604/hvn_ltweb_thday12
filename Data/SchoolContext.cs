using ltweb_th1.Models;
using Microsoft.EntityFrameworkCore;

namespace ltweb_th1.Data
{
    public class SchoolContext :DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options): base(options) { }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Learner> Learners { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
    }
}
