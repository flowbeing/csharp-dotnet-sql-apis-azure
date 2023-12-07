namespace HelloWorld.Models
{

    public class ComputerSnake
    {

        public int computer_id { get; set; }
        public string motherboard { get; set; }
        public bool has_wifi { get; set; }
        public bool has_lte { get; set; }
        public DateTime? release_date { get; set; }

        public decimal price { get; set; }

        public string video_card { get; set; }

        public ComputerSnake()
        {

            // applying empty string to (String) variables that have a null value
            if (motherboard == null)
            {
                motherboard = "";
            }

            if (video_card == null)
            {
                video_card = "";
            }
            // if (ReleaseDate == null)
            // {
            //     ReleaseDate = ""
            // }

        }

        // Just to check which of the properties have a null value
        public void getProperties()
        {
            // if (Compu)
            Console.WriteLine($"computer_id: {computer_id}");
            Console.WriteLine($"motherboard: {motherboard}");
            Console.WriteLine($"has_wifi: {has_wifi}");
            Console.WriteLine($"has_lte: {has_lte}");
            Console.WriteLine($"release_date: {release_date}");
            Console.WriteLine($"price: {price}");
            Console.WriteLine($"video_card: {video_card}");
        }

    }
}