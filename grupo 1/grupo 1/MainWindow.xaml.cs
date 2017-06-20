using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.ComponentModel;

namespace Entrega_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            Mazo m = new Mazo();
            Mazo m2 = new Mazo();
            Hunter Hunter1 = new Hunter("Rexxar", 30, "Steady Shot", 0);
            Hunter Hunter2 = new Hunter("Rexxar", 30, "Steady Shot", 0);
            string jugador1 = "puxilupi";
            string Jugador2 = "Tutu";
            Jugador p1 = new Jugador(jugador1, 1, 0, m.mazito, 0, 0, Hunter1);
            Jugador p2 = new Jugador(Jugador2, 1, 0, m2.mazito, 0, 0, Hunter2);
            Minions wisp = new Minions("wisp", 0, 1, 1, "None", 0, "C:/Users/Crist/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/wisp.png");
            Minions murloc = new Minions("Murloc Raider", 1, 1, 2, "Murloc", 0, "C:/Users/Crist/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/murloc.png");
            Minions blood = new Minions("Bloodfen Raptor", 2, 2, 3, "Beast", 0, "C:/Users/Crist/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/raptor.png");
            Minions river = new Minions("River Crocolisk", 2, 3, 2, "Beast", 0, "C:/Users/Crist/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/cocodrilo.png");
            Minions magma = new Minions("Magma Rager", 3, 1, 3, "Elemental", 0, "C:/Users/Crist/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/magmar.png");
            Minions chill = new Minions("chillwind Yeti", 4, 5, 4, "None", 0, "C:/Users/Crist/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/yeti.png");
            Minions oasis = new Minions("Oasis Snapjaw", 4, 7, 2, "Beast", 0, "C:/Users/Crist/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/oasis.png");
            Minions ogre = new Minions("Boulderfist Ogre", 6, 7, 6, "None", 0, "C:/Users/Crist/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/ogro.png");
            Minions golem = new Minions("War Golem", 7, 7, 7, "None", 0, "C:/Users/Crist/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/golem.png");
            Minions hound = new Minions("Core Hound", 7, 5, 9, "Beast", 0, "C:/Users/Crist/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/core.png");
            m.AgregarCarta(wisp);
            m.AgregarCarta(blood);
            m.AgregarCarta(blood);
            m.AgregarCarta(blood);
            m.AgregarCarta(chill);
            m.AgregarCarta(chill);
            m.AgregarCarta(chill);
            m.AgregarCarta(golem);
            m.AgregarCarta(golem);
            m.AgregarCarta(golem);
            m.AgregarCarta(hound);
            m.AgregarCarta(hound);
            m.AgregarCarta(hound);
            m.AgregarCarta(magma);
            m.AgregarCarta(magma);
            m.AgregarCarta(magma);
            m.AgregarCarta(murloc);
            m.AgregarCarta(murloc);
            m.AgregarCarta(murloc);
            m.AgregarCarta(oasis);
            m.AgregarCarta(oasis);
            m.AgregarCarta(oasis);
            m.AgregarCarta(ogre);
            m.AgregarCarta(ogre);
            m.AgregarCarta(ogre);
            m.AgregarCarta(river);
            m.AgregarCarta(river);
            m.AgregarCarta(river);
            m.AgregarCarta(wisp);
            m.AgregarCarta(wisp);
            m2.AgregarCarta(blood);
            m2.AgregarCarta(blood);
            m2.AgregarCarta(blood);
            m2.AgregarCarta(chill);
            m2.AgregarCarta(chill);
            m2.AgregarCarta(chill);
            m2.AgregarCarta(golem);
            m2.AgregarCarta(golem);
            m2.AgregarCarta(golem);
            m2.AgregarCarta(hound);
            m2.AgregarCarta(hound);
            m2.AgregarCarta(hound);
            m2.AgregarCarta(magma);
            m2.AgregarCarta(magma);
            m2.AgregarCarta(magma);
            m2.AgregarCarta(murloc);
            m2.AgregarCarta(murloc);
            m2.AgregarCarta(murloc);
            m2.AgregarCarta(oasis);
            m2.AgregarCarta(oasis);
            m2.AgregarCarta(oasis);
            m2.AgregarCarta(ogre);
            m2.AgregarCarta(ogre);
            m2.AgregarCarta(ogre);
            m2.AgregarCarta(river);
            m2.AgregarCarta(river);
            m2.AgregarCarta(river);
            m2.AgregarCarta(wisp);
            m2.AgregarCarta(wisp);
            m2.AgregarCarta(wisp);




            p1m1.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            p1m2.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            p1m3.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            p2m1.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            p2m2.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            p2m3.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            p2m4.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));





        }

        private bool cte { get; set; }
        private bool cte2 { get; set; }

        private bool cte3 { get; set; }
        private bool cte4 { get; set; }
        private bool cte5 { get; set; }
        private bool cte6 { get; set; }
        private bool cte7 { get; set; }
        private bool cte8 { get; set; }
        private bool cte9 { get; set; }
        private bool cte10 { get; set; }

        private bool cte_ { get; set; }
        private bool cte2_ { get; set; }
        private bool cte3_ { get; set; }
        private bool cte4_ { get; set; }
        private bool cte5_ { get; set; }
        private bool cte6_ { get; set; }
        private bool cte7_ { get; set; }
        private bool cte8_ { get; set; }
        private bool cte9_ { get; set; }
        private bool cte10_ { get; set; }

        private bool ataca1 { get; set; }
        private bool ataca2 { get; set; }
        private bool ataca3 { get; set; }
        private bool ataca4 { get; set; }
        private bool ataca5 { get; set; }
        private bool ataca6 { get; set; }
        private bool ataca7 { get; set; }

        private bool ataca1_ { get; set; }
        private bool ataca2_ { get; set; }
        private bool ataca3_ { get; set; }
        private bool ataca4_ { get; set; }
        private bool ataca5_ { get; set; }
        private bool ataca6_ { get; set; }
        private bool ataca7_ { get; set; }

        // Desde aca metodos de invocar jugador 1
        private void p1m1e(object sender, MouseButtonEventArgs e)
        {
            cte = true;
        }
        private void p1m2e(object sender, MouseButtonEventArgs e)
        {
            cte2 = true;
        }
        private void p1m3e(object sender, MouseButtonEventArgs e)
        {
            cte3 = true;
        }
        private void p1m4e(object sender, MouseButtonEventArgs e)
        {
            cte4 = true;
        }
        private void p1m5e(object sender, MouseButtonEventArgs e)
        {
            cte5 = true;
        }
        private void p1m6e(object sender, MouseButtonEventArgs e)
        {
            cte6 = true;
        }
        private void p1m7e(object sender, MouseButtonEventArgs e)
        {
            cte7 = true;
        }
        private void p1m8e(object sender, MouseButtonEventArgs e)
        {
            cte8 = true;
        }
        private void p1m9e(object sender, MouseButtonEventArgs e)
        {
            cte9 = true;
        }
        private void p1m10e(object sender, MouseButtonEventArgs e)
        {
            cte10 = true;
        }
        private void p1t1e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap1.Source;
            var cartamano = p1m1.Source;
            var cartamano2 = p1m2.Source;
            var cartamano3 = p1m3.Source;
            var cartamano4 = p1m4.Source;
            var cartamano5 = p1m5.Source;
            var cartamano6 = p1m6.Source;
            var cartamano7 = p1m7.Source;
            var cartamano8 = p1m8.Source;
            var cartamano9 = p1m9.Source;
            var cartamano10 = p1m10.Source;
            var cartatablero = p1t1.Source;
            //string
            //Jugador p1 = new Jugador(jugador1, 1, 0, m.mazito, 0, 0, Hunter1);
            //p1m1.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));

            // Cualquier carta se puede invocar en la primera posicion del tablero 

            if (cte == true)
            {
                if (p1m1.Source != p1t1.Source)
                {
                    p1t1.Source = cartamano;
                    p1m1.Source = cartaoriginal;
                    p1t1.IsEnabled = true;
                    cte = false;
                    if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {
                        ataquep1t1.Content = "2";
                        vidap1t1.Content = "1";
                        p1t1.Source = murloc.Source;
                    }
                    else if (p1t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t1.Content = " 1";
                        vidap1t1.Content = "1";
                        p1t1.Source = wisp.Source;
                    }
                    else if (p1t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t1.Content = " 2";
                        vidap1t1.Content = "3";
                        p1t1.Source = cocodrilo.Source;
                    }
                    else if (p1t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t1.Content = " 3";
                        vidap1t1.Content = "2";
                        p1t1.Source = raptor.Source;
                    }
                    else if (p1t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t1.Content = "5";
                        vidap1t1.Content = "1";
                        p1t1.Source = magmar.Source;
                    }
                    else if (p1t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {
                        ataquep1t1.Content = "4";
                        vidap1t1.Content = "5";
                        p1t1.Source = yeti.Source;
                    }
                    else if (p1t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {
                        ataquep1t1.Content = "6";
                        vidap1t1.Content = "7";
                        p1t1.Source = ogro.Source;
                    }
                    else if (p1t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {
                        ataquep1t1.Content = "7";
                        vidap1t1.Content = "7";
                        p1t1.Source = golem.Source;
                    }
                    else if (p1t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t1.Content = "2";
                        vidap1t1.Content = "7";
                        p1t1.Source = oasis.Source;
                    }
                    else if (p1t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t1.Content = "9";
                        vidap1t1.Content = "5";
                        p1t1.Source = core.Source;
                    }
                }
                if (cte2 == true)
                {
                    if (p1m2.Source != p1t1.Source)
                    {
                        p1t1.Source = cartamano2;
                        p1m2.Source = cartaoriginal;
                        p1t1.IsEnabled = true;
                        cte2 = false;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = " 1";
                            p1t1.Source = murloc.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 1";
                            vidap1t1.Content = "1";
                            p1t1.Source = wisp.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 2";
                            vidap1t1.Content = "3";
                        }
                        else if (p1t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 3";
                            vidap1t1.Content = "2";
                            p1t1.Source = raptor.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "5";
                            vidap1t1.Content = "1";
                            p1t1.Source = magmar.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "4";
                            vidap1t1.Content = "5";
                            p1t1.Source = yeti.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "6";
                            vidap1t1.Content = "7";
                            p1t1.Source = ogro.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "7";
                            vidap1t1.Content = "7";
                            p1t1.Source = golem.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "7";
                            p1t1.Source = oasis.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "9";
                            vidap1t1.Content = "5";
                            p1t1.Source = core.Source;
                        }
                    }
                }
                if (cte3 == true)
                {
                    if (p1m3.Source != p1t1.Source)
                    {
                        p1t1.Source = cartamano3;
                        p1m3.Source = cartaoriginal;
                        p1t1.IsEnabled = true;
                        cte3 = false;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 2";
                            vidap1t1.Content = "1";
                            p1t1.Source = murloc.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 1";
                            vidap1t1.Content = "1";
                            p1t1.Source = wisp.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 2";
                            vidap1t1.Content = "3";
                            p1t1.Source = cocodrilo.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 3";
                            vidap1t1.Content = "2";
                            p1t1.Source = raptor.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "5";
                            vidap1t1.Content = "1";
                            p1t1.Source = magmar.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "4";
                            vidap1t1.Content = "5";
                            p1t1.Source = yeti.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "6";
                            vidap1t1.Content = "7";
                            p1t1.Source = ogro.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "7";
                            vidap1t1.Content = "7";
                            p1t1.Source = golem.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "7";
                            p1t1.Source = oasis.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "9";
                            vidap1t1.Content = "5";
                            p1t1.Source = core.Source;
                        }
                    }
                }
                if (cte4 == true)
                {
                    if (p1m4.Source != p1t1.Source)
                    {
                        p1t1.Source = cartamano4;
                        p1m4.Source = cartaoriginal;
                        p1t1.IsEnabled = true;
                        cte4 = false;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = " 1";
                            p1t1.Source = murloc.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 1";
                            vidap1t1.Content = "1";
                            p1t1.Source = wisp.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 2";
                            vidap1t1.Content = "3";
                            p1t1.Source = cocodrilo.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 3";
                            vidap1t1.Content = "2";
                            p1t1.Source = raptor.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "5";
                            vidap1t1.Content = "1";
                        }
                        else if (p1t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "4";
                            vidap1t1.Content = "5";
                            p1t1.Source = yeti.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "6";
                            vidap1t1.Content = "7";
                            p1t1.Source = ogro.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "7";
                            vidap1t1.Content = "7";
                            p1t1.Source = golem.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "7";
                            p1t1.Source = oasis.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "9";
                            vidap1t1.Content = "5";
                            p1t1.Source = core.Source;
                        }
                    }
                }
                if (cte5 == true)
                {
                    if (p1m5.Source != p1t1.Source)
                    {
                        p1t1.Source = cartamano5;
                        p1m5.Source = cartaoriginal;
                        p1t1.IsEnabled = true;
                        cte5 = false;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "1";
                            p1t1.Source = murloc.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 1";
                            vidap1t1.Content = "1";
                            p1t1.Source = wisp.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 2";
                            vidap1t1.Content = "3";
                            p1t1.Source = cocodrilo.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 3";
                            vidap1t1.Content = "2";
                            p1t1.Source = raptor.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "5";
                            vidap1t1.Content = "1";
                            p1t1.Source = magmar.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "4";
                            vidap1t1.Content = "5";
                            p1t1.Source = yeti.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "6";
                            vidap1t1.Content = "7";
                            p1t1.Source = ogro.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "7";
                            vidap1t1.Content = "7";
                            p1t1.Source = golem.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "7";
                            p1t1.Source = oasis.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "9";
                            vidap1t1.Content = "5";
                            p1t1.Source = core.Source;
                        }
                    }
                }
                if (cte6 == true)
                {
                    if (p1m6.Source != p1t1.Source)
                    {
                        p1t1.Source = cartamano6;
                        p1m6.Source = cartaoriginal;
                        p1t1.IsEnabled = true;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "1";
                            p1t1.Source = murloc.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 1";
                            vidap1t1.Content = "1";
                            p1t1.Source = wisp.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 2";
                            vidap1t1.Content = "3";
                            p1t1.Source = cocodrilo.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 3";
                            vidap1t1.Content = "2";
                            p1t1.Source = raptor.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "5";
                            vidap1t1.Content = "1";
                            p1t1.Source = magmar.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "4";
                            vidap1t1.Content = "5";
                            p1t1.Source = yeti.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "6";
                            vidap1t1.Content = "7";
                            p1t1.Source = ogro.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "7";
                            vidap1t1.Content = "7";
                            p1t1.Source = golem.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "7";
                            p1t1.Source = oasis.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "9";
                            vidap1t1.Content = "5";
                            p1t1.Source = core.Source;
                        }
                    }
                }
                if (cte7 == true)
                {
                    if (p1m3.Source != p1t1.Source)
                    {
                        p1t1.Source = cartamano7;
                        p1m7.Source = cartaoriginal;
                        p1t1.IsEnabled = true;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "1";
                            p1t1.Source = murloc.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 1";
                            vidap1t1.Content = "1";
                            p1t1.Source = wisp.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 2";
                            vidap1t1.Content = "3";
                            p1t1.Source = cocodrilo.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 3";
                            vidap1t1.Content = "2";
                            p1t1.Source = raptor.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "5";
                            vidap1t1.Content = "1";
                            p1t1.Source = magmar.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "4";
                            vidap1t1.Content = "5";
                            p1t1.Source = yeti.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "6";
                            vidap1t1.Content = "7";
                            p1t1.Source = ogro.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "7";
                            vidap1t1.Content = "7";
                            p1t1.Source = golem.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "7";
                            p1t1.Source = oasis.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "9";
                            vidap1t1.Content = "5";
                            p1t1.Source = core.Source;
                        }
                    }
                }
                if (cte8 == true)
                {
                    if (p1m8.Source != p1t1.Source)
                    {
                        p1t1.Source = cartamano8;
                        p1m8.Source = cartaoriginal;
                        p1t1.IsEnabled = true;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "1";
                            p1t1.Source = murloc.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 1";
                            vidap1t1.Content = "1";
                            p1t1.Source = wisp.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 2";
                            vidap1t1.Content = "3";
                            p1t1.Source = cocodrilo.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 3";
                            vidap1t1.Content = "2";
                            p1t1.Source = raptor.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "5";
                            vidap1t1.Content = "1";
                            p1t1.Source = magmar.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "4";
                            vidap1t1.Content = "5";
                            p1t1.Source = yeti.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "6";
                            vidap1t1.Content = "7";
                            p1t1.Source = ogro.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "7";
                            vidap1t1.Content = "7";
                            p1t1.Source = golem.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "7";
                            p1t1.Source = oasis.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "9";
                            vidap1t1.Content = "5";
                            p1t1.Source = core.Source;
                        }
                    }
                }
                if (cte9 == true)
                {
                    if (p1m9.Source != p1t1.Source)
                    {
                        p1t1.Source = cartamano9;
                        p1m9.Source = cartaoriginal;
                        p1t1.IsEnabled = true;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "1";
                            p1t1.Source = murloc.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 1";
                            vidap1t1.Content = "1";
                            p1t1.Source = wisp.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 2";
                            vidap1t1.Content = "3";
                            p1t1.Source = cocodrilo.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 3";
                            vidap1t1.Content = "2";
                            p1t1.Source = raptor.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "5";
                            vidap1t1.Content = "1";
                            p1t1.Source = magmar.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "4";
                            vidap1t1.Content = "5";
                            p1t1.Source = yeti.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "6";
                            vidap1t1.Content = "7";
                            p1t1.Source = ogro.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "7";
                            vidap1t1.Content = "7";
                            p1t1.Source = golem.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "7";
                            p1t1.Source = oasis.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "9";
                            vidap1t1.Content = "5";
                            p1t1.Source = core.Source;
                        }
                    }
                }
                if (cte10 == true)
                {
                    if (p1m10.Source != p1t1.Source)
                    {
                        p1t1.Source = cartamano10;
                        p1m10.Source = cartaoriginal;
                        p1t1.IsEnabled = true;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = " 1";
                            p1t1.Source = murloc.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 1";
                            vidap1t1.Content = "1";
                            p1t1.Source = wisp.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 2";
                            vidap1t1.Content = "3";
                            p1t1.Source = cocodrilo.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = " 3";
                            vidap1t1.Content = "2";
                            p1t1.Source = raptor.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "5";
                            vidap1t1.Content = "1";
                            p1t1.Source = magmar.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "4";
                            vidap1t1.Content = "5";
                            p1t1.Source = yeti.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "6";
                            vidap1t1.Content = "7";
                            p1t1.Source = ogro.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "7";
                            vidap1t1.Content = "7";
                            p1t1.Source = golem.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "2";
                            vidap1t1.Content = "7";
                            p1t1.Source = oasis.Source;
                        }
                        else if (p1t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep1t1.Content = "9";
                            vidap1t1.Content = "5";
                            p1t1.Source = core.Source;
                        }
                    }
                }


            }
        }
        private void p1t2e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap1.Source;
            var cartamano = p1m1.Source;
            var cartamano2 = p1m2.Source;
            var cartamano3 = p1m3.Source;
            var cartamano4 = p1m4.Source;
            var cartamano5 = p1m5.Source;
            var cartamano6 = p1m6.Source;
            var cartamano7 = p1m7.Source;
            var cartamano8 = p1m8.Source;
            var cartamano9 = p1m9.Source;
            var cartamano10 = p1m10.Source;
            var cartatablero = p1t2.Source;
            if (cte == true)
            {
                if (p1m1.Source != p1t2.Source)
                {
                    p1t2.Source = cartamano;
                    p1m1.Source = cartaoriginal;
                    p1t2.IsEnabled = true;
                    cte = false;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = " 1";
                        p1t2.Source = murloc.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 1";
                        vidap1t2.Content = "1";
                        p1t2.Source = wisp.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 2";
                        vidap1t2.Content = "3";
                        p1t2.Source = cocodrilo.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 3";
                        vidap1t2.Content = "2";
                        p1t2.Source = raptor.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "5";
                        vidap1t2.Content = "1";
                        p1t2.Source = magmar.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "4";
                        vidap1t2.Content = "5";
                        p1t2.Source = yeti.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "6";
                        vidap1t2.Content = "7";
                        p1t2.Source = ogro.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "7";
                        vidap1t2.Content = "7";
                        p1t2.Source = golem.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "7";
                        p1t2.Source = oasis.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "9";
                        vidap1t2.Content = "5";
                        p1t2.Source = core.Source;
                    }
                }
            }
            if (cte2 == true)
            {
                if (p1m2.Source != p1t2.Source)
                {
                    p1t2.Source = cartamano2;
                    p1m2.Source = cartaoriginal;
                    p1t2.IsEnabled = true;
                    cte2 = false;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "1";
                        p1t2.Source = murloc.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 1";
                        vidap1t2.Content = "1";
                        p1t2.Source = wisp.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 2";
                        vidap1t2.Content = "3";
                        p1t2.Source = cocodrilo.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 3";
                        vidap1t2.Content = "2";
                        p1t2.Source = raptor.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "5";
                        vidap1t2.Content = "1";
                        p1t2.Source = magmar.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "4";
                        vidap1t2.Content = "5";
                        p1t2.Source = yeti.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "6";
                        vidap1t2.Content = "7";
                        p1t2.Source = ogro.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "7";
                        vidap1t2.Content = "7";
                        p1t2.Source = golem.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "7";
                        p1t2.Source = oasis.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "9";
                        vidap1t2.Content = "5";
                        p1t2.Source = core.Source;
                    }
                }
            }
            if (cte3 == true)
            {
                if (p1m3.Source != p1t2.Source)
                {
                    p1t2.Source = cartamano3;
                    p1m3.Source = cartaoriginal;
                    p1t2.IsEnabled = true;
                    cte3 = false;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 2";
                        vidap1t2.Content = "1";
                        p1t2.Source = murloc.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 1";
                        vidap1t2.Content = "1";
                        p1t2.Source = wisp.Source;

                    }
                    else if (p1t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 2";
                        vidap1t2.Content = "3";
                        p1t2.Source = cocodrilo.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 3";
                        vidap1t2.Content = "2";
                        p1t2.Source = raptor.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "5";
                        vidap1t2.Content = "1";
                        p1t2.Source = magmar.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "4";
                        vidap1t2.Content = "5";
                        p1t2.Source = yeti.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "6";
                        vidap1t2.Content = "7";
                        p1t2.Source = ogro.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "7";
                        vidap1t2.Content = "7";
                        p1t2.Source = golem.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "7";
                        p1t2.Source = oasis.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "9";
                        vidap1t2.Content = "5";
                        p1t2.Source = core.Source;
                    }
                }
            }
            if (cte4 == true)
            {
                if (p1m4.Source != p1t2.Source)
                {
                    p1t2.Source = cartamano4;
                    p1m4.Source = cartaoriginal;
                    p1t2.IsEnabled = true;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "1";
                        p1t2.Source = murloc.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 1";
                        vidap1t2.Content = "1";
                        p1t2.Source = wisp.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 2";
                        vidap1t2.Content = "3";
                        p1t2.Source = cocodrilo.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 3";
                        vidap1t2.Content = "2";
                        p1t2.Source = raptor.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "5";
                        vidap1t2.Content = "1";
                        p1t2.Source = magmar.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "4";
                        vidap1t2.Content = "5";
                        p1t2.Source = yeti.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "6";
                        vidap1t2.Content = "7";
                        p1t2.Source = ogro.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "7";
                        vidap1t2.Content = "7";
                        p1t2.Source = golem.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "7";
                        p1t2.Source = oasis.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "9";
                        vidap1t2.Content = "5";
                        p1t2.Source = core.Source;
                    }
                }
            }
            if (cte5 == true)
            {
                if (p1m5.Source != p1t2.Source)
                {
                    p1t1.Source = cartamano5;
                    p1m5.Source = cartaoriginal;
                    p1t1.IsEnabled = true;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "1";
                        p1t2.Source = murloc.Source;

                    }
                    else if (p1t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 1";
                        vidap1t2.Content = "1";
                        p1t2.Source = wisp.Source;

                    }
                    else if (p1t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 2";
                        vidap1t2.Content = "3";
                        p1t2.Source = cocodrilo.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 3";
                        vidap1t2.Content = "2";
                        p1t2.Source = raptor.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "5";
                        vidap1t2.Content = "1";
                        p1t2.Source = magmar.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "4";
                        vidap1t2.Content = "5";
                        p1t2.Source = yeti.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "6";
                        vidap1t2.Content = "7";
                        p1t2.Source = ogro.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "7";
                        vidap1t2.Content = "7";
                        p1t2.Source = golem.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "7";
                        p1t2.Source = oasis.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "9";
                        vidap1t2.Content = "5";
                        p1t2.Source = core.Source;
                    }
                }
            }
            if (cte6 == true)
            {
                if (p1m6.Source != p1t2.Source)
                {
                    p1t2.Source = cartamano6;
                    p1m6.Source = cartaoriginal;
                    p1t2.IsEnabled = true;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "1";
                        p1t2.Source = murloc.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 1";
                        vidap1t2.Content = "1";
                        p1t2.Source = wisp.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 2";
                        vidap1t2.Content = "3";
                        p1t2.Source = cocodrilo.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 3";
                        vidap1t2.Content = "2";
                        p1t2.Source = raptor.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "5";
                        vidap1t2.Content = "1";
                        p1t2.Source = magmar.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "4";
                        vidap1t2.Content = "5";
                        p1t2.Source = yeti.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "6";
                        vidap1t2.Content = "7";
                        p1t2.Source = ogro.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "7";
                        vidap1t2.Content = "7";
                        p1t2.Source = golem.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "7";
                        p1t2.Source = oasis.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "9";
                        vidap1t2.Content = "5";
                        p1t2.Source = core.Source;
                    }
                }
            }
            if (cte7 == true)
            {
                if (p1m3.Source != p1t2.Source)
                {
                    p1t2.Source = cartamano7;
                    p1m7.Source = cartaoriginal;
                    p1t2.IsEnabled = true;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "1";
                        p1t2.Source = murloc.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 1";
                        vidap1t2.Content = "1";
                        p1t2.Source = wisp.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 2";
                        vidap1t2.Content = "3";
                        p1t2.Source = cocodrilo.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 3";
                        vidap1t2.Content = "2";
                        p1t2.Source = raptor.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "5";
                        vidap1t2.Content = "1";
                        p1t2.Source = magmar.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "4";
                        vidap1t2.Content = "5";
                        p1t2.Source = yeti.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "6";
                        vidap1t2.Content = "7";
                        p1t2.Source = ogro.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "7";
                        vidap1t2.Content = "7";
                        p1t2.Source = golem.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "7";
                        p1t2.Source = oasis.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "9";
                        vidap1t2.Content = "5";
                        p1t2.Source = core.Source;
                    }
                }
            }
            if (cte8 == true)
            {
                if (p1m8.Source != p1t2.Source)
                {
                    p1t2.Source = cartamano8;
                    p1m8.Source = cartaoriginal;
                    p1t2.IsEnabled = true;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "1";
                        p1t2.Source = murloc.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 1";
                        vidap1t2.Content = "1";
                        p1t2.Source = wisp.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 2";
                        vidap1t2.Content = "3";
                        p1t2.Source = cocodrilo.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 3";
                        vidap1t2.Content = "2";
                        p1t2.Source = raptor.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "5";
                        vidap1t2.Content = "1";
                        p1t2.Source = magmar.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "4";
                        vidap1t2.Content = "5";
                        p1t2.Source = yeti.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "6";
                        vidap1t2.Content = "7";
                        p1t2.Source = ogro.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "7";
                        vidap1t2.Content = "7";
                        p1t2.Source = golem.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "7";
                        p1t2.Source = oasis.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "9";
                        vidap1t2.Content = "5";
                        p1t2.Source = core.Source;
                    }
                }
            }
            if (cte9 == true)
            {
                if (p1m9.Source != p1t2.Source)
                {
                    p1t2.Source = cartamano9;
                    p1m9.Source = cartaoriginal;
                    p1t2.IsEnabled = true;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "1";
                        p1t2.Source = murloc.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 1";
                        vidap1t2.Content = "1";
                        p1t2.Source = wisp.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 2";
                        vidap1t2.Content = "3";
                        p1t2.Source = cocodrilo.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 3";
                        vidap1t2.Content = "2";
                        p1t2.Source = raptor.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "5";
                        vidap1t2.Content = "1";
                        p1t2.Source = magmar.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "4";
                        vidap1t2.Content = "5";
                        p1t2.Source = yeti.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "6";
                        vidap1t2.Content = "7";
                        p1t2.Source = ogro.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "7";
                        vidap1t2.Content = "7";
                        p1t2.Source = golem.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "7";
                        p1t2.Source = oasis.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "9";
                        vidap1t2.Content = "5";
                        p1t2.Source = core.Source;
                    }
                }
            }
            if (cte10 == true)
            {
                if (p1m10.Source != p1t2.Source)
                {
                    p1t2.Source = cartamano10;
                    p1m10.Source = cartaoriginal;
                    p1t2.IsEnabled = true;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "1";
                        p1t2.Source = murloc.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 1";
                        vidap1t2.Content = "1";
                        p1t2.Source = wisp.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 2";
                        vidap1t2.Content = "3";
                        p1t2.Source = cocodrilo.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = " 3";
                        vidap1t2.Content = "2";
                        p1t2.Source = raptor.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "5";
                        vidap1t2.Content = "1";
                        p1t2.Source = magmar.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "4";
                        vidap1t2.Content = "5";
                        p1t2.Source = yeti.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "6";
                        vidap1t2.Content = "7";
                        p1t2.Source = ogro.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "7";
                        vidap1t2.Content = "7";
                        p1t2.Source = golem.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "2";
                        vidap1t2.Content = "7";
                        p1t2.Source = oasis.Source;
                    }
                    else if (p1t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t2.Content = "9";
                        vidap1t2.Content = "5";
                        p1t2.Source = core.Source;
                    }
                }
            }
        }
        private void p1t3e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap1.Source;
            var cartamano = p1m1.Source;
            var cartamano2 = p1m2.Source;
            var cartamano3 = p1m3.Source;
            var cartamano4 = p1m4.Source;
            var cartamano5 = p1m5.Source;
            var cartamano6 = p1m6.Source;
            var cartamano7 = p1m7.Source;
            var cartamano8 = p1m8.Source;
            var cartamano9 = p1m9.Source;
            var cartamano10 = p1m10.Source;
            var cartatablero = p1t3.Source;
            if (cte == true)
            {
                if (p1m1.Source != p1t3.Source)
                {
                    p1t3.Source = cartamano;
                    p1m1.Source = cartaoriginal;
                    p1t3.IsEnabled = true;
                    cte = false;
                    if (p1t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "1";
                        p1t3.Source = murloc.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = " 1";
                        vidap1t3.Content = "1";
                        p1t3.Source = wisp.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = " 2";
                        vidap1t3.Content = "3";
                        p1t3.Source = cocodrilo.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = " 3";
                        vidap1t3.Content = "2";
                        p1t3.Source = raptor.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "5";
                        vidap1t3.Content = "1";
                        p1t3.Source = magmar.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "4";
                        vidap1t3.Content = "5";
                        p1t3.Source = yeti.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "6";
                        vidap1t3.Content = "7";
                        p1t3.Source = ogro.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "7";
                        vidap1t3.Content = "7";
                        p1t3.Source = golem.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "7";
                        p1t3.Source = oasis.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "9";
                        vidap1t3.Content = "5";
                        p1t3.Source = core.Source;
                    }
                }


            }
            if (cte2 == true)
            {
                if (p1m2.Source != p1t3.Source)
                {
                    p1t3.Source = cartamano2;
                    p1m2.Source = cartaoriginal;
                    p1t3.IsEnabled = true;
                    cte2 = false;
                    if (p1t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "2";
                        vidap1t3.Content = " 1";
                        p1t3.Source = murloc.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 1";
                        vidap1t3.Content = "1";
                        p1t3.Source = wisp.Source;
                    }


                    else if (p1t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 2";
                        vidap1t3.Content = "3";
                        p1t3.Source = cocodrilo.Source;



                    }
                    else if (p1t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 3";
                        vidap1t3.Content = "2";
                        p1t3.Source = raptor.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "5";
                        vidap1t3.Content = "1";
                        p1t3.Source = magmar.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "4";
                        vidap1t3.Content = "5";
                        p1t3.Source = yeti.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "6";
                        vidap1t3.Content = "7";
                        p1t3.Source = ogro.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "7";
                        vidap1t3.Content = "7";
                        p1t3.Source = golem.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "7";
                        p1t3.Source = oasis.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "9";
                        vidap1t3.Content = "5";
                        p1t3.Source = core.Source;
                    }
                }
            }
            if (cte3 == true)
            {
                if (p1m3.Source != p1t3.Source)
                {
                    p1t3.Source = cartamano3;
                    p1m3.Source = cartaoriginal;
                    p1t3.IsEnabled = true;
                    cte3 = false;
                    if (p1t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "2";
                        vidap1t3.Content = " 1";
                        p1t3.Source = murloc.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 1";
                        vidap1t3.Content = "1";
                        p1t3.Source = wisp.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 2";
                        vidap1t3.Content = "3";
                        p1t3.Source = cocodrilo.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 3";
                        vidap1t3.Content = "2";
                        p1t3.Source = raptor.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "5";
                        vidap1t3.Content = "1";
                        p1t3.Source = magmar.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "4";
                        vidap1t3.Content = "5";
                        p1t3.Source = yeti.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "6";
                        vidap1t3.Content = "7";
                        p1t3.Source = ogro.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "7";
                        vidap1t3.Content = "7";
                        p1t3.Source = golem.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "7";
                        p1t3.Source = oasis.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "9";
                        vidap1t3.Content = "5";
                        p1t3.Source = core.Source;
                    }
                }
            }
            if (cte4 == true)
            {
                if (p1m4.Source != p1t3.Source)
                {
                    p1t3.Source = cartamano4;
                    p1m4.Source = cartaoriginal;
                    p1t3.IsEnabled = true;
                    cte4 = false;
                    if (p1t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "1";
                        p1t3.Source = murloc.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 1";
                        vidap1t3.Content = "1";
                        p1t3.Source = wisp.Source;


                    }
                    else if (p1t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 2";
                        vidap1t3.Content = "3";
                        p1t3.Source = cocodrilo.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 3";
                        vidap1t3.Content = "2";
                        p1t3.Source = raptor.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "5";
                        vidap1t3.Content = "1";
                        p1t3.Source = magmar.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "4";
                        vidap1t3.Content = "5";
                        p1t3.Source = yeti.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "6";
                        vidap1t3.Content = "7";
                        p1t3.Source = ogro.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "7";
                        vidap1t3.Content = "7";
                        p1t3.Source = golem.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "7";
                        p1t3.Source = oasis.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "9";
                        vidap1t3.Content = "5";
                        p1t3.Source = core.Source;
                    }
                }
            }
            if (cte5 == true)
            {
                if (p1m5.Source != p1t3.Source)
                {
                    p1t3.Source = cartamano5;
                    p1m5.Source = cartaoriginal;
                    p1t3.IsEnabled = true;
                    if (p1t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "1";
                        p1t3.Source = murloc.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 1";
                        vidap1t3.Content = "1";
                        p1t3.Source = wisp.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 2";
                        vidap1t3.Content = "3";
                        p1t3.Source = cocodrilo.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 3";
                        vidap1t3.Content = "2";
                        p1t3.Source = raptor.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "5";
                        vidap1t3.Content = "1";
                        p1t3.Source = magmar.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "4";
                        vidap1t3.Content = "5";
                        p1t3.Source = yeti.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "6";
                        vidap1t3.Content = "7";
                        p1t3.Source = ogro.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "7";
                        vidap1t3.Content = "7";
                        p1t3.Source = golem.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "7";
                        p1t3.Source = oasis.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "9";
                        vidap1t3.Content = "5";
                        p1t3.Source = core.Source;
                    }
                }
            }
            if (cte6 == true)
            {
                if (p1m6.Source != p1t3.Source)
                {
                    p1t3.Source = cartamano6;
                    p1m6.Source = cartaoriginal;
                    p1t3.IsEnabled = true;
                    if (p1t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "1";
                        p1t3.Source = murloc.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 1";
                        vidap1t3.Content = "1";
                        p1t3.Source = wisp.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 2";
                        vidap1t3.Content = "3";
                        p1t3.Source = cocodrilo.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 3";
                        vidap1t3.Content = "2";
                        p1t3.Source = raptor.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "5";
                        vidap1t3.Content = "1";
                        p1t3.Source = magmar.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "4";
                        vidap1t3.Content = "5";
                        p1t3.Source = yeti.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "6";
                        vidap1t3.Content = "7";
                        p1t3.Source = ogro.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "7";
                        vidap1t3.Content = "7";
                        p1t3.Source = golem.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "7";
                        p1t3.Source = oasis.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "9";
                        vidap1t3.Content = "5";
                        p1t3.Source = core.Source;
                    }
                }
            }
            if (cte7 == true)
            {
                if (p1m3.Source != p1t3.Source)
                {
                    p1t3.Source = cartamano7;
                    p1m7.Source = cartaoriginal;
                    p1t3.IsEnabled = true;
                    if (p1t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "1";
                        p1t3.Source = murloc.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 1";
                        vidap1t3.Content = "1";
                        p1t3.Source = wisp.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 2";
                        vidap1t3.Content = "3";
                        p1t3.Source = cocodrilo.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 3";
                        vidap1t3.Content = "2";
                        p1t3.Source = raptor.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "5";
                        vidap1t3.Content = "1";
                        p1t3.Source = magmar.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "4";
                        vidap1t3.Content = "5";
                        p1t3.Source = yeti.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "6";
                        vidap1t3.Content = "7";
                        p1t3.Source = ogro.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "7";
                        vidap1t3.Content = "7";
                        p1t3.Source = golem.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "7";
                        p1t3.Source = oasis.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "9";
                        vidap1t3.Content = "5";
                        p1t3.Source = core.Source;
                    }
                }
            }
            if (cte8 == true)
            {
                if (p1m8.Source != p1t3.Source)
                {
                    p1t3.Source = cartamano8;
                    p1m8.Source = cartaoriginal;
                    p1t3.IsEnabled = true;
                    if (p1t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "1";
                        p1t3.Source = murloc.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 1";
                        vidap1t3.Content = "1";
                        p1t3.Source = wisp.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 2";
                        vidap1t3.Content = "3";
                        p1t3.Source = cocodrilo.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 3";
                        vidap1t3.Content = "2";
                        p1t3.Source = raptor.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "5";
                        vidap1t3.Content = "1";
                        p1t3.Source = magmar.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "4";
                        vidap1t3.Content = "5";
                        p1t3.Source = yeti.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "6";
                        vidap1t3.Content = "7";
                        p1t3.Source = ogro.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "7";
                        vidap1t3.Content = "7";
                        p1t3.Source = golem.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "7";
                        p1t3.Source = oasis.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "9";
                        vidap1t3.Content = "5";
                        p1t3.Source = core.Source;
                    }
                }
            }
            if (cte9 == true)
            {
                if (p1m9.Source != p1t3.Source)
                {
                    p1t3.Source = cartamano9;
                    p1m9.Source = cartaoriginal;
                    p1t3.IsEnabled = true;
                    if (p1t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "1";
                        p1t3.Source = murloc.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 1";
                        vidap1t3.Content = "1";
                        p1t3.Source = wisp.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 2";
                        vidap1t3.Content = "3";
                        p1t3.Source = cocodrilo.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 3";
                        vidap1t3.Content = "2";
                        p1t3.Source = raptor.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "5";
                        vidap1t3.Content = "1";
                        p1t3.Source = magmar.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "4";
                        vidap1t3.Content = "5";
                        p1t3.Source = yeti.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "6";
                        vidap1t3.Content = "7";
                        p1t3.Source = ogro.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "7";
                        vidap1t3.Content = "7";
                        p1t3.Source = golem.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "7";
                        p1t3.Source = oasis.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "9";
                        vidap1t3.Content = "5";
                        p1t3.Source = core.Source;
                    }
                }
            }
            if (cte10 == true)
            {
                if (p1m10.Source != p1t3.Source)
                {
                    p1t3.Source = cartamano10;
                    p1m10.Source = cartaoriginal;
                    p1t3.IsEnabled = true;
                    if (p1t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "1";
                        p1t3.Source = murloc.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 1";
                        vidap1t3.Content = "1";
                        p1t3.Source = wisp.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 2";
                        vidap1t3.Content = "3";
                        p1t3.Source = cocodrilo.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = " 3";
                        vidap1t3.Content = "2";
                        p1t3.Source = raptor.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "5";
                        vidap1t3.Content = "1";
                        p1t3.Source = magmar.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "4";
                        vidap1t3.Content = "5";
                        p1t3.Source = yeti.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "6";
                        vidap1t3.Content = "7";
                        p1t3.Source = ogro.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t3.Content = "7";
                        vidap1t3.Content = "7";
                        p1t3.Source = golem.Source;

                    }
                    else if (p1t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "2";
                        vidap1t3.Content = "7";
                        p1t3.Source = oasis.Source;
                    }
                    else if (p1t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t3.Content = "9";
                        vidap1t3.Content = "5";
                        p1t3.Source = core.Source;
                    }
                }
            }
        }
        private void p1t4e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap1.Source;
            var cartamano = p1m1.Source;
            var cartamano2 = p1m2.Source;
            var cartamano3 = p1m3.Source;
            var cartamano4 = p1m4.Source;
            var cartamano5 = p1m5.Source;
            var cartamano6 = p1m6.Source;
            var cartamano7 = p1m7.Source;
            var cartamano8 = p1m8.Source;
            var cartamano9 = p1m9.Source;
            var cartamano10 = p1m10.Source;
            var cartatablero = p1t2.Source;

            if (cte == true)
            {
                if (p1m1.Source != p1t4.Source)
                {
                    p1t4.Source = cartamano;
                    p1m1.Source = cartaoriginal;
                    p1t4.IsEnabled = true;
                    if (p1t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "1";
                        p1t4.Source = wisp.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 1";
                        vidap1t4.Content = "1";
                        p1t4.Source = wisp.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 2";
                        vidap1t4.Content = "3";
                        p1t4.Source = cocodrilo.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 3";
                        vidap1t4.Content = "2";
                        p1t4.Source = raptor.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "5";
                        vidap1t4.Content = "1";
                        p1t4.Source = magmar.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "4";
                        vidap1t4.Content = "5";
                        p1t4.Source = yeti.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "6";
                        vidap1t4.Content = "7";
                        p1t4.Source = ogro.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "7";
                        vidap1t4.Content = "7";
                        p1t4.Source = golem.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "7";
                        p1t4.Source = oasis.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "9";
                        vidap1t4.Content = "5";
                        p1t4.Source = core.Source;
                    }
                }


            }
            if (cte2 == true)
            {
                if (p1m2.Source != p1t4.Source)
                {
                    p1t4.Source = cartamano2;
                    p1m2.Source = cartaoriginal;
                    p1t4.IsEnabled = true;
                    if (p1t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "1";
                        p1t4.Source = murloc.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 1";
                        vidap1t4.Content = "1";
                        p1t4.Source = wisp.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 2";
                        vidap1t4.Content = "3";
                        p1t4.Source = cocodrilo.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 3";
                        vidap1t4.Content = "2";
                        p1t4.Source = raptor.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "5";
                        vidap1t4.Content = "1";
                        p1t4.Source = magmar.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "4";
                        vidap1t4.Content = "5";
                        p1t4.Source = yeti.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "6";
                        vidap1t4.Content = "7";
                        p1t4.Source = ogro.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "7";
                        vidap1t4.Content = "7";
                        p1t4.Source = golem.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "7";
                        p1t4.Source = oasis.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "9";
                        vidap1t4.Content = "5";
                        p1t4.Source = core.Source;
                    }
                }
            }
            if (cte3 == true)
            {
                if (p1m3.Source != p1t4.Source)
                {
                    p1t4.Source = cartamano3;
                    p1m3.Source = cartaoriginal;
                    p1t4.IsEnabled = true;
                    if (p1t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "1";
                        p1t4.Source = murloc.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 1";
                        vidap1t4.Content = "1";
                        p1t4.Source = wisp.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 2";
                        vidap1t4.Content = "3";
                        p1t4.Source = cocodrilo.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 3";
                        vidap1t4.Content = "2";
                        p1t4.Source = raptor.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "5";
                        vidap1t4.Content = "1";
                        p1t4.Source = magmar.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "4";
                        vidap1t4.Content = "5";
                        p1t4.Source = yeti.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "6";
                        vidap1t4.Content = "7";
                        p1t4.Source = ogro.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "7";
                        vidap1t4.Content = "7";
                        p1t4.Source = golem.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "7";
                        p1t4.Source = oasis.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "9";
                        vidap1t4.Content = "5";
                        p1t4.Source = core.Source;
                    }
                }
            }
            if (cte4 == true)
            {
                if (p1m4.Source != p1t4.Source)
                {
                    p1t4.Source = cartamano4;
                    p1m4.Source = cartaoriginal;
                    p1t4.IsEnabled = true;
                    if (p1t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "1";
                        p1t4.Source = murloc.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 1";
                        vidap1t4.Content = "1";
                        p1t4.Source = wisp.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 2";
                        vidap1t4.Content = "3";
                        p1t4.Source = cocodrilo.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 3";
                        vidap1t4.Content = "2";
                        p1t4.Source = raptor.Source;




                    }
                    else if (p1t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "5";
                        vidap1t4.Content = "1";
                        p1t4.Source = magmar.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "4";
                        vidap1t4.Content = "5";
                        p1t4.Source = yeti.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "6";
                        vidap1t4.Content = "7";
                        p1t4.Source = ogro.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "7";
                        vidap1t4.Content = "7";
                        p1t4.Source = golem.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "7";
                        p1t4.Source = oasis.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "9";
                        vidap1t4.Content = "5";
                        p1t4.Source = core.Source;
                    }
                }
            }
            if (cte5 == true)
            {
                if (p1m5.Source != p1t4.Source)
                {
                    p1t1.Source = cartamano5;
                    p1m5.Source = cartaoriginal;
                    p1t1.IsEnabled = true;
                    if (p1t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "1";
                        p1t4.Source = murloc.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 1";
                        vidap1t4.Content = "1";
                        p1t4.Source = wisp.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 2";
                        vidap1t4.Content = "3";
                        p1t4.Source = cocodrilo.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 3";
                        vidap1t4.Content = "2";
                        p1t4.Source = raptor.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "5";
                        vidap1t4.Content = "1";
                        p1t4.Source = magmar.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "4";
                        vidap1t4.Content = "5";
                        p1t4.Source = yeti.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "6";
                        vidap1t4.Content = "7";
                        p1t4.Source = ogro.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "7";
                        vidap1t4.Content = "7";
                        p1t4.Source = golem.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "7";
                        p1t4.Source = oasis.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "9";
                        vidap1t4.Content = "5";
                        p1t4.Source = core.Source;
                    }
                }
            }
            if (cte6 == true)
            {
                if (p1m6.Source != p1t4.Source)
                {
                    p1t4.Source = cartamano6;
                    p1m6.Source = cartaoriginal;
                    p1t4.IsEnabled = true;
                    if (p1t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "1";
                        p1t4.Source = murloc.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 1";
                        vidap1t4.Content = "1";
                        p1t4.Source = wisp.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 2";
                        vidap1t4.Content = "3";
                        p1t4.Source = cocodrilo.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 3";
                        vidap1t4.Content = "2";
                        p1t4.Source = raptor.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "5";
                        vidap1t4.Content = "1";
                        p1t4.Source = magmar.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "4";
                        vidap1t4.Content = "5";
                        p1t4.Source = yeti.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "6";
                        vidap1t4.Content = "7";
                        p1t4.Source = ogro.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "7";
                        vidap1t4.Content = "7";
                        p1t4.Source = golem.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "7";
                        p1t4.Source = oasis.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "9";
                        vidap1t4.Content = "5";
                        p1t4.Source = core.Source;
                    }
                }
            }
            if (cte7 == true)
            {
                if (p1m3.Source != p1t4.Source)
                {
                    p1t4.Source = cartamano7;
                    p1m7.Source = cartaoriginal;
                    p1t4.IsEnabled = true;
                    if (p1t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "1";
                        p1t4.Source = murloc.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 1";
                        vidap1t4.Content = "1";
                        p1t4.Source = wisp.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 2";
                        vidap1t4.Content = "3";
                        p1t4.Source = cocodrilo.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 3";
                        vidap1t4.Content = "2";
                        p1t4.Source = raptor.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "5";
                        vidap1t4.Content = "1";
                        p1t4.Source = magmar.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "4";
                        vidap1t4.Content = "5";
                        p1t4.Source = yeti.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "6";
                        vidap1t4.Content = "7";
                        p1t4.Source = ogro.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "7";
                        vidap1t4.Content = "7";
                        p1t4.Source = golem.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "7";
                        p1t4.Source = oasis.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "9";
                        vidap1t4.Content = "5";
                        p1t4.Source = core.Source;
                    }
                }
            }
            if (cte8 == true)
            {
                if (p1m8.Source != p1t4.Source)
                {
                    p1t4.Source = cartamano8;
                    p1m8.Source = cartaoriginal;
                    p1t4.IsEnabled = true;
                    if (p1t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "1";
                        p1t4.Source = murloc.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 1";
                        vidap1t4.Content = "1";
                        p1t4.Source = wisp.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 2";
                        vidap1t4.Content = "3";
                        p1t4.Source = cocodrilo.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 3";
                        vidap1t4.Content = "2";
                        p1t4.Source = raptor.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "5";
                        vidap1t4.Content = "1";
                        p1t4.Source = magmar.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "4";
                        vidap1t4.Content = "5";
                        p1t4.Source = yeti.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "6";
                        vidap1t4.Content = "7";
                        p1t4.Source = ogro.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "7";
                        vidap1t4.Content = "7";
                        p1t4.Source = golem.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "7";
                        p1t4.Source = oasis.Source;



                    }
                    else if (p1t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "9";
                        vidap1t4.Content = "5";
                        p1t4.Source = core.Source;
                    }
                }
            }
            if (cte9 == true)
            {
                if (p1m9.Source != p1t4.Source)
                {
                    p1t4.Source = cartamano9;
                    p1m9.Source = cartaoriginal;
                    p1t4.IsEnabled = true;
                    if (p1t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "1";
                        p1t4.Source = murloc.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 1";
                        vidap1t4.Content = "1";
                        p1t4.Source = wisp.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 2";
                        vidap1t4.Content = "3";
                        p1t4.Source = cocodrilo.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 3";
                        vidap1t4.Content = "2";
                        p1t4.Source = raptor.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "5";
                        vidap1t4.Content = "1";
                        p1t4.Source = magmar.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "4";
                        vidap1t4.Content = "5";
                        p1t4.Source = yeti.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "6";
                        vidap1t4.Content = "7";
                        p1t4.Source = ogro.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "7";
                        vidap1t4.Content = "7";
                        p1t4.Source = golem.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "7";
                        p1t4.Source = oasis.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "9";
                        vidap1t4.Content = "5";
                        p1t4.Source = core.Source;
                    }
                }
            }
            if (cte10 == true)
            {
                if (p1m10.Source != p1t4.Source)
                {
                    p1t4.Source = cartamano10;
                    p1m10.Source = cartaoriginal;
                    p1t4.IsEnabled = true;
                    if (p1t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "1";
                        p1t4.Source = murloc.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 1";
                        vidap1t4.Content = "1";
                        p1t4.Source = wisp.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 2";
                        vidap1t4.Content = "3";
                        p1t4.Source = cocodrilo.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = " 3";
                        vidap1t4.Content = "2";
                        p1t4.Source = raptor.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "5";
                        vidap1t4.Content = "1";
                        p1t4.Source = magmar.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "4";
                        vidap1t4.Content = "5";
                        p1t4.Source = yeti.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "6";
                        vidap1t4.Content = "7";
                        p1t4.Source = ogro.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t4.Content = "7";
                        vidap1t4.Content = "7";
                        p1t4.Source = golem.Source;

                    }
                    else if (p1t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "2";
                        vidap1t4.Content = "7";
                        p1t4.Source = oasis.Source;
                    }
                    else if (p1t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t4.Content = "9";
                        vidap1t4.Content = "5";
                        p1t4.Source = core.Source;
                    }
                }
            }
        }
        private void p1t5e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap1.Source;
            var cartamano = p1m1.Source;
            var cartamano2 = p1m2.Source;
            var cartamano3 = p1m3.Source;
            var cartamano4 = p1m4.Source;
            var cartamano5 = p1m5.Source;
            var cartamano6 = p1m6.Source;
            var cartamano7 = p1m7.Source;
            var cartamano8 = p1m8.Source;
            var cartamano9 = p1m9.Source;
            var cartamano10 = p1m10.Source;
            var cartatablero = p1t2.Source;

            if (cte == true)
            {
                if (p1m1.Source != p1t5.Source)
                {
                    p1t5.Source = cartamano;
                    p1m1.Source = cartaoriginal;
                    p1t5.IsEnabled = true;
                    if (p1t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "2";
                        vidap1t5.Content = " 1";
                        p1t5.Source = murloc.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 1";
                        vidap1t5.Content = "1";
                        p1t5.Source = wisp.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 2";
                        vidap1t5.Content = "3";
                        p1t5.Source = cocodrilo.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 3";
                        vidap1t5.Content = "2";
                        p1t5.Source = raptor.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "5";
                        vidap1t5.Content = "1";
                        p1t5.Source = magmar.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "4";
                        vidap1t5.Content = "5";
                        p1t4.Source = yeti.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "6";
                        vidap1t5.Content = "7";
                        p1t5.Source = ogro.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "7";
                        vidap1t5.Content = "7";
                        p1t5.Source = golem.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "7";
                        p1t5.Source = oasis.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "9";
                        vidap1t5.Content = "5";
                        p1t5.Source = core.Source;
                    }
                }


            }
            if (cte2 == true)
            {
                if (p1m2.Source != p1t5.Source)
                {
                    p1t5.Source = cartamano2;
                    p1m2.Source = cartaoriginal;
                    p1t5.IsEnabled = true;
                    if (p1t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "1";
                        p1t5.Source = murloc.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 1";
                        vidap1t5.Content = "1";
                        p1t5.Source = wisp.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 2";
                        vidap1t5.Content = "3";
                        p1t5.Source = cocodrilo.Source;




                    }
                    else if (p1t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 3";
                        vidap1t5.Content = "2";
                        p1t5.Source = raptor.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "5";
                        vidap1t5.Content = "1";
                        p1t5.Source = magmar.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "4";
                        vidap1t5.Content = "5";
                        p1t5.Source = yeti.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "6";
                        vidap1t5.Content = "7";
                        p1t5.Source = ogro.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "7";
                        vidap1t5.Content = "7";
                        p1t5.Source = golem.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "7";
                        p1t5.Source = oasis.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "9";
                        vidap1t5.Content = "5";
                        p1t5.Source = core.Source;
                    }
                }
            }
            if (cte3 == true)
            {
                if (p1m3.Source != p1t5.Source)
                {
                    p1t5.Source = cartamano3;
                    p1m3.Source = cartaoriginal;
                    p1t5.IsEnabled = true;
                    if (p1t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "1";
                        p1t5.Source = murloc.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 1";
                        vidap1t5.Content = "1";
                        p1t5.Source = wisp.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 2";
                        vidap1t5.Content = "3";
                        p1t5.Source = cocodrilo.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 3";
                        vidap1t5.Content = "2";
                        p1t5.Source = raptor.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "5";
                        vidap1t5.Content = "1";
                        p1t5.Source = magmar.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "4";
                        vidap1t5.Content = "5";
                        p1t5.Source = yeti.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "6";
                        vidap1t5.Content = "7";
                        p1t5.Source = ogro.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "7";
                        vidap1t5.Content = "7";
                        p1t5.Source = golem.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "7";
                        p1t5.Source = oasis.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "9";
                        vidap1t5.Content = "5";
                        p1t5.Source = core.Source;
                    }
                }
            }
            if (cte4 == true)
            {
                if (p1m4.Source != p1t5.Source)
                {
                    p1t5.Source = cartamano4;
                    p1m4.Source = cartaoriginal;
                    p1t5.IsEnabled = true;
                    if (p1t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "1";
                        p1t5.Source = murloc.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 1";
                        vidap1t5.Content = "1";
                        p1t5.Source = wisp.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 2";
                        vidap1t5.Content = "3";
                        p1t5.Source = cocodrilo.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 3";
                        vidap1t5.Content = "2";
                        p1t5.Source = raptor.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "5";
                        vidap1t5.Content = "1";
                        p1t5.Source = magmar.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "4";
                        vidap1t5.Content = "5";
                        p1t5.Source = yeti.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "6";
                        vidap1t5.Content = "7";
                        p1t5.Source = ogro.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "7";
                        vidap1t5.Content = "7";
                        p1t5.Source = golem.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "7";
                        p1t5.Source = oasis.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "9";
                        vidap1t5.Content = "5";
                        p1t5.Source = core.Source;
                    }
                }
            }
            if (cte5 == true)
            {
                if (p1m5.Source != p1t5.Source)
                {
                    p1t5.Source = cartamano5;
                    p1m5.Source = cartaoriginal;
                    p1t5.IsEnabled = true;
                    if (p1t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "1";
                        p1t5.Source = murloc.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 1";
                        vidap1t5.Content = "1";
                        p1t5.Source = wisp.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 2";
                        vidap1t5.Content = "3";
                        p1t5.Source = cocodrilo.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 3";
                        vidap1t5.Content = "2";
                        p1t5.Source = raptor.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "5";
                        vidap1t5.Content = "1";
                        p1t5.Source = magmar.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "4";
                        vidap1t5.Content = "5";
                        p1t5.Source = yeti.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "6";
                        vidap1t5.Content = "7";
                        p1t5.Source = ogro.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "7";
                        vidap1t5.Content = "7";
                        p1t5.Source = golem.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "7";
                        p1t5.Source = oasis.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "9";
                        vidap1t5.Content = "5";
                        p1t5.Source = core.Source;
                    }
                }
            }
            if (cte6 == true)
            {
                if (p1m6.Source != p1t5.Source)
                {
                    p1t5.Source = cartamano6;
                    p1m6.Source = cartaoriginal;
                    p1t5.IsEnabled = true;
                    if (p1t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "1";
                        p1t5.Source = murloc.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 1";
                        vidap1t5.Content = "1";
                        p1t5.Source = wisp.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 2";
                        vidap1t5.Content = "3";
                        p1t5.Source = cocodrilo.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 3";
                        vidap1t5.Content = "2";
                        p1t5.Source = raptor.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "5";
                        vidap1t5.Content = "1";
                        p1t5.Source = magmar.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "4";
                        vidap1t5.Content = "5";
                        p1t5.Source = yeti.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "6";
                        vidap1t5.Content = "7";
                        p1t5.Source = ogro.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "7";
                        vidap1t5.Content = "7";
                        p1t5.Source = golem.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "7";
                        p1t5.Source = oasis.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "9";
                        vidap1t5.Content = "5";
                        p1t5.Source = core.Source;
                    }
                }
            }
            if (cte7 == true)
            {
                if (p1m3.Source != p1t5.Source)
                {
                    p1t5.Source = cartamano7;
                    p1m7.Source = cartaoriginal;
                    p1t5.IsEnabled = true;
                    if (p1t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "1";
                        p1t5.Source = murloc.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 1";
                        vidap1t5.Content = "1";
                        p1t5.Source = wisp.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 2";
                        vidap1t5.Content = "3";
                        p1t5.Source = cocodrilo.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 3";
                        vidap1t5.Content = "2";
                        p1t5.Source = raptor.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "5";
                        vidap1t5.Content = "1";
                        p1t5.Source = magmar.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "4";
                        vidap1t5.Content = "5";
                        p1t5.Source = yeti.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "6";
                        vidap1t5.Content = "7";
                        p1t5.Source = ogro.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "7";
                        vidap1t5.Content = "7";
                        p1t5.Source = golem.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "7";
                        p1t5.Source = oasis.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "9";
                        vidap1t5.Content = "5";
                        p1t5.Source = core.Source;
                    }
                }
            }
            if (cte8 == true)
            {
                if (p1m8.Source != p1t5.Source)
                {
                    p1t5.Source = cartamano8;
                    p1m8.Source = cartaoriginal;
                    p1t5.IsEnabled = true;
                    if (p1t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "1";
                        p1t5.Source = murloc.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 1";
                        vidap1t5.Content = "1";
                        p1t5.Source = wisp.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 2";
                        vidap1t5.Content = "3";
                        p1t5.Source = cocodrilo.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 3";
                        vidap1t5.Content = "2";
                        p1t5.Source = raptor.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "5";
                        vidap1t5.Content = "1";
                        p1t5.Source = magmar.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "4";
                        vidap1t5.Content = "5";
                        p1t5.Source = yeti.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "6";
                        vidap1t5.Content = "7";
                        p1t5.Source = ogro.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "7";
                        vidap1t5.Content = "7";
                        p1t5.Source = golem.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "7";
                        p1t5.Source = oasis.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "9";
                        vidap1t5.Content = "5";
                        p1t5.Source = core.Source;
                    }
                }
            }
            if (cte9 == true)
            {
                if (p1m9.Source != p1t5.Source)
                {
                    p1t5.Source = cartamano9;
                    p1m9.Source = cartaoriginal;
                    p1t5.IsEnabled = true;
                    if (p1t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "1";
                        p1t5.Source = murloc.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 1";
                        vidap1t5.Content = "1";
                        p1t5.Source = wisp.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 2";
                        vidap1t5.Content = "3";
                        p1t5.Source = cocodrilo.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 3";
                        vidap1t5.Content = "2";
                        p1t5.Source = raptor.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "5";
                        vidap1t5.Content = "1";
                        p1t5.Source = magmar.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "4";
                        vidap1t5.Content = "5";
                        p1t5.Source = yeti.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "6";
                        vidap1t5.Content = "7";
                        p1t5.Source = ogro.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "7";
                        vidap1t5.Content = "7";
                        p1t5.Source = golem.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "7";
                        p1t5.Source = oasis.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "9";
                        vidap1t5.Content = "5";
                        p1t5.Source = core.Source;
                    }
                }
            }
            if (cte10 == true)
            {
                if (p1m10.Source != p1t5.Source)
                {
                    p1t5.Source = cartamano10;
                    p1m10.Source = cartaoriginal;
                    p1t5.IsEnabled = true;
                    if (p1t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "1";
                        p1t5.Source = murloc.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 1";
                        vidap1t5.Content = "1";
                        p1t5.Source = wisp.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 2";
                        vidap1t5.Content = "3";
                        p1t5.Source = cocodrilo.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = " 3";
                        vidap1t5.Content = "2";
                        p1t5.Source = raptor.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "5";
                        vidap1t5.Content = "1";
                        p1t5.Source = magmar.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "4";
                        vidap1t5.Content = "5";
                        p1t5.Source = yeti.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "6";
                        vidap1t5.Content = "7";
                        p1t5.Source = ogro.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "7";
                        vidap1t5.Content = "7";
                        p1t5.Source = golem.Source;

                    }
                    else if (p1t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "2";
                        vidap1t5.Content = "7";
                        p1t5.Source = oasis.Source;
                    }
                    else if (p1t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t5.Content = "9";
                        vidap1t5.Content = "5";
                        p1t5.Source = core.Source;
                    }
                }
            }
        }
        private void p1t6e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap1.Source;
            var cartamano = p1m1.Source;
            var cartamano2 = p1m2.Source;
            var cartamano3 = p1m3.Source;
            var cartamano4 = p1m4.Source;
            var cartamano5 = p1m5.Source;
            var cartamano6 = p1m6.Source;
            var cartamano7 = p1m7.Source;
            var cartamano8 = p1m8.Source;
            var cartamano9 = p1m9.Source;
            var cartamano10 = p1m10.Source;
            var cartatablero = p1t6.Source;

            if (cte == true)
            {
                if (p1m1.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano;
                    p1m1.Source = cartaoriginal;
                    p1t6.IsEnabled = true;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";
                        p1t6.Source = murloc.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";
                        p1t6.Source = wisp.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";
                        p1t6.Source = cocodrilo.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";
                        p1t6.Source = raptor.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";
                        p1t6.Source = magmar.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";
                        p1t6.Source = yeti.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";
                        p1t6.Source = ogro.Source;


                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";
                        p1t6.Source = golem.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                        p1t6.Source = oasis.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                        p1t6.Source = core.Source;
                    }
                }


            }
            if (cte2 == true)
            {
                if (p1m2.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano2;
                    p1m2.Source = cartaoriginal;
                    p1t6.IsEnabled = true;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";
                        p1t6.Source = murloc.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";
                        p1t6.Source = wisp.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";
                        p1t6.Source = cocodrilo.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";
                        p1t6.Source = raptor.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";
                        p1t6.Source = magmar.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";
                        p1t6.Source = yeti.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";
                        p1t6.Source = ogro.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";
                        p1t6.Source = golem.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                        p1t6.Source = oasis.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                        p1t6.Source = core.Source;
                    }
                }
            }
            if (cte3 == true)
            {
                if (p1m3.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano3;
                    p1m3.Source = cartaoriginal;
                    p1t6.IsEnabled = true;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";
                        p1t6.Source = murloc.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";
                        p1t6.Source = wisp.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";
                        p1t6.Source = cocodrilo.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";
                        p1t6.Source = raptor.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";
                        p1t6.Source = magmar.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";
                        p1t6.Source = yeti.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";
                        p1t6.Source = ogro.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";
                        p1t6.Source = golem.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                        p1t6.Source = oasis.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                        p1t6.Source = core.Source;
                    }
                }
            }
            if (cte4 == true)
            {
                if (p1m4.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano4;
                    p1m4.Source = cartaoriginal;
                    p1t6.IsEnabled = true;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";
                        p1t6.Source = murloc.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";
                        p1t6.Source = wisp.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";
                        p1t6.Source = cocodrilo.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";
                        p1t6.Source = raptor.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";
                        p1t6.Source = magmar.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";
                        p1t6.Source = yeti.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";
                        p1t6.Source = ogro.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";
                        p1t6.Source = golem.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                        p1t6.Source = oasis.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                        p1t6.Source = core.Source;
                    }
                }
            }
            if (cte5 == true)
            {
                if (p1m5.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano5;
                    p1m5.Source = cartaoriginal;
                    p1t6.IsEnabled = true;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";
                        p1t6.Source = murloc.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";
                        p1t6.Source = wisp.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";
                        p1t6.Source = cocodrilo.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";
                        p1t6.Source = raptor.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";
                        p1t6.Source = magmar.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";
                        p1t6.Source = yeti.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";
                        p1t6.Source = ogro.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";
                        p1t6.Source = golem.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                        p1t6.Source = oasis.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                        p1t6.Source = core.Source;
                    }
                }
            }
            if (cte6 == true)
            {
                if (p1m6.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano6;
                    p1m6.Source = cartaoriginal;
                    p1t6.IsEnabled = true;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";
                        p1t6.Source = murloc.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";
                        p1t6.Source = wisp.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";
                        p1t6.Source = cocodrilo.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";
                        p1t6.Source = raptor.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";
                        p1t6.Source = magmar.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";
                        p1t6.Source = yeti.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";
                        p1t6.Source = ogro.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";
                        p1t6.Source = golem.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                        p1t6.Source = oasis.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                        p1t6.Source = core.Source;
                    }
                }
            }
            if (cte7 == true)
            {
                if (p1m3.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano7;
                    p1m7.Source = cartaoriginal;
                    p1t6.IsEnabled = true;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";
                        p1t6.Source = murloc.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";
                        p1t6.Source = wisp.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";
                        p1t6.Source = cocodrilo.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";
                        p1t6.Source = raptor.Source;

                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";
                        p1t6.Source = magmar.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";
                        p1t6.Source = yeti.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";
                        p1t6.Source = ogro.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";
                        p1t6.Source = golem.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                        p1t6.Source = oasis.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                        p1t6.Source = core.Source;
                    }
                }
            }
            if (cte8 == true)
            {
                if (p1m8.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano8;
                    p1m8.Source = cartaoriginal;
                    p1t6.IsEnabled = true;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";
                        p1t6.Source = murloc.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";
                        p1t6.Source = wisp.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";
                        p1t6.Source = cocodrilo.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";
                        p1t6.Source = raptor.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";
                        p1t6.Source = magmar.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";
                        p1t6.Source = yeti.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";
                        p1t6.Source = ogro.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";
                        p1t6.Source = golem.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                        p1t6.Source = oasis.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                        p1t6.Source = core.Source;
                    }
                }
            }
            if (cte9 == true)
            {
                if (p1m9.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano9;
                    p1m9.Source = cartaoriginal;
                    p1t6.IsEnabled = true;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";
                        p1t6.Source = murloc.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";
                        p1t6.Source = wisp.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";
                        p1t6.Source = cocodrilo.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";
                        p1t6.Source = raptor.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";
                        p1t6.Source = magmar.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";
                        p1t6.Source = yeti.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";
                        p1t6.Source = ogro.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";
                        p1t6.Source = golem.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                        p1t6.Source = oasis.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                        p1t6.Source = core.Source;
                    }
                }
            }
            if (cte10 == true)
            {
                if (p1m10.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano10;
                    p1m10.Source = cartaoriginal;
                    p1t6.IsEnabled = true;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";
                        p1t6.Source = murloc.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";
                        p1t6.Source = wisp.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";
                        p1t6.Source = cocodrilo.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";
                        p1t6.Source = raptor.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";
                        p1t6.Source = magmar.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";
                        p1t6.Source = yeti.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";
                        p1t6.Source = ogro.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";
                        p1t6.Source = golem.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                        p1t6.Source = oasis.Source;
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                        p1t6.Source = core.Source;
                    }
                }
            }
        }
        private void p1t7e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap1.Source;
            var cartamano = p1m1.Source;
            var cartamano2 = p1m2.Source;
            var cartamano3 = p1m3.Source;
            var cartamano4 = p1m4.Source;
            var cartamano5 = p1m5.Source;
            var cartamano6 = p1m6.Source;
            var cartamano7 = p1m7.Source;
            var cartamano8 = p1m8.Source;
            var cartamano9 = p1m9.Source;
            var cartamano10 = p1m10.Source;
            var cartatablero = p1t7.Source;

            if (cte == true)
            {
                if (p1m1.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano;
                    p1m1.Source = cartaoriginal;
                    p1t7.IsEnabled = true;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";
                        p1t7.Source = murloc.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";
                        p1t7.Source = wisp.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";
                        p1t7.Source = cocodrilo.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";
                        p1t7.Source = raptor.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";
                        p1t7.Source = magmar.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";
                        p1t7.Source = yeti.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";
                        p1t7.Source = ogro.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";
                        p1t7.Source = golem.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                        p1t7.Source = oasis.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                        p1t7.Source = core.Source;
                    }
                }


            }
            if (cte2 == true)
            {
                if (p1m2.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano2;
                    p1m2.Source = cartaoriginal;
                    p1t7.IsEnabled = true;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";
                        p1t7.Source = murloc.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";
                        p1t7.Source = wisp.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";
                        p1t7.Source = cocodrilo.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";
                        p1t7.Source = raptor.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";
                        p1t7.Source = magmar.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";
                        p1t7.Source = yeti.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";
                        p1t7.Source = ogro.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";
                        p1t7.Source = golem.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                        p1t7.Source = oasis.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                        p1t7.Source = core.Source;
                    }
                }
            }
            if (cte3 == true)
            {
                if (p1m3.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano3;
                    p1m3.Source = cartaoriginal;
                    p1t7.IsEnabled = true;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";
                        p1t7.Source = murloc.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";
                        p1t7.Source = wisp.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";
                        p1t7.Source = cocodrilo.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";
                        p1t7.Source = raptor.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";
                        p1t7.Source = magmar.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";
                        p1t7.Source = yeti.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";
                        p1t7.Source = ogro.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";
                        p1t7.Source = golem.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                        p1t7.Source = oasis.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                        p1t7.Source = core.Source;
                    }
                }
            }
            if (cte4 == true)
            {
                if (p1m4.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano4;
                    p1m4.Source = cartaoriginal;
                    p1t7.IsEnabled = true;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";
                        p1t7.Source = murloc.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";
                        p1t7.Source = wisp.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";
                        p1t7.Source = cocodrilo.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";
                        p1t7.Source = raptor.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";
                        p1t7.Source = magmar.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";
                        p1t7.Source = yeti.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";
                        p1t7.Source = ogro.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";
                        p1t7.Source = golem.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                        p1t7.Source = oasis.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                        p1t7.Source = core.Source;
                    }
                }
            }
            if (cte5 == true)
            {
                if (p1m5.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano5;
                    p1m5.Source = cartaoriginal;
                    p1t7.IsEnabled = true;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";
                        p1t7.Source = murloc.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";
                        p1t7.Source = wisp.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";
                        p1t7.Source = cocodrilo.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";
                        p1t7.Source = raptor.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";
                        p1t7.Source = magmar.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";
                        p1t7.Source = yeti.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";
                        p1t7.Source = ogro.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";
                        p1t7.Source = golem.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                        p1t7.Source = oasis.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                        p1t7.Source = core.Source;
                    }
                }
            }
            if (cte6 == true)
            {
                if (p1m6.Source != p1t2.Source)
                {
                    p1t2.Source = cartamano6;
                    p1m6.Source = cartaoriginal;
                    p1t2.IsEnabled = true;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";
                        p1t7.Source = murloc.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";
                        p1t7.Source = wisp.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";
                        p1t7.Source = cocodrilo.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";
                        p1t7.Source = raptor.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";
                        p1t7.Source = magmar.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";
                        p1t7.Source = yeti.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";
                        p1t7.Source = ogro.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";
                        p1t7.Source = golem.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                        p1t7.Source = oasis.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                        p1t7.Source = core.Source;
                    }
                }
            }
            if (cte7 == true)
            {
                if (p1m3.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano7;
                    p1m7.Source = cartaoriginal;
                    p1t7.IsEnabled = true;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";
                        p1t7.Source = murloc.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";
                        p1t7.Source = wisp.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";
                        p1t7.Source = cocodrilo.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";
                        p1t7.Source = raptor.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";
                        p1t7.Source = magmar.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";
                        p1t7.Source = yeti.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";
                        p1t7.Source = ogro.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";
                        p1t7.Source = golem.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                        p1t7.Source = oasis.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                        p1t7.Source = core.Source;
                    }
                }
            }
            if (cte8 == true)
            {
                if (p1m8.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano8;
                    p1m8.Source = cartaoriginal;
                    p1t7.IsEnabled = true;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";
                        p1t7.Source = murloc.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";
                        p1t7.Source = wisp.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";
                        p1t7.Source = cocodrilo.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";
                        p1t7.Source = raptor.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";
                        p1t7.Source = magmar.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";
                        p1t7.Source = yeti.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";
                        p1t7.Source = ogro.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";
                        p1t7.Source = golem.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                        p1t7.Source = oasis.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                        p1t7.Source = core.Source;
                    }
                }
            }
            if (cte9 == true)
            {
                if (p1m9.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano9;
                    p1m9.Source = cartaoriginal;
                    p1t7.IsEnabled = true;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";
                        p1t7.Source = murloc.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";
                        p1t7.Source = wisp.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";
                        p1t7.Source = cocodrilo.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";
                        p1t7.Source = raptor.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";
                        p1t7.Source = magmar.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";
                        p1t7.Source = yeti.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";
                        p1t7.Source = ogro.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";
                        p1t7.Source = golem.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                        p1t7.Source = oasis.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                        p1t7.Source = core.Source;
                    }
                }
            }
            if (cte10 == true)
            {
                if (p1m10.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano10;
                    p1m10.Source = cartaoriginal;
                    p1t7.IsEnabled = true;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";
                        p1t7.Source = murloc.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";
                        p1t7.Source = wisp.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";
                        p1t7.Source = cocodrilo.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";
                        p1t7.Source = raptor.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";
                        p1t7.Source = magmar.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";
                        p1t7.Source = yeti.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";
                        p1t7.Source = ogro.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";
                        p1t7.Source = golem.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                        p1t7.Source = oasis.Source;
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                        p1t7.Source = core.Source;
                    }
                }
            }
        }
    
        // Hasta aca metodos de invocar jugador 1

        // Desde aca metodos invocar jugador 2
        private void p2m1e(object sender, MouseButtonEventArgs e)
        {
            cte_ = true;
        }
        private void p2m2e(object sender, MouseButtonEventArgs e)
        {
            cte2_ = true;
        }
        private void p2m3e(object sender, MouseButtonEventArgs e)
        {
            cte3_ = true;
        }
        private void p2m4e(object sender, MouseButtonEventArgs e)
        {
            cte4_ = true;
        }
        private void p2m5e(object sender, MouseButtonEventArgs e)
        {
            cte5_ = true;
        }
        private void p2m6e(object sender, MouseButtonEventArgs e)
        {
            cte6_ = true;
        }
        private void p2m7e(object sender, MouseButtonEventArgs e)
        {
            cte7_ = true;
        }
        private void p2m8e(object sender, MouseButtonEventArgs e)
        {
            cte8_ = true;
        }
        private void p2m9e(object sender, MouseButtonEventArgs e)
        {
            cte9_ = true;
        }
        private void p2m10e(object sender, MouseButtonEventArgs e)
        {
            cte10_ = true;
        }
        private void p2t1e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap2.Source;
            var cartamano = p2m1.Source;
            var cartamano2 = p2m2.Source;
            var cartamano3 = p2m3.Source;
            var cartamano4 = p2m4.Source;
            var cartamano5 = p2m5.Source;
            var cartamano6 = p2m6.Source;
            var cartamano7 = p2m7.Source;
            var cartamano8 = p2m8.Source;
            var cartamano9 = p2m9.Source;
            var cartamano10 = p2m10.Source;
            var cartatablero = p2t1.Source;
            //string
            //Jugador p2 = new Jugador(jugador1, 1, 0, m.mazito, 0, 0, Hunter1);
            //p2m1.Source = new BitmapImage(new Uri(p2.SacarCarta(m).Source));

            // Cualquier carta se puede invocar en la primera posicion del tablero 

            if (cte_ == true)
            {

                if (p2m1.Source != p2t1.Source)
                {
                    p2t1.Source = cartamano;
                    p2m1.Source = cartaoriginal;
                    p2t1.IsEnabled = true;
                    cte_ = false;
                    if (p2t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep2t1.Content = "2";
                        vidap2t1.Content = "1";
                        p2t1.Source = murloc.Source;
                        

                    }
                    else if (p2t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep2t1.Content = " 1";
                        vidap2t1.Content = "1";
                        p2t1.Source = wisp.Source;
                        
                    }
                    else if (p2t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep2t1.Content = " 2";
                        vidap2t1.Content = "3";
                        p2t1.Source = cocodrilo.Source;
                     
                    }
                    else if (p2t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep2t1.Content = " 3";
                        vidap2t1.Content = "2";
                        p2t1.Source = raptor.Source;
                       
                    }
                    else if (p2t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep2t1.Content = "5";
                        vidap2t1.Content = "1";
                        p2t1.Source = magmar.Source;
                       
                    }
                    else if (p2t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep2t1.Content = "4";
                        vidap2t1.Content = "5";
                        p2t1.Source = yeti.Source;
                       
                    }
                    else if (p2t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep2t1.Content = "6";
                        vidap2t1.Content = "7";
                        p2t1.Source = ogro.Source;
                      
                    }
                    else if (p2t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep2t1.Content = "7";
                        vidap2t1.Content = "7";
                        p2t1.Source = golem.Source;
                      
                    }
                    else if (p2t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep2t1.Content = "2";
                        vidap2t1.Content = "7";
                        p2t1.Source = oasis.Source;
                      
                    }
                    else if (p2t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep2t1.Content = "9";
                        vidap2t1.Content = "5";
                        p2t1.Source = core.Source;
                        
                    }


                }
                if (cte2_ == true)
                {
                    if (p2m2.Source != p2t1.Source)
                    {
                        p2t1.Source = cartamano2;
                        p2m2.Source = cartaoriginal;
                        p2t1.IsEnabled = false;
                        cte2_ = false;
                        if (p2t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "2";
                            vidap2t1.Content = " 1";
                            p2t1.Source = murloc.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 1";
                            vidap2t1.Content = "1";
                            p2t1.Source = wisp.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 2";
                            vidap2t1.Content = "3";

                        }
                        else if (p2t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 3";
                            vidap2t1.Content = "2";
                            p2t1.Source = raptor.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "5";
                            vidap2t1.Content = "1";
                            p2t1.Source = magmar.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "4";
                            vidap2t1.Content = "5";
                            p2t1.Source = yeti.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "6";
                            vidap2t1.Content = "7";
                            p2t1.Source = ogro.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "7";
                            vidap2t1.Content = "7";
                            p2t1.Source = golem.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "7";
                            p2t1.Source = oasis.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "9";
                            vidap2t1.Content = "5";
                            p2t1.Source = core.Source;
                        }
                    }
                }
                if (cte3_ == true)
                {
                    if (p2m3.Source != p2t1.Source)
                    {
                        p2t1.Source = cartamano3;
                        p2m3.Source = cartaoriginal;
                        p2t1.IsEnabled = false;

                        if (p2t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 2";
                            vidap2t1.Content = "1";
                            p2t1.Source = murloc.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 1";
                            vidap2t1.Content = "1";
                            p2t1.Source = wisp.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 2";
                            vidap2t1.Content = "3";
                            p2t1.Source = cocodrilo.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 3";
                            vidap2t1.Content = "2";
                            p2t1.Source = raptor.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "5";
                            vidap2t1.Content = "1";
                            p2t1.Source = magmar.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "4";
                            vidap2t1.Content = "5";
                            p2t1.Source = yeti.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "6";
                            vidap2t1.Content = "7";
                            p2t1.Source = ogro.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "7";
                            vidap2t1.Content = "7";
                            p2t1.Source = golem.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "7";
                            p2t1.Source = oasis.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "9";
                            vidap2t1.Content = "5";
                            p2t1.Source = core.Source;
                        }
                    }
                }
                if (cte4_ == true)
                {
                    if (p2m4.Source != p2t1.Source)
                    {
                        p2t1.Source = cartamano4;
                        p2m4.Source = cartaoriginal;
                        p2t1.IsEnabled = false;

                        if (p2t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "2";
                            vidap2t1.Content = " 1";
                            p2t1.Source = murloc.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 1";
                            vidap2t1.Content = "1";
                            p2t1.Source = wisp.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 2";
                            vidap2t1.Content = "3";
                            p2t1.Source = cocodrilo.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 3";
                            vidap2t1.Content = "2";
                            p2t1.Source = raptor.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "5";
                            vidap2t1.Content = "1";

                        }
                        else if (p2t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "4";
                            vidap2t1.Content = "5";
                            p2t1.Source = yeti.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "6";
                            vidap2t1.Content = "7";
                            p2t1.Source = ogro.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "7";
                            vidap2t1.Content = "7";
                            p2t1.Source = golem.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "7";
                            p2t1.Source = oasis.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "9";
                            vidap2t1.Content = "5";
                            p2t1.Source = core.Source;
                        }
                    }
                }
                if (cte5_ == true)
                {
                    if (p2m5.Source != p2t1.Source)
                    {
                        p2t1.Source = cartamano5;
                        p2m5.Source = cartaoriginal;
                        p2t1.IsEnabled = false;
                        if (p2t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "1";
                            p2t1.Source = murloc.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 1";
                            vidap2t1.Content = "1";
                            p2t1.Source = wisp.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 2";
                            vidap2t1.Content = "3";
                            p2t1.Source = cocodrilo.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 3";
                            vidap2t1.Content = "2";
                            p2t1.Source = raptor.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "5";
                            vidap2t1.Content = "1";
                            p2t1.Source = magmar.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "4";
                            vidap2t1.Content = "5";
                            p2t1.Source = yeti.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "6";
                            vidap2t1.Content = "7";
                            p2t1.Source = ogro.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "7";
                            vidap2t1.Content = "7";
                            p2t1.Source = golem.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "7";
                            p2t1.Source = oasis.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "9";
                            vidap2t1.Content = "5";
                            p2t1.Source = core.Source;
                        }
                    }
                }
                if (cte6_ == true)
                {
                    if (p2m6.Source != p2t1.Source)
                    {
                        p2t1.Source = cartamano6;
                        p2m6.Source = cartaoriginal;
                        p2t1.IsEnabled = false;
                        if (p2t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "1";
                            p2t1.Source = murloc.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 1";
                            vidap2t1.Content = "1";
                            p2t1.Source = wisp.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 2";
                            vidap2t1.Content = "3";
                            p2t1.Source = cocodrilo.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 3";
                            vidap2t1.Content = "2";
                            p2t1.Source = raptor.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "5";
                            vidap2t1.Content = "1";
                            p2t1.Source = magmar.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "4";
                            vidap2t1.Content = "5";
                            p2t1.Source = yeti.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "6";
                            vidap2t1.Content = "7";
                            p2t1.Source = ogro.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "7";
                            vidap2t1.Content = "7";
                            p2t1.Source = golem.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "7";
                            p2t1.Source = oasis.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "9";
                            vidap2t1.Content = "5";
                            p2t1.Source = core.Source;
                        }
                    }
                }
                if (cte7_ == true)
                {
                    if (p2m3.Source != p2t1.Source)
                    {
                        p2t1.Source = cartamano7;
                        p2m7.Source = cartaoriginal;
                        p2t1.IsEnabled = false;
                        if (p2t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "1";
                            p2t1.Source = murloc.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 1";
                            vidap2t1.Content = "1";
                            p2t1.Source = wisp.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 2";
                            vidap2t1.Content = "3";
                            p2t1.Source = cocodrilo.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 3";
                            vidap2t1.Content = "2";
                            p2t1.Source = raptor.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "5";
                            vidap2t1.Content = "1";
                            p2t1.Source = magmar.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "4";
                            vidap2t1.Content = "5";
                            p2t1.Source = yeti.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "6";
                            vidap2t1.Content = "7";
                            p2t1.Source = ogro.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "7";
                            vidap2t1.Content = "7";
                            p2t1.Source = golem.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "7";
                            p2t1.Source = oasis.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "9";
                            vidap2t1.Content = "5";
                            p2t1.Source = core.Source;
                        }
                    }
                }
                if (cte8_ == true)
                {
                    if (p2m8.Source != p2t1.Source)
                    {
                        p2t1.Source = cartamano8;
                        p2m8.Source = cartaoriginal;
                        p2t1.IsEnabled = false;
                        if (p2t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "1";
                            p2t1.Source = murloc.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 1";
                            vidap2t1.Content = "1";
                            p2t1.Source = wisp.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 2";
                            vidap2t1.Content = "3";
                            p2t1.Source = cocodrilo.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 3";
                            vidap2t1.Content = "2";
                            p2t1.Source = raptor.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "5";
                            vidap2t1.Content = "1";
                            p2t1.Source = magmar.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "4";
                            vidap2t1.Content = "5";
                            p2t1.Source = yeti.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "6";
                            vidap2t1.Content = "7";
                            p2t1.Source = ogro.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "7";
                            vidap2t1.Content = "7";
                            p2t1.Source = golem.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "7";
                            p2t1.Source = oasis.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "9";
                            vidap2t1.Content = "5";
                            p2t1.Source = core.Source;
                        }
                    }
                }
                if (cte9_ == true)
                {
                    if (p2m9.Source != p2t1.Source)
                    {
                        p2t1.Source = cartamano9;
                        p2m9.Source = cartaoriginal;
                        p2t1.IsEnabled = false;
                        if (p2t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "1";
                            p2t1.Source = murloc.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 1";
                            vidap2t1.Content = "1";
                            p2t1.Source = wisp.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 2";
                            vidap2t1.Content = "3";
                            p2t1.Source = cocodrilo.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 3";
                            vidap2t1.Content = "2";
                            p2t1.Source = raptor.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "5";
                            vidap2t1.Content = "1";
                            p2t1.Source = magmar.Source;


                        }
                        else if (p2t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "4";
                            vidap2t1.Content = "5";
                            p2t1.Source = yeti.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "6";
                            vidap2t1.Content = "7";
                            p2t1.Source = ogro.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "7";
                            vidap2t1.Content = "7";
                            p2t1.Source = golem.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "7";
                            p2t1.Source = oasis.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "9";
                            vidap2t1.Content = "5";
                            p2t1.Source = core.Source;
                        }
                    }
                }
                if (cte10_ == true)
                {
                    if (p2m10.Source != p2t1.Source)
                    {
                        p2t1.Source = cartamano10;
                        p2m10.Source = cartaoriginal;
                        p2t1.IsEnabled = false;
                        if (p2t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "2";
                            vidap2t1.Content = " 1";
                            p2t1.Source = murloc.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 1";
                            vidap2t1.Content = "1";
                            p2t1.Source = wisp.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 2";
                            vidap2t1.Content = "3";
                            p2t1.Source = cocodrilo.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = " 3";
                            vidap2t1.Content = "2";
                            p2t1.Source = raptor.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "5";
                            vidap2t1.Content = "1";
                            p2t1.Source = magmar.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "4";
                            vidap2t1.Content = "5";
                            p2t1.Source = yeti.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "6";
                            vidap2t1.Content = "7";
                            p2t1.Source = ogro.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t1.Content = "7";
                            vidap2t1.Content = "7";
                            p2t1.Source = golem.Source;

                        }
                        else if (p2t1.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "2";
                            vidap2t1.Content = "7";
                            p2t1.Source = oasis.Source;
                        }
                        else if (p2t1.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t1.Content = "9";
                            vidap2t1.Content = "5";
                            p2t1.Source = core.Source;
                        }
                    }
                }
            }
        }
        private void p2t2e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap2.Source;
            var cartamano = p2m1.Source;
            var cartamano2 = p2m2.Source;
            var cartamano3 = p2m3.Source;
            var cartamano4 = p2m4.Source;
            var cartamano5 = p2m5.Source;
            var cartamano6 = p2m6.Source;
            var cartamano7 = p2m7.Source;
            var cartamano8 = p2m8.Source;
            var cartamano9 = p2m9.Source;
            var cartamano10 = p2m10.Source;
            var cartatablero = p2t2.Source;

            if (cte_ == true)
            {

                if (p2m1.Source != p2t2.Source)
                {
                    p2t2.Source = cartamano;
                    p2m1.Source = cartaoriginal;
                    p2t2.IsEnabled = false;
                    if (p2t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep2t2.Content = "2";
                        vidap2t2.Content = "1";
                        p2t2.Source = murloc.Source;

                    }
                    else if (p2t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep2t2.Content = " 1";
                        vidap2t2.Content = "1";
                        p2t2.Source = wisp.Source;

                    }
                    else if (p2t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep2t2.Content = " 2";
                        vidap2t2.Content = "3";
                        p2t2.Source = cocodrilo.Source;

                    }
                    else if (p2t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep2t2.Content = " 3";
                        vidap2t2.Content = "2";
                        p2t2.Source = raptor.Source;

                    }
                    else if (p2t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep2t2.Content = "5";
                        vidap2t2.Content = "1";
                        p2t2.Source = magmar.Source;

                    }
                    else if (p2t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep2t2.Content = "4";
                        vidap2t2.Content = "5";
                        p2t2.Source = yeti.Source;

                    }
                    else if (p2t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep2t2.Content = "6";
                        vidap2t2.Content = "7";
                        p2t2.Source = ogro.Source;

                    }
                    else if (p2t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep2t2.Content = "7";
                        vidap2t2.Content = "7";
                        p2t2.Source = golem.Source;

                    }
                    else if (p2t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep2t2.Content = "2";
                        vidap2t2.Content = "7";
                        p2t2.Source = oasis.Source;
                    }
                    else if (p2t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep2t2.Content = "9";
                        vidap2t2.Content = "5";
                        p2t2.Source = core.Source;
                    }


                }
                if (cte2_ == true)
                {
                    if (p2m2.Source != p2t2.Source)
                    {
                        p2t2.Source = cartamano2;
                        p2m2.Source = cartaoriginal;
                        p2t2.IsEnabled = false;
                        if (p2t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "2";
                            vidap2t2.Content = " 1";
                            p2t2.Source = murloc.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 1";
                            vidap2t2.Content = "1";
                            p2t2.Source = wisp.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 2";
                            vidap2t2.Content = "3";

                        }
                        else if (p2t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 3";
                            vidap2t2.Content = "2";
                            p2t2.Source = raptor.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "5";
                            vidap2t2.Content = "1";
                            p2t2.Source = magmar.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "4";
                            vidap2t2.Content = "5";
                            p2t2.Source = yeti.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "6";
                            vidap2t2.Content = "7";
                            p2t2.Source = ogro.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "7";
                            vidap2t2.Content = "7";
                            p2t2.Source = golem.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "7";
                            p2t2.Source = oasis.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "9";
                            vidap2t2.Content = "5";
                            p2t2.Source = core.Source;
                        }
                    }
                }
                if (cte3_ == true)
                {
                    if (p2m3.Source != p2t2.Source)
                    {
                        p2t2.Source = cartamano3;
                        p2m3.Source = cartaoriginal;
                        p2t2.IsEnabled = false;
                        if (p2t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 2";
                            vidap2t2.Content = "1";
                            p2t2.Source = murloc.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 1";
                            vidap2t2.Content = "1";
                            p2t2.Source = wisp.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 2";
                            vidap2t2.Content = "3";
                            p2t2.Source = cocodrilo.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 3";
                            vidap2t2.Content = "2";
                            p2t2.Source = raptor.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "5";
                            vidap2t2.Content = "1";
                            p2t2.Source = magmar.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "4";
                            vidap2t2.Content = "5";
                            p2t2.Source = yeti.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "6";
                            vidap2t2.Content = "7";
                            p2t2.Source = ogro.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "7";
                            vidap2t2.Content = "7";
                            p2t2.Source = golem.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "7";
                            p2t2.Source = oasis.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "9";
                            vidap2t2.Content = "5";
                            p2t2.Source = core.Source;
                        }
                    }
                }
                if (cte4_ == true)
                {
                    if (p2m4.Source != p2t2.Source)
                    {
                        p2t2.Source = cartamano4;
                        p2m4.Source = cartaoriginal;
                        p2t2.IsEnabled = false;
                        if (p2t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "2";
                            vidap2t2.Content = " 1";
                            p2t2.Source = murloc.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 1";
                            vidap2t2.Content = "1";
                            p2t2.Source = wisp.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 2";
                            vidap2t2.Content = "3";
                            p2t2.Source = cocodrilo.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 3";
                            vidap2t2.Content = "2";
                            p2t2.Source = raptor.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "5";
                            vidap2t2.Content = "1";

                        }
                        else if (p2t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "4";
                            vidap2t2.Content = "5";
                            p2t2.Source = yeti.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "6";
                            vidap2t2.Content = "7";
                            p2t2.Source = ogro.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "7";
                            vidap2t2.Content = "7";
                            p2t2.Source = golem.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "7";
                            p2t2.Source = oasis.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "9";
                            vidap2t2.Content = "5";
                            p2t2.Source = core.Source;
                        }
                    }
                }
                if (cte5_ == true)
                {
                    if (p2m5.Source != p2t2.Source)
                    {
                        p2t2.Source = cartamano5;
                        p2m5.Source = cartaoriginal;
                        p2t2.IsEnabled = false;
                        if (p2t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "1";
                            p2t2.Source = murloc.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 1";
                            vidap2t2.Content = "1";
                            p2t2.Source = wisp.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 2";
                            vidap2t2.Content = "3";
                            p2t2.Source = cocodrilo.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 3";
                            vidap2t2.Content = "2";
                            p2t2.Source = raptor.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "5";
                            vidap2t2.Content = "1";
                            p2t2.Source = magmar.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "4";
                            vidap2t2.Content = "5";
                            p2t2.Source = yeti.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "6";
                            vidap2t2.Content = "7";
                            p2t2.Source = ogro.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "7";
                            vidap2t2.Content = "7";
                            p2t2.Source = golem.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "7";
                            p2t2.Source = oasis.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "9";
                            vidap2t2.Content = "5";
                            p2t2.Source = core.Source;
                        }
                    }
                }
                if (cte6_ == true)
                {
                    if (p2m6.Source != p2t2.Source)
                    {
                        p2t2.Source = cartamano6;
                        p2m6.Source = cartaoriginal;
                        p2t2.IsEnabled = false;
                        if (p2t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "1";
                            p2t2.Source = murloc.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 1";
                            vidap2t2.Content = "1";
                            p2t2.Source = wisp.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 2";
                            vidap2t2.Content = "3";
                            p2t2.Source = cocodrilo.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 3";
                            vidap2t2.Content = "2";
                            p2t2.Source = raptor.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "5";
                            vidap2t2.Content = "1";
                            p2t2.Source = magmar.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "4";
                            vidap2t2.Content = "5";
                            p2t2.Source = yeti.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "6";
                            vidap2t2.Content = "7";
                            p2t2.Source = ogro.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "7";
                            vidap2t2.Content = "7";
                            p2t2.Source = golem.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "7";
                            p2t2.Source = oasis.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "9";
                            vidap2t2.Content = "5";
                            p2t2.Source = core.Source;
                        }
                    }
                }
                if (cte7_ == true)
                {
                    if (p2m3.Source != p2t2.Source)
                    {
                        p2t2.Source = cartamano7;
                        p2m7.Source = cartaoriginal;
                        p2t2.IsEnabled = false;
                        if (p2t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "1";
                            p2t2.Source = murloc.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 1";
                            vidap2t2.Content = "1";
                            p2t2.Source = wisp.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 2";
                            vidap2t2.Content = "3";
                            p2t2.Source = cocodrilo.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 3";
                            vidap2t2.Content = "2";
                            p2t2.Source = raptor.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "5";
                            vidap2t2.Content = "1";
                            p2t2.Source = magmar.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "4";
                            vidap2t2.Content = "5";
                            p2t2.Source = yeti.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "6";
                            vidap2t2.Content = "7";
                            p2t2.Source = ogro.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "7";
                            vidap2t2.Content = "7";
                            p2t2.Source = golem.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "7";
                            p2t2.Source = oasis.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "9";
                            vidap2t2.Content = "5";
                            p2t2.Source = core.Source;
                        }
                    }
                }
                if (cte8_ == true)
                {
                    if (p2m8.Source != p2t2.Source)
                    {
                        p2t2.Source = cartamano8;
                        p2m8.Source = cartaoriginal;
                        p2t2.IsEnabled = false;
                        if (p2t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "1";
                            p2t2.Source = murloc.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 1";
                            vidap2t2.Content = "1";
                            p2t2.Source = wisp.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 2";
                            vidap2t2.Content = "3";
                            p2t2.Source = cocodrilo.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 3";
                            vidap2t2.Content = "2";
                            p2t2.Source = raptor.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "5";
                            vidap2t2.Content = "1";
                            p2t2.Source = magmar.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "4";
                            vidap2t2.Content = "5";
                            p2t2.Source = yeti.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "6";
                            vidap2t2.Content = "7";
                            p2t2.Source = ogro.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "7";
                            vidap2t2.Content = "7";
                            p2t2.Source = golem.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "7";
                            p2t2.Source = oasis.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "9";
                            vidap2t2.Content = "5";
                            p2t2.Source = core.Source;
                        }
                    }
                }
                if (cte9_ == true)
                {
                    if (p2m9.Source != p2t2.Source)
                    {
                        p2t2.Source = cartamano9;
                        p2m9.Source = cartaoriginal;
                        p2t2.IsEnabled = false;
                        if (p2t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "1";
                            p2t2.Source = murloc.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 1";
                            vidap2t2.Content = "1";
                            p2t2.Source = wisp.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 2";
                            vidap2t2.Content = "3";
                            p2t2.Source = cocodrilo.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 3";
                            vidap2t2.Content = "2";
                            p2t2.Source = raptor.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "5";
                            vidap2t2.Content = "1";
                            p2t2.Source = magmar.Source;


                        }
                        else if (p2t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "4";
                            vidap2t2.Content = "5";
                            p2t2.Source = yeti.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "6";
                            vidap2t2.Content = "7";
                            p2t2.Source = ogro.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "7";
                            vidap2t2.Content = "7";
                            p2t2.Source = golem.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "7";
                            p2t2.Source = oasis.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "9";
                            vidap2t2.Content = "5";
                            p2t2.Source = core.Source;
                        }
                    }
                }
                if (cte10_ == true)
                {
                    if (p2m10.Source != p2t2.Source)
                    {
                        p2t2.Source = cartamano10;
                        p2m10.Source = cartaoriginal;
                        p2t2.IsEnabled = false;
                        if (p2t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "2";
                            vidap2t2.Content = " 1";
                            p2t2.Source = murloc.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 1";
                            vidap2t2.Content = "1";
                            p2t2.Source = wisp.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 2";
                            vidap2t2.Content = "3";
                            p2t2.Source = cocodrilo.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = " 3";
                            vidap2t2.Content = "2";
                            p2t2.Source = raptor.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "5";
                            vidap2t2.Content = "1";
                            p2t2.Source = magmar.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "4";
                            vidap2t2.Content = "5";
                            p2t2.Source = yeti.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "6";
                            vidap2t2.Content = "7";
                            p2t2.Source = ogro.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t2.Content = "7";
                            vidap2t2.Content = "7";
                            p2t2.Source = golem.Source;

                        }
                        else if (p2t2.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "2";
                            vidap2t2.Content = "7";
                            p2t2.Source = oasis.Source;
                        }
                        else if (p2t2.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t2.Content = "9";
                            vidap2t2.Content = "5";
                            p2t2.Source = core.Source;
                        }
                    }
                }
            }
        }
        private void p2t3e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap2.Source;
            var cartamano = p2m1.Source;
            var cartamano2 = p2m2.Source;
            var cartamano3 = p2m3.Source;
            var cartamano4 = p2m4.Source;
            var cartamano5 = p2m5.Source;
            var cartamano6 = p2m6.Source;
            var cartamano7 = p2m7.Source;
            var cartamano8 = p2m8.Source;
            var cartamano9 = p2m9.Source;
            var cartamano10 = p2m10.Source;
            var cartatablero = p2t3.Source;
            if (cte_ == true)
            {

                if (p2m1.Source != p2t3.Source)
                {
                    p2t3.Source = cartamano;
                    p2m1.Source = cartaoriginal;
                    p2t3.IsEnabled = false;
                    if (p2t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep2t3.Content = "2";
                        vidap2t3.Content = "1";
                        p2t3.Source = murloc.Source;

                    }
                    else if (p2t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep2t3.Content = " 1";
                        vidap2t3.Content = "1";
                        p2t3.Source = wisp.Source;

                    }
                    else if (p2t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep2t3.Content = " 2";
                        vidap2t3.Content = "3";
                        p2t3.Source = cocodrilo.Source;

                    }
                    else if (p2t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep2t3.Content = " 3";
                        vidap2t3.Content = "2";
                        p2t3.Source = raptor.Source;

                    }
                    else if (p2t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep2t3.Content = "5";
                        vidap2t3.Content = "1";
                        p2t3.Source = magmar.Source;

                    }
                    else if (p2t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep2t3.Content = "4";
                        vidap2t3.Content = "5";
                        p2t3.Source = yeti.Source;

                    }
                    else if (p2t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep2t3.Content = "6";
                        vidap2t3.Content = "7";
                        p2t3.Source = ogro.Source;

                    }
                    else if (p2t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep2t3.Content = "7";
                        vidap2t3.Content = "7";
                        p2t3.Source = golem.Source;

                    }
                    else if (p2t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep2t3.Content = "2";
                        vidap2t3.Content = "7";
                        p2t3.Source = oasis.Source;
                    }
                    else if (p2t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep2t3.Content = "9";
                        vidap2t3.Content = "5";
                        p2t3.Source = core.Source;
                    }


                }
                if (cte2_ == true)
                {
                    if (p2m2.Source != p2t3.Source)
                    {
                        p2t3.Source = cartamano2;
                        p2m2.Source = cartaoriginal;
                        p2t3.IsEnabled = false;
                        if (p2t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "2";
                            vidap2t3.Content = " 1";
                            p2t3.Source = murloc.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 1";
                            vidap2t3.Content = "1";
                            p2t3.Source = wisp.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 2";
                            vidap2t3.Content = "3";

                        }
                        else if (p2t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 3";
                            vidap2t3.Content = "2";
                            p2t3.Source = raptor.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "5";
                            vidap2t3.Content = "1";
                            p2t3.Source = magmar.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "4";
                            vidap2t3.Content = "5";
                            p2t3.Source = yeti.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "6";
                            vidap2t3.Content = "7";
                            p2t3.Source = ogro.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "7";
                            vidap2t3.Content = "7";
                            p2t3.Source = golem.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "7";
                            p2t3.Source = oasis.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "9";
                            vidap2t3.Content = "5";
                            p2t3.Source = core.Source;
                        }
                    }
                }
                if (cte3_ == true)
                {
                    if (p2m3.Source != p2t3.Source)
                    {
                        p2t3.Source = cartamano3;
                        p2m3.Source = cartaoriginal;
                        p2t3.IsEnabled = false;
                        if (p2t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 2";
                            vidap2t3.Content = "1";
                            p2t3.Source = murloc.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 1";
                            vidap2t3.Content = "1";
                            p2t3.Source = wisp.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 2";
                            vidap2t3.Content = "3";
                            p2t3.Source = cocodrilo.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 3";
                            vidap2t3.Content = "2";
                            p2t3.Source = raptor.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "5";
                            vidap2t3.Content = "1";
                            p2t3.Source = magmar.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "4";
                            vidap2t3.Content = "5";
                            p2t3.Source = yeti.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "6";
                            vidap2t3.Content = "7";
                            p2t3.Source = ogro.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "7";
                            vidap2t3.Content = "7";
                            p2t3.Source = golem.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "7";
                            p2t3.Source = oasis.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "9";
                            vidap2t3.Content = "5";
                            p2t3.Source = core.Source;
                        }
                    }
                }
                if (cte4_ == true)
                {
                    if (p2m4.Source != p2t3.Source)
                    {
                        p2t3.Source = cartamano4;
                        p2m4.Source = cartaoriginal;
                        p2t3.IsEnabled = false;
                        if (p2t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "2";
                            vidap2t3.Content = " 1";
                            p2t3.Source = murloc.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 1";
                            vidap2t3.Content = "1";
                            p2t3.Source = wisp.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 2";
                            vidap2t3.Content = "3";
                            p2t3.Source = cocodrilo.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 3";
                            vidap2t3.Content = "2";
                            p2t3.Source = raptor.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "5";
                            vidap2t3.Content = "1";

                        }
                        else if (p2t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "4";
                            vidap2t3.Content = "5";
                            p2t3.Source = yeti.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "6";
                            vidap2t3.Content = "7";
                            p2t3.Source = ogro.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "7";
                            vidap2t3.Content = "7";
                            p2t3.Source = golem.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "7";
                            p2t3.Source = oasis.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "9";
                            vidap2t3.Content = "5";
                            p2t3.Source = core.Source;
                        }
                    }
                }
                if (cte5_ == true)
                {
                    if (p2m5.Source != p2t3.Source)
                    {
                        p2t3.Source = cartamano5;
                        p2m5.Source = cartaoriginal;
                        p2t3.IsEnabled = false;
                        if (p2t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "1";
                            p2t3.Source = murloc.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 1";
                            vidap2t3.Content = "1";
                            p2t3.Source = wisp.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 2";
                            vidap2t3.Content = "3";
                            p2t3.Source = cocodrilo.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 3";
                            vidap2t3.Content = "2";
                            p2t3.Source = raptor.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "5";
                            vidap2t3.Content = "1";
                            p2t3.Source = magmar.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "4";
                            vidap2t3.Content = "5";
                            p2t3.Source = yeti.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "6";
                            vidap2t3.Content = "7";
                            p2t3.Source = ogro.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "7";
                            vidap2t3.Content = "7";
                            p2t3.Source = golem.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "7";
                            p2t3.Source = oasis.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "9";
                            vidap2t3.Content = "5";
                            p2t3.Source = core.Source;
                        }
                    }
                }
                if (cte6_ == true)
                {
                    if (p2m6.Source != p2t3.Source)
                    {
                        p2t3.Source = cartamano6;
                        p2m6.Source = cartaoriginal;
                        p2t3.IsEnabled = false;
                        if (p2t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "1";
                            p2t3.Source = murloc.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 1";
                            vidap2t3.Content = "1";
                            p2t3.Source = wisp.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 2";
                            vidap2t3.Content = "3";
                            p2t3.Source = cocodrilo.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 3";
                            vidap2t3.Content = "2";
                            p2t3.Source = raptor.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "5";
                            vidap2t3.Content = "1";
                            p2t3.Source = magmar.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "4";
                            vidap2t3.Content = "5";
                            p2t3.Source = yeti.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "6";
                            vidap2t3.Content = "7";
                            p2t3.Source = ogro.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "7";
                            vidap2t3.Content = "7";
                            p2t3.Source = golem.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "7";
                            p2t3.Source = oasis.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "9";
                            vidap2t3.Content = "5";
                            p2t3.Source = core.Source;
                        }
                    }
                }
                if (cte7_ == true)
                {
                    if (p2m3.Source != p2t3.Source)
                    {
                        p2t3.Source = cartamano7;
                        p2m7.Source = cartaoriginal;
                        p2t3.IsEnabled = false;
                        if (p2t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "1";
                            p2t3.Source = murloc.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 1";
                            vidap2t3.Content = "1";
                            p2t3.Source = wisp.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 2";
                            vidap2t3.Content = "3";
                            p2t3.Source = cocodrilo.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 3";
                            vidap2t3.Content = "2";
                            p2t3.Source = raptor.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "5";
                            vidap2t3.Content = "1";
                            p2t3.Source = magmar.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "4";
                            vidap2t3.Content = "5";
                            p2t3.Source = yeti.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "6";
                            vidap2t3.Content = "7";
                            p2t3.Source = ogro.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "7";
                            vidap2t3.Content = "7";
                            p2t3.Source = golem.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "7";
                            p2t3.Source = oasis.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "9";
                            vidap2t3.Content = "5";
                            p2t3.Source = core.Source;
                        }
                    }
                }
                if (cte8_ == true)
                {
                    if (p2m8.Source != p2t3.Source)
                    {
                        p2t3.Source = cartamano8;
                        p2m8.Source = cartaoriginal;
                        p2t3.IsEnabled = false;
                        if (p2t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "1";
                            p2t3.Source = murloc.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 1";
                            vidap2t3.Content = "1";
                            p2t3.Source = wisp.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 2";
                            vidap2t3.Content = "3";
                            p2t3.Source = cocodrilo.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 3";
                            vidap2t3.Content = "2";
                            p2t3.Source = raptor.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "5";
                            vidap2t3.Content = "1";
                            p2t3.Source = magmar.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "4";
                            vidap2t3.Content = "5";
                            p2t3.Source = yeti.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "6";
                            vidap2t3.Content = "7";
                            p2t3.Source = ogro.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "7";
                            vidap2t3.Content = "7";
                            p2t3.Source = golem.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "7";
                            p2t3.Source = oasis.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "9";
                            vidap2t3.Content = "5";
                            p2t3.Source = core.Source;
                        }
                    }
                }
                if (cte9_ == true)
                {
                    if (p2m9.Source != p2t3.Source)
                    {
                        p2t3.Source = cartamano9;
                        p2m9.Source = cartaoriginal;
                        p2t3.IsEnabled = false;
                        if (p2t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "1";
                            p2t3.Source = murloc.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 1";
                            vidap2t3.Content = "1";
                            p2t3.Source = wisp.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 2";
                            vidap2t3.Content = "3";
                            p2t3.Source = cocodrilo.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 3";
                            vidap2t3.Content = "2";
                            p2t3.Source = raptor.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "5";
                            vidap2t3.Content = "1";
                            p2t3.Source = magmar.Source;


                        }
                        else if (p2t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "4";
                            vidap2t3.Content = "5";
                            p2t3.Source = yeti.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "6";
                            vidap2t3.Content = "7";
                            p2t3.Source = ogro.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "7";
                            vidap2t3.Content = "7";
                            p2t3.Source = golem.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "7";
                            p2t3.Source = oasis.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "9";
                            vidap2t3.Content = "5";
                            p2t3.Source = core.Source;
                        }
                    }
                }
                if (cte10_ == true)
                {
                    if (p2m10.Source != p2t3.Source)
                    {
                        p2t3.Source = cartamano10;
                        p2m10.Source = cartaoriginal;
                        p2t3.IsEnabled = false;
                        if (p2t3.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "2";
                            vidap2t3.Content = " 1";
                            p2t3.Source = murloc.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 1";
                            vidap2t3.Content = "1";
                            p2t3.Source = wisp.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 2";
                            vidap2t3.Content = "3";
                            p2t3.Source = cocodrilo.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = " 3";
                            vidap2t3.Content = "2";
                            p2t3.Source = raptor.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "5";
                            vidap2t3.Content = "1";
                            p2t3.Source = magmar.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "4";
                            vidap2t3.Content = "5";
                            p2t3.Source = yeti.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "6";
                            vidap2t3.Content = "7";
                            p2t3.Source = ogro.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t3.Content = "7";
                            vidap2t3.Content = "7";
                            p2t3.Source = golem.Source;

                        }
                        else if (p2t3.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "2";
                            vidap2t3.Content = "7";
                            p2t3.Source = oasis.Source;
                        }
                        else if (p2t3.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t3.Content = "9";
                            vidap2t3.Content = "5";
                            p2t3.Source = core.Source;
                        }
                    }
                }
            }
        }
        private void p2t4e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap2.Source;
            var cartamano = p2m1.Source;
            var cartamano2 = p2m2.Source;
            var cartamano3 = p2m3.Source;
            var cartamano4 = p2m4.Source;
            var cartamano5 = p2m5.Source;
            var cartamano6 = p2m6.Source;
            var cartamano7 = p2m7.Source;
            var cartamano8 = p2m8.Source;
            var cartamano9 = p2m9.Source;
            var cartamano10 = p2m10.Source;
            var cartatablero = p2t4.Source;
            if (cte_ == true)
            {

                if (p2m1.Source != p2t4.Source)
                {
                    p2t4.Source = cartamano;
                    p2m1.Source = cartaoriginal;
                    p2t4.IsEnabled = false;
                    if (p2t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep2t4.Content = "2";
                        vidap2t4.Content = "1";
                        p2t4.Source = murloc.Source;

                    }
                    else if (p2t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep2t4.Content = " 1";
                        vidap2t4.Content = "1";
                        p2t4.Source = wisp.Source;

                    }
                    else if (p2t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep2t4.Content = " 2";
                        vidap2t4.Content = "3";
                        p2t4.Source = cocodrilo.Source;

                    }
                    else if (p2t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep2t4.Content = " 3";
                        vidap2t4.Content = "2";
                        p2t4.Source = raptor.Source;

                    }
                    else if (p2t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep2t4.Content = "5";
                        vidap2t4.Content = "1";
                        p2t4.Source = magmar.Source;

                    }
                    else if (p2t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep2t4.Content = "4";
                        vidap2t4.Content = "5";
                        p2t4.Source = yeti.Source;

                    }
                    else if (p2t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep2t4.Content = "6";
                        vidap2t4.Content = "7";
                        p2t4.Source = ogro.Source;

                    }
                    else if (p2t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep2t4.Content = "7";
                        vidap2t4.Content = "7";
                        p2t4.Source = golem.Source;

                    }
                    else if (p2t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep2t4.Content = "2";
                        vidap2t4.Content = "7";
                        p2t4.Source = oasis.Source;
                    }
                    else if (p2t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep2t4.Content = "9";
                        vidap2t4.Content = "5";
                        p2t4.Source = core.Source;
                    }


                }
                if (cte2_ == true)
                {
                    if (p2m2.Source != p2t4.Source)
                    {
                        p2t4.Source = cartamano2;
                        p2m2.Source = cartaoriginal;
                        p2t4.IsEnabled = false;
                        if (p2t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "2";
                            vidap2t4.Content = " 1";
                            p2t4.Source = murloc.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 1";
                            vidap2t4.Content = "1";
                            p2t4.Source = wisp.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 2";
                            vidap2t4.Content = "3";

                        }
                        else if (p2t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 3";
                            vidap2t4.Content = "2";
                            p2t4.Source = raptor.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "5";
                            vidap2t4.Content = "1";
                            p2t4.Source = magmar.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "4";
                            vidap2t4.Content = "5";
                            p2t4.Source = yeti.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "6";
                            vidap2t4.Content = "7";
                            p2t4.Source = ogro.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "7";
                            vidap2t4.Content = "7";
                            p2t4.Source = golem.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "7";
                            p2t4.Source = oasis.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "9";
                            vidap2t4.Content = "5";
                            p2t4.Source = core.Source;
                        }
                    }
                }
                if (cte3_ == true)
                {
                    if (p2m3.Source != p2t4.Source)
                    {
                        p2t4.Source = cartamano3;
                        p2m3.Source = cartaoriginal;
                        p2t4.IsEnabled = false;
                        if (p2t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 2";
                            vidap2t4.Content = "1";
                            p2t4.Source = murloc.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 1";
                            vidap2t4.Content = "1";
                            p2t4.Source = wisp.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 2";
                            vidap2t4.Content = "3";
                            p2t4.Source = cocodrilo.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 3";
                            vidap2t4.Content = "2";
                            p2t4.Source = raptor.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "5";
                            vidap2t4.Content = "1";
                            p2t4.Source = magmar.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "4";
                            vidap2t4.Content = "5";
                            p2t4.Source = yeti.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "6";
                            vidap2t4.Content = "7";
                            p2t4.Source = ogro.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "7";
                            vidap2t4.Content = "7";
                            p2t4.Source = golem.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "7";
                            p2t4.Source = oasis.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "9";
                            vidap2t4.Content = "5";
                            p2t4.Source = core.Source;
                        }
                    }
                }
                if (cte4_ == true)
                {
                    if (p2m4.Source != p2t4.Source)
                    {
                        p2t4.Source = cartamano4;
                        p2m4.Source = cartaoriginal;
                        p2t4.IsEnabled = false;
                        if (p2t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "2";
                            vidap2t4.Content = " 1";
                            p2t4.Source = murloc.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 1";
                            vidap2t4.Content = "1";
                            p2t4.Source = wisp.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 2";
                            vidap2t4.Content = "3";
                            p2t4.Source = cocodrilo.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 3";
                            vidap2t4.Content = "2";
                            p2t4.Source = raptor.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "5";
                            vidap2t4.Content = "1";

                        }
                        else if (p2t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "4";
                            vidap2t4.Content = "5";
                            p2t4.Source = yeti.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "6";
                            vidap2t4.Content = "7";
                            p2t4.Source = ogro.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "7";
                            vidap2t4.Content = "7";
                            p2t4.Source = golem.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "7";
                            p2t4.Source = oasis.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "9";
                            vidap2t4.Content = "5";
                            p2t4.Source = core.Source;
                        }
                    }
                }
                if (cte5_ == true)
                {
                    if (p2m5.Source != p2t4.Source)
                    {
                        p2t4.Source = cartamano5;
                        p2m5.Source = cartaoriginal;
                        p2t4.IsEnabled = false;
                        if (p2t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "1";
                            p2t4.Source = murloc.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 1";
                            vidap2t4.Content = "1";
                            p2t4.Source = wisp.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 2";
                            vidap2t4.Content = "3";
                            p2t4.Source = cocodrilo.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 3";
                            vidap2t4.Content = "2";
                            p2t4.Source = raptor.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "5";
                            vidap2t4.Content = "1";
                            p2t4.Source = magmar.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "4";
                            vidap2t4.Content = "5";
                            p2t4.Source = yeti.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "6";
                            vidap2t4.Content = "7";
                            p2t4.Source = ogro.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "7";
                            vidap2t4.Content = "7";
                            p2t4.Source = golem.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "7";
                            p2t4.Source = oasis.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "9";
                            vidap2t4.Content = "5";
                            p2t4.Source = core.Source;
                        }
                    }
                }
                if (cte6_ == true)
                {
                    if (p2m6.Source != p2t4.Source)
                    {
                        p2t4.Source = cartamano6;
                        p2m6.Source = cartaoriginal;
                        p2t4.IsEnabled = false;
                        if (p2t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "1";
                            p2t4.Source = murloc.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 1";
                            vidap2t4.Content = "1";
                            p2t4.Source = wisp.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 2";
                            vidap2t4.Content = "3";
                            p2t4.Source = cocodrilo.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 3";
                            vidap2t4.Content = "2";
                            p2t4.Source = raptor.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "5";
                            vidap2t4.Content = "1";
                            p2t4.Source = magmar.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "4";
                            vidap2t4.Content = "5";
                            p2t4.Source = yeti.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "6";
                            vidap2t4.Content = "7";
                            p2t4.Source = ogro.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "7";
                            vidap2t4.Content = "7";
                            p2t4.Source = golem.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "7";
                            p2t4.Source = oasis.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "9";
                            vidap2t4.Content = "5";
                            p2t4.Source = core.Source;
                        }
                    }
                }
                if (cte7_ == true)
                {
                    if (p2m3.Source != p2t4.Source)
                    {
                        p2t4.Source = cartamano7;
                        p2m7.Source = cartaoriginal;
                        p2t4.IsEnabled = false;
                        if (p2t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "1";
                            p2t4.Source = murloc.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 1";
                            vidap2t4.Content = "1";
                            p2t4.Source = wisp.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 2";
                            vidap2t4.Content = "3";
                            p2t4.Source = cocodrilo.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 3";
                            vidap2t4.Content = "2";
                            p2t4.Source = raptor.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "5";
                            vidap2t4.Content = "1";
                            p2t4.Source = magmar.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "4";
                            vidap2t4.Content = "5";
                            p2t4.Source = yeti.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "6";
                            vidap2t4.Content = "7";
                            p2t4.Source = ogro.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "7";
                            vidap2t4.Content = "7";
                            p2t4.Source = golem.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "7";
                            p2t4.Source = oasis.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "9";
                            vidap2t4.Content = "5";
                            p2t4.Source = core.Source;
                        }
                    }
                }
                if (cte8_ == true)
                {
                    if (p2m8.Source != p2t4.Source)
                    {
                        p2t4.Source = cartamano8;
                        p2m8.Source = cartaoriginal;
                        p2t4.IsEnabled = false;
                        if (p2t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "1";
                            p2t4.Source = murloc.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 1";
                            vidap2t4.Content = "1";
                            p2t4.Source = wisp.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 2";
                            vidap2t4.Content = "3";
                            p2t4.Source = cocodrilo.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 3";
                            vidap2t4.Content = "2";
                            p2t4.Source = raptor.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "5";
                            vidap2t4.Content = "1";
                            p2t4.Source = magmar.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "4";
                            vidap2t4.Content = "5";
                            p2t4.Source = yeti.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "6";
                            vidap2t4.Content = "7";
                            p2t4.Source = ogro.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "7";
                            vidap2t4.Content = "7";
                            p2t4.Source = golem.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "7";
                            p2t4.Source = oasis.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "9";
                            vidap2t4.Content = "5";
                            p2t4.Source = core.Source;
                        }
                    }
                }
                if (cte9_ == true)
                {
                    if (p2m9.Source != p2t4.Source)
                    {
                        p2t4.Source = cartamano9;
                        p2m9.Source = cartaoriginal;
                        p2t4.IsEnabled = false;
                        if (p2t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "1";
                            p2t4.Source = murloc.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 1";
                            vidap2t4.Content = "1";
                            p2t4.Source = wisp.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 2";
                            vidap2t4.Content = "3";
                            p2t4.Source = cocodrilo.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 3";
                            vidap2t4.Content = "2";
                            p2t4.Source = raptor.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "5";
                            vidap2t4.Content = "1";
                            p2t4.Source = magmar.Source;


                        }
                        else if (p2t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "4";
                            vidap2t4.Content = "5";
                            p2t4.Source = yeti.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "6";
                            vidap2t4.Content = "7";
                            p2t4.Source = ogro.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "7";
                            vidap2t4.Content = "7";
                            p2t4.Source = golem.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "7";
                            p2t4.Source = oasis.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "9";
                            vidap2t4.Content = "5";
                            p2t4.Source = core.Source;
                        }
                    }
                }
                if (cte10_ == true)
                {
                    if (p2m10.Source != p2t4.Source)
                    {
                        p2t4.Source = cartamano10;
                        p2m10.Source = cartaoriginal;
                        p2t4.IsEnabled = false;
                        if (p2t4.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "2";
                            vidap2t4.Content = " 1";
                            p2t4.Source = murloc.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 1";
                            vidap2t4.Content = "1";
                            p2t4.Source = wisp.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 2";
                            vidap2t4.Content = "3";
                            p2t4.Source = cocodrilo.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = " 3";
                            vidap2t4.Content = "2";
                            p2t4.Source = raptor.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "5";
                            vidap2t4.Content = "1";
                            p2t4.Source = magmar.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "4";
                            vidap2t4.Content = "5";
                            p2t4.Source = yeti.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "6";
                            vidap2t4.Content = "7";
                            p2t4.Source = ogro.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t4.Content = "7";
                            vidap2t4.Content = "7";
                            p2t4.Source = golem.Source;

                        }
                        else if (p2t4.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "2";
                            vidap2t4.Content = "7";
                            p2t4.Source = oasis.Source;
                        }
                        else if (p2t4.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t4.Content = "9";
                            vidap2t4.Content = "5";
                            p2t4.Source = core.Source;
                        }
                    }
                }
            }
        }
        private void p2t5e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap2.Source;
            var cartamano = p2m1.Source;
            var cartamano2 = p2m2.Source;
            var cartamano3 = p2m3.Source;
            var cartamano4 = p2m4.Source;
            var cartamano5 = p2m5.Source;
            var cartamano6 = p2m6.Source;
            var cartamano7 = p2m7.Source;
            var cartamano8 = p2m8.Source;
            var cartamano9 = p2m9.Source;
            var cartamano10 = p2m10.Source;
            var cartatablero = p2t5.Source;
            if (cte_ == true)
            {

                if (p2m1.Source != p2t5.Source)
                {
                    p2t5.Source = cartamano;
                    p2m1.Source = cartaoriginal;
                    p2t5.IsEnabled = false;
                    if (p2t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep2t5.Content = "2";
                        vidap2t5.Content = "1";
                        p2t5.Source = murloc.Source;

                    }
                    else if (p2t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep2t5.Content = " 1";
                        vidap2t5.Content = "1";
                        p2t5.Source = wisp.Source;

                    }
                    else if (p2t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep2t5.Content = " 2";
                        vidap2t5.Content = "3";
                        p2t5.Source = cocodrilo.Source;

                    }
                    else if (p2t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep2t5.Content = " 3";
                        vidap2t5.Content = "2";
                        p2t5.Source = raptor.Source;

                    }
                    else if (p2t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep2t5.Content = "5";
                        vidap2t5.Content = "1";
                        p2t5.Source = magmar.Source;

                    }
                    else if (p2t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep2t5.Content = "4";
                        vidap2t5.Content = "5";
                        p2t5.Source = yeti.Source;

                    }
                    else if (p2t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep2t5.Content = "6";
                        vidap2t5.Content = "7";
                        p2t5.Source = ogro.Source;

                    }
                    else if (p2t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep2t5.Content = "7";
                        vidap2t5.Content = "7";
                        p2t5.Source = golem.Source;

                    }
                    else if (p2t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep2t5.Content = "2";
                        vidap2t5.Content = "7";
                        p2t5.Source = oasis.Source;
                    }
                    else if (p2t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep2t5.Content = "9";
                        vidap2t5.Content = "5";
                        p2t5.Source = core.Source;
                    }


                }
                if (cte2_ == true)
                {
                    if (p2m2.Source != p2t5.Source)
                    {
                        p2t5.Source = cartamano2;
                        p2m2.Source = cartaoriginal;
                        p2t5.IsEnabled = false;
                        if (p2t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "2";
                            vidap2t5.Content = " 1";
                            p2t5.Source = murloc.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 1";
                            vidap2t5.Content = "1";
                            p2t5.Source = wisp.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 2";
                            vidap2t5.Content = "3";

                        }
                        else if (p2t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 3";
                            vidap2t5.Content = "2";
                            p2t5.Source = raptor.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "5";
                            vidap2t5.Content = "1";
                            p2t5.Source = magmar.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "4";
                            vidap2t5.Content = "5";
                            p2t5.Source = yeti.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "6";
                            vidap2t5.Content = "7";
                            p2t5.Source = ogro.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "7";
                            vidap2t5.Content = "7";
                            p2t5.Source = golem.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "7";
                            p2t5.Source = oasis.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "9";
                            vidap2t5.Content = "5";
                            p2t5.Source = core.Source;
                        }
                    }
                }
                if (cte3_ == true)
                {
                    if (p2m3.Source != p2t5.Source)
                    {
                        p2t5.Source = cartamano3;
                        p2m3.Source = cartaoriginal;
                        p2t5.IsEnabled = false;
                        if (p2t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 2";
                            vidap2t5.Content = "1";
                            p2t5.Source = murloc.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 1";
                            vidap2t5.Content = "1";
                            p2t5.Source = wisp.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 2";
                            vidap2t5.Content = "3";
                            p2t5.Source = cocodrilo.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 3";
                            vidap2t5.Content = "2";
                            p2t5.Source = raptor.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "5";
                            vidap2t5.Content = "1";
                            p2t5.Source = magmar.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "4";
                            vidap2t5.Content = "5";
                            p2t5.Source = yeti.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "6";
                            vidap2t5.Content = "7";
                            p2t5.Source = ogro.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "7";
                            vidap2t5.Content = "7";
                            p2t5.Source = golem.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "7";
                            p2t5.Source = oasis.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "9";
                            vidap2t5.Content = "5";
                            p2t5.Source = core.Source;
                        }
                    }
                }
                if (cte4_ == true)
                {
                    if (p2m4.Source != p2t5.Source)
                    {
                        p2t5.Source = cartamano4;
                        p2m4.Source = cartaoriginal;
                        p2t5.IsEnabled = false;
                        if (p2t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "2";
                            vidap2t5.Content = " 1";
                            p2t5.Source = murloc.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 1";
                            vidap2t5.Content = "1";
                            p2t5.Source = wisp.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 2";
                            vidap2t5.Content = "3";
                            p2t5.Source = cocodrilo.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 3";
                            vidap2t5.Content = "2";
                            p2t5.Source = raptor.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "5";
                            vidap2t5.Content = "1";

                        }
                        else if (p2t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "4";
                            vidap2t5.Content = "5";
                            p2t5.Source = yeti.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "6";
                            vidap2t5.Content = "7";
                            p2t5.Source = ogro.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "7";
                            vidap2t5.Content = "7";
                            p2t5.Source = golem.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "7";
                            p2t5.Source = oasis.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "9";
                            vidap2t5.Content = "5";
                            p2t5.Source = core.Source;
                        }
                    }
                }
                if (cte5_ == true)
                {
                    if (p2m5.Source != p2t5.Source)
                    {
                        p2t5.Source = cartamano5;
                        p2m5.Source = cartaoriginal;
                        p2t5.IsEnabled = false;
                        if (p2t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "1";
                            p2t5.Source = murloc.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 1";
                            vidap2t5.Content = "1";
                            p2t5.Source = wisp.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 2";
                            vidap2t5.Content = "3";
                            p2t5.Source = cocodrilo.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 3";
                            vidap2t5.Content = "2";
                            p2t5.Source = raptor.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "5";
                            vidap2t5.Content = "1";
                            p2t5.Source = magmar.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "4";
                            vidap2t5.Content = "5";
                            p2t5.Source = yeti.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "6";
                            vidap2t5.Content = "7";
                            p2t5.Source = ogro.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "7";
                            vidap2t5.Content = "7";
                            p2t5.Source = golem.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "7";
                            p2t5.Source = oasis.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "9";
                            vidap2t5.Content = "5";
                            p2t5.Source = core.Source;
                        }
                    }
                }
                if (cte6_ == true)
                {
                    if (p2m6.Source != p2t5.Source)
                    {
                        p2t5.Source = cartamano6;
                        p2m6.Source = cartaoriginal;
                        p2t5.IsEnabled = false;
                        if (p2t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "1";
                            p2t5.Source = murloc.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 1";
                            vidap2t5.Content = "1";
                            p2t5.Source = wisp.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 2";
                            vidap2t5.Content = "3";
                            p2t5.Source = cocodrilo.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 3";
                            vidap2t5.Content = "2";
                            p2t5.Source = raptor.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "5";
                            vidap2t5.Content = "1";
                            p2t5.Source = magmar.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "4";
                            vidap2t5.Content = "5";
                            p2t5.Source = yeti.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "6";
                            vidap2t5.Content = "7";
                            p2t5.Source = ogro.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "7";
                            vidap2t5.Content = "7";
                            p2t5.Source = golem.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "7";
                            p2t5.Source = oasis.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "9";
                            vidap2t5.Content = "5";
                            p2t5.Source = core.Source;
                        }
                    }
                }
                if (cte7_ == true)
                {
                    if (p2m3.Source != p2t5.Source)
                    {
                        p2t5.Source = cartamano7;
                        p2m7.Source = cartaoriginal;
                        p2t5.IsEnabled = false;
                        if (p2t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "1";
                            p2t5.Source = murloc.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 1";
                            vidap2t5.Content = "1";
                            p2t5.Source = wisp.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 2";
                            vidap2t5.Content = "3";
                            p2t5.Source = cocodrilo.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 3";
                            vidap2t5.Content = "2";
                            p2t5.Source = raptor.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "5";
                            vidap2t5.Content = "1";
                            p2t5.Source = magmar.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "4";
                            vidap2t5.Content = "5";
                            p2t5.Source = yeti.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "6";
                            vidap2t5.Content = "7";
                            p2t5.Source = ogro.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "7";
                            vidap2t5.Content = "7";
                            p2t5.Source = golem.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "7";
                            p2t5.Source = oasis.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "9";
                            vidap2t5.Content = "5";
                            p2t5.Source = core.Source;
                        }
                    }
                }
                if (cte8_ == true)
                {
                    if (p2m8.Source != p2t5.Source)
                    {
                        p2t5.Source = cartamano8;
                        p2m8.Source = cartaoriginal;
                        p2t5.IsEnabled = false;
                        if (p2t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "1";
                            p2t5.Source = murloc.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 1";
                            vidap2t5.Content = "1";
                            p2t5.Source = wisp.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 2";
                            vidap2t5.Content = "3";
                            p2t5.Source = cocodrilo.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 3";
                            vidap2t5.Content = "2";
                            p2t5.Source = raptor.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "5";
                            vidap2t5.Content = "1";
                            p2t5.Source = magmar.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "4";
                            vidap2t5.Content = "5";
                            p2t5.Source = yeti.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "6";
                            vidap2t5.Content = "7";
                            p2t5.Source = ogro.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "7";
                            vidap2t5.Content = "7";
                            p2t5.Source = golem.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "7";
                            p2t5.Source = oasis.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "9";
                            vidap2t5.Content = "5";
                            p2t5.Source = core.Source;
                        }
                    }
                }
                if (cte9_ == true)
                {
                    if (p2m9.Source != p2t5.Source)
                    {
                        p2t5.Source = cartamano9;
                        p2m9.Source = cartaoriginal;
                        p2t5.IsEnabled = false;
                        if (p2t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "1";
                            p2t5.Source = murloc.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 1";
                            vidap2t5.Content = "1";
                            p2t5.Source = wisp.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 2";
                            vidap2t5.Content = "3";
                            p2t5.Source = cocodrilo.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 3";
                            vidap2t5.Content = "2";
                            p2t5.Source = raptor.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "5";
                            vidap2t5.Content = "1";
                            p2t5.Source = magmar.Source;


                        }
                        else if (p2t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "4";
                            vidap2t5.Content = "5";
                            p2t5.Source = yeti.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "6";
                            vidap2t5.Content = "7";
                            p2t5.Source = ogro.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "7";
                            vidap2t5.Content = "7";
                            p2t5.Source = golem.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "7";
                            p2t5.Source = oasis.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "9";
                            vidap2t5.Content = "5";
                            p2t5.Source = core.Source;
                        }
                    }
                }
                if (cte10_ == true)
                {
                    if (p2m10.Source != p2t5.Source)
                    {
                        p2t5.Source = cartamano10;
                        p2m10.Source = cartaoriginal;
                        p2t5.IsEnabled = false;
                        if (p2t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "2";
                            vidap2t5.Content = " 1";
                            p2t5.Source = murloc.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 1";
                            vidap2t5.Content = "1";
                            p2t5.Source = wisp.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 2";
                            vidap2t5.Content = "3";
                            p2t5.Source = cocodrilo.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = " 3";
                            vidap2t5.Content = "2";
                            p2t5.Source = raptor.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "5";
                            vidap2t5.Content = "1";
                            p2t5.Source = magmar.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "4";
                            vidap2t5.Content = "5";
                            p2t5.Source = yeti.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "6";
                            vidap2t5.Content = "7";
                            p2t5.Source = ogro.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t5.Content = "7";
                            vidap2t5.Content = "7";
                            p2t5.Source = golem.Source;

                        }
                        else if (p2t5.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "2";
                            vidap2t5.Content = "7";
                            p2t5.Source = oasis.Source;
                        }
                        else if (p2t5.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t5.Content = "9";
                            vidap2t5.Content = "5";
                            p2t5.Source = core.Source;
                        }
                    }
                }


            }
        }
        private void p2t6e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap2.Source;
            var cartamano = p2m1.Source;
            var cartamano2 = p2m2.Source;
            var cartamano3 = p2m3.Source;
            var cartamano4 = p2m4.Source;
            var cartamano5 = p2m5.Source;
            var cartamano6 = p2m6.Source;
            var cartamano7 = p2m7.Source;
            var cartamano8 = p2m8.Source;
            var cartamano9 = p2m9.Source;
            var cartamano10 = p2m10.Source;
            var cartatablero = p2t6.Source;
            if (cte_ == true)
            {

                if (p2m1.Source != p2t6.Source)
                {
                    p2t6.Source = cartamano;
                    p2m1.Source = cartaoriginal;
                    p2t6.IsEnabled = false;
                    if (p2t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep2t6.Content = "2";
                        vidap2t6.Content = "1";
                        p2t6.Source = murloc.Source;

                    }
                    else if (p2t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep2t6.Content = " 1";
                        vidap2t6.Content = "1";
                        p2t6.Source = wisp.Source;

                    }
                    else if (p2t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep2t6.Content = " 2";
                        vidap2t6.Content = "3";
                        p2t6.Source = cocodrilo.Source;

                    }
                    else if (p2t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep2t6.Content = " 3";
                        vidap2t6.Content = "2";
                        p2t6.Source = raptor.Source;

                    }
                    else if (p2t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep2t6.Content = "5";
                        vidap2t6.Content = "1";
                        p2t6.Source = magmar.Source;

                    }
                    else if (p2t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep2t6.Content = "4";
                        vidap2t6.Content = "5";
                        p2t6.Source = yeti.Source;

                    }
                    else if (p2t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep2t6.Content = "6";
                        vidap2t6.Content = "7";
                        p2t6.Source = ogro.Source;

                    }
                    else if (p2t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep2t6.Content = "7";
                        vidap2t6.Content = "7";
                        p2t6.Source = golem.Source;

                    }
                    else if (p2t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep2t6.Content = "2";
                        vidap2t6.Content = "7";
                        p2t6.Source = oasis.Source;
                    }
                    else if (p2t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep2t6.Content = "9";
                        vidap2t6.Content = "5";
                        p2t6.Source = core.Source;
                    }


                }
                if (cte2_ == true)
                {
                    if (p2m2.Source != p2t6.Source)
                    {
                        p2t6.Source = cartamano2;
                        p2m2.Source = cartaoriginal;
                        p2t6.IsEnabled = false;
                        if (p2t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "2";
                            vidap2t6.Content = " 1";
                            p2t6.Source = murloc.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 1";
                            vidap2t6.Content = "1";
                            p2t6.Source = wisp.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 2";
                            vidap2t6.Content = "3";

                        }
                        else if (p2t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 3";
                            vidap2t6.Content = "2";
                            p2t6.Source = raptor.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "5";
                            vidap2t6.Content = "1";
                            p2t6.Source = magmar.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "4";
                            vidap2t6.Content = "5";
                            p2t6.Source = yeti.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "6";
                            vidap2t6.Content = "7";
                            p2t6.Source = ogro.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "7";
                            vidap2t6.Content = "7";
                            p2t6.Source = golem.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "7";
                            p2t6.Source = oasis.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "9";
                            vidap2t6.Content = "5";
                            p2t6.Source = core.Source;
                        }
                    }
                }
                if (cte3_ == true)
                {
                    if (p2m3.Source != p2t6.Source)
                    {
                        p2t6.Source = cartamano3;
                        p2m3.Source = cartaoriginal;
                        p2t6.IsEnabled = false;
                        if (p2t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 2";
                            vidap2t6.Content = "1";
                            p2t6.Source = murloc.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 1";
                            vidap2t6.Content = "1";
                            p2t6.Source = wisp.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 2";
                            vidap2t6.Content = "3";
                            p2t6.Source = cocodrilo.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 3";
                            vidap2t6.Content = "2";
                            p2t6.Source = raptor.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "5";
                            vidap2t6.Content = "1";
                            p2t6.Source = magmar.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "4";
                            vidap2t6.Content = "5";
                            p2t6.Source = yeti.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "6";
                            vidap2t6.Content = "7";
                            p2t6.Source = ogro.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "7";
                            vidap2t6.Content = "7";
                            p2t6.Source = golem.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "7";
                            p2t6.Source = oasis.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "9";
                            vidap2t6.Content = "5";
                            p2t6.Source = core.Source;
                        }
                    }
                }
                if (cte4_ == true)
                {
                    if (p2m4.Source != p2t6.Source)
                    {
                        p2t6.Source = cartamano4;
                        p2m4.Source = cartaoriginal;
                        p2t6.IsEnabled = false;
                        if (p2t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "2";
                            vidap2t6.Content = " 1";
                            p2t6.Source = murloc.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 1";
                            vidap2t6.Content = "1";
                            p2t6.Source = wisp.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 2";
                            vidap2t6.Content = "3";
                            p2t6.Source = cocodrilo.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 3";
                            vidap2t6.Content = "2";
                            p2t6.Source = raptor.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "5";
                            vidap2t6.Content = "1";

                        }
                        else if (p2t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "4";
                            vidap2t6.Content = "5";
                            p2t6.Source = yeti.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "6";
                            vidap2t6.Content = "7";
                            p2t6.Source = ogro.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "7";
                            vidap2t6.Content = "7";
                            p2t6.Source = golem.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "7";
                            p2t6.Source = oasis.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "9";
                            vidap2t6.Content = "5";
                            p2t6.Source = core.Source;
                        }
                    }
                }
                if (cte5_ == true)
                {
                    if (p2m5.Source != p2t6.Source)
                    {
                        p2t6.Source = cartamano5;
                        p2m5.Source = cartaoriginal;
                        p2t6.IsEnabled = false;
                        if (p2t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "1";
                            p2t6.Source = murloc.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 1";
                            vidap2t6.Content = "1";
                            p2t6.Source = wisp.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 2";
                            vidap2t6.Content = "3";
                            p2t6.Source = cocodrilo.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 3";
                            vidap2t6.Content = "2";
                            p2t6.Source = raptor.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "5";
                            vidap2t6.Content = "1";
                            p2t6.Source = magmar.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "4";
                            vidap2t6.Content = "5";
                            p2t6.Source = yeti.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "6";
                            vidap2t6.Content = "7";
                            p2t6.Source = ogro.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "7";
                            vidap2t6.Content = "7";
                            p2t6.Source = golem.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "7";
                            p2t6.Source = oasis.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "9";
                            vidap2t6.Content = "5";
                            p2t6.Source = core.Source;
                        }
                    }
                }
                if (cte6_ == true)
                {
                    if (p2m6.Source != p2t6.Source)
                    {
                        p2t6.Source = cartamano6;
                        p2m6.Source = cartaoriginal;
                        p2t6.IsEnabled = false;
                        if (p2t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "1";
                            p2t6.Source = murloc.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 1";
                            vidap2t6.Content = "1";
                            p2t6.Source = wisp.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 2";
                            vidap2t6.Content = "3";
                            p2t6.Source = cocodrilo.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 3";
                            vidap2t6.Content = "2";
                            p2t6.Source = raptor.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "5";
                            vidap2t6.Content = "1";
                            p2t6.Source = magmar.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "4";
                            vidap2t6.Content = "5";
                            p2t6.Source = yeti.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "6";
                            vidap2t6.Content = "7";
                            p2t6.Source = ogro.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "7";
                            vidap2t6.Content = "7";
                            p2t6.Source = golem.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "7";
                            p2t6.Source = oasis.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "9";
                            vidap2t6.Content = "5";
                            p2t6.Source = core.Source;
                        }
                    }
                }
                if (cte7_ == true)
                {
                    if (p2m3.Source != p2t6.Source)
                    {
                        p2t6.Source = cartamano7;
                        p2m7.Source = cartaoriginal;
                        p2t6.IsEnabled = false;
                        if (p2t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "1";
                            p2t6.Source = murloc.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 1";
                            vidap2t6.Content = "1";
                            p2t6.Source = wisp.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 2";
                            vidap2t6.Content = "3";
                            p2t6.Source = cocodrilo.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 3";
                            vidap2t6.Content = "2";
                            p2t6.Source = raptor.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "5";
                            vidap2t6.Content = "1";
                            p2t6.Source = magmar.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "4";
                            vidap2t6.Content = "5";
                            p2t6.Source = yeti.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "6";
                            vidap2t6.Content = "7";
                            p2t6.Source = ogro.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "7";
                            vidap2t6.Content = "7";
                            p2t6.Source = golem.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "7";
                            p2t6.Source = oasis.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "9";
                            vidap2t6.Content = "5";
                            p2t6.Source = core.Source;
                        }
                    }
                }
                if (cte8_ == true)
                {
                    if (p2m8.Source != p2t6.Source)
                    {
                        p2t6.Source = cartamano8;
                        p2m8.Source = cartaoriginal;
                        p2t6.IsEnabled = false;
                        if (p2t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "1";
                            p2t6.Source = murloc.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 1";
                            vidap2t6.Content = "1";
                            p2t6.Source = wisp.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 2";
                            vidap2t6.Content = "3";
                            p2t6.Source = cocodrilo.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 3";
                            vidap2t6.Content = "2";
                            p2t6.Source = raptor.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "5";
                            vidap2t6.Content = "1";
                            p2t6.Source = magmar.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "4";
                            vidap2t6.Content = "5";
                            p2t6.Source = yeti.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "6";
                            vidap2t6.Content = "7";
                            p2t6.Source = ogro.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "7";
                            vidap2t6.Content = "7";
                            p2t6.Source = golem.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "7";
                            p2t6.Source = oasis.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "9";
                            vidap2t6.Content = "5";
                            p2t6.Source = core.Source;
                        }
                    }
                }
                if (cte9_ == true)
                {
                    if (p2m9.Source != p2t6.Source)
                    {
                        p2t6.Source = cartamano9;
                        p2m9.Source = cartaoriginal;
                        p2t6.IsEnabled = false;
                        if (p2t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "1";
                            p2t6.Source = murloc.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 1";
                            vidap2t6.Content = "1";
                            p2t6.Source = wisp.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 2";
                            vidap2t6.Content = "3";
                            p2t6.Source = cocodrilo.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 3";
                            vidap2t6.Content = "2";
                            p2t6.Source = raptor.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "5";
                            vidap2t6.Content = "1";
                            p2t6.Source = magmar.Source;


                        }
                        else if (p2t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "4";
                            vidap2t6.Content = "5";
                            p2t6.Source = yeti.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "6";
                            vidap2t6.Content = "7";
                            p2t6.Source = ogro.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "7";
                            vidap2t6.Content = "7";
                            p2t6.Source = golem.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "7";
                            p2t6.Source = oasis.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "9";
                            vidap2t6.Content = "5";
                            p2t6.Source = core.Source;
                        }
                    }
                }
                if (cte10_ == true)
                {
                    if (p2m10.Source != p2t6.Source)
                    {
                        p2t6.Source = cartamano10;
                        p2m10.Source = cartaoriginal;
                        p2t6.IsEnabled = false;
                        if (p2t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "2";
                            vidap2t6.Content = " 1";
                            p2t6.Source = murloc.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 1";
                            vidap2t6.Content = "1";
                            p2t6.Source = wisp.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 2";
                            vidap2t6.Content = "3";
                            p2t6.Source = cocodrilo.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = " 3";
                            vidap2t6.Content = "2";
                            p2t6.Source = raptor.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "5";
                            vidap2t6.Content = "1";
                            p2t6.Source = magmar.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "4";
                            vidap2t6.Content = "5";
                            p2t6.Source = yeti.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "6";
                            vidap2t6.Content = "7";
                            p2t6.Source = ogro.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t6.Content = "7";
                            vidap2t6.Content = "7";
                            p2t6.Source = golem.Source;

                        }
                        else if (p2t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "2";
                            vidap2t6.Content = "7";
                            p2t6.Source = oasis.Source;
                        }
                        else if (p2t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t6.Content = "9";
                            vidap2t6.Content = "5";
                            p2t6.Source = core.Source;
                        }
                    }
                }


            }
        }
        private void p2t7e(object sender, MouseButtonEventArgs e)
        {
            var cartaoriginal = cartaocultap2.Source;
            var cartamano = p2m1.Source;
            var cartamano2 = p2m2.Source;
            var cartamano3 = p2m3.Source;
            var cartamano4 = p2m4.Source;
            var cartamano5 = p2m5.Source;
            var cartamano6 = p2m6.Source;
            var cartamano7 = p2m7.Source;
            var cartamano8 = p2m8.Source;
            var cartamano9 = p2m9.Source;
            var cartamano10 = p2m10.Source;
            var cartatablero = p2t7.Source;
            if (cte_ == true)
            {

                if (p2m1.Source != p2t7.Source)
                {
                    p2t7.Source = cartamano;
                    p2m1.Source = cartaoriginal;
                    p2t7.IsEnabled = false;
                    if (p2t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep2t7.Content = "2";
                        vidap2t7.Content = "1";
                        p2t7.Source = murloc.Source;

                    }
                    else if (p2t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep2t7.Content = " 1";
                        vidap2t7.Content = "1";
                        p2t7.Source = wisp.Source;

                    }
                    else if (p2t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep2t7.Content = " 2";
                        vidap2t7.Content = "3";
                        p2t7.Source = cocodrilo.Source;

                    }
                    else if (p2t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep2t7.Content = " 3";
                        vidap2t7.Content = "2";
                        p2t7.Source = raptor.Source;

                    }
                    else if (p2t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep2t7.Content = "5";
                        vidap2t7.Content = "1";
                        p2t7.Source = magmar.Source;

                    }
                    else if (p2t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep2t7.Content = "4";
                        vidap2t7.Content = "5";
                        p2t7.Source = yeti.Source;

                    }
                    else if (p2t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep2t7.Content = "6";
                        vidap2t7.Content = "7";
                        p2t7.Source = ogro.Source;

                    }
                    else if (p2t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep2t7.Content = "7";
                        vidap2t7.Content = "7";
                        p2t7.Source = golem.Source;

                    }
                    else if (p2t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep2t7.Content = "2";
                        vidap2t7.Content = "7";
                        p2t7.Source = oasis.Source;
                    }
                    else if (p2t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep2t7.Content = "9";
                        vidap2t7.Content = "5";
                        p2t7.Source = core.Source;
                    }


                }
                if (cte2_ == true)
                {
                    if (p2m2.Source != p2t7.Source)
                    {
                        p2t7.Source = cartamano2;
                        p2m2.Source = cartaoriginal;
                        p2t7.IsEnabled = false;
                        if (p2t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "2";
                            vidap2t7.Content = " 1";
                            p2t7.Source = murloc.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 1";
                            vidap2t7.Content = "1";
                            p2t7.Source = wisp.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 2";
                            vidap2t7.Content = "3";

                        }
                        else if (p2t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 3";
                            vidap2t7.Content = "2";
                            p2t7.Source = raptor.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "5";
                            vidap2t7.Content = "1";
                            p2t7.Source = magmar.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "4";
                            vidap2t7.Content = "5";
                            p2t7.Source = yeti.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "6";
                            vidap2t7.Content = "7";
                            p2t7.Source = ogro.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "7";
                            vidap2t7.Content = "7";
                            p2t7.Source = golem.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "7";
                            p2t7.Source = oasis.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "9";
                            vidap2t7.Content = "5";
                            p2t7.Source = core.Source;
                        }
                    }
                }
                if (cte3_ == true)
                {
                    if (p2m3.Source != p2t7.Source)
                    {
                        p2t7.Source = cartamano3;
                        p2m3.Source = cartaoriginal;
                        p2t7.IsEnabled = false;
                        if (p2t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 2";
                            vidap2t7.Content = "1";
                            p2t7.Source = murloc.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 1";
                            vidap2t7.Content = "1";
                            p2t7.Source = wisp.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 2";
                            vidap2t7.Content = "3";
                            p2t7.Source = cocodrilo.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 3";
                            vidap2t7.Content = "2";
                            p2t7.Source = raptor.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "5";
                            vidap2t7.Content = "1";
                            p2t7.Source = magmar.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "4";
                            vidap2t7.Content = "5";
                            p2t7.Source = yeti.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "6";
                            vidap2t7.Content = "7";
                            p2t7.Source = ogro.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "7";
                            vidap2t7.Content = "7";
                            p2t7.Source = golem.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "7";
                            p2t7.Source = oasis.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "9";
                            vidap2t7.Content = "5";
                            p2t7.Source = core.Source;
                        }
                    }
                }
                if (cte4_ == true)
                {
                    if (p2m4.Source != p2t7.Source)
                    {
                        p2t7.Source = cartamano4;
                        p2m4.Source = cartaoriginal;
                        p2t7.IsEnabled = false;
                        if (p2t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "2";
                            vidap2t7.Content = " 1";
                            p2t7.Source = murloc.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 1";
                            vidap2t7.Content = "1";
                            p2t7.Source = wisp.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 2";
                            vidap2t7.Content = "3";
                            p2t7.Source = cocodrilo.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 3";
                            vidap2t7.Content = "2";
                            p2t7.Source = raptor.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "5";
                            vidap2t7.Content = "1";

                        }
                        else if (p2t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "4";
                            vidap2t7.Content = "5";
                            p2t7.Source = yeti.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "6";
                            vidap2t7.Content = "7";
                            p2t7.Source = ogro.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "7";
                            vidap2t7.Content = "7";
                            p2t7.Source = golem.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "7";
                            p2t7.Source = oasis.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "9";
                            vidap2t7.Content = "5";
                            p2t7.Source = core.Source;
                        }
                    }
                }
                if (cte5_ == true)
                {
                    if (p2m5.Source != p2t7.Source)
                    {
                        p2t7.Source = cartamano5;
                        p2m5.Source = cartaoriginal;
                        p2t7.IsEnabled = false;
                        if (p2t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "1";
                            p2t7.Source = murloc.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 1";
                            vidap2t7.Content = "1";
                            p2t7.Source = wisp.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 2";
                            vidap2t7.Content = "3";
                            p2t7.Source = cocodrilo.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 3";
                            vidap2t7.Content = "2";
                            p2t7.Source = raptor.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "5";
                            vidap2t7.Content = "1";
                            p2t7.Source = magmar.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "4";
                            vidap2t7.Content = "5";
                            p2t7.Source = yeti.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "6";
                            vidap2t7.Content = "7";
                            p2t7.Source = ogro.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "7";
                            vidap2t7.Content = "7";
                            p2t7.Source = golem.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "7";
                            p2t7.Source = oasis.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "9";
                            vidap2t7.Content = "5";
                            p2t7.Source = core.Source;
                        }
                    }
                }
                if (cte6_ == true)
                {
                    if (p2m6.Source != p2t7.Source)
                    {
                        p2t7.Source = cartamano6;
                        p2m6.Source = cartaoriginal;
                        p2t7.IsEnabled = false;
                        if (p2t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "1";
                            p2t7.Source = murloc.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 1";
                            vidap2t7.Content = "1";
                            p2t7.Source = wisp.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 2";
                            vidap2t7.Content = "3";
                            p2t7.Source = cocodrilo.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 3";
                            vidap2t7.Content = "2";
                            p2t7.Source = raptor.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "5";
                            vidap2t7.Content = "1";
                            p2t7.Source = magmar.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "4";
                            vidap2t7.Content = "5";
                            p2t7.Source = yeti.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "6";
                            vidap2t7.Content = "7";
                            p2t7.Source = ogro.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "7";
                            vidap2t7.Content = "7";
                            p2t7.Source = golem.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "7";
                            p2t7.Source = oasis.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "9";
                            vidap2t7.Content = "5";
                            p2t7.Source = core.Source;
                        }
                    }
                }
                if (cte7_ == true)
                {
                    if (p2m3.Source != p2t7.Source)
                    {
                        p2t7.Source = cartamano7;
                        p2m7.Source = cartaoriginal;
                        p2t7.IsEnabled = false;
                        if (p2t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "1";
                            p2t7.Source = murloc.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 1";
                            vidap2t7.Content = "1";
                            p2t7.Source = wisp.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 2";
                            vidap2t7.Content = "3";
                            p2t7.Source = cocodrilo.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 3";
                            vidap2t7.Content = "2";
                            p2t7.Source = raptor.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "5";
                            vidap2t7.Content = "1";
                            p2t7.Source = magmar.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "4";
                            vidap2t7.Content = "5";
                            p2t7.Source = yeti.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "6";
                            vidap2t7.Content = "7";
                            p2t7.Source = ogro.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "7";
                            vidap2t7.Content = "7";
                            p2t7.Source = golem.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "7";
                            p2t7.Source = oasis.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "9";
                            vidap2t7.Content = "5";
                            p2t7.Source = core.Source;
                        }
                    }
                }
                if (cte8_ == true)
                {
                    if (p2m8.Source != p2t7.Source)
                    {
                        p2t7.Source = cartamano8;
                        p2m8.Source = cartaoriginal;
                        p2t7.IsEnabled = false;
                        if (p2t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "1";
                            p2t7.Source = murloc.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 1";
                            vidap2t7.Content = "1";
                            p2t7.Source = wisp.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 2";
                            vidap2t7.Content = "3";
                            p2t7.Source = cocodrilo.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 3";
                            vidap2t7.Content = "2";
                            p2t7.Source = raptor.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "5";
                            vidap2t7.Content = "1";
                            p2t7.Source = magmar.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "4";
                            vidap2t7.Content = "5";
                            p2t7.Source = yeti.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "6";
                            vidap2t7.Content = "7";
                            p2t7.Source = ogro.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "7";
                            vidap2t7.Content = "7";
                            p2t7.Source = golem.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "7";
                            p2t7.Source = oasis.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "9";
                            vidap2t7.Content = "5";
                            p2t7.Source = core.Source;
                        }
                    }
                }
                if (cte9_ == true)
                {
                    if (p2m9.Source != p2t7.Source)
                    {
                        p2t7.Source = cartamano9;
                        p2m9.Source = cartaoriginal;
                        p2t7.IsEnabled = false;
                        if (p2t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "1";
                            p2t7.Source = murloc.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 1";
                            vidap2t7.Content = "1";
                            p2t7.Source = wisp.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 2";
                            vidap2t7.Content = "3";
                            p2t7.Source = cocodrilo.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 3";
                            vidap2t7.Content = "2";
                            p2t7.Source = raptor.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "5";
                            vidap2t7.Content = "1";
                            p2t7.Source = magmar.Source;


                        }
                        else if (p2t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "4";
                            vidap2t7.Content = "5";
                            p2t7.Source = yeti.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "6";
                            vidap2t7.Content = "7";
                            p2t7.Source = ogro.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "7";
                            vidap2t7.Content = "7";
                            p2t7.Source = golem.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "7";
                            p2t7.Source = oasis.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "9";
                            vidap2t7.Content = "5";
                            p2t7.Source = core.Source;
                        }
                    }
                }
                if (cte10_ == true)
                {
                    if (p2m10.Source != p2t7.Source)
                    {
                        p2t7.Source = cartamano10;
                        p2m10.Source = cartaoriginal;
                        p2t7.IsEnabled = false;
                        if (p2t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "2";
                            vidap2t7.Content = " 1";
                            p2t7.Source = murloc.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 1";
                            vidap2t7.Content = "1";
                            p2t7.Source = wisp.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 2";
                            vidap2t7.Content = "3";
                            p2t7.Source = cocodrilo.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = " 3";
                            vidap2t7.Content = "2";
                            p2t7.Source = raptor.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "5";
                            vidap2t7.Content = "1";
                            p2t7.Source = magmar.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "4";
                            vidap2t7.Content = "5";
                            p2t7.Source = yeti.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "6";
                            vidap2t7.Content = "7";
                            p2t7.Source = ogro.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                        {

                            ataquep2t7.Content = "7";
                            vidap2t7.Content = "7";
                            p2t7.Source = golem.Source;

                        }
                        else if (p2t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "2";
                            vidap2t7.Content = "7";
                            p2t7.Source = oasis.Source;
                        }
                        else if (p2t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                        {
                            ataquep2t7.Content = "9";
                            vidap2t7.Content = "5";
                            p2t7.Source = core.Source;
                        }
                    }
                }
            }
        }
        // Hasta aca metodo invocar jugador 2 

       
      
        // P1 ataca a p2

        private void atacap1t1e(object sender, MouseButtonEventArgs e)
        {
            ataca1 = true;
        }
        private void atacap1t2e(object sender, MouseButtonEventArgs e)
        {
           ataca2 = true;
        }
        private void atacap1t3e(object sender, MouseButtonEventArgs e)
        {
            ataca3 = true;

        }
        private void atacap1t4e(object sender, MouseButtonEventArgs e)
        {
            ataca4 = true;
        }
        private void atacap1t5e(object sender, MouseButtonEventArgs e)
        {
            ataca5 = true;
        }
        private void atacap1t6e(object sender, MouseButtonEventArgs e)
        {
            ataca6 = true;
        }
        private void atacap1t7e(object sender, MouseButtonEventArgs e)
        {
            ataca7 = true;
        }

        private void p1atacap2t1(object sender, MouseButtonEventArgs e)
        {
            var cartatablero1 = p1t1.Source.ToString().ToLower();
            var cartatablero2 = p1t2.Source.ToString().ToLower();
            var cartatablero3 = p1t3.Source.ToString().ToLower();
            var cartatablero4 = p1t4.Source.ToString().ToLower();
            var cartatablero5 = p1t5.Source.ToString().ToLower();
            var cartatablero6 = p1t6.Source.ToString().ToLower();
            var cartatablero7 = p1t7.Source.ToString().ToLower();
            var cartatablerop2 = p2t1.Source.ToString().ToLower();

            if (ataca2 == true)
            {
                if (p1t2.Source.ToString().ToLower() != cartaocultap1.Source.ToString().ToLower())
                {
                    if (p2t1.Source.ToString().ToLower() != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t2.Content = Convert.ToInt32(vidap1t2.Content) - Convert.ToInt32(ataquep2t1.Content);
                        vidap2t1.Content = Convert.ToInt32(vidap2t1.Content) - Convert.ToInt32(ataquep1t2.Content);
                        if (Convert.ToInt32(vidap1t2.Content) <= 0)
                        {
                            p1t2.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t1.Content) <= 0)
                        {
                            p2t1.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

            if (ataca1 == true)
            {
                if (cartatablero1 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t1.Content = Convert.ToInt32(vidap1t1.Content) - Convert.ToInt32(ataquep2t1.Content);
                        vidap2t1.Content = Convert.ToInt32(vidap2t1.Content) - Convert.ToInt32(ataquep1t1.Content);
                        if (Convert.ToInt32(vidap1t1.Content) <= 0)
                        {
                            p1t1.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t1.Content) <= 0)
                        {
                            p2t1.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
           
            if (ataca3 == true)
            {
                if (cartatablero3 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t3.Content = Convert.ToInt32(vidap1t3.Content) - Convert.ToInt32(ataquep2t1.Content);
                        vidap2t1.Content = Convert.ToInt32(vidap2t1.Content) - Convert.ToInt32(ataquep1t3.Content);
                        if (Convert.ToInt32(vidap1t3.Content) <= 0)
                        {
                            p1t3.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t1.Content) <= 0)
                        {
                            p2t1.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca4 == true)
            {
                if (cartatablero4 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t4.Content = Convert.ToInt32(vidap1t4.Content) - Convert.ToInt32(ataquep2t1.Content);
                        vidap2t1.Content = Convert.ToInt32(vidap2t1.Content) - Convert.ToInt32(ataquep1t4.Content);
                        if (Convert.ToInt32(vidap1t4.Content) <= 0)
                        {
                            p1t4.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t1.Content) <= 0)
                        {
                            p2t1.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca5 == true)
            {
                if (cartatablero5 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t5.Content = Convert.ToInt32(vidap1t5.Content) - Convert.ToInt32(ataquep2t1.Content);
                        vidap2t1.Content = Convert.ToInt32(vidap2t1.Content) - Convert.ToInt32(ataquep1t5.Content);
                        if (Convert.ToInt32(vidap1t5.Content) <= 0)
                        {
                            p1t5.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t1.Content) <= 0)
                        {
                            p2t1.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca6 == true)
            {
                if (cartatablero6 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t6.Content = Convert.ToInt32(vidap1t6.Content) - Convert.ToInt32(ataquep2t1.Content);
                        vidap2t1.Content = Convert.ToInt32(vidap2t1.Content) - Convert.ToInt32(ataquep1t6.Content);
                        if (Convert.ToInt32(vidap1t6.Content) <= 0)
                        {
                            p1t6.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t1.Content) <= 0)
                        {
                            p2t1.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca7 == true)
            {
                if (cartatablero7 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t7.Content = Convert.ToInt32(vidap1t7.Content) - Convert.ToInt32(ataquep2t1.Content);
                        vidap2t1.Content = Convert.ToInt32(vidap2t1.Content) - Convert.ToInt32(ataquep1t7.Content);
                        if (Convert.ToInt32(vidap1t7.Content) <= 0)
                        {
                            p1t7.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t1.Content) <= 0)
                        {
                            p2t1.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

        }
        private void p1atacap2t2(object sender, MouseButtonEventArgs e)
        {
           
                var cartatablero1 = p1t1.Source.ToString().ToLower();
                var cartatablero2 = p1t2.Source.ToString().ToLower();
                var cartatablero3 = p1t3.Source.ToString().ToLower();
                var cartatablero4 = p1t4.Source.ToString().ToLower();
                var cartatablero5 = p1t5.Source.ToString().ToLower();
                var cartatablero6 = p1t6.Source.ToString().ToLower();
                var cartatablero7 = p1t7.Source.ToString().ToLower();
                var cartatablerop2 = p2t2.Source.ToString().ToLower();

                if (ataca2 == true)
                {
                    if (p1t2.Source.ToString().ToLower() != cartaocultap1.Source.ToString().ToLower())
                    {
                        if (p2t2.Source.ToString().ToLower() != cartaocultap2.Source.ToString().ToLower())
                        {
                            vidap1t2.Content = Convert.ToInt32(vidap1t2.Content) - Convert.ToInt32(ataquep2t2.Content);
                            vidap2t2.Content = Convert.ToInt32(vidap2t2.Content) - Convert.ToInt32(ataquep1t2.Content);
                            if (Convert.ToInt32(vidap1t2.Content) <= 0)
                            {
                                p1t2.Source = cartaocultap1.Source;
                            }
                            if (Convert.ToInt32(vidap2t2.Content) <= 0)
                            {
                                p2t2.Source = cartaocultap2.Source;
                            }
                        }
                    }
                }

                if (ataca1 == true)
                {
                    if (cartatablero1 != cartaocultap1.Source.ToString().ToLower())
                    {
                        if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                        {
                            vidap1t1.Content = Convert.ToInt32(vidap1t1.Content) - Convert.ToInt32(ataquep2t2.Content);
                            vidap2t2.Content = Convert.ToInt32(vidap2t2.Content) - Convert.ToInt32(ataquep1t1.Content);
                            if (Convert.ToInt32(vidap1t1.Content) <= 0)
                            {
                                p1t1.Source = cartaocultap1.Source;
                            }
                            if (Convert.ToInt32(vidap2t2.Content) <= 0)
                            {
                                p2t2.Source = cartaocultap2.Source;
                            }
                        }
                    }
                }

                if (ataca3 == true)
                {
                    if (cartatablero3 != cartaocultap1.Source.ToString().ToLower())
                    {
                        if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                        {
                            vidap1t3.Content = Convert.ToInt32(vidap1t3.Content) - Convert.ToInt32(ataquep2t2.Content);
                            vidap2t2.Content = Convert.ToInt32(vidap2t2.Content) - Convert.ToInt32(ataquep1t3.Content);
                            if (Convert.ToInt32(vidap1t3.Content) <= 0)
                            {
                                p1t3.Source = cartaocultap1.Source;
                            }
                            if (Convert.ToInt32(vidap2t2.Content) <= 0)
                            {
                                p2t2.Source = cartaocultap2.Source;
                            }
                        }
                    }
                }
                else if (ataca4 == true)
                {
                    if (cartatablero4 != cartaocultap1.Source.ToString().ToLower())
                    {
                        if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                        {
                            vidap1t4.Content = Convert.ToInt32(vidap1t4.Content) - Convert.ToInt32(ataquep2t2.Content);
                            vidap2t2.Content = Convert.ToInt32(vidap2t2.Content) - Convert.ToInt32(ataquep1t4.Content);
                            if (Convert.ToInt32(vidap1t4.Content) <= 0)
                            {
                                p1t4.Source = cartaocultap1.Source;
                            }
                            if (Convert.ToInt32(vidap2t2.Content) <= 0)
                            {
                                p2t2.Source = cartaocultap2.Source;
                            }
                        }
                    }
                }
                else if (ataca5 == true)
                {
                    if (cartatablero5 != cartaocultap1.Source.ToString().ToLower())
                    {
                        if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                        {
                            vidap1t5.Content = Convert.ToInt32(vidap1t5.Content) - Convert.ToInt32(ataquep2t2.Content);
                            vidap2t2.Content = Convert.ToInt32(vidap2t2.Content) - Convert.ToInt32(ataquep1t5.Content);
                            if (Convert.ToInt32(vidap1t5.Content) <= 0)
                            {
                                p1t5.Source = cartaocultap1.Source;
                            }
                            if (Convert.ToInt32(vidap2t2.Content) <= 0)
                            {
                                p2t2.Source = cartaocultap2.Source;
                            }
                        }
                    }
                }
                else if (ataca6 == true)
                {
                    if (cartatablero6 != cartaocultap1.Source.ToString().ToLower())
                    {
                        if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                        {
                            vidap1t6.Content = Convert.ToInt32(vidap1t6.Content) - Convert.ToInt32(ataquep2t2.Content);
                            vidap2t2.Content = Convert.ToInt32(vidap2t2.Content) - Convert.ToInt32(ataquep1t6.Content);
                            if (Convert.ToInt32(vidap1t6.Content) <= 0)
                            {
                                p1t6.Source = cartaocultap1.Source;
                            }
                            if (Convert.ToInt32(vidap2t2.Content) <= 0)
                            {
                                p2t2.Source = cartaocultap2.Source;
                            }
                        }
                    }
                }
                else if (ataca7 == true)
                {
                    if (cartatablero7 != cartaocultap1.Source.ToString().ToLower())
                    {
                        if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                        {
                            vidap1t7.Content = Convert.ToInt32(vidap1t7.Content) - Convert.ToInt32(ataquep2t2.Content);
                            vidap2t2.Content = Convert.ToInt32(vidap2t2.Content) - Convert.ToInt32(ataquep1t7.Content);
                            if (Convert.ToInt32(vidap1t7.Content) <= 0)
                            {
                                p1t7.Source = cartaocultap1.Source;
                            }
                            if (Convert.ToInt32(vidap2t2.Content) <= 0)
                            {
                                p2t2.Source = cartaocultap2.Source;
                            }
                        }
                    }
                }

            }
        private void p1atacap2t3(object sender, MouseButtonEventArgs e)
        {


            var cartatablero1 = p1t1.Source.ToString().ToLower();
            var cartatablero2 = p1t2.Source.ToString().ToLower();
            var cartatablero3 = p1t3.Source.ToString().ToLower();
            var cartatablero4 = p1t4.Source.ToString().ToLower();
            var cartatablero5 = p1t5.Source.ToString().ToLower();
            var cartatablero6 = p1t6.Source.ToString().ToLower();
            var cartatablero7 = p1t7.Source.ToString().ToLower();
            var cartatablerop2 = p2t3.Source.ToString().ToLower();

            if (ataca2 == true)
            {
                if (p1t2.Source.ToString().ToLower() != cartaocultap1.Source.ToString().ToLower())
                {
                    if (p2t3.Source.ToString().ToLower() != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t2.Content = Convert.ToInt32(vidap1t2.Content) - Convert.ToInt32(ataquep2t3.Content);
                        vidap2t3.Content = Convert.ToInt32(vidap2t3.Content) - Convert.ToInt32(ataquep1t2.Content);
                        if (Convert.ToInt32(vidap1t2.Content) <= 0)
                        {
                            p1t2.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t3.Content) <= 0)
                        {
                            p2t3.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

            if (ataca1 == true)
            {
                if (cartatablero1 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t1.Content = Convert.ToInt32(vidap1t1.Content) - Convert.ToInt32(ataquep2t3.Content);
                        vidap2t3.Content = Convert.ToInt32(vidap2t3.Content) - Convert.ToInt32(ataquep1t1.Content);
                        if (Convert.ToInt32(vidap1t1.Content) <= 0)
                        {
                            p1t1.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t3.Content) <= 0)
                        {
                            p2t3.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

            if (ataca3 == true)
            {
                if (cartatablero3 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t3.Content = Convert.ToInt32(vidap1t3.Content) - Convert.ToInt32(ataquep2t3.Content);
                        vidap2t3.Content = Convert.ToInt32(vidap2t3.Content) - Convert.ToInt32(ataquep1t3.Content);
                        if (Convert.ToInt32(vidap1t3.Content) <= 0)
                        {
                            p1t3.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t3.Content) <= 0)
                        {
                            p2t3.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca4 == true)
            {
                if (cartatablero4 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t4.Content = Convert.ToInt32(vidap1t4.Content) - Convert.ToInt32(ataquep2t3.Content);
                        vidap2t3.Content = Convert.ToInt32(vidap2t3.Content) - Convert.ToInt32(ataquep1t4.Content);
                        if (Convert.ToInt32(vidap1t4.Content) <= 0)
                        {
                            p1t4.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t3.Content) <= 0)
                        {
                            p2t3.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca5 == true)
            {
                if (cartatablero5 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t5.Content = Convert.ToInt32(vidap1t5.Content) - Convert.ToInt32(ataquep2t3.Content);
                        vidap2t3.Content = Convert.ToInt32(vidap2t3.Content) - Convert.ToInt32(ataquep1t5.Content);
                        if (Convert.ToInt32(vidap1t5.Content) <= 0)
                        {
                            p1t5.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t3.Content) <= 0)
                        {
                            p2t3.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca6 == true)
            {
                if (cartatablero6 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t6.Content = Convert.ToInt32(vidap1t6.Content) - Convert.ToInt32(ataquep2t3.Content);
                        vidap2t3.Content = Convert.ToInt32(vidap2t3.Content) - Convert.ToInt32(ataquep1t6.Content);
                        if (Convert.ToInt32(vidap1t6.Content) <= 0)
                        {
                            p1t6.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t3.Content) <= 0)
                        {
                            p2t3.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca7 == true)
            {
                if (cartatablero7 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t7.Content = Convert.ToInt32(vidap1t7.Content) - Convert.ToInt32(ataquep2t3.Content);
                        vidap2t3.Content = Convert.ToInt32(vidap2t3.Content) - Convert.ToInt32(ataquep1t7.Content);
                        if (Convert.ToInt32(vidap1t7.Content) <= 0)
                        {
                            p1t7.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t3.Content) <= 0)
                        {
                            p2t3.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

        }
        private void p1atacap2t4(object sender, MouseButtonEventArgs e)
        {


            var cartatablero1 = p1t1.Source.ToString().ToLower();
            var cartatablero2 = p1t2.Source.ToString().ToLower();
            var cartatablero3 = p1t3.Source.ToString().ToLower();
            var cartatablero4 = p1t4.Source.ToString().ToLower();
            var cartatablero5 = p1t5.Source.ToString().ToLower();
            var cartatablero6 = p1t6.Source.ToString().ToLower();
            var cartatablero7 = p1t7.Source.ToString().ToLower();
            var cartatablerop2 = p2t4.Source.ToString().ToLower();

            if (ataca2 == true)
            {
                if (p1t2.Source.ToString().ToLower() != cartaocultap1.Source.ToString().ToLower())
                {
                    if (p2t4.Source.ToString().ToLower() != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t2.Content = Convert.ToInt32(vidap1t2.Content) - Convert.ToInt32(ataquep2t4.Content);
                        vidap2t4.Content = Convert.ToInt32(vidap2t4.Content) - Convert.ToInt32(ataquep1t2.Content);
                        if (Convert.ToInt32(vidap1t2.Content) <= 0)
                        {
                            p1t2.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t4.Content) <= 0)
                        {
                            p2t4.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

            if (ataca1 == true)
            {
                if (cartatablero1 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t1.Content = Convert.ToInt32(vidap1t1.Content) - Convert.ToInt32(ataquep2t4.Content);
                        vidap2t4.Content = Convert.ToInt32(vidap2t4.Content) - Convert.ToInt32(ataquep1t1.Content);
                        if (Convert.ToInt32(vidap1t1.Content) <= 0)
                        {
                            p1t1.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t4.Content) <= 0)
                        {
                            p2t4.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

            if (ataca3 == true)
            {
                if (cartatablero3 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t3.Content = Convert.ToInt32(vidap1t3.Content) - Convert.ToInt32(ataquep2t4.Content);
                        vidap2t4.Content = Convert.ToInt32(vidap2t4.Content) - Convert.ToInt32(ataquep1t3.Content);
                        if (Convert.ToInt32(vidap1t3.Content) <= 0)
                        {
                            p1t3.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t4.Content) <= 0)
                        {
                            p2t4.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca4 == true)
            {
                if (cartatablero4 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t4.Content = Convert.ToInt32(vidap1t4.Content) - Convert.ToInt32(ataquep2t4.Content);
                        vidap2t4.Content = Convert.ToInt32(vidap2t4.Content) - Convert.ToInt32(ataquep1t4.Content);
                        if (Convert.ToInt32(vidap1t4.Content) <= 0)
                        {
                            p1t4.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t4.Content) <= 0)
                        {
                            p2t4.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca5 == true)
            {
                if (cartatablero5 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t5.Content = Convert.ToInt32(vidap1t5.Content) - Convert.ToInt32(ataquep2t4.Content);
                        vidap2t4.Content = Convert.ToInt32(vidap2t4.Content) - Convert.ToInt32(ataquep1t5.Content);
                        if (Convert.ToInt32(vidap1t5.Content) <= 0)
                        {
                            p1t5.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t4.Content) <= 0)
                        {
                            p2t4.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca6 == true)
            {
                if (cartatablero6 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t6.Content = Convert.ToInt32(vidap1t6.Content) - Convert.ToInt32(ataquep2t4.Content);
                        vidap2t4.Content = Convert.ToInt32(vidap2t4.Content) - Convert.ToInt32(ataquep1t6.Content);
                        if (Convert.ToInt32(vidap1t6.Content) <= 0)
                        {
                            p1t6.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t4.Content) <= 0)
                        {
                            p2t4.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca7 == true)
            {
                if (cartatablero7 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t7.Content = Convert.ToInt32(vidap1t7.Content) - Convert.ToInt32(ataquep2t4.Content);
                        vidap2t4.Content = Convert.ToInt32(vidap2t4.Content) - Convert.ToInt32(ataquep1t7.Content);
                        if (Convert.ToInt32(vidap1t7.Content) <= 0)
                        {
                            p1t7.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t4.Content) <= 0)
                        {
                            p2t4.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

        }
        private void p1atacap2t5(object sender, MouseButtonEventArgs e)
        {


            var cartatablero1 = p1t1.Source.ToString().ToLower();
            var cartatablero2 = p1t2.Source.ToString().ToLower();
            var cartatablero3 = p1t3.Source.ToString().ToLower();
            var cartatablero4 = p1t4.Source.ToString().ToLower();
            var cartatablero5 = p1t5.Source.ToString().ToLower();
            var cartatablero6 = p1t6.Source.ToString().ToLower();
            var cartatablero7 = p1t7.Source.ToString().ToLower();
            var cartatablerop2 = p2t5.Source.ToString().ToLower();

            if (ataca2 == true)
            {
                if (p1t2.Source.ToString().ToLower() != cartaocultap1.Source.ToString().ToLower())
                {
                    if (p2t5.Source.ToString().ToLower() != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t2.Content = Convert.ToInt32(vidap1t2.Content) - Convert.ToInt32(ataquep2t5.Content);
                        vidap2t5.Content = Convert.ToInt32(vidap2t5.Content) - Convert.ToInt32(ataquep1t2.Content);
                        if (Convert.ToInt32(vidap1t2.Content) <= 0)
                        {
                            p1t2.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t5.Content) <= 0)
                        {
                            p2t5.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

            if (ataca1 == true)
            {
                if (cartatablero1 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t1.Content = Convert.ToInt32(vidap1t1.Content) - Convert.ToInt32(ataquep2t5.Content);
                        vidap2t5.Content = Convert.ToInt32(vidap2t5.Content) - Convert.ToInt32(ataquep1t1.Content);
                        if (Convert.ToInt32(vidap1t1.Content) <= 0)
                        {
                            p1t1.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t5.Content) <= 0)
                        {
                            p2t5.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

            if (ataca3 == true)
            {
                if (cartatablero3 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t3.Content = Convert.ToInt32(vidap1t3.Content) - Convert.ToInt32(ataquep2t5.Content);
                        vidap2t5.Content = Convert.ToInt32(vidap2t5.Content) - Convert.ToInt32(ataquep1t3.Content);
                        if (Convert.ToInt32(vidap1t3.Content) <= 0)
                        {
                            p1t3.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t5.Content) <= 0)
                        {
                            p2t5.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca4 == true)
            {
                if (cartatablero4 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t4.Content = Convert.ToInt32(vidap1t4.Content) - Convert.ToInt32(ataquep2t5.Content);
                        vidap2t5.Content = Convert.ToInt32(vidap2t5.Content) - Convert.ToInt32(ataquep1t4.Content);
                        if (Convert.ToInt32(vidap1t4.Content) <= 0)
                        {
                            p1t4.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t5.Content) <= 0)
                        {
                            p2t5.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca5 == true)
            {
                if (cartatablero5 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t5.Content = Convert.ToInt32(vidap1t5.Content) - Convert.ToInt32(ataquep2t5.Content);
                        vidap2t5.Content = Convert.ToInt32(vidap2t5.Content) - Convert.ToInt32(ataquep1t5.Content);
                        if (Convert.ToInt32(vidap1t5.Content) <= 0)
                        {
                            p1t5.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t5.Content) <= 0)
                        {
                            p2t5.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca6 == true)
            {
                if (cartatablero6 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t6.Content = Convert.ToInt32(vidap1t6.Content) - Convert.ToInt32(ataquep2t5.Content);
                        vidap2t5.Content = Convert.ToInt32(vidap2t5.Content) - Convert.ToInt32(ataquep1t6.Content);
                        if (Convert.ToInt32(vidap1t6.Content) <= 0)
                        {
                            p1t6.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t5.Content) <= 0)
                        {
                            p2t5.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca7 == true)
            {
                if (cartatablero7 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t7.Content = Convert.ToInt32(vidap1t7.Content) - Convert.ToInt32(ataquep2t5.Content);
                        vidap2t5.Content = Convert.ToInt32(vidap2t5.Content) - Convert.ToInt32(ataquep1t7.Content);
                        if (Convert.ToInt32(vidap1t7.Content) <= 0)
                        {
                            p1t7.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t5.Content) <= 0)
                        {
                            p2t5.Source = cartaocultap2.Source;
                        }
                    }
                }
            }



        }
        private void p1atacap2t6(object sender, MouseButtonEventArgs e)
        {


            var cartatablero1 = p1t1.Source.ToString().ToLower();
            var cartatablero2 = p1t2.Source.ToString().ToLower();
            var cartatablero3 = p1t3.Source.ToString().ToLower();
            var cartatablero4 = p1t4.Source.ToString().ToLower();
            var cartatablero5 = p1t5.Source.ToString().ToLower();
            var cartatablero6 = p1t6.Source.ToString().ToLower();
            var cartatablero7 = p1t7.Source.ToString().ToLower();
            var cartatablerop2 = p2t6.Source.ToString().ToLower();

            if (ataca2 == true)
            {
                if (p1t2.Source.ToString().ToLower() != cartaocultap1.Source.ToString().ToLower())
                {
                    if (p2t6.Source.ToString().ToLower() != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t2.Content = Convert.ToInt32(vidap1t2.Content) - Convert.ToInt32(ataquep2t6.Content);
                        vidap2t6.Content = Convert.ToInt32(vidap2t6.Content) - Convert.ToInt32(ataquep1t2.Content);
                        if (Convert.ToInt32(vidap1t2.Content) <= 0)
                        {
                            p1t2.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t6.Content) <= 0)
                        {
                            p2t6.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

            if (ataca1 == true)
            {
                if (cartatablero1 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t1.Content = Convert.ToInt32(vidap1t1.Content) - Convert.ToInt32(ataquep2t6.Content);
                        vidap2t6.Content = Convert.ToInt32(vidap2t6.Content) - Convert.ToInt32(ataquep1t1.Content);
                        if (Convert.ToInt32(vidap1t1.Content) <= 0)
                        {
                            p1t1.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t6.Content) <= 0)
                        {
                            p2t6.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

            if (ataca3 == true)
            {
                if (cartatablero3 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t3.Content = Convert.ToInt32(vidap1t3.Content) - Convert.ToInt32(ataquep2t6.Content);
                        vidap2t6.Content = Convert.ToInt32(vidap2t6.Content) - Convert.ToInt32(ataquep1t3.Content);
                        if (Convert.ToInt32(vidap1t3.Content) <= 0)
                        {
                            p1t3.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t6.Content) <= 0)
                        {
                            p2t6.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca4 == true)
            {
                if (cartatablero4 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t4.Content = Convert.ToInt32(vidap1t4.Content) - Convert.ToInt32(ataquep2t6.Content);
                        vidap2t6.Content = Convert.ToInt32(vidap2t6.Content) - Convert.ToInt32(ataquep1t4.Content);
                        if (Convert.ToInt32(vidap1t4.Content) <= 0)
                        {
                            p1t4.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t6.Content) <= 0)
                        {
                            p2t6.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca5 == true)
            {
                if (cartatablero5 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t5.Content = Convert.ToInt32(vidap1t5.Content) - Convert.ToInt32(ataquep2t6.Content);
                        vidap2t6.Content = Convert.ToInt32(vidap2t6.Content) - Convert.ToInt32(ataquep1t5.Content);
                        if (Convert.ToInt32(vidap1t5.Content) <= 0)
                        {
                            p1t5.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t6.Content) <= 0)
                        {
                            p2t6.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca6 == true)
            {
                if (cartatablero6 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t6.Content = Convert.ToInt32(vidap1t6.Content) - Convert.ToInt32(ataquep2t6.Content);
                        vidap2t6.Content = Convert.ToInt32(vidap2t6.Content) - Convert.ToInt32(ataquep1t6.Content);
                        if (Convert.ToInt32(vidap1t6.Content) <= 0)
                        {
                            p1t6.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t6.Content) <= 0)
                        {
                            p2t6.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca7 == true)
            {
                if (cartatablero7 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t7.Content = Convert.ToInt32(vidap1t7.Content) - Convert.ToInt32(ataquep2t6.Content);
                        vidap2t6.Content = Convert.ToInt32(vidap2t6.Content) - Convert.ToInt32(ataquep1t7.Content);
                        if (Convert.ToInt32(vidap1t7.Content) <= 0)
                        {
                            p1t7.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t6.Content) <= 0)
                        {
                            p2t6.Source = cartaocultap2.Source;
                        }
                    }
                }
            }



        }
        private void p1atacap2t7(object sender, MouseButtonEventArgs e)
        {


            var cartatablero1 = p1t1.Source.ToString().ToLower();
            var cartatablero2 = p1t2.Source.ToString().ToLower();
            var cartatablero3 = p1t3.Source.ToString().ToLower();
            var cartatablero4 = p1t4.Source.ToString().ToLower();
            var cartatablero5 = p1t5.Source.ToString().ToLower();
            var cartatablero6 = p1t6.Source.ToString().ToLower();
            var cartatablero7 = p1t7.Source.ToString().ToLower();
            var cartatablerop2 = p2t7.Source.ToString().ToLower();

            if (ataca2 == true)
            {
                if (p1t2.Source.ToString().ToLower() != cartaocultap1.Source.ToString().ToLower())
                {
                    if (p2t7.Source.ToString().ToLower() != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t2.Content = Convert.ToInt32(vidap1t2.Content) - Convert.ToInt32(ataquep2t7.Content);
                        vidap2t7.Content = Convert.ToInt32(vidap2t7.Content) - Convert.ToInt32(ataquep1t2.Content);
                        if (Convert.ToInt32(vidap1t2.Content) <= 0)
                        {
                            p1t2.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t7.Content) <= 0)
                        {
                            p2t7.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

            if (ataca1 == true)
            {
                if (cartatablero1 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t1.Content = Convert.ToInt32(vidap1t1.Content) - Convert.ToInt32(ataquep2t7.Content);
                        vidap2t7.Content = Convert.ToInt32(vidap2t7.Content) - Convert.ToInt32(ataquep1t1.Content);
                        if (Convert.ToInt32(vidap1t1.Content) <= 0)
                        {
                            p1t1.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t7.Content) <= 0)
                        {
                            p2t7.Source = cartaocultap2.Source;
                        }
                    }
                }
            }

            if (ataca3 == true)
            {
                if (cartatablero3 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t3.Content = Convert.ToInt32(vidap1t3.Content) - Convert.ToInt32(ataquep2t7.Content);
                        vidap2t7.Content = Convert.ToInt32(vidap2t7.Content) - Convert.ToInt32(ataquep1t3.Content);
                        if (Convert.ToInt32(vidap1t3.Content) <= 0)
                        {
                            p1t3.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t7.Content) <= 0)
                        {
                            p2t7.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca4 == true)
            {
                if (cartatablero4 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t4.Content = Convert.ToInt32(vidap1t4.Content) - Convert.ToInt32(ataquep2t7.Content);
                        vidap2t7.Content = Convert.ToInt32(vidap2t7.Content) - Convert.ToInt32(ataquep1t4.Content);
                        if (Convert.ToInt32(vidap1t4.Content) <= 0)
                        {
                            p1t4.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t7.Content) <= 0)
                        {
                            p2t7.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca5 == true)
            {
                if (cartatablero5 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t5.Content = Convert.ToInt32(vidap1t5.Content) - Convert.ToInt32(ataquep2t7.Content);
                        vidap2t7.Content = Convert.ToInt32(vidap2t7.Content) - Convert.ToInt32(ataquep1t5.Content);
                        if (Convert.ToInt32(vidap1t5.Content) <= 0)
                        {
                            p1t5.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t7.Content) <= 0)
                        {
                            p2t7.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca6 == true)
            {
                if (cartatablero6 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t6.Content = Convert.ToInt32(vidap1t6.Content) - Convert.ToInt32(ataquep2t7.Content);
                        vidap2t7.Content = Convert.ToInt32(vidap2t7.Content) - Convert.ToInt32(ataquep1t6.Content);
                        if (Convert.ToInt32(vidap1t6.Content) <= 0)
                        {
                            p1t6.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t7.Content) <= 0)
                        {
                            p2t7.Source = cartaocultap2.Source;
                        }
                    }
                }
            }
            else if (ataca7 == true)
            {
                if (cartatablero7 != cartaocultap1.Source.ToString().ToLower())
                {
                    if (cartatablerop2 != cartaocultap2.Source.ToString().ToLower())
                    {
                        vidap1t7.Content = Convert.ToInt32(vidap1t7.Content) - Convert.ToInt32(ataquep2t7.Content);
                        vidap2t7.Content = Convert.ToInt32(vidap2t7.Content) - Convert.ToInt32(ataquep1t7.Content);
                        if (Convert.ToInt32(vidap1t7.Content) <= 0)
                        {
                            p1t7.Source = cartaocultap1.Source;
                        }
                        if (Convert.ToInt32(vidap2t7.Content) <= 0)
                        {
                            p2t7.Source = cartaocultap2.Source;
                        }
                    }
                }
            }



        }
        // hasta aca p1 ataca a p2
        private void enter1(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                var contenido = txt11.Text;
                txt12.Text = contenido;
                txt12.IsEnabled = false;
            }
        }
        private void txt21_(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                continuar.Visibility = Visibility.Visible;
                var contenido = txt21.Text;
                txt22.Text = contenido;
                txt22.IsEnabled = false;
                int Continuar = 0;
                if (Continuar == 0)
                {
                    continuar.Visibility = Visibility.Visible;
                }
            }
        }

        private void Priestrb_Checked(object sender, RoutedEventArgs e)
        {
            Priest.Visibility = Visibility.Visible;
            Tablero.Visibility = Visibility.Visible;
            p1m1.Visibility = Visibility.Visible;
            Eleccion1.Visibility = Visibility.Hidden;
        }

        private void Magerb_Checked(object sender, RoutedEventArgs e)
        {


            Mage.Visibility = Visibility.Visible;

        }

        private void terminar1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Terminarturno2_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }

}
