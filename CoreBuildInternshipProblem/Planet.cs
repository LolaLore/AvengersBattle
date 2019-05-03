using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBuildInternshipProblem
{
    class Planet : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HeroAttackModifier { get; set; }
        public int HeroHealthModifier { get; set; }
        public int VillainAttackModifier { get; set; }
        public int VillainHealthModifier { get; set; }

        public Planet(int id, string name, string description, int heroAttackModifier, int heroHealthModifier, int villainAttackModifier, int villainHealthModifier)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.HeroAttackModifier = heroAttackModifier;
            this.HeroHealthModifier = heroHealthModifier;
            this.VillainAttackModifier = villainAttackModifier;
            this.VillainHealthModifier = villainHealthModifier;
        }

        public Planet()
        {
        }

        public object Clone()
        {
            return new Planet(Id, Name, Description, HeroAttackModifier, HeroHealthModifier, VillainAttackModifier, VillainHealthModifier);
        }
    }
}
