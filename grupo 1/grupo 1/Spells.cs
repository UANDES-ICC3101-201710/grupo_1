using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_3
{
    public class Spells : Carta
    {
        public Spells(string Name, int Cost)
            : base(Name, Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
        }
        public override void Describir()
        {
            Console.WriteLine(" nombre " + this.Name + " cost: " + this.Cost);
            base.Describir();
        }
    }
}
