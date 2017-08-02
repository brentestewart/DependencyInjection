using System.Collections.Generic;
using System.Linq;
using SuperHero.Common;

namespace SuperHero.Data
{
    public class MarvelHeroStaticDataService : BaseHeroStaticDataService
    {
        public override IEnumerable<HeroDto> GetHeroes()
        {
            return Heroes.Where(h => h.Universe == Universe.Marvel).OrderBy(h => h.HeroName);
        }
    }
}