namespace HelloWorld.Models
{

    public class Computer
    {

        public int ComputerId { get; set; }
        public string MotherBoard { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }

        public string VideoCard { get; set; }

        public Computer()
        {

            // applying empty string to (String) variables that have a null value
            if (MotherBoard == null)
            {
                MotherBoard = "";
            }

            if (VideoCard == null)
            {
                VideoCard = "";
            }

        }

        // Just to check which of the properties have a null value
        public void getProperties()
        {
            // if (Compu)
            Console.WriteLine($"ComputerId: {ComputerId}");
            Console.WriteLine($"MotherBoard: {MotherBoard}");
            Console.WriteLine($"HasWifi: {HasWifi}");
            Console.WriteLine($"HasLTE: {HasLTE}");
            Console.WriteLine($"ReleaseDate: {ReleaseDate}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"VideoCard: {VideoCard}");
        }

    }
}