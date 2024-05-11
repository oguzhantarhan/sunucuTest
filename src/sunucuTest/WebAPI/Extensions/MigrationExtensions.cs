using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace WebAPI.MigrationExtensions;

public static class MigrationExtensions
{

public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope=app.ApplicationServices.CreateScope();
        using BaseDbContext dbContext=scope.ServiceProvider.GetService<BaseDbContext>();
        dbContext.Database.Migrate();
    }
}
