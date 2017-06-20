using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_3
{
    public class Jugador
    {
        public string Usuario;
        public int Rango;
        public List<Minions> mazito;
        public int Cristal;
        public int Turno;
        public int ocupado;
        public List<Minions> Manito = new List<Minions>();
        public Heroe heroe;
        public virtual void Describir()
        {
            Console.WriteLine("Tu Mano es: ");
            int i = 0;
            foreach (Minions carta in Manito)
            {
                Console.WriteLine(i);
                carta.Describir();
                i++;
            }

        }
        public void SacarCarta(Mazo mazito)
        {
            if (Manito.Count <= 10)
            {
                mazito.ShuffleList();
                Manito.Add(mazito.EntregarCarta());
                Console.WriteLine("sacaste : ");
                mazito.EntregarCarta().Describir();
                mazito.Borrar();
            }
            if (Manito.Count > 10)
            {
                Manito.Remove(mazito.EntregarCarta());
                Console.WriteLine("tu mano esta muy llena, se ha borrado: ");
                mazito.EntregarCarta().Describir();
                mazito.Borrar();
            }
        }


        public Jugador(string Usuario, int Rango, int Cristal, List<Minions> mazito, int Turno, int ocupado, Heroe heroe)
        {

            this.Usuario = Usuario;
            this.Rango = Rango;
            this.Cristal = Cristal;
            this.Turno = Turno;
            this.ocupado = ocupado;
            this.mazito = mazito;
            this.heroe = heroe;
        }
        public string DarNombre()
        {
            return this.Usuario;
        }
        public void InvocarMinion(Minions carta, Tablero tablero)
        {
            if (Manito.Contains(carta) == true)
            {
                if (carta.EntregarCosto() <= Cristal)
                {
                    Console.WriteLine("invocaste a un :");
                    carta.Describir();
                    tablero.ActivarMinion(carta);
                    Manito.Remove(carta);
                    this.Cristal = this.Cristal - carta.Cost;

                }
                else if (carta.EntregarCosto() > Cristal)
                {
                    Console.WriteLine("no tienes suficiente cristal ");
                }
                if (carta.EntregarNombre() == "Coin")
                {
                    Cristal += 1;
                    ocupado = 1;
                }
            }
            else
            {
                Console.WriteLine("No puedes Invocar una carta que no esta en tu mano");
            }
        }

    }
}
