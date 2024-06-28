using Microsoft.EntityFrameworkCore;

namespace EntityFramWorkExample
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        public TrainingDbContext()
        {
            _connectionString = "Server=DESKTOP-5R4OMH0\\SQLEXPRESS;Database=CSharpRev;User Id=csharprev;Password=123456;TrustServerCertificate=True";

        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(_connectionString);

            }
            
            base.OnConfiguring(optionsBuilder);
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Topic>().ToTable("Topics"); // possible to modify the class name in db before migration
            modelBuilder.Entity<CourseStudent>()
                .HasKey((x) => new {x.StudentId, x.CourseId }); //composite primary key
            modelBuilder.Entity<Course>().HasIndex((x) => x.Name); //Indexing the Name

            modelBuilder.Entity<Course>() //one to many
                .HasMany(x => x.CourseTopics)
                .WithOne(x => x.TopicCourse)
                .HasForeignKey(x => x.CourseId);
            modelBuilder.Entity<CourseStudent>()//many to many
                .HasOne(x => x.Course)
                .WithMany(x => x.CourseStudents);

            modelBuilder.Entity<CourseStudent>()
               .HasOne(x => x.Student)
               .WithMany(x => x.StudentCourses);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; } 
    }
}
