using System.Collections.Generic;
using SuperHero.Common;

namespace SuperHero.Data.FileServices
{
    public class DCHeroJsonDataService : BaseJsonDataService
    {
        public override IEnumerable<HeroDto> GetHeroes()
        {
            return GetHeroesFromFile(DcHeroFilePath);
        }
    }
}
