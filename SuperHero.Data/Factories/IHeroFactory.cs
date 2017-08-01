using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHero.Common;

namespace SuperHero.Data.Factories
{
    public interface IHeroFactory
    {
        Hero CreateHero(HeroDto dto);
    }
}
