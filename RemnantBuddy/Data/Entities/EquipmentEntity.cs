namespace RemnantBuddy.Data.Entities;

public class EquipmentEntity
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public List<TagEntity> Tags { get; set; } = new();

    public List<SubTagEntity> SubTags { get; set; } = new();
}
