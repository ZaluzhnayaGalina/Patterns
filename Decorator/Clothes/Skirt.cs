using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Clothes
{
    class Skirt : Garment
    { 
        private string _puttingOn = "Put on skirt"
        public override string PutOn()
        {
            return _puttingOn;
        }
    }
}
