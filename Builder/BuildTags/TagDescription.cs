using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemnantBuddyBackend.BuildTags
{
    public class TagDescription
    {
        public Category Category { get; set; }

        public List<Effect> Effects = new List<Effect>();
    }
}
