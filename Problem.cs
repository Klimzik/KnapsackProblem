namespace KnapsackProblem
{
    public class Problem
    {
        public int n { get; set; }
        public int Seed { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public Problem(int capacity = 20,int n = 10, int seed = 10) 
        { 
            for (int i = 0; i < n; i++)
            {
                Items.Add(new Item(seed));
            }
            Solve(capacity);
        }

        public Result Solve (int capacity)
        {
            Result result = new Result();

            Items = Items.OrderBy(item => item.Ratio).ToList();

            foreach (var item in Items)
            {
                if(capacity - item.Weight >= 0)
                {
                    result.ResultItems.Add(item);
                    result.TotalValue += item.Value;
                    result.TotalWeight += item.Weight;
                    capacity -= item.Weight;
                }
            }
            result.Display();
            return result;
        }
    }
}
