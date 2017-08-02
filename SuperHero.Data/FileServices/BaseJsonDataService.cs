using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using SuperHero.Common;

namespace SuperHero.Data.FileServices
{
    public abstract class BaseJsonDataService : IHeroDataService
    {
        protected const string DcHeroFilePath = @".\data\dc_heroes.json";
        protected const string MarvelHeroFilePath = @".\data\marvel_heroes.json";
        public abstract IEnumerable<HeroDto> GetHeroes();

        protected List<HeroDto> GetHeroesFromFile(string path)
        {
            using (var reader = new StreamReader(path))
            {
                var contents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<HeroDto>>(contents).OrderBy(h => h.HeroName).ToList();
            }
        }
    }
}