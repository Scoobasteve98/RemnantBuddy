namespace RemnantBuddy.Models;
public class SubTag
{
    public SubTagEnum SubTagID { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<Tag> Tags { get; set; } = new();
}
