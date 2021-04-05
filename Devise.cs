using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class Devise:IEuros,IDollars
    {
        double Valeur;
        double ValEuros = 10.66, ValDollars = 9.06;

        public Devise(double ValDev)
        {
            this.Valeur=ValDev
        }

        public Devise ToDollars(MAD somme) 
            return new Devise(somme.Conversion(ValDollars));
        public Devise ToEuros(MAD somme)
            return new Devise(somme.Conversion(ValEuros));

    }
}
