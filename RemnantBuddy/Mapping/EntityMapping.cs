using RemnantBuddy.Data.Entities;
using RemnantBuddy.Models;

namespace RemnantBuddy.Mapping;
public static class EntityMapping
{
    public static Ring MapToModel(this RingEntity entity)
    {
        return new()
        {
            Name = entity.Name,
            Description = entity.Description,
            Location = entity.Location,
            Tags = [.. entity.Tags.Select(MapToModel)],
            SubTags = [.. entity.SubTags.Select(MapToModel)],
        };
    }

    public static Tag MapToModel(this TagEntity entity)
    {
        return new()
        {
            TagID = (TagEnum)entity.TagID,
            Name = entity.Name,
            SubTags = [.. entity.SubTags.Select(MapToModel)],
        };
    }

    public static SubTag MapToModel(this SubTagEntity entity)
    {
        return new()
        {
            SubTagID = (SubTagEnum)entity.SubTagID,
            Name = entity.Name,
            Tags = [.. entity.Tags.Select(MapToModel)]
        };
    }
}
