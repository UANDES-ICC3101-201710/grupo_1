using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_3
{
    public class Mazo
    {
        public List<Minions> mazito = new List<Minions>();
        public void AgregarCarta(Minions carta)
        {
            mazito.Add(carta);
        }
        public void ShuffleList()
        {
            List<Minions> shuffledList = new List<Minions>();
            Random r = new Random();
            int RandomIndex = 0;
            while (mazito.Count > 0)
            {
                RandomIndex = r.Next(0, mazito.Count);
                shuffledList.Add(mazito[RandomIndex]);
                mazito.RemoveAt(RandomIndex);
            }
            this.mazito = shuffledList;
        }

        public Minions EntregarCarta()
        {
            return mazito[mazito.Count - 1];

        }
        public void Borrar()
        {
            mazito.RemoveAt(mazito.Count - 1);
        }


    }
}
