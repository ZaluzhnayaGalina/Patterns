namespace Decorator
{
    class Scarf : Accessories
    {
        private Garment _decoratee;
        private string _puttingOn = ", scarf";
        public Scarf(Garment decoratee)
        {
            _decoratee = decoratee;
        }

        public override string PutOn()
        {
            return _decoratee.PutOn() + _puttingOn;
        }
    }
}
