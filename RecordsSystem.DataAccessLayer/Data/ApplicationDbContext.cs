using Microsoft.EntityFrameworkCore;
using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<RecUserDetail> RecUserDetails { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<CompanyDetail> CompanyDetails { get; set; }
        public DbSet<AddressDetail> AddressesDetails { get; set; }

    }
}
