namespace day9v7
{
    public class Cat
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public Toy FavouriteToy { get; set; }
        public List<Food> FoodsThatItEats { get; set; }

        public void Report()
        {
            Console.WriteLine($"My name is {Name}, this is what people think of me: {Description}");
            Console.WriteLine($"I weight {Weight} gramms");
            if(FavouriteToy != null)
            {
                Console.WriteLine($"My favorite toy is {FavouriteToy.Name}, it costs {FavouriteToy.Price}");
            }
            if(FoodsThatItEats != null)
            {
                Console.WriteLine("I like following foods:");
                foreach (var food in FoodsThatItEats)
                {
                    Console.WriteLine($"{food.Name} that has {food.Nutrition} kcal");
                }
            }


        }
    }
}
