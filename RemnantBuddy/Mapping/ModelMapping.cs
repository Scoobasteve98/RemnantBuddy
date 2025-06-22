using RemnantBuddy.Data.Entities;
using RemnantBuddy.Models;

namespace RemnantBuddy.Mapping;
public static class ModelMapping
{
    public static RingEntity MapToEntity(this Ring entity)
    {
        return new()
        {
            RingEntityId = entity.RingId,
            Name = entity.Name,
            Description = entity.Description,
            Location = entity.Location,
            Tags = [.. entity.Tags.Select(MapToEntity)],
            SubTags = [.. entity.SubTags.Select(MapToEntity)],
        };
    }

    public static TagEntity MapToEntity(this Tag entity)
    {
        return new()
        {
            TagEntityId = (int)entity.TagID,
            Name = entity.Name,
            SubTags = [.. entity.SubTags.Select(MapToEntity)],
        };
    }

    public static SubTagEntity MapToEntity(this SubTag entity)
    {
        return new()
        {
            SubTagEntityId = (int)entity.SubTagID,
            Name = entity.Name,
            Tags = [.. entity.Tags.Select(MapToEntity)]
        };
    }
}
