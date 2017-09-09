namespace Decorator.Clothes
{
    class Stockings : Accessories
    {
        private string _puttingOn;
        private Garment _decoratee;
        public Stockings(Garment decoratee)
        {
            _puttingOn = ", stockings";
            _decoratee = decoratee;
        }

        public override string PutOn()
        {
            return _decoratee.PutOn() + _puttingOn;
        }
    }
}
