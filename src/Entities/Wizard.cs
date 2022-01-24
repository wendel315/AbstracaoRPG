namespace Abstracao_RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public override string Attack() 
        {
            return Name
                + " lançou magia";
        }

        public string Attack(int Bonus) 
        {
            if (Bonus > 6) 
            {
                  return Name 
                    + " Lançou magia super efetiva com bônus de ataque de "
                    + Bonus;   
            }

            else 
            {
                return Name
                    + " Lançou uma magia com força fraca com bonus de "
                    + Bonus;
            }
        }
    }
}