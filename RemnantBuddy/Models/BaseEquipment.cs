namespace RemnantBuddy.Models;

public class BaseEquipment
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public List<Tag> Tags { get; set; } = new();

    public List<SubTag> SubTags { get; set; } = new();

    public override string ToString()
    {
        return $"Name: {Name}\nDescription: {Description}\nLocation: {Location}";
    }
}
