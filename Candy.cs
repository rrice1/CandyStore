namespace candy_market
{
    internal class Candy
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Flavor { get; set; }
        public string Category { get; set; }
        public string DateReceived { get; set; }
        public int CandyId { get; set; }
    }

    internal class CandyOwners
    {
        public string Name { get; set; }
        public int CandyId { get; set; }
    }

    // Constructor
}