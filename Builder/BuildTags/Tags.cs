using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemnantBuddyBackend.BuildTags;

public class Tags
{
    public static TagDescription LowEnemyHealth = new()
    {
        Category = Category.Control,
        Effects = [Effect.LowEnemyHealth],
    };

    public static TagDescription AOE = new()
    {
        Category = Category.Utility,
        Effects = [Effect.AOE],
    };

    public static TagDescription Aura = new()
    {
        Category = Category.Utility,
        Effects = [Effect.Aura],
    };
}
