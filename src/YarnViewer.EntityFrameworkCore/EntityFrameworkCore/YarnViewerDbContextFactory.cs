using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using YarnViewer.Configuration;
using YarnViewer.Web;

namespace YarnViewer.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class YarnViewerDbContextFactory : IDesignTimeDbContextFactory<YarnViewerDbContext>
    {
        public YarnViewerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<YarnViewerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            YarnViewerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(YarnViewerConsts.ConnectionStringName));

            return new YarnViewerDbContext(builder.Options);
        }
    }
}
