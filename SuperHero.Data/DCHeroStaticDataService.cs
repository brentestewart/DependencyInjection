using System.Collections.Generic;
using System.Linq;
using SuperHero.Common;

namespace SuperHero.Data
{
    public class DCHeroStaticDataService : BaseHeroStaticDataService
	{
		public override IEnumerable<HeroDto> GetHeroes()
		{
			return Heroes.Where(h => h.Universe == Universe.DC).OrderBy(h => h.HeroName);
		}
	}
}
