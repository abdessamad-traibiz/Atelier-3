using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2
{
    interface IEuros
    {

        Devise ToEuros(MAD somme);
    }
}
