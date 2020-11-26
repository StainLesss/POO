using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class ArmurerieException : System.Exception{
        public ArmurerieException() : base(){}
        public ArmurerieException(string message) : base(message) { }
    }
}
