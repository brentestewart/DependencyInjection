using System.Collections.Generic;
using SuperHero.Common;

namespace SuperHero.Data
{
    public class MarvelHeroJsonDataService : BaseJsonDataService
    {
        public override IEnumerable<HeroDto> GetHeroes()
        {
            return GetHeroesFromFile(MarvelHeroFilePath);
        }
    }
}