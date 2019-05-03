using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBuildInternshipProblem
{
    class Character : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public bool IsVillain { get; set; }

        public Character(int id, string name, string description,int attack,int health, bool isVillain)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Attack = attack;
            this.Health = health;
            this.IsVillain = isVillain;
        }

        public Character()
        {
        }

        public object Clone()
        {
            return new Character(Id, Name, Description, Attack, Health, IsVillain);
        }
    }
}
