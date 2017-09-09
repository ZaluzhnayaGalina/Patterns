namespace Decorator.Clothes
{
    class Skirt : Garment
    {
        private string _puttingOn = "Put on skirt";

        public override string PutOn()
        {
            return _puttingOn;
        }
    }
}
