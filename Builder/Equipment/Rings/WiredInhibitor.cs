using RemnantBuddyBackend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemnantBuddyBackend.Equipment.Rings;

internal class WiredInhibitor
{
    public List<Tag> Tags { get; } = new() { Tag.Slow, Tag.NegativeStatusEffect };


}
