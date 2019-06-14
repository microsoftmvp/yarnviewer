using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using YarnViewer.Authorization.Roles;
using YarnViewer.Authorization.Users;
using YarnViewer.MultiTenancy;

namespace YarnViewer.EntityFrameworkCore
{
    public class YarnViewerDbContext : AbpZeroDbContext<Tenant, Role, User, YarnViewerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public YarnViewerDbContext(DbContextOptions<YarnViewerDbContext> options)
            : base(options)
        {
        }
    }
}
