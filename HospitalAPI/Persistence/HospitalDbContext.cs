
using HospitalAPI.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalAPI.Persistence
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<UserCaracteristcs> userCaracteristcs { get; set; }
        public DbSet<Feedback> feedbacks { get; set; }

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {

        }
    }
}
