using RemnantBuddyBackend.BuildTags;
using RemnantBuddyBackend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemnantBuddyBackend.Equipment;

public class BaseEquipment
{
    public Category Category { get; set; }

    public List<Tag> Tags { get; set; } = new();

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Name: {Name}\nDescription: {Description}\nLocation: {Location}";
    }
}
