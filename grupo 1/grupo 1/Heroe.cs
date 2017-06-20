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
        public int _VidaMax;
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
        public int VidaMax
        {
            get { return _VidaMax; }
            set { _VidaMax = value; }
        }

        public Heroe(string nomH, int LP, string PoderH, int Armor, int LPMax)
        {
            NombreH = nomH;
            PtVida = LP;
            PoderHeroe = PoderH;
            ArmaduraH = Armor;
            VidaMax = LPMax;

        }

        public virtual void HabilidadHeroe()
        {

        }

    }
    public class Warrior : Heroe
    {

        public Warrior(string nomH, int LP, string PoderH, int Armor, int LPMax)
            : base(nomH, LP, PoderH, Armor, LPMax)
        {
        }

        public override void HabilidadHeroe()
        {
            ArmaduraH = ArmaduraH + 2;
        }


    }
    public class Hunter : Heroe
    {

        public Hunter(string nomH, int LP, string PoderH, int Armor, int LPMax)
            : base(nomH, LP, PoderH, Armor, LPMax)
        {


        }
        public override void HabilidadHeroe()
        {

        }

    }
    public class Druida : Heroe
    {

        public Druida(string nomH, int LP, string PoderH, int Armor, int LPMax)
            : base(nomH, LP, PoderH, Armor, LPMax)
        {


        }
        public override void HabilidadHeroe()
        {

        }

    }
    public class Mago : Heroe
    {

        public Mago(string nomH, int LP, string PoderH, int Armor, int LPMax)
            : base(nomH, LP, PoderH, Armor, LPMax)
        {


        }
        public override void HabilidadHeroe()
        {

        }

    }
    public class Paladin : Heroe
    {

        public Paladin(string nomH, int LP, string PoderH, int Armor, int LPMax)
            : base(nomH, LP, PoderH, Armor, LPMax)
        {


        }

    }
    public class Sacerdote : Heroe
    {

        public Sacerdote(string nomH, int LP, string PoderH, int Armor, int LPMax)
            : base(nomH, LP, PoderH, Armor, LPMax)
        {


        }
        public override void HabilidadHeroe()
        {

        }

    }
    public class Picaro : Heroe
    {

        public Picaro(string nomH, int LP, string PoderH, int Armor, int LPMax)
            : base(nomH, LP, PoderH, Armor, LPMax)
        {


        }
        public override void HabilidadHeroe()
        {

        }

    }
    public class Chaman : Heroe
    {

        public Chaman(string nomH, int LP, string PoderH, int Armor, int LPMax)
            : base(nomH, LP, PoderH, Armor, LPMax)
        {


        }
        public override void HabilidadHeroe()
        {

        }

    }
    public class Brujo : Heroe
    {

        public Brujo(string nomH, int LP, string PoderH, int Armor, int LPMax)
            : base(nomH, LP, PoderH, Armor, LPMax)
        {


        }
        public override void HabilidadHeroe()
        {

        }

    }
}
