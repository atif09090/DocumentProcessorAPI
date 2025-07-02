using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DocumentProcessorAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Document> Documents => Set<Document>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }

}
