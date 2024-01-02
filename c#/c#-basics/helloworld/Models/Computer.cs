using System.Text.Json.Serialization;

namespace HelloWorld.Models
{

    public class Computer
    {
        [JsonPropertyName("computer_id")]
        public int ComputerId { get; set; }

        [JsonPropertyName("motherboard")]
        public string Motherboard { get; set; }

        [JsonPropertyName("has_wifi")]
        public bool HasWifi { get; set; }

        [JsonPropertyName("has_lte")]
        public bool HasLTE { get; set; }

        [JsonPropertyName("release_date")]
        public DateTime? ReleaseDate { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("video_card")]
        public string VideoCard { get; set; }

        public Computer()
        {

            // applying empty string to (String) variables that have a null value
            if (Motherboard == null)
            {
                Motherboard = "";
            }

            if (VideoCard == null)
            {
                VideoCard = "";
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
            Console.WriteLine($"ComputerId: {ComputerId}");
            Console.WriteLine($"MotherBoard: {Motherboard}");
            Console.WriteLine($"HasWifi: {HasWifi}");
            Console.WriteLine($"HasLTE: {HasLTE}");
            Console.WriteLine($"ReleaseDate: {ReleaseDate}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"VideoCard: {VideoCard}");
        }

    }
}