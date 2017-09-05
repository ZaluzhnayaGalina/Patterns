namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new AnalyzingNumbers();
            numbers.Print();
            numbers.Sort();
            numbers.Print();
            System.Console.ReadKey(true);
        }
    }
}
