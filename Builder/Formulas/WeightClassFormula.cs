using RemnantBuddyBackend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemnantBuddyBackend.Formulas;
internal class WeightClassFormula
{
    public const int MediumThreshold = 25;
    public const int HeavyThreshold = 50;
    public const int SuperHeavyThreshold = 75;
    private WeightClass _weightClass;
    internal WeightClass WeightClass { get; }

    internal WeightClassFormula(decimal weight, int encumbranceModifier = 0, int thresholdModifier = 0)
    {
        SetWeightClass(weight, encumbranceModifier, thresholdModifier);
    }

    internal void SetWeightClass(decimal weight, int encumbranceModifier = 0, int thresholdModifier = 0)
    {
        if (weight < MediumThreshold + thresholdModifier)
        {
            _weightClass = WeightClass.Light;
        }
        else if (weight < HeavyThreshold + thresholdModifier)
        {
            _weightClass = WeightClass.Medium;
        }
        else if (weight < SuperHeavyThreshold + thresholdModifier)
        {
            _weightClass = WeightClass.Heavy;
        }
        else
        {
            _weightClass = WeightClass.SuperHeavy;
        }

        if (encumbranceModifier > 0 && _weightClass > WeightClass.Light)
        {
            _weightClass = _weightClass - encumbranceModifier;
        }
    }
}
