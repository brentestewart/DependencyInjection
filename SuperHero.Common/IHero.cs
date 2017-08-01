using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero.Common
{
    public interface IAttack
    {
        string Description { get; }
    }

    public class Punch : IAttack
    {
        public string Description => "Punched foe in the face!";
    }

    public class Kick : IAttack
    {
        public string Description => "Kicks foe in the groin!";
    }

    public class Shoot : IAttack
    {
        public string Description => "Shoots foe in the eye!";
    }

    public interface IWeapon
    {
        string Name { get; }
        WeaponType WeaponType { get; }
    }

    public class Unarmed : IWeapon
    {
        public string Name => "Unarmed";
        public WeaponType WeaponType => WeaponType.Unarmed;
    }

    public class BowAndArrow : IWeapon
    {
        public string Name => "Bow and Arrow";
        public WeaponType WeaponType => WeaponType.BowAndArrow;
    }

    public interface IHero
    {
        string HeroName { get; set; }
        string RealName { get; set; }
        Universe Universe { get; set; }
        HeroType HeroType { get; set; }
        IWeapon Weapon { get; set; }
        IAttack Attack { get; set; }
        int Health { get; set; }
        int Defense { get; set; }
        string LogoPath { get; set; }
        Dictionary<WeaponType, DamageRange> FightingSkills { get; set; }
        Dictionary<ArenaProperty, int> EnvironmentSkills { get; set; }
    }
}
