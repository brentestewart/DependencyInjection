using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero.Common
{
    public interface IHeroServiceLocator
    {
        IHeroDataService GetDCHeroService();
        IHeroDataService GetMarvelService();
    }
}
