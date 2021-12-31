using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class ClassInit
    {
        public static void Init()
        {
            Characters Bowman = new Characters();
            Bowman.Id = 1;
            Bowman.Hp = 20;
            Bowman.Damage = 15;
            Bowman.Armor = 5;
            Characters Warrior = new Characters();
            Warrior.Id = 2;
            Warrior.Hp = 50;
            Warrior.Damage = 10;
            Warrior.Armor = 15;
            Characters Priest = new Characters();
            Priest.Id = 3;
            Priest.Hp = 30;
            Priest.Damage = 10;
            Priest.Armor = 5;
        }
    }
}
