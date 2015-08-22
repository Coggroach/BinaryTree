using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    enum Rarity
    {
        Free,
        Common,
        Rare,
        Epic,
        Legendary
    }
    enum Class 
    {
        Priest,
        Warrior,
        Mage,
        Druid,
        Shaman,
        Hunter,
        Rogue,
        Paladin,
        Warlock
    }
    enum Type
    {
        Minion,
        Spell,
        Hero_Power,
        Weapon
    }
    class Card
    {
        public string CardId { get; private set; }
        public string Name { get; private set; }
        public string CardSet { get; private set; }
        public Rarity Rarity { get; private set; }
        public int Attack { get; private set; }
        public int Health { get; private set; }
        public int Cost{ get; private set; }
        public int Durability{ get; private set; }
        public Class Character{ get; private set; }
        public Type Type{ get; private set; }
        public String Text{ get; private set; }
        public List<Object> Mechanics{ get; private set; }
        public Card(string c, string n, string cs, Rarity r, int a, int h, int co, int dur, Class ch, Type t, String txt, List<Object> m)
        {
            this.CardId = c;
            this.Name = n;
            this.CardSet = cs;
            this.Rarity = r;
            this.Attack = a;
            this.Health = h;
            this.Cost = co;
            this.Durability = dur;
            this.Character = ch;
            this.Type = t;
            this.Text = txt;
            this.Mechanics = m;
        }
        public Card(string c, string n)
        {
            this.CardId = c;
            this.Name = n;
        }
        public void Write()
        {
            Console.WriteLine(this.Name);
        }

    }
}
