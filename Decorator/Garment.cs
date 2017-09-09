using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class Garment
    {
        private string _puttingOn;
        public abstract string PutOn();
    }
}
