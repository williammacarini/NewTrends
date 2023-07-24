namespace FuncAndAction
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[]
            {
                "William", "Camila", "Enzo", "Chanel"
            };

            Action<string> AddNames = (string name) =>
            {
                Array.Resize(ref names, names.Count() + 1);
                names[names.Count()] = name;
            };

            string findName(string name) => names.FirstOrDefault(f => f == name) ?? "Not Found!";

            var name = findName("Vanda");
            Console.WriteLine(name);
        }
    }
}