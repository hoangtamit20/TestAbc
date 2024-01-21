using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OCLP.Data.Entities;

namespace OCLP.Data.DbContext
{
    public class OCLPDbContext : IdentityDbContext<AppUser>
    {
        public OCLPDbContext(DbContextOptions<OCLPDbContext> options) : base(options)
        {
            
        }


        #region dbset
        public DbSet<UrlHelperEntity> UrlHelperEntities { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
