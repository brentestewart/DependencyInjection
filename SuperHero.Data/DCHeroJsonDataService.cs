using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Ninject;
using SuperHero.Common;
using SuperHero.Data.Factories;

namespace SuperHero.Data
{
    public class DCHeroJsonDataService : IHeroDataService
    {
        public IEnumerable<HeroDto> GetHeroes()
        {
            using (var reader = new StreamReader(@".\data\dc_heroes.json"))
            {
                var results = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<HeroDto>>(results).ToList();
            }
        }
    }
}
