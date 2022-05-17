using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Entiteti
{
    public class Pakovanje
    {
        public virtual int IdPakovanja { get; protected set; }
        public virtual string VrstaPakovanja { get; set; }
    }
}
