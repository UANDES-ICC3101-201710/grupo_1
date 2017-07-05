using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entrega_3
{
    public class Heroe
    {
        public string _NombreH;
        public int _PtVidaH;
        public string _PoderH;
        public int _Armadura;
        public string NombreH
        {
            get { return _NombreH; }
            set { _NombreH = value; }
        }
        public int PtVida
        {
            get { return _PtVidaH; }
            set { _PtVidaH = value; }
        }
        public int ArmaduraH
        {
            get { return _Armadura; }
            set { _Armadura = value; }
        }
        public string PoderHeroe
        {
            get { return _PoderH; }
            set { _PoderH = value; }
        }

        public Heroe(string nomH, int LP, string PoderH, int Armor)
        {
            NombreH = nomH;
            PtVida = LP;
            PoderHeroe = PoderH;
            ArmaduraH = Armor;

        }

        public virtual void HabilidadHeroe()
        {

        }

    }

    public class Warrior : Heroe
    {

        public Warrior(string nomH, int LP, string PoderH, int Armor)
            : base(nomH, LP, PoderH, Armor)
        {
        }

        public override void HabilidadHeroe()
        {
            ArmaduraH = ArmaduraH + 2;
        }


    }
    public class Hunter : Heroe
    {

        public Hunter(string nomH, int LP, string PoderH, int ArmaduraH)
            : base(nomH, LP, PoderH, ArmaduraH)
        {


        }
        public override void HabilidadHeroe()
        {

        }

    }
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
    public class Minions : Carta
    {
        public int Ataque;
        public int Vida;
        public string Nature;
        public int Disponible;
        public string Source;


        public Minions(string Name, int Cost, int Vida, int Ataque, string Nature, int Disponible, string Source)
            : base(Name, Cost)
        {
            this.Name = Name;
            this.Cost = Cost;
            this.Ataque = Ataque;
            this.Vida = Vida;
            this.Nature = Nature;
            this.Source = Source;
            this.Disponible = Disponible;
        }
        public string EntregarSource()
        {
            return this.Source;
        }
        public int EntregarVida()
        {
            return this.Vida;
        }
        public int EntregarAtaque()
        {
            return this.Ataque;
        }
        public int EntregarDisponible()
        {
            return this.Disponible;
        }
        public string DarNombre()
        {
            return this.Name;
        }
        public override void Describir()
        {
            Console.WriteLine(" nombre: " + this.Name + " cost: " + this.Cost + " ataque: " + this.Ataque + " Vida: " + this.Vida + " Nature: " + this.Nature);
            base.Describir();
        }

    }
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
        public Minions SacarCarta(Mazo mazito)
        {
            if (Manito.Count <= 10)
            {
                mazito.ShuffleList();
                Manito.Add(mazito.EntregarCarta());
                Console.WriteLine("sacaste : ");
                mazito.EntregarCarta().Describir();

                mazito.Borrar();
                return mazito.EntregarCarta();

            }
            else
            {
                Manito.Remove(mazito.EntregarCarta());
                Console.WriteLine("tu mano esta muy llena, se ha borrado: ");
                mazito.EntregarCarta().Describir();
                mazito.Borrar();
                return mazito.EntregarCarta();

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
    public class Jugar
    {
        public List<Minions> mazito;
        public List<Minions> Manito;
        public List<Minions> Tablero;
        int random;

        public void Turno(Jugador p1, Mazo mazito, Jugador p2, Mazo mazito2, Tablero tablerito, Tablero tablerito2)
        {
            string Desicion1;
            string Desicion2;
            string MinionE;
            string minionataca;
            string atacar;
            int vidaminion;
            int ataqueminion;
            int vidaminion2;
            int ataqueminion2;
            int SeSigue = 0;
            int sacacarta = 0;
            int noserindio = 0;
            int HeroeAtaco = 0;


            Random rnd = new Random();
            random = rnd.Next(0, 2);
            if (random == 0)
            {

                Console.WriteLine("Comienza " + p1.DarNombre());
                p2.ocupado = -1;
                Console.WriteLine("tus cartas son : ");
                p1.SacarCarta(mazito);
                p1.SacarCarta(mazito);
                p1.SacarCarta(mazito);
                Console.WriteLine(Environment.NewLine + p2.DarNombre() + " tus cartas son : ");
                p2.SacarCarta(mazito2);
                p2.SacarCarta(mazito2);
                p2.SacarCarta(mazito2);
                p2.SacarCarta(mazito2);
                Spells coin = new Spells("Magic Extra Coin", 0);
                p1.Cristal = 1;
                p2.Cristal = 0;
                p1.Turno = 1;
                p2.Turno = 0;

            }
            if (random == 1)
            {
                Console.WriteLine(rnd);
                Console.WriteLine("Comienza " + p2.DarNombre());
                p1.ocupado = -1;
                Console.WriteLine("tus cartas son : ");
                p2.SacarCarta(mazito2);
                p2.SacarCarta(mazito2);
                p2.SacarCarta(mazito2);
                Console.WriteLine(Environment.NewLine + p1.DarNombre() + " tus cartas son : ");
                p1.SacarCarta(mazito);
                p1.SacarCarta(mazito);
                p1.SacarCarta(mazito);
                p1.SacarCarta(mazito);
                p2.Cristal = 1;
                p1.Cristal = 0;
                p2.Turno = 1;
                p1.Turno = 0;


            }

            while (p1.heroe.PtVida > 0 && p2.heroe.PtVida > 0)
            {
                SeSigue = 0;
                HeroeAtaco = 0;
                while (SeSigue == 0)
                {

                    // Pox Segunda
                    if (random == 1) // este es benja en su primer turno , empezando él
                    {
                        Console.WriteLine(Environment.NewLine + "Le toca a: " + p2.DarNombre());
                        Console.WriteLine("Tienes " + p2.Cristal + " Cristal(es)");
                        Console.WriteLine("1.- invocar minnion." + Environment.NewLine + "2.- Atacar" + Environment.NewLine + "3.- Habilidad Heroe" + Environment.NewLine + "4.-Rendirse" + Environment.NewLine + "5.-Terminar Turno" + Environment.NewLine);
                        Desicion1 = Convert.ToString(Console.ReadLine());
                        if (sacacarta == 0)
                        {
                            p2.SacarCarta(mazito2);
                            Console.WriteLine("Te quedan " + p2.Cristal + " Cristal(es)" + Environment.NewLine);
                            sacacarta = 1;
                        }

                        if (Desicion1 == "1")
                        {
                            Console.WriteLine(p2.DarNombre() + " tu mano es: ");
                            p2.Describir();
                            Console.WriteLine(Environment.NewLine + "Que carta desea invocar ingrese el numero de la posicion (Partiendo de 0)" + Environment.NewLine);
                            MinionE = Convert.ToString(Console.ReadLine());
                            if (Convert.ToInt32(MinionE) <= p2.Manito.Count)
                            {
                                p2.InvocarMinion(p2.Manito[Convert.ToInt32(MinionE)], tablerito2);
                            }
                            else
                            {
                                Console.WriteLine("Porfavor escojer un numero valido.");
                            }
                        }
                        // empieza opcion 2
                        else if (Desicion1 == "2" && tablerito2.tablerito.Count > 0)
                        {
                            Console.WriteLine("Con que minion Atacaras, seleccione un numero del 0 al 7 " + Environment.NewLine);
                            tablerito2.Describir();
                            minionataca = Convert.ToString(Console.ReadLine());
                            while (Convert.ToInt32(minionataca) > tablerito2.tablerito.Count)
                            {
                                Console.WriteLine("Introduzca un numero valido");
                                minionataca = Convert.ToString(Console.ReadLine());
                            }
                            if (tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarDisponible() == 0)
                            {
                                Console.WriteLine(Environment.NewLine + "Los minions no pueden atacar el mismo turno en el que son invocados, espera minimo 1 turno mas!" + Environment.NewLine);
                            }
                            else if (tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarDisponible() == 1)
                            {
                                Console.WriteLine(Environment.NewLine + "Tu minion tiene : " + tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque() + " de ataque." + Environment.NewLine);
                                ataqueminion2 = tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque();
                                vidaminion2 = tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarVida();
                                tablerito2.tablerito[Convert.ToInt32(minionataca)].Disponible = 0;
                                Console.WriteLine("A Quien Atacar (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito.Describir();
                                atacar = Convert.ToString(Console.ReadLine());
                                while ((tablerito.tablerito.Count == 0 && Convert.ToInt32(atacar) != 8) || Convert.ToInt32(atacar) > tablerito.tablerito.Count)
                                {
                                    if (Convert.ToInt32(atacar) > tablerito.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba de nuevo");
                                        atacar = Convert.ToString(Console.ReadLine());
                                        if (Convert.ToInt32(atacar) == 8)
                                        {
                                            break;
                                        }
                                    }
                                    else if (tablerito.tablerito.Count == 0)
                                    {
                                        Console.WriteLine("Tu oponente no tiene minions al cual atacar! prueba atacando a su Heroe");
                                        atacar = "8";
                                    }

                                }
                                if (atacar == "8" && p1.heroe.ArmaduraH <= 0)
                                {
                                    p1.heroe.PtVida = p1.heroe.PtVida - ataqueminion2;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p1.heroe.ArmaduraH > 0)
                                {
                                    p1.heroe.ArmaduraH = p1.heroe.ArmaduraH - ataqueminion2;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito.tablerito.Contains(tablerito.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque();

                                    vidaminion2 = vidaminion2 - ataqueminion;
                                    vidaminion = vidaminion - ataqueminion2;

                                    Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion);
                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion2);

                                    if (vidaminion2 <= 0)
                                    {
                                        Console.WriteLine(Environment.NewLine + p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarNombre() + " ha muerto " + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito2.Describir();
                                    }
                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(minionataca)]);
                                        Console.WriteLine(p1.DarNombre() + " Tu tablero ahora es: " + Environment.NewLine);
                                        tablerito.Describir();

                                    }
                                    if (vidaminion2 > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(minionataca)].Vida = vidaminion2;
                                    }
                                    tablerito2.tablerito[Convert.ToInt32(minionataca)].Vida = vidaminion2;
                                    if (vidaminion > 0)
                                    {
                                        tablerito.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }

                            }


                        }
                        else if (Desicion1 == "2" && tablerito2.tablerito.Count == 0)
                        {
                            Console.WriteLine("No tienes minions, elige otra opción.");
                            Desicion1 = Convert.ToString(Console.ReadLine());
                        }

                        // Termina opcion 2
                        // empieza opcion 3
                        else if (Desicion1 == "3" && HeroeAtaco == 0)
                        {
                            Console.WriteLine("Tu heroe es: " + p2.heroe.NombreH + Environment.NewLine + "Su habilidad es: " + p2.heroe.PoderHeroe);
                            if (p2.heroe.PoderHeroe == "Steady Shot" && p2.Cristal >= 2)
                            {
                                p1.heroe.PtVida = p1.heroe.PtVida - 2;
                                Console.WriteLine("Le quedan " + p1.heroe.PtVida + " Puntos de vida al Heroe de " + p1.DarNombre());
                                p2.Cristal = p2.Cristal - 2;
                                HeroeAtaco = 1;
                            }
                            else if (p2.heroe.PoderHeroe == "Armor UP!" && p2.Cristal >= 2)
                            {
                                p2.heroe.ArmaduraH = p2.heroe.ArmaduraH + 2;
                                Console.WriteLine("Tu heroe ahora tiene " + p2.heroe.ArmaduraH + " puntos de armadura.");
                                p2.Cristal = p2.Cristal - 2;
                                HeroeAtaco = 1;
                            }
                            else
                            {
                                Console.WriteLine("tu heroe no puede atacar");
                            }

                        }
                        else if (Desicion1 == "3" && HeroeAtaco == 1)
                        {
                            Console.WriteLine(Environment.NewLine + "Tu Heroe ya ataco este turno, vuelve a intentarlo en él proximo." + Environment.NewLine);
                        }
                        else if (Desicion1 == "4")
                        {
                            p2.heroe.PtVida = -1;
                            noserindio = 1;
                            SeSigue = 1;
                        }

                        //Termina opcion 3

                        // empieza Opcion 5
                        else if (Desicion1 == "5")
                        {
                            foreach (Minions carta in tablerito2.tablerito)
                            {
                                carta.Disponible = 1;
                            }

                            p1.Turno += 1;

                            if (p1.Turno <= 10)
                            {
                                p1.Cristal = p1.Turno;
                            }
                            else
                            {
                                p1.Cristal = 10;
                            }
                            sacacarta = 0;
                            SeSigue = 1;

                        }//termina opcion 5
                        else
                        {

                        }

                    }
                    // PoX Primera
                    if (random == 0) // esta es PoX en su primer turno empezando ella
                    {
                        Console.WriteLine(Environment.NewLine + "Le toca a: " + p1.DarNombre());
                        Console.WriteLine("Tienes " + p1.Cristal + " Cristal(es)");
                        Console.WriteLine("1.- invocar minnion." + Environment.NewLine + "2.- Atacar" + Environment.NewLine + "3.- Habilidad Heroe" + Environment.NewLine + "4.-Rendirse" + Environment.NewLine + "5.-Terminar Turno" + Environment.NewLine);
                        Desicion1 = Convert.ToString(Console.ReadLine());
                        if (sacacarta == 0)
                        {
                            p1.SacarCarta(mazito);
                            Console.WriteLine("Te quedan " + p1.Cristal + " Cristal(es)" + Environment.NewLine);
                            sacacarta = 1;
                        }
                        if (Desicion1 == "1")
                        {

                            Console.WriteLine(p1.DarNombre() + " tu mano es: ");
                            p1.Describir();
                            Console.WriteLine(Environment.NewLine + "Que carta desea invocar ingrese el numero de la posicion (Partiendo de 0)" + Environment.NewLine);
                            MinionE = Convert.ToString(Console.ReadLine());
                            if (Convert.ToInt32(MinionE) <= p1.Manito.Count)
                            {
                                p1.InvocarMinion(p1.Manito[Convert.ToInt32(MinionE)], tablerito);
                            }
                            else
                            {
                                Console.WriteLine("Porfavor escojer un numero valido.");
                            }
                        }
                        else if (Desicion1 == "2" && tablerito.tablerito.Count > 0)
                        {
                            Console.WriteLine("Con que minion Atacaras, seleccione un numero del 0 al 7 " + Environment.NewLine);
                            tablerito.Describir();
                            minionataca = Convert.ToString(Console.ReadLine());
                            while (Convert.ToInt32(minionataca) > tablerito.tablerito.Count)
                            {
                                Console.WriteLine("Introduzca un numero valido");
                                minionataca = Convert.ToString(Console.ReadLine());
                            }
                            if (Convert.ToInt32(minionataca) > tablerito.tablerito.Count)
                            {
                                Console.WriteLine("Introduzca un numero valido");
                                minionataca = Convert.ToString(Console.ReadLine());
                            }
                            if (tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarDisponible() == 0)
                            {
                                Console.WriteLine(Environment.NewLine + "Los minions no pueden atacar el mismo turno en el que son invocados, espera minimo 1 turno mas!" + Environment.NewLine);
                            }
                            else if (tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarDisponible() == 1)
                            {
                                Console.WriteLine(Environment.NewLine + "Tu minion tiene : " + tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque() + " de ataque." + Environment.NewLine);
                                ataqueminion = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque();
                                tablerito.tablerito[Convert.ToInt32(minionataca)].Disponible = 0;
                                vidaminion = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarVida();
                                Console.WriteLine("A Quien Atacar (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito2.Describir();
                                atacar = Convert.ToString(Console.ReadLine());
                                while ((tablerito2.tablerito.Count == 0 && Convert.ToInt32(atacar) != 8) || Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                {
                                    if (Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba denuevo");
                                        atacar = Convert.ToString(Console.ReadLine());
                                        if (atacar == "8")
                                        {
                                            break;
                                        }
                                    }
                                    else if (tablerito2.tablerito.Count == 0)
                                    {
                                        Console.WriteLine("Tu oponente no tiene minions al cual atacar! prueba atacando a su Heroe");
                                        atacar = "8";
                                    }

                                }
                                if (atacar == "8" && p2.heroe.ArmaduraH <= 0)
                                {
                                    p2.heroe.PtVida = p2.heroe.PtVida - ataqueminion;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.PtVida + " puntos de vida.");
                                }
                                if (atacar == "8" && p2.heroe.ArmaduraH > 0)
                                {
                                    p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - ataqueminion;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le queda " + p2.heroe.ArmaduraH + " de armadura.");
                                }
                                else if (tablerito2.tablerito.Contains(tablerito2.tablerito[Convert.ToInt32(atacar)]) == true)
                                {

                                    vidaminion2 = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion2 = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque();

                                    vidaminion = vidaminion - ataqueminion2;
                                    vidaminion2 = vidaminion2 - ataqueminion;

                                    Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion);
                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion2);

                                    if (vidaminion2 <= 0)
                                    {
                                        Console.WriteLine(p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto. " + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero ahora es: ");
                                        tablerito2.Describir();
                                    }
                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarNombre() + " ha muerto. " + Environment.NewLine);
                                        Console.WriteLine(p1.DarNombre() + " tu tablero ahora es:");
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(minionataca)]);
                                        tablerito.Describir();

                                    }
                                    if (vidaminion2 > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(minionataca)].Vida = vidaminion2;
                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }

                            }
                            else
                            {

                            }

                        }
                        else if (Desicion1 == "2" && tablerito.tablerito.Count == 0)
                        {
                            Console.WriteLine("Eliga una opcion valida");
                            Desicion1 = Convert.ToString(Console.ReadLine());

                        }
                        else if (Desicion1 == "3" && HeroeAtaco == 0)
                        {
                            Console.WriteLine("Tu heroe es: " + p1.heroe.NombreH + Environment.NewLine + "Su habilidad es: " + p1.heroe.PoderHeroe);
                            if (p1.heroe.PoderHeroe == "Steady Shot" && p1.Cristal >= 2)
                            {
                                if (p2.heroe.ArmaduraH <= 0)
                                {
                                    p2.heroe.PtVida = p2.heroe.PtVida - 2;
                                    Console.WriteLine("Le quedan " + p2.heroe.PtVida + " Puntos de vida al Heroe de " + p2.DarNombre());
                                    p1.Cristal = p1.Cristal - 2;
                                    HeroeAtaco = 1;
                                }
                                else if (p2.heroe.ArmaduraH > 0)
                                {
                                    p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - 2;
                                    Console.WriteLine("Le quedan " + p2.heroe.ArmaduraH + " Puntos de armadura al Heroe de " + p2.DarNombre());
                                    p1.Cristal = p1.Cristal - 2;
                                    HeroeAtaco = 1;

                                }
                            }
                            else if (p1.heroe.PoderHeroe == "Armor UP!" && p1.Cristal >= 2)
                            {
                                p1.heroe.ArmaduraH = p1.heroe.ArmaduraH + 2;
                                Console.WriteLine("Tu heroe ahora tiene " + p1.heroe.ArmaduraH + " de armadura");
                                p1.Cristal = p1.Cristal - 2;
                                HeroeAtaco = 1;
                            }
                            else
                            {
                                Console.WriteLine("tu heroe no puede atacar");
                            }
                        }
                        else if (Desicion1 == "3" && HeroeAtaco == 1)
                        {
                            Console.WriteLine(Environment.NewLine + "Tu Heroe ya ataco este turno, vuelve a intentarlo en él proximo." + Environment.NewLine);
                        }
                        else if (Desicion1 == "4")
                        {

                            p1.heroe.PtVida = -1;
                            noserindio = 1;
                            SeSigue = 1;

                        }

                        else if (Desicion1 == "5")
                        {
                            foreach (Minions carta in tablerito.tablerito)
                            {
                                carta.Disponible = 1;
                            }
                            p2.Turno += 1;

                            if (p2.Turno <= 10)
                            {
                                p2.Cristal = p2.Turno;
                            }
                            else
                            {
                                p2.Cristal = 10;
                            }
                            sacacarta = 0;
                            SeSigue = 1;
                        }
                        else
                        {

                        }
                    }
                }

                int SeSigue2 = 0;
                int HeroeAtaco2 = 0;
                while (SeSigue2 == 0 && noserindio == 0)
                {


                    // PoX Segunda

                    if (random == 1) // Esta es PoX en su primer turno, empezando benja
                    {
                        Console.WriteLine(Environment.NewLine + "Le toca a: " + p1.DarNombre());
                        Console.WriteLine("Tienes " + p1.Cristal + " Cristal(es)");
                        Console.WriteLine("1.- invocar minnion." + Environment.NewLine + "2.- Atacar" + Environment.NewLine + "3.- Habilidad Heroe" + Environment.NewLine + "4.-Rendirse" + Environment.NewLine + "5.-Terminar Turno" + Environment.NewLine);
                        Desicion2 = Convert.ToString(Console.ReadLine());
                        if (sacacarta == 0)
                        {
                            p1.SacarCarta(mazito);
                            sacacarta = 1;

                        }

                        if (Desicion2 == "1")
                        {
                            Console.WriteLine(p1.DarNombre() + " tu mano es: ");
                            p1.Describir();
                            Console.WriteLine(Environment.NewLine + "Que carta desea invocar ingrese el numero de la posicion (Partiendo de 0)" + Environment.NewLine);
                            MinionE = Convert.ToString(Console.ReadLine());
                            if (Convert.ToInt32(MinionE) <= p1.Manito.Count)
                            {
                                p1.InvocarMinion(p1.Manito[Convert.ToInt32(MinionE)], tablerito);
                            }
                            else
                            {
                                Console.WriteLine("Porfavor escojer un numero valido.");
                            }
                        }
                        else if (Desicion2 == "2" && tablerito.tablerito.Count > 0)
                        {
                            Console.WriteLine("Con que minion Atacaras, seleccione un numero del 0 al 7 " + Environment.NewLine);
                            tablerito.Describir();
                            minionataca = Convert.ToString(Console.ReadLine());
                            while (Convert.ToInt32(minionataca) > tablerito.tablerito.Count)
                            {
                                Console.WriteLine("Introduzca un numero valido");
                                minionataca = Convert.ToString(Console.ReadLine());
                            }
                            if (tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarDisponible() == 0)
                            {
                                Console.WriteLine(Environment.NewLine + "Los minions no pueden atacar el mismo turno en el que son invocados, espera minimo 1 turno mas!" + Environment.NewLine);
                            }
                            else if (tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarDisponible() == 1)
                            {
                                Console.WriteLine(Environment.NewLine + "Tu minion tiene : " + tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque() + " de ataque." + Environment.NewLine);
                                ataqueminion = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque();
                                tablerito.tablerito[Convert.ToInt32(minionataca)].Disponible = 0;
                                vidaminion = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarVida();
                                Console.WriteLine("A Quien Atacar (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito2.Describir();
                                atacar = Convert.ToString(Console.ReadLine());
                                while ((tablerito2.tablerito.Count == 0 && Convert.ToInt32(atacar) != 8) || Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                {
                                    if (Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba denuevo");
                                        atacar = Convert.ToString(Console.ReadLine());
                                        if (atacar == "8")
                                        {
                                            break;
                                        }
                                    }
                                    else if (tablerito2.tablerito.Count == 0)
                                    {
                                        Console.WriteLine("Tu oponente no tiene minions al cual atacar! prueba atacando a su Heroe");
                                        atacar = "8";
                                    }

                                }
                                if (atacar == "8" && p2.heroe.ArmaduraH <= 0)
                                {
                                    p2.heroe.PtVida = p2.heroe.PtVida - ataqueminion;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.PtVida + " puntos de vida");
                                }
                                else if (atacar == "8" && p2.heroe.ArmaduraH > 0)
                                {
                                    p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - ataqueminion;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.ArmaduraH + " puntos de armadura");
                                }
                                else if (tablerito2.tablerito.Contains(tablerito2.tablerito[Convert.ToInt32(atacar)]) == true)
                                {

                                    vidaminion2 = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion2 = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque();

                                    vidaminion = vidaminion - ataqueminion2;
                                    vidaminion2 = vidaminion2 - ataqueminion;

                                    Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion);
                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion2);

                                    if (vidaminion2 <= 0)
                                    {
                                        Console.WriteLine(Environment.NewLine + p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto. " + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero  ahora es: ");
                                        tablerito2.Describir();
                                    }
                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarNombre() + " ha muerto. " + Environment.NewLine);
                                        Console.WriteLine(p1.DarNombre() + " tu tablero ahora es:");
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(minionataca)]);
                                        tablerito.Describir();

                                    }
                                    if (vidaminion2 > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(minionataca)].Vida = vidaminion2;
                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }

                            }
                            else
                            {

                            }

                        }
                        else if (Desicion2 == "2" && tablerito.tablerito.Count == 0)
                        {
                            Console.WriteLine("Eliga una opcion valida");
                            Desicion1 = Convert.ToString(Console.ReadLine());

                        }
                        else if (Desicion2 == "3" && HeroeAtaco2 == 0)
                        {
                            Console.WriteLine("Tu heroe es: " + p1.heroe.NombreH + Environment.NewLine + "Su habilidad es: " + p1.heroe.PoderHeroe);
                            if (p1.heroe.PoderHeroe == "Steady Shot" && p1.Cristal >= 2)
                            {
                                if (p2.heroe.ArmaduraH <= 0)
                                {
                                    p2.heroe.PtVida = p2.heroe.PtVida - 2;
                                    Console.WriteLine("Le quedan " + p2.heroe.PtVida + " Puntos de vida al Heroe de " + p2.DarNombre());
                                    p1.Cristal = p1.Cristal - 2;
                                    HeroeAtaco2 = 1;
                                }
                                else if (p2.heroe.ArmaduraH > 0)
                                {
                                    p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - 2;
                                    Console.WriteLine("Le quedan " + p2.heroe.ArmaduraH + " Puntos de armaduro al Heroe de " + p2.DarNombre());
                                    p1.Cristal = p1.Cristal - 2;
                                    HeroeAtaco2 = 1;
                                }
                            }
                            else if (p1.heroe.PoderHeroe == "Armor UP!" && p1.Cristal >= 2)
                            {
                                p1.heroe.ArmaduraH = p1.heroe.ArmaduraH + 2;
                                Console.WriteLine("Tu heroe ahora tiene " + p1.heroe.ArmaduraH + " puntos de armadura.");
                                p1.Cristal = p1.Cristal - 2;
                                HeroeAtaco2 = 1;
                            }
                            else
                            {
                                Console.WriteLine("tu heroe no puede atacar");
                            }

                        }
                        else if (Desicion2 == "3" && HeroeAtaco2 == 1)
                        {
                            Console.WriteLine(Environment.NewLine + "Tu Heroe ya ataco este turno, vuelve a intentarlo en él proximo." + Environment.NewLine);
                        }
                        else if (Desicion2 == "4")
                        {

                            p1.heroe.PtVida = -1;
                            SeSigue2 = 1;
                        }

                        else if (Desicion2 == "5")
                        {
                            Console.WriteLine("Terminaste tu turno");
                            foreach (Minions carta in tablerito.tablerito)
                            {
                                carta.Disponible = 1;
                            }
                            p2.Turno += 1;

                            if (p2.Turno <= 10)
                            {
                                p2.Cristal = p2.Turno;
                            }
                            else
                            {
                                p2.Cristal = 10;
                            }
                            sacacarta = 0;
                            SeSigue2 = 1;
                        }
                        else
                        {

                        }
                    }

                    // PoX PoX Primera
                    if (random == 0) // Este es Benja en su primer turno, empezando PoX
                    {
                        Console.WriteLine(Environment.NewLine + "Le toca a: " + p2.DarNombre());
                        Console.WriteLine("Tienes " + p2.Cristal + " Cristal(es)");
                        Console.WriteLine("1.- invocar minnion." + Environment.NewLine + "2.- Atacar" + Environment.NewLine + "3.- Habilidad Heroe" + Environment.NewLine + "4.-Rendirse" + Environment.NewLine + "5.-Terminar Turno" + Environment.NewLine);
                        Desicion2 = Convert.ToString(Console.ReadLine());
                        if (sacacarta == 0)
                        {
                            p2.SacarCarta(mazito2);
                            Console.WriteLine("Te quedan " + p2.Cristal + " Cristal(es)" + Environment.NewLine);
                            sacacarta = 1;
                        }
                        if (Desicion2 == "1")
                        {
                            Console.WriteLine(p2.DarNombre() + " tu mano es: ");
                            p2.Describir();
                            Console.WriteLine(Environment.NewLine + "Que carta desea invocar ingrese el numero de la posicion (Partiendo de 0)" + Environment.NewLine);
                            MinionE = Convert.ToString(Console.ReadLine());
                            if (Convert.ToInt32(MinionE) <= p2.Manito.Count)
                            {
                                p2.InvocarMinion(p2.Manito[Convert.ToInt32(MinionE)], tablerito2);
                            }
                            else
                            {
                                Console.WriteLine("Porfavor escojer un numero valido.");
                            }
                        }
                        // empieza opcion 2
                        else if (Desicion2 == "2" && tablerito2.tablerito.Count > 0)
                        {
                            Console.WriteLine("Con que minion Atacaras, seleccione un numero del 0 al 7" + Environment.NewLine);
                            tablerito2.Describir();
                            minionataca = Convert.ToString(Console.ReadLine());
                            while (Convert.ToInt32(minionataca) > tablerito2.tablerito.Count)
                            {
                                Console.WriteLine("Introduzca un numero valido");
                                minionataca = Convert.ToString(Console.ReadLine());
                            }
                            if (tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarDisponible() == 0)
                            {
                                Console.WriteLine(Environment.NewLine + "Los minions no pueden atacar el mismo turno en el que son invocados, espera minimo 1 turno mas!" + Environment.NewLine);
                            }
                            else if (tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarDisponible() == 1)
                            {
                                Console.WriteLine(Environment.NewLine + "Tu minion tiene : " + tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque() + " de ataque." + Environment.NewLine);
                                ataqueminion2 = tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque();
                                tablerito2.tablerito[Convert.ToInt32(minionataca)].Disponible = 0;
                                vidaminion2 = tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarVida();
                                Console.WriteLine("A Quien Atacar (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito.Describir();
                                atacar = Convert.ToString(Console.ReadLine());
                                while ((tablerito.tablerito.Count == 0 && Convert.ToInt32(atacar) != 8) || Convert.ToInt32(atacar) > tablerito.tablerito.Count)
                                {
                                    if (Convert.ToInt32(atacar) > tablerito.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida,ingresa otro valor ");
                                        atacar = Convert.ToString(Console.ReadLine());
                                        if (atacar == "8")
                                        {
                                            break;
                                        }

                                    }
                                    else if (tablerito.tablerito.Count == 0)
                                    {
                                        Console.WriteLine("Tu oponente no tiene minions al cual atacar! prueba atacando a su Heroe");
                                        atacar = "8";
                                    }

                                }
                                if (atacar == "8" && p1.heroe.ArmaduraH <= 0)
                                {
                                    p1.heroe.PtVida = p1.heroe.PtVida - ataqueminion2;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p1.heroe.ArmaduraH > 0)
                                {
                                    p1.heroe.ArmaduraH = p1.heroe.ArmaduraH - ataqueminion2;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito.tablerito.Contains(tablerito.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque();

                                    vidaminion2 = vidaminion2 - ataqueminion;
                                    vidaminion = vidaminion - ataqueminion2; ataqueminion = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque();

                                    Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion);
                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion2);

                                    if (vidaminion2 <= 0)
                                    {
                                        Console.WriteLine(Environment.NewLine + p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarNombre() + " ha muerto " + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito2.Describir();
                                    }
                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(minionataca)]);
                                        Console.WriteLine(p1.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito.Describir();

                                    }
                                    if (vidaminion2 > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(minionataca)].Vida = vidaminion2;
                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }
                            }
                            else
                            {

                            }

                        }
                        else if (Desicion2 == "2" && tablerito2.tablerito.Count == 0)
                        {
                            Console.WriteLine("No tienes minnions en el campo, eligue otra opcion");
                            Desicion2 = Convert.ToString(Console.ReadLine());
                        }
                        //Termina opcion 2
                        else if (Desicion2 == "3" && HeroeAtaco2 == 0)
                        {
                            Console.WriteLine("Tu heroe es: " + p2.heroe.NombreH + Environment.NewLine + "Su habilidad es: " + p2.heroe.PoderHeroe);
                            if (p2.heroe.PoderHeroe == "Steady Shot" && p2.Cristal >= 2)
                            {
                                if (p1.heroe.ArmaduraH <= 0)
                                {
                                    p1.heroe.PtVida = p1.heroe.PtVida - 2;
                                    Console.WriteLine("Le quedan " + p1.heroe.PtVida + " Puntos de vida al Heroe de " + p1.DarNombre());
                                    p2.Cristal = p2.Cristal - 2;
                                    HeroeAtaco2 = 1;
                                }
                                else if (p1.heroe.ArmaduraH > 0)
                                {
                                    p1.heroe.ArmaduraH = p1.heroe.ArmaduraH - 2;
                                    Console.WriteLine("Le quedan " + p1.heroe.ArmaduraH + " Puntos de armadura al Heroe de " + p1.DarNombre());
                                    p2.Cristal = p2.Cristal - 2;
                                    HeroeAtaco2 = 1;
                                }
                            }
                            else if (p2.heroe.PoderHeroe == "Armor UP!" && p2.Cristal >= 2)
                            {
                                p2.heroe.ArmaduraH = p2.heroe.ArmaduraH + 2;
                                Console.WriteLine("Tu heroe ahora tiene " + p2.heroe.ArmaduraH + " de armadura");
                                p2.Cristal = p2.Cristal - 2;
                                HeroeAtaco2 = 1;
                            }
                            else
                            {
                                Console.WriteLine("tu heroe no puede atacar");
                            }

                        }
                        else if (Desicion2 == "3" && HeroeAtaco == 1)
                        {
                            Console.WriteLine(Environment.NewLine + "Tu Heroe ya ataco este turno, vuelve a intentarlo en él proximo." + Environment.NewLine);
                        }
                        else if (Desicion2 == "4")
                        {

                            p2.heroe.PtVida = -1;
                            SeSigue2 = 1;
                        }

                        else if (Desicion2 == "5")
                        {
                            Console.WriteLine("Terminaste tu turno.");

                            foreach (Minions carta in tablerito2.tablerito)
                            {
                                carta.Disponible = 1;
                            }
                            p1.Turno += 1;

                            if (p1.Turno <= 10)
                            {
                                p1.Cristal = p1.Turno;
                            }
                            else
                            {
                                p1.Cristal = 10;
                            }
                            sacacarta = 0;
                            SeSigue2 = 1;
                        }
                        else
                        {

                        }
                    }

                }
                // aca termina segundo while
            }

            if (p1.heroe.PtVida <= 0 && p2.heroe.PtVida > 0)
            {
                Console.WriteLine("ganó " + p2.DarNombre());
            }
            if (p2.heroe.PtVida <= 0 && p1.heroe.PtVida > 0)
            {
                Console.WriteLine("ganó " + p1.DarNombre());
            }






        }
    }

}
