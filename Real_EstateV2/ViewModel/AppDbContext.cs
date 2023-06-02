using Microsoft.EntityFrameworkCore;

namespace Real_EstateV2.ViewModel
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
                
        }
    }
}
