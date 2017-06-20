using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_3
{
    public class Minions : Carta
    {
        public int Ataque;
        public int Vida;
        public int Vidamax;
        public string Nature;
        public int Disponible;
        public Minions(string Name, int Cost, int Vida, int Vidamax, int Ataque, string Nature, int Disponible)
            : base(Name, Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
            this.Ataque = Ataque;
            this.Vida = Vida;
            this.Vidamax = Vidamax;
            this.Nature = Nature;
            this.Disponible = Disponible;
        }
        public int EntregarVida()
        {
            return this.Vida;
        }
        public int EntregarVidamax()
        {
            return this.Vidamax;
        }
        public int EntregarAtaque()
        {
            return this.Ataque;
        }
        public int EntregarDisponible()
        {
            return this.Disponible;
        }
        public override void Describir()
        {
            Console.WriteLine(" nombre: " + this.Name + " cost: " + this.Cost + " ataque: " + this.Ataque + " Vida: " + this.Vida + " Nature: " + this.Nature);
            base.Describir();
        }

    }
}
