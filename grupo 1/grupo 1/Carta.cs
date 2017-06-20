using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_3
{
    public class Carta
    {
        public string Name;
        public int Cost;

        public Carta(string Name, int Cost)
        {
            this.Name = Name;
            this.Cost = Cost;

        }
        public int EntregarCosto()
        {
            return this.Cost;
        }
        public virtual void Describir()
        {
        }
        public string EntregarNombre()
        {
            return this.Name;
        }

    }
}
