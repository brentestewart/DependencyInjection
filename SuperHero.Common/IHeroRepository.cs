using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero.Common
{
    public interface IHeroRepository
    {
        List<IHero> GetAllHeroes();
    }
}
