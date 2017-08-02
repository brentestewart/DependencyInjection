using SuperHero.Common;

namespace SuperHero.Data.Factories
{
    public interface IHeroFactory
    {
        Hero CreateHero(HeroDto dto);
    }
}
