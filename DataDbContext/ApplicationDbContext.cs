using Interview1.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Interview1.DataDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; } /* 把我的Order模型建立成叫做Orders的資料表 */
    }
}
