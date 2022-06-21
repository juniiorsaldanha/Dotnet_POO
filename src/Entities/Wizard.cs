namespace DOTNET_POO.src.Entities
{
    public class Wizard: Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name; 
            this.Level = Level; 
            this.HeroType = HeroType;
        }
        public virtual string Attack()
        {
            return $"{Name} Lançou Magia"; 
        }

        public virtual string Attack(int Bonus)
        {
            if(Bonus > 6)
                return $"{Name} Lançou Magia super efetiva com bonus de {Bonus}";
            else
                return  $"{Name} Lançou Magia com força fraca com bonus de {Bonus}";
        }       
    }
}