using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHero.Common;
using SuperHero.Data;
using SuperHero.Data.Factories;

namespace SuperHero.Repository
{
    public class DCHeroRepository : IHeroRepository
    {
        public IHeroFactory HeroFactory { get; set; }
        private IHeroDataService DataService { get; set; }

        public DCHeroRepository(IHeroFactory heroFactory)
        {
            //DataService = new DCHeroStaticDataService();
            //DataService = new DCHeroJsonDataService();
            HeroFactory = heroFactory;
            DataService = HeroServiceLocator.Resolve<IHeroDataService>();
        }

        public List<IHero> GetAllHeroes()
        {
            var heroList = new List<IHero>();
            DataService.GetHeroes().ToList().ForEach(dto => heroList.Add(HeroFactory.CreateHero(dto)));
            return heroList;
        }
    }
}
