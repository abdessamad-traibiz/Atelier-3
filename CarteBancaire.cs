using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    class CarteBancaire
    {
        static int Cpt;
        int CodeCarteBan;
        string TypeCarteBan;
        public CarteBancaire(string TypeCarte)
        {
            this.code = ++Cpt;
            this.TypeCarteBan = TypeCarte;
        }
    }
}
