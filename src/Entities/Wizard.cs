namespace dio_projetoDotnet.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }

        public override string Attack(){
            return this.Name + " Lançou Magia" + " e gastou 1 MP. Total de Mp = " + (this.Mp - 1);
        }
        
        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + " Lançou Magia super efetiva com bonus de ataque de " + Bonus;
            } else{
                return this.Name + " Lançou Magia fraca com bonus de ataque de " + Bonus;
            }
        }
    }
}