// USING AUTOMAPPER TO CONVERT OBJECTS FROM ONE FORM TO ANTOEHR 

using System.Text.Json;
using AutoMapper;

using HelloWorld.Models;


namespace HelloWorld
{

    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            string computerSnakeCase = File.ReadAllText("ComputersSnake.json");

            IEnumerable<ComputerSnake>? computersSnakeCaseIEnumerable = JsonSerializer.Deserialize<IEnumerable<ComputerSnake>>(computerSnakeCase);

            // Creating a Mapper => ComputerSnake (object) to Computer (object)
            AutoMapper.Mapper mapper = new AutoMapper.Mapper(new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ComputerSnake, Computer>()
                    .ForMember(
                        destination => destination.ComputerId,
                        options => options.MapFrom(source => source.computer_id))
                    .ForMember(
                        destination => destination.Motherboard,
                        options => options.MapFrom(source => source.motherboard)
                    )
                    .ForMember(
                        destination => destination.HasWifi,
                        options => options.MapFrom(source => source.has_wifi)
                    )
                    .ForMember(
                        destination => destination.HasLTE,
                        options => options.MapFrom(source => source.has_lte)
                    )
                    .ForMember(
                        destination => destination.ReleaseDate,
                        options => options.MapFrom(source => source.release_date)
                    )
                    .ForMember(
                        destination => destination.VideoCard,
                        options => options.MapFrom(source => source.video_card)
                    );
            }));


            if (computersSnakeCaseIEnumerable != null)
            {

                IEnumerable<Computer> computersIEnumerable = mapper.Map<IEnumerable<Computer>>(computersSnakeCaseIEnumerable);

                // foreach (ComputerSnake computerSnake in computersSnakeCaseIEnumerable)
                // {

                //     Console.WriteLine($"{computerSnake.computer_id}, {computerSnake.motherboard}, {computerSnake.has_wifi}, {computerSnake.has_lte}, {computerSnake.release_date}, {computerSnake.video_card}");

                // }

                foreach (Computer computer in computersIEnumerable)
                {

                    Console.WriteLine($"{computer.ComputerId}, {computer.Motherboard}, {computer.HasWifi}, {computer.HasLTE}, {computer.ReleaseDate}, {computer.VideoCard}");

                }
            }

        }
    }
}