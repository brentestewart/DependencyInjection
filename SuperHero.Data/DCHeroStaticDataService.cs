﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHero.Common;

namespace SuperHero.Data
{
    public class DCHeroStaticDataService : IHeroDataService
    {
        public IEnumerable<HeroDto> GetHeroes()
        {
            var fightingSkills = new Dictionary<WeaponType, DamageRange>();
            fightingSkills.Add(WeaponType.Unarmed, new DamageRange { MinDamage = 0, MaxDamage = 100 });
            fightingSkills.Add(WeaponType.BowAndArrow, new DamageRange { MinDamage = 0, MaxDamage = 100 });
            fightingSkills.Add(WeaponType.Knife, new DamageRange { MinDamage = 0, MaxDamage = 100 });
            fightingSkills.Add(WeaponType.Sword, new DamageRange { MinDamage = 0, MaxDamage = 100 });

            var environmentSkills = new Dictionary<ArenaProperty, int>();
            environmentSkills.Add(ArenaProperty.IsDark, 50);
            environmentSkills.Add(ArenaProperty.IsOuterSpace, 50);
            environmentSkills.Add(ArenaProperty.IsUnderwater, 50);

            return new List<HeroDto>()
            {
                new HeroDto
                {
                    HeroName = "Ant-Man",
                    RealName = "Scott Lang",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Melee,
                    Health = 200,
                    Defense = 500,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/ant-man_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Black Widow",
                    RealName = "Natasha Romanovo",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Melee,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Black-Widow_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Captain America",
                    RealName = "Steve Rogers",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Melee,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Captain-America_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Cyclops",
                    RealName = "Scott Summers",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Ranged,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Cyclops_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Daredevil",
                    RealName = "Matt Murdock",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Melee,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Daredevil_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Hawkeye",
                    RealName = "Clint Barton",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Ranged,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Hawkeye_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Hulk",
                    RealName = "Bruce Banner",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Melee,
                    Health = 999,
                    Defense = 100,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Hulk_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Human Torch",
                    RealName = "Johnny Storm",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Ranged,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Human-Torch_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Ironman",
                    RealName = "Tony Stark",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Ranged,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Ironman_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Spiderman",
                    RealName = "Peter Parker",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Ranged,
                    Health = 300,
                    Defense = 900,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Spiderman_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Storm",
                    RealName = "Ororo Munrow",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Ranged,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Storm_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Wolverine",
                    RealName = "James Howlett",
                    Universe = Universe.Marvel,
                    HeroType = HeroType.Melee,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Wolverine_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Aquaman",
                    RealName = "Arthur Curry",
                    Universe = Universe.DC,
                    HeroType = HeroType.Melee,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Aquaman_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Atom",
                    RealName = "Ray Palmer",
                    Universe = Universe.DC,
                    HeroType = HeroType.Melee,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Atom_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Batman",
                    RealName = "Bruce Wayne",
                    Universe = Universe.DC,
                    HeroType = HeroType.Melee,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Batman_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Green Arrow",
                    RealName = "Oliver Queen",
                    Universe = Universe.DC,
                    HeroType = HeroType.Ranged,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Green-Arrow_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Green Lantern",
                    RealName = "Hal Jordan",
                    Universe = Universe.DC,
                    HeroType = HeroType.Melee,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Green-Lantern_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Hawkman",
                    RealName = "Carter Hall",
                    Universe = Universe.DC,
                    HeroType = HeroType.Melee,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Hawkman_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Supergirl",
                    RealName = "Kara Zor-El",
                    Universe = Universe.DC,
                    HeroType = HeroType.Melee,
                    Health = 700,
                    Defense = 700,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Supergirl_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Superman",
                    RealName = "Clark Kent",
                    Universe = Universe.DC,
                    HeroType = HeroType.Melee,
                    Health = 900,
                    Defense = 900,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Superman_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "The Flash",
                    RealName = "Barry Allen",
                    Universe = Universe.DC,
                    HeroType = HeroType.Melee,
                    Health = 300,
                    Defense = 800,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/The-Flash_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
                new HeroDto
                {
                    HeroName = "Wonder Woman",
                    RealName = "Diana Prince",
                    Universe = Universe.DC,
                    HeroType = HeroType.Melee,
                    Health = 300,
                    Defense = 300,
                    LogoPath = "pack://application:,,,/SuperHero.View;component/Assets/Images/Wonder-Woman_Logo.png",
                    FightingSkills = fightingSkills,
					EnvironmentSkills = environmentSkills
                },
            };
        }
    }
}
