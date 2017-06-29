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
            Minions wisp = new Minions("wisp", 0, 1, 1, "None", 0,"C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/wisp.png");
            Minions murloc = new Minions("Murloc Raider", 1, 1, 2, "Murloc", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/murloc.png");
            Minions blood = new Minions("Bloodfen Raptor", 2, 2, 3, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/raptor.png");
            Minions river = new Minions("River Crocolisk", 2, 3, 2, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/cocodrilo.png");
            Minions magma = new Minions("Magma Rager", 3, 1, 3, "Elemental", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/magmar.png");
            Minions chill = new Minions("chillwind Yeti", 4, 5, 4, "None", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/yeti.png");
            Minions oasis = new Minions("Oasis Snapjaw", 4, 7, 2, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/oasis.png");
            Minions ogre = new Minions("Boulderfist Ogre", 6, 7, 6, "None", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/ogro.png");
            Minions golem = new Minions("War Golem", 7, 7, 7, "None", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/golem.png");
            Minions hound = new Minions("Core Hound", 7, 5, 9, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/core.png");
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
            cristalp1.Content = 1;
            cristalp2.Content = 0;


            

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
                        p1t1.IsEnabled = false;
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
                        p1t1.IsEnabled = false;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep1t1.Content =" 2";
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
                        p1t1.IsEnabled = false;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep1t1.Content = "2";
                            vidap1t1.Content =" 1";
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
                        p1t1.IsEnabled = false;
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
                        p1t1.IsEnabled = false;
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
                        p1t1.IsEnabled = false;
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
                        p1t1.IsEnabled = false;
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
                        p1t1.IsEnabled = false;
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
                        p1t1.IsEnabled = false;
                        if (p1t1.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                        {

                            ataquep1t1.Content = "2";
                            vidap1t1.Content =" 1";
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
                    p1t2.IsEnabled = false;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t2.Content = "2";
                        vidap1t2.Content =" 1";
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
                    p1t2.IsEnabled = false;
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
                    p1t2.IsEnabled = false;
                    if (p1t2.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t2.Content =" 2";
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
                    p1t2.IsEnabled = false;
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
                    p1t1.IsEnabled = false;
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
                    p1t2.IsEnabled = false;
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
                    p1t2.IsEnabled = false;
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
                    p1t2.IsEnabled = false;
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
                    p1t2.IsEnabled = false;
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
                    p1t2.IsEnabled = false;
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
                    p1t3.IsEnabled = false;
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
                    p1t3.IsEnabled = false;
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
                    p1t3.IsEnabled = false;
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
                    p1t3.IsEnabled = false;
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
                    p1t3.IsEnabled = false;
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
                    p1t3.IsEnabled = false;
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
                    p1t3.IsEnabled = false;
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
                    p1t3.IsEnabled = false;
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
                    p1t3.IsEnabled = false;
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
                    p1t3.IsEnabled = false;
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
                    p1t4.IsEnabled = false;
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
                    p1t4.IsEnabled = false;
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
                    p1t4.IsEnabled = false;
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
                    p1t4.IsEnabled = false;
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
                    p1t1.IsEnabled = false;
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
                    p1t4.IsEnabled = false;
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
                    p1t4.IsEnabled = false;
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
                    p1t4.IsEnabled = false;
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
                    p1t4.IsEnabled = false;
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
                    p1t4.IsEnabled = false;
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
                    p1t5.IsEnabled = false;
                    if (p1t5.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t5.Content = "2";
                        vidap1t5.Content =" 1";
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
                    p1t5.IsEnabled = false;
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
                    p1t5.IsEnabled = false;
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
                    p1t5.IsEnabled = false;
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
                    p1t5.IsEnabled = false;
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
                    p1t5.IsEnabled = false;
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
                    p1t5.IsEnabled = false;
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
                    p1t5.IsEnabled = false;
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
                    p1t5.IsEnabled = false;
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
                    p1t5.IsEnabled = false;
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
                    p1t6.IsEnabled = false;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content ="1";
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
                    p1t6.IsEnabled = false;
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
                    p1t6.IsEnabled = false;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content ="1" ;

                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";

                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";

                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";

                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                    }
                }
            }
            if (cte4 == true)
            {
                if (p1m4.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano4;
                    p1m4.Source = cartaoriginal;
                    p1t6.IsEnabled = false;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";

                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";

                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";

                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                    }
                }
            }
            if (cte5 == true)
            {
                if (p1m5.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano5;
                    p1m5.Source = cartaoriginal;
                    p1t6.IsEnabled = false;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";

                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";

                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";

                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                    }
                }
            }
            if (cte6 == true)
            {
                if (p1m6.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano6;
                    p1m6.Source = cartaoriginal;
                    p1t6.IsEnabled = false;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";

                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";

                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";

                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                    }
                }
            }
            if (cte7 == true)
            {
                if (p1m3.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano7;
                    p1m7.Source = cartaoriginal;
                    p1t6.IsEnabled = false;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";

                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";

                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";

                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                    }
                }
            }
            if (cte8 == true)
            {
                if (p1m8.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano8;
                    p1m8.Source = cartaoriginal;
                    p1t6.IsEnabled = false;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";

                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";

                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";

                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                    }
                }
            }
            if (cte9 == true)
            {
                if (p1m9.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano9;
                    p1m9.Source = cartaoriginal;
                    p1t6.IsEnabled = false;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";

                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";

                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";

                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
                    }
                }
            }
            if (cte10 == true)
            {
                if (p1m10.Source != p1t6.Source)
                {
                    p1t6.Source = cartamano10;
                    p1m10.Source = cartaoriginal;
                    p1t6.IsEnabled = false;
                    if (p1t6.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 1";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 2";
                        vidap1t6.Content = "3";

                    }
                    else if (p1t6.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = " 3";
                        vidap1t6.Content = "2";

                    }
                    else if (p1t6.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "5";
                        vidap1t6.Content = "1";

                    }
                    else if (p1t6.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "4";
                        vidap1t6.Content = "5";

                    }
                    else if (p1t6.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "6";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t6.Content = "7";
                        vidap1t6.Content = "7";

                    }
                    else if (p1t6.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "2";
                        vidap1t6.Content = "7";
                    }
                    else if (p1t6.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t6.Content = "9";
                        vidap1t6.Content = "5";
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
                    p1t7.IsEnabled = false;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";

                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";

                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";

                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                    }
                }


            }
            if (cte2 == true)
            {
                if (p1m2.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano2;
                    p1m2.Source = cartaoriginal;
                    p1t7.IsEnabled = false;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";

                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";

                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";

                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                    }
                }
            }
            if (cte3 == true)
            {
                if (p1m3.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano3;
                    p1m3.Source = cartaoriginal;
                    p1t7.IsEnabled = false;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";

                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";

                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";

                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                    }
                }
            }
            if (cte4 == true)
            {
                if (p1m4.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano4;
                    p1m4.Source = cartaoriginal;
                    p1t7.IsEnabled = false;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";

                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";

                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";

                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                    }
                }
            }
            if (cte5 == true)
            {
                if (p1m5.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano5;
                    p1m5.Source = cartaoriginal;
                    p1t7.IsEnabled = false;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";

                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";

                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";

                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                    }
                }
            }
            if (cte6 == true)
            {
                if (p1m6.Source != p1t2.Source)
                {
                    p1t2.Source = cartamano6;
                    p1m6.Source = cartaoriginal;
                    p1t2.IsEnabled = false;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";

                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";

                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";

                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                    }
                }
            }
            if (cte7 == true)
            {
                if (p1m3.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano7;
                    p1m7.Source = cartaoriginal;
                    p1t7.IsEnabled = false;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";

                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";

                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";

                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                    }
                }
            }
            if (cte8 == true)
            {
                if (p1m8.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano8;
                    p1m8.Source = cartaoriginal;
                    p1t7.IsEnabled = false;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";

                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";

                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";

                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                    }
                }
            }
            if (cte9 == true)
            {
                if (p1m9.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano9;
                    p1m9.Source = cartaoriginal;
                    p1t7.IsEnabled = false;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";

                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";

                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";

                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                    }
                }
            }
            if (cte10 == true)
            {
                if (p1m10.Source != p1t7.Source)
                {
                    p1t7.Source = cartamano10;
                    p1m10.Source = cartaoriginal;
                    p1t7.IsEnabled = false;
                    if (p1t7.Source.ToString().ToLower() == murloc0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == wisp0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 1";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == cocodrilo0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 2";
                        vidap1t7.Content = "3";

                    }
                    else if (p1t7.Source.ToString().ToLower() == raptor0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = " 3";
                        vidap1t7.Content = "2";

                    }
                    else if (p1t7.Source.ToString().ToLower() == magmar0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "5";
                        vidap1t7.Content = "1";

                    }
                    else if (p1t7.Source.ToString().ToLower() == yeti0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "4";
                        vidap1t7.Content = "5";

                    }
                    else if (p1t7.Source.ToString().ToLower() == ogro0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "6";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == golem0.Source.ToString().ToLower())
                    {

                        ataquep1t7.Content = "7";
                        vidap1t7.Content = "7";

                    }
                    else if (p1t7.Source.ToString().ToLower() == oasis0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "2";
                        vidap1t7.Content = "7";
                    }
                    else if (p1t7.Source.ToString().ToLower() == core0.Source.ToString().ToLower())
                    {
                        ataquep1t7.Content = "9";
                        vidap1t7.Content = "5";
                    }
                }
            }
        }

        private void p2m1e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2m2e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2m3e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2m4e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2m5e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2m6e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2m7e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2m8e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2m9e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2m10e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2t1e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2t2e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2t3e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2t4e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2t5e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2t6e(object sender, MouseButtonEventArgs e)
        {

        }

        private void p2t7e(object sender, MouseButtonEventArgs e)
        {

        }

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
            Eleccion2.Visibility = Visibility.Visible;
            Priestrb1.Visibility = Visibility.Visible;
            Rougerb1.Visibility = Visibility.Visible;
            Rexxarrb1.Visibility = Visibility.Visible;
            Warlocb1.Visibility = Visibility.Visible;
            Warriorb1.Visibility = Visibility.Visible;
            Magerb1.Visibility = Visibility.Visible;
            Shamanrb1.Visibility = Visibility.Visible;
            Druidrb1.Visibility = Visibility.Visible;
            paladinrb1.Visibility = Visibility.Visible;
            InfoPriest1.Visibility = Visibility.Visible;
            InfoRouege1.Visibility = Visibility.Visible;
            InfoRexxar1.Visibility = Visibility.Visible;
            InfoWarloc1.Visibility = Visibility.Visible;
            InfoDruid1.Visibility = Visibility.Visible;
            InfoMage1.Visibility = Visibility.Visible;
            InfoShaman1.Visibility = Visibility.Visible;
            InfoPaladin1.Visibility = Visibility.Visible;
            InfoWarrior1.Visibility = Visibility.Visible;


            

        }

        private void Magerb_Checked(object sender, RoutedEventArgs e)
        {


            Mage.Visibility = Visibility.Visible;
            Eleccion2.Visibility = Visibility.Visible;
            Priestrb1.Visibility = Visibility.Visible;
            Rougerb1.Visibility = Visibility.Visible;
            Rexxarrb1.Visibility = Visibility.Visible;
            Warlocb1.Visibility = Visibility.Visible;
            Warriorb1.Visibility = Visibility.Visible;
            Magerb1.Visibility = Visibility.Visible;
            Shamanrb1.Visibility = Visibility.Visible;
            Druidrb1.Visibility = Visibility.Visible;
            paladinrb1.Visibility = Visibility.Visible;
            InfoPriest1.Visibility = Visibility.Visible;
            InfoRouege1.Visibility = Visibility.Visible;
            InfoRexxar1.Visibility = Visibility.Visible;
            InfoWarloc1.Visibility = Visibility.Visible;
            InfoDruid1.Visibility = Visibility.Visible;
            InfoMage1.Visibility = Visibility.Visible;
            InfoShaman1.Visibility = Visibility.Visible;
            InfoPaladin1.Visibility = Visibility.Visible;
            InfoWarrior1.Visibility = Visibility.Visible;

        }

        private void terminar1_Click(object sender, RoutedEventArgs e)  
        {
            
            Mazo m2 = new Mazo();
            Hunter Hunter2 = new Hunter("Rexxar", 30, "Steady Shot", 0);
            string jugador2 = "puxilupi";
            Jugador p2 = new Jugador(jugador2, 1, 0, m2.mazito, 0, 0, Hunter2);
            Minions wisp = new Minions("wisp", 0, 1, 1, "None", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/wisp.png");
            Minions murloc = new Minions("Murloc Raider", 1, 1, 2, "Murloc", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/murloc.png");
            Minions blood = new Minions("Bloodfen Raptor", 2, 2, 3, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/raptor.png");
            Minions river = new Minions("River Crocolisk", 2, 3, 2, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/cocodrilo.png");
            Minions magma = new Minions("Magma Rager", 3, 1, 3, "Elemental", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/magmar.png");
            Minions chill = new Minions("chillwind Yeti", 4, 5, 4, "None", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/yeti.png");
            Minions oasis = new Minions("Oasis Snapjaw", 4, 7, 2, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/oasis.png");
            Minions ogre = new Minions("Boulderfist Ogre", 6, 7, 6, "None", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/ogro.png");
            Minions golem = new Minions("War Golem", 7, 7, 7, "None", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/golem.png");
            Minions hound = new Minions("Core Hound", 7, 5, 9, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/core.png");
            m2.AgregarCarta(wisp);
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
            cristalp2.Content = Convert.ToInt32(cristalp2.Content) + 1;
            if (Convert.ToInt32(cristalp2.Content) > 10)
            {
                cristalp2.Content = 10;
            }
            if (p2m1.Source.ToString().ToLower() == cartaocultap2.Source.ToString().ToLower())
            {
                p2m1.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            }
            else if (p2m2.Source.ToString().ToLower() == cartaocultap2.Source.ToString().ToLower())
            {
                p2m2.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            }
            else if (p2m3.Source.ToString().ToLower() == cartaocultap2.Source.ToString().ToLower())
            {
                p2m3.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            }
            else if (p2m4.Source.ToString().ToLower() == cartaocultap2.Source.ToString().ToLower())
            {
                p2m4.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            }
            else if (p2m5.Source.ToString().ToLower() == cartaocultap2.Source.ToString().ToLower())
            {
                p2m5.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            }
            else if (p2m6.Source.ToString().ToLower() == cartaocultap2.Source.ToString().ToLower())
            {
                p2m6.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            }
            else if (p2m7.Source.ToString().ToLower() == cartaocultap2.Source.ToString().ToLower())
            {
                p2m7.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            }
            else if (p2m8.Source.ToString().ToLower() == cartaocultap2.Source.ToString().ToLower())
            {
                p2m8.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            }
            else if (p2m9.Source.ToString().ToLower() == cartaocultap2.Source.ToString().ToLower())
            {
                p2m9.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            }
            else if (p2m10.Source.ToString().ToLower() == cartaocultap2.Source.ToString().ToLower())
            {
                p2m10.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
            }
            else
            {
                MessageBox.Show("tienes mas de 10 cartas en la mano");
                cartamuertap2.Visibility = Visibility.Visible;
                cartamuertap2.Source = new BitmapImage(new Uri(p2.SacarCarta(m2).Source));
                MessageBox.Show("carta eliminada");
                cartamuertap2.Visibility = Visibility.Hidden;
                cartamuertap2.Source = cartaocultap2.Source;
            }
            Terminarturno2.Visibility = Visibility.Visible;
            terminar1.Visibility = Visibility.Hidden;
        }

        public void Terminarturno2_Click(object sender, RoutedEventArgs e) 
        {
            Mazo m = new Mazo();
            Hunter Hunter1 = new Hunter("Rexxar", 30, "Steady Shot", 0);
            string jugador1 = "puxilupi";
            Jugador p1 = new Jugador(jugador1, 1, 0, m.mazito, 0, 0, Hunter1);
            Minions wisp = new Minions("wisp", 0, 1, 1, "None", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/wisp.png");
            Minions murloc = new Minions("Murloc Raider", 1, 1, 2, "Murloc", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/murloc.png");
            Minions blood = new Minions("Bloodfen Raptor", 2, 2, 3, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/raptor.png");
            Minions river = new Minions("River Crocolisk", 2, 3, 2, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/cocodrilo.png");
            Minions magma = new Minions("Magma Rager", 3, 1, 3, "Elemental", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/magmar.png");
            Minions chill = new Minions("chillwind Yeti", 4, 5, 4, "None", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/yeti.png");
            Minions oasis = new Minions("Oasis Snapjaw", 4, 7, 2, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/oasis.png");
            Minions ogre = new Minions("Boulderfist Ogre", 6, 7, 6, "None", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/ogro.png");
            Minions golem = new Minions("War Golem", 7, 7, 7, "None", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/golem.png");
            Minions hound = new Minions("Core Hound", 7, 5, 9, "Beast", 0, "C:/Users/CarmenPazTorresPrade/Documents/Visual Studio 2017/Projects/Entrega 3/Entrega 3/Interfaz Grafica/core.png");
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
            cristalp1.Content = Convert.ToInt32(cristalp1.Content) + 1;
            if (Convert.ToInt32(cristalp1.Content) > 10)
            {
                cristalp1.Content = 10;
            }
            if (p1m1.Source.ToString().ToLower() == cartaocultap1.Source.ToString().ToLower())
            {
                p1m1.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            }
            else if (p1m2.Source.ToString().ToLower() == cartaocultap1.Source.ToString().ToLower())
            {
                p1m2.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            }
            else if (p1m3.Source.ToString().ToLower() == cartaocultap1.Source.ToString().ToLower())
            {
                p1m3.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            }
            else if (p1m4.Source.ToString().ToLower() == cartaocultap1.Source.ToString().ToLower())
            {
                p1m4.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            }
            else if (p1m5.Source.ToString().ToLower() == cartaocultap1.Source.ToString().ToLower())
            {
                p1m5.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            }
            else if (p1m6.Source.ToString().ToLower() == cartaocultap1.Source.ToString().ToLower())
            {
                p1m6.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            }
            else if (p1m7.Source.ToString().ToLower() == cartaocultap1.Source.ToString().ToLower())
            {
                p1m7.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            }
            else if (p1m8.Source.ToString().ToLower() == cartaocultap1.Source.ToString().ToLower())
            {
                p1m8.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            }
            else if (p1m9.Source.ToString().ToLower() == cartaocultap1.Source.ToString().ToLower())
            {
                p1m9.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            }
            else if (p1m10.Source.ToString().ToLower() == cartaocultap1.Source.ToString().ToLower())
            {
                p1m10.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
            }
            else
            {
                MessageBox.Show("tienes mas de 10 cartas en la mano");
                cartamuertap1.Visibility = Visibility.Visible;
                cartamuertap1.Source = new BitmapImage(new Uri(p1.SacarCarta(m).Source));
                MessageBox.Show("carta eliminada");
                cartamuertap1.Visibility = Visibility.Hidden;
                cartamuertap1.Source = cartaocultap1.Source;
            }
            terminar1.Visibility = Visibility.Visible;
            Terminarturno2.Visibility = Visibility.Hidden;
        }

        private void warlocb_Checked(object sender, RoutedEventArgs e)
        {
            Warloc.Visibility = Visibility.Visible;
            Eleccion2.Visibility = Visibility.Visible;
            Priestrb1.Visibility = Visibility.Visible;
            Rougerb1.Visibility = Visibility.Visible;
            Rexxarrb1.Visibility = Visibility.Visible;
            Warlocb1.Visibility = Visibility.Visible;
            Warriorb1.Visibility = Visibility.Visible;
            Magerb1.Visibility = Visibility.Visible;
            Shamanrb1.Visibility = Visibility.Visible;
            Druidrb1.Visibility = Visibility.Visible;
            paladinrb1.Visibility = Visibility.Visible;
            InfoPriest1.Visibility = Visibility.Visible;
            InfoRouege1.Visibility = Visibility.Visible;
            InfoRexxar1.Visibility = Visibility.Visible;
            InfoWarloc1.Visibility = Visibility.Visible;
            InfoDruid1.Visibility = Visibility.Visible;
            InfoMage1.Visibility = Visibility.Visible;
            InfoShaman1.Visibility = Visibility.Visible;
            InfoPaladin1.Visibility = Visibility.Visible;
            InfoWarrior1.Visibility = Visibility.Visible;
        }

        private void warriorb_Checked(object sender, RoutedEventArgs e)
        {
            Warrior.Visibility = Visibility.Visible;
            Eleccion2.Visibility = Visibility.Visible;
            Priestrb1.Visibility = Visibility.Visible;
            Rougerb1.Visibility = Visibility.Visible;
            Rexxarrb1.Visibility = Visibility.Visible;
            Warlocb1.Visibility = Visibility.Visible;
            Warriorb1.Visibility = Visibility.Visible;
            Magerb1.Visibility = Visibility.Visible;
            Shamanrb1.Visibility = Visibility.Visible;
            Druidrb1.Visibility = Visibility.Visible;
            paladinrb1.Visibility = Visibility.Visible;
            InfoPriest1.Visibility = Visibility.Visible;
            InfoRouege1.Visibility = Visibility.Visible;
            InfoRexxar1.Visibility = Visibility.Visible;
            InfoWarloc1.Visibility = Visibility.Visible;
            InfoDruid1.Visibility = Visibility.Visible;
            InfoMage1.Visibility = Visibility.Visible;
            InfoShaman1.Visibility = Visibility.Visible;
            InfoPaladin1.Visibility = Visibility.Visible;
            InfoWarrior1.Visibility = Visibility.Visible;
        }

        private void druidb_Checked(object sender, RoutedEventArgs e)
        {
            Druid.Visibility = Visibility.Visible;
            Eleccion2.Visibility = Visibility.Visible;
            Priestrb1.Visibility = Visibility.Visible;
            Rougerb1.Visibility = Visibility.Visible;
            Rexxarrb1.Visibility = Visibility.Visible;
            Warlocb1.Visibility = Visibility.Visible;
            Warriorb1.Visibility = Visibility.Visible;
            Magerb1.Visibility = Visibility.Visible;
            Shamanrb1.Visibility = Visibility.Visible;
            Druidrb1.Visibility = Visibility.Visible;
            paladinrb1.Visibility = Visibility.Visible;
            InfoPriest1.Visibility = Visibility.Visible;
            InfoRouege1.Visibility = Visibility.Visible;
            InfoRexxar1.Visibility = Visibility.Visible;
            InfoWarloc1.Visibility = Visibility.Visible;
            InfoDruid1.Visibility = Visibility.Visible;
            InfoMage1.Visibility = Visibility.Visible;
            InfoShaman1.Visibility = Visibility.Visible;
            InfoPaladin1.Visibility = Visibility.Visible;
            InfoWarrior1.Visibility = Visibility.Visible;

        }

        private void shamanb_Checked(object sender, RoutedEventArgs e)
        {
            Shaman.Visibility = Visibility.Visible;
            Eleccion2.Visibility = Visibility.Visible;
            Priestrb1.Visibility = Visibility.Visible;
            Rougerb1.Visibility = Visibility.Visible;
            Rexxarrb1.Visibility = Visibility.Visible;
            Warlocb1.Visibility = Visibility.Visible;
            Warriorb1.Visibility = Visibility.Visible;
            Magerb1.Visibility = Visibility.Visible;
            Shamanrb1.Visibility = Visibility.Visible;
            Druidrb1.Visibility = Visibility.Visible;
            paladinrb1.Visibility = Visibility.Visible;
            InfoPriest1.Visibility = Visibility.Visible;
            InfoRouege1.Visibility = Visibility.Visible;
            InfoRexxar1.Visibility = Visibility.Visible;
            InfoWarloc1.Visibility = Visibility.Visible;
            InfoDruid1.Visibility = Visibility.Visible;
            InfoMage1.Visibility = Visibility.Visible;
            InfoShaman1.Visibility = Visibility.Visible;
            InfoPaladin1.Visibility = Visibility.Visible;
            InfoWarrior1.Visibility = Visibility.Visible;
        }

        private void Rougerb_Checked(object sender, RoutedEventArgs e)
        {
            Rouge.Visibility = Visibility.Visible;
            Eleccion2.Visibility = Visibility.Visible;
            Priestrb1.Visibility = Visibility.Visible;
            Rougerb1.Visibility = Visibility.Visible;
            Rexxarrb1.Visibility = Visibility.Visible;
            Warlocb1.Visibility = Visibility.Visible;
            Warriorb1.Visibility = Visibility.Visible;
            Magerb1.Visibility = Visibility.Visible;
            Shamanrb1.Visibility = Visibility.Visible;
            Druidrb1.Visibility = Visibility.Visible;
            paladinrb1.Visibility = Visibility.Visible;
            InfoPriest1.Visibility = Visibility.Visible;
            InfoRouege1.Visibility = Visibility.Visible;
            InfoRexxar1.Visibility = Visibility.Visible;
            InfoWarloc1.Visibility = Visibility.Visible;
            InfoDruid1.Visibility = Visibility.Visible;
            InfoMage1.Visibility = Visibility.Visible;
            InfoShaman1.Visibility = Visibility.Visible;
            InfoPaladin1.Visibility = Visibility.Visible;
            InfoWarrior1.Visibility = Visibility.Visible;
        }

        private void paladinb_Checked(object sender, RoutedEventArgs e)
        {
            Paladin.Visibility = Visibility.Visible;
            Eleccion2.Visibility = Visibility.Visible;
            Priestrb1.Visibility = Visibility.Visible;
            Rougerb1.Visibility = Visibility.Visible;
            Rexxarrb1.Visibility = Visibility.Visible;
            Warlocb1.Visibility = Visibility.Visible;
            Warriorb1.Visibility = Visibility.Visible;
            Magerb1.Visibility = Visibility.Visible;
            Shamanrb1.Visibility = Visibility.Visible;
            Druidrb1.Visibility = Visibility.Visible;
            paladinrb1.Visibility = Visibility.Visible;
            InfoPriest1.Visibility = Visibility.Visible;
            InfoRouege1.Visibility = Visibility.Visible;
            InfoRexxar1.Visibility = Visibility.Visible;
            InfoWarloc1.Visibility = Visibility.Visible;
            InfoDruid1.Visibility = Visibility.Visible;
            InfoMage1.Visibility = Visibility.Visible;
            InfoShaman1.Visibility = Visibility.Visible;
            InfoPaladin1.Visibility = Visibility.Visible;
            InfoWarrior1.Visibility = Visibility.Visible;
        }

        private void Rexxarb_Checked(object sender, RoutedEventArgs e)
        {
            Rexxar.Visibility = Visibility.Visible;
            Eleccion2.Visibility = Visibility.Visible;
            Priestrb1.Visibility = Visibility.Visible;
            Rougerb1.Visibility = Visibility.Visible;
            Rexxarrb1.Visibility = Visibility.Visible;
            Warlocb1.Visibility = Visibility.Visible;
            Warriorb1.Visibility = Visibility.Visible;
            Magerb1.Visibility = Visibility.Visible;
            Shamanrb1.Visibility = Visibility.Visible;
            Druidrb1.Visibility = Visibility.Visible;
            paladinrb1.Visibility = Visibility.Visible;
            InfoPriest1.Visibility = Visibility.Visible;
            InfoRouege1.Visibility = Visibility.Visible;
            InfoRexxar1.Visibility = Visibility.Visible;
            InfoWarloc1.Visibility = Visibility.Visible;
            InfoDruid1.Visibility = Visibility.Visible;
            InfoMage1.Visibility = Visibility.Visible;
            InfoShaman1.Visibility = Visibility.Visible;
            InfoPaladin1.Visibility = Visibility.Visible;
            InfoWarrior1.Visibility = Visibility.Visible;

        }

        private void infopriest_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Este heroe es un sacerdote de la epoca medieval, es muy conocido en las tierras de Azeroth ya que hace mucho tiempo dio su vida para revevir al fenix sagrado de la region y asi salvo a la habitantes de ventormenta de una peste verde. Por eso su habilidad especial es restaurar 2 de vida en honor a esta gran hazaña");
        }

        private void inforouge_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Antes de ser una Picara, Jordana de las Mercedes estaba a punto de comprometerse con el amor de su vida, pero un dia antes de la boda encuentra a su amado con otra. Fue tanta la decepcion en su corazon que decidio abandonar su vida llena de comodidades y riquezas, decidio convertirse en pirata y navegar los 7 mares en busca de la mejor venganza. Su habilidad especial es atacar uno a cualquiera que se le cruze");

        }

        private void inforexxar_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Este hombre, no fue siempre ermitaño y criador de lobos en las llanuras solitarias, antes fue un condecorado banquetero pero se dio cuenta que la vida asi no tenia sentido alguno, por eso deicidio migrar muy lejos y empezar a vivir con sus propias reglas. Su habilidad es atacar con dos puntos de ataque a quien desee juzgarlo  ");

        }

        private void infopaladin_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hijo del rey Astuto, nieto del rey Elocuaz, una decendencia envidiable para los ojos de cualquiera, que hara lo que sea para ser el mejor de su linaje. Su espada contiene la habilidad de traer a la vida un escudero que lo ayudara en su flameble aventura  ");
        }

        private void infowarloc_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reucelio el Sarcedorte, el enviado de Dios mas querido por los habitantes de Pueblo Blanco, humilde y lleno de fe. Hasta que un día descubre un viejo pergamino en las ruinas de Lordaeron. En este pergamino estaba la verdadera historia de la sagrada escritura, devastado y arruinado por este descubrimiento comienza a tomar el camino de las tinieblas, volviendose en un mago oscuro y perverso. Su habilidad creada por la decepcion y el odio es sacrificar dos de vida para sacar una carta, quien lo mira a los ojos se convierte en sombras");
        }

        private void infowarrior_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Diguieto, lider de los guerreros de Ogrimmar y experto en programacion, ha decido enfrentar a quien se le ponga en su camino, Osado y programador su habilidad especial es ganar dos de aramadura, esta es programada por el amor que tiene en su gran corazon");
        }

        private void infoMage_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("L'Poxitte es una Maga Oscura, proviniente de Kirin Tor, sus habilidades y astucia la han llevado a ser una de las contricantes mas temidas. Pero esta joven maga, no le interesa su reputación sino  encontrar el verdadero amor, du habilidad especial es atacar uno a la que ella  elige, asi que no la desafies.");
;        }

        private void infoShaman_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HipoNuka, un chaman lider de Earthen Ring, un lugar lleno de tiernos animales y bellas flores, tiene la habilidad de invocar1 de  4 tottem al azar ");
        }

        private void infoDruid_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Antiguo y misterioso es heroe tiene la habilidad de tener uno de armadura y uno de ataque");
        }

   

        private void infoRouge1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Antes de ser una Picara, Jordana de las Mercedes estaba a punto de comprometerse con el amor de su vida, pero un dia antes de la boda encuentra a su amado con otra. Fue tanta la decepcion en su corazon que decidio abandonar su vida llena de comodidades y riquezas, decidio convertirse en pirata y navegar los 7 mares en busca de la mejor venganza. Su habilidad especial es atacar uno a cualquiera que se le cruze");
        }

        private void infoRexxar1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Este hombre, no fue siempre ermitaño y criador de lobos en las llanuras solitarias, antes fue un condecorado banquetero pero se dio cuenta que la vida asi no tenia sentido alguno, por eso deicidio migrar muy lejos y empezar a vivir con sus propias reglas. Su habilidad es atacar con dos puntos de ataque a quien desee juzgarlo  ");
        }

        private void infopaladin1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hijo del rey Astuto, nieto del rey Elocuaz, una decendencia envidiable para los ojos de cualquiera, que hara lo que sea para ser el mejor de su linaje. Su espada contiene la habilidad de traer a la vida un escudero que lo ayudara en su flameble aventura  ");
        }

        private void infowarloc1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reucelio el Sarcedorte, el enviado de Dios mas querido por los habitantes de Pueblo Blanco, humilde y lleno de fe. Hasta que un día descubre un viejo pergamino en las ruinas de Lordaeron. En este pergamino estaba la verdadera historia de la sagrada escritura, devastado y arruinado por este descubrimiento comienza a tomar el camino de las tinieblas, volviendose en un mago oscuro y perverso. Su habilidad creada por la decepcion y el odio es sacrificar dos de vida para sacar una carta, quien lo mira a los ojos se convierte en sombras");
        }

        private void infoWarrior1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Diguieto, lider de los guerreros de Ogrimmar y experto en programacion, ha decido enfrentar a quien se le ponga en su camino, Osado y programador su habilidad especial es ganar dos de aramadura, esta es programada por el amor que tiene en su gran corazon");
        }

        private void infoMage1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("L'Poxitte es una Maga Oscura, proviniente de Kirin Tor, sus habilidades y astucia la han llevado a ser una de las contricantes mas temidas. Pero esta joven maga, no le interesa su reputación sino  encontrar el verdadero amor, du habilidad especial es atacar uno a la que ella  elige, asi que no la desafies.");
        }

        private void infoShaman1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HipoNuka, un chaman lider de Earthen Ring, un lugar lleno de tiernos animales y bellas flores, tiene la habilidad de invocar1 de  4 tottem al azar ");
        }

        private void infoDruid1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Antiguo y misterioso es heroe tiene la habilidad de tener uno de armadura y uno de ataque");
        }

        private void Rexxar1_Checked(object sender, RoutedEventArgs e)
        {
            Rexxar1.Visibility = Visibility.Visible;
            Tablero.Visibility = Visibility.Visible;
            txt22.Visibility = Visibility.Visible;
            txt12.Visibility = Visibility.Visible;
            terminar1.Visibility = Visibility.Visible;
            cristalp1.Visibility = Visibility.Visible;
            cristalp2.Visibility = Visibility.Visible;
            vidap1.Visibility = Visibility.Visible;
            vidap2.Visibility = Visibility.Visible;
            p1m1.Visibility = Visibility.Visible;
            p1m2.Visibility = Visibility.Visible;
            p1m3.Visibility = Visibility.Visible;
            p1m4.Visibility = Visibility.Visible;
            p1m5.Visibility = Visibility.Visible;
            p1m6.Visibility = Visibility.Visible;
            p1m7.Visibility = Visibility.Visible;
            p1m8.Visibility = Visibility.Visible;
            p1m9.Visibility = Visibility.Visible;
            p1m10.Visibility = Visibility.Visible;
            p1t1.Visibility = Visibility.Visible;
            p1t2.Visibility = Visibility.Visible;
            p1t3.Visibility = Visibility.Visible;
            p1t4.Visibility = Visibility.Visible;
            p1t5.Visibility = Visibility.Visible;
            p1t6.Visibility = Visibility.Visible;
            p1t7.Visibility = Visibility.Visible;
            p2m1.Visibility = Visibility.Visible;
            p2m2.Visibility = Visibility.Visible;
            p2m3.Visibility = Visibility.Visible;
            p2m4.Visibility = Visibility.Visible;
            p2m5.Visibility = Visibility.Visible;
            p2m6.Visibility = Visibility.Visible;
            p2m7.Visibility = Visibility.Visible;
            p2m8.Visibility = Visibility.Visible;
            p2m9.Visibility = Visibility.Visible;
            p2m10.Visibility = Visibility.Visible;
            p2t1.Visibility = Visibility.Visible;
            p2t2.Visibility = Visibility.Visible;
            p2t3.Visibility = Visibility.Visible;
            p2t4.Visibility = Visibility.Visible;
            p2t5.Visibility = Visibility.Visible;
            p2t6.Visibility = Visibility.Visible;
            p2t7.Visibility = Visibility.Visible;
        }

        private void Rougerb1_Checked(object sender, RoutedEventArgs e)
        {
            Rouge1.Visibility = Visibility.Visible;
            Tablero.Visibility = Visibility.Visible;
            txt22.Visibility = Visibility.Visible;
            txt12.Visibility = Visibility.Visible;
            terminar1.Visibility = Visibility.Visible;
            
            cristalp1.Visibility = Visibility.Visible;
            cristalp2.Visibility = Visibility.Visible;
            vidap1.Visibility = Visibility.Visible;
            vidap2.Visibility = Visibility.Visible;
            p1m1.Visibility = Visibility.Visible;
            p1m2.Visibility = Visibility.Visible;
            p1m3.Visibility = Visibility.Visible;
            p1m4.Visibility = Visibility.Visible;
            p1m5.Visibility = Visibility.Visible;
            p1m6.Visibility = Visibility.Visible;
            p1m7.Visibility = Visibility.Visible;
            p1m8.Visibility = Visibility.Visible;
            p1m9.Visibility = Visibility.Visible;
            p1m10.Visibility = Visibility.Visible;
            p1t1.Visibility = Visibility.Visible;
            p1t2.Visibility = Visibility.Visible;
            p1t3.Visibility = Visibility.Visible;
            p1t4.Visibility = Visibility.Visible;
            p1t5.Visibility = Visibility.Visible;
            p1t6.Visibility = Visibility.Visible;
            p1t7.Visibility = Visibility.Visible;
            p2m1.Visibility = Visibility.Visible;
            p2m2.Visibility = Visibility.Visible;
            p2m3.Visibility = Visibility.Visible;
            p2m4.Visibility = Visibility.Visible;
            p2m5.Visibility = Visibility.Visible;
            p2m6.Visibility = Visibility.Visible;
            p2m7.Visibility = Visibility.Visible;
            p2m8.Visibility = Visibility.Visible;
            p2m9.Visibility = Visibility.Visible;
            p2m10.Visibility = Visibility.Visible;
            p2t1.Visibility = Visibility.Visible;
            p2t2.Visibility = Visibility.Visible;
            p2t3.Visibility = Visibility.Visible;
            p2t4.Visibility = Visibility.Visible;
            p2t5.Visibility = Visibility.Visible;
            p2t6.Visibility = Visibility.Visible;
            p2t7.Visibility = Visibility.Visible;
        }

        private void Druidrb1_Checked(object sender, RoutedEventArgs e)
        {
            Druid1.Visibility = Visibility;
            Tablero.Visibility = Visibility.Visible;
            txt22.Visibility = Visibility.Visible;
            txt12.Visibility = Visibility.Visible;
            terminar1.Visibility = Visibility.Visible;
          
            cristalp1.Visibility = Visibility.Visible;
            cristalp2.Visibility = Visibility.Visible;
            vidap1.Visibility = Visibility.Visible;
            vidap2.Visibility = Visibility.Visible;
            p1m1.Visibility = Visibility.Visible;
            p1m2.Visibility = Visibility.Visible;
            p1m3.Visibility = Visibility.Visible;
            p1m4.Visibility = Visibility.Visible;
            p1m5.Visibility = Visibility.Visible;
            p1m6.Visibility = Visibility.Visible;
            p1m7.Visibility = Visibility.Visible;
            p1m8.Visibility = Visibility.Visible;
            p1m9.Visibility = Visibility.Visible;
            p1m10.Visibility = Visibility.Visible;
            p1t1.Visibility = Visibility.Visible;
            p1t2.Visibility = Visibility.Visible;
            p1t3.Visibility = Visibility.Visible;
            p1t4.Visibility = Visibility.Visible;
            p1t5.Visibility = Visibility.Visible;
            p1t6.Visibility = Visibility.Visible;
            p1t7.Visibility = Visibility.Visible;
            p2m1.Visibility = Visibility.Visible;
            p2m2.Visibility = Visibility.Visible;
            p2m3.Visibility = Visibility.Visible;
            p2m4.Visibility = Visibility.Visible;
            p2m5.Visibility = Visibility.Visible;
            p2m6.Visibility = Visibility.Visible;
            p2m7.Visibility = Visibility.Visible;
            p2m8.Visibility = Visibility.Visible;
            p2m9.Visibility = Visibility.Visible;
            p2m10.Visibility = Visibility.Visible;
            p2t1.Visibility = Visibility.Visible;
            p2t2.Visibility = Visibility.Visible;
            p2t3.Visibility = Visibility.Visible;
            p2t4.Visibility = Visibility.Visible;
            p2t5.Visibility = Visibility.Visible;
            p2t6.Visibility = Visibility.Visible;
            p2t7.Visibility = Visibility.Visible;
        }

        private void Shamanrb1_Checked(object sender, RoutedEventArgs e)
        {
            Shaman1.Visibility = Visibility.Visible;
            Tablero.Visibility = Visibility.Visible;
            txt22.Visibility = Visibility.Visible;
            txt12.Visibility = Visibility.Visible;
            terminar1.Visibility = Visibility.Visible;
            
            cristalp1.Visibility = Visibility.Visible;
            cristalp2.Visibility = Visibility.Visible;
            vidap1.Visibility = Visibility.Visible;
            vidap2.Visibility = Visibility.Visible;
            p1m1.Visibility = Visibility.Visible;
            p1m2.Visibility = Visibility.Visible;
            p1m3.Visibility = Visibility.Visible;
            p1m4.Visibility = Visibility.Visible;
            p1m5.Visibility = Visibility.Visible;
            p1m6.Visibility = Visibility.Visible;
            p1m7.Visibility = Visibility.Visible;
            p1m8.Visibility = Visibility.Visible;
            p1m9.Visibility = Visibility.Visible;
            p1m10.Visibility = Visibility.Visible;
            p1t1.Visibility = Visibility.Visible;
            p1t2.Visibility = Visibility.Visible;
            p1t3.Visibility = Visibility.Visible;
            p1t4.Visibility = Visibility.Visible;
            p1t5.Visibility = Visibility.Visible;
            p1t6.Visibility = Visibility.Visible;
            p1t7.Visibility = Visibility.Visible;
            p2m1.Visibility = Visibility.Visible;
            p2m2.Visibility = Visibility.Visible;
            p2m3.Visibility = Visibility.Visible;
            p2m4.Visibility = Visibility.Visible;
            p2m5.Visibility = Visibility.Visible;
            p2m6.Visibility = Visibility.Visible;
            p2m7.Visibility = Visibility.Visible;
            p2m8.Visibility = Visibility.Visible;
            p2m9.Visibility = Visibility.Visible;
            p2m10.Visibility = Visibility.Visible;
            p2t1.Visibility = Visibility.Visible;
            p2t2.Visibility = Visibility.Visible;
            p2t3.Visibility = Visibility.Visible;
            p2t4.Visibility = Visibility.Visible;
            p2t5.Visibility = Visibility.Visible;
            p2t6.Visibility = Visibility.Visible;
            p2t7.Visibility = Visibility.Visible;
        }

        private void Magerb1_Checked(object sender, RoutedEventArgs e)
        {
            Mage1.Visibility = Visibility.Visible;
            Tablero.Visibility = Visibility.Visible;
            txt22.Visibility = Visibility.Visible;
            txt12.Visibility = Visibility.Visible;
            terminar1.Visibility = Visibility.Visible;
           
            cristalp1.Visibility = Visibility.Visible;
            cristalp2.Visibility = Visibility.Visible;
            vidap1.Visibility = Visibility.Visible;
            vidap2.Visibility = Visibility.Visible;
            p1m1.Visibility = Visibility.Visible;
            p1m2.Visibility = Visibility.Visible;
            p1m3.Visibility = Visibility.Visible;
            p1m4.Visibility = Visibility.Visible;
            p1m5.Visibility = Visibility.Visible;
            p1m6.Visibility = Visibility.Visible;
            p1m7.Visibility = Visibility.Visible;
            p1m8.Visibility = Visibility.Visible;
            p1m9.Visibility = Visibility.Visible;
            p1m10.Visibility = Visibility.Visible;
            p1t1.Visibility = Visibility.Visible;
            p1t2.Visibility = Visibility.Visible;
            p1t3.Visibility = Visibility.Visible;
            p1t4.Visibility = Visibility.Visible;
            p1t5.Visibility = Visibility.Visible;
            p1t6.Visibility = Visibility.Visible;
            p1t7.Visibility = Visibility.Visible;
            p2m1.Visibility = Visibility.Visible;
            p2m2.Visibility = Visibility.Visible;
            p2m3.Visibility = Visibility.Visible;
            p2m4.Visibility = Visibility.Visible;
            p2m5.Visibility = Visibility.Visible;
            p2m6.Visibility = Visibility.Visible;
            p2m7.Visibility = Visibility.Visible;
            p2m8.Visibility = Visibility.Visible;
            p2m9.Visibility = Visibility.Visible;
            p2m10.Visibility = Visibility.Visible;
            p2t1.Visibility = Visibility.Visible;
            p2t2.Visibility = Visibility.Visible;
            p2t3.Visibility = Visibility.Visible;
            p2t4.Visibility = Visibility.Visible;
            p2t5.Visibility = Visibility.Visible;
            p2t6.Visibility = Visibility.Visible;
            p2t7.Visibility = Visibility.Visible;
        }

        private void Warriorrb_Checked(object sender, RoutedEventArgs e)
        {
            Warrior1.Visibility = Visibility.Visible;
            Tablero.Visibility = Visibility.Visible;
            txt22.Visibility = Visibility.Visible;
            txt12.Visibility = Visibility.Visible;
            terminar1.Visibility = Visibility.Visible;
           
            cristalp1.Visibility = Visibility.Visible;
            cristalp2.Visibility = Visibility.Visible;
            vidap1.Visibility = Visibility.Visible;
            vidap2.Visibility = Visibility.Visible;
            p1m1.Visibility = Visibility.Visible;
            p1m2.Visibility = Visibility.Visible;
            p1m3.Visibility = Visibility.Visible;
            p1m4.Visibility = Visibility.Visible;
            p1m5.Visibility = Visibility.Visible;
            p1m6.Visibility = Visibility.Visible;
            p1m7.Visibility = Visibility.Visible;
            p1m8.Visibility = Visibility.Visible;
            p1m9.Visibility = Visibility.Visible;
            p1m10.Visibility = Visibility.Visible;
            p1t1.Visibility = Visibility.Visible;
            p1t2.Visibility = Visibility.Visible;
            p1t3.Visibility = Visibility.Visible;
            p1t4.Visibility = Visibility.Visible;
            p1t5.Visibility = Visibility.Visible;
            p1t6.Visibility = Visibility.Visible;
            p1t7.Visibility = Visibility.Visible;
            p2m1.Visibility = Visibility.Visible;
            p2m2.Visibility = Visibility.Visible;
            p2m3.Visibility = Visibility.Visible;
            p2m4.Visibility = Visibility.Visible;
            p2m5.Visibility = Visibility.Visible;
            p2m6.Visibility = Visibility.Visible;
            p2m7.Visibility = Visibility.Visible;
            p2m8.Visibility = Visibility.Visible;
            p2m9.Visibility = Visibility.Visible;
            p2m10.Visibility = Visibility.Visible;
            p2t1.Visibility = Visibility.Visible;
            p2t2.Visibility = Visibility.Visible;
            p2t3.Visibility = Visibility.Visible;
            p2t4.Visibility = Visibility.Visible;
            p2t5.Visibility = Visibility.Visible;
            p2t6.Visibility = Visibility.Visible;
            p2t7.Visibility = Visibility.Visible;

        }

        private void Warlocrb_Checked(object sender, RoutedEventArgs e)
        {
            Warloc1.Visibility = Visibility.Visible;
            Tablero.Visibility = Visibility.Visible;
            txt22.Visibility = Visibility.Visible;
            txt12.Visibility = Visibility.Visible;
            terminar1.Visibility = Visibility.Visible;
           
            cristalp1.Visibility = Visibility.Visible;
            cristalp2.Visibility = Visibility.Visible;
            vidap1.Visibility = Visibility.Visible;
            vidap2.Visibility = Visibility.Visible;
            p1m1.Visibility = Visibility.Visible;
            p1m2.Visibility = Visibility.Visible;
            p1m3.Visibility = Visibility.Visible;
            p1m4.Visibility = Visibility.Visible;
            p1m5.Visibility = Visibility.Visible;
            p1m6.Visibility = Visibility.Visible;
            p1m7.Visibility = Visibility.Visible;
            p1m8.Visibility = Visibility.Visible;
            p1m9.Visibility = Visibility.Visible;
            p1m10.Visibility = Visibility.Visible;
            p1t1.Visibility = Visibility.Visible;
            p1t2.Visibility = Visibility.Visible;
            p1t3.Visibility = Visibility.Visible;
            p1t4.Visibility = Visibility.Visible;
            p1t5.Visibility = Visibility.Visible;
            p1t6.Visibility = Visibility.Visible;
            p1t7.Visibility = Visibility.Visible;
            p2m1.Visibility = Visibility.Visible;
            p2m2.Visibility = Visibility.Visible;
            p2m3.Visibility = Visibility.Visible;
            p2m4.Visibility = Visibility.Visible;
            p2m5.Visibility = Visibility.Visible;
            p2m6.Visibility = Visibility.Visible;
            p2m7.Visibility = Visibility.Visible;
            p2m8.Visibility = Visibility.Visible;
            p2m9.Visibility = Visibility.Visible;
            p2m10.Visibility = Visibility.Visible;
            p2t1.Visibility = Visibility.Visible;
            p2t2.Visibility = Visibility.Visible;
            p2t3.Visibility = Visibility.Visible;
            p2t4.Visibility = Visibility.Visible;
            p2t5.Visibility = Visibility.Visible;
            p2t6.Visibility = Visibility.Visible;
            p2t7.Visibility = Visibility.Visible;
        }

        private void Paladinrb1_Checked(object sender, RoutedEventArgs e)
        {
            Paladin1.Visibility = Visibility.Visible;
            Tablero.Visibility = Visibility.Visible;
            txt22.Visibility = Visibility.Visible;
            txt12.Visibility = Visibility.Visible;
            terminar1.Visibility = Visibility.Visible;

            cristalp1.Visibility = Visibility.Visible;
            cristalp2.Visibility = Visibility.Visible;
            vidap1.Visibility = Visibility.Visible;
            vidap2.Visibility = Visibility.Visible;
            p1m1.Visibility = Visibility.Visible;
            p1m2.Visibility = Visibility.Visible;
            p1m3.Visibility = Visibility.Visible;
            p1m4.Visibility = Visibility.Visible;
            p1m5.Visibility = Visibility.Visible;
            p1m6.Visibility = Visibility.Visible;
            p1m7.Visibility = Visibility.Visible;
            p1m8.Visibility = Visibility.Visible;
            p1m9.Visibility = Visibility.Visible;
            p1m10.Visibility = Visibility.Visible;
            p1t1.Visibility = Visibility.Visible;
            p1t2.Visibility = Visibility.Visible;
            p1t3.Visibility = Visibility.Visible;
            p1t4.Visibility = Visibility.Visible;
            p1t5.Visibility = Visibility.Visible;
            p1t6.Visibility = Visibility.Visible;
            p1t7.Visibility = Visibility.Visible;
            p2m1.Visibility = Visibility.Visible;
            p2m2.Visibility = Visibility.Visible;
            p2m3.Visibility = Visibility.Visible;
            p2m4.Visibility = Visibility.Visible;
            p2m5.Visibility = Visibility.Visible;
            p2m6.Visibility = Visibility.Visible;
            p2m7.Visibility = Visibility.Visible;
            p2m8.Visibility = Visibility.Visible;
            p2m9.Visibility = Visibility.Visible;
            p2m10.Visibility = Visibility.Visible;
            p2t1.Visibility = Visibility.Visible;
            p2t2.Visibility = Visibility.Visible;
            p2t3.Visibility = Visibility.Visible;
            p2t4.Visibility = Visibility.Visible;
            p2t5.Visibility = Visibility.Visible;
            p2t6.Visibility = Visibility.Visible;
            p2t7.Visibility = Visibility.Visible;
        }

        private void Priest1_Checked(object sender, RoutedEventArgs e)
        {
            Priest1.Visibility = Visibility.Visible;
            Tablero.Visibility = Visibility.Visible;
            txt22.Visibility = Visibility.Visible;
            txt12.Visibility = Visibility.Visible;
            terminar1.Visibility = Visibility.Visible;
         
            cristalp1.Visibility = Visibility.Visible;
            cristalp2.Visibility = Visibility.Visible;
            vidap1.Visibility = Visibility.Visible;
            vidap2.Visibility = Visibility.Visible;
            p1m1.Visibility = Visibility.Visible;
            p1m2.Visibility = Visibility.Visible;
            p1m3.Visibility = Visibility.Visible;
            p1m4.Visibility = Visibility.Visible;
            p1m5.Visibility = Visibility.Visible;
            p1m6.Visibility = Visibility.Visible;
            p1m7.Visibility = Visibility.Visible;
            p1m8.Visibility = Visibility.Visible;
            p1m9.Visibility = Visibility.Visible;
            p1m10.Visibility = Visibility.Visible;
            p1t1.Visibility = Visibility.Visible;
            p1t2.Visibility = Visibility.Visible;
            p1t3.Visibility = Visibility.Visible;
            p1t4.Visibility = Visibility.Visible;
            p1t5.Visibility = Visibility.Visible;
            p1t6.Visibility = Visibility.Visible;
            p1t7.Visibility = Visibility.Visible;
            p2m1.Visibility = Visibility.Visible;
            p2m2.Visibility = Visibility.Visible;
            p2m3.Visibility = Visibility.Visible;
            p2m4.Visibility = Visibility.Visible;
            p2m5.Visibility = Visibility.Visible;
            p2m6.Visibility = Visibility.Visible;
            p2m7.Visibility = Visibility.Visible;
            p2m8.Visibility = Visibility.Visible;
            p2m9.Visibility = Visibility.Visible;
            p2m10.Visibility = Visibility.Visible;
            p2t1.Visibility = Visibility.Visible;
            p2t2.Visibility = Visibility.Visible;
            p2t3.Visibility = Visibility.Visible;
            p2t4.Visibility = Visibility.Visible;
            p2t5.Visibility = Visibility.Visible;
            p2t6.Visibility = Visibility.Visible;
            p2t7.Visibility = Visibility.Visible;
        }

        private void infoPriest1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Este heroe es un sacerdote de la epoca medieval, es muy conocido en las tierras de Azeroth ya que hace mucho tiempo dio su vida para revevir al fenix sagrado de la region y asi salvo a la habitantes de ventormenta de una peste verde. Por eso su habilidad especial es restaurar 2 de vida en honor a esta gran hazaña");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pergamino.Visibility = Visibility.Visible;
            titulo.Visibility = Visibility.Hidden;
            Hola.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Eleccion1.Visibility = Visibility.Visible;
            infodruid.Visibility = Visibility.Visible;
            infomage.Visibility = Visibility.Visible;
            infopriest.Visibility = Visibility.Visible;
            infopaladin.Visibility = Visibility.Visible;
            inforouge.Visibility = Visibility.Visible;
            infoshaman.Visibility = Visibility.Visible;
            inforexxar.Visibility = Visibility.Visible;
            infowarloc.Visibility = Visibility.Visible;
            infowarrior.Visibility = Visibility.Visible;
            Magerb.Visibility = Visibility.Visible;
            Rexxarb.Visibility = Visibility.Visible;
            Priestrb.Visibility = Visibility.Visible;
            Rougerb.Visibility = Visibility.Visible;
            druidb.Visibility = Visibility.Visible;
            shamanb.Visibility = Visibility.Visible;
            warlocb.Visibility = Visibility.Visible;
            warriorb.Visibility = Visibility.Visible;
            paladinb.Visibility = Visibility.Visible;
            titulo.Visibility = Visibility.Hidden;
            Bienvenidad2.Visibility = Visibility.Hidden;
            Escudo.Visibility = Visibility.Hidden;
            pergamino.Visibility = Visibility.Hidden;
            Hola.Visibility = Visibility.Hidden;
            Jugar.Visibility = Visibility.Hidden;
            ins.Visibility = Visibility.Hidden;
        }

        private void continuar_Click(object sender, RoutedEventArgs e)
        {
            Bienvenidad2.Visibility = Visibility.Visible;
            Jugar.Visibility = Visibility.Visible;
            ins.Visibility = Visibility.Visible;
            Escudo.Visibility = Visibility.Visible;
            titulo.Visibility = Visibility.Visible;

        }
    }

    }
