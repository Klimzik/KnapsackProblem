namespace KnapsackProblem
{
    public class Result
    {
        public int TotalWeight { get; set; } = 0;
        public int TotalValue { get; set; } = 0;
        public List<Item> ResultItems { get; set; } = new List<Item>();

        public Result() { }

        public void display() 
        {
            Console.WriteLine("Wartość przedmitów w plecaku: ");
            Console.WriteLine(TotalValue);
            Console.WriteLine("Waga przedmiotów w plecaku: ");
            Console.WriteLine(TotalWeight);

            foreach (var item in ResultItems)
            {
                Console.WriteLine("Wartość: " + item.Value + ". Waga: " + item.Weight);
            }
        }
        public override string ToString()
        {
            return TotalWeight.ToString();
        }
    }
}
