//am using global on program.cs file
namespace VerifyEmailForgotPasswordWebApi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=CHRISWAX-ICTD;Database=VerifyEmailPwdWebApi;Trusted_Connection=true;");
        }

        //public DbSet<User> Users { get; set; }
        //using below instead of the above removes the warning on the DataContext CTOR 
        public DbSet<User> Users => Set<User >();
    }
}
