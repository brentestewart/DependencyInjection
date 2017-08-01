using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero.Common
{
    public class HeroDto
    {
        public string HeroName { get; set; }
        public string RealName { get; set; }
        public Universe Universe { get; set; }
        public HeroType HeroType { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public string LogoPath { get; set; }
        public Dictionary<WeaponType, DamageRange> FightingSkills { get; set; }
        public Dictionary<ArenaProperty, int> EnvironmentSkills { get; set; }
    }

    public class Hero : IHero
    {
        public string HeroName { get; set; }
        public string RealName { get; set; }
        public Universe Universe { get; set; }
        public HeroType HeroType { get; set; }
        public IWeapon Weapon { get; set; }
        public IAttack Attack { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public string LogoPath { get; set; }
        public Dictionary<WeaponType, DamageRange> FightingSkills { get; set; }
        public Dictionary<ArenaProperty, int> EnvironmentSkills { get; set; }
        public string DamageRange => $"{FightingSkills[Weapon.WeaponType]?.MinDamage} to {FightingSkills[Weapon.WeaponType]?.MaxDamage}";

        public Hero(HeroDto dto, IWeapon weapon, IAttack attack)
        {
            HeroName = dto.HeroName;
            RealName = dto.RealName;
            Universe = dto.Universe;
            HeroType = dto.HeroType;
            Health = dto.Health;
            Defense = dto.Defense;
            LogoPath = dto.LogoPath;
            FightingSkills = dto.FightingSkills;
            EnvironmentSkills = dto.EnvironmentSkills;
            Weapon = weapon;
            Attack = attack;
        }
    }

    public class DamageRange
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
    }
}
