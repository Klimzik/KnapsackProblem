namespace KnapsackProblem
{
    public class Result
    {
        public int TotalWeight { get; set; } = 0;
        public int TotalValue { get; set; } = 0;
        public List<Item> ResultItems { get; set; } = new List<Item>();

        public Result() { }

        public void Display() 
        {
            Console.WriteLine("Wartość przedmitów w plecaku: "+ TotalValue);
            Console.WriteLine("Waga przedmiotów w plecaku: "+ TotalWeight);

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
