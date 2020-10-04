using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Puygrenier_Solann
{
    public class ArmurerieException : System.Exception{
        public ArmurerieException() : base(){}
        public ArmurerieException(string message) : base(message) { }
    }
}
