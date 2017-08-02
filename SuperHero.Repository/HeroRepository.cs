using System.Collections.Generic;
using System.Linq;
using SuperHero.Common;
using SuperHero.Data;
using SuperHero.Data.Factories;
using SuperHero.Data.FileServices;

namespace SuperHero.Repository
{
    public class HeroRepository : IHeroRepository
    {
        public IHeroFactory HeroFactory { get; set; }
        private IHeroDataService DataService { get; set; }

        public HeroRepository()
        {
            DataService = new DCHeroJsonDataService();
            HeroFactory = new HeroFactory();
        }

        public List<IHero> GetAllHeroes()
        {
            var heroList = new List<IHero>();
            DataService.GetHeroes().ToList().ForEach(dto => heroList.Add(HeroFactory.CreateHero(dto)));
            return heroList;
        }
    }
}
