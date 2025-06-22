using Microsoft.EntityFrameworkCore;
using RemnantBuddy.Mapping;
using RemnantBuddy.Models;

namespace RemnantBuddy.Data;
public class RemnantRepository(IDbContextFactory<RemnantDbContext> dbContextFactory)
{
    private readonly IDbContextFactory<RemnantDbContext> _dbContextFactory = dbContextFactory;

    public RemnantDbContext CurrentDbContext { get; private set; }

    public async Task<RemnantDbContext> CreateDbContextAsync()
    {
        if (CurrentDbContext is not null)
        {
            try
            {
                await CurrentDbContext.DisposeAsync();
            }
            catch (ObjectDisposedException) { }
        }
        CurrentDbContext = await _dbContextFactory.CreateDbContextAsync();
        return CurrentDbContext;
    }

    public List<Ring> GetAllRings()
    {
        return [.. CurrentDbContext.Rings.Select(ring => ring.MapToModel())];
    }

    public List<Tag> GetAllTags()
    {
        return [.. CurrentDbContext.Tags.Select(tag => tag.MapToModel())];
    }

    public Dictionary<Tag, SubTag> GetAllSubTags(List<Tag> tags)
    {
        Dictionary<Tag, SubTag> mappedSubTags = new();
        foreach (var tag in tags)
        {
            foreach (var subTag in CurrentDbContext.SubTags
                .Where(i => i.Tags.Any(j => j.TagID == ((int)tag.TagID))))
            {
                mappedSubTags.Add(tag, subTag.MapToModel());
            }
        }

        return mappedSubTags;
    }

    public async Task UpdateRing(Ring ring)
    {
        CurrentDbContext.Rings.Update(ring.MapToEntity());
        await CurrentDbContext.SaveChangesAsync();
    }

    public async Task AddRing(Ring ring)
    {
        await CurrentDbContext.Rings.AddAsync(ring.MapToEntity());
        await CurrentDbContext.SaveChangesAsync();
    }

    public async Task AddTag(Tag tag)
    {
        await CurrentDbContext.Tags.AddAsync(tag.MapToEntity());
        await CurrentDbContext.SaveChangesAsync();
    }

    public async Task AddSubTag(SubTag subTag)
    {
        await CurrentDbContext.SubTags.AddAsync(subTag.MapToEntity());
        await CurrentDbContext.SaveChangesAsync();
    }
}
