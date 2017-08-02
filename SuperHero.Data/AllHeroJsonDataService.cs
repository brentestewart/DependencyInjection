using System.Collections.Generic;
using System.Linq;
using SuperHero.Common;

namespace SuperHero.Data
{
    public class AllHeroJsonDataService : BaseJsonDataService
    {
        public override IEnumerable<HeroDto> GetHeroes()
        {
            var heroes = new List<HeroDto>();
            heroes.AddRange(GetHeroesFromFile(DcHeroFilePath));
            heroes.AddRange(GetHeroesFromFile(MarvelHeroFilePath));
            return heroes.OrderBy(h => h.HeroName);
        }
    }
}