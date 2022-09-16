using EFMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMVC.Controllers
{
    public class MVCContextcs : DbContext
    {
        public MVCContextcs(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
