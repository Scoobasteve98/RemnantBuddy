namespace RemnantBuddy.Data.Entities;

public class TagEntity
{
    public int TagID { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<RingEntity> Rings { get; set; } = new();

    public List<SubTagEntity> SubTags { get; set; } = new();
}
