using System.Data.Entity;
using Evernote.Entities;

namespace Evernote.DataAccessLayer.EntityFramework
{
    public class DatabaseContext:DbContext
    {
        public DbSet<DUser> Users { get; set; }
        public DbSet<DNote> Notes { get; set; }
        public DbSet<DComment> Comments { get; set; }
        public DbSet<DCategory> Categories { get; set; }
        public DbSet<DLiked> Likes { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
}
