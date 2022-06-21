namespace DOTNET_POO.src.Entities
{
    public class Hero
    {
        public Hero()
        {
            
        }

        public Hero(string Name, int Level, string HeroType, int HP, int MP)
        {   
            this.Name = Name; 
            this.Level = Level; 
            this.HeroType = HeroType; 
        }

        public string Name;
        public int Level; 
        public string HeroType;
        public int HP; 
        public int MP; 



        public override string ToString()
        {
            return $"{Name} {Level} {HeroType}";
        }

        public string Attack()
        {
            return $" {Name} Atacou com sua Espada!"; 
        }




    }
}