using Microsoft.EntityFrameworkCore;

namespace Club.Infastructure.Data
{
    public class ClubDBContext : DbContext
    {
        public ClubDBContext(DbContextOptions<ClubDBContext> options) : base (options)  
        {

        }
    }
}
