namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string serialNubmer = commandInfo[0];
                string itemName = commandInfo[1];
                int itemQuantity = int.Parse(commandInfo[2]);
                decimal itemPrice = decimal.Parse(commandInfo[3]);

                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;

                Box box = new Box();
                box.SerialNumber = serialNubmer;
                box.ItemQuantity = itemQuantity;
                box.Item = item;

                boxes.Add(box);

                command = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(x => x.PriceForOneBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForOneBox:F2}");
            }
        }
    }
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForOneBox => Item.Price * ItemQuantity;

        //public override bool Equals (object? obj)
        //{
        //    var objBox = obj as Box;

        //    if(this.SerialNumber == objBox.SerialNumber)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

    }
}