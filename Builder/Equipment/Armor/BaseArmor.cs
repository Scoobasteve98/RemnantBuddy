using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemnantBuddyBackend.Equipment.Armor;

public class BaseArmor
{
    public decimal Armor { get; private set; }

    public decimal Weight { get; private set; }

    public int BleeedingResistance { get; private set; }

    public int FireResistance { get; private set; }

    public int ShockResistance { get; private set; }

    public int CorrosonResistance { get; private set; }

    public int BlightResistance { get; private set; }

    public decimal DamageReduction { get; private set; }
}
