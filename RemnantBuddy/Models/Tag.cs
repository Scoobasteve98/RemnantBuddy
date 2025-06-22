namespace RemnantBuddy.Models;
public class Tag
{
    public TagEnum TagID { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<SubTag> SubTags { get; set; } = new();
}
