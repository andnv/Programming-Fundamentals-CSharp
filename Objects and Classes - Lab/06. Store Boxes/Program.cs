namespace _06._Store_Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Markup;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] boxInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int quantity = int.Parse(boxInfo[2]);
                decimal price = decimal.Parse(boxInfo[3]);

                Item item = new Item(itemName, price);
                Box box = new Box(serialNumber, item, quantity);

                boxes.Add(box);
            }

            foreach (var box in boxes.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PricePerBox:F2}");
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = itemQuantity;
        }

        public string SerialNumber { get; set; }

        public Item Item{ get; set; }

        public int Quantity { get; set; }

        public decimal PricePerBox 
        {
            get 
            {
                return Quantity * Item.Price;
            }
        }

    }
}
