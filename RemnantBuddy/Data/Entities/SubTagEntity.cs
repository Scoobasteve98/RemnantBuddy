namespace RemnantBuddy.Data.Entities;

public class SubTagEntity
{
    public int SubTagID { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<TagEntity> Tags { get; set; } = new();

    public List<RingEntity> Rings { get; set; } = new();
}
