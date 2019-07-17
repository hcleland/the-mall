using System;

namespace TheMall
{
    class Program
    {
        static void Main(string[] args)
        {
            DollarStore Dollarama = new DollarStore();
            DollarItem MultiColorPen = new DollarItem()
            {
                Name = "Multi Colored Pen with 12 Colors"
            };

            Dollarama.AddToInventory("multi-colored pen", MultiColorPen);

            FoodStore Cinnabon = new FoodStore();

            FoodItem ClassicRoll = new FoodItem()
            {
                Name = "The Classic Roll",
                Price = 3.50,
                Calories = 880
            };

            FoodItem CaramelPecanBon = new FoodItem()
            {
                Name = "Caramel Pecanbon",
                Price = 6,
                Calories = 1080
            };

            Cinnabon.AddToInventory("Classic Roll", ClassicRoll);

            Cinnabon.AddToInventory("Caramel Pecanbon", CaramelPecanBon);

            Console.WriteLine(Dollarama.GetFromInventory("multi-colored pen").Name);
            Console.WriteLine(Cinnabon.GetFromInventory("Classic Roll").Name);
        }
    }
}
