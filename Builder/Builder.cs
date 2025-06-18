using Newtonsoft.Json;
using RemnantBuddyBackend.Enums;
using RemnantBuddyBackend.Equipment.Amulets;
using RemnantBuddyBackend.Equipment.Rings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemnantBuddyBackend;
public class Builder
{
    private readonly List<BaseRing> _rings = new List<BaseRing>();
    private readonly List<BaseAmulet> _amulets = new List<BaseAmulet>();

    public Builder()
    {
        _rings = LoadRings();
        _amulets = LoadAmulets();
    }

    public IEnumerable<BaseRing> GetRingsByTag(Tag tag)
    {
        return _rings.Where(i => i.Tags.Contains(tag));
    }

    public IEnumerable<BaseAmulet> GetAmuletsByTag(Tag tag)
    {
        return _amulets.Where(i => i.Tags.Contains(tag));
    }

    private List<BaseRing> LoadRings()
    {
        return JsonConvert.DeserializeObject<List<BaseRing>>(File.ReadAllText("C:\\Code\\RemnantBuddy\\Builder\\Equipment\\Rings\\rings.json"));
    }

    private List<BaseAmulet> LoadAmulets()
    {
        return JsonConvert.DeserializeObject<List<BaseAmulet>>(File.ReadAllText("C:\\Code\\RemnantBuddy\\Builder\\Equipment\\Amulets\\amulets.json"));
    }
}
