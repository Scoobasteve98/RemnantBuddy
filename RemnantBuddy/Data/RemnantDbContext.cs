using Microsoft.EntityFrameworkCore;
using RemnantBuddy.Data.Entities;

namespace RemnantBuddy.Data;

public class RemnantDbContext : DbContext
{
    private string dbPath = Path.Combine(FileSystem.AppDataDirectory, "RemnantBuddy", "remnantBuddy.db3");
    public RemnantDbContext()
    {
        string folder = Path.GetDirectoryName(dbPath) ?? string.Empty;
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={dbPath}");
    }
    public DbSet<RingEntity> Rings { get; set; }

    public DbSet<TagEntity> Tags { get; set; }

    public DbSet<SubTagEntity> SubTags { get; set; }
}
