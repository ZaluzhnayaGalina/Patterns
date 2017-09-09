using System;

namespace Decorator.Clothes
{
    class Cardigan : Garment
    {
        private string _puttingOn = "Put on cardigan";
        public override string PutOn()
        {
            return _puttingOn;
        }
    }
}
