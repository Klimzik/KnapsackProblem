namespace KnapsackProblem
{
    public class Item
    {
        public int NumberOfItems { get; set; }
        public List<bool> Value { get; set; } = new List<bool>();
        public List<int> Weight { get; set; } = new List<int>();

        public Item(int n, int seed = 5) 
        {
            Random random = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                Weight.Add(random.Next(10));
            }
            NumberOfItems = n;
        }
    }
}



//uszeregowac sobie potem elementu w tej liście malejąco, potem od mojej okreslonej wagi odejmowac aktualny przedmiot.
