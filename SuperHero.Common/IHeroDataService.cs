using System.Collections.Generic;

namespace SuperHero.Common
{
    public interface IHeroDataService
    {
        IEnumerable<HeroDto> GetHeroes();
    }
}
