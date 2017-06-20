using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_3
{
    public class Tablero
    {
        public Jugador p1;
        public List<Minions> mazito;
        public List<Minions> tablerito = new List<Minions>();
        public Tablero(Jugador p1, List<Minions> mazito)
        {
            this.p1 = p1;
            this.mazito = mazito;
        }
        public void ActivarMinion(Minions carta)
        {
            if (tablerito.Count < 8)
            {
                Minions v1 = p1.Manito[p1.Manito.IndexOf(carta)];
                tablerito.Add(v1);
            }
            if (tablerito.Count > 8)
            {
                Console.WriteLine("no puedes invocar mas minions");
            }

        }
        public virtual void Describir()
        {
            foreach (Carta carta in tablerito)
            {
                carta.Describir();
            }
        }

    }
}
