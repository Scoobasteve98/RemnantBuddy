using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemnantBuddyBackend.Formulas;

internal class Formula : IFormula
{
    public decimal Percent { get; set; }

    public decimal Amount { get; set; }

    public decimal Calculate()
    {
        return Amount * Percent;
    }
}
