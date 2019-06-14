using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace YarnViewer.EntityFrameworkCore
{
    public static class YarnViewerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<YarnViewerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<YarnViewerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
