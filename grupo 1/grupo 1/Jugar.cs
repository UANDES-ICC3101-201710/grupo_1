using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_3
{
    public class Jugar
    {
        public List<Minions> mazito;
        public List<Minions> Manito;
        public List<Minions> Tablero;
        int random;
        int rndtotem;

        public void Turno(Jugador p1, Mazo mazito, Jugador p2, Mazo mazito2, Tablero tablerito, Tablero tablerito2)
        {
            string Desicion1;
            string Desicion2;
            string MinionE;
            string minionataca;
            string atacar;
            string curar;
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
                    //-------------------------------------------------- Empieza Jugador 2 ----------------------------------------

                    if (random == 1) // Primer turno Jugador 2
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

                        //---------------------- empieza opcion 2 ( Atacar con minion )--------------------------------

                        else if (Desicion1 == "2" && tablerito2.tablerito.Count > 0)
                        {
                            Console.WriteLine("Con que minion Atacaras, seleccione un numero del 0 al 7 " + Environment.NewLine);
                            tablerito2.Describir();
                            minionataca = Convert.ToString(Console.ReadLine()); // minion ataca => Con el minion que atacaras
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
                                ataqueminion2 = tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque(); // ataque del minion atacante
                                vidaminion2 = tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarVida(); // vida del minion atacante
                                tablerito2.tablerito[Convert.ToInt32(minionataca)].Disponible = 0;
                                Console.WriteLine("A Quien Atacar (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito.Describir();
                                atacar = Convert.ToString(Console.ReadLine()); // atacar => al minion que atacara o al heroe.
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
                                    ataqueminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarAtaque(); // ataque del minion defensor
                                    vidaminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarVida();     // vida del minion defensor

                                    vidaminion2 = vidaminion2 - ataqueminion; // vida restante minion atacante
                                    vidaminion = vidaminion - ataqueminion2;  // vida restante minion defensor

                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion2);
                                    Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion);


                                    if (vidaminion2 <= 0)  // muere el minion atacante ... de jugador 2
                                    {
                                        Console.WriteLine(Environment.NewLine + p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarNombre() + " ha muerto " + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito2.Describir();
                                    }
                                    else if (vidaminion2 > 0) // si no muere el minion del jugador 2 ... vida restante
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(minionataca)].Vida = vidaminion2;
                                    }

                                    if (vidaminion <= 0)  // muere minion defensor ... de jugador 1
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(minionataca)]);
                                        Console.WriteLine(p1.DarNombre() + " Tu tablero ahora es: " + Environment.NewLine);
                                        tablerito.Describir();

                                    }
                                    else if (vidaminion > 0) // si no muere el minion del jugador 1 .. vida restante
                                    {
                                        tablerito.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }

                            }
                            else
                            {

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
                            // ------------------------------------Habilidad Picaro------------------------------------
                            else if (p2.heroe.PoderHeroe == "Maestria en dagas" && p2.Cristal >= 2)
                            {
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
                                    p1.heroe.PtVida = p1.heroe.PtVida - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p1.heroe.ArmaduraH > 0)
                                {
                                    p1.heroe.ArmaduraH = p1.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito.tablerito.Contains(tablerito.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;

                                    Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion);

                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p1.DarNombre() + " Tu tablero ahora es: " + Environment.NewLine);
                                        tablerito.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }
                                HeroeAtaco = 1;
                                p2.Cristal = p2.Cristal - 2;
                            } // ------------------------------------picaro hasta aca------------------------------------
                            else if (p2.heroe.PoderHeroe == "Refuerzo" && p2.Cristal >= 2 && tablerito2.tablerito.Count < 8)
                            //------------------------------------ Paladin desde aca------------------------------------
                            {
                                Minions Recluta = new Minions("Recluta mano de plata", 1, 1, 1, 2, "Recluta", 0);
                                tablerito2.tablerito.Add(Recluta);
                                Console.WriteLine(Environment.NewLine + "Has invocado a " + Recluta.EntregarNombre() + "  tu tablero ahora es: " + Environment.NewLine);
                                tablerito2.Describir();
                                HeroeAtaco = 1;
                                p2.Cristal = p2.Cristal - 2;
                            } // ------------------------------------ Paladin hasta aca------------------------------------

                            //----------------------------------- Druida desde aca-----------------------------------------------

                            else if (p2.heroe.PoderHeroe == "Cambio de forma" && p2.Cristal >= 2)
                            {
                                p2.heroe.ArmaduraH = 1;
                                Console.WriteLine("Tu heroe durante este turno tien 1 pt. de ataque y 1 pt de armadura" + Environment.NewLine);
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
                                    p1.heroe.PtVida = p1.heroe.PtVida - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p1.heroe.ArmaduraH > 0)
                                {
                                    p1.heroe.ArmaduraH = p1.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito.tablerito.Contains(tablerito.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;
                                    p2.heroe.PtVida = p2.heroe.PtVida - (ataqueminion - 1);



                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p1.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                        Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion + " pts de vida. ");
                                    }
                                }
                                p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - 1;
                                HeroeAtaco = 1;
                                p2.Cristal = p2.Cristal - 2;
                            } //------------------------------------------- Druida hasta aca --------------------------------------------------


                            // ------------------------------------------Mago desde aca ---------------------------------------------------
                            else if (p2.heroe.PoderHeroe == "Explosión de fuego" && p2.Cristal >= 2)
                            {
                                Console.WriteLine("A quien quieres realizarle 1 pt. de daño (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
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
                                    p1.heroe.PtVida = p1.heroe.PtVida - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p1.heroe.ArmaduraH > 0)
                                {
                                    p1.heroe.ArmaduraH = p1.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito.tablerito.Contains(tablerito.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;


                                    Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion);

                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p1.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }

                                HeroeAtaco = 1;
                                p2.Cristal = p2.Cristal - 2;
                            }
                            // ------------------------------------Mago hasta aca------------------------------------

                            // -------------------------------------- Brujo desde aca -------------------------------------------
                            else if (p2.heroe.PoderHeroe == "Transfusión de vida" && p2.Cristal >= 2)
                            {
                                p2.heroe.PtVida = p2.heroe.PtVida - 2;
                                p2.SacarCarta(mazito2);
                                HeroeAtaco = 1;
                                p2.Cristal = p2.Cristal - 2;
                            }
                            // -------------------------------------- Brujo hasta aca -------------------------------------------

                            // -------------------------------------- Chaman desde aca -------------------------------------------
                            else if (p2.heroe.PoderHeroe == "Llamada totémica" && p2.Cristal >= 2)
                            {
                                Random rnd2 = new Random();
                                rndtotem = rnd2.Next(0, 4);

                                if (rndtotem == 0)
                                {
                                    Minions SearingTotem = new Minions("Searing Totem", 0, 1, 1, 1, "Totem", 0);
                                    tablerito2.tablerito.Add(SearingTotem);
                                    Console.WriteLine(Environment.NewLine + "Has invocado a " + SearingTotem.EntregarNombre() + "  tu tablero ahora es: " + Environment.NewLine);
                                    tablerito2.Describir();

                                }
                                else if (rndtotem == 1)
                                {
                                    p2.heroe.PtVida = p2.heroe.PtVida + 2;
                                    Console.WriteLine(Environment.NewLine + "Has invocado a un Stoneclaw Totem y has gando 2 de salud, tu salud ahora es: " + p2.heroe.PtVida);
                                }
                                else if (rndtotem == 2)
                                {
                                    Minions Wrathoftheairtotem = new Minions("Wrath of the air totem", 0, 2, 2, 0, "totem", 0);
                                    Console.WriteLine(Environment.NewLine + " Has invocado a un Wrath of the air totem, tu tablero ahora es :" + Environment.NewLine);
                                    tablerito2.tablerito.Add(Wrathoftheairtotem);
                                    tablerito2.Describir();
                                }
                                else if (rndtotem == 3)
                                {
                                    Minions HealingTotem = new Minions("Healing totem", 0, 2, 2, 0, "totem", 0);
                                    Console.WriteLine(Environment.NewLine + " Has invocado a un Healing totem, tu tablero ahora es: " + Environment.NewLine);
                                    tablerito2.tablerito.Add(HealingTotem);
                                    tablerito2.Describir();
                                }
                                HeroeAtaco = 1;
                                p2.Cristal = p2.Cristal - 2;

                            }
                            // -------------------------------------- Chaman Hasta aca -------------------------------------------

                            // -------------------------------------- Sacerdote desde aca ---------------------------------------
                            else if (p2.heroe.PoderHeroe == "Sanación inferior" && p2.Cristal >= 2)
                            {
                                Console.WriteLine("Has utilizado la habilidad 'Sanación inferior', eligue a quien quieres otorgarle 2 pts. de vida: ");
                                curar = Convert.ToString(Console.ReadLine());
                                tablerito.Describir();
                                while ((tablerito.tablerito.Count == 0 && Convert.ToInt32(curar) != 8) || Convert.ToInt32(curar) > tablerito.tablerito.Count)
                                {
                                    if (Convert.ToInt32(curar) > tablerito.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba de nuevo");
                                        curar = Convert.ToString(Console.ReadLine());
                                        if (Convert.ToInt32(curar) == 8)
                                        {
                                            break;
                                        }
                                    }
                                    else if (tablerito.tablerito.Count == 0)
                                    {
                                        Console.WriteLine("No tienes minions para curar");
                                        curar = "8";
                                    }

                                }
                                if (curar == "8" && p2.heroe.PtVida < 29)
                                {
                                    p2.heroe.PtVida = p2.heroe.PtVida + 2;
                                }
                                else if (tablerito2.tablerito.Contains(tablerito2.tablerito[Convert.ToInt32(curar)]) == true)
                                {
                                    int minioncurar; // numero del minion que se curara
                                    int minioncurarmax; // vida maxima del minion que se curara
                                    minioncurar = tablerito2.tablerito[Convert.ToInt32(curar)].EntregarVida();
                                    minioncurarmax = tablerito2.tablerito[Convert.ToInt32(curar)].EntregarVidamax();
                                    if (minioncurar < (minioncurarmax - 1) && minioncurar > 0)
                                    {
                                        minioncurar = minioncurar + 2;
                                        tablerito2.tablerito[Convert.ToInt32(curar)].Vida = minioncurar;
                                    }
                                }
                                else
                                {

                                }
                                p2.Cristal = p2.Cristal - 2;
                                HeroeAtaco = 1;
                            }
                            // ----------------------------- Sacerdote hasta aca -----------------------------------
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
                            // ------------------------------------- Efecto Healing totem -----------------------------------------------
                            foreach (Minions carta in tablerito2.tablerito)
                            {
                                if (carta.Name == "Healing totem")
                                {
                                    foreach (Minions carta1 in tablerito2.tablerito)
                                    {
                                        if (carta1.Vida < carta1.Vidamax)
                                        {
                                            carta1.Vida = carta1.Vida + 1;
                                        }

                                    }
                                    Console.WriteLine(Environment.NewLine + "Tus minions han ganado 1 de vida gracias a tu Healing totem, tu tablero ahora es: " + Environment.NewLine);
                                    tablerito2.Describir();
                                }

                            }
                            // ------------------------------------- Efecto Healing totem FIN -----------------------------------------------
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

                    // ------------------------------------------------ Empieza el Jugador 1 -------------------------------------

                    if (random == 0) // Primer turno del jugador 1
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
                                ataqueminion = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque(); // ataque del minion atacante
                                vidaminion = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarVida();     // vida minion atacante
                                tablerito.tablerito[Convert.ToInt32(minionataca)].Disponible = 0;
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

                                    vidaminion2 = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarVida(); // Vida minion defensor
                                    ataqueminion2 = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarAtaque(); // Ataque minion defensor

                                    vidaminion = vidaminion - ataqueminion2; // vida restante minion atacante
                                    vidaminion2 = vidaminion2 - ataqueminion; // vida restante minion defensor

                                    Console.WriteLine(Environment.NewLine + "Al minion de " + p1.DarNombre() + " le queda " + vidaminion);
                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion2);

                                    if (vidaminion2 <= 0)
                                    {
                                        Console.WriteLine(Environment.NewLine + p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto. " + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero ahora es: ");
                                        tablerito2.Describir();
                                    }
                                    else if (vidaminion2 > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(minionataca)].Vida = vidaminion2;
                                    }
                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarNombre() + " ha muerto. " + Environment.NewLine);
                                        Console.WriteLine(p1.DarNombre() + " tu tablero ahora es:");
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(minionataca)]);
                                        tablerito.Describir();

                                    }
                                    else if (vidaminion > 0)
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

                            // ------------------------------------- Picaro desde aca -----------------------------------

                            else if (p1.heroe.PoderHeroe == "Maestria en dagas" && p1.Cristal >= 2)
                            {
                                Console.WriteLine("A Quien Atacar (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito2.Describir();
                                atacar = Convert.ToString(Console.ReadLine());
                                while ((tablerito2.tablerito.Count == 0 && Convert.ToInt32(atacar) != 8) || Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                {
                                    if (Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba de nuevo");
                                        atacar = Convert.ToString(Console.ReadLine());
                                        if (Convert.ToInt32(atacar) == 8)
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
                                    p2.heroe.PtVida = p2.heroe.PtVida - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p2.heroe.ArmaduraH > 0)
                                {
                                    p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito2.tablerito.Contains(tablerito2.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;

                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion);

                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " Tu tablero ahora es: " + Environment.NewLine);
                                        tablerito2.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }
                                HeroeAtaco = 1;
                                p1.Cristal = p1.Cristal - 2;
                            }
                            // --------------------------------------- Picaro hasta aca ----------------------------

                            //------------------------------------------Paladin desde aca ---------------------------------
                            else if (p1.heroe.PoderHeroe == "Refuerzo" && p1.Cristal >= 2 && tablerito.tablerito.Count < 8)
                            {
                                Minions Recluta = new Minions("Recluta mano de plata", 1, 1, 1, 2, "Recluta", 0);
                                tablerito.tablerito.Add(Recluta);
                                Console.WriteLine(Environment.NewLine + "Has invocado a " + Recluta.EntregarNombre() + "  tu tablero ahora es: " + Environment.NewLine);
                                tablerito.Describir();
                                HeroeAtaco = 1;
                                p1.Cristal = p1.Cristal - 2;
                            }//---------------------------------------------- Paladin hasta aca------------------------------------------

                            // --------------------------------------------------Druida desde aca -----------------------------------------
                            else if (p1.heroe.PoderHeroe == "Cambio de forma" && p1.Cristal >= 2)
                            {
                                p1.heroe.ArmaduraH = 1;
                                Console.WriteLine("Tu heroe durante este turno tien 1 pt de ataque y 1 pt de armadura" + Environment.NewLine);
                                Console.WriteLine("A Quien Atacar (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito2.Describir();
                                atacar = Convert.ToString(Console.ReadLine());
                                while ((tablerito2.tablerito.Count == 0 && Convert.ToInt32(atacar) != 8) || Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                {
                                    if (Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba de nuevo");
                                        atacar = Convert.ToString(Console.ReadLine());
                                        if (Convert.ToInt32(atacar) == 8)
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
                                    p2.heroe.PtVida = p2.heroe.PtVida - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p2.heroe.ArmaduraH > 0)
                                {
                                    p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito2.tablerito.Contains(tablerito2.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;
                                    p1.heroe.PtVida = p1.heroe.PtVida - (ataqueminion - 1);

                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito2.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                        Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion + " pts de vida. ");
                                    }
                                }
                                p1.heroe.ArmaduraH = p1.heroe.ArmaduraH - 1;
                                HeroeAtaco = 1;
                                p1.Cristal = p1.Cristal - 2;
                            }
                            // ---------------------------------------- Druida hasta aca ----------------------------------------

                            // ---------------------------------------- Mago desde aca ----------------------------------------
                            else if (p1.heroe.PoderHeroe == "Explosión de fuego" && p1.Cristal >= 2)
                            {
                                Console.WriteLine("A quien quieres realizarle 1 pt. de daño (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito2.Describir();
                                atacar = Convert.ToString(Console.ReadLine());
                                while ((tablerito2.tablerito.Count == 0 && Convert.ToInt32(atacar) != 8) || Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                {
                                    if (Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba de nuevo");
                                        atacar = Convert.ToString(Console.ReadLine());
                                        if (Convert.ToInt32(atacar) == 8)
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
                                    p2.heroe.PtVida = p2.heroe.PtVida - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p2.heroe.ArmaduraH > 0)
                                {
                                    p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito2.tablerito.Contains(tablerito2.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;


                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion + " puntos de vida.");

                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito2.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }

                                HeroeAtaco = 1;
                                p1.Cristal = p1.Cristal - 2;
                            }
                            // ---------------------------------------- Mago hasta aca ----------------------------------------

                            // ---------------------------------------- Brujo desde aca ----------------------------------------
                            else if (p1.heroe.PoderHeroe == "Transfusión de vida" && p1.Cristal >= 2)
                            {
                                p1.heroe.PtVida = p1.heroe.PtVida - 1;
                                p1.SacarCarta(mazito);
                                HeroeAtaco = 1;
                            }
                            // ---------------------------------------- Brujo hasta aca ----------------------------------------

                            // -------------------------------------- Chaman desde aca -------------------------------------------
                            else if (p1.heroe.PoderHeroe == "Llamada totémica" && p1.Cristal >= 2)
                            {
                                Random rnd2 = new Random();
                                rndtotem = rnd2.Next(0, 4);

                                if (rndtotem == 0)
                                {
                                    Minions SearingTotem = new Minions("Searing Totem", 0, 1, 1, 1, "Totem", 0);
                                    tablerito.tablerito.Add(SearingTotem);
                                    Console.WriteLine(Environment.NewLine + p1.DarNombre() + " has invocado a " + SearingTotem.EntregarNombre() + "  tu tablero ahora es: " + Environment.NewLine);
                                    tablerito.Describir();

                                }
                                else if (rndtotem == 1)
                                {
                                    p1.heroe.PtVida = p1.heroe.PtVida + 2;
                                    Console.WriteLine(Environment.NewLine + "Has invocado a un Stoneclaw Totem y has gando 2 de salud, tu salud ahora es: " + p1.heroe.PtVida);
                                }
                                else if (rndtotem == 2)
                                {
                                    Minions Wrathoftheairtotem = new Minions("Wrath of the air totem", 0, 2, 2, 0, "totem", 0);
                                    Console.WriteLine(Environment.NewLine + " Has invocado a un Wrath of the air totem, tu tablero ahora es :" + Environment.NewLine);
                                    tablerito.tablerito.Add(Wrathoftheairtotem);
                                    tablerito.Describir();
                                }
                                else if (rndtotem == 3)
                                {
                                    Minions HealingTotem = new Minions("Healing totem", 0, 2, 2, 0, "totem", 0);
                                    Console.WriteLine(Environment.NewLine + " Has invocado a un Healing totem, tu tablero ahora es: " + Environment.NewLine);
                                    tablerito.tablerito.Add(HealingTotem);
                                    tablerito.Describir();
                                }
                                HeroeAtaco = 1;
                                p1.Cristal = p1.Cristal - 2;

                            }
                            // -------------------------------------- Chaman Hasta aca -------------------------------------------
                            // -------------------------------------- Sacerdote desde aca ---------------------------------------
                            else if (p1.heroe.PoderHeroe == "Sanación inferior" && p1.Cristal >= 2)
                            {
                                Console.WriteLine("Has utilizado la habilidad 'Sanación inferior', eligue a quien quieres otorgarle 2 pts. de vida: ");
                                curar = Convert.ToString(Console.ReadLine());
                                tablerito.Describir();
                                while ((tablerito.tablerito.Count == 0 && Convert.ToInt32(curar) != 8) || Convert.ToInt32(curar) > tablerito.tablerito.Count)
                                {
                                    if (Convert.ToInt32(curar) > tablerito.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba de nuevo");
                                        curar = Convert.ToString(Console.ReadLine());
                                        if (Convert.ToInt32(curar) == 8)
                                        {
                                            break;
                                        }
                                    }
                                    else if (tablerito.tablerito.Count == 0)
                                    {
                                        Console.WriteLine("No tienes minions para curar");
                                        curar = "8";
                                    }

                                }
                                if (curar == "8" && p1.heroe.PtVida < 29)
                                {
                                    p1.heroe.PtVida = p1.heroe.PtVida + 2;
                                }
                                else if (tablerito.tablerito.Contains(tablerito.tablerito[Convert.ToInt32(curar)]) == true)
                                {
                                    int minioncurar; // numero del minion que se curara
                                    int minioncurarmax; // vida maxima del minion que se curara
                                    minioncurar = tablerito.tablerito[Convert.ToInt32(curar)].EntregarVida();
                                    minioncurarmax = tablerito.tablerito[Convert.ToInt32(curar)].EntregarVidamax();
                                    if (minioncurar < (minioncurarmax - 1) && minioncurar > 0)
                                    {
                                        minioncurar = minioncurar + 2;
                                        tablerito.tablerito[Convert.ToInt32(curar)].Vida = minioncurar;
                                    }
                                }
                                else
                                {

                                }
                                p1.Cristal = p1.Cristal - 2;
                                HeroeAtaco = 1;
                            }
                            // ------------------------------------ Sacerdote hasta aca ---------------------------
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
                            // ------------------------------------- Efecto Healing totem -----------------------------------------------
                            foreach (Minions carta in tablerito.tablerito)
                            {
                                if (carta.Name == "Healing totem")
                                {
                                    foreach (Minions carta1 in tablerito.tablerito)
                                    {
                                        if (carta1.Vida < carta1.Vidamax)
                                        {
                                            carta1.Vida = carta1.Vida + 1;
                                        }

                                    }
                                    Console.WriteLine(Environment.NewLine + "Tus minions han ganado 1 de vida gracias a tu Healing totem, tu tablero ahora es: " + Environment.NewLine);
                                    tablerito.Describir();
                                }

                            }
                            // ------------------------------------- Efecto Healing totem FIN -----------------------------------------------
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
                // Segundo turno
                int SeSigue2 = 0;
                int HeroeAtaco2 = 0;
                while (SeSigue2 == 0 && noserindio == 0)
                {


                    // ----------------------------------------------- Empieza el Jugador 2 ------------------------------------------------------

                    if (random == 1) // Primer turno del jugador 1
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
                                ataqueminion = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque(); // ataque del minion atacante
                                vidaminion = tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarVida();     // vida minion atacante
                                tablerito.tablerito[Convert.ToInt32(minionataca)].Disponible = 0;
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

                                    vidaminion2 = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarVida(); // Vida minion defensor
                                    ataqueminion2 = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarAtaque(); // Ataque minion defensor

                                    vidaminion = vidaminion - ataqueminion2; // vida restante minion atacante
                                    vidaminion2 = vidaminion2 - ataqueminion; // vida restante minion defensor

                                    Console.WriteLine(Environment.NewLine + "Al minion de " + p1.DarNombre() + " le queda " + vidaminion);
                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion2);

                                    if (vidaminion2 <= 0)
                                    {
                                        Console.WriteLine(Environment.NewLine + p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto. " + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero ahora es: ");
                                        tablerito2.Describir();
                                    }
                                    else if (vidaminion2 > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(minionataca)].Vida = vidaminion2;
                                    }
                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(minionataca)].EntregarNombre() + " ha muerto. " + Environment.NewLine);
                                        Console.WriteLine(p1.DarNombre() + " tu tablero ahora es:");
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(minionataca)]);
                                        tablerito.Describir();

                                    }
                                    else if (vidaminion > 0)
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
                            // ---------------------------------------- Picaro desde aca ----------------------------------------
                            else if (p1.heroe.PoderHeroe == "Maestria en dagas" && p1.Cristal >= 2)
                            {
                                Console.WriteLine("A Quien Atacar (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito2.Describir();
                                atacar = Convert.ToString(Console.ReadLine());
                                while ((tablerito2.tablerito.Count == 0 && Convert.ToInt32(atacar) != 8) || Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                {
                                    if (Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba de nuevo");
                                        atacar = Convert.ToString(Console.ReadLine());
                                        if (Convert.ToInt32(atacar) == 8)
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
                                    p2.heroe.PtVida = p2.heroe.PtVida - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p2.heroe.ArmaduraH > 0)
                                {
                                    p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito2.tablerito.Contains(tablerito2.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;

                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion);

                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " Tu tablero ahora es: " + Environment.NewLine);
                                        tablerito2.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }
                                HeroeAtaco2 = 1;
                                p1.Cristal = p1.Cristal - 2;
                            }
                            // ---------------------------------------- Picaro hasta aca----------------------------------------
                            // ---------------------------------------- Paladin desde aca ----------------------------------------
                            else if (p1.heroe.PoderHeroe == "Refuerzo" && p1.Cristal >= 2 && tablerito.tablerito.Count < 8)
                            {
                                Minions Recluta = new Minions("Recluta mano de plata", 1, 1, 1, 2, "Recluta", 0);
                                tablerito.tablerito.Add(Recluta);
                                Console.WriteLine(Environment.NewLine + "Has invocado a " + Recluta.EntregarNombre() + "  tu tablero ahora es: " + Environment.NewLine);
                                tablerito.Describir();
                                HeroeAtaco2 = 1;
                                p1.Cristal = p1.Cristal - 2;
                            } //---------------------------------------- Paladin hasta aca ----------------------------------------

                            //---------------------------------------- Druida desde aca ----------------------------------------
                            else if (p1.heroe.PoderHeroe == "Cambio de forma" && p1.Cristal >= 2)
                            {
                                p1.heroe.ArmaduraH = 1;
                                Console.WriteLine("Tu heroe durante este turno tien 1 pt de ataque y 1 pt de armadura" + Environment.NewLine);
                                Console.WriteLine("A Quien Atacar (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito2.Describir();
                                atacar = Convert.ToString(Console.ReadLine());
                                while ((tablerito2.tablerito.Count == 0 && Convert.ToInt32(atacar) != 8) || Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                {
                                    if (Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba de nuevo");
                                        atacar = Convert.ToString(Console.ReadLine());
                                        if (Convert.ToInt32(atacar) == 8)
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
                                    p2.heroe.PtVida = p2.heroe.PtVida - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p2.heroe.ArmaduraH > 0)
                                {
                                    p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito2.tablerito.Contains(tablerito2.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;
                                    p1.heroe.PtVida = p1.heroe.PtVida - (ataqueminion - 1);

                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito2.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                        Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion + " pts de vida. ");
                                    }
                                }
                                p1.heroe.ArmaduraH = p1.heroe.ArmaduraH - 1;
                                HeroeAtaco2 = 1;
                                p1.Cristal = p1.Cristal - 2;
                            }
                            //----------------------------------------  Druida hasta aca ----------------------------------------

                            //----------------------------------------  Mago desde aca ----------------------------------------
                            else if (p1.heroe.PoderHeroe == "Explosión de fuego" && p1.Cristal >= 2)
                            {
                                Console.WriteLine("A quien quieres realizarle 1 pt. de daño (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito2.Describir();
                                atacar = Convert.ToString(Console.ReadLine());
                                while ((tablerito2.tablerito.Count == 0 && Convert.ToInt32(atacar) != 8) || Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                {
                                    if (Convert.ToInt32(atacar) > tablerito2.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba de nuevo");
                                        atacar = Convert.ToString(Console.ReadLine());
                                        if (Convert.ToInt32(atacar) == 8)
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
                                    p2.heroe.PtVida = p2.heroe.PtVida - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p2.heroe.ArmaduraH > 0)
                                {
                                    p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p2.DarNombre() + " a tu heroe le quedan " + p2.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito2.tablerito.Contains(tablerito2.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;


                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion + " puntos de vida.");

                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito2.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }

                                HeroeAtaco2 = 1;
                                p1.Cristal = p1.Cristal - 2;
                            }
                            // ---------------------------------------- Mago hasta aca ----------------------------------------

                            // ---------------------------------------- Brujo desde aca ----------------------------------------
                            else if (p1.heroe.PoderHeroe == "Transfusión de vida" && p1.Cristal >= 2)
                            {
                                p1.heroe.PtVida = p1.heroe.PtVida - 1;
                                p1.SacarCarta(mazito);
                                HeroeAtaco2 = 1;
                                p1.Cristal = p1.Cristal - 2;
                            }
                            // ---------------------------------------- Brujo hasta aca ----------------------------------------

                            // -------------------------------------- Chaman desde aca -------------------------------------------
                            else if (p1.heroe.PoderHeroe == "Llamada totémica" && p1.Cristal >= 2)
                            {
                                Random rnd2 = new Random();
                                rndtotem = rnd2.Next(0, 4);

                                if (rndtotem == 0)
                                {
                                    Minions SearingTotem = new Minions("Searing Totem", 0, 1, 1, 1, "Totem", 0);
                                    tablerito.tablerito.Add(SearingTotem);
                                    Console.WriteLine(Environment.NewLine + p1.DarNombre() + " has invocado a " + SearingTotem.EntregarNombre() + "  tu tablero ahora es: " + Environment.NewLine);
                                    tablerito.Describir();

                                }
                                else if (rndtotem == 1)
                                {
                                    p1.heroe.PtVida = p1.heroe.PtVida + 2;
                                    Console.WriteLine(Environment.NewLine + "Has invocado a un Stoneclaw Totem y has gando 2 de salud, tu salud ahora es: " + p1.heroe.PtVida);
                                }
                                else if (rndtotem == 2)
                                {
                                    Minions Wrathoftheairtotem = new Minions("Wrath of the air totem", 0, 2, 2, 0, "totem", 0);
                                    Console.WriteLine(Environment.NewLine + " Has invocado a un Wrath of the air totem, tu tablero ahora es :" + Environment.NewLine);
                                    tablerito.tablerito.Add(Wrathoftheairtotem);
                                    tablerito.Describir();
                                }
                                else if (rndtotem == 3)
                                {
                                    Minions HealingTotem = new Minions("Healing totem", 0, 2, 2, 0, "totem", 0);
                                    Console.WriteLine(Environment.NewLine + " Has invocado a un Healing totem, tu tablero ahora es: " + Environment.NewLine);
                                    tablerito.tablerito.Add(HealingTotem);
                                    tablerito.Describir();
                                }
                                HeroeAtaco2 = 1;
                                p1.Cristal = p1.Cristal - 2;

                            }
                            // ---------------------------------------- Chaman hasta aca ----------------------------------------
                            // -------------------------------------- Sacerdote desde aca ---------------------------------------
                            else if (p1.heroe.PoderHeroe == "Sanación inferior" && p1.Cristal >= 2)
                            {
                                Console.WriteLine("Has utilizado la habilidad 'Sanación inferior', eligue a quien quieres otorgarle 2 pts. de vida: ");
                                curar = Convert.ToString(Console.ReadLine());
                                tablerito.Describir();
                                while ((tablerito.tablerito.Count == 0 && Convert.ToInt32(curar) != 8) || Convert.ToInt32(curar) > tablerito.tablerito.Count)
                                {
                                    if (Convert.ToInt32(curar) > tablerito.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba de nuevo");
                                        curar = Convert.ToString(Console.ReadLine());
                                        if (Convert.ToInt32(curar) == 8)
                                        {
                                            break;
                                        }
                                    }
                                    else if (tablerito.tablerito.Count == 0)
                                    {
                                        Console.WriteLine("No tienes minions para curar");
                                        curar = "8";
                                    }

                                }
                                if (curar == "8" && p1.heroe.PtVida < 29)
                                {
                                    p1.heroe.PtVida = p1.heroe.PtVida + 2;
                                }
                                else if (tablerito.tablerito.Contains(tablerito.tablerito[Convert.ToInt32(curar)]) == true)
                                {
                                    int minioncurar; // numero del minion que se curara
                                    int minioncurarmax; // vida maxima del minion que se curara
                                    minioncurar = tablerito.tablerito[Convert.ToInt32(curar)].EntregarVida();
                                    minioncurarmax = tablerito.tablerito[Convert.ToInt32(curar)].EntregarVidamax();
                                    if (minioncurar < (minioncurarmax - 1) && minioncurar > 0)
                                    {
                                        minioncurar = minioncurar + 2;
                                        tablerito.tablerito[Convert.ToInt32(curar)].Vida = minioncurar;
                                    }
                                }
                                else
                                {

                                }
                                p1.Cristal = p1.Cristal - 2;
                                HeroeAtaco2 = 1;
                            }
                            // ------------------------------------ Sacerdote hasta aca ---------------------------
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
                            // ------------------------------------- Efecto Healing totem -----------------------------------------------
                            foreach (Minions carta in tablerito.tablerito)
                            {
                                if (carta.Name == "Healing totem")
                                {
                                    foreach (Minions carta1 in tablerito.tablerito)
                                    {
                                        if (carta1.Vida < carta1.Vidamax)
                                        {
                                            carta1.Vida = carta1.Vida + 1;
                                        }

                                    }
                                    Console.WriteLine(Environment.NewLine + "Tus minions han ganado 1 de vida gracias a tu Healing totem, tu tablero ahora es: " + Environment.NewLine);
                                    tablerito.Describir();
                                }

                            }
                            // ------------------------------------- Efecto Healing totem FIN -----------------------------------------------
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


                    // ------------------------------------------- Empieza el jugador 1 ------------------------------------------

                    if (random == 0) // Primer turno del jugador 2
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
                            Console.WriteLine("Con que minion Atacaras, seleccione un numero del 0 al 7 " + Environment.NewLine);
                            tablerito2.Describir();
                            minionataca = Convert.ToString(Console.ReadLine()); // minion ataca => Con el minion que atacaras
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
                                ataqueminion2 = tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarAtaque(); // ataque del minion atacante
                                vidaminion2 = tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarVida(); // vida del minion atacante
                                tablerito2.tablerito[Convert.ToInt32(minionataca)].Disponible = 0;
                                Console.WriteLine("A Quien Atacar (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
                                tablerito.Describir();
                                atacar = Convert.ToString(Console.ReadLine()); // atacar => al minion que atacara o al heroe.
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
                                    ataqueminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarAtaque(); // ataque del minion defensor
                                    vidaminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarVida();     // vida del minion defensor

                                    vidaminion2 = vidaminion2 - ataqueminion; // vida restante minion atacante
                                    vidaminion = vidaminion - ataqueminion2;  // vida restante minion defensor

                                    Console.WriteLine("Al minion de " + p2.DarNombre() + " le queda " + vidaminion2);
                                    Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion);


                                    if (vidaminion2 <= 0)  // muere el minion atacante ... de jugador 2
                                    {
                                        Console.WriteLine(Environment.NewLine + p2.DarNombre() + " tu minnion " + tablerito2.tablerito[Convert.ToInt32(minionataca)].EntregarNombre() + " ha muerto " + Environment.NewLine);
                                        tablerito2.tablerito.Remove(tablerito2.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p2.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito2.Describir();
                                    }
                                    else if (vidaminion2 > 0) // si no muere el minion del jugador 2 ... vida restante
                                    {
                                        tablerito2.tablerito[Convert.ToInt32(minionataca)].Vida = vidaminion2;
                                    }

                                    if (vidaminion <= 0)  // muere minion defensor ... de jugador 1
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(minionataca)]);
                                        Console.WriteLine(p1.DarNombre() + " Tu tablero ahora es: " + Environment.NewLine);
                                        tablerito.Describir();

                                    }
                                    else if (vidaminion > 0) // si no muere el minion del jugador 1 .. vida restante
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
                            // ---------------------------------------- Picaro desde aca ----------------------------------------
                            else if (p2.heroe.PoderHeroe == "Maestria en dagas" && p2.Cristal >= 2)
                            {
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
                                    p1.heroe.PtVida = p1.heroe.PtVida - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p1.heroe.ArmaduraH > 0)
                                {
                                    p1.heroe.ArmaduraH = p1.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito.tablerito.Contains(tablerito.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;

                                    Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion);

                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p1.DarNombre() + " Tu tablero ahora es: " + Environment.NewLine);
                                        tablerito.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }
                                HeroeAtaco2 = 1;
                                p2.Cristal = p2.Cristal - 2;
                            }
                            // ---------------------------------------- Picaro hasta aca ----------------------------------------

                            // ----------------------------------------Paladin desde aca ----------------------------------------
                            else if (p2.heroe.PoderHeroe == "Refuerzo" && p2.Cristal >= 2 && tablerito2.tablerito.Count < 8)
                            {
                                Minions Recluta = new Minions("Recluta mano de plata", 1, 1, 1, 2, "Recluta", 0);
                                tablerito2.tablerito.Add(Recluta);
                                Console.WriteLine(Environment.NewLine + "Has invocado a " + Recluta.EntregarNombre() + "  tu tablero ahora es: " + Environment.NewLine);
                                tablerito2.Describir();
                                HeroeAtaco2 = 1;
                                p2.Cristal = p2.Cristal - 2;
                            }
                            // ---------------------------------------- Paladin hasta aca ----------------------------------------

                            //---------------------------------------- Druida desde aca ----------------------------------------
                            else if (p2.heroe.PoderHeroe == "Cambio de forma" && p2.Cristal >= 2)
                            {
                                p2.heroe.ArmaduraH = 1;
                                Console.WriteLine("Tu heroe durante este turno tien 1 pt de ataque y 1 pt de armadura" + Environment.NewLine);
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
                                    p1.heroe.PtVida = p1.heroe.PtVida - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p1.heroe.ArmaduraH > 0)
                                {
                                    p1.heroe.ArmaduraH = p1.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito.tablerito.Contains(tablerito.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;
                                    p2.heroe.PtVida = p2.heroe.PtVida - (ataqueminion - 1);

                                    Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion);

                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p1.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                    }
                                }
                                p2.heroe.ArmaduraH = p2.heroe.ArmaduraH - 1;
                                HeroeAtaco2 = 1;
                                p2.Cristal = p2.Cristal - 2;
                            }
                            // ---------------------------------------- Druida hasta aca ----------------------------------------

                            // ---------------------------------------- Mago desde aca
                            else if (p2.heroe.PoderHeroe == "Explosión de fuego" && p2.Cristal >= 2)
                            {
                                Console.WriteLine("A quien quieres realizarle 1 pt. de daño (Eleguir numero del 0 al 7) o al Heroe (8)" + Environment.NewLine);
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
                                    p1.heroe.PtVida = p1.heroe.PtVida - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.PtVida + "puntos de vida");
                                }
                                else if (atacar == "8" && p1.heroe.ArmaduraH > 0)
                                {
                                    p1.heroe.ArmaduraH = p1.heroe.ArmaduraH - 1;
                                    Console.WriteLine(p1.DarNombre() + " a tu heroe le quedan " + p1.heroe.ArmaduraH + "puntos de armadura");
                                }
                                else if (tablerito.tablerito.Contains(tablerito.tablerito[Convert.ToInt32(atacar)]) == true)
                                {
                                    vidaminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarVida();
                                    ataqueminion = tablerito.tablerito[Convert.ToInt32(atacar)].EntregarAtaque();

                                    vidaminion = vidaminion - 1;



                                    if (vidaminion <= 0)
                                    {
                                        Console.WriteLine(p1.DarNombre() + " tu minnion " + tablerito.tablerito[Convert.ToInt32(atacar)].EntregarNombre() + " ha muerto." + Environment.NewLine);
                                        tablerito.tablerito.Remove(tablerito.tablerito[Convert.ToInt32(atacar)]);
                                        Console.WriteLine(p1.DarNombre() + " tu tablero ahora es: " + Environment.NewLine);
                                        tablerito.Describir();

                                    }
                                    if (vidaminion > 0)
                                    {
                                        tablerito.tablerito[Convert.ToInt32(atacar)].Vida = vidaminion;
                                        Console.WriteLine("Al minion de " + p1.DarNombre() + " le queda " + vidaminion + " pts de vida. ");
                                    }
                                }

                                HeroeAtaco2 = 1;
                                p2.Cristal = p2.Cristal - 2;
                            }
                            // --------------------------------------------------------------- Mago hasta aca ---------------------------------------

                            // ---------------------------------------- Brujo desde aca ----------------------------------------
                            else if (p2.heroe.PoderHeroe == "Transfusión de vida" && p2.Cristal >= 2)
                            {
                                p2.heroe.PtVida = p2.heroe.PtVida - 2;
                                p2.SacarCarta(mazito2);
                                HeroeAtaco2 = 1;
                                p2.Cristal = p2.Cristal - 2;
                            }
                            // ---------------------------------------- Brujo hasta aca ----------------------------------------


                            // -------------------------------------- Chaman desde aca -------------------------------------------
                            else if (p2.heroe.PoderHeroe == "Llamada totémica" && p2.Cristal >= 2)
                            {
                                Random rnd2 = new Random();
                                rndtotem = rnd2.Next(0, 4);

                                if (rndtotem == 0)
                                {
                                    Minions SearingTotem = new Minions("Searing Totem", 0, 1, 1, 1, "Totem", 0);
                                    tablerito2.tablerito.Add(SearingTotem);
                                    Console.WriteLine(Environment.NewLine + "Has invocado a " + SearingTotem.EntregarNombre() + "  tu tablero ahora es: " + Environment.NewLine);
                                    tablerito2.Describir();

                                }
                                else if (rndtotem == 1)
                                {
                                    p2.heroe.PtVida = p2.heroe.PtVida + 2;
                                    Console.WriteLine(Environment.NewLine + "Has invocado a un Stoneclaw Totem y has gando 2 de salud, tu salud ahora es: " + p2.heroe.PtVida);
                                }
                                else if (rndtotem == 2)
                                {
                                    Minions Wrathoftheairtotem = new Minions("Wrath of the air totem", 0, 2, 2, 0, "totem", 0);
                                    Console.WriteLine(Environment.NewLine + " Has invocado a un Wrath of the air totem, tu tablero ahora es :" + Environment.NewLine);
                                    tablerito2.tablerito.Add(Wrathoftheairtotem);
                                    tablerito2.Describir();
                                }
                                else if (rndtotem == 3)
                                {
                                    Minions HealingTotem = new Minions("Healing totem", 0, 2, 2, 0, "totem", 0);
                                    Console.WriteLine(Environment.NewLine + " Has invocado a un Healing totem, tu tablero ahora es: " + Environment.NewLine);
                                    tablerito2.tablerito.Add(HealingTotem);
                                    tablerito2.Describir();
                                }
                                HeroeAtaco2 = 1;
                                p2.Cristal = p2.Cristal - 2;

                            }
                            // -------------------------------------- Chaman Hasta aca -------------------------------------------

                            // -------------------------------------- Sacerdote desde aca ---------------------------------------
                            else if (p2.heroe.PoderHeroe == "Sanación inferior" && p2.Cristal >= 2)
                            {
                                Console.WriteLine("Has utilizado la habilidad 'Sanación inferior', eligue a quien quieres otorgarle 2 pts. de vida: ");
                                curar = Convert.ToString(Console.ReadLine());
                                tablerito2.Describir();
                                while ((tablerito2.tablerito.Count == 0 && Convert.ToInt32(curar) != 8) || Convert.ToInt32(curar) > tablerito2.tablerito.Count)
                                {
                                    if (Convert.ToInt32(curar) > tablerito2.tablerito.Count)
                                    {
                                        Console.WriteLine("tu opcion no es valida, prueba de nuevo");
                                        curar = Convert.ToString(Console.ReadLine());
                                        if (Convert.ToInt32(curar) == 8)
                                        {
                                            break;
                                        }
                                    }
                                    else if (tablerito2.tablerito.Count == 0)
                                    {
                                        Console.WriteLine("No tienes minions para curar");
                                        curar = "8";
                                    }

                                }
                                if (curar == "8" && p2.heroe.PtVida < 29)
                                {
                                    p2.heroe.PtVida = p2.heroe.PtVida + 2;
                                }
                                else if (tablerito2.tablerito.Contains(tablerito2.tablerito[Convert.ToInt32(curar)]) == true)
                                {
                                    int minioncurar; // numero del minion que se curara
                                    int minioncurarmax; // vida maxima del minion que se curara
                                    minioncurar = tablerito2.tablerito[Convert.ToInt32(curar)].EntregarVida();
                                    minioncurarmax = tablerito2.tablerito[Convert.ToInt32(curar)].EntregarVidamax();
                                    if (minioncurar < (minioncurarmax - 1) && minioncurar > 0)
                                    {
                                        minioncurar = minioncurar + 2;
                                        tablerito2.tablerito[Convert.ToInt32(curar)].Vida = minioncurar;
                                    }
                                }
                                else
                                {

                                }
                                p2.Cristal = p2.Cristal - 2;
                                HeroeAtaco2 = 1;
                            }
                            // ----------------------------- Sacerdote hasta aca -----------------------------------
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

                            p2.heroe.PtVida = -1;
                            SeSigue2 = 1;
                        }

                        else if (Desicion2 == "5")
                        {

                            // ------------------------------------- Efecto Healing totem -----------------------------------------------
                            foreach (Minions carta in tablerito2.tablerito)
                            {
                                if (carta.Name == "Healing totem")
                                {
                                    foreach (Minions carta1 in tablerito2.tablerito)
                                    {
                                        if (carta1.Vida < carta1.Vidamax)
                                        {
                                            carta1.Vida = carta1.Vida + 1;
                                        }

                                    }
                                    Console.WriteLine(Environment.NewLine + "Tus minions han ganado 1 de vida gracias a tu Healing totem, tu tablero ahora es: " + Environment.NewLine);
                                    tablerito2.Describir();
                                }

                            }
                            // ------------------------------------- Efecto Healing totem FIN -----------------------------------------------

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
