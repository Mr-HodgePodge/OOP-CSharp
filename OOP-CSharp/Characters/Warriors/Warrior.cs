namespace Characters.Warriors
{
    public class Warrior
    {
        // fields
        private int height;
        private int weight;
        private string name;

        // Properties
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        public Warrior(int height, int weight, string name)
        {
            Height = height;
            Weight = weight;
            Name = name;
        }

        public void Greet(Warrior warrior)
        {
            Console.WriteLine($@"Greetings, {warrior.Name}!");
        }
    }
}