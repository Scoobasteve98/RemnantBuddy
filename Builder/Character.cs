using RemnantBuddyBackend.Equipment.Armor;
using RemnantBuddyBackend.Formulas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemnantBuddyBackend;

internal class Character
{
    public string PrimaryArchetype { get; set; }

    public string SecondaryArchetype { get; set; }

    public BaseArmor Helmet { get; set; } = new();

    public BaseArmor BodyArmor { get; set; } = new();

    public BaseArmor LegArmor { get; set; } = new();

    public BaseArmor GloveArmor { get; set; } = new();

    public string Heart { get; set; }

    public decimal Armor => Helmet.Armor + BodyArmor.Armor + LegArmor.Armor + GloveArmor.Armor;

    public decimal Weight => Helmet.Weight + BodyArmor.Weight + LegArmor.Weight + GloveArmor.Weight;

    public int BleeedingResistance => Helmet.BleeedingResistance + BodyArmor.BleeedingResistance + LegArmor.BleeedingResistance + GloveArmor.BleeedingResistance;

    public int FireResistance => 0;

    public int ShockResistance { get; private set; }

    public int CorrosonResistance { get; private set; }

    public int BlightResistance { get; private set; }

    public WeightClassFormula WeightClass { get; private set; } = new(0, 0, 0);

    public decimal DamageReduction { get; private set; }

    public decimal ArmorDR => Armor / (Armor + 200);

    public decimal TotalDR => DamageReduction + ArmorDR - (ArmorDR * DamageReduction);
}
