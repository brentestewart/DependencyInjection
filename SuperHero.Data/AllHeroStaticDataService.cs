using System.Collections.Generic;
using System.Linq;
using SuperHero.Common;

namespace SuperHero.Data
{
    public class AllHeroStaticDataService : BaseHeroStaticDataService
    {
        public override IEnumerable<HeroDto> GetHeroes()
        {
            return Heroes.OrderBy(h => h.HeroName);
        }
    }
}