namespace Decorator.Clothes
{
    class Dress : Garment
    {
        string _puttingOn = "Put on dress";
        public override string PutOn()
        {
            return _puttingOn;
        }
    }
}
