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
            Weight = random.Next(10);
            Value = random.Next(10);
            Ratio = Value / Weight;
        }
    }
}



//uszeregowac sobie potem elementu w tej liście malejąco, potem od mojej okreslonej wagi odejmowac aktualny przedmiot.
