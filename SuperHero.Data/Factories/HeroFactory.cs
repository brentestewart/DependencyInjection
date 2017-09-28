using SuperHero.Common;

namespace SuperHero.Data.Factories
{
    public class HeroFactory : IHeroFactory
    {
        public IWeapon Weapon { get; set; }
        public IAttack Attack { get; set; }

        public HeroFactory()
        {
            Weapon = new Unarmed();
            Attack = new Punch();
        }
        public Hero CreateHero(HeroDto dto)
        {
            return new Hero(dto, Weapon, Attack);
        }
    }
}