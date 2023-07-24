namespace Tupla
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<Data>()
            {
                new Data(01, 2023),
                new Data(02, 2023),
                new Data(02, 2023),
                new Data(02, 2023),
                new Data(01, 2024),
            };

            var dataDistinct = collection.Select(s => (s.Month, s.Year)).Distinct();
            var validate = dataDistinct.Count() == 1;
        }

        public record Data (int Month, int Year);
    }
}
