namespace KnapsackProblem
{
    public class Item
    {
        public int Value { get; set; }
        public int Weight{ get; set; }
        public double Ratio { get; set; }

        public Item(int seed) 
        {
            Random random = new Random();
            Weight = random.Next(1,10);
            Value = random.Next(1, 10);
            Ratio = Value / Weight;
        }
    }
}