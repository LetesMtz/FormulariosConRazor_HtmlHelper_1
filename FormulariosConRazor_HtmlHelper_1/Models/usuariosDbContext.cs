using Microsoft.EntityFrameworkCore;

namespace FormulariosConRazor_HtmlHelper_1.Models
{
    public class usuariosDbContext : DbContext
    {
        public usuariosDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<usuarios> usuarios { get; set; }
    }
}
